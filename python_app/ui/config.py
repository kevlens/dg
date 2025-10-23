"""Field definitions and display layouts for the Tkinter UI."""

# Width settings -------------------------------------------------------------
SECTION_LISTBOX_WIDTH = 36


SECTION_DISPLAY_FIELDS = [
    "SECTION_ID",
    "SECTION_NAME",
    "DEPT_CODE",
    "START_MILE",
    "END_MILE",
    "LINE_NAME",
    "LINE_DIR",
]

DEVICE_EDIT_FIELDS = [
    "POINT_NAME",
    "POINT_FLAG",
    "POINT_NOTE",
    "POINT_PHONENO",
    "TYPE",
    "POSITION",
]

SECTION_EDIT_FIELDS = [
    "SECTION_NAME",
    "DEPT_CODE",
    "START_MILE",
    "END_MILE",
    "LINE_NAME",
    "LINE_DIR",
]

SECTION_CREATE_FIELDS = [
    "SECTION_ID",
    "SECTION_NAME",
    "DEPT_CODE",
    "START_MILE",
    "END_MILE",
    "LINE_NAME",
    "LINE_DIR",
    "START_SCALER_INDEX",
    "END_SCALER_INDEX",
    "STATION_STATION",
    "GC_VOL",
    "ENVIRONMENT_VOL",
]

DEVICE_CREATE_FIELDS = [
    "POINT_NO",
    "POINT_NAME",
    "TYPE",
    "POSITION",
    "POINT_FLAG",
    "POINT_NOTE",
    "POINT_PHONENO",
    "MATCHUP_PHONE",
    "PREV_PHONE",
    "NEXT_PHONE",
    "LINE_NAME",
    "LINE_DIR",
    "LINE_CODE",
    "MILEAGE_COORDINATE",
    "POINT_ORDER",
]

SECTION_LINE_DISPLAY_FIELDS = [
    "PKID",
    "POINT_NO",
    "MILEAGE_START",
    "MILEAGE_END",
]

SECTION_LINE_EDIT_FIELDS = [
    "MILEAGE_START",
    "MILEAGE_END",
]
