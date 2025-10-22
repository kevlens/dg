using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_PLAN_PROBLEM
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:计划编号（对应各计划表里的PLAN_ID） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_ID {get;set;}

        /// <summary>
        /// Desc:流程ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FLOWID {get;set;}

        /// <summary>
        /// Desc:作业地点表PKID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LOC_PKID {get;set;}

        /// <summary>
        /// Desc:问题库ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROBLEM_ID {get;set;}

        /// <summary>
        /// Desc:线代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_CODE {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_DIR {get;set;}

        /// <summary>
        /// Desc:车站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_STATION_CODE {get;set;}

        /// <summary>
        /// Desc:股道号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TRACK_CODE {get;set;}

        /// <summary>
        /// Desc:道岔号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TURNOUT_CODE {get;set;}

        /// <summary>
        /// Desc:问题项目 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_ITEM {get;set;}

        /// <summary>
        /// Desc:问题代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_CODE {get;set;}

        /// <summary>
        /// Desc:单元号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_UNIT_NUM {get;set;}

        /// <summary>
        /// Desc:问题位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_PLACE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_PRO_MILE {get;set;}

        /// <summary>
        /// Desc:峰值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single N_PRO_PEAK {get;set;}

        /// <summary>
        /// Desc:病害详情 
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
        /// Desc:超限等级(1,2,3,4 对应Ⅰ、Ⅱ、Ⅲ、Ⅳ),默认0 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool N_OVERRUN_LEVEL {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CHECK_TYPE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CHECK_DEV {get;set;}

        /// <summary>
        /// Desc:检查人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_INSPECTOR {get;set;}

        /// <summary>
        /// Desc:检查日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? D_CHECK_DATE {get;set;}

        /// <summary>
        /// Desc:问题入库时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? T_PRO_CRT_TM {get;set;}

        /// <summary>
        /// Desc:整冶日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? D_REPAIR_DATE {get;set;}

        /// <summary>
        /// Desc:处理结果 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_REPAIR_RES {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

        /// <summary>
        /// Desc:线路特征（曲线、道岔） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_FEATURE {get;set;}

        /// <summary>
        /// Desc:问题销号标记 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool FLAG {get;set;}

        /// <summary>
        /// Desc:复核情况 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COMPOSITE {get;set;}

        /// <summary>
        /// Desc:整修人或整修负责人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_REPAIR_MAN {get;set;}

    }
}
