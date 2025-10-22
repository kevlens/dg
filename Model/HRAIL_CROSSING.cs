using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class HRAIL_CROSSING
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CROSSING_ID {get;set;}

        /// <summary>
        /// Desc:工务段代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string GWD_CODE {get;set;}

        /// <summary>
        /// Desc:车间代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_CODE {get;set;}

        /// <summary>
        /// Desc:工区代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_CODE {get;set;}

        /// <summary>
        /// Desc:线编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LINE_CODE {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:运营状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RUN_STATUS {get;set;}

        /// <summary>
        /// Desc:轨枕标识（0，正线；1，站段岔特线） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CROSSING_FLAG {get;set;}

        /// <summary>
        /// Desc:车站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME {get;set;}

        /// <summary>
        /// Desc:车站号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_CODE {get;set;}

        /// <summary>
        /// Desc:线别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_CAT {get;set;}

        /// <summary>
        /// Desc:股道编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CODE {get;set;}

        /// <summary>
        /// Desc:全长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OVERALL_LENGTH {get;set;}

        /// <summary>
        /// Desc:开始里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? START_MILE {get;set;}

        /// <summary>
        /// Desc:结束里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? END_MILE {get;set;}

        /// <summary>
        /// Desc:长链标记 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LONGCHAIN_MARKER {get;set;}

        /// <summary>
        /// Desc:轨距类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_TYPE {get;set;}

        /// <summary>
        /// Desc:轨枕类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CROSSING_TYPE {get;set;}

        /// <summary>
        /// Desc:轨枕型号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CROSSING_MODEL {get;set;}

        /// <summary>
        /// Desc:铺设长度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? LAY_LENGTH {get;set;}

        /// <summary>
        /// Desc:铺设根数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? LAY_ROOTS {get;set;}

        /// <summary>
        /// Desc:生产厂家 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MANUFACTURER {get;set;}

        /// <summary>
        /// Desc:制造年度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MANUFACTURING_YEAR {get;set;}

        /// <summary>
        /// Desc:铺设年度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LAY_YEAR {get;set;}

        /// <summary>
        /// Desc:配置根数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? CONFIGE_ROOTS {get;set;}

        /// <summary>
        /// Desc:扣件类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FASTENER_TYPE {get;set;}

        /// <summary>
        /// Desc:扣件型号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FASTENER_MODEL {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
