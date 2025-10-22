using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class WEATHER_PROVINCE_FORECAST
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:城市名称（站名） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CITY_NAME {get;set;}

        /// <summary>
        /// Desc:天气现象 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? WEATHER_EVENT {get;set;}

        /// <summary>
        /// Desc:平均气温 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? WEATHER_TEMPERATURE {get;set;}

        /// <summary>
        /// Desc:降水量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? WEATHER_RAINS {get;set;}

        /// <summary>
        /// Desc:风向 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WIND_DIRECTION {get;set;}

        /// <summary>
        /// Desc:风速 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? WIND_SPEED {get;set;}

        /// <summary>
        /// Desc:风力 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WIND_POWER {get;set;}

        /// <summary>
        /// Desc:云量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? CLOUD_COVER {get;set;}

        /// <summary>
        /// Desc:能见度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? WEATHER_VISIBILITY {get;set;}

        /// <summary>
        /// Desc:0白天 1夜晚 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DAY_NIGHT {get;set;}

        /// <summary>
        /// Desc:接收时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RECE_TIME {get;set;}

        /// <summary>
        /// Desc:最高气温 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? HING_TEMPERATURE {get;set;}

        /// <summary>
        /// Desc:最低气温 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? LOW_TEMPERATURE {get;set;}

        /// <summary>
        /// Desc:预报日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? FORECAST_TIME {get;set;}

    }
}
