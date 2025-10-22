using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class HRAIL_RAIL
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string RAIL_ID {get;set;}

        /// <summary>
        /// Desc:工务段代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string GWD_CODE {get;set;}

        /// <summary>
        /// Desc:车间代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_CODE {get;set;}

        /// <summary>
        /// Desc:工区代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_CODE {get;set;}

        /// <summary>
        /// Desc:线编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LINE_CODE {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:运营状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RUN_STATUS {get;set;}

        /// <summary>
        /// Desc:线路类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_TYPE {get;set;}

        /// <summary>
        /// Desc:轨距类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_TYPE {get;set;}

        /// <summary>
        /// Desc:开始里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? START_MILE {get;set;}

        /// <summary>
        /// Desc:结束里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? END_MILE {get;set;}

        /// <summary>
        /// Desc:长链标记 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LONGCHAIN_MARKER {get;set;}

        /// <summary>
        /// Desc:单根轨长(米) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? SINGLERAIL_LENGTH {get;set;}

        /// <summary>
        /// Desc:轨型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIL_TYPE {get;set;}

        /// <summary>
        /// Desc:钢种 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STEEK_TYPE {get;set;}

        /// <summary>
        /// Desc:生产厂家 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MANUFACTURER {get;set;}

        /// <summary>
        /// Desc:制造年度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MANUFACTURING_YEAR {get;set;}

        /// <summary>
        /// Desc:接头方式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOINT_STYLE {get;set;}

        /// <summary>
        /// Desc:是否再用轨 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string IS_REUSERAIL {get;set;}

        /// <summary>
        /// Desc:整修情况 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RENOVATE_SITUATE {get;set;}

        /// <summary>
        /// Desc:换轨年月 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? REPLACERAIL_YEAR {get;set;}

        /// <summary>
        /// Desc:累计通过总重 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GROSS_WEIGHT {get;set;}

        /// <summary>
        /// Desc:钢轨特性 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIL_IDENTITY {get;set;}

        /// <summary>
        /// Desc:鱼尾螺栓级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FISHBOLT_LEVEL {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
