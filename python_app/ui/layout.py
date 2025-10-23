"""Layout construction helpers for the Tkinter UI."""
from __future__ import annotations

from typing import Optional

import tkinter as tk
from tkinter import ttk

from .. import constants
from ..models import Section, SectionLine
from .config import (
    SECTION_DISPLAY_FIELDS,
    SECTION_LINE_DISPLAY_FIELDS,
    SECTION_LISTBOX_WIDTH,
)


class LayoutMixin:
    """Builds the static widgets and handles control state."""

    def _build_ui(self) -> None:
        self.columnconfigure(0, weight=1)
        self.columnconfigure(1, weight=1)
        self.rowconfigure(1, weight=1)
        self.rowconfigure(2, weight=1)
        self.rowconfigure(3, weight=0)

        # connection controls -------------------------------------------------
        conn_frame = ttk.LabelFrame(self, text="数据库连接")  # type: ignore[call-arg]
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
            sections_frame,
            exportselection=False,
            height=18,
            width=SECTION_LISTBOX_WIDTH,
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

        self.section_menu = tk.Menu(self, tearoff=0)  # type: ignore[call-arg]
        self.section_menu.add_command(label="新增定标器", command=self.add_device)
        self._section_menu_add_device_index = self.section_menu.index("end")
        self.section_menu.add_command(label="删除区间", command=self.delete_section)
        self._section_menu_delete_index = self.section_menu.index("end")

        self.device_menu = tk.Menu(self, tearoff=0)  # type: ignore[call-arg]
        self.device_menu.add_command(label="删除定标器", command=self.delete_device)
        self._device_menu_delete_index = self.device_menu.index("end")
        self.device_menu.add_command(label="更新画线", command=self.update_line)
        self._device_menu_update_line_index = self.device_menu.index("end")
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

        self.update_line_btn = ttk.Button(
            line_frame, text="更新画线信息", command=self.update_line
        )
        self.update_line_btn.grid(
            row=len(SECTION_LINE_DISPLAY_FIELDS),
            column=0,
            columnspan=2,
            pady=(10, 5),
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

    def _display_section_details(self, section: Section) -> None:
        for field in SECTION_DISPLAY_FIELDS:
            value = getattr(section, field, "") or "-"
            self.section_detail_vars[field].set(value)

    def _clear_section_details(self) -> None:
        for var in self.section_detail_vars.values():
            var.set("-")

    def _update_controls(self) -> None:
        connected = self.db is not None  # type: ignore[attr-defined]
        section_selected = self.selected_section is not None  # type: ignore[attr-defined]
        device_selected = self.selected_device is not None  # type: ignore[attr-defined]
        line_available = self.selected_line is not None  # type: ignore[attr-defined]
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
            self.selected_device = None  # type: ignore[attr-defined]
            self.selected_line = None  # type: ignore[attr-defined]
            self._clear_line_details()

        self.update_section_btn.configure(state=tk.NORMAL if section_selected else tk.DISABLED)
        self.update_device_btn.configure(state=tk.NORMAL if device_selected else tk.DISABLED)
        self.delete_device_btn.configure(state=tk.NORMAL if device_selected else tk.DISABLED)
        self.update_line_btn.configure(state=tk.NORMAL if line_available else tk.DISABLED)
        self.export_sql_btn.configure(
            state=tk.NORMAL if operations_available else tk.DISABLED
        )

        self._update_menu_states(
            connected, section_selected, device_selected, line_available, operations_available
        )

    def set_status(self, message: str) -> None:
        self.status_var.set(message)
