using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_PLAN_WEEK
    {
        
        /// <summary>
        /// Desc:计划ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PLAN_ID {get;set;}

        /// <summary>
        /// Desc:流程ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FLOW_ID {get;set;}

        /// <summary>
        /// Desc:工务段代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GWD_CODE {get;set;}

        /// <summary>
        /// Desc:部门代码（编制计划的用户所在的部门代码） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEP_CODE {get;set;}

        /// <summary>
        /// Desc:周（计划）开始日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? PLAN_START_DATE {get;set;}

        /// <summary>
        /// Desc:周（计划）结束日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? PLAN_END_DATE {get;set;}

        /// <summary>
        /// Desc:线名 
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
        /// Desc:区间或车站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SECTION {get;set;}

        /// <summary>
        /// Desc:（施工计划、维修计划、临时计划）（作业 / 施工）里程或位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LOCATION {get;set;}

        /// <summary>
        /// Desc:项目（维修项目、施工项目或检查项目的具体内容，多个内容以 ｜分隔） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM {get;set;}

        /// <summary>
        /// Desc:日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? PLAN_DATE {get;set;}

        /// <summary>
        /// Desc:作业时间（格式：开始时间-结束时间(用时)    ;时间精确到时：分：00，多个时间段用|分割） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TIME {get;set;}

        /// <summary>
        /// Desc:计划类型（1：维修计划；2：施工计划；3：临时计划 ） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool PLAN_TYPE {get;set;}

        /// <summary>
        /// Desc:项目类型（1：维修项目；2：施工项目；3：检查项目） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool ITEM_TYPE {get;set;}

        /// <summary>
        /// Desc:等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_LEVEL {get;set;}

        /// <summary>
        /// Desc:天窗类型（1：点内；2：点外；3：预留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WINDOW_TYPE {get;set;}

        /// <summary>
        /// Desc:调度计划号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_NO {get;set;}

        /// <summary>
        /// Desc:计划状态（1：待报；2：审核；3：下发；0：4；0：默认） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool PLAN_STATUS {get;set;}

        /// <summary>
        /// Desc:调度命令号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DISPATCHIN_ORDER {get;set;}

        /// <summary>
        /// Desc:作业命令号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_ORDER {get;set;}

        /// <summary>
        /// Desc:作业类型（1：综合修；2：临时修；3：预留） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool JOB_TYPE {get;set;}

        /// <summary>
        /// Desc:登记站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REG_STATION {get;set;}

        /// <summary>
        /// Desc:人员明细（从计划人员明细表中获取） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMBERS {get;set;}

        /// <summary>
        /// Desc:配合人员（录入） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OTHER_MEMBERS {get;set;}

        /// <summary>
        /// Desc:机具（从机具明细表中获取） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TOOLS {get;set;}

        /// <summary>
        /// Desc:材料（从材料明细表中获取） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MATERIALS {get;set;}

        /// <summary>
        /// Desc:关联问题（从计划问题明细表中提取） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROBLEMS {get;set;}

        /// <summary>
        /// Desc:安全风险提示 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RISK {get;set;}

        /// <summary>
        /// Desc:风险变化 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RISK_CHANGE {get;set;}

        /// <summary>
        /// Desc:（施工/作业）单位及负责人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_UNIT {get;set;}

        /// <summary>
        /// Desc:（施工/作业）配合单位及负责人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORKWITH_UNIT {get;set;}

        /// <summary>
        /// Desc:作业负责人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_LEADER {get;set;}

        /// <summary>
        /// Desc:驻站联络员 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_MEMBER {get;set;}

        /// <summary>
        /// Desc:现场防护员 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LOCATE_MEMBER {get;set;}

        /// <summary>
        /// Desc:监控干部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MONITOR_MEMBER {get;set;}

        /// <summary>
        /// Desc:影响范围 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTENT {get;set;}

        /// <summary>
        /// Desc:限速及行车方式变化 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SPEED_CHANGE {get;set;}

        /// <summary>
        /// Desc:行车限制卡（hidden） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRAIN_LIMIT {get;set;}

        /// <summary>
        /// Desc:设备变化（hidden） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EQU_CHANGE {get;set;}

        /// <summary>
        /// Desc:运输组织（hidden） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRANS_ORG {get;set;}

        /// <summary>
        /// Desc:工程列车 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRAINS {get;set;}

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
        /// Desc:创建用户 
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
        /// Desc:工区代码（显示时显示工区名称，计划归属的工区） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_CODE {get;set;}

    }
}
