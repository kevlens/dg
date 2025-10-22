using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_FLOW_PROCESS
    {
        
        /// <summary>
        /// Desc:需要增加 INSTANCE_ID 字段 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FLOWID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PROCESS_ID {get;set;}

        /// <summary>
        /// Desc:单位代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string UNIT_CODE {get;set;}

        /// <summary>
        /// Desc:部门代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:用户 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string USERID {get;set;}

        /// <summary>
        /// Desc:步骤号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int STEPID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STEP_DESC {get;set;}

        /// <summary>
        /// Desc:步骤状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool STEP_STATUS {get;set;}

        /// <summary>
        /// Desc:步骤操作 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ACTIONID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ACTION_DESC {get;set;}

        /// <summary>
        /// Desc:步骤操作状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool ACTION_STATUS {get;set;}

        /// <summary>
        /// Desc:流程执行状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool FLOW_STATUS {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? NEXT_STEPID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NEXT_DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NEXT_USERID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool BACK_STATUS {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BACK_DESC {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CRT_TM {get;set;}

    }
}
