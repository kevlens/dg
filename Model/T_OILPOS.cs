using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_OILPOS
    {
        
        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:线代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_CODE {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:公里标 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? MILEAGE {get;set;}

        /// <summary>
        /// Desc:时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RECORD_TIME {get;set;}

        /// <summary>
        /// Desc:手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_NO {get;set;}

        /// <summary>
        /// Desc:经度(GPS) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? LONGITUDE {get;set;}

        /// <summary>
        /// Desc:纬度(GPS) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? LATITUDE {get;set;}

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
        /// Desc:百度经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? BAIDULONGITUDE {get;set;}

        /// <summary>
        /// Desc:百度纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? BAIDULATITUDE {get;set;}

        /// <summary>
        /// Desc:速度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? SPEED {get;set;}

        /// <summary>
        /// Desc:方向 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? DIRECTION {get;set;}

        /// <summary>
        /// Desc:星数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? SATELLITE_NO {get;set;}

        /// <summary>
        /// Desc:方式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POS_MODE {get;set;}

        /// <summary>
        /// Desc:操作人编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OP_ID {get;set;}

        /// <summary>
        /// Desc:预留字段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OILPOS_MEMO {get;set;}

    }
}
