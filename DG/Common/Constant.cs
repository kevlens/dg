using Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DG.Common
{
    public static class Constant
    {
        public static SqlSugarClient client = null;

        public static List<PushBasicData> opList = new List<PushBasicData>();

        public static string pathext = string.Empty;

        public static bool isop = false;
        private static void tb_KeyPressNumberAndMinus(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是负号，退格且不能转为小数，则屏蔽输入
            if (!(e.KeyChar == '-' || e.KeyChar == '\b' || float.TryParse(((TextBox)sender).Text + e.KeyChar.ToString(), out float f)))
            {
                e.Handled = true;
            }
        }
        public static void SetTextBoxOnlyNumberAndMinus(this Control ctrl)
        {
            foreach (Control item in ctrl.Controls)
            {
                if (item is TextBox)
                {
                    if(item.Name.ToUpper().Contains("MILE") || item.Name.ToUpper().Contains("LON") || item.Name.ToUpper().Contains("LAT"))
                    ((TextBox)item).KeyPress += tb_KeyPressNumberAndMinus;
                }
                else
                {
                    SetTextBoxOnlyNumberAndMinus(item);
                }
            }
        }

        public static void SaveFile(List<PushBasicData> pbdList, string name)
        {
            try
            {
                string sqlpath = Environment.CurrentDirectory + "\\SQL\\SQL_" + name + DateTime.Now.ToString("yyyyMMddHHmmss") + ".SQL";
                string orapath = Environment.CurrentDirectory + "\\SQL\\ORA_" + name + DateTime.Now.ToString("yyyyMMddHHmmss") + ".SQL";
                string tranpath = Environment.CurrentDirectory + "\\SQL\\SQL穿网_" + name + DateTime.Now.ToString("yyyyMMddHHmmss") + ".SQL";

                using (StreamWriter file = new StreamWriter(tranpath))
                {
                    foreach (var line in pbdList)
                    {
                        if (!line.datatype.EndsWith("HIS"))
                        {
                            file.WriteLine(string.Format("INSERT INTO PushBasicData values('{0}','{1}','{2}','{3}','{4}','{5}');",
                                line.dataop, line.datatype, line.datatext, line.status, line.addtime,line.errnum));
                        }
                    }

                }
                using (StreamWriter file = new StreamWriter(orapath))
                {
                    WriteFile(file, pbdList, "ORA");
                }
                using(StreamWriter file = new StreamWriter(sqlpath))
                {
                    WriteFile(file, pbdList, "SQL");
                }
                MessageBox.Show("生成SQL文件成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("生成SQL文件失败" + ex.ToString());
            }
        }

        private static void WriteFile(StreamWriter file, List<PushBasicData> pbdList, string type)
        {
            foreach (var line in pbdList)
            {
                string sql = string.Empty;
                switch (line.dataop)
                {
                    case "INSERT":
                        if (line.datatype == "BROKENRAIL_BDATA_SECTION")
                        {
                            var si = Newtonsoft.Json.JsonConvert.DeserializeObject<BROKENRAIL_BDATA_SECTION>(line.datatext);
                            sql = SQLUtil.GetSQL("INSERT", si, type);
                        }
                        else if (line.datatype == "BROKENRAIL_BDATA_DEVICE")
                        {  
                            var di = Newtonsoft.Json.JsonConvert.DeserializeObject<BROKENRAIL_BDATA_DEVICE>(line.datatext);
                            sql = SQLUtil.GetSQL("INSERT", di, type);
                        }
                        else if (line.datatype == "BROKENRAIL_SECTION_LINE")
                        {
                            var li = Newtonsoft.Json.JsonConvert.DeserializeObject<BROKENRAIL_SECTION_LINE>(line.datatext);
                            sql = SQLUtil.GetSQL("INSERT", li, type);
                        }
                        else if (line.datatype == "BROKENRAIL_BDATA_BOUNDARY")
                        {
                            var bi = Newtonsoft.Json.JsonConvert.DeserializeObject<BROKENRAIL_BDATA_BOUNDARY>(line.datatext);
                            sql = SQLUtil.GetSQL("INSERT", bi, type);
                        }
                        else if(line.datatype == "T_GIS_LINE")
                        {
                            var gl = Newtonsoft.Json.JsonConvert.DeserializeObject<T_GIS_LINE>(line.datatext);
                            sql = SQLUtil.GetSQL("INSERT", gl, type);
                        }
                        else if (line.datatype == "T_GIS_STATION")
                        {
                            var gl = Newtonsoft.Json.JsonConvert.DeserializeObject<T_GIS_STATION>(line.datatext);
                            sql = SQLUtil.GetSQL("INSERT", gl, type);
                        }
                        break;
                    case "UPDATE":
                        if (line.datatype == "BROKENRAIL_BDATA_SECTION")
                        {
                            var si = Newtonsoft.Json.JsonConvert.DeserializeObject<BROKENRAIL_BDATA_SECTION>(line.datatext);
                            sql = SQLUtil.GetSQL("UPDATE", si, type);
                        }
                        else if (line.datatype == "BROKENRAIL_BDATA_DEVICE")
                        {
                            var di = Newtonsoft.Json.JsonConvert.DeserializeObject<BROKENRAIL_BDATA_DEVICE>(line.datatext);
                            sql = SQLUtil.GetSQL("UPDATE", di, type);

                        }
                        else if (line.datatype == "BROKENRAIL_SECTION_LINE")
                        {
                            var li = Newtonsoft.Json.JsonConvert.DeserializeObject<BROKENRAIL_SECTION_LINE>(line.datatext);
                            sql = SQLUtil.GetSQL("UPDATE", li, type);

                        }
                        else if (line.datatype == "BROKENRAIL_BDATA_BOUNDARY")
                        {
                            var bi = Newtonsoft.Json.JsonConvert.DeserializeObject<BROKENRAIL_BDATA_BOUNDARY>(line.datatext);
                            sql = SQLUtil.GetSQL("UPDATE", bi, type);
                        }
                        break;
                    case "DELETE":
                        if (line.datatype == "BROKENRAIL_BDATA_SECTION")
                        {
                            var si = Newtonsoft.Json.JsonConvert.DeserializeObject<BROKENRAIL_BDATA_SECTION>(line.datatext);
                            sql = SQLUtil.GetSQL("DELETE", si, type);
                        }
                        else if (line.datatype == "BROKENRAIL_BDATA_DEVICE")
                        {
                            var di = Newtonsoft.Json.JsonConvert.DeserializeObject<BROKENRAIL_BDATA_DEVICE>(line.datatext);
                            sql = SQLUtil.GetSQL("DELETE", di, type);

                        }
                        else if (line.datatype == "BROKENRAIL_SECTION_LINE")
                        {
                            var li = Newtonsoft.Json.JsonConvert.DeserializeObject<BROKENRAIL_SECTION_LINE>(line.datatext);
                            sql = SQLUtil.GetSQL("DELETE", li, type);
                        }
                        else if (line.datatype == "BROKENRAIL_BDATA_BOUNDARY")
                        {
                            var bi = Newtonsoft.Json.JsonConvert.DeserializeObject<BROKENRAIL_BDATA_BOUNDARY>(line.datatext);
                            sql = SQLUtil.GetSQL("DELETE", bi, type);
                        }
                        else if (line.datatype == "BROKENRAIL_DEVICE_STATUS")
                        {
                            var ds = Newtonsoft.Json.JsonConvert.DeserializeObject<BROKENRAIL_DEVICE_STATUS>(line.datatext);
                            sql = SQLUtil.GetSQL("DELETE", ds, type);
                        }
                        else if (line.datatype == "BROKENRAIL_DEVICE_STATUSHIS")
                        {
                            var dsh = Newtonsoft.Json.JsonConvert.DeserializeObject<BROKENRAIL_DEVICE_STATUSHIS>(line.datatext);
                            sql = SQLUtil.GetSQL("DELETE", dsh, type);
                        }
                        else if (line.datatype == "BROKENRAIL_SECTION_STATUS")
                        {
                            var ss = Newtonsoft.Json.JsonConvert.DeserializeObject<BROKENRAIL_SECTION_STATUS>(line.datatext);
                            sql = SQLUtil.GetSQL("DELETE", ss, type);
                        }
                        else if (line.datatype == "BROKENRAIL_SECTION_STATUSHIS")
                        {
                            var ssh = Newtonsoft.Json.JsonConvert.DeserializeObject<BROKENRAIL_SECTION_STATUSHIS>(line.datatext);
                            sql = SQLUtil.GetSQL("DELETE", ssh, type);
                        }
                        else if (line.datatype == "BROKENRAIL_VOLTAGE_STATUS")
                        {
                            var vs = Newtonsoft.Json.JsonConvert.DeserializeObject<BROKENRAIL_VOLTAGE_STATUS>(line.datatext);
                            sql = SQLUtil.GetSQL("DELETE", vs, type);
                        }
                        else if (line.datatype == "BROKENRAIL_VOLTAGE_STATUSHIS")
                        {
                            var vsh = Newtonsoft.Json.JsonConvert.DeserializeObject<BROKENRAIL_VOLTAGE_STATUSHIS>(line.datatext);
                            sql = SQLUtil.GetSQL("DELETE", vsh, type);
                        }
                        break;
                    case "CHANGE":
                        if (line.datatype == "BROKENRAIL_DEVICE_STATUS")
                        {
                            string[] ps = line.datatext.Split(',');
                            sql = string.Format("UPDATE BROKENRAIL_DEVICE_STATUS SET POINT_NO = '{0}' WHERE POINT_NO = '{1}';", ps[1], ps[0]);
                        }
                        else if (line.datatype == "BROKENRAIL_DEVICE_STATUSHIS")
                        {
                            string[] ps = line.datatext.Split(',');
                            sql = string.Format("UPDATE BROKENRAIL_DEVICE_STATUSHIS SET POINT_NO = '{0}' WHERE POINT_NO = '{1}';", ps[1], ps[0]);
                        }
                        if (line.datatype == "BROKENRAIL_VOLTAGE_STATUS")
                        {
                            string[] ps = line.datatext.Split(',');
                            sql = string.Format("UPDATE BROKENRAIL_VOLTAGE_STATUS SET POINT_NO = '{0}' WHERE POINT_NO = '{1}';", ps[1], ps[0]);
                        }
                        else if (line.datatype == "BROKENRAIL_VOLTAGE_STATUSHIS")
                        {
                            string[] ps = line.datatext.Split(',');
                            sql = string.Format("UPDATE BROKENRAIL_VOLTAGE_STATUSHIS SET POINT_NO = '{0}' WHERE POINT_NO = '{1}';", ps[1], ps[0]);
                        }
                        break;
                }
                file.WriteLine(sql);
            }
        }
    }
}
