using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_BRIDGE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string BRIDGE_ID {get;set;}

        /// <summary>
        /// Desc:工务段代码 
        /// Default:- 
        /// Nullable:True 
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
        /// Desc:线号 
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
        /// Desc:中心里程 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public Double CENTER_MILE {get;set;}

        /// <summary>
        /// Desc:桥号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string BRIDGE_CODE {get;set;}

        /// <summary>
        /// Desc:桥名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BRIDGE_NAME {get;set;}

        /// <summary>
        /// Desc:区间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BRIDGE_SECTION {get;set;}

        /// <summary>
        /// Desc:股道数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? TRACK_NUM {get;set;}

        /// <summary>
        /// Desc:全长 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public double FULL_LENGTH {get;set;}

        /// <summary>
        /// Desc:桥长 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public double BRIDGE_LENGTH {get;set;}

        /// <summary>
        /// Desc:维修长度 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public double MAINTAINCE_LENGTH {get;set;}

        /// <summary>
        /// Desc:建成年度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BUILD_YEAR {get;set;}

        /// <summary>
        /// Desc:孔跨式样 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HOLESPAN_STYLE {get;set;}

        /// <summary>
        /// Desc:桥梁类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BRIDGE_TYPE {get;set;}

        /// <summary>
        /// Desc:运营状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RUN_STATUS {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

        /// <summary>
        /// Desc:是否检定 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TEST_FLAG {get;set;}

        /// <summary>
        /// Desc:检定报告 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TEST_REPORT {get;set;}

    }
}
