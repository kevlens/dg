using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RULE_RESULT_CENSUS
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:部门代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:制度代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOCODE {get;set;}

        /// <summary>
        /// Desc:工务段占比 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single GWD_SCALE {get;set;}

        /// <summary>
        /// Desc:车间占比 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single CJ_SCALE {get;set;}

        /// <summary>
        /// Desc:工区占比 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single GQ_SCALE {get;set;}

        /// <summary>
        /// Desc:部门占比 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single DEPT_SCALE {get;set;}

        /// <summary>
        /// Desc:单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UNIT_CODE {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
