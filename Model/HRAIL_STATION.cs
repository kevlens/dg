using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class HRAIL_STATION
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string STATION_ID {get;set;}

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
        /// Desc:车站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME {get;set;}

        /// <summary>
        /// Desc:车站编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string STATION_CODE {get;set;}

        /// <summary>
        /// Desc:运营状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RUN_STATUS {get;set;}

        /// <summary>
        /// Desc:线编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_CODE {get;set;}

        /// <summary>
        /// Desc:主线标志 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string THREAD_SIGN {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:拼音字头 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PY_PREFIX {get;set;}

        /// <summary>
        /// Desc:技术作业别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SKILL_WORK {get;set;}

        /// <summary>
        /// Desc:业务性质别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BUSINESS_TYPE {get;set;}

        /// <summary>
        /// Desc:车站等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_GRADE {get;set;}

        /// <summary>
        /// Desc:轨距类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_TYPE {get;set;}

        /// <summary>
        /// Desc:中心里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? CENTER_MILE {get;set;}

        /// <summary>
        /// Desc:工区里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? AREA_MILE {get;set;}

        /// <summary>
        /// Desc:最小半径 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single MIN_RADIUS {get;set;}

        /// <summary>
        /// Desc:最大坡度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? MAX_SLOPE {get;set;}

        /// <summary>
        /// Desc:股道数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? TRACK_NUM {get;set;}

        /// <summary>
        /// Desc:道岔数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? TURNOUT_NUM {get;set;}

        /// <summary>
        /// Desc:下行进站机 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? DOWN_INMAC {get;set;}

        /// <summary>
        /// Desc:下行有效长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? DOWN_VALID {get;set;}

        /// <summary>
        /// Desc:上行进站机 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? UP_INMAC {get;set;}

        /// <summary>
        /// Desc:上行有效长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? UP_VALID {get;set;}

        /// <summary>
        /// Desc:经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_LONGITUDE {get;set;}

        /// <summary>
        /// Desc:纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_LATITUDE {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

    }
}
