using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG.Common
{
    public class DBService
    {
        public SqlSugarClient GetInstance(string url)
        {
            try
            {
                if (Constant.client == null)
                {
                    Constant.client = new SqlSugarClient(new ConnectionConfig()
                    {
                        ConnectionString = url,
                        DbType = DbType.SqlServer,
                        IsAutoCloseConnection = true,
                        InitKeyType = InitKeyType.Attribute
                    });
              //      Constant.client.IsEnableLogEvent = true;//启用日志事件

                    //  client.LogEventStarting = (sql, par) => { FileLogUtility.Debug(sql + " " + par + "\r\n"); };
                    return Constant.client;
                }
                else
                    return Constant.client;
            }
            catch (Exception ex)
            {
                return Constant.client;
            }
        }

    }
}
