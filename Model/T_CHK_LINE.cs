using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_CHK_LINE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

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
        /// Desc:起点里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? START_MILE {get;set;}

        /// <summary>
        /// Desc:终点里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? END_MILE {get;set;}

        /// <summary>
        /// Desc:车站名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME {get;set;}

        /// <summary>
        /// Desc:股道 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_NUM {get;set;}

        /// <summary>
        /// Desc:速度范围(0:其他站线;1:Vmax≤120Km/h正线及到发线;2:160Km/h≥Vmax>120Km/h正线;3:Vmax>160Km/h正线;4:专用线) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SPEED_RANGE {get;set;}

        /// <summary>
        /// Desc:位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIR_TYPE {get;set;}

        /// <summary>
        /// Desc:名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NAME {get;set;}

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
        /// Desc:线路类别 0客车通道 1其他正线 2到发线 3站专线 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_TYPE {get;set;}

        /// <summary>
        /// Desc:检查位置 0正线线路 1站线线路 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_POS {get;set;}

    }
}
