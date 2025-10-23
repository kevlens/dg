"""Tkinter interface that mirrors the original WinForms workflow."""
from __future__ import annotations

import csv
from dataclasses import replace
from datetime import datetime
from pathlib import Path
from typing import Callable, List, Optional
import tkinter as tk
from tkinter import messagebox, ttk

from . import constants
from .db_service import DBService, DatabaseError
from .models import Device, Section, SectionLine
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

SECTION_CREATE_FIELDS = [
    "SECTION_ID",
    "SECTION_NAME",
    "DEPT_CODE",
    "START_MILE",
    "END_MILE",
    "LINE_NAME",
    "LINE_DIR",
    "START_SCALER_INDEX",
    "END_SCALER_INDEX",
    "STATION_STATION",
    "GC_VOL",
    "ENVIRONMENT_VOL",
]

DEVICE_CREATE_FIELDS = [
    "POINT_NO",
    "POINT_NAME",
    "TYPE",
    "POSITION",
    "POINT_FLAG",
    "POINT_NOTE",
    "POINT_PHONENO",
    "MATCHUP_PHONE",
    "PREV_PHONE",
    "NEXT_PHONE",
    "LINE_NAME",
    "LINE_DIR",
    "LINE_CODE",
    "MILEAGE_COORDINATE",
    "POINT_ORDER",
]

SECTION_LINE_DISPLAY_FIELDS = [
    "PKID",
    "POINT_NO",
    "MILEAGE_START",
    "MILEAGE_END",
]


def center_window(window: tk.Toplevel, parent: tk.Misc) -> None:
    """Center a toplevel window relative to its parent."""

    window.update_idletasks()
    try:
        parent.update_idletasks()
    except Exception:  # pragma: no cover - defensive
        pass

    parent_width = max(parent.winfo_width(), 1)
    parent_height = max(parent.winfo_height(), 1)
    parent_x = parent.winfo_rootx()
    parent_y = parent.winfo_rooty()

    width = window.winfo_width()
    height = window.winfo_height()

    x = parent_x + max((parent_width - width) // 2, 0)
    y = parent_y + max((parent_height - height) // 2, 0)
    window.geometry(f"+{x}+{y}")


class EditDialog(tk.Toplevel):
    """Modal dialog used to edit a record in a single window."""

    def __init__(
        self,
        parent: tk.Tk,
        title: str,
        fields: List[str],
        source: object,
    ) -> None:
        super().__init__(parent)
        self.title(title)
        self.transient(parent)
        self.resizable(False, False)
        self.grab_set()
        self.result: Optional[dict[str, str]] = None
        self._source = source

        container = ttk.Frame(self, padding=10)
        container.grid(row=0, column=0, sticky="nsew")
        container.columnconfigure(1, weight=1)

        self._variables: dict[str, tk.StringVar] = {}
        first_entry: Optional[ttk.Entry] = None
        for row, field in enumerate(fields):
            ttk.Label(container, text=field).grid(
                row=row, column=0, padx=(0, 8), pady=4, sticky="e"
            )
            value = getattr(source, field, "") or ""
            var = tk.StringVar(value=str(value))
            entry = ttk.Entry(container, textvariable=var, width=40)
            entry.grid(row=row, column=1, padx=0, pady=4, sticky="ew")
            self._variables[field] = var
            if first_entry is None:
                first_entry = entry

        button_frame = ttk.Frame(self, padding=(10, 0, 10, 10))
        button_frame.grid(row=1, column=0, sticky="ew")
        button_frame.columnconfigure(0, weight=1)
        button_frame.columnconfigure(1, weight=1)

        ok_button = ttk.Button(button_frame, text="确定", command=self._on_ok)
        ok_button.grid(row=0, column=0, padx=(0, 5), sticky="ew")
        cancel_button = ttk.Button(button_frame, text="取消", command=self._on_cancel)
        cancel_button.grid(row=0, column=1, padx=(5, 0), sticky="ew")

        self.bind("<Return>", lambda _event: self._on_ok())
        self.bind("<Escape>", lambda _event: self._on_cancel())
        self.protocol("WM_DELETE_WINDOW", self._on_cancel)

        if first_entry is not None:
            first_entry.focus()

        self.wait_visibility()
        center_window(self, parent)
        self.wait_window(self)

    def _on_ok(self) -> None:
        changes: dict[str, str] = {}
        for field, var in self._variables.items():
            new_value = var.get().strip()
            original = getattr(self._source, field, "") or ""
            if new_value != str(original):
                changes[field] = new_value
        self.result = changes
        self.grab_release()
        self.destroy()

    def _on_cancel(self) -> None:
        self.result = None
        self.grab_release()
        self.destroy()


class PhoneChangeDialog(tk.Toplevel):
    """Dialog dedicated to updating a device phone number."""

    def __init__(self, parent: tk.Tk, device: Device) -> None:
        super().__init__(parent)
        self.title("更换手机号")
        self.transient(parent)
        self.resizable(False, False)
        self.grab_set()
        self.result: Optional[str] = None

        container = ttk.Frame(self, padding=10)
        container.grid(row=0, column=0, sticky="nsew")
        container.columnconfigure(1, weight=1)

        device_name = device.POINT_NAME or "未命名"
        ttk.Label(container, text="定标器").grid(
            row=0, column=0, padx=(0, 8), pady=4, sticky="e"
        )
        ttk.Label(
            container,
            text=f"{device_name} ({device.POINT_NO})",
        ).grid(row=0, column=1, padx=0, pady=4, sticky="w")

        ttk.Label(container, text="原手机号").grid(
            row=1, column=0, padx=(0, 8), pady=4, sticky="e"
        )
        original_phone = device.POINT_PHONENO or ""
        ttk.Label(
            container,
            text=original_phone if original_phone else "(空)",
        ).grid(row=1, column=1, padx=0, pady=4, sticky="w")

        ttk.Label(container, text="配对手机号").grid(
            row=2, column=0, padx=(0, 8), pady=4, sticky="e"
        )
        ttk.Label(
            container,
            text=device.MATCHUP_PHONE or "(空)",
        ).grid(row=2, column=1, padx=0, pady=4, sticky="w")

        ttk.Label(container, text="前一手机号").grid(
            row=3, column=0, padx=(0, 8), pady=4, sticky="e"
        )
        ttk.Label(
            container,
            text=device.PREV_PHONE or "(空)",
        ).grid(row=3, column=1, padx=0, pady=4, sticky="w")

        ttk.Label(container, text="后一手机号").grid(
            row=4, column=0, padx=(0, 8), pady=4, sticky="e"
        )
        ttk.Label(
            container,
            text=device.NEXT_PHONE or "(空)",
        ).grid(row=4, column=1, padx=0, pady=4, sticky="w")

        ttk.Label(container, text="新手机号").grid(
            row=5, column=0, padx=(0, 8), pady=4, sticky="e"
        )
        self._new_phone_var = tk.StringVar(value=original_phone)
        entry = ttk.Entry(container, textvariable=self._new_phone_var, width=40)
        entry.grid(row=5, column=1, padx=0, pady=4, sticky="ew")

        button_frame = ttk.Frame(self, padding=(10, 0, 10, 10))
        button_frame.grid(row=1, column=0, sticky="ew")
        button_frame.columnconfigure(0, weight=1)
        button_frame.columnconfigure(1, weight=1)

        ttk.Button(button_frame, text="确定", command=self._on_ok).grid(
            row=0, column=0, padx=(0, 5), sticky="ew"
        )
        ttk.Button(button_frame, text="取消", command=self._on_cancel).grid(
            row=0, column=1, padx=(5, 0), sticky="ew"
        )

        self.bind("<Return>", lambda _event: self._on_ok())
        self.bind("<Escape>", lambda _event: self._on_cancel())
        self.protocol("WM_DELETE_WINDOW", self._on_cancel)

        entry.focus()
        self.wait_visibility()
        center_window(self, parent)
        self.wait_window(self)

    def _on_ok(self) -> None:
        self.result = self._new_phone_var.get().strip()
        self.grab_release()
        self.destroy()

    def _on_cancel(self) -> None:
        self.result = None
        self.grab_release()
        self.destroy()


class BoundaryWindow(tk.Toplevel):
    """Simple viewer for boundary records."""

    def __init__(self, parent: tk.Tk, fetcher: Callable[[], List[object]]) -> None:
        super().__init__(parent)
        self.title("分界线数据")
        self.geometry("480x360")
        self.minsize(420, 300)
        self.transient(parent)

        self._fetcher = fetcher

        container = ttk.Frame(self, padding=10)
        container.grid(row=0, column=0, sticky="nsew")
        self.columnconfigure(0, weight=1)
        self.rowconfigure(0, weight=1)
        container.columnconfigure(0, weight=1)
        container.rowconfigure(0, weight=1)

        columns = ("PKID", "SECTION_ID", "BOUNDARY_NAME")
        self.tree = ttk.Treeview(container, columns=columns, show="headings")
        for column in columns:
            self.tree.heading(column, text=column)
            self.tree.column(column, width=140, anchor="center")
        self.tree.grid(row=0, column=0, sticky="nsew")

        scroll = ttk.Scrollbar(container, orient=tk.VERTICAL, command=self.tree.yview)
        scroll.grid(row=0, column=1, sticky="ns")
        self.tree.configure(yscrollcommand=scroll.set)

        button_frame = ttk.Frame(container)
        button_frame.grid(row=1, column=0, columnspan=2, sticky="ew", pady=(10, 0))
        button_frame.columnconfigure(0, weight=1)
        button_frame.columnconfigure(1, weight=1)

        ttk.Button(button_frame, text="刷新", command=self.refresh).grid(
            row=0, column=0, padx=(0, 5), sticky="ew"
        )
        ttk.Button(button_frame, text="关闭", command=self.destroy).grid(
            row=0, column=1, padx=(5, 0), sticky="ew"
        )

        center_window(self, parent)
        self.refresh()

    def refresh(self) -> None:
        try:
            boundaries = self._fetcher()
        except DatabaseError as exc:  # pragma: no cover - requires database
            messagebox.showerror("读取失败", str(exc), parent=self)
            return

        for item in self.tree.get_children():
            self.tree.delete(item)

        for boundary in boundaries:
            self.tree.insert(
                "",
                tk.END,
                values=(
                    getattr(boundary, "PKID", ""),
                    getattr(boundary, "SECTION_ID", ""),
                    getattr(boundary, "BOUNDARY_NAME", ""),
                ),
            )


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
        self.selected_line: Optional[SectionLine] = None
        self._line_cache: dict[str, Optional[SectionLine]] = {}

        constants.STATE.reset_operations()

        self._build_menus()
        self._build_ui()
        self._update_controls()
        self.protocol("WM_DELETE_WINDOW", self.on_close)

    # ------------------------------------------------------------------
    def _build_menus(self) -> None:
        menubar = tk.Menu(self)

        self.system_menu = tk.Menu(menubar, tearoff=0)
        self.system_menu.add_command(label="重新加载", command=self.load_sections)
        self._menu_reload_index = self.system_menu.index("end")
        self.system_menu.add_command(
            label="初始化内网数据", command=self.initialize_intranet_data
        )
        self._menu_init_index = self.system_menu.index("end")
        self.system_menu.add_command(label="分界线数据", command=self.show_boundaries)
        self._menu_boundary_index = self.system_menu.index("end")
        self.system_menu.add_command(label="新增区间", command=self.add_section)
        self._menu_add_section_index = self.system_menu.index("end")
        self.system_menu.add_command(label="新增定标器", command=self.add_device)
        self._menu_add_device_index = self.system_menu.index("end")
        self.system_menu.add_separator()
        self.system_menu.add_command(label="生成操作 SQL", command=self.export_sql)
        self._menu_export_index = self.system_menu.index("end")
        menubar.add_cascade(label="系统", menu=self.system_menu)

        self.import_menu = tk.Menu(menubar, tearoff=0)
        self.import_menu.add_command(
            label="导入EXCEL",
            command=lambda: self._not_implemented("导入EXCEL"),
            state=tk.DISABLED,
        )
        self._menu_import_excel_index = self.import_menu.index("end")
        self.import_menu.add_command(
            label="导入线路数据",
            command=lambda: self._not_implemented("导入线路数据"),
        )
        self._menu_import_line_index = self.import_menu.index("end")
        self.import_menu.add_command(
            label="导入车站数据",
            command=lambda: self._not_implemented("导入车站数据"),
        )
        self._menu_import_station_index = self.import_menu.index("end")
        menubar.add_cascade(label="导入", menu=self.import_menu)

        self.backup_menu = tk.Menu(menubar, tearoff=0)
        self.backup_menu.add_command(label="备份当前数据", command=self.backup_data)
        self._menu_backup_index = self.backup_menu.index("end")
        menubar.add_cascade(label="备份", menu=self.backup_menu)

        self.config(menu=menubar)
        self.menubar = menubar

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
        for col in range(10):
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

        self.disconnect_button = ttk.Button(
            conn_frame, text="断开", command=self.disconnect
        )
        self.disconnect_button.grid(row=0, column=9, padx=5, pady=5)

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
        self.section_listbox.bind("<Button-3>", self._on_section_context)

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
        right_frame.rowconfigure(1, weight=0)
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
        self.devices_listbox.bind("<Button-3>", self._on_device_context)

        self.section_menu = tk.Menu(self, tearoff=0)
        self.section_menu.add_command(label="新增定标器", command=self.add_device)
        self._section_menu_add_device_index = self.section_menu.index("end")
        self.section_menu.add_command(label="删除区间", command=self.delete_section)
        self._section_menu_delete_index = self.section_menu.index("end")

        self.device_menu = tk.Menu(self, tearoff=0)
        self.device_menu.add_command(label="删除定标器", command=self.delete_device)
        self._device_menu_delete_index = self.device_menu.index("end")
        self.device_menu.add_command(label="删除画线", command=self.delete_device_line)
        self._device_menu_delete_line_index = self.device_menu.index("end")
        self.device_menu.add_command(label="更换手机号", command=self.change_device_phone)
        self._device_menu_change_phone_index = self.device_menu.index("end")

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

        line_frame = ttk.LabelFrame(right_frame, text="画线信息")
        line_frame.grid(row=1, column=0, sticky="ew", pady=(10, 0))
        line_frame.columnconfigure(1, weight=1)

        self.line_detail_vars: dict[str, tk.StringVar] = {}
        for idx, field in enumerate(SECTION_LINE_DISPLAY_FIELDS):
            ttk.Label(line_frame, text=field).grid(
                row=idx, column=0, sticky="e", padx=5, pady=2
            )
            var = tk.StringVar(value="-")
            self.line_detail_vars[field] = var
            ttk.Label(line_frame, textvariable=var).grid(
                row=idx, column=1, sticky="w", padx=5, pady=2
            )

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

    # ------------------------------------------------------------------
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
            self.section_listbox.insert(tk.END, self._section_label(section))

        self.selected_section = None
        self.selected_device = None
        self.selected_line = None
        self._line_cache = {}
        self.devices = []
        self.devices_listbox.delete(0, tk.END)
        self._clear_section_details()
        self._clear_line_details()
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
            self.devices_listbox.insert(tk.END, self._device_label(device))
        self.selected_device = None
        self.selected_line = None
        self._line_cache = {}
        self._clear_line_details()
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
        self._load_line_details(self.selected_device)
        self._update_controls()

    def _load_line_details(self, device: Device) -> None:
        if not self.db:
            self.selected_line = None
            self._clear_line_details()
            return

        point_no = device.POINT_NO
        fetched_from_db = point_no not in self._line_cache
        if fetched_from_db:
            try:
                line = self.db.fetch_section_line(point_no)
            except Exception as exc:  # pragma: no cover - requires database
                messagebox.showerror("读取失败", f"读取画线数据失败: {exc}", parent=self)
                self.set_status("读取画线数据失败。")
                line = None
            self._line_cache[point_no] = line
        else:
            line = self._line_cache[point_no]

        self.selected_line = line
        self._display_line_details(line)

        if line is None:
            self.set_status("此定标器无画线数据。")
        else:
            start = line.MILEAGE_START if line.MILEAGE_START not in (None, "") else "-"
            end = line.MILEAGE_END if line.MILEAGE_END not in (None, "") else "-"
            self.set_status(f"画线范围：{start} - {end}。")

    # ------------------------------------------------------------------
    def update_section(self) -> None:
        if not (self.db and self.selected_section):
            messagebox.showwarning("提示", "请选择区间。", parent=self)
            return
        section = self.selected_section
        dialog = EditDialog(self, "更新区间信息", SECTION_EDIT_FIELDS, section)
        updates = dialog.result
        if updates is None:
            return
        if not updates:
            messagebox.showinfo("提示", "未检测到修改。", parent=self)
            return
        updated = replace(section)
        for field, value in updates.items():
            setattr(updated, field, value)
        if self.section_listbox.curselection():
            idx = self.section_listbox.curselection()[0]
            self.sections[idx] = updated
            self.section_listbox.delete(idx)
            self.section_listbox.insert(idx, self._section_label(updated))
            self.section_listbox.selection_set(idx)
        self.selected_section = updated
        self._display_section_details(updated)
        self.db.queue_update(updated, updated.PRIMARY_KEYS, changes=updates)
        messagebox.showinfo("已记录", "区间更新操作已加入队列。", parent=self)
        self.refresh_operations()
        self.set_status("区间更新操作已加入队列。")

    # ------------------------------------------------------------------
    def update_device(self) -> None:
        if not (self.db and self.selected_device and self.selected_section):
            messagebox.showwarning("提示", "请选择定标器。", parent=self)
            return
        device = self.selected_device
        dialog = EditDialog(self, "更新定标器信息", DEVICE_EDIT_FIELDS, device)
        updates = dialog.result
        if updates is None:
            return
        if not updates:
            messagebox.showinfo("提示", "未检测到修改。", parent=self)
            return
        updated = replace(device)
        for field, value in updates.items():
            setattr(updated, field, value)
        if self.devices_listbox.curselection():
            idx = self.devices_listbox.curselection()[0]
            self.devices[idx] = updated
            self.devices_listbox.delete(idx)
            self.devices_listbox.insert(idx, self._device_label(updated))
            self.devices_listbox.selection_set(idx)
        self.selected_device = updated
        self.db.queue_update(updated, updated.PRIMARY_KEYS, changes=updates)
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
    def delete_section(self) -> None:
        if not (self.db and self.selected_section):
            messagebox.showwarning("提示", "请选择要删除的区间。", parent=self)
            return

        section = self.selected_section
        confirm = messagebox.askyesno(
            "确认删除",
            f"确定要删除区间 {section.SECTION_NAME} ({section.SECTION_ID}) 吗？",
            parent=self,
        )
        if not confirm:
            return

        try:
            devices = self.db.fetch_devices(section.SECTION_ID)
        except Exception as exc:  # pragma: no cover - requires database
            messagebox.showerror("删除失败", f"无法读取区间定标器: {exc}", parent=self)
            return

        for device in devices:
            self.db.queue_delete(
                "BROKENRAIL_BDATA_DEVICE",
                {"POINT_NO": device.POINT_NO},
                ("POINT_NO",),
            )
            try:
                line = self.db.fetch_section_line(device.POINT_NO)
            except Exception:  # pragma: no cover - requires database
                line = None
            if line:
                self.db.queue_delete(
                    line.TABLE_NAME,
                    {"PKID": line.PKID},
                    line.PRIMARY_KEYS,
                )

        self.db.queue_delete(
            "BROKENRAIL_BDATA_SECTION",
            {"SECTION_ID": section.SECTION_ID},
            ("SECTION_ID",),
        )

        if self.section_listbox.curselection():
            index = self.section_listbox.curselection()[0]
        else:
            index = self.sections.index(section)
        self.section_listbox.delete(index)
        del self.sections[index]

        self.selected_section = None
        self.selected_device = None
        self.devices = []
        self.devices_listbox.delete(0, tk.END)
        self._clear_section_details()

        messagebox.showinfo("已记录", "删除区间操作已加入队列。", parent=self)
        self.refresh_operations()
        self.set_status("区间删除操作已加入队列。")

    # ------------------------------------------------------------------
    def delete_device_line(self) -> None:
        if not (self.db and self.selected_device):
            messagebox.showwarning("提示", "请选择定标器。", parent=self)
            return

        device = self.selected_device
        line = self.selected_line
        if line is None:
            try:
                line = self.db.fetch_section_line(device.POINT_NO)
            except Exception as exc:  # pragma: no cover - requires database
                messagebox.showerror("删除失败", f"读取画线数据失败: {exc}", parent=self)
                return
            self._line_cache[device.POINT_NO] = line

        if line is None:
            messagebox.showinfo("提示", "此定标器无画线数据。", parent=self)
            return

        confirm = messagebox.askyesno("确认删除", "确定要删除画线数据吗？", parent=self)
        if not confirm:
            return

        self.db.queue_delete(
            line.TABLE_NAME,
            {"PKID": line.PKID},
            line.PRIMARY_KEYS,
        )
        self.selected_line = None
        self._line_cache[device.POINT_NO] = None
        self._display_line_details(None)
        messagebox.showinfo("已记录", "删除画线操作已加入队列。", parent=self)
        self.refresh_operations()
        self.set_status("删除画线操作已加入队列。")

    # ------------------------------------------------------------------
    def change_device_phone(self) -> None:
        if not (self.db and self.selected_device):
            messagebox.showwarning("提示", "请选择定标器。", parent=self)
            return

        device = self.selected_device
        dialog = PhoneChangeDialog(self, device)
        new_phone = dialog.result
        if new_phone is None:
            return

        current_phone = device.POINT_PHONENO or ""
        if new_phone == current_phone:
            messagebox.showinfo("提示", "未检测到修改。", parent=self)
            return

        updated = replace(device, POINT_PHONENO=new_phone)

        if self.devices_listbox.curselection():
            idx = self.devices_listbox.curselection()[0]
            self.devices[idx] = updated
            self.devices_listbox.delete(idx)
            self.devices_listbox.insert(idx, self._device_label(updated))
            self.devices_listbox.selection_set(idx)
        self.selected_device = updated

        self.db.queue_update(
            updated,
            updated.PRIMARY_KEYS,
            changes={"POINT_PHONENO": new_phone},
        )
        messagebox.showinfo("已记录", "手机号更新操作已加入队列。", parent=self)
        self.refresh_operations()
        self.set_status("手机号更新操作已加入队列。")

    # ------------------------------------------------------------------
    def add_section(self) -> None:
        if not self.db:
            messagebox.showwarning("提示", "请先连接数据库。", parent=self)
            return

        template = Section(
            SECTION_ID="",
            SECTION_NAME="",
            DEPT_CODE="",
            END_SCALER_INDEX="",
            END_MILE="",
            ENVIRONMENT_VOL="",
            GC_VOL="",
            LINE_DIR="",
            LINE_NAME="",
            START_SCALER_INDEX="",
            START_MILE="",
            STATION_STATION="",
        )
        dialog = EditDialog(self, "新增区间", SECTION_CREATE_FIELDS, template)
        updates = dialog.result
        if updates is None:
            return

        payload = template.to_payload()
        payload.update(updates)

        section_id = payload.get("SECTION_ID", "").strip()
        section_name = payload.get("SECTION_NAME", "").strip()
        if not section_id:
            messagebox.showwarning("提示", "区间编号不能为空。", parent=self)
            return
        if not section_name:
            messagebox.showwarning("提示", "区间名称不能为空。", parent=self)
            return

        payload["SECTION_ID"] = section_id
        payload["SECTION_NAME"] = section_name

        new_section = Section(**payload)
        self.sections.append(new_section)
        self.section_listbox.insert(tk.END, self._section_label(new_section))
        new_index = len(self.sections) - 1
        self.section_listbox.selection_clear(0, tk.END)
        self.section_listbox.selection_set(new_index)
        self.section_listbox.event_generate("<<ListboxSelect>>")

        self.db.queue_insert(new_section, new_section.PRIMARY_KEYS)
        messagebox.showinfo("已记录", "新增区间操作已加入队列。", parent=self)
        self.refresh_operations()
        self.set_status("新增区间操作已加入队列。")

    # ------------------------------------------------------------------
    def add_device(self) -> None:
        if not (self.db and self.selected_section):
            messagebox.showwarning("提示", "请选择区间。", parent=self)
            return

        section = self.selected_section
        template = Device(POINT_NO="", SECTION_ID=section.SECTION_ID)
        dialog = EditDialog(self, "新增定标器", DEVICE_CREATE_FIELDS, template)
        updates = dialog.result
        if updates is None:
            return

        payload = template.to_payload()
        payload.update(updates)
        payload["SECTION_ID"] = section.SECTION_ID

        point_no = payload.get("POINT_NO", "").strip()
        if not point_no:
            messagebox.showwarning("提示", "定标器编号不能为空。", parent=self)
            return
        payload["POINT_NO"] = point_no
        if payload.get("POINT_NAME") is not None:
            payload["POINT_NAME"] = payload["POINT_NAME"].strip()

        for field in ("POINT_ORDER",):
            value = payload.get(field)
            if value in (None, ""):
                payload[field] = None
            else:
                try:
                    payload[field] = int(value)
                except ValueError:
                    messagebox.showwarning("提示", "序号必须为数字。", parent=self)
                    return

        for field in ("MILEAGE_COORDINATE",):
            value = payload.get(field)
            if value in (None, ""):
                payload[field] = None
            else:
                try:
                    payload[field] = float(value)
                except ValueError:
                    messagebox.showwarning("提示", "里程坐标必须为数字。", parent=self)
                    return

        new_device = Device(**payload)
        self.devices.append(new_device)
        self.devices_listbox.insert(tk.END, self._device_label(new_device))
        new_index = len(self.devices) - 1
        self.devices_listbox.selection_clear(0, tk.END)
        self.devices_listbox.selection_set(new_index)
        self.selected_device = new_device

        self.db.queue_insert(new_device, new_device.PRIMARY_KEYS)
        messagebox.showinfo("已记录", "新增定标器操作已加入队列。", parent=self)
        self.refresh_operations()
        self.set_status("新增定标器操作已加入队列。")

    # ------------------------------------------------------------------
    def initialize_intranet_data(self) -> None:
        if not self.db:
            messagebox.showwarning("提示", "请先连接数据库。", parent=self)
            return

        self.set_status("正在生成内网初始化 SQL…")
        self.update_idletasks()

        try:
            sections = self.db.fetch_sections()
            devices = self.db.fetch_all_devices()
            lines = self.db.fetch_all_section_lines()
            boundaries = self.db.fetch_boundaries()
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

    # ------------------------------------------------------------------
    def backup_data(self) -> None:
        if not self.db:
            messagebox.showwarning("提示", "请先连接数据库。", parent=self)
            return

        self.set_status("正在备份数据…")
        self.update_idletasks()

        try:
            sections = self.db.fetch_sections()
            devices = self.db.fetch_all_devices()
            lines = self.db.fetch_all_section_lines()
            boundaries = self.db.fetch_boundaries()
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

    # ------------------------------------------------------------------
    def show_boundaries(self) -> None:
        if not self.db:
            messagebox.showwarning("提示", "请先连接数据库。", parent=self)
            return

        BoundaryWindow(self, lambda: self.db.fetch_boundaries())

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
            summary = self._format_operation_entry(op)
            self.operations_listbox.insert(tk.END, summary)
        self._update_controls()

    # ------------------------------------------------------------------
    def _format_operation_entry(self, op: constants.PushOperation) -> str:
        primary_parts = []
        for key in op.primary_keys:
            value = op.payload.get(key)
            primary_parts.append(f"{key}={self._display_value(value)}")

        summary = f"[{op.operation}] {op.table}"
        if primary_parts:
            summary += f" ({', '.join(primary_parts)})"

        detail_parts: List[str] = []
        if op.operation == "DELETE":
            detail_parts.append("删除记录")
        else:
            changes = op.changes or {}
            if changes:
                for key, value in changes.items():
                    detail_parts.append(f"{key}={self._display_value(value)}")
            else:
                for key, value in op.payload.items():
                    if key in op.primary_keys:
                        continue
                    if op.operation == "UPDATE" or value not in (None, ""):
                        detail_parts.append(f"{key}={self._display_value(value)}")

        if detail_parts:
            summary += f" | {'; '.join(detail_parts)}"
        return summary

    @staticmethod
    def _display_value(value: object) -> str:
        if value in (None, ""):
            return "(空)"
        return str(value)

    # ------------------------------------------------------------------
    def _section_label(self, section: Section) -> str:
        name = section.SECTION_NAME or "未命名区间"
        return f"{name} ({section.SECTION_ID})"

    def _device_label(self, device: Device) -> str:
        name = device.POINT_NAME or "未命名"
        dtype = device.TYPE or "未知类型"
        return f"{name} ({device.POINT_NO}) - {dtype}"

    def _make_insert_operation(
        self, record: object, added_at: str
    ) -> constants.PushOperation:
        if hasattr(record, "to_payload"):
            payload = record.to_payload()
        else:
            payload = {
                key: value
                for key, value in vars(record).items()
                if not key.startswith("_")
            }
        table_name = getattr(record, "TABLE_NAME", record.__class__.__name__)
        primary_keys = list(getattr(record, "PRIMARY_KEYS", ()))
        return constants.PushOperation(
            operation="INSERT",
            table=table_name,
            payload=payload,
            primary_keys=primary_keys,
            added_at=added_at,
        )

    def _write_backup_csv(self, path: Path, rows: List[dict]) -> str:
        if not rows:
            path.write_text("", encoding="utf-8")
            return str(path)

        fieldnames: List[str] = sorted({key for row in rows for key in row.keys()})
        with path.open("w", newline="", encoding="utf-8-sig") as handle:
            writer = csv.DictWriter(handle, fieldnames=fieldnames)
            writer.writeheader()
            for row in rows:
                normalized = {
                    key: "" if row.get(key) is None else row.get(key)
                    for key in fieldnames
                }
                writer.writerow(normalized)
        return str(path)

    def _not_implemented(self, feature: str) -> None:
        messagebox.showinfo(
            "提示", f"{feature} 功能暂未在 Python 版本中实现。", parent=self
        )

    def _on_section_context(self, event: tk.Event[tk.Listbox]) -> None:  # type: ignore[type-var]
        if not self.sections:
            return
        index = self.section_listbox.nearest(event.y)
        if index < 0 or index >= len(self.sections):
            return
        self.section_listbox.selection_clear(0, tk.END)
        self.section_listbox.selection_set(index)
        self.section_listbox.event_generate("<<ListboxSelect>>")
        try:
            self.section_menu.tk_popup(event.x_root, event.y_root)
        finally:
            self.section_menu.grab_release()

    def _on_device_context(self, event: tk.Event[tk.Listbox]) -> None:  # type: ignore[type-var]
        if not self.devices:
            return
        index = self.devices_listbox.nearest(event.y)
        if index < 0 or index >= len(self.devices):
            return
        self.devices_listbox.selection_clear(0, tk.END)
        self.devices_listbox.selection_set(index)
        self.devices_listbox.event_generate("<<ListboxSelect>>")

        device = self.devices[index]
        phone_state = tk.DISABLED
        if self.selected_device is device and device.TYPE != "定标器":
            phone_state = tk.NORMAL
        line_state = tk.NORMAL if self.selected_line else tk.DISABLED
        self.device_menu.entryconfig(
            self._device_menu_delete_line_index, state=line_state
        )
        self.device_menu.entryconfig(
            self._device_menu_change_phone_index, state=phone_state
        )

        try:
            self.device_menu.tk_popup(event.x_root, event.y_root)
        finally:
            self.device_menu.grab_release()

    # ------------------------------------------------------------------
    def _display_line_details(self, line: Optional[SectionLine]) -> None:
        if not hasattr(self, "line_detail_vars"):
            return
        if line is None:
            for var in self.line_detail_vars.values():
                var.set("-")
            return

        values = {
            "PKID": line.PKID,
            "POINT_NO": line.POINT_NO,
            "MILEAGE_START": line.MILEAGE_START,
            "MILEAGE_END": line.MILEAGE_END,
        }
        for field, var in self.line_detail_vars.items():
            value = values.get(field)
            if value in (None, ""):
                var.set("-")
            else:
                var.set(str(value))

    def _clear_line_details(self) -> None:
        self._display_line_details(None)

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
        line_available = self.selected_line is not None
        operations_available = bool(constants.STATE.get_operations())

        self.connect_button.configure(state=tk.DISABLED if connected else tk.NORMAL)
        self.disconnect_button.configure(state=tk.NORMAL if connected else tk.DISABLED)
        self.refresh_sections_btn.configure(state=tk.NORMAL if connected else tk.DISABLED)
        self.section_listbox.configure(state=tk.NORMAL if connected else tk.DISABLED)

        if section_selected:
            self.devices_listbox.configure(state=tk.NORMAL)
        else:
            self.devices_listbox.configure(state=tk.DISABLED)
            self.devices_listbox.selection_clear(0, tk.END)
            self.selected_device = None
            self.selected_line = None
            self._clear_line_details()

        self.update_section_btn.configure(state=tk.NORMAL if section_selected else tk.DISABLED)
        self.update_device_btn.configure(state=tk.NORMAL if device_selected else tk.DISABLED)
        self.delete_device_btn.configure(state=tk.NORMAL if device_selected else tk.DISABLED)
        self.export_sql_btn.configure(state=tk.NORMAL if operations_available else tk.DISABLED)

        self._update_menu_states(
            connected, section_selected, device_selected, operations_available
        )

    def set_status(self, message: str) -> None:
        self.status_var.set(message)

    # ------------------------------------------------------------------
    def _update_menu_states(
        self,
        connected: bool,
        section_selected: bool,
        device_selected: bool,
        operations_available: bool,
    ) -> None:
        state_connected = tk.NORMAL if connected else tk.DISABLED

        self.system_menu.entryconfig(self._menu_reload_index, state=state_connected)
        self.system_menu.entryconfig(self._menu_init_index, state=state_connected)
        self.system_menu.entryconfig(self._menu_boundary_index, state=state_connected)
        self.system_menu.entryconfig(self._menu_add_section_index, state=state_connected)
        self.system_menu.entryconfig(
            self._menu_add_device_index,
            state=tk.NORMAL if section_selected else tk.DISABLED,
        )
        self.system_menu.entryconfig(
            self._menu_export_index,
            state=tk.NORMAL if operations_available else tk.DISABLED,
        )

        self.import_menu.entryconfig(
            self._menu_import_line_index, state=state_connected
        )
        self.import_menu.entryconfig(
            self._menu_import_station_index, state=state_connected
        )
        self.backup_menu.entryconfig(self._menu_backup_index, state=state_connected)

        self.section_menu.entryconfig(
            self._section_menu_add_device_index,
            state=tk.NORMAL if section_selected else tk.DISABLED,
        )
        self.section_menu.entryconfig(
            self._section_menu_delete_index,
            state=tk.NORMAL if section_selected else tk.DISABLED,
        )
        self.device_menu.entryconfig(
            self._device_menu_delete_index,
            state=tk.NORMAL if device_selected else tk.DISABLED,
        )
        self.device_menu.entryconfig(
            self._device_menu_delete_line_index,
            state=tk.NORMAL if device_selected and line_available else tk.DISABLED,
        )
        phone_state = tk.NORMAL if device_selected else tk.DISABLED
        self.device_menu.entryconfig(
            self._device_menu_change_phone_index, state=phone_state
        )

    # ------------------------------------------------------------------
    def on_close(self) -> None:
        if self.db:
            self.disconnect()
        self.destroy()


def main() -> None:
    app = Application()
    app.mainloop()


if __name__ == "__main__":
    main()
