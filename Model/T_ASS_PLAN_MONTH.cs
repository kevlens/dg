using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_PLAN_MONTH
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PLAN_ID {get;set;}

        /// <summary>
        /// Desc:流程ID（流程表外键关系） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FLOW_ID {get;set;}

        /// <summary>
        /// Desc:工务段代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string GWD_CODE {get;set;}

        /// <summary>
        /// Desc:部门代码（计划编制单位代码） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DEP_CODE {get;set;}

        /// <summary>
        /// Desc:计划年月（yyyy-mm） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string YEARMOTH {get;set;}

        /// <summary>
        /// Desc:起止日期 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PLAN_DATE {get;set;}

        /// <summary>
        /// Desc:起止时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TIME {get;set;}

        /// <summary>
        /// Desc:封锁时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BLOCK_TIME {get;set;}

        /// <summary>
        /// Desc:计划类型（1：维修计划；2：施工计划； ） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool PLAN_TYPE {get;set;}

        /// <summary>
        /// Desc:项目类型（1：维修项目；2：施工项目；） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool ITEM_TYPE {get;set;}

        /// <summary>
        /// Desc:等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_LEVEL {get;set;}

        /// <summary>
        /// Desc:作业项目 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM {get;set;}

        /// <summary>
        /// Desc:单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEMUNIT {get;set;}

        /// <summary>
        /// Desc:天窗类型（1：维修天窗；2：施工天窗；3：天窗点外） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool WINDOW_TYPE {get;set;}

        /// <summary>
        /// Desc:线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:作业地点（里程） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_LOCATION {get;set;}

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
        public string TRACK_CODE {get;set;}

        /// <summary>
        /// Desc:道岔号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUT_CODE {get;set;}

        /// <summary>
        /// Desc:作业内容及影响范围 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTENT {get;set;}

        /// <summary>
        /// Desc:登记车站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REG_STATION {get;set;}

        /// <summary>
        /// Desc:作业数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? WORKLOAD {get;set;}

        /// <summary>
        /// Desc:人工数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Byte? LABOUR {get;set;}

        /// <summary>
        /// Desc:作业单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_UNIT {get;set;}

        /// <summary>
        /// Desc:配合单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORKWITH_UNIT {get;set;}

        /// <summary>
        /// Desc:主要材料 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MATERIAL {get;set;}

        /// <summary>
        /// Desc:限速及行车方式变化 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SPEED_CHANGE {get;set;}

        /// <summary>
        /// Desc:设备变化 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EQU_CHANGE {get;set;}

        /// <summary>
        /// Desc:运输组织 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRANS_ORG {get;set;}

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
        /// Desc:创建人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CRT_USER {get;set;}

        /// <summary>
        /// Desc:有效标志 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EFF_FLAG {get;set;}

        /// <summary>
        /// Desc:计划状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool PLAN_STATUS {get;set;}

    }
}
