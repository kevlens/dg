using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_CHK_CURVE_ITEMS
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:T_CHK_CURVE主键 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FKID {get;set;}

        /// <summary>
        /// Desc:测试点(10米一个测点，不足10米存为 测点号-副点) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHK_NO {get;set;}

        /// <summary>
        /// Desc:H：缓；HY：缓圆；Y：圆；YH：圆缓 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPE_CURVE {get;set;}

        /// <summary>
        /// Desc:计算正矢 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string VERSINE_CALC {get;set;}

        /// <summary>
        /// Desc:拨道量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_MM {get;set;}

        /// <summary>
        /// Desc:拨后正矢 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string VERSINE_TRACKED {get;set;}

        /// <summary>
        /// Desc:现场正失 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string VERSINE_SCENE {get;set;}

        /// <summary>
        /// Desc:记事 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECORD {get;set;}

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

    }
}
