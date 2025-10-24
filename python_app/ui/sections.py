"""Section-related actions for the Tkinter UI."""
from __future__ import annotations

from dataclasses import replace
from typing import Any

import tkinter as tk
from tkinter import messagebox

from ..models import Section
from .config import SECTION_CREATE_FIELDS, SECTION_EDIT_FIELDS
from .dialogs import EditDialog


class SectionActionsMixin:
    """Operations that manage section records."""

    def load_sections(self) -> None:
        if not self.db:  # type: ignore[attr-defined]
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

        self.sections = sections  # type: ignore[attr-defined]
        self.section_listbox.delete(0, tk.END)  # type: ignore[attr-defined]
        for section in sections:
            self.section_listbox.insert(tk.END, self._section_label(section))  # type: ignore[attr-defined]

        self.selected_section = None  # type: ignore[attr-defined]
        self.selected_device = None  # type: ignore[attr-defined]
        self.selected_line = None  # type: ignore[attr-defined]
        self._line_cache = {}  # type: ignore[attr-defined]
        self.devices = []  # type: ignore[attr-defined]
        self.devices_listbox.delete(0, tk.END)  # type: ignore[attr-defined]
        self._clear_section_details()
        self._clear_line_details()
        self.refresh_operations()
        self.set_status(f"已加载 {len(sections)} 个区间。")
        self._update_controls()

    def on_section_selected(self, event: tk.Event[Any]) -> None:
        if not self.section_listbox.curselection():  # type: ignore[attr-defined]
            return
        index = self.section_listbox.curselection()[0]  # type: ignore[attr-defined]
        if index >= len(self.sections):  # type: ignore[attr-defined]
            return
        section = self.sections[index]  # type: ignore[index]
        self.selected_section = section  # type: ignore[attr-defined]
        self._display_section_details(section)
        self.load_devices(section)
        self._update_controls()

    def update_section(self) -> None:
        if not (self.db and self.selected_section):  # type: ignore[attr-defined]
            messagebox.showwarning("提示", "请选择区间。", parent=self)
            return
        section = self.selected_section  # type: ignore[assignment]
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
        if self.section_listbox.curselection():  # type: ignore[attr-defined]
            idx = self.section_listbox.curselection()[0]  # type: ignore[attr-defined]
            self.sections[idx] = updated  # type: ignore[index]
            self.section_listbox.delete(idx)  # type: ignore[attr-defined]
            self.section_listbox.insert(idx, self._section_label(updated))  # type: ignore[attr-defined]
            self.section_listbox.selection_set(idx)  # type: ignore[attr-defined]
        self.selected_section = updated  # type: ignore[attr-defined]
        self._display_section_details(updated)
        self.db.queue_update(updated, updated.PRIMARY_KEYS, changes=updates)  # type: ignore[union-attr]
        messagebox.showinfo("已记录", "区间更新操作已加入队列。", parent=self)
        self.refresh_operations()
        self.set_status("区间更新操作已加入队列。")

    def add_section(self) -> None:
        if not self.db:  # type: ignore[attr-defined]
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
        self.sections.append(new_section)  # type: ignore[attr-defined]
        self.section_listbox.insert(tk.END, self._section_label(new_section))  # type: ignore[attr-defined]
        new_index = len(self.sections) - 1  # type: ignore[attr-defined]
        self.section_listbox.selection_clear(0, tk.END)  # type: ignore[attr-defined]
        self.section_listbox.selection_set(new_index)  # type: ignore[attr-defined]
        self.section_listbox.event_generate("<<ListboxSelect>>")  # type: ignore[attr-defined]

        self.db.queue_insert(new_section, new_section.PRIMARY_KEYS)  # type: ignore[union-attr]
        messagebox.showinfo("已记录", "新增区间操作已加入队列。", parent=self)
        self.refresh_operations()
        self.set_status("新增区间操作已加入队列。")

    def delete_section(self) -> None:
        if not (self.db and self.selected_section):  # type: ignore[attr-defined]
            messagebox.showwarning("提示", "请选择要删除的区间。", parent=self)
            return

        section = self.selected_section  # type: ignore[assignment]
        confirm = messagebox.askyesno(
            "确认删除",
            f"确定要删除区间 {section.SECTION_NAME} ({section.SECTION_ID}) 吗？",
            parent=self,
        )
        if not confirm:
            return

        try:
            devices = self.db.fetch_devices(section.SECTION_ID)  # type: ignore[union-attr]
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
                line = self.db.fetch_section_line(device.POINT_NO)  # type: ignore[union-attr]
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

        if self.section_listbox.curselection():  # type: ignore[attr-defined]
            index = self.section_listbox.curselection()[0]  # type: ignore[attr-defined]
        else:
            index = self.sections.index(section)  # type: ignore[attr-defined]
        self.section_listbox.delete(index)  # type: ignore[attr-defined]
        del self.sections[index]  # type: ignore[attr-defined]

        self.selected_section = None  # type: ignore[attr-defined]
        self.selected_device = None  # type: ignore[attr-defined]
        self.devices = []  # type: ignore[attr-defined]
        self.devices_listbox.delete(0, tk.END)  # type: ignore[attr-defined]
        self._clear_section_details()

        messagebox.showinfo("已记录", "删除区间操作已加入队列。", parent=self)
        self.refresh_operations()
        self.set_status("区间删除操作已加入队列。")

    def _section_label(self, section: Section) -> str:
        return f"{section.SECTION_NAME} ({section.SECTION_ID})"
