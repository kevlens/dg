using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_TURNOUT_VAL_DETAIL
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
        /// Desc:- 
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
        /// Desc:项目 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_ITEM {get;set;}

        /// <summary>
        /// Desc:病害名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_NAME {get;set;}

        /// <summary>
        /// Desc:病害位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_PLACE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single N_PEAK {get;set;}

        /// <summary>
        /// Desc:分值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_SCORE {get;set;}

        /// <summary>
        /// Desc:评定标准 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_STANDARD {get;set;}

        /// <summary>
        /// Desc:检查类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CHECK_TYPE {get;set;}

        /// <summary>
        /// Desc:检查设备 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CHECK_DEV {get;set;}

        /// <summary>
        /// Desc:评定日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? T_ASS_DATE {get;set;}

        /// <summary>
        /// Desc:是否有效 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_EFF_FLAG {get;set;}

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
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_CODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_DETAIL {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_SPEED {get;set;}

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
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? D_CHECK_DATE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_INSPECTOR {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_POST {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_TQI_VALUE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_TQI_SCORE {get;set;}

    }
}
