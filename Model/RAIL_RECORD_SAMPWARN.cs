using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIL_RECORD_SAMPWARN
    {
        
        /// <summary>
        /// Desc:采样记录ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string SAMPWARNRECORD_ID {get;set;}

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
        /// Desc:报警标志（0：正常  1：过车  2：环境差报警  3：采样出错  4：主机与定标器接线断） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SAMPWARN_TYPE {get;set;}

        /// <summary>
        /// Desc:电压 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POWER {get;set;}

        /// <summary>
        /// Desc:未解析纪录 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SAMPWARNRECORD_LOG {get;set;}

        /// <summary>
        /// Desc:0消警,1报警 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SAMPWARN_FLAG {get;set;}

    }
}
