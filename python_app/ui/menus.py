"""Menu construction and context-handling helpers."""
from __future__ import annotations

from typing import Any

import tkinter as tk
from tkinter import messagebox


class MenuMixin:
    """Provides the menubar and context menus."""

    def _build_menus(self) -> None:
        menubar = tk.Menu(self)  # type: ignore[call-arg]

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

    def _update_menu_states(
        self,
        connected: bool,
        section_selected: bool,
        device_selected: bool,
        line_available: bool,
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
            self._device_menu_update_line_index,
            state=tk.NORMAL if device_selected and line_available else tk.DISABLED,
        )
        self.device_menu.entryconfig(
            self._device_menu_delete_line_index,
            state=tk.NORMAL if device_selected and line_available else tk.DISABLED,
        )
        phone_state = tk.NORMAL if device_selected else tk.DISABLED
        self.device_menu.entryconfig(
            self._device_menu_change_phone_index, state=phone_state
        )

    def _not_implemented(self, feature: str) -> None:
        messagebox.showinfo(
            "提示", f"{feature} 功能暂未在 Python 版本中实现。", parent=self
        )

    def _on_section_context(self, event: tk.Event[Any]) -> None:
        if not self.sections:  # type: ignore[attr-defined]
            return
        index = self.section_listbox.nearest(event.y)  # type: ignore[attr-defined]
        if index < 0 or index >= len(self.sections):  # type: ignore[attr-defined]
            return
        self.section_listbox.selection_clear(0, tk.END)  # type: ignore[attr-defined]
        self.section_listbox.selection_set(index)  # type: ignore[attr-defined]
        self.section_listbox.event_generate("<<ListboxSelect>>")  # type: ignore[attr-defined]
        try:
            self.section_menu.tk_popup(event.x_root, event.y_root)  # type: ignore[attr-defined]
        finally:
            self.section_menu.grab_release()  # type: ignore[attr-defined]

    def _on_device_context(self, event: tk.Event[Any]) -> None:
        if not self.devices:  # type: ignore[attr-defined]
            return
        index = self.devices_listbox.nearest(event.y)  # type: ignore[attr-defined]
        if index < 0 or index >= len(self.devices):  # type: ignore[attr-defined]
            return
        self.devices_listbox.selection_clear(0, tk.END)  # type: ignore[attr-defined]
        self.devices_listbox.selection_set(index)  # type: ignore[attr-defined]
        self.devices_listbox.event_generate("<<ListboxSelect>>")  # type: ignore[attr-defined]

        device = self.devices[index]  # type: ignore[index]
        phone_state = tk.DISABLED
        if self.selected_device is device and device.TYPE != "定标器":  # type: ignore[attr-defined]
            phone_state = tk.NORMAL
        line_state = tk.NORMAL if self.selected_line else tk.DISABLED  # type: ignore[attr-defined]
        self.device_menu.entryconfig(  # type: ignore[attr-defined]
            self._device_menu_update_line_index, state=line_state
        )
        self.device_menu.entryconfig(  # type: ignore[attr-defined]
            self._device_menu_delete_line_index, state=line_state
        )
        self.device_menu.entryconfig(  # type: ignore[attr-defined]
            self._device_menu_change_phone_index, state=phone_state
        )

        try:
            self.device_menu.tk_popup(event.x_root, event.y_root)  # type: ignore[attr-defined]
        finally:
            self.device_menu.grab_release()  # type: ignore[attr-defined]
