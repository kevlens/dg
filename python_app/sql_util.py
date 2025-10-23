"""Utility helpers for generating SQL scripts."""
from __future__ import annotations

import datetime as _dt
import json
from typing import Iterable

from .constants import PushOperation, ensure_sql_directory


def _escape(value: object) -> str:
    if value is None:
        return "NULL"
    if isinstance(value, (int, float)):
        return str(value)
    text = str(value)
    return "'" + text.replace("'", "''") + "'"


def _columns_and_values(payload: dict, db_type: str) -> tuple[str, str]:
    columns = []
    values = []
    for key, value in payload.items():
        columns.append(key)
        if value is None:
            values.append("''" if db_type == "ORA" else "NULL")
        else:
            values.append(_escape(value))
    return ",".join(columns), ",".join(values)


def build_insert_sql(table: str, payload: dict, db_type: str) -> str:
    cols, vals = _columns_and_values(payload, db_type)
    return f"INSERT INTO {table} ({cols}) VALUES ({vals});"


def build_update_sql(table: str, payload: dict, keys: Iterable[str], db_type: str) -> str:
    assignments = []
    clauses = []
    for column, value in payload.items():
        if column in keys:
            continue
        if value is not None:
            assignments.append(f"{column} = {_escape(value)}")
    for key in keys:
        value = payload.get(key)
        clauses.append(f"{key} = {_escape(value)}")
    return f"UPDATE {table} SET {', '.join(assignments)} WHERE {' AND '.join(clauses)};"


def build_delete_sql(table: str, payload: dict, keys: Iterable[str]) -> str:
    clauses = []
    for key in keys:
        value = payload.get(key)
        clauses.append(f"{key} = {_escape(value)}")
    return f"DELETE FROM {table} WHERE {' AND '.join(clauses)};"


def save_sql_scripts(operations: Iterable[PushOperation], prefix: str = "") -> list[str]:
    """Persist the recorded operations to SQL, Oracle and cross-network scripts."""

    directory = ensure_sql_directory()
    timestamp = _dt.datetime.now().strftime("%Y%m%d%H%M%S")
    base_name = f"{prefix}{timestamp}" if prefix else timestamp
    sql_file = directory / f"SQL_{base_name}.SQL"
    ora_file = directory / f"ORA_{base_name}.SQL"
    bridge_file = directory / f"SQL穿网_{base_name}.SQL"

    sql_statements = []
    ora_statements = []
    bridge_statements = []

    for op in operations:
        payload = dict(op.payload)
        if op.operation == "INSERT":
            sql_stmt = build_insert_sql(op.table, payload, "SQL")
            ora_stmt = build_insert_sql(op.table, payload, "ORA")
        elif op.operation == "UPDATE":
            sql_stmt = build_update_sql(op.table, payload, op.primary_keys, "SQL")
            ora_stmt = build_update_sql(op.table, payload, op.primary_keys, "ORA")
        elif op.operation == "DELETE":
            sql_stmt = build_delete_sql(op.table, payload, op.primary_keys)
            ora_stmt = sql_stmt
        else:
            raise ValueError(f"Unsupported operation type: {op.operation}")

        sql_statements.append(sql_stmt)
        ora_statements.append(ora_stmt)
        if not op.table.endswith("HIS"):
            bridge_statements.append(
                "INSERT INTO PushBasicData values('{operation}','{table}','{payload}',"
                "'{status}','{added_at}','{error}');".format(
                    operation=op.operation,
                    table=op.table,
                    payload=json.dumps(payload, ensure_ascii=False),
                    status=op.status,
                    added_at=op.added_at or "",
                    error=op.error_count,
                )
            )

    sql_file.write_text("\n".join(sql_statements), encoding="utf-8")
    ora_file.write_text("\n".join(ora_statements), encoding="utf-8")
    bridge_file.write_text("\n".join(bridge_statements), encoding="utf-8")

    return [str(sql_file), str(ora_file), str(bridge_file)]


__all__ = [
    "build_insert_sql",
    "build_update_sql",
    "build_delete_sql",
    "save_sql_scripts",
]
