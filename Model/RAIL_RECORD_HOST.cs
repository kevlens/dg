using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIL_RECORD_HOST
    {
        
        /// <summary>
        /// Desc:主机记录ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string HOSTRECORD_ID {get;set;}

        /// <summary>
        /// Desc:主机编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HOST_NO {get;set;}

        /// <summary>
        /// Desc:时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RECORD_TIME {get;set;}

        /// <summary>
        /// Desc:电源板状态（0：正常 1：异常） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POWERBOARD_FLAG {get;set;}

        /// <summary>
        /// Desc:接口板状态（0：正常 1：异常） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INTERFACEBOARD_FLAG {get;set;}

        /// <summary>
        /// Desc:定标器个数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? POINT_NUM {get;set;}

        /// <summary>
        /// Desc:电池电压 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POWER {get;set;}

        /// <summary>
        /// Desc:未解析纪录 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HOSTRECORD_LOG {get;set;}

        /// <summary>
        /// Desc:电压方式（0：电池 1：AC） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POWER_TYPE {get;set;}

        /// <summary>
        /// Desc:AC电压 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POWER_AC {get;set;}

    }
}
