"""Dataclasses mirroring the small subset of entities used by the toolkit."""
from __future__ import annotations

from dataclasses import dataclass, field, asdict
from datetime import datetime
from typing import Any, Dict, Iterable, List, Optional


@dataclass
class Section:
    SECTION_ID: str
    SECTION_NAME: str
    DEPT_CODE: str = ""
    END_SCALER_INDEX: str = ""
    END_MILE: str = ""
    ENVIRONMENT_VOL: str = ""
    GC_VOL: str = ""
    LINE_DIR: str = ""
    LINE_NAME: str = ""
    START_SCALER_INDEX: str = ""
    START_MILE: str = ""
    STATION_STATION: str = ""

    TABLE_NAME: str = field(init=False, default="BROKENRAIL_BDATA_SECTION")
    PRIMARY_KEYS: Iterable[str] = ("SECTION_ID",)

    def to_payload(self) -> Dict[str, Any]:
        payload = asdict(self)
        payload.pop("TABLE_NAME", None)
        payload.pop("PRIMARY_KEYS", None)
        return payload


@dataclass
class Device:
    POINT_NO: str
    SECTION_ID: str
    POINT_NAME: str = ""
    LINE_CODE: str = ""
    LINE_NAME: str = ""
    LINE_DIR: str = ""
    POINT_FLAG: str = ""
    POINT_NOTE: str = ""
    POINT_PHONENO: str = ""
    POSITION: str = ""
    TYPE: str = ""
    DEVICE_MODE: str = ""
    MATCHUP_PHONE: str = ""
    PREV_PHONE: str = ""
    NEXT_PHONE: str = ""
    PREV_SCALER_MILEAGE: str = ""
    NEXT_SCALER_MILEAGE: str = ""
    IS_END: str = ""
    LEFT_FREQUENCY: str = ""
    RIGHT_FREQUENCY: str = ""
    VOLTAGE: str = ""
    POINT_ORDER: Optional[int] = None
    MILEAGE_COORDINATE: Optional[float] = None
    LONGITUDE: Optional[float] = None
    LATITUDE: Optional[float] = None
    MARSLONGITUDE: Optional[float] = None
    MARSLATITUDE: Optional[float] = None
    BAIDULONGITUDE: Optional[float] = None
    BAIDULATITUDE: Optional[float] = None

    TABLE_NAME: str = field(init=False, default="BROKENRAIL_BDATA_DEVICE")
    PRIMARY_KEYS: Iterable[str] = ("POINT_NO",)

    def to_payload(self) -> Dict[str, Any]:
        payload = asdict(self)
        payload.pop("TABLE_NAME", None)
        payload.pop("PRIMARY_KEYS", None)
        return payload


@dataclass
class SectionLine:
    PKID: str
    POINT_NO: str
    MILEAGE_START: Optional[float] = None
    MILEAGE_END: Optional[float] = None

    TABLE_NAME: str = field(init=False, default="BROKENRAIL_SECTION_LINE")
    PRIMARY_KEYS: Iterable[str] = ("PKID",)

    def to_payload(self) -> Dict[str, Any]:
        payload = asdict(self)
        payload.pop("TABLE_NAME", None)
        payload.pop("PRIMARY_KEYS", None)
        return payload


@dataclass
class Boundary:
    PKID: str
    SECTION_ID: str
    BOUNDARY_NAME: str

    TABLE_NAME: str = field(init=False, default="BROKENRAIL_BDATA_BOUNDARY")
    PRIMARY_KEYS: Iterable[str] = ("PKID",)

    def to_payload(self) -> Dict[str, Any]:
        payload = asdict(self)
        payload.pop("TABLE_NAME", None)
        payload.pop("PRIMARY_KEYS", None)
        return payload


@dataclass
class PushBasicData:
    dataop: str
    datatype: str
    datatext: Dict[str, Any]
    addtime: datetime = field(default_factory=datetime.utcnow)
    status: int = 0
    errnum: int = 0


__all__ = [
    "Section",
    "Device",
    "SectionLine",
    "Boundary",
    "PushBasicData",
]
