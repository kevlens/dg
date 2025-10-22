using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_TURNOUT_VAL
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FKID {get;set;}

        /// <summary>
        /// Desc:工务段编码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_GWD_CODE {get;set;}

        /// <summary>
        /// Desc:单位编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_DEP_CODE {get;set;}

        /// <summary>
        /// Desc:单元号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string N_UNIT_NUM {get;set;}

        /// <summary>
        /// Desc:道岔号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_TURNOUT_CODE {get;set;}

        /// <summary>
        /// Desc:线编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_CODE {get;set;}

        /// <summary>
        /// Desc:线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_NAME {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_DIR {get;set;}

        /// <summary>
        /// Desc:车站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_STATION_NAME {get;set;}

        /// <summary>
        /// Desc:车站编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_STATION_CODE {get;set;}

        /// <summary>
        /// Desc:评定标准 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_STANDARD {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_STATIC_SCORE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_DYNAMIC_SCORE {get;set;}

        /// <summary>
        /// Desc:分值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_SCORE {get;set;}

        /// <summary>
        /// Desc:评定日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? T_ASS_DATE {get;set;}

        /// <summary>
        /// Desc:创建人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CRT_NAME {get;set;}

        /// <summary>
        /// Desc:排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_ORDER {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

        /// <summary>
        /// Desc:评定等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_EVAL_GRADE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_CAT {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_ASS_DEP_CODE {get;set;}

        /// <summary>
        /// Desc:TQI数值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_TQI_VALUE {get;set;}

        /// <summary>
        /// Desc:TQI分值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_TQI_SCORE {get;set;}

        /// <summary>
        /// Desc:创建日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? T_CRT_TM {get;set;}

    }
}
