using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_CULVERT
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CULVERT_ID {get;set;}

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
        /// Desc:区间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CULVERT_SECTION {get;set;}

        /// <summary>
        /// Desc:全长 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public double FULL_LENGTH {get;set;}

        /// <summary>
        /// Desc:维修长度 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public double MAINTAINCE_LENGTH {get;set;}

        /// <summary>
        /// Desc:线路数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? LINE_NUM {get;set;}

        /// <summary>
        /// Desc:孔数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? HOLE_NUM {get;set;}

        /// <summary>
        /// Desc:式样 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STYLE {get;set;}

        /// <summary>
        /// Desc:净孔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? CLEAN_HOLE {get;set;}

        /// <summary>
        /// Desc:图号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FIGURE_NUM {get;set;}

        /// <summary>
        /// Desc:净高 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? CLEAN_HEIGHT {get;set;}

        /// <summary>
        /// Desc:轨底至涵顶高 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? CULVERT_TOP {get;set;}

        /// <summary>
        /// Desc:建成年度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BUILD_YEAR {get;set;}

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

    }
}
