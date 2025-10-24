"""Primary Tkinter application window."""
from __future__ import annotations

from typing import List, Optional

import tkinter as tk

from .. import constants
from ..db_service import DBService
from ..models import Device, Section, SectionLine
from .connection import ConnectionMixin
from .data import DataActionsMixin
from .devices import DeviceActionsMixin
from .layout import LayoutMixin
from .menus import MenuMixin
from .operations import OperationLogMixin
from .sections import SectionActionsMixin


class Application(
    tk.Tk,
    MenuMixin,
    LayoutMixin,
    ConnectionMixin,
    SectionActionsMixin,
    DeviceActionsMixin,
    DataActionsMixin,
    OperationLogMixin,
):
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

    def on_close(self) -> None:
        if self.db:
            self.disconnect()
        self.destroy()


def main() -> None:
    app = Application()
    app.mainloop()
