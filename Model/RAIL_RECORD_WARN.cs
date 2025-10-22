using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIL_RECORD_WARN
    {
        
        /// <summary>
        /// Desc:定标器记录ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string WARNRECORD_ID {get;set;}

        /// <summary>
        /// Desc:主机编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HOST_NO {get;set;}

        /// <summary>
        /// Desc:时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RECORD_TIME {get;set;}

        /// <summary>
        /// Desc:定标器编号（手机号_序号） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POINT_NO {get;set;}

        /// <summary>
        /// Desc:未解析纪录 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WARNRECORD_LOG {get;set;}

        /// <summary>
        /// Desc:报警/恢复标志（1：报警 2：恢复） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WARN_TYPE {get;set;}

        /// <summary>
        /// Desc:消音原因 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLEAR_REASON {get;set;}

        /// <summary>
        /// Desc:消音人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLEAR_MAN {get;set;}

        /// <summary>
        /// Desc:消间时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CLEAR_TIME {get;set;}

    }
}
