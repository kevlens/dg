using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class TOOL_JOB_PLAN_IMPORT
    {
        
        /// <summary>
        /// Desc:工单号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string JOB_NO {get;set;}

        /// <summary>
        /// Desc:工单名称 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string JOB_NAME {get;set;}

        /// <summary>
        /// Desc:部门代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:作业负责人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_LEADER {get;set;}

        /// <summary>
        /// Desc:作业开始时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string START_TIME {get;set;}

        /// <summary>
        /// Desc:计划工机具 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PLAN_TOOL {get;set;}

        /// <summary>
        /// Desc:工单状态(0：未领用；1：领用；2；返还；9：异常（维修、保养、报废）） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool JOB_STATE {get;set;}

        /// <summary>
        /// Desc:部门名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_NAME {get;set;}

        /// <summary>
        /// Desc:作业结束时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string END_TIME {get;set;}

    }
}
