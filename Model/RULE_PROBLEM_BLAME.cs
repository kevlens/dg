using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RULE_PROBLEM_BLAME
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PROBLEM_PKID {get;set;}

        /// <summary>
        /// Desc:责任单位 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string GWD_CODE {get;set;}

        /// <summary>
        /// Desc:责任部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:责任车间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_CODE {get;set;}

        /// <summary>
        /// Desc:责任工区 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_CODE {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
