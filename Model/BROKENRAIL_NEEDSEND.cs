using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BROKENRAIL_NEEDSEND
    {
        
        /// <summary>
        /// Desc:区间ＩＤ　 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string SECTION_ID {get;set;}

        /// <summary>
        /// Desc:钢轨异常/钢轨恢复 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string SECTION_STATUS {get;set;}

        /// <summary>
        /// Desc:时间 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public DateTime RECORD_TIME {get;set;}

        /// <summary>
        /// Desc:开始里程 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string MILEAGE_START {get;set;}

        /// <summary>
        /// Desc:结束里程 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string MILEAGE_END {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string POINT_NO {get;set;}

        /// <summary>
        /// Desc:左轨/右轨 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIL_DIR {get;set;}

        /// <summary>
        /// Desc:线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME {get;set;}

        /// <summary>
        /// Desc:行别  
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:操作时间 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public DateTime OPERATE_TIME {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:是否已发送 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SEND_FLAG {get;set;}

    }
}
