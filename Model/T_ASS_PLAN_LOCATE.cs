using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_PLAN_LOCATE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:计划编号（对应各计划表里的PLAN_ID） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PLAN_ID {get;set;}

        /// <summary>
        /// Desc:流程ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FLOWID {get;set;}

        /// <summary>
        /// Desc:作业项目 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM {get;set;}

        /// <summary>
        /// Desc:天窗类型(对应派工单中的作业类型) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool WINDOW_TYPE {get;set;}

        /// <summary>
        /// Desc:等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_LEVEL {get;set;}

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
        /// Desc:作业时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TIME {get;set;}

        /// <summary>
        /// Desc:开始里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? START_MILE {get;set;}

        /// <summary>
        /// Desc:结束里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? END_MILE {get;set;}

        /// <summary>
        /// Desc:车站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION {get;set;}

        /// <summary>
        /// Desc:股道号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACKNO {get;set;}

        /// <summary>
        /// Desc:道岔号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUTNO {get;set;}

        /// <summary>
        /// Desc:设备单元号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EQUIP_UNIT_NO {get;set;}

        /// <summary>
        /// Desc:作业人数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Byte? LABOUR {get;set;}

        /// <summary>
        /// Desc:机具 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TOOLS {get;set;}

        /// <summary>
        /// Desc:材料 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MATERIALS {get;set;}

        /// <summary>
        /// Desc:内容及影响范围 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTENT {get;set;}

        /// <summary>
        /// Desc:施工封锁或限速要求 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SPEED_CHANGE {get;set;}

        /// <summary>
        /// Desc:工程列车 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRAINS {get;set;}

        /// <summary>
        /// Desc:其他 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REMARK {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

        /// <summary>
        /// Desc:创建时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CRT_TIME {get;set;}

        /// <summary>
        /// Desc:项目类型（ITEM_TYPE） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool ITEM_TYPE {get;set;}

        /// <summary>
        /// Desc:实际作业时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FC_PLAN_TIME {get;set;}

        /// <summary>
        /// Desc:实际命令号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FC_ORDER {get;set;}

    }
}
