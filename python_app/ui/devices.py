"""Device-related actions for the Tkinter UI."""
from __future__ import annotations

import uuid
from dataclasses import replace
from typing import Any

import tkinter as tk
from tkinter import messagebox

from ..models import Device, Section, SectionLine
from .config import (
    DEVICE_CREATE_FIELDS,
    DEVICE_EDIT_FIELDS,
    SECTION_LINE_EDIT_FIELDS,
)
from .dialogs import EditDialog, PhoneChangeDialog


class DeviceActionsMixin:
    """Operations that manage device and section-line records."""

    def load_devices(self, section: Section) -> None:
        if not self.db:  # type: ignore[attr-defined]
            return
        self.set_status("正在读取定标器列表…")
        self.update_idletasks()
        try:
            devices = self.db.fetch_devices(section.SECTION_ID)  # type: ignore[union-attr]
        except Exception as exc:  # pragma: no cover - requires database
            messagebox.showerror("读取失败", f"读取定标器失败: {exc}", parent=self)
            self.set_status("读取定标器失败。")
            return

        self.devices = devices  # type: ignore[attr-defined]
        self.devices_listbox.configure(state=tk.NORMAL)  # type: ignore[attr-defined]
        self.devices_listbox.delete(0, tk.END)  # type: ignore[attr-defined]
        for device in devices:
            self.devices_listbox.insert(tk.END, self._device_label(device))  # type: ignore[attr-defined]
        self.selected_device = None  # type: ignore[attr-defined]
        self.selected_line = None  # type: ignore[attr-defined]
        self._line_cache = {}  # type: ignore[attr-defined]
        self._clear_line_details()
        self._update_controls()
        self.set_status(
            f"区间 {section.SECTION_NAME} 包含 {len(devices)} 个定标器。"
        )

    def on_device_selected(self, event: tk.Event[Any]) -> None:
        if not self.devices_listbox.curselection():  # type: ignore[attr-defined]
            return
        index = self.devices_listbox.curselection()[0]  # type: ignore[attr-defined]
        if index >= len(self.devices):  # type: ignore[attr-defined]
            return
        self.selected_device = self.devices[index]  # type: ignore[index]
        self._load_line_details(self.selected_device)  # type: ignore[arg-type]
        self._update_controls()

    def _load_line_details(self, device: Device) -> None:
        if not self.db:  # type: ignore[attr-defined]
            self.selected_line = None  # type: ignore[attr-defined]
            self._clear_line_details()
            return

        point_no = device.POINT_NO
        fetched_from_db = point_no not in self._line_cache  # type: ignore[attr-defined]
        if fetched_from_db:
            try:
                line = self.db.fetch_section_line(point_no)  # type: ignore[union-attr]
            except Exception as exc:  # pragma: no cover - requires database
                messagebox.showerror("读取失败", f"读取画线数据失败: {exc}", parent=self)
                line = None
            self._line_cache[point_no] = line  # type: ignore[attr-defined]
        else:
            line = self._line_cache.get(point_no)  # type: ignore[attr-defined]

        self.selected_line = line  # type: ignore[attr-defined]
        self._display_line_details(line)
        if line:
            start = line.MILEAGE_START if line.MILEAGE_START is not None else "-"
            end = line.MILEAGE_END if line.MILEAGE_END is not None else "-"
            self.set_status(f"画线范围：{start} - {end}。")
        else:
            self.set_status("此定标器暂无画线信息。")

    def update_device(self) -> None:
        if not (self.db and self.selected_device and self.selected_section):  # type: ignore[attr-defined]
            messagebox.showwarning("提示", "请选择定标器。", parent=self)
            return
        device = self.selected_device  # type: ignore[assignment]
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
        if self.devices_listbox.curselection():  # type: ignore[attr-defined]
            idx = self.devices_listbox.curselection()[0]  # type: ignore[attr-defined]
            self.devices[idx] = updated  # type: ignore[index]
            self.devices_listbox.delete(idx)  # type: ignore[attr-defined]
            self.devices_listbox.insert(idx, self._device_label(updated))  # type: ignore[attr-defined]
            self.devices_listbox.selection_set(idx)  # type: ignore[attr-defined]
        self.selected_device = updated  # type: ignore[attr-defined]
        self.db.queue_update(updated, updated.PRIMARY_KEYS, changes=updates)  # type: ignore[union-attr]
        messagebox.showinfo("已记录", "定标器更新操作已加入队列。", parent=self)
        self.refresh_operations()
        self.set_status("定标器更新操作已加入队列。")

    def update_line(self) -> None:
        if not (self.db and self.selected_device):  # type: ignore[attr-defined]
            messagebox.showwarning("提示", "请选择定标器。", parent=self)
            return

        line = self.selected_line  # type: ignore[attr-defined]
        if line is None:
            messagebox.showwarning("提示", "此定标器没有画线数据。", parent=self)
            return

        dialog = EditDialog(self, "更新画线信息", SECTION_LINE_EDIT_FIELDS, line)
        updates = dialog.result
        if updates is None:
            return
        if not updates:
            messagebox.showinfo("提示", "未检测到修改。", parent=self)
            return

        converted: dict[str, float | None] = {}
        for field, value in updates.items():
            if value == "":
                converted[field] = None
            else:
                try:
                    converted[field] = float(value)
                except ValueError:
                    messagebox.showwarning("提示", "起止里程必须为数字。", parent=self)
                    return

        updated = replace(line)
        for field, value in converted.items():
            setattr(updated, field, value)

        self.selected_line = updated  # type: ignore[attr-defined]
        if self.selected_device:  # type: ignore[attr-defined]
            self._line_cache[self.selected_device.POINT_NO] = updated  # type: ignore[attr-defined]
        self._display_line_details(updated)

        self.db.queue_update(updated, updated.PRIMARY_KEYS, changes=converted)  # type: ignore[union-attr]
        messagebox.showinfo("已记录", "画线更新操作已加入队列。", parent=self)
        self.refresh_operations()
        self.set_status("画线更新操作已加入队列。")

    def delete_device(self) -> None:
        if not (self.db and self.selected_device):  # type: ignore[attr-defined]
            messagebox.showwarning("提示", "请选择要删除的定标器。", parent=self)
            return
        device = self.selected_device  # type: ignore[assignment]
        confirm = messagebox.askyesno(
            "确认删除",
            f"确定要删除定标器 {device.POINT_NAME or device.POINT_NO} ({device.POINT_NO}) 吗？",
            parent=self,
        )
        if not confirm:
            return
        payload = {"POINT_NO": device.POINT_NO}
        self.db.queue_delete("BROKENRAIL_BDATA_DEVICE", payload, ("POINT_NO",))  # type: ignore[union-attr]
        messagebox.showinfo("已记录", "删除操作已加入队列。", parent=self)
        self.refresh_operations()
        self.set_status("定标器删除操作已加入队列。")

    def delete_device_line(self) -> None:
        if not (self.db and self.selected_device):  # type: ignore[attr-defined]
            messagebox.showwarning("提示", "请选择定标器。", parent=self)
            return

        device = self.selected_device  # type: ignore[assignment]
        line = self.selected_line  # type: ignore[attr-defined]
        if line is None:
            try:
                line = self.db.fetch_section_line(device.POINT_NO)  # type: ignore[union-attr]
            except Exception as exc:  # pragma: no cover - requires database
                messagebox.showerror("删除失败", f"读取画线数据失败: {exc}", parent=self)
                return
            self._line_cache[device.POINT_NO] = line  # type: ignore[attr-defined]

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
        self.selected_line = None  # type: ignore[attr-defined]
        self._line_cache[device.POINT_NO] = None  # type: ignore[attr-defined]
        self._display_line_details(None)
        messagebox.showinfo("已记录", "删除画线操作已加入队列。", parent=self)
        self.refresh_operations()
        self.set_status("删除画线操作已加入队列。")

    def change_device_phone(self) -> None:
        if not (self.db and self.selected_device):  # type: ignore[attr-defined]
            messagebox.showwarning("提示", "请选择定标器。", parent=self)
            return

        device = self.selected_device  # type: ignore[assignment]
        dialog = PhoneChangeDialog(self, device)
        new_phone = dialog.result
        if new_phone is None:
            return

        current_phone = device.POINT_PHONENO or ""
        if new_phone == current_phone:
            messagebox.showinfo("提示", "未检测到修改。", parent=self)
            return

        updated = replace(device, POINT_PHONENO=new_phone)

        if self.devices_listbox.curselection():  # type: ignore[attr-defined]
            idx = self.devices_listbox.curselection()[0]  # type: ignore[attr-defined]
            self.devices[idx] = updated  # type: ignore[index]
            self.devices_listbox.delete(idx)  # type: ignore[attr-defined]
            self.devices_listbox.insert(idx, self._device_label(updated))  # type: ignore[attr-defined]
            self.devices_listbox.selection_set(idx)  # type: ignore[attr-defined]
        self.selected_device = updated  # type: ignore[attr-defined]

        self.db.queue_update(
            updated,
            updated.PRIMARY_KEYS,
            changes={"POINT_PHONENO": new_phone},
        )  # type: ignore[union-attr]
        messagebox.showinfo("已记录", "手机号更新操作已加入队列。", parent=self)
        self.refresh_operations()
        self.set_status("手机号更新操作已加入队列。")

    def add_device(self) -> None:
        if not (self.db and self.selected_section):  # type: ignore[attr-defined]
            messagebox.showwarning("提示", "请选择区间。", parent=self)
            return

        section = self.selected_section  # type: ignore[assignment]
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
        self.devices.append(new_device)  # type: ignore[attr-defined]
        self.devices_listbox.insert(tk.END, self._device_label(new_device))  # type: ignore[attr-defined]
        new_index = len(self.devices) - 1  # type: ignore[attr-defined]
        self.devices_listbox.selection_clear(0, tk.END)  # type: ignore[attr-defined]
        self.devices_listbox.selection_set(new_index)  # type: ignore[attr-defined]
        self.selected_device = new_device  # type: ignore[attr-defined]

        self.db.queue_insert(new_device, new_device.PRIMARY_KEYS)  # type: ignore[union-attr]

        new_line = SectionLine(
            PKID=str(uuid.uuid4()),
            POINT_NO=new_device.POINT_NO,
            MILEAGE_START=None,
            MILEAGE_END=None,
        )
        self._line_cache[new_device.POINT_NO] = new_line  # type: ignore[attr-defined]
        self.selected_line = new_line  # type: ignore[attr-defined]
        self._display_line_details(new_line)
        self.db.queue_insert(new_line, new_line.PRIMARY_KEYS)  # type: ignore[union-attr]

        messagebox.showinfo("已记录", "新增定标器及画线操作已加入队列。", parent=self)
        self.refresh_operations()
        self.set_status("新增定标器及画线操作已加入队列。")

    def _device_label(self, device: Device) -> str:
        return f"{device.POINT_NAME or device.POINT_NO} ({device.POINT_NO})"
