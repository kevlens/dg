using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class JOB_PLAN_UPDOWN
    {
        
        /// <summary>
        /// Desc:手机号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PHONE {get;set;}

        /// <summary>
        /// Desc:作业计划号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_ID {get;set;}

        /// <summary>
        /// Desc:时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? LASTTIME {get;set;}

        /// <summary>
        /// Desc:上下道状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UPDOWN {get;set;}

    }
}
