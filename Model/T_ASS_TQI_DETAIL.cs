using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_TQI_DETAIL
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
        /// Desc:工务段代码 
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
        /// Desc:单位名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_DEP_NAME {get;set;}

        /// <summary>
        /// Desc:单位属性 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_DEP_PROP {get;set;}

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
        /// Desc:线别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_CAT {get;set;}

        /// <summary>
        /// Desc:里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_PRO_MILE {get;set;}

        /// <summary>
        /// Desc:病害类型（种类）代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_PRO_CODE {get;set;}

        /// <summary>
        /// Desc:病害类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_NAME {get;set;}

        /// <summary>
        /// Desc:超限 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LEVEL {get;set;}

        /// <summary>
        /// Desc:TQI数值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single N_TQI_PEAK {get;set;}

        /// <summary>
        /// Desc:TQI超标 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TQI_OVER {get;set;}

        /// <summary>
        /// Desc:检查日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? D_CHECK_DATE {get;set;}

        /// <summary>
        /// Desc:是否生成工单（Y、N）默认 N 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_JOB_FLAG {get;set;}

        /// <summary>
        /// Desc:工单号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_JOB_NO {get;set;}

        /// <summary>
        /// Desc:是否整修（Y、N）默认 N 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_REPAIR_FLAG {get;set;}

        /// <summary>
        /// Desc:整修日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? D_REPAIR_DATE {get;set;}

        /// <summary>
        /// Desc:整治效果 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_REPAIR_RES {get;set;}

        /// <summary>
        /// Desc:消号、归档标志（Y、N） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_DOC_FLAG {get;set;}

        /// <summary>
        /// Desc:创建日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? T_CRT_TM {get;set;}

        /// <summary>
        /// Desc:创建人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CRT_NAME {get;set;}

        /// <summary>
        /// Desc:是否有效（Y、N）默认 Y 
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
        /// Desc:峰值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single N_PRO_PEAK {get;set;}

        /// <summary>
        /// Desc:速度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_SPEED {get;set;}

        /// <summary>
        /// Desc:速度范围 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string N_SPEED_SPAN {get;set;}

    }
}
