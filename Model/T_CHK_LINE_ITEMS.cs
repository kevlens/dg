using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_CHK_LINE_ITEMS
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:T_CHK_LINE主键 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FKID {get;set;}

        /// <summary>
        /// Desc:钢轨编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? RAIL_NO {get;set;}

        /// <summary>
        /// Desc:里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? LICHENG {get;set;}

        /// <summary>
        /// Desc:位置标志(0:接头;1:小腰;2:中间;3:后小腰;) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POS_TYPE {get;set;}

        /// <summary>
        /// Desc:类型 0：直线，1：缓和曲线，2：圆曲线 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPE {get;set;}

        /// <summary>
        /// Desc:0:正常;1:增 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ADD_FLAG {get;set;}

        /// <summary>
        /// Desc:轨距 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE {get;set;}

        /// <summary>
        /// Desc:水平 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LEVEL {get;set;}

        /// <summary>
        /// Desc:三角坑 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST {get;set;}

        /// <summary>
        /// Desc:轨向 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK {get;set;}

        /// <summary>
        /// Desc:高低 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIGH_LOW {get;set;}

        /// <summary>
        /// Desc:临修日期及内容 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_TM_CONTENT {get;set;}

        /// <summary>
        /// Desc:检查时间/复检时间(必传) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CHK_TM {get;set;}

        /// <summary>
        /// Desc:经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? LNG {get;set;}

        /// <summary>
        /// Desc:纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? LAT {get;set;}

        /// <summary>
        /// Desc:火星经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARS_LNG {get;set;}

        /// <summary>
        /// Desc:火星纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARS_LAT {get;set;}

        /// <summary>
        /// Desc:百度经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? BAIDU_LNG {get;set;}

        /// <summary>
        /// Desc:百度纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? BAIDU_LAT {get;set;}

        /// <summary>
        /// Desc:GPS时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? GPS_TM {get;set;}

        /// <summary>
        /// Desc:0:正常;1:复检数据 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECHECK_FLAG {get;set;}

        /// <summary>
        /// Desc:曲线半径 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? CURVE_RADIUS {get;set;}

        /// <summary>
        /// Desc:超高 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? SUPHIGH {get;set;}

        /// <summary>
        /// Desc:顺坡率 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? SLOPE_RATE {get;set;}

        /// <summary>
        /// Desc:加宽值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? WIDENING_VALUE {get;set;}

    }
}
