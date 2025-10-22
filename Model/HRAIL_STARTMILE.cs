using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class HRAIL_STARTMILE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string STRATMILE_ID {get;set;}

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
        /// Desc:顺号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_TYPE {get;set;}

        /// <summary>
        /// Desc:轨距类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_TYPE {get;set;}

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
        /// Desc:起点站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string START_STATIONNAME {get;set;}

        /// <summary>
        /// Desc:起点站编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string START_STATIONCODE {get;set;}

        /// <summary>
        /// Desc:起点位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string START_POSITION {get;set;}

        /// <summary>
        /// Desc:终点站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string END_STATIONNAME {get;set;}

        /// <summary>
        /// Desc:终点站编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string END_STATIONCODE {get;set;}

        /// <summary>
        /// Desc:终点位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string END_POSITION {get;set;}

        /// <summary>
        /// Desc:延展长度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? EXTENSION_LENGTH {get;set;}

        /// <summary>
        /// Desc:比上年增减 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? COMPARE_ADDREDUCE {get;set;}

        /// <summary>
        /// Desc:标高系统 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STAND_SYS {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
