using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_CHK_VISCHECK_ITEMS
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:检查类型(0:正线；1:站线；2:道岔) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_TYPE {get;set;}

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
        /// Desc:里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? MILEAGE {get;set;}

        /// <summary>
        /// Desc:车站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME {get;set;}

        /// <summary>
        /// Desc:股道名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_NUM {get;set;}

        /// <summary>
        /// Desc:道岔名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUT_NO {get;set;}

        /// <summary>
        /// Desc:道岔位置或轨号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POS_NAME {get;set;}

        /// <summary>
        /// Desc:临修日期及内容 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_TM_CONTENT {get;set;}

        /// <summary>
        /// Desc:手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_NO {get;set;}

        /// <summary>
        /// Desc:检查人员(多人以,分割) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHK_NAME {get;set;}

        /// <summary>
        /// Desc:检查时间(必传) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CHK_TM {get;set;}

        /// <summary>
        /// Desc:创建时间(必传) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CRT_TM {get;set;}

        /// <summary>
        /// Desc:创建人（登陆用户名） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CRT_NAME {get;set;}

        /// <summary>
        /// Desc:更新时间(必传) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? UPD_TM {get;set;}

        /// <summary>
        /// Desc:更新人(必传)（登陆用户名） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UPD_NAME {get;set;}

        /// <summary>
        /// Desc:排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? SHOW_ORDER {get;set;}

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
        /// Desc:检查位置 0正线线路 1站线线路 2正线道岔 3站线道岔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_POS {get;set;}

        /// <summary>
        /// Desc:线路类别 0客车通道 1其他正线 2到发线 3站专线 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_TYPE {get;set;}

    }
}
