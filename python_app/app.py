"""Command line interface that mirrors the WinForms workflow."""
from __future__ import annotations

import getpass
import sys
from dataclasses import replace
from typing import List, Optional

from . import constants
from .db_service import DBService, DatabaseError
from .models import Device, Section
from .sql_util import save_sql_scripts


MENU = (
    "请选择需要执行的操作:\n"
    "  1. 列出所有区间\n"
    "  2. 查看区间详情并列出定标器\n"
    "  3. 更新区间信息\n"
    "  4. 更新定标器信息\n"
    "  5. 删除定标器\n"
    "  6. 生成操作 SQL\n"
    "  7. 退出\n> "
)


class Application:
    def __init__(self) -> None:
        self.db: Optional[DBService] = None
        self.sections: List[Section] = []

    # ------------------------------------------------------------------
    def prompt_connection(self) -> None:
        host = input("数据库地址: ").strip()
        database = input("数据库名称: ").strip()
        user = input("用户名: ").strip()
        password = getpass.getpass("密码: ")

        connection_string = (
            f"DRIVER={{ODBC Driver 17 for SQL Server}};SERVER={host};"
            f"DATABASE={database};UID={user};PWD={password}"
        )
        try:
            self.db = DBService(connection_string)
        except DatabaseError as exc:
            print(f"连接数据库失败: {exc}")
            sys.exit(1)

        constants.STATE.connection_user = user
        self.db.start_keepalive()

    # ------------------------------------------------------------------
    def load_sections(self) -> None:
        if not self.db:
            raise RuntimeError("数据库尚未连接")
        try:
            self.sections = self.db.fetch_sections()
        except Exception as exc:  # pragma: no cover - requires database
            print(f"读取区间数据失败: {exc}")

    def list_sections(self) -> None:
        if not self.sections:
            print("没有可用的区间，请先加载数据。")
            return
        for idx, section in enumerate(self.sections, start=1):
            print(f"{idx}. {section.SECTION_NAME} ({section.SECTION_ID})")

    def choose_section(self) -> Optional[Section]:
        if not self.sections:
            print("需要先加载区间数据。")
            return None
        try:
            choice = int(input("请输入区间序号: "))
        except ValueError:
            print("输入无效")
            return None
        if not 1 <= choice <= len(self.sections):
            print("超出范围")
            return None
        return self.sections[choice - 1]

    # ------------------------------------------------------------------
    def show_section_details(self, section: Section) -> None:
        print("区间信息:")
        for field in (
            "SECTION_ID",
            "SECTION_NAME",
            "DEPT_CODE",
            "START_MILE",
            "END_MILE",
            "LINE_NAME",
            "LINE_DIR",
        ):
            print(f"  {field}: {getattr(section, field)}")
        self.list_devices(section)

    def list_devices(self, section: Section) -> List[Device]:
        if not self.db:
            raise RuntimeError("数据库尚未连接")
        try:
            devices = self.db.fetch_devices(section.SECTION_ID)
        except Exception as exc:  # pragma: no cover - requires database
            print(f"读取定标器失败: {exc}")
            return []
        for idx, device in enumerate(devices, start=1):
            print(f"  {idx}. {device.POINT_NAME} ({device.POINT_NO}) 类型: {device.TYPE}")
        return devices

    # ------------------------------------------------------------------
    def update_section(self, section: Section) -> None:
        if not self.db:
            raise RuntimeError("数据库尚未连接")
        updated = replace(section)
        for field in (
            "SECTION_NAME",
            "DEPT_CODE",
            "START_MILE",
            "END_MILE",
            "LINE_NAME",
            "LINE_DIR",
        ):
            current = getattr(section, field)
            new_value = input(f"{field} [{current}]: ").strip()
            if new_value:
                setattr(updated, field, new_value)
        self.db.queue_update(updated, updated.PRIMARY_KEYS)
        print("已记录更新操作，稍后可生成 SQL 文件。")

    def update_device(self, section: Section) -> None:
        devices = self.list_devices(section)
        if not devices:
            return
        try:
            choice = int(input("请输入定标器序号: "))
        except ValueError:
            print("输入无效")
            return
        if not 1 <= choice <= len(devices):
            print("超出范围")
            return
        device = devices[choice - 1]
        updated = replace(device)
        for field in (
            "POINT_NAME",
            "POINT_FLAG",
            "POINT_NOTE",
            "POINT_PHONENO",
            "TYPE",
            "POSITION",
        ):
            current = getattr(device, field)
            new_value = input(f"{field} [{current}]: ").strip()
            if new_value:
                setattr(updated, field, new_value)
        self.db.queue_update(updated, updated.PRIMARY_KEYS)
        print("已记录更新操作。")

    def delete_device(self, section: Section) -> None:
        devices = self.list_devices(section)
        if not devices:
            return
        try:
            choice = int(input("请输入要删除的定标器序号: "))
        except ValueError:
            print("输入无效")
            return
        if not 1 <= choice <= len(devices):
            print("超出范围")
            return
        device = devices[choice - 1]
        payload = {"POINT_NO": device.POINT_NO}
        if not self.db:
            raise RuntimeError("数据库尚未连接")
        self.db.queue_delete("BROKENRAIL_BDATA_DEVICE", payload, ("POINT_NO",))
        print("删除操作已加入队列。")

    # ------------------------------------------------------------------
    def export_sql(self) -> None:
        operations = constants.STATE.get_operations()
        if not operations:
            print("没有可导出的操作。")
            return
        files = save_sql_scripts(operations, prefix=constants.STATE.connection_user + "_")
        constants.STATE.reset_operations()
        print("已生成如下文件:")
        for file in files:
            print(f"  {file}")

    # ------------------------------------------------------------------
    def run(self) -> None:
        self.prompt_connection()
        self.load_sections()
        actions = {
            "1": self.list_sections,
            "2": lambda: self._action_show(),
            "3": lambda: self._action_update_section(),
            "4": lambda: self._action_update_device(),
            "5": lambda: self._action_delete_device(),
            "6": self.export_sql,
        }
        while True:
            choice = input(MENU).strip()
            if choice == "7":
                break
            action = actions.get(choice)
            if not action:
                print("无法识别的操作。")
                continue
            action()
        if self.db:
            self.db.close()

    # helpers -----------------------------------------------------------
    def _action_show(self) -> None:
        section = self.choose_section()
        if section:
            self.show_section_details(section)

    def _action_update_section(self) -> None:
        section = self.choose_section()
        if section:
            self.update_section(section)

    def _action_update_device(self) -> None:
        section = self.choose_section()
        if section:
            self.update_device(section)

    def _action_delete_device(self) -> None:
        section = self.choose_section()
        if section:
            self.delete_device(section)


def main() -> None:
    app = Application()
    app.run()


if __name__ == "__main__":
    main()
