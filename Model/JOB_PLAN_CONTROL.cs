using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class JOB_PLAN_CONTROL
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PLAN_CONTROL_ID {get;set;}

        /// <summary>
        /// Desc:计划表主键 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_ID {get;set;}

        /// <summary>
        /// Desc:内容等级(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTENT_LEVEL {get;set;}

        /// <summary>
        /// Desc:作业地点(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME {get;set;}

        /// <summary>
        /// Desc:实际上道人数即上道人数职工(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ONLOAD_ACTUAL_NUM {get;set;}

        /// <summary>
        /// Desc:驻站上台时间(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? STATION_UP_TIME {get;set;}

        /// <summary>
        /// Desc:上道命令号(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UP_STATION_NO {get;set;}

        /// <summary>
        /// Desc:上道时间(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? UP_STATION_TIME {get;set;}

        /// <summary>
        /// Desc:下道命令号(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOWN_STATION_NO {get;set;}

        /// <summary>
        /// Desc:下道时间(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? DOWN_STATION_TIME {get;set;}

        /// <summary>
        /// Desc:监控人员(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTROL_PEOPLE {get;set;}

        /// <summary>
        /// Desc:发现问题(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FIND_PROBLEM {get;set;}

        /// <summary>
        /// Desc:标记颜色（计划-太原） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MARK_COLOR {get;set;}

        /// <summary>
        /// Desc:标记内容（计划-太原） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MARK_CONTENT {get;set;}

        /// <summary>
        /// Desc:拨出号码（计划-太原） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_NO {get;set;}

        /// <summary>
        /// Desc:驻站上台命令号(计划-武汉桥) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UP_STATION_ZZNO {get;set;}

        /// <summary>
        /// Desc:驻站下台时间(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? STATION_DOWN_TIME {get;set;}

        /// <summary>
        /// Desc:驻站下台命令号(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOWN_STATION_ZZNO {get;set;}

        /// <summary>
        /// Desc:驻站到岗卡控要点详情 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATIONUP_DETAIL {get;set;}

        /// <summary>
        /// Desc:驻站到岗卡控操作时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? STATIONUP_OPTIME {get;set;}

        /// <summary>
        /// Desc:驻站到岗卡控操作用户 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATIONUP_OPUSER {get;set;}

        /// <summary>
        /// Desc:入网卡控要点详情 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ONSTATION_DETAIL {get;set;}

        /// <summary>
        /// Desc:入网卡控操作时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? ONSTATION_OPTIME {get;set;}

        /// <summary>
        /// Desc:入网卡控操作用户 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ONSTATION_OPUSER {get;set;}

        /// <summary>
        /// Desc:作业回检卡控要点详情 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECHECK_DETAIL {get;set;}

        /// <summary>
        /// Desc:作业回检卡控操作时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RECHECK_OPTIME {get;set;}

        /// <summary>
        /// Desc:作业回检卡控操作用户 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECHECK_OPUSER {get;set;}

        /// <summary>
        /// Desc:出网卡控要点详情 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOWNSTATION_DETAIL {get;set;}

        /// <summary>
        /// Desc:出网卡控操作时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? DOWNSTATION_OPTIME {get;set;}

        /// <summary>
        /// Desc:出网卡控操作用户 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOWNSTATION_OPUSER {get;set;}

        /// <summary>
        /// Desc:计划取消原因 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CANCEL_REASON {get;set;}

    }
}
