using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIL_SOUNDBDATA_POINT
    {
        
        /// <summary>
        /// Desc:声波断轨定标器编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string POINT_NO {get;set;}

        /// <summary>
        /// Desc:声波断轨定标器名称 
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
        /// Desc:监测区间名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MONITOR_SECTION_NAME {get;set;}

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
        /// Desc:序号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? POINT_ORDER {get;set;}

        /// <summary>
        /// Desc:定标器标志（0：收 1：发） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POINT_FLAG {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POINT_NOTE {get;set;}

        /// <summary>
        /// Desc:声波断轨定标器手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POINT_PHONENO {get;set;}

        /// <summary>
        /// Desc:监测区间区间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MONITOR_SECTION_RANGE {get;set;}

        /// <summary>
        /// Desc:主机，从机，定标器 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPE {get;set;}

        /// <summary>
        /// Desc:左股，右股，- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POSITION {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SECTION_ID {get;set;}

    }
}
