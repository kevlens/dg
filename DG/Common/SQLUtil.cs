using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DG.Common
{
    public static class SQLUtil
    {
        public static string GetSQL<T>(string op, T data, string type)
        {
            string sql = string.Empty;
            StringBuilder sb = new StringBuilder();
            Type t = typeof(T);
            PropertyInfo[] pi = t.GetProperties();
            if (op == "INSERT")
            {
                string names = "(";
                string values = "(";

                foreach (var p in pi)
                {
                    names += p.Name + ",";
                    if (p.GetValue(data, null) != null)
                    {
                        values += "'" + p.GetValue(data, null).ToString() + "',";
                    }
                    else
                    {
                        values += type == "ORA" ? "''," : "NULL,";
                    }
                }
                names = names.TrimEnd(',');
                values = values.TrimEnd(',');
                names += ")";
                values += ")";
                sql = "INSERT INTO " + pi[0].DeclaringType.Name + names + " VALUES " + values +";";
            }
            else if(op == "UPDATE")
            {
                string nv = "";
                string wh = "";
                foreach (var p in pi)
                {
                    if (p.GetCustomAttributesData().Count == 0)
                    {
                        if (p.GetValue(data, null) != null)
                        {
                            nv += p.Name + " = '" + p.GetValue(data, null).ToString() + "',";
                        }
                    }
                    else
                    {
                        wh = " WHERE " + p.Name + " = '" + p.GetValue(data, null).ToString() + "',";
                    }
                }
                nv = nv.TrimEnd(',');
                wh = wh.TrimEnd(',');
                sql = "UPDATE " + pi[0].DeclaringType.Name + " SET " + nv + wh +";";
            }
            else if(op == "DELETE")
            {
                foreach (var p in pi)
                {
                    if(p.GetCustomAttributesData().Count != 0)
                    {
                        sql = "DELETE FROM " + p.DeclaringType.Name + " WHERE " + p.Name + " = '" + p.GetValue(data, null).ToString() + "'" + ";";
                        break;
                    }
                }
            }
            return sql;
        }

        public static T DeepCopyByBin<T>(T obj)
        {
            object retval;
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                //序列化成流
                bf.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                //反序列化成对象
                retval = bf.Deserialize(ms);
                ms.Close();
            }
            return (T)retval;
        }
    }
}
