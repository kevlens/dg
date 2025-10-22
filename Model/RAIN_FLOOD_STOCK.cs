using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIN_FLOOD_STOCK
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FLOODSTOCK_ID {get;set;}

        /// <summary>
        /// Desc:车站编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_CODE {get;set;}

        /// <summary>
        /// Desc:车站名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME {get;set;}

        /// <summary>
        /// Desc:火星经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARSLONGITUDE {get;set;}

        /// <summary>
        /// Desc:火星纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARSLATITUDE {get;set;}

        /// <summary>
        /// Desc:存放股道 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LOCATION_TRACK {get;set;}

        /// <summary>
        /// Desc:备料类型（存车情况） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STOCK_TYPE {get;set;}

        /// <summary>
        /// Desc:备料名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STOCK_NAME {get;set;}

        /// <summary>
        /// Desc:备料数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? STOCK_NUM {get;set;}

        /// <summary>
        /// Desc:车辆编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CAR_NUM {get;set;}

        /// <summary>
        /// Desc:到达日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? ARRIVE_DATE {get;set;}

        /// <summary>
        /// Desc:使用情况 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string USE_SITUATION {get;set;}

        /// <summary>
        /// Desc:解备日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RELIEVE_DATE {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEMO {get;set;}

    }
}
