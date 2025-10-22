using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_GATEMNG_AUTHHISTORY
    {
        
        /// <summary>
        /// Desc:授权历史即白名单ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string HISTORY_ID {get;set;}

        /// <summary>
        /// Desc:门号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATE_NO {get;set;}

        /// <summary>
        /// Desc:卡号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CARD_NO {get;set;}

        /// <summary>
        /// Desc:时间启用标志（0：不启用 1：启用） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TIMEENABLE_FLAG {get;set;}

        /// <summary>
        /// Desc:授权开始时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? TIME_BEGIN {get;set;}

        /// <summary>
        /// Desc:授权结束时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? TIME_END {get;set;}

        /// <summary>
        /// Desc:5AA5未解析纪录 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HISTORY_LOG {get;set;}

        /// <summary>
        /// Desc:卡归属段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AUTHOPT_SECTION {get;set;}

        /// <summary>
        /// Desc:记录时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? HIS_TIME {get;set;}

        /// <summary>
        /// Desc:授权操作类型(1:新增，2:删除) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AUTH_OPT {get;set;}

    }
}
