using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class OIL_RECORD_CHECK
    {
        
        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string RECORDCHECK_ID {get;set;}

        /// <summary>
        /// Desc:操作人编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OP_ID {get;set;}

        /// <summary>
        /// Desc:线代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_CODE {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:公里标 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? RECORD_MILE {get;set;}

        /// <summary>
        /// Desc:时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RECORD_TIME {get;set;}

        /// <summary>
        /// Desc:预留字段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECORDCHECK_MEMO {get;set;}

        /// <summary>
        /// Desc:线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME {get;set;}

        /// <summary>
        /// Desc:操作人名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OP_NAME {get;set;}

        /// <summary>
        /// Desc:手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_NO {get;set;}

        /// <summary>
        /// Desc:设备名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEVICE_NAME {get;set;}

        /// <summary>
        /// Desc:设备编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEVICE_NO {get;set;}

    }
}
