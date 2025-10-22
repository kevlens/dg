using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class TOOL_JOB_PLAN
    {
        
        /// <summary>
        /// Desc:工单号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string JOB_NO {get;set;}

        /// <summary>
        /// Desc:计划类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_TYPE {get;set;}

        /// <summary>
        /// Desc:部门代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:作业负责人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_LEADER_NAME {get;set;}

        /// <summary>
        /// Desc:作业开始时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? START_TIME {get;set;}

        /// <summary>
        /// Desc:计划工机具 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TOOL {get;set;}

        /// <summary>
        /// Desc:工单状态(0：未领用；1：全部领用；2；全部返还；3：部分领用；4：部分返还：5：上线；6：下线；7：已获取；9：异常（维修、保养、报废）） 
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
        public DateTime? END_TIME {get;set;}

        /// <summary>
        /// Desc:行车调度命令号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRAIN_NO {get;set;}

        /// <summary>
        /// Desc:工务命令号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_NO {get;set;}

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
        /// Desc:里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILEAGE {get;set;}

        /// <summary>
        /// Desc:作业内容 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_CONTENT {get;set;}

        /// <summary>
        /// Desc:车站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION {get;set;}

        /// <summary>
        /// Desc:人工结束备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEMO {get;set;}

        /// <summary>
        /// Desc:工单描述 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOTE {get;set;}

        /// <summary>
        /// Desc:作业负责人手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_LEADER_NO {get;set;}

        /// <summary>
        /// Desc:导入时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? IMPORT_DATE {get;set;}

    }
}
