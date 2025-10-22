using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIL_SOUNDRECORD_POINT
    {
        
        /// <summary>
        /// Desc:记录ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string RECORDPOINT_ID {get;set;}

        /// <summary>
        /// Desc:定标器编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POINT_NO {get;set;}

        /// <summary>
        /// Desc:时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RECORD_TIME {get;set;}

        /// <summary>
        /// Desc:位置标志（0：左 1：右） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POS_FLAG {get;set;}

        /// <summary>
        /// Desc:状态标志（0：正常 1：故障） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATE_FLAG {get;set;}

    }
}
