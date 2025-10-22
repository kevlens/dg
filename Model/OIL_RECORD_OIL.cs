using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class OIL_RECORD_OIL
    {
        
        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string RECORDOIL_ID {get;set;}

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
        /// Desc:开始涂油时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? OILTIME_BEGIN {get;set;}

        /// <summary>
        /// Desc:开始涂油公里标 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? OILMILE_BEGIN {get;set;}

        /// <summary>
        /// Desc:结束涂油时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? OILTIME_END {get;set;}

        /// <summary>
        /// Desc:结束涂油公里标 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? OILMILE_END {get;set;}

        /// <summary>
        /// Desc:左右轨标记（0：空，1：左轨，2：右轨） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POS_FLAG {get;set;}

        /// <summary>
        /// Desc:电机状态（1：涂油，2：堵转） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MACHINE_STATE {get;set;}

        /// <summary>
        /// Desc:预留字段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECORDOIL_MEMO {get;set;}

        /// <summary>
        /// Desc:涂油模式（0：自动，1：手动） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OIL_MODEL {get;set;}

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
