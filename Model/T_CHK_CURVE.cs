using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_CHK_CURVE
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
        /// Desc:曲线半径 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? CURVE_RADIUS {get;set;}

        /// <summary>
        /// Desc:缓和曲线长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TRANSITIOLEN {get;set;}

        /// <summary>
        /// Desc:曲线全长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? CURVE_LENGTH {get;set;}

        /// <summary>
        /// Desc:直缓点位置号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRANS_STARTNO {get;set;}

        /// <summary>
        /// Desc:直缓点位置里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TRANS_STARTMILE {get;set;}

        /// <summary>
        /// Desc:缓直点位置号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRANS_ENDNO {get;set;}

        /// <summary>
        /// Desc:缓直点位置里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TRANS_ENDMILE {get;set;}

        /// <summary>
        /// Desc:速度范围(0:Vmax≤120Km/h;1:160Km/h≥Vmax>120Km/h;2:Vmax>160Km/h;) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SPEED_RANGE {get;set;}

        /// <summary>
        /// Desc:0：正线及到发线；1：其他站线；2：专用线；3：附带曲线 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPE {get;set;}

        /// <summary>
        /// Desc:车站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATIOT_NAME {get;set;}

        /// <summary>
        /// Desc:股道 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_NUM {get;set;}

        /// <summary>
        /// Desc:超高 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? SUPPER_HIGH {get;set;}

        /// <summary>
        /// Desc:位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIR_TYPE {get;set;}

        /// <summary>
        /// Desc:起始车站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATIOT_BGN {get;set;}

        /// <summary>
        /// Desc:结束车站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATIOT_END {get;set;}

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
        /// Desc:创建日期(必传) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CRT_TM {get;set;}

        /// <summary>
        /// Desc:创建人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CRT_NAME {get;set;}

        /// <summary>
        /// Desc:更新日期(必传) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? UPD_TM {get;set;}

        /// <summary>
        /// Desc:更新人(必传) 
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

    }
}
