using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class HRAIL_BALLAST
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string BALLAST_ID {get;set;}

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
        /// Desc:道床标识（0，正线；1，站段岔特线） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BALLAST_FLAG {get;set;}

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
        /// Desc:线路类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_TYPE {get;set;}

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
        public int? OVERALL_LENGTH {get;set;}

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
        /// Desc:道床类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BALLAST_TYPE {get;set;}

        /// <summary>
        /// Desc:道碴材质 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BALLAST_MATERAIL {get;set;}

        /// <summary>
        /// Desc:轨距类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_TYPE {get;set;}

        /// <summary>
        /// Desc:道碴等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BALLAST_LEVEL {get;set;}

        /// <summary>
        /// Desc:道床顶宽 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? BALLAST_TOPWIDTH {get;set;}

        /// <summary>
        /// Desc:枕底厚度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? PILLOW_THICKNESS {get;set;}

        /// <summary>
        /// Desc:垫层材质 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CUSSION_MATERAIL {get;set;}

        /// <summary>
        /// Desc:垫层厚度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? CUSSION_THICKNESS {get;set;}

        /// <summary>
        /// Desc:边坡1比N 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? SIDE_SLOPE {get;set;}

        /// <summary>
        /// Desc:脏污程度编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIRTY_PROGRM {get;set;}

        /// <summary>
        /// Desc:清筛年度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SCREEN_YEAR {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
