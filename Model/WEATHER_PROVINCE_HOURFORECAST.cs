using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class WEATHER_PROVINCE_HOURFORECAST
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
        /// Desc:气温 
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
        /// Desc:气压 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? WEATHER_PRESSURE {get;set;}

        /// <summary>
        /// Desc:相对湿度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? RELATIVE_HUMIDITY {get;set;}

        /// <summary>
        /// Desc:接收时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RECE_TIME {get;set;}

    }
}
