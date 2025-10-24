"""Application entry point for launching the Tkinter UI."""
from __future__ import annotations

from pathlib import Path
import sys

if __package__ in (None, ""):
    current_dir = Path(__file__).resolve().parent
    project_root = current_dir.parent
    # Ensure both the package directory and its parent are available for PyInstaller builds
    for path in (project_root, current_dir):
        if str(path) not in sys.path:
            sys.path.append(str(path))
    from python_app.ui.application import Application, main  # type: ignore
else:  # pragma: no cover - exercised via module execution
    from .ui.application import Application, main

__all__ = ["Application", "main"]


if __name__ == "__main__":
    main()
