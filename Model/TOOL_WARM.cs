using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class TOOL_WARM
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string SID {get;set;}

        /// <summary>
        /// Desc:工单号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string JOB_NO {get;set;}

        /// <summary>
        /// Desc:工机具编号组（上传上来的工机具编号组） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TOOL_IDS {get;set;}

        /// <summary>
        /// Desc:工机具名称（工机具名称组，用“；”分隔） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TOOL_NAMES {get;set;}

        /// <summary>
        /// Desc:工机具报警时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? TOOL_UPDOWNLINE_TIME {get;set;}

        /// <summary>
        /// Desc:经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? LNG {get;set;}

        /// <summary>
        /// Desc:纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? LAT {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEMO {get;set;}

    }
}
