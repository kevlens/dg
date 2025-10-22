"""Database access layer for the Python port."""
from __future__ import annotations

import contextlib
import logging
import threading
import time
from dataclasses import asdict
from datetime import datetime
from typing import Iterable, List, Optional

from . import constants
from .models import Device, Section, SectionLine

try:
    import pyodbc  # type: ignore
except Exception:  # pragma: no cover - optional dependency
    pyodbc = None

LOGGER = logging.getLogger(__name__)


class DatabaseError(RuntimeError):
    """Raised when the toolkit cannot perform a database operation."""


class DBService:
    """Wrapper around a pyodbc connection.

    The original application used SqlSugar, an ORM for .NET.  Python does not
    ship with a direct equivalent, so the port relies on ``pyodbc``.  The class
    exposes a very small API that mirrors the data access needs from the WinForms
    implementation.
    """

    def __init__(self, connection_string: str) -> None:
        if pyodbc is None:
            raise DatabaseError(
                "pyodbc is required for database access. Install it with 'pip install pyodbc'."
            )

        try:
            self._conn = pyodbc.connect(connection_string)
        except Exception as exc:  # pragma: no cover - requires database
            raise DatabaseError(f"Failed to open database connection: {exc}") from exc

        self._keepalive_thread: Optional[threading.Thread] = None
        self._keepalive_stop = threading.Event()

    # ------------------------------------------------------------------
    # keep-alive handling
    def start_keepalive(self, section_id: str = "pxg-dyd") -> None:
        """Start a background thread that mimics the WinForms status update loop."""

        if self._keepalive_thread and self._keepalive_thread.is_alive():
            return

        def _run() -> None:
            sql = (
                "UPDATE BROKENRAIL_SECTION_STATUS_KF "
                "SET SECTION_STATUS = '正常', RECORD_TIME = ? WHERE SECTION_ID = ?"
            )
            while not self._keepalive_stop.is_set():
                try:
                    with contextlib.closing(self._conn.cursor()) as cur:
                        cur.execute(sql, time.strftime("%Y-%m-%d %H:%M:%S"), section_id)
                        self._conn.commit()
                except Exception as exc:  # pragma: no cover - requires database
                    LOGGER.warning("Keep-alive update failed: %s", exc)
                self._keepalive_stop.wait(30)

        thread = threading.Thread(target=_run, name="keepalive", daemon=True)
        self._keepalive_thread = thread
        thread.start()

    def stop_keepalive(self) -> None:
        self._keepalive_stop.set()
        if self._keepalive_thread and self._keepalive_thread.is_alive():
            self._keepalive_thread.join(timeout=1)

    # ------------------------------------------------------------------
    # query helpers
    def fetch_sections(self) -> List[Section]:  # pragma: no cover - requires database
        sql = (
            "SELECT SECTION_ID, SECTION_NAME, DEPT_CODE, END_SCALER_INDEX, END_MILE, "
            "ENVIRONMENT_VOL, GC_VOL, LINE_DIR, LINE_NAME, START_SCALER_INDEX, "
            "START_MILE, STATION_STATION FROM BROKENRAIL_BDATA_SECTION ORDER BY SECTION_NAME"
        )
        with contextlib.closing(self._conn.cursor()) as cur:
            rows = cur.execute(sql).fetchall()
        sections = []
        for row in rows:
            sections.append(
                Section(
                    SECTION_ID=row.SECTION_ID,
                    SECTION_NAME=row.SECTION_NAME,
                    DEPT_CODE=row.DEPT_CODE or "",
                    END_SCALER_INDEX=row.END_SCALER_INDEX or "",
                    END_MILE=row.END_MILE or "",
                    ENVIRONMENT_VOL=row.ENVIRONMENT_VOL or "",
                    GC_VOL=row.GC_VOL or "",
                    LINE_DIR=row.LINE_DIR or "",
                    LINE_NAME=row.LINE_NAME or "",
                    START_SCALER_INDEX=row.START_SCALER_INDEX or "",
                    START_MILE=row.START_MILE or "",
                    STATION_STATION=row.STATION_STATION or "",
                )
            )
        return sections

    def fetch_devices(self, section_id: str) -> List[Device]:  # pragma: no cover - requires database
        sql = (
            "SELECT * FROM BROKENRAIL_BDATA_DEVICE WHERE SECTION_ID = ? ORDER BY MILEAGE_COORDINATE"
        )
        with contextlib.closing(self._conn.cursor()) as cur:
            rows = cur.execute(sql, section_id).fetchall()
        devices: List[Device] = []
        field_names = {
            name
            for name in Device.__dataclass_fields__.keys()
            if name not in {"TABLE_NAME", "PRIMARY_KEYS"}
        }
        for row in rows:
            payload = {}
            for field in field_names:
                payload[field] = getattr(row, field, None)
            payload = {
                key: (value if value not in ("", None) else None)
                for key, value in payload.items()
            }
            devices.append(Device(**payload))
        return devices

    def fetch_section_line(self, point_no: str) -> Optional[SectionLine]:  # pragma: no cover - requires database
        sql = "SELECT * FROM BROKENRAIL_SECTION_LINE WHERE POINT_NO = ?"
        with contextlib.closing(self._conn.cursor()) as cur:
            row = cur.execute(sql, point_no).fetchone()
        if row is None:
            return None
        field_names = {
            name
            for name in SectionLine.__dataclass_fields__.keys()
            if name not in {"TABLE_NAME", "PRIMARY_KEYS"}
        }
        payload = {field: getattr(row, field, None) for field in field_names}
        return SectionLine(**payload)

    # ------------------------------------------------------------------
    def queue_update(
        self,
        model: object,
        primary_keys: Iterable[str],
        *,
        changes: Optional[dict[str, str]] = None,
    ) -> None:
        payload = asdict(model)
        table_name = payload.pop("TABLE_NAME", model.__class__.__name__)
        payload.pop("PRIMARY_KEYS", None)
        constants.STATE.add_operation(
            constants.PushOperation(
                operation="UPDATE",
                table=table_name,
                payload=payload,
                primary_keys=list(primary_keys),
                added_at=datetime.now().strftime("%Y-%m-%d %H:%M:%S"),
                changes=dict(changes) if changes else None,
            )
        )

    def queue_insert(self, model: object, primary_keys: Iterable[str]) -> None:
        payload = asdict(model)
        table_name = payload.pop("TABLE_NAME", model.__class__.__name__)
        payload.pop("PRIMARY_KEYS", None)
        constants.STATE.add_operation(
            constants.PushOperation(
                operation="INSERT",
                table=table_name,
                payload=payload,
                primary_keys=list(primary_keys),
                added_at=datetime.now().strftime("%Y-%m-%d %H:%M:%S"),
            )
        )

    def queue_delete(self, table: str, payload: dict, primary_keys: Iterable[str]) -> None:
        constants.STATE.add_operation(
            constants.PushOperation(
                operation="DELETE",
                table=table,
                payload=payload,
                primary_keys=list(primary_keys),
                added_at=datetime.now().strftime("%Y-%m-%d %H:%M:%S"),
            )
        )

    def close(self) -> None:
        self.stop_keepalive()
        try:
            self._conn.close()
        except Exception:  # pragma: no cover - best effort cleanup
            LOGGER.debug("Ignoring error while closing the database connection", exc_info=True)


__all__ = ["DBService", "DatabaseError"]
