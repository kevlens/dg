using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_CHK_TURNOUT
    {
        
        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:车站名
 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME {get;set;}

        /// <summary>
        /// Desc:道岔编号
 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUT_CODE {get;set;}

        /// <summary>
        /// Desc:道岔型号
 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUT_NO {get;set;}

        /// <summary>
        /// Desc:道岔类型(18号道岔)
 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUT_TYPE {get;set;}

        /// <summary>
        /// Desc:0左开、1右开
 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIR_TYPE {get;set;}

        /// <summary>
        /// Desc:0砼枕、1木枕
 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MER_TYPE {get;set;}

        /// <summary>
        /// Desc:速度范围(0:其他站线;1:Vmax≤120Km/h正线及到发线;2:160Km/h≥Vmax>120Km/h正线;3:Vmax>160Km/h正线)
 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SPEED_RANGE {get;set;}

        /// <summary>
        /// Desc:道岔类型(0:单开 1:菱型 2:交分 3:双开 4：可动心轨单开)
 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUTYPE_FLAG {get;set;}

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

        /// <summary>
        /// Desc:检查位置 0正线道岔 1站线道岔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_POS {get;set;}

    }
}
