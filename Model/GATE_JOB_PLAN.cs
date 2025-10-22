using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_JOB_PLAN
    {
        
        /// <summary>
        /// Desc:计划单号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PLAN_NO {get;set;}

        /// <summary>
        /// Desc:作业类型（0：点内施工；1：点外；2：点内维修；） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TYPE {get;set;}

        /// <summary>
        /// Desc:计划作业日期(手动*) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? PLANCONSTRUCT_DATE {get;set;}

        /// <summary>
        /// Desc:部门代码(手动*) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:线名(手动*) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME {get;set;}

        /// <summary>
        /// Desc:行别(手动*) 
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
        /// Desc:作业时间段(手动*) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLANCONSTRUCT_TIMEPERIOD {get;set;}

        /// <summary>
        /// Desc:作业负责人ID(手动*) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_LEADER {get;set;}

        /// <summary>
        /// Desc:作业人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_WORKERS {get;set;}

        /// <summary>
        /// Desc:天窗类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SKYLIGHTS_TYPE {get;set;}

        /// <summary>
        /// Desc:部门名称(手动*) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_NAME {get;set;}

        /// <summary>
        /// Desc:里程(手动*) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILEAGE_COORDINATE {get;set;}

        /// <summary>
        /// Desc:0：计划 1：手动 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_FLAG {get;set;}

        /// <summary>
        /// Desc:作业负责人手机号(手动*) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER_PHONE {get;set;}

        /// <summary>
        /// Desc:作业负责人名字(手动*) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_LEADERNAME {get;set;}

        /// <summary>
        /// Desc:作业状态0:未下发 1：下发成功 2：下发失败 3：作废 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_STATE {get;set;}

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
