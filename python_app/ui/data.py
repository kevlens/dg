"""Export and backup helpers for the Tkinter UI."""
from __future__ import annotations

import csv
from datetime import datetime
from pathlib import Path
from typing import List

from tkinter import messagebox

from .. import constants
from ..sql_util import save_sql_scripts
from .dialogs import BoundaryWindow


class DataActionsMixin:
    """Provides data export, backup, and boundary viewing actions."""

    def initialize_intranet_data(self) -> None:
        if not self.db:  # type: ignore[attr-defined]
            messagebox.showwarning("提示", "请先连接数据库。", parent=self)
            return

        self.set_status("正在生成内网初始化 SQL…")
        self.update_idletasks()

        try:
            sections = self.db.fetch_sections()  # type: ignore[union-attr]
            devices = self.db.fetch_all_devices()  # type: ignore[union-attr]
            lines = self.db.fetch_all_section_lines()  # type: ignore[union-attr]
            boundaries = self.db.fetch_boundaries()  # type: ignore[union-attr]
        except Exception as exc:  # pragma: no cover - requires database
            messagebox.showerror("生成失败", f"读取数据失败: {exc}", parent=self)
            self.set_status("生成失败。")
            return

        operations: List[constants.PushOperation] = []
        added_at = datetime.now().strftime("%Y-%m-%d %H:%M:%S")
        for record in sections:
            operations.append(self._make_insert_operation(record, added_at))
        for record in devices:
            operations.append(self._make_insert_operation(record, added_at))
        for record in lines:
            operations.append(self._make_insert_operation(record, added_at))
        for record in boundaries:
            operations.append(self._make_insert_operation(record, added_at))

        if not operations:
            messagebox.showinfo("提示", "未找到可导出的数据。", parent=self)
            self.set_status("没有可导出的数据。")
            return

        prefix = constants.STATE.connection_user + "_" if constants.STATE.connection_user else ""
        files = save_sql_scripts(operations, prefix=f"INIT_{prefix}")
        message = "已生成如下文件:\n" + "\n".join(files)
        messagebox.showinfo("初始化完成", message, parent=self)
        self.set_status("内网初始化 SQL 已生成。")

    def backup_data(self) -> None:
        if not self.db:  # type: ignore[attr-defined]
            messagebox.showwarning("提示", "请先连接数据库。", parent=self)
            return

        self.set_status("正在备份数据…")
        self.update_idletasks()

        try:
            sections = self.db.fetch_sections()  # type: ignore[union-attr]
            devices = self.db.fetch_all_devices()  # type: ignore[union-attr]
            lines = self.db.fetch_all_section_lines()  # type: ignore[union-attr]
            boundaries = self.db.fetch_boundaries()  # type: ignore[union-attr]
        except Exception as exc:  # pragma: no cover - requires database
            messagebox.showerror("备份失败", f"读取数据失败: {exc}", parent=self)
            self.set_status("备份失败。")
            return

        backup_dir = Path.cwd() / "Backups"
        backup_dir.mkdir(parents=True, exist_ok=True)
        timestamp = datetime.now().strftime("%Y%m%d%H%M%S")

        files = [
            self._write_backup_csv(
                backup_dir / f"sections_{timestamp}.csv",
                [section.to_payload() for section in sections],
            ),
            self._write_backup_csv(
                backup_dir / f"devices_{timestamp}.csv",
                [device.to_payload() for device in devices],
            ),
            self._write_backup_csv(
                backup_dir / f"section_lines_{timestamp}.csv",
                [line.to_payload() for line in lines],
            ),
            self._write_backup_csv(
                backup_dir / f"boundaries_{timestamp}.csv",
                [boundary.to_payload() for boundary in boundaries],
            ),
        ]

        message = "已导出如下备份文件:\n" + "\n".join(files)
        messagebox.showinfo("备份完成", message, parent=self)
        self.set_status("数据备份完成。")

    def show_boundaries(self) -> None:
        if not self.db:  # type: ignore[attr-defined]
            messagebox.showwarning("提示", "请先连接数据库。", parent=self)
            return

        BoundaryWindow(self, lambda: self.db.fetch_boundaries())  # type: ignore[union-attr]

    def export_sql(self) -> None:
        operations = constants.STATE.get_operations()
        if not operations:
            messagebox.showinfo("提示", "没有可导出的操作。", parent=self)
            return
        prefix = constants.STATE.connection_user + "_" if constants.STATE.connection_user else ""
        files = save_sql_scripts(operations, prefix=prefix)
        constants.STATE.reset_operations()
        self.refresh_operations()
        message = "已生成如下文件:\n" + "\n".join(files)
        messagebox.showinfo("SQL 已生成", message, parent=self)
        self.set_status("SQL 已生成。")

    def _make_insert_operation(
        self, record: constants.HasTableMetadata, added_at: str
    ) -> constants.PushOperation:
        table_name = getattr(record, "TABLE_NAME", record.__class__.__name__)
        payload = record.to_payload()  # type: ignore[call-arg]
        payload["ADDED_AT"] = added_at
        primary_keys = getattr(record, "PRIMARY_KEYS", tuple())
        return constants.PushOperation(
            action="INSERT",
            table=table_name,
            payload=payload,
            primary_keys=primary_keys,
        )

    def _write_backup_csv(self, path: Path, rows: List[dict]) -> str:
        with path.open("w", newline="", encoding="utf-8") as handle:
            writer = csv.DictWriter(handle, fieldnames=rows[0].keys() if rows else [])
            writer.writeheader()
            writer.writerows(rows)
        return str(path)
