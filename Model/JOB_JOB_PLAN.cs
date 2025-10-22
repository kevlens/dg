using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class JOB_JOB_PLAN
    {
        
        /// <summary>
        /// Desc:计划单号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PLAN_NO {get;set;}

        /// <summary>
        /// Desc:作业类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_TYPE {get;set;}

        /// <summary>
        /// Desc:计划作业日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? PLANCONSTRUCT_DATE {get;set;}

        /// <summary>
        /// Desc:车间部门代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:部门代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

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
        /// Desc:区间车站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SECTION_STATION {get;set;}

        /// <summary>
        /// Desc:影响范围 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INFLUENCE_RANGE {get;set;}

        /// <summary>
        /// Desc:走行方式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GO_WAY {get;set;}

        /// <summary>
        /// Desc:登记站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REGISTER_STATION {get;set;}

        /// <summary>
        /// Desc:作业位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_PLACE {get;set;}

        /// <summary>
        /// Desc:特殊地段标志位（0：否，1：是） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SPECIALSECTION_FLAG {get;set;}

        /// <summary>
        /// Desc:作业项目说明 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_ILLUSTRATE {get;set;}

        /// <summary>
        /// Desc:关联问题清单 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RELATIVE_PROBLEMS {get;set;}

        /// <summary>
        /// Desc:作业时间段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOBTIME_PERIOD {get;set;}

        /// <summary>
        /// Desc:作业负责人ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_LEADER {get;set;}

        /// <summary>
        /// Desc:三员 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_WORKERS {get;set;}

        /// <summary>
        /// Desc:驻站次数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BESTATIONED_TIMES {get;set;}

        /// <summary>
        /// Desc:使用机具及操作人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_TOOL {get;set;}

        /// <summary>
        /// Desc:天窗类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SKYLIGHTS_TYPE {get;set;}

        /// <summary>
        /// Desc:站段管理标志位（0：否，1：是） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATIONSECTIONMNG_FLAG {get;set;}

        /// <summary>
        /// Desc:其他作业部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OTHERJOB_DEPTS {get;set;}

        /// <summary>
        /// Desc:安全风险提示 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SECURITYRISK_NOTICE {get;set;}

        /// <summary>
        /// Desc:领导干部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER {get;set;}

        /// <summary>
        /// Desc:工单状态  
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_STATE {get;set;}

        /// <summary>
        /// Desc:门禁防控系统是否已取（0：否，1：是） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATEGET_FLAG {get;set;}

        /// <summary>
        /// Desc:工机具系统是否已取（0：否，1：是） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TOOLGET_FLAG {get;set;}

        /// <summary>
        /// Desc:计划作废操作人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UNABLEPLAN_USER {get;set;}

        /// <summary>
        /// Desc:计划作废时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? UNABLEPLAN_DATE {get;set;}

    }
}
