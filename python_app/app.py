"""Application entry point for launching the Tkinter UI."""
from __future__ import annotations

from .ui.application import Application, main

__all__ = ["Application", "main"]


if __name__ == "__main__":
    main()
