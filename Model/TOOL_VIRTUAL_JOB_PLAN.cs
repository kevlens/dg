using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class TOOL_VIRTUAL_JOB_PLAN
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
        /// Nullable:True 
        /// </summary>
        public string JOB_NAME {get;set;}

        /// <summary>
        /// Desc:工单创建时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? JOB_CREATE {get;set;}

        /// <summary>
        /// Desc:手机号码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE {get;set;}

        /// <summary>
        /// Desc:人工结束备住 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEMO {get;set;}

        /// <summary>
        /// Desc:工单状态(0：未领用；1：全部领用；2；全部返还；3：部分领用；4：部分返还：5：上线；6：下线；7：已获取；9：异常（维修、保养、报废）） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool JOB_STATE {get;set;}

        /// <summary>
        /// Desc:领用人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string USE_PERSON {get;set;}

        /// <summary>
        /// Desc:部门代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:部门名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_NAME {get;set;}

        /// <summary>
        /// Desc:0代表虚拟工单，1代表无工单,2代表领用单 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool JOB_FLAG {get;set;}

        /// <summary>
        /// Desc:工单描述 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOTE {get;set;}

    }
}
