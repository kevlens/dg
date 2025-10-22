using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class REPAIR_ACCOUNT
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:类别(计算保留) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_TYPE {get;set;}

        /// <summary>
        /// Desc:线名（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME {get;set;}

        /// <summary>
        /// Desc:行别（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIRECTION {get;set;}

        /// <summary>
        /// Desc:开始里程（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_BEGIN {get;set;}

        /// <summary>
        /// Desc:结束里程（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_END {get;set;}

        /// <summary>
        /// Desc:维修年月2015.11（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_YEAR {get;set;}

        /// <summary>
        /// Desc:线别（大修钢轨） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME_ONE {get;set;}

        /// <summary>
        /// Desc:行别（大修钢轨） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIRECTION_ONE {get;set;}

        /// <summary>
        /// Desc:区间（大修钢轨） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_AREA {get;set;}

        /// <summary>
        /// Desc:起点里程（大修钢轨） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILEAGE_BEGIN_ONE {get;set;}

        /// <summary>
        /// Desc:终点里程（大修钢轨） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILEAGE_END_ONE {get;set;}

        /// <summary>
        /// Desc:长度（大修钢轨） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_LENGTH {get;set;}

        /// <summary>
        /// Desc:上次换轨年月（大修钢轨） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_YEAR_LAST {get;set;}

        /// <summary>
        /// Desc:母材累计疲劳伤损数量(处)（大修钢轨） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LESIONS_NUM {get;set;}

        /// <summary>
        /// Desc:每公里母材疲劳伤损率（大修钢轨） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LESIONS_NUM_PERCENT {get;set;}

        /// <summary>
        /// Desc:备注（大修钢轨） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_CONTENT {get;set;}

        /// <summary>
        /// Desc:单位（大修钢轨） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_DEPT {get;set;}

        /// <summary>
        /// Desc:解析关键字错误信息（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ERRORINFO {get;set;}

        /// <summary>
        /// Desc:导入时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? INTIME {get;set;}

        /// <summary>
        /// Desc:部门编码（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:上次清筛
年月（大机清筛） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_YEAR_LAST_ONE {get;set;}

        /// <summary>
        /// Desc:上一年度通过总重（大机清筛） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LAST_YEAR_WEIGHT_ONE {get;set;}

        /// <summary>
        /// Desc:截至上一年度累计通过总重（大机清筛） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LAST_YEAR_WEIGHT_SUM_ONE {get;set;}

        /// <summary>
        /// Desc:线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME_TWO {get;set;}

        /// <summary>
        /// Desc:区段（正线轨枕） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_AREA_ONE {get;set;}

        /// <summary>
        /// Desc:是否本年清筛地段（正线轨枕） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string IS_THIS_YEAR {get;set;}

        /// <summary>
        /// Desc:既有轨枕类型（正线轨枕） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SLEEPER_TYPE {get;set;}

        /// <summary>
        /// Desc:69型枕数量(根)（正线轨枕） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SLEEPER_SIXNINE_NUM {get;set;}

        /// <summary>
        /// Desc:木枕数量(根)（正线轨枕） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WOOD_SLEEPER_NUM {get;set;}

        /// <summary>
        /// Desc:需III型枕(根)（正线轨枕） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SLEEPER_THREE_NUM {get;set;}

        /// <summary>
        /// Desc:维修年月,日期格式（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? REPAIR_YEAR_DATE {get;set;}

        /// <summary>
        /// Desc:下次维修年月（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_PLAN_DATE {get;set;}

        /// <summary>
        /// Desc:轨型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIL_TYPE {get;set;}

        /// <summary>
        /// Desc:线路类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_TYPE {get;set;}

        /// <summary>
        /// Desc:材质 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIL_MATERIAL {get;set;}

        /// <summary>
        /// Desc:道岔明细 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIL_TURNOUT {get;set;}

        /// <summary>
        /// Desc:道岔轨件更换情况 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIL_REPLACE_TURNOUT {get;set;}

        /// <summary>
        /// Desc:段名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_DEPT_ONE {get;set;}

        /// <summary>
        /// Desc:区间或车站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_AREA_TWO {get;set;}

        /// <summary>
        /// Desc:区段起点里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILEAGE_BEGIN_TWO {get;set;}

        /// <summary>
        /// Desc:区段终点里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILEAGE_END_TWO {get;set;}

        /// <summary>
        /// Desc:长度（km） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_LENGTH_TWO {get;set;}

        /// <summary>
        /// Desc:道岔数量（组） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUT_NUMBER_ONE {get;set;}

        /// <summary>
        /// Desc:修理年月 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_YEAR_ONE {get;set;}

        /// <summary>
        /// Desc:2014年度通过总重（mt） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LAST_YEAR_WEIGHT_TWO {get;set;}

        /// <summary>
        /// Desc:最近一次捣固后累计通过总重（mt） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LAST_YEAR_WEIGHT_SUM_THREE {get;set;}

        /// <summary>
        /// Desc:下次修理时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPLACE_PLAN_NEXT {get;set;}

        /// <summary>
        /// Desc:周期（年） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPLACE_PLAN_CYCLE {get;set;}

        /// <summary>
        /// Desc:最近一次作业后累计通过总重（mt） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LAST_YEAR_WEIGHT_SUM_FOUR {get;set;}

        /// <summary>
        /// Desc:上次换枕年月 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_YEAR_LAST_TWO {get;set;}

        /// <summary>
        /// Desc:岔枕更换情况 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIL_REPLACE_TURNOUT_ONE {get;set;}

        /// <summary>
        /// Desc:修理周期（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? REPAIR_CYCLE {get;set;}

        /// <summary>
        /// Desc:周期超限类型（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OVERRUN_TYPE {get;set;}

        /// <summary>
        /// Desc:下次维修年月,日期格式（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? REPAIR_PLAN_NEXT_DATE {get;set;}

        /// <summary>
        /// Desc:截至目前累计通过总重 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string YEAR_CAPACITY {get;set;}

    }
}
