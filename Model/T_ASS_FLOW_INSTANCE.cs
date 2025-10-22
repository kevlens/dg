using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_FLOW_INSTANCE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int FLOWID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string INSTANCE_ID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string INSTANCE_NAME {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string INSTANCE_DATE {get;set;}

        /// <summary>
        /// Desc:创建部门代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:创建部门名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_NAME {get;set;}

        /// <summary>
        /// Desc:创建人 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string USER_ID {get;set;}

        /// <summary>
        /// Desc:当前状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool STATUS {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool FLAG {get;set;}

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
