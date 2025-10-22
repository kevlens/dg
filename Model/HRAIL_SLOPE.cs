using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class HRAIL_SLOPE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string SLOPE_ID {get;set;}

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
        /// Desc:起轨顶标高 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? LIFTING_HEIGHT {get;set;}

        /// <summary>
        /// Desc:坡度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? SLOPE_DEGREE {get;set;}

        /// <summary>
        /// Desc:坡长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? SLOPE_LENGTH {get;set;}

        /// <summary>
        /// Desc:竖曲线类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CURVE_TYPE {get;set;}

        /// <summary>
        /// Desc:竖曲线半径 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? CURVE_RADIUS {get;set;}

        /// <summary>
        /// Desc:竖曲线长度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? CURVE_LENGTH {get;set;}

        /// <summary>
        /// Desc:跌落量米 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? DROP_METER {get;set;}

        /// <summary>
        /// Desc:长短链里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? LONGCHAIN_MILE {get;set;}

        /// <summary>
        /// Desc:长短链 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LONGSHORT_CHAIN {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
