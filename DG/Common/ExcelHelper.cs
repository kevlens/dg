using Model;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DG.Common
{
    public class ExcelHelper<T>
    {
        public List<T> ToDataTable(string excelPath, int sheetIndex, int rowIndex)
        {
            bool isHead = true;//第一行必须是表头
            try
            {
                DataTable dt = new DataTable(Path.GetFileNameWithoutExtension(excelPath) + "_Sheet" + sheetIndex);
                IWorkbook workbook;

                //workbook = new HSSFWorkbook(file);//创建对应文件
                try
                {
                    using (FileStream file = new FileStream(excelPath, FileMode.Open, FileAccess.Read))
                    {
                        workbook = new HSSFWorkbook(file);//创建对应文件EXCEL2003
                    }
                }
                catch (Exception ex)
                {
                    using (FileStream file = new FileStream(excelPath, FileMode.Open, FileAccess.Read))
                    {
                        workbook = new XSSFWorkbook(file);//创建对应文件EXCEL2007
                    }
                }
                ISheet sheet = workbook.GetSheetAt(sheetIndex);//按索引获取工作表
                var rows = sheet.GetRowEnumerator();//获取工作表中所有行HSSFSheet.GetRow(rowIndex)获取某一行
                for (int i = 0; i < rowIndex; i++)//从第rowindex行开始读取
                {
                    rows.MoveNext();
                }
                IRow row = (IRow)rows.Current;
                try
                {
                    for (int i = 0; i < row.LastCellNum; i++)//给DataTable创建列
                    {
                        ICell cell = row.GetCell(i);
                        string columnName = isHead ? cell.ToString() : i.ToString();
                        if (columnName.Trim() == "")
                        {
                            //amm.Statu = AjaxStatu.err;
                            //amm.Msg = "表头名不能为空！";

                            //return amm;

                            columnName = "EXTNAME" + i.ToString();
                        }
                        try
                        {
                            dt.Columns.Add(columnName.Replace("\r", "").Replace("\n", "").Replace(" ", "").Trim(), typeof(string));   //去除标题头回车，换行的情况
                        }
                        catch (Exception)
                        {
                            dt.Columns.Add(columnName.Trim() + i.ToString(), typeof(string));
                        }
                    }

                }
                catch (Exception)
                {
                    return null;
                }
                if (!isHead)//如果第一行是列名则不加入DataTable
                {
                    DataRow first = dt.NewRow();
                    for (int i = 0; i < row.LastCellNum; i++)
                    {
                        ICell cell = row.GetCell(i);
                        first[i] = cell.ToString();
                    }
                    dt.Rows.Add(first);
                }
                while (rows.MoveNext())
                {
                    row = (IRow)rows.Current;
                    DataRow dataRow = dt.NewRow();
                    for (int i = 0; i < row.LastCellNum; i++)
                    {
                        ICell cell = row.GetCell(i);
                        if (cell != null)
                        {
                            if (cell.CellType == CellType.Numeric)//如果是日期或数字
                            {
                                string readvalue = GetCellValue(cell);
                                if (readvalue.IndexOf("/") > -1 || readvalue.IndexOf("-") > 1)//如果是日期
                                {
                                    dataRow[i] = cell.DateCellValue.ToString("yyyy-MM-dd HH:mm:ss");
                                }
                                else
                                {
                                    dataRow[i] = readvalue;
                                }
                            }
                            else
                            {
                                dataRow[i] = GetCellValue(cell);
                            }
                            //dataRow[i] = cell.ToString();
                        }
                        else//如果是空白
                        {
                            dataRow[i] = "";
                        }
                        if (i == dt.Columns.Count - 1)
                        {
                            break;//如果行的列比表头多则不继续读取
                        }
                    }
                    dt.Rows.Add(dataRow);
                }
                dt = removeEmpty(dt);
                return DataTableToEntityList(dt);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public  bool ToExcel(string savePath, string SheetName, string HeadName, IList listJob, string className, string note = "")
        {
            try
            {

                DataTable table = ToDataTable(listJob, className, note);
                List<int> dateCellIndex = new List<int>();//日期格式列
                bool header = true;
                //创建工作薄
                HSSFWorkbook wk = new HSSFWorkbook();
                //创建一个名称为mySheet的表
                ISheet tb = wk.CreateSheet(SheetName);
                #region 表头样式
                ICellStyle headStyle = wk.CreateCellStyle();
                headStyle.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.Yellow.Index;
                headStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                IFont font = wk.CreateFont();
                font.FontName = "宋体";
                font.FontHeightInPoints = 12;
                font.Boldweight = 700;
                headStyle.SetFont(font);
                #endregion


                #region 行样式
                ICellStyle stylerow = wk.CreateCellStyle();
                stylerow.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                IFont fontrow = wk.CreateFont();
                fontrow.FontName = "宋体";
                fontrow.FontHeightInPoints = 12;
                stylerow.SetFont(fontrow);
                stylerow.WrapText = true;
                #endregion

                #region 日期行样式
                ICellStyle dateStyle = wk.CreateCellStyle();
                IDataFormat format = wk.CreateDataFormat();
                dateStyle.DataFormat = format.GetFormat("yyyy-MM-dd HH:mm:ss");
                stylerow.WrapText = true;
                #endregion

                #region 数字样式
                ICellStyle numStyle = wk.CreateCellStyle();
                numStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("0.00");
                //IDataFormat numformat = wk.CreateDataFormat();
                //numStyle.DataFormat = numformat.GetFormat("0.00");
                #endregion
                Dictionary<string, string> excelDataMap = ReadXml(className, false, note);
                //合并标题行
                /// <param name="sheet">要合并单元格所在的sheet</param>
                /// <param name="rowstart">开始行的索引</param>
                /// <param name="rowend">结束行的索引</param>
                /// <param name="colstart">开始列的索引</param>
                /// <param name="colend">结束列的索引</param>
                tb.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(0, 0, 0, excelDataMap.Keys.Count));

                IRow rowhead = tb.CreateRow(0);//创建一行
                rowhead.HeightInPoints = 25; //行高
                ICell cellhead = rowhead.GetCell(0, MissingCellPolicy.CREATE_NULL_AS_BLANK); //在行中创建单元格
                cellhead.CellStyle = headStyle;
                cellhead.SetCellValue(HeadName);//写入表头

                //SetCellRangeAddress(tb, 0, 0, 1, 20);
                int rowIndex = 1;
                if (header)
                {
                    IRow row = tb.CreateRow(rowIndex);//创建一行
                    rowIndex++;
                    row.HeightInPoints = 25; //行高
                    int cellIndex = 0;//开始列索引
                    #region 弃用
                    //for (int i = 0; i < table.Columns.Count; i++)
                    //{
                    //    if (!table.Columns[i].ToString().EndsWith("_wennull"))
                    //    {
                    //        if (table.Columns[i].DataType.ToString() == "System.DateTime")//日期型
                    //        {
                    //            tb.SetColumnWidth(cellIndex, 20 * 256);//行宽10个汉字
                    //            dateCellIndex.Add(cellIndex);
                    //        }
                    //        else
                    //        {
                    //            tb.SetColumnWidth(cellIndex, 16 * 256);//行宽8个汉字
                    //        }
                    //        ICell cell = row.GetCell(cellIndex, MissingCellPolicy.CREATE_NULL_AS_BLANK); //在行中创建单元格
                    //        cell.CellStyle = headStyle;
                    //        cell.SetCellValue(table.Columns[i].ToString());//循环往第二行的单元格中添加数据
                    //        cellIndex++;
                    //    }
                    //} 
                    #endregion
                    foreach (var item in excelDataMap)
                    {
                        string columsName = item.Value;
                        if (table.Columns[columsName].DataType.ToString() == "System.DateTime")//日期型
                        {
                            tb.SetColumnWidth(cellIndex, 20 * 256);//行宽10个汉字
                            dateCellIndex.Add(cellIndex);
                        }
                        else
                        {
                            tb.SetColumnWidth(cellIndex, 16 * 256);//行宽8个汉字
                        }
                        ICell cell = row.GetCell(cellIndex, MissingCellPolicy.CREATE_NULL_AS_BLANK); //在行中创建单元格
                        cell.CellStyle = headStyle;
                        cell.SetCellValue(table.Columns[columsName].ToString());//循环往第二行的单元格中添加数据
                        cellIndex++;
                    }
                }
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    IRow row = tb.CreateRow(rowIndex + i);//创建一行
                    row.HeightInPoints = 20; //行高
                    int cellIndex = 0;//开始列索引
                    #region 弃用
                    //for (int c = 0; c < table.Columns.Count; c++)
                    //{
                    //    if (!table.Columns[c].ToString().EndsWith("_wennull"))
                    //    {
                    //        ICell cell = row.GetCell(cellIndex, MissingCellPolicy.CREATE_NULL_AS_BLANK); //在行中创建单元格
                    //        if (table.Columns[c].DataType.ToString() == "System.DateTime")//日期型
                    //        {
                    //            string value = table.Rows[i][c].ToString();
                    //            if (value != "")
                    //            {
                    //                cell.SetCellValue(Convert.ToDateTime(value).ToString("yyyy-MM-dd HH:mm:ss"));//循环往第二行的单元格中添加数据
                    //            }
                    //            cell.CellStyle = dateStyle;
                    //        }
                    //        else
                    //        {
                    //            cell.SetCellValue(table.Rows[i][c].ToString());//循环往第二行的单元格中添加数据
                    //            cell.CellStyle = stylerow;
                    //        }
                    //        cellIndex++;
                    //    }
                    //} 
                    #endregion

                    foreach (var item in excelDataMap)
                    {
                        string columsName = item.Value;
                        ICell cell = row.GetCell(cellIndex, MissingCellPolicy.CREATE_NULL_AS_BLANK); //在行中创建单元格
                        if (table.Columns[columsName].DataType.ToString() == "System.DateTime")//日期型
                        {
                            string value = table.Rows[i][columsName].ToString();
                            if (value != "")
                            {
                                cell.SetCellValue(Convert.ToDateTime(value).ToString("yyyy-MM-dd HH:mm:ss"));//循环往第二行的单元格中添加数据
                            }
                            cell.CellStyle = dateStyle;
                        }
                        else if (table.Columns[columsName].DataType.ToString() == "System.Decimal")
                        {
                            string value = table.Rows[i][columsName].ToString();
                            if (value != "")
                            {
                                cell.SetCellValue(Convert.ToDouble(value));//循环往第二行的单元格中添加数据
                            }
                            //cell.CellStyle = numStyle;//数字格式化，不启用
                        }
                        else
                        {
                            cell.SetCellValue(table.Rows[i][columsName].ToString());//循环往第二行的单元格中添加数据
                            cell.CellStyle = stylerow;
                        }
                        cellIndex++;
                    }
                }
                //foreach (int cellIndex in dateCellIndex)
                //{
                //    for (int y = table.Rows.Count; y < 500; y++)//至少设置500行格式
                //    {
                //        IRow row = tb.CreateRow(rowIndex + y);//创建一行
                //        row.HeightInPoints = 20; //行高
                //        ICell cell = row.GetCell(cellIndex, MissingCellPolicy.CREATE_NULL_AS_BLANK); //在行中创建单元格
                //        //cell.SetCellValue("");//循环往第二行的单元格中添加数据
                //        cell.CellStyle = dateStyle;
                //    }
                //}
                using (FileStream fs = File.OpenWrite(savePath)) //打开一个xls文件，如果没有则自行创建，如果存在myxls.xls文件则在创建是不要打开该文件！
                {
                    wk.Write(fs);   //向打开的这个xls文件中写入mySheet表并保存。
                }
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DataTable ToDataTable(IList list, string className, string note = "", string otherPath = "")
        {
            DataTable table = new DataTable();
            if (list.Count > 0)
            {
                System.Reflection.PropertyInfo[] propertys = list[0].GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    //result.Columns.Add(pi.Name);
                    string fullName = pi.PropertyType.FullName;
                    if (fullName.Contains("System.DateTime"))
                    {//日期型
                        table.Columns.Add(pi.Name, typeof(DateTime));
                    }
                    else if (fullName.Contains("System.Decimal"))
                    {//日期型
                        table.Columns.Add(pi.Name, typeof(Decimal));
                    }
                    else
                    {
                        table.Columns.Add(pi.Name, typeof(String));
                    }
                }

                table = ReplaceColumnsNameToExcel(table, className, note, otherPath);

                for (int i = 0; i < list.Count; i++)
                {
                    DataRow row = table.NewRow();
                    for (int j = 0; j < propertys.Length; j++)
                    {
                        //string piName = propertys[j].Name;
                        object obj = propertys[j].GetValue(list[i], null);
                        row[j] = obj == null ? DBNull.Value : obj;

                    }
                    table.Rows.Add(row);
                    //ArrayList tempList = new ArrayList();
                    //foreach (PropertyInfo pi in propertys)
                    //{
                    //    object obj = pi.GetValue(list[i], null);
                    //    tempList.Add(obj);
                    //}
                    //object[] array = tempList.ToArray();
                    //table.LoadDataRow(array, true);
                }
            }
            return table;
        }

        private string GetCellValue(ICell cell)
        {
            if (cell == null)
                return string.Empty;
            switch (cell.CellType)
            {

                case CellType.Blank:
                    return string.Empty;
                case CellType.Boolean:
                    return cell.BooleanCellValue.ToString().Trim();
                case CellType.Error:
                    return cell.ErrorCellValue.ToString().Trim();
                case CellType.String:
                    return cell.StringCellValue.Trim();
                case CellType.Formula:
                    try
                    {
                        HSSFFormulaEvaluator e = new HSSFFormulaEvaluator(cell.Sheet.Workbook);
                        e.EvaluateInCell(cell);
                        return cell.ToString().Trim();
                    }
                    catch
                    {
                        return cell.NumericCellValue.ToString().Trim();
                    }
                case CellType.Numeric:
                case CellType.Unknown:
                default:
                    return cell.ToString().Trim();
            }
        }

        private DataTable removeEmpty(DataTable dt)
        {
            List<DataRow> removelist = new List<DataRow>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bool rowdataisnull = true;
                for (int j = 0; j < dt.Columns.Count; j++)
                {

                    if (!string.IsNullOrEmpty(dt.Rows[i][j].ToString().Trim()))
                    {

                        rowdataisnull = false;
                    }

                }
                if (rowdataisnull)
                {
                    removelist.Add(dt.Rows[i]);
                }

            }
            for (int i = 0; i < removelist.Count; i++)
            {
                dt.Rows.Remove(removelist[i]);
            }
            return dt;
        }

        private List<T> DataTableToEntityList(DataTable p_DataSet)
        {
            List<T> result = new List<T>();
            if (p_DataSet == null )
                return result;// default(List<T>);
            if (p_DataSet.Rows.Count <= 0)
                return result;// default(List<T>);
            DataTable p_Data = p_DataSet;
            // 返回值初始化
            for (int j = 0; j < p_Data.Rows.Count; j++)
            {
                T _t = (T)Activator.CreateInstance(typeof(T));
                PropertyInfo[] propertys = _t.GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    if (p_Data.Columns.IndexOf(pi.Name.ToUpper()) != -1 && p_Data.Rows[j][pi.Name.ToUpper()] != DBNull.Value && p_Data.Rows[j][pi.Name.ToUpper()] != "")
                    {
                        if (pi.PropertyType.FullName.Contains("double"))
                        {
                            pi.SetValue(_t, Convert.ToDecimal(p_Data.Rows[j][pi.Name.ToUpper()]), null);
                        }
                        else if (p_Data.Rows[j][pi.Name.ToUpper()].GetType().Name == typeof(float).Name)
                        {
                            pi.SetValue(_t, Convert.ToDecimal(p_Data.Rows[j][pi.Name.ToUpper()]), null);
                        }
                        else if (p_Data.Rows[j][pi.Name.ToUpper()].GetType().Name == typeof(Int64).Name)
                        {
                            pi.SetValue(_t, Convert.ToDecimal(p_Data.Rows[j][pi.Name.ToUpper()]), null);
                        }
                        else if (p_Data.Rows[j][pi.Name.ToUpper()].GetType().Name == typeof(int?).Name)
                        {
                            pi.SetValue(_t, Convert.ToInt32(p_Data.Rows[j][pi.Name.ToUpper()]), null);
                        }
                        else if (pi.PropertyType.FullName.Contains("Decimal") || pi.PropertyType.FullName.Contains("Double")|| pi.PropertyType.FullName.Contains("Int64")
                            || pi.PropertyType.FullName.Contains("Single"))
                        {
                            pi.SetValue(_t, Convert.ToDecimal(p_Data.Rows[j][pi.Name.ToUpper()]), null);
                        }
                        else if (pi.PropertyType.FullName.Contains("Int32"))
                        {
                            pi.SetValue(_t, Convert.ToInt32(p_Data.Rows[j][pi.Name.ToUpper()]), null);
                        }
                        else
                        {
                            pi.SetValue(_t, p_Data.Rows[j][pi.Name.ToUpper()], null);
                        }
                    }
                    else
                    {
                        pi.SetValue(_t, null, null);
                    }
                }
                result.Add(_t);
            }
            return result;
        }

        public static Dictionary<string, string> ReadXml(string className, bool flag, string note = "", string otherPath = "")
        {
            Dictionary<string, string> excelDataMap = new Dictionary<string, string>();
            //HttpRuntime.AppDomainAppPath 网站在服务器磁盘上的物理路径
            //任何于Request/HttpContext.Current等相关的方法, 都只能在有请求上下文或者页面时使用. 即在无请求上下文时,HttpContext.Current为null. 而HttpRuntime.AppDomainAppPath方法一直可用.
            string path = Application.StartupPath + "\\excelData.xml";
            //string path = Path.Combine(HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath), "Content", "UpLoadExcel\\Excel_Data_Map.xml");
            //以下沈阳局自动导计划专用D:\\Visual Studio 2012\\Projects\\code\\Platforms-gw\\Platforms\\Web
            //string path = Path.Combine("D:\\WebFile\\sygw", "Content", "UpLoadExcel\\Excel_Data_Map.xml");
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);

            XmlNodeList listNodes = xmlDocument.SelectNodes("/datatable/dataname[@name='" + className + "']/item");
            bool orderflag = false;//是否启用排序
            foreach (XmlElement node in listNodes)
            {
                if (flag)//导入
                {
                    if (excelDataMap.ContainsKey(node.GetAttribute("key")))
                    {
                        string xx = node.GetAttribute("key");
                    }
                    else
                    {
                        excelDataMap.Add(node.GetAttribute("key"), node.GetAttribute("value"));
                    }
                }
                else//导出
                {
                    string order = node.GetAttribute("order");
                    if (order != "")
                    {
                        orderflag = true;//启用排序
                    }
                    else
                    {
                        order = "9999";
                    }
                    if (note == "")
                    {
                        excelDataMap.Add(order + "#" + node.GetAttribute("value"), node.GetAttribute("key"));
                    }
                    else
                    {
                        if (node.GetAttribute("note").IndexOf(note) > -1)
                        {
                            if (node.GetAttribute("note").IndexOf("|") > -1)//如果属于共用字段
                            {
                                int j = 0;//所在位置
                                string[] notes = node.GetAttribute("note").Split('|');
                                for (int i = 0; i < notes.Length; i++)
                                {
                                    if (notes[i] == note)
                                    {
                                        j = i;
                                        break;
                                    }
                                }
                                try
                                {
                                    order = order.Split('|')[j];
                                }
                                catch (Exception)
                                {
                                }
                            }
                            excelDataMap.Add(order + "#" + node.GetAttribute("value"), node.GetAttribute("key"));
                        }
                    }
                }
            }
            if (!flag)//导出
            {
                if (orderflag)//导出时启用排序
                {
                    excelDataMap = excelDataMap.OrderBy(i => i.Key.Split('#')[0].Length).ThenBy(i => i.Key.Split('#')[0]).ToDictionary(o => o.Key.Split('#')[1], p => p.Value);
                }
                else
                {
                    excelDataMap = excelDataMap.ToDictionary(o => o.Key.Split('#')[1], p => p.Value);
                }
            }
            return excelDataMap;

        }

        public static DataTable ReplaceColumnsNameToExcel(DataTable dt, string className, string note = "", string otherPath = "")
        {
            Dictionary<string, string> excelDataMap = ReadXml(className, false, note, otherPath);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                string columnName = dt.Columns[i].ColumnName.Trim();//数据库字段名
                if (excelDataMap.ContainsKey(columnName))//如果有此表头对应excel表头名
                {
                    dt.Columns[i].ColumnName = excelDataMap[columnName];//替换为excel表头名
                }
            }
            return dt;
        }
    }
}
