using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIL_BDATA_POINT
    {
        
        /// <summary>
        /// Desc:定标器编号（手机号_序号） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string POINT_NO {get;set;}

        /// <summary>
        /// Desc:定标器名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POINT_NAME {get;set;}

        /// <summary>
        /// Desc:线代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_CODE {get;set;}

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
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:里程坐标 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_COORDINATE {get;set;}

        /// <summary>
        /// Desc:一般定标器（0：正常 1 ：末端） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NORMAL_FLAG {get;set;}

        /// <summary>
        /// Desc:对应主机编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HOST_NO {get;set;}

        /// <summary>
        /// Desc:对应主机序号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? POINT_ORDER {get;set;}

        /// <summary>
        /// Desc:发送时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? SEND_TIME {get;set;}

        /// <summary>
        /// Desc:经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? LONGITUDE {get;set;}

        /// <summary>
        /// Desc:纬度 
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
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POINT_NOTE {get;set;}

    }
}
