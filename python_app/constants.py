"""Runtime helpers shared across the Python implementation."""
from __future__ import annotations

from dataclasses import dataclass
from pathlib import Path
from threading import Lock
from typing import List, Optional


@dataclass
class PushOperation:
    """Representation of a pending data operation."""

    operation: str
    table: str
    payload: dict
    primary_keys: List[str]
    added_at: Optional[str] = None
    status: int = 0
    error_count: int = 0
    raw_json: Optional[str] = None


class AppState:
    """Container for runtime state similar to the C# ``Constant`` class."""

    def __init__(self) -> None:
        self._lock = Lock()
        self.operations: List[PushOperation] = []
        self.connection_user: str = ""
        self.db_client = None

    def reset_operations(self) -> None:
        with self._lock:
            self.operations.clear()

    def add_operation(self, op: PushOperation) -> None:
        with self._lock:
            self.operations.append(op)

    def get_operations(self) -> List[PushOperation]:
        with self._lock:
            return list(self.operations)


STATE = AppState()


def ensure_sql_directory() -> Path:
    """Return the directory that stores generated SQL files."""

    sql_dir = Path.cwd() / "SQL"
    sql_dir.mkdir(parents=True, exist_ok=True)
    return sql_dir


__all__ = ["PushOperation", "STATE", "ensure_sql_directory"]
