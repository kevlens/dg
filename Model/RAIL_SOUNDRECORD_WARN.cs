using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIL_SOUNDRECORD_WARN
    {
        
        /// <summary>
        /// Desc:记录ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string WARNRECORD_ID {get;set;}

        /// <summary>
        /// Desc:定标器编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POINT_NO {get;set;}

        /// <summary>
        /// Desc:位置标志（0：左 1：右） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POS_FLAG {get;set;}

        /// <summary>
        /// Desc:报警标志（0：断轨恢复 1：断轨报警） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WARN_FLAG {get;set;}

        /// <summary>
        /// Desc:报警时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? WARN_TIME {get;set;}

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

        /// <summary>
        /// Desc:报警开始里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILE_START {get;set;}

        /// <summary>
        /// Desc:报警结束里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILE_END {get;set;}

    }
}
