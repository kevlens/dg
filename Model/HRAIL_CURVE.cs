using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class HRAIL_CURVE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CURVE_ID {get;set;}

        /// <summary>
        /// Desc:- 
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
        /// Desc:运营状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RUN_STATUS {get;set;}

        /// <summary>
        /// Desc:起点里程 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public Double START_MILE {get;set;}

        /// <summary>
        /// Desc:终点里程 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public Double END_MILE {get;set;}

        /// <summary>
        /// Desc:长链标记（Y、N） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LONGCHAIN_MARK {get;set;}

        /// <summary>
        /// Desc:曲线方向（左、右） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CURVE_DIR {get;set;}

        /// <summary>
        /// Desc:曲线半径 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single CURVE_RADIUS {get;set;}

        /// <summary>
        /// Desc:转向角 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? DEFLECTION_ANGLE {get;set;}

        /// <summary>
        /// Desc:轨距类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_TYPE {get;set;}

        /// <summary>
        /// Desc:轨距加宽 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? GAUGE_WIDEN {get;set;}

        /// <summary>
        /// Desc:超高 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? SUPHIGH {get;set;}

        /// <summary>
        /// Desc:顺坡率 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single SLOPE_RATE {get;set;}

        /// <summary>
        /// Desc:起点切线长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? START_TANGENT {get;set;}

        /// <summary>
        /// Desc:起缓和线长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? START_ALLAYLINE {get;set;}

        /// <summary>
        /// Desc:终缓和线长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? END_ALLAYLINE {get;set;}

        /// <summary>
        /// Desc:终点切线长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? END_TANGENT {get;set;}

        /// <summary>
        /// Desc:曲线全长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? CURVE_FULLLEN {get;set;}

        /// <summary>
        /// Desc:平均速度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Byte? AVG_SPEED {get;set;}

        /// <summary>
        /// Desc:归整半径 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single SORT_RADIUS {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
