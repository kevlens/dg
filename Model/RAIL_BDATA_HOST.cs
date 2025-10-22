using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIL_BDATA_HOST
    {
        
        /// <summary>
        /// Desc:主机编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string HOST_NO {get;set;}

        /// <summary>
        /// Desc:主机名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HOST_NAME {get;set;}

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
        /// Desc:是否区间（0：否 1：是） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SECTION_FLAG {get;set;}

        /// <summary>
        /// Desc:监测区间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MONITOR_SECTION {get;set;}

        /// <summary>
        /// Desc:监测开始里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MONITORMILE_BEGIN {get;set;}

        /// <summary>
        /// Desc:监测结束里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MONITORMILE_END {get;set;}

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
        /// Desc:所属部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HOST_NOTE {get;set;}

    }
}
