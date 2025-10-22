using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class JOB_PLAN_UPDOWNHIS
    {
        
        /// <summary>
        /// Desc:手机号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PHONE {get;set;}

        /// <summary>
        /// Desc:时间 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public DateTime RECORD_TIME {get;set;}

        /// <summary>
        /// Desc:上下道状态(上道，下道) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UPDOWN {get;set;}

    }
}
