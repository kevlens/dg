"""Tkinter interface that mirrors the original WinForms workflow."""
from __future__ import annotations

from dataclasses import replace
from typing import List, Optional
import tkinter as tk
from tkinter import messagebox, simpledialog, ttk

from . import constants
from .db_service import DBService, DatabaseError
from .models import Device, Section
from .sql_util import save_sql_scripts


SECTION_DISPLAY_FIELDS = [
    "SECTION_ID",
    "SECTION_NAME",
    "DEPT_CODE",
    "START_MILE",
    "END_MILE",
    "LINE_NAME",
    "LINE_DIR",
]

DEVICE_EDIT_FIELDS = [
    "POINT_NAME",
    "POINT_FLAG",
    "POINT_NOTE",
    "POINT_PHONENO",
    "TYPE",
    "POSITION",
]

SECTION_EDIT_FIELDS = [
    "SECTION_NAME",
    "DEPT_CODE",
    "START_MILE",
    "END_MILE",
    "LINE_NAME",
    "LINE_DIR",
]


class Application(tk.Tk):
    """Main window providing a UI similar to the WinForms tool."""

    def __init__(self) -> None:
        super().__init__()
        self.title("DG 工具 (Python)")
        self.geometry("1024x680")
        self.minsize(900, 600)

        self.db: Optional[DBService] = None
        self.sections: List[Section] = []
        self.devices: List[Device] = []
        self.selected_section: Optional[Section] = None
        self.selected_device: Optional[Device] = None

        constants.STATE.reset_operations()

        self._build_ui()
        self._update_controls()
        self.protocol("WM_DELETE_WINDOW", self.on_close)

    # ------------------------------------------------------------------
    def _build_ui(self) -> None:
        self.columnconfigure(0, weight=1)
        self.columnconfigure(1, weight=1)
        self.rowconfigure(1, weight=1)
        self.rowconfigure(2, weight=1)
        self.rowconfigure(3, weight=0)

        # connection controls -------------------------------------------------
        conn_frame = ttk.LabelFrame(self, text="数据库连接")
        conn_frame.grid(row=0, column=0, columnspan=2, sticky="ew", padx=10, pady=10)
        for col in range(9):
            conn_frame.columnconfigure(col, weight=1)

        ttk.Label(conn_frame, text="服务器").grid(row=0, column=0, padx=5, pady=5, sticky="e")
        self.host_var = tk.StringVar()
        ttk.Entry(conn_frame, textvariable=self.host_var, width=18).grid(
            row=0, column=1, padx=5, pady=5, sticky="ew"
        )

        ttk.Label(conn_frame, text="数据库").grid(row=0, column=2, padx=5, pady=5, sticky="e")
        self.database_var = tk.StringVar()
        ttk.Entry(conn_frame, textvariable=self.database_var, width=18).grid(
            row=0, column=3, padx=5, pady=5, sticky="ew"
        )

        ttk.Label(conn_frame, text="用户名").grid(row=0, column=4, padx=5, pady=5, sticky="e")
        self.user_var = tk.StringVar()
        ttk.Entry(conn_frame, textvariable=self.user_var, width=16).grid(
            row=0, column=5, padx=5, pady=5, sticky="ew"
        )

        ttk.Label(conn_frame, text="密码").grid(row=0, column=6, padx=5, pady=5, sticky="e")
        self.password_var = tk.StringVar()
        ttk.Entry(conn_frame, textvariable=self.password_var, width=16, show="*").grid(
            row=0, column=7, padx=5, pady=5, sticky="ew"
        )

        self.connect_button = ttk.Button(conn_frame, text="连接", command=self.connect)
        self.connect_button.grid(row=0, column=8, padx=5, pady=5)

        # section list -------------------------------------------------------
        left_frame = ttk.Frame(self)
        left_frame.grid(row=1, column=0, sticky="nsew", padx=(10, 5), pady=5)
        left_frame.rowconfigure(0, weight=1)
        left_frame.rowconfigure(1, weight=0)
        left_frame.columnconfigure(0, weight=1)

        sections_frame = ttk.LabelFrame(left_frame, text="区间列表")
        sections_frame.grid(row=0, column=0, sticky="nsew")
        sections_frame.rowconfigure(0, weight=1)
        sections_frame.columnconfigure(0, weight=1)

        self.section_listbox = tk.Listbox(
            sections_frame, exportselection=False, height=18
        )
        self.section_listbox.grid(row=0, column=0, sticky="nsew")
        section_scroll = ttk.Scrollbar(
            sections_frame, orient=tk.VERTICAL, command=self.section_listbox.yview
        )
        section_scroll.grid(row=0, column=1, sticky="ns")
        self.section_listbox.configure(yscrollcommand=section_scroll.set)
        self.section_listbox.bind("<<ListboxSelect>>", self.on_section_selected)

        self.refresh_sections_btn = ttk.Button(
            sections_frame, text="刷新区间", command=self.load_sections
        )
        self.refresh_sections_btn.grid(row=1, column=0, columnspan=2, pady=5)

        details_frame = ttk.LabelFrame(left_frame, text="区间详情")
        details_frame.grid(row=1, column=0, sticky="ew", pady=(10, 0))
        details_frame.columnconfigure(1, weight=1)

        self.section_detail_vars: dict[str, tk.StringVar] = {}
        for idx, field in enumerate(SECTION_DISPLAY_FIELDS):
            ttk.Label(details_frame, text=field).grid(
                row=idx, column=0, sticky="e", padx=5, pady=2
            )
            var = tk.StringVar(value="-")
            self.section_detail_vars[field] = var
            ttk.Label(details_frame, textvariable=var).grid(
                row=idx, column=1, sticky="w", padx=5, pady=2
            )

        self.update_section_btn = ttk.Button(
            details_frame, text="更新区间信息", command=self.update_section
        )
        self.update_section_btn.grid(
            row=len(SECTION_DISPLAY_FIELDS), column=0, columnspan=2, pady=(10, 5)
        )

        # device list --------------------------------------------------------
        right_frame = ttk.Frame(self)
        right_frame.grid(row=1, column=1, sticky="nsew", padx=(5, 10), pady=5)
        right_frame.rowconfigure(0, weight=1)
        right_frame.columnconfigure(0, weight=1)

        devices_frame = ttk.LabelFrame(right_frame, text="定标器")
        devices_frame.grid(row=0, column=0, sticky="nsew")
        devices_frame.columnconfigure(0, weight=1)
        devices_frame.rowconfigure(0, weight=1)

        self.devices_listbox = tk.Listbox(devices_frame, exportselection=False, height=18)
        self.devices_listbox.grid(row=0, column=0, sticky="nsew")
        device_scroll = ttk.Scrollbar(
            devices_frame, orient=tk.VERTICAL, command=self.devices_listbox.yview
        )
        device_scroll.grid(row=0, column=1, sticky="ns")
        self.devices_listbox.configure(yscrollcommand=device_scroll.set)
        self.devices_listbox.bind("<<ListboxSelect>>", self.on_device_selected)

        device_buttons = ttk.Frame(devices_frame)
        device_buttons.grid(row=1, column=0, columnspan=2, pady=5)
        self.update_device_btn = ttk.Button(
            device_buttons, text="更新定标器", command=self.update_device
        )
        self.update_device_btn.pack(side=tk.LEFT, padx=5)
        self.delete_device_btn = ttk.Button(
            device_buttons, text="删除定标器", command=self.delete_device
        )
        self.delete_device_btn.pack(side=tk.LEFT, padx=5)

        # operations ---------------------------------------------------------
        operations_frame = ttk.LabelFrame(self, text="已记录操作")
        operations_frame.grid(
            row=2, column=0, columnspan=2, sticky="nsew", padx=10, pady=(5, 5)
        )
        operations_frame.columnconfigure(0, weight=1)
        operations_frame.rowconfigure(0, weight=1)

        self.operations_listbox = tk.Listbox(operations_frame, height=6)
        self.operations_listbox.grid(row=0, column=0, sticky="nsew")
        operations_scroll = ttk.Scrollbar(
            operations_frame, orient=tk.VERTICAL, command=self.operations_listbox.yview
        )
        operations_scroll.grid(row=0, column=1, sticky="ns")
        self.operations_listbox.configure(yscrollcommand=operations_scroll.set)

        self.export_sql_btn = ttk.Button(
            operations_frame, text="生成操作 SQL", command=self.export_sql
        )
        self.export_sql_btn.grid(row=1, column=0, columnspan=2, pady=5)

        # status bar ---------------------------------------------------------
        self.status_var = tk.StringVar(value="请先连接数据库。")
        status_label = ttk.Label(self, textvariable=self.status_var, anchor="w")
        status_label.grid(row=3, column=0, columnspan=2, sticky="ew", padx=10, pady=(0, 10))

    # ------------------------------------------------------------------
    def connect(self) -> None:
        host = self.host_var.get().strip()
        database = self.database_var.get().strip()
        user = self.user_var.get().strip()
        password = self.password_var.get().strip()

        if not host or not database or not user or not password:
            messagebox.showwarning("提示", "请完整填写连接信息。", parent=self)
            return

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
            return

        constants.STATE.connection_user = user
        self.db.start_keepalive()
        self.set_status("连接成功，正在加载区间…")
        self.load_sections()

    # ------------------------------------------------------------------
    def load_sections(self) -> None:
        if not self.db:
            messagebox.showwarning("提示", "请先连接数据库。", parent=self)
            return
        self.set_status("正在读取区间列表…")
        self.update_idletasks()
        try:
            sections = self.db.fetch_sections()
        except Exception as exc:  # pragma: no cover - requires database
            messagebox.showerror("读取失败", f"读取区间失败: {exc}", parent=self)
            self.set_status("读取区间失败。")
            return

        self.sections = sections
        self.section_listbox.delete(0, tk.END)
        for section in sections:
            label = f"{section.SECTION_NAME} ({section.SECTION_ID})"
            self.section_listbox.insert(tk.END, label)

        self.selected_section = None
        self.selected_device = None
        self.devices = []
        self.devices_listbox.delete(0, tk.END)
        self._clear_section_details()
        self.refresh_operations()
        self.set_status(f"已加载 {len(sections)} 个区间。")
        self._update_controls()

    # ------------------------------------------------------------------
    def on_section_selected(self, event: tk.Event[tk.Listbox]) -> None:  # type: ignore[type-var]
        if not self.section_listbox.curselection():
            return
        index = self.section_listbox.curselection()[0]
        if index >= len(self.sections):
            return
        section = self.sections[index]
        self.selected_section = section
        self._display_section_details(section)
        self.load_devices(section)
        self._update_controls()

    # ------------------------------------------------------------------
    def load_devices(self, section: Section) -> None:
        if not self.db:
            return
        self.set_status("正在读取定标器列表…")
        self.update_idletasks()
        try:
            devices = self.db.fetch_devices(section.SECTION_ID)
        except Exception as exc:  # pragma: no cover - requires database
            messagebox.showerror("读取失败", f"读取定标器失败: {exc}", parent=self)
            self.set_status("读取定标器失败。")
            return

        self.devices = devices
        self.devices_listbox.configure(state=tk.NORMAL)
        self.devices_listbox.delete(0, tk.END)
        for device in devices:
            label = (
                f"{device.POINT_NAME or '未命名'} ({device.POINT_NO})"
                f" - {device.TYPE or '未知类型'}"
            )
            self.devices_listbox.insert(tk.END, label)
        self.selected_device = None
        self._update_controls()
        self.set_status(
            f"区间 {section.SECTION_NAME} 包含 {len(devices)} 个定标器。"
        )

    # ------------------------------------------------------------------
    def on_device_selected(self, event: tk.Event[tk.Listbox]) -> None:  # type: ignore[type-var]
        if not self.devices_listbox.curselection():
            return
        index = self.devices_listbox.curselection()[0]
        if index >= len(self.devices):
            return
        self.selected_device = self.devices[index]
        self._update_controls()

    # ------------------------------------------------------------------
    def update_section(self) -> None:
        if not (self.db and self.selected_section):
            messagebox.showwarning("提示", "请选择区间。", parent=self)
            return
        section = self.selected_section
        updates = self._prompt_for_updates("更新区间信息", SECTION_EDIT_FIELDS, section)
        if updates is None:
            return
        updated = replace(section)
        for field, value in updates.items():
            setattr(updated, field, value)
        self.db.queue_update(updated, updated.PRIMARY_KEYS)
        messagebox.showinfo("已记录", "区间更新操作已加入队列。", parent=self)
        self.refresh_operations()
        self.set_status("区间更新操作已加入队列。")

    # ------------------------------------------------------------------
    def update_device(self) -> None:
        if not (self.db and self.selected_device and self.selected_section):
            messagebox.showwarning("提示", "请选择定标器。", parent=self)
            return
        device = self.selected_device
        updates = self._prompt_for_updates("更新定标器信息", DEVICE_EDIT_FIELDS, device)
        if updates is None:
            return
        updated = replace(device)
        for field, value in updates.items():
            setattr(updated, field, value)
        self.db.queue_update(updated, updated.PRIMARY_KEYS)
        messagebox.showinfo("已记录", "定标器更新操作已加入队列。", parent=self)
        self.refresh_operations()
        self.set_status("定标器更新操作已加入队列。")

    # ------------------------------------------------------------------
    def delete_device(self) -> None:
        if not (self.db and self.selected_device):
            messagebox.showwarning("提示", "请选择要删除的定标器。", parent=self)
            return
        device = self.selected_device
        confirm = messagebox.askyesno(
            "确认删除",
            f"确定要删除定标器 {device.POINT_NAME or device.POINT_NO} ({device.POINT_NO}) 吗？",
            parent=self,
        )
        if not confirm:
            return
        payload = {"POINT_NO": device.POINT_NO}
        self.db.queue_delete("BROKENRAIL_BDATA_DEVICE", payload, ("POINT_NO",))
        messagebox.showinfo("已记录", "删除操作已加入队列。", parent=self)
        self.refresh_operations()
        self.set_status("定标器删除操作已加入队列。")

    # ------------------------------------------------------------------
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

    # ------------------------------------------------------------------
    def refresh_operations(self) -> None:
        self.operations_listbox.delete(0, tk.END)
        for op in constants.STATE.get_operations():
            summary = f"[{op.operation}] {op.table} - 主键: {', '.join(op.primary_keys)}"
            self.operations_listbox.insert(tk.END, summary)
        self._update_controls()

    # ------------------------------------------------------------------
    def _prompt_for_updates(self, title: str, fields: List[str], source: object) -> Optional[dict[str, str]]:
        updates: dict[str, str] = {}
        for field in fields:
            current = getattr(source, field, "") or ""
            value = simpledialog.askstring(
                title,
                f"{field} (留空保持不变)",
                initialvalue=str(current),
                parent=self,
            )
            if value is None:
                return None
            value = value.strip()
            if value == "":
                updates[field] = current
            else:
                updates[field] = value
        return updates

    # ------------------------------------------------------------------
    def _display_section_details(self, section: Section) -> None:
        for field in SECTION_DISPLAY_FIELDS:
            value = getattr(section, field, "") or "-"
            self.section_detail_vars[field].set(value)

    def _clear_section_details(self) -> None:
        for var in self.section_detail_vars.values():
            var.set("-")

    def _update_controls(self) -> None:
        connected = self.db is not None
        section_selected = self.selected_section is not None
        device_selected = self.selected_device is not None
        operations_available = bool(constants.STATE.get_operations())

        self.refresh_sections_btn.configure(state=tk.NORMAL if connected else tk.DISABLED)
        self.section_listbox.configure(state=tk.NORMAL if connected else tk.DISABLED)

        if section_selected:
            self.devices_listbox.configure(state=tk.NORMAL)
        else:
            self.devices_listbox.configure(state=tk.DISABLED)
            self.devices_listbox.selection_clear(0, tk.END)
            self.selected_device = None

        self.update_section_btn.configure(state=tk.NORMAL if section_selected else tk.DISABLED)
        self.update_device_btn.configure(state=tk.NORMAL if device_selected else tk.DISABLED)
        self.delete_device_btn.configure(state=tk.NORMAL if device_selected else tk.DISABLED)
        self.export_sql_btn.configure(state=tk.NORMAL if operations_available else tk.DISABLED)

    def set_status(self, message: str) -> None:
        self.status_var.set(message)

    # ------------------------------------------------------------------
    def on_close(self) -> None:
        if self.db:
            self.db.close()
        self.destroy()


def main() -> None:
    app = Application()
    app.mainloop()


if __name__ == "__main__":
    main()
