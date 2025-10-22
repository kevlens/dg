using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_STATION
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:工务段编码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_GWD_CODE {get;set;}

        /// <summary>
        /// Desc:工区编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_DEP_CODE {get;set;}

        /// <summary>
        /// Desc:车站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_STATION_NAME {get;set;}

        /// <summary>
        /// Desc:车站编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_STATION_CODE {get;set;}

        /// <summary>
        /// Desc:运营状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_RUN_STATUS {get;set;}

        /// <summary>
        /// Desc:线编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_CODE {get;set;}

        /// <summary>
        /// Desc:主线标志 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_THREAD_SIGN {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_DIR {get;set;}

        /// <summary>
        /// Desc:拼音字头 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PY_PREFIX {get;set;}

        /// <summary>
        /// Desc:技术作业别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_SKILL_WORK {get;set;}

        /// <summary>
        /// Desc:业务性质别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_BUSINESS_TYPE {get;set;}

        /// <summary>
        /// Desc:车站等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_STATION_GRADE {get;set;}

        /// <summary>
        /// Desc:轨距类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_GAUGE_TYPE {get;set;}

        /// <summary>
        /// Desc:中心里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_CENTER_MILE {get;set;}

        /// <summary>
        /// Desc:工区里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_AREA_MILE {get;set;}

        /// <summary>
        /// Desc:最小半径 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single N_MIN_RADIUS {get;set;}

        /// <summary>
        /// Desc:最大坡度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_MAX_SLOPE {get;set;}

        /// <summary>
        /// Desc:股道数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_TRACK_NUM {get;set;}

        /// <summary>
        /// Desc:道岔数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_TURNOUT_NUM {get;set;}

        /// <summary>
        /// Desc:下行进站机 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_DOWN_INMAC {get;set;}

        /// <summary>
        /// Desc:下行有效长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_DOWN_VALID {get;set;}

        /// <summary>
        /// Desc:上行进站机 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_UP_INMAC {get;set;}

        /// <summary>
        /// Desc:上行有效长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_UP_VALID {get;set;}

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
        /// Desc:创建日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? T_CRT_TM {get;set;}

        /// <summary>
        /// Desc:创建人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CRT_NAME {get;set;}

        /// <summary>
        /// Desc:是否有效 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_EFF_FLAG {get;set;}

        /// <summary>
        /// Desc:排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_ORDER {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

    }
}
