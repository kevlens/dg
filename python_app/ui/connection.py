"""Database connection lifecycle helpers."""
from __future__ import annotations

import tkinter as tk
from tkinter import messagebox

from .. import constants
from ..db_service import DBService, DatabaseError


class ConnectionMixin:
    """Handles connecting to and disconnecting from the database."""

    db: DBService | None

    def connect(self) -> None:
        host = self.host_var.get().strip()
        database = self.database_var.get().strip()
        user = self.user_var.get().strip()
        password = self.password_var.get().strip()

        if not host or not database or not user or not password:
            messagebox.showwarning("提示", "请完整填写连接信息。", parent=self)
            return

        self.connect_button.configure(state=tk.DISABLED)

        connection_string = (
            f"DRIVER={{ODBC Driver 17 for SQL Server}};SERVER={host};"
            f"DATABASE={database};UID={user};PWD={password}"
        )

        if self.db:
            self.db.close()
            self.db = None

        self.set_status("正在连接数据库…")
        self.update_idletasks()
        try:
            self.db = DBService(connection_string)
        except DatabaseError as exc:
            messagebox.showerror("连接失败", str(exc), parent=self)
            self.set_status("连接失败，请重试。")
            self.db = None
            self._update_controls()
            return

        constants.STATE.connection_user = user
        self.db.start_keepalive()
        self.set_status("连接成功，正在加载区间…")
        self.load_sections()

    def disconnect(self) -> None:
        if not self.db:
            return

        self.set_status("正在断开连接…")
        self.update_idletasks()

        try:
            self.db.close()
        except Exception:  # pragma: no cover - best effort cleanup
            pass

        self.db = None
        constants.STATE.connection_user = ""
        self.sections = []
        self.devices = []
        self.selected_section = None
        self.selected_device = None
        self.selected_line = None
        self._line_cache = {}

        self.section_listbox.delete(0, tk.END)
        self.devices_listbox.delete(0, tk.END)
        self._clear_section_details()
        self._clear_line_details()
        self.operations_listbox.selection_clear(0, tk.END)

        self.set_status("数据库已断开，可重新连接。")
        self._update_controls()
