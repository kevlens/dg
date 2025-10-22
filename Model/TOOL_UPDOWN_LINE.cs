using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class TOOL_UPDOWN_LINE
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
        /// Desc:工机具上下线时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? TOOL_UPDOWNLINE_TIME {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEMO {get;set;}

        /// <summary>
        /// Desc:工机具当前状态（0是上线，1是下线） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool TOOL_UPDOWNLINE_STATU {get;set;}

        /// <summary>
        /// Desc:是否报警（0为不需要报警，1为需要报警） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool ALERM {get;set;}

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

    }
}
