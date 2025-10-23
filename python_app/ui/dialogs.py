"""Dialog windows for the Tkinter application."""
from __future__ import annotations

from typing import Callable, List, Optional

import tkinter as tk
from tkinter import messagebox, ttk

from ..db_service import DatabaseError
from ..models import Device


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

        if first_entry is not None:
            first_entry.focus()
        self.bind("<Return>", lambda _event: self._on_ok())
        self.bind("<Escape>", lambda _event: self._on_cancel())
        self.protocol("WM_DELETE_WINDOW", self._on_cancel)

        self.wait_visibility()
        center_window(self, parent)
        self.wait_window(self)

    def _on_ok(self) -> None:
        updates: dict[str, str] = {}
        for field, var in self._variables.items():
            value = var.get().strip()
            original = getattr(self._source, field, "") or ""
            if value != str(original):
                updates[field] = value
        self.result = updates
        self.grab_release()
        self.destroy()

    def _on_cancel(self) -> None:
        self.result = None
        self.grab_release()
        self.destroy()


class PhoneChangeDialog(tk.Toplevel):
    """Dialog for updating a device's phone number."""

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

        ttk.Label(container, text="原手机号").grid(
            row=0, column=0, padx=(0, 8), pady=4, sticky="e"
        )
        ttk.Label(container, text=device.POINT_PHONENO or "-").grid(
            row=0, column=1, padx=0, pady=4, sticky="w"
        )

        ttk.Label(container, text="配对手机").grid(
            row=1, column=0, padx=(0, 8), pady=4, sticky="e"
        )
        ttk.Label(container, text=device.MATCHUP_PHONE or "-").grid(
            row=1, column=1, padx=0, pady=4, sticky="w"
        )

        ttk.Label(container, text="上一站手机").grid(
            row=2, column=0, padx=(0, 8), pady=4, sticky="e"
        )
        ttk.Label(container, text=device.PREV_PHONE or "-").grid(
            row=2, column=1, padx=0, pady=4, sticky="w"
        )

        ttk.Label(container, text="下一站手机").grid(
            row=3, column=0, padx=(0, 8), pady=4, sticky="e"
        )
        ttk.Label(container, text=device.NEXT_PHONE or "-").grid(
            row=3, column=1, padx=0, pady=4, sticky="w"
        )

        ttk.Label(container, text="新手机号").grid(
            row=4, column=0, padx=(0, 8), pady=4, sticky="e"
        )
        self._new_phone_var = tk.StringVar()
        entry = ttk.Entry(container, textvariable=self._new_phone_var, width=40)
        entry.grid(row=4, column=1, padx=0, pady=4, sticky="ew")

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
