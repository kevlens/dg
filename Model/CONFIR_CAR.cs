using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class CONFIR_CAR
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:车次 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRAIN_NUM {get;set;}

        /// <summary>
        /// Desc:发车时刻 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPARTURE_STARTTIME {get;set;}

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
        public string DIRECTION {get;set;}

        /// <summary>
        /// Desc:区段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_SECTION {get;set;}

        /// <summary>
        /// Desc:出发车站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_START {get;set;}

        /// <summary>
        /// Desc:出发车站股道 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHANNEL_START {get;set;}

        /// <summary>
        /// Desc:终点车站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_END {get;set;}

        /// <summary>
        /// Desc:终点车站股道 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHANNEL_END {get;set;}

        /// <summary>
        /// Desc:到达时刻 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPARTURE_ENDTIME {get;set;}

        /// <summary>
        /// Desc:负责添乘车间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CJNAME {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTENT {get;set;}

        /// <summary>
        /// Desc:火星经度出发车站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARS_LONGITUDE {get;set;}

        /// <summary>
        /// Desc:火星纬度出发车站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARS_LATITUDE {get;set;}

        /// <summary>
        /// Desc:部门编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:去程时长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public long TRIP_TIME {get;set;}

    }
}
