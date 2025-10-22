using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class LEDGER_RAIL_MATERIAL
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:物料名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MATERIAL_NAME {get;set;}

        /// <summary>
        /// Desc:规格型号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MATERIAL_TYPE {get;set;}

        /// <summary>
        /// Desc:图号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DRAW_NUM {get;set;}

        /// <summary>
        /// Desc:开别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_TYPE {get;set;}

        /// <summary>
        /// Desc:单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UNIT {get;set;}

        /// <summary>
        /// Desc:月初数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? EARLY_NUM {get;set;}

        /// <summary>
        /// Desc:本月收入 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? REVENUE_MONTH {get;set;}

        /// <summary>
        /// Desc:本月消耗 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? CONSUMPTION_MONTH {get;set;}

        /// <summary>
        /// Desc:月末数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? END_NUMBER {get;set;}

        /// <summary>
        /// Desc:存放地点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STORAGE_LOCATION {get;set;}

        /// <summary>
        /// Desc:存放里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILEAGE {get;set;}

        /// <summary>
        /// Desc:部门名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_NAME {get;set;}

        /// <summary>
        /// Desc:单位主管 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UNIT_LEADER {get;set;}

        /// <summary>
        /// Desc:材料科长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHIEF {get;set;}

        /// <summary>
        /// Desc:填表人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AUTHOR {get;set;}

        /// <summary>
        /// Desc:日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CHIEF_TIME {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEMO {get;set;}

        /// <summary>
        /// Desc:单位编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:录入时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? INPUT_DATE {get;set;}

        /// <summary>
        /// Desc:录入人员 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INPUT_USER {get;set;}

    }
}
