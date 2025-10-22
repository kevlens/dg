using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIL_RECORD_POINT
    {
        
        /// <summary>
        /// Desc:定标器记录ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string POINTRECORD_ID {get;set;}

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
        /// Desc:序号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? RECORD_ORDER {get;set;}

        /// <summary>
        /// Desc:定标器电压 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POINT_POWER {get;set;}

        /// <summary>
        /// Desc:未解析纪录 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POINTRECORD_LOG {get;set;}

        /// <summary>
        /// Desc:基准电压 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STANDARD_POWER {get;set;}

        /// <summary>
        /// Desc:定标器编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POINT_NO {get;set;}

        /// <summary>
        /// Desc:0正常,1环境差 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATUS_FLAG {get;set;}

        /// <summary>
        /// Desc:0正常，1故障 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WARN_FLAG {get;set;}

    }
}
