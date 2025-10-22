using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_MSG
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string MSG_ID {get;set;}

        /// <summary>
        /// Desc:类别（0：默认；1：紧急保养作业通知书；。。。） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int MSG_CAT {get;set;}

        /// <summary>
        /// Desc:通知书ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOTICE_ID {get;set;}

        /// <summary>
        /// Desc:签发部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ISSUE_DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:签发日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? ISSUE_DATE {get;set;}

        /// <summary>
        /// Desc:签收部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SIGN_DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:签收日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? SIGN_DATE {get;set;}

        /// <summary>
        /// Desc:签收人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECEIVER {get;set;}

        /// <summary>
        /// Desc:计划号（为作业计划预留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_ID {get;set;}

        /// <summary>
        /// Desc:备注 
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

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CRT_NAME {get;set;}

    }
}
