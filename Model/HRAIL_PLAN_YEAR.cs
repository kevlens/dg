using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class HRAIL_PLAN_YEAR
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PLAN_ID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FLOW_ID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string GWD_CODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_CODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_CODE {get;set;}

        /// <summary>
        /// Desc:计划年份（格式：yyyy） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_DATE {get;set;}

        /// <summary>
        /// Desc:计划类型（1：维修计划；2：施工计划；3：检查计划） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool PLAN_TYPE {get;set;}

        /// <summary>
        /// Desc:类别（线路、桥梁、防护设施、外委施工监护、添乘） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CATEGORY {get;set;}

        /// <summary>
        /// Desc:检查类别（0：默认；3：周期检查；4：专项检查；5：添乘检查；1：日常检查；2：其它；）；PLAN_TYPE为3时有效 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? CHECK_TYPE {get;set;}

        /// <summary>
        /// Desc:检查周期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Byte? CHECK_CYCLE {get;set;}

        /// <summary>
        /// Desc:检查周期单位（次 / 天、月、季、年） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_CYCLE_UNIT {get;set;}

        /// <summary>
        /// Desc:项目类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM_TYPE {get;set;}

        /// <summary>
        /// Desc:项目代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM_CODE {get;set;}

        /// <summary>
        /// Desc:项目名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM_NAME {get;set;}

        /// <summary>
        /// Desc:单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM_UNIT {get;set;}

        /// <summary>
        /// Desc:线别（正线、其它站线（动车径路）、其它站线（非动车径路）、车站、桥隧、其它） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_TYPE {get;set;}

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
        /// Desc:线别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_CAT {get;set;}

        /// <summary>
        /// Desc:起点里程/中心里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? START_MILE {get;set;}

        /// <summary>
        /// Desc:终点里程（里程不是区段里程时，只填起点里程，不填终点里程） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? END_MILE {get;set;}

        /// <summary>
        /// Desc:车站代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_CODE {get;set;}

        /// <summary>
        /// Desc:股道号（多个以逗号分隔） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CODE {get;set;}

        /// <summary>
        /// Desc:道岔号（多个以逗号分隔） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUT_CODE {get;set;}

        /// <summary>
        /// Desc:桥隧设备类别（桥梁、隧道、涵渠、地道、灰坑、天桥、跨线桥、上跨立交桥、其它） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EQU_CAT {get;set;}

        /// <summary>
        /// Desc:中心里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? CENTER_MILE {get;set;}

        /// <summary>
        /// Desc:桥隧设备号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EQU_CODE {get;set;}

        /// <summary>
        /// Desc:桥隧设备名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EQU_NAME {get;set;}

        /// <summary>
        /// Desc:设备数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? EQU_NUM {get;set;}

        /// <summary>
        /// Desc:年计划数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? Y_P_NUM {get;set;}

        /// <summary>
        /// Desc:年计划用工（人） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? Y_P_E_NUM {get;set;}

        /// <summary>
        /// Desc:年完成数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? Y_C_NUM {get;set;}

        /// <summary>
        /// Desc:年实际用工（人） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? Y_C_E_NUM {get;set;}

        /// <summary>
        /// Desc:1月计划数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? M1_P_NUM {get;set;}

        /// <summary>
        /// Desc:1月计划用工（人） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? M1_P_E_NUM {get;set;}

        /// <summary>
        /// Desc:1月完成数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? M1_C_NUM {get;set;}

        /// <summary>
        /// Desc:1月实际用工（人） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? M1_C_E_NUM {get;set;}

        /// <summary>
        /// Desc:2月计划数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? M2_P_NUM {get;set;}

        /// <summary>
        /// Desc:2月计划用工（人） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? M2_P_E_NUM {get;set;}

        /// <summary>
        /// Desc:2月完成数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? M2_C_NUM {get;set;}

        /// <summary>
        /// Desc:2月实际用工（人） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? M2_C_E_NUM {get;set;}

    }
}
