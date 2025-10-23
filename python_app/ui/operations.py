"""Operation-log helpers for the Tkinter UI."""
from __future__ import annotations

from typing import Any

import tkinter as tk

from .. import constants


class OperationLogMixin:
    """Handles formatting and displaying queued operations."""

    def refresh_operations(self) -> None:
        self.operations_listbox.delete(0, tk.END)  # type: ignore[attr-defined]
        for op in constants.STATE.get_operations():
            summary = self._format_operation_entry(op)
            self.operations_listbox.insert(tk.END, summary)  # type: ignore[attr-defined]
        self._update_controls()

    def _format_operation_entry(self, op: constants.PushOperation) -> str:
        primary_parts = []
        for key in op.primary_keys:
            value = op.payload.get(key, "")
            primary_parts.append(f"{key}={self._display_value(value)}")
        changed_parts = []
        changes = op.changes or {}
        for key, value in changes.items():
            changed_parts.append(f"{key}→{self._display_value(value)}")
        payload_preview = ", ".join(primary_parts)
        if changed_parts:
            payload_preview += " | " + ", ".join(changed_parts)
        return f"[{op.action}] {op.table}: {payload_preview}"

    @staticmethod
    def _display_value(value: Any) -> str:
        if value in (None, ""):
            return "(空)"
        if isinstance(value, str):
            return value
        return str(value)
