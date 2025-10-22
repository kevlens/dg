using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_GATEMNG_LASTSTATE
    {
        
        /// <summary>
        /// Desc:门号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string GATE_NO {get;set;}

        /// <summary>
        /// Desc:状态（0：关 1 ：开） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATE_FLAG {get;set;}

        /// <summary>
        /// Desc:时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? STATE_TIME {get;set;}

        /// <summary>
        /// Desc:门磁状态（0：关 1：开） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATEMAGNETS_FLAG {get;set;}

        /// <summary>
        /// Desc:门锁状态 （0：关 1：开） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATELOCK_FLAG {get;set;}

        /// <summary>
        /// Desc:读卡器状态 （0：正常 1：异常） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string READCARD_FLAG {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATE_ORDER {get;set;}

    }
}
