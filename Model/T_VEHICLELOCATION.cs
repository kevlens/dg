using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_VEHICLELOCATION
    {
        
        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:机车号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? LOCOMOTIVE_NO {get;set;}

        /// <summary>
        /// Desc:机车型号描述 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LOCOMOTIVE_TYPE {get;set;}

        /// <summary>
        /// Desc:时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RECORD_TIME {get;set;}

        /// <summary>
        /// Desc:车次 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRAIN_NO {get;set;}

        /// <summary>
        /// Desc:线名 
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
        /// Desc:实速 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? SPEED_REAL {get;set;}

        /// <summary>
        /// Desc:交路号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? CROSS_NO {get;set;}

        /// <summary>
        /// Desc:车站号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? STATION_NO {get;set;}

        /// <summary>
        /// Desc:0：货运 1：客运 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ISPASSENGER_FLAG {get;set;}

        /// <summary>
        /// Desc:0：本务 1：补机 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ISPUSH_FLAG {get;set;}

        /// <summary>
        /// Desc:机车信号（0：单灯 1：多灯） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? SIGNAL_TYPE {get;set;}

        /// <summary>
        /// Desc:机车信号颜色（0：无灯 1：绿 2：黄 3：双黄 4：红黄 5：红 6：白 7：绿黄 8：黄2） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? SIGNAL_COLOR {get;set;}

        /// <summary>
        /// Desc:机车工况（0：零位 1：向后 2：向前 3：制动 4：牵引） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? LOCOMOTIVE_STATE {get;set;}

        /// <summary>
        /// Desc:信息机编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? INFOMACHINE_NO {get;set;}

        /// <summary>
        /// Desc:信息机种类（0：出站 1：进站 2：通过 3：预告 4：容许 5：其它） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? INFOMACHINE_TYPE {get;set;}

        /// <summary>
        /// Desc:0：监控 1：降级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ISLOWLEVEL_FLAG {get;set;}

        /// <summary>
        /// Desc:0：非调车 1：调车 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ISCHANGETRAIN_FLAG {get;set;}

        /// <summary>
        /// Desc:辆数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? TRAIN_NUMBER {get;set;}

        /// <summary>
        /// Desc:司机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? DRIVER_NO {get;set;}

        /// <summary>
        /// Desc:副司机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? ASSDRIVER_NO {get;set;}

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
        /// Desc:GPS速度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? SPEED_GPS {get;set;}

        /// <summary>
        /// Desc:接收的卫星数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? SATELLITE_NO {get;set;}

        /// <summary>
        /// Desc:手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_NO {get;set;}

        /// <summary>
        /// Desc:上一次里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? LAST_MILE {get;set;}

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
        /// Desc:机车型号编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LOCOMOTIVE_NUMBER {get;set;}

        /// <summary>
        /// Desc:车站名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME {get;set;}

    }
}
