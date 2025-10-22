# Python 版本的断轨基础数据工具

该目录包含原 WinForms 工具的 Python 命令行实现。程序依然围绕同一套数据库表工作，
但通过简化的交互式菜单来完成连接、查询、修改及生成 SQL 脚本等操作。

## 运行环境

1. 安装 Python 3.10 及以上版本。
2. 安装依赖：

```bash
pip install pyodbc
```

程序默认使用 **ODBC Driver 17 for SQL Server**。如目标服务器使用其他驱动，请按照
相应驱动修改 `python_app/app.py` 中的连接字符串。

## 使用方法

```bash
python -m python_app.app
```

随后按照提示输入数据库地址、库名、用户名和密码。成功连接后即可通过菜单执行数据
浏览及操作，所有修改都会记录在内存中，选择“生成操作 SQL”后会在当前目录的 `SQL/`
文件夹下生成与 WinForms 版本一致的三份脚本文件。
