"""Ensure the Python port remains importable when launching from the DG project."""
from __future__ import annotations

import sys
from pathlib import Path

# When the PyCharm project is set to the legacy C# solution directory (DG),
# the interpreter's ``sys.path`` does not include the repository root where the
# ``python_app`` package lives.  Adding the parent directory here mirrors the
# behavior of opening the full repository as the project root so that
# ``python_app.app`` can always be imported via ``python -m python_app.app``.
_repo_root = Path(__file__).resolve().parents[1]
_repo_root_str = str(_repo_root)
if _repo_root_str not in sys.path:
    sys.path.insert(0, _repo_root_str)
