using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class CURVE_BASE
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
        /// Nullable:True 
        /// </summary>
        public string C_GWD_CODE {get;set;}

        /// <summary>
        /// Desc:单位编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_DEP_CODE {get;set;}

        /// <summary>
        /// Desc:线编号 
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
        /// Desc:线别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_CAT {get;set;}

        /// <summary>
        /// Desc:运营状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_RUN_STATUS {get;set;}

        /// <summary>
        /// Desc:起点里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_START_MILE {get;set;}

        /// <summary>
        /// Desc:终点里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_END_MILE {get;set;}

        /// <summary>
        /// Desc:长链标记（Y、N） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LONGCHAIN_MARK {get;set;}

        /// <summary>
        /// Desc:曲线方向（左、右） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CURVE_DIR {get;set;}

        /// <summary>
        /// Desc:曲线半径 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single N_CURVE_RADIUS {get;set;}

        /// <summary>
        /// Desc:转向角 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_DEFLECTION_ANGLE {get;set;}

        /// <summary>
        /// Desc:轨距类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_GAUGE_TYPE {get;set;}

        /// <summary>
        /// Desc:轨距加宽 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_GAUGE_WIDEN {get;set;}

        /// <summary>
        /// Desc:超高 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_SUPHIGH {get;set;}

        /// <summary>
        /// Desc:顺坡率 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single N_SLOPE_RATE {get;set;}

        /// <summary>
        /// Desc:起点切线长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_START_TANGENT {get;set;}

        /// <summary>
        /// Desc:起缓和线长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_START_ALLAYLINE {get;set;}

        /// <summary>
        /// Desc:终缓和线长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_END_ALLAYLINE {get;set;}

        /// <summary>
        /// Desc:终点切线长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_END_TANGENT {get;set;}

        /// <summary>
        /// Desc:曲线全长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_CURVE_FULLLEN {get;set;}

        /// <summary>
        /// Desc:平均速度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Byte? N_AVG_SPEED {get;set;}

        /// <summary>
        /// Desc:归整半径 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single N_SORT_RADIUS {get;set;}

        /// <summary>
        /// Desc:是否无缝线路（Y、N） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_JOINTLESS_TRACK {get;set;}

        /// <summary>
        /// Desc:轨枕类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SLEEPERTYPE {get;set;}

        /// <summary>
        /// Desc:轨枕配置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? SLEEPERCONFIG {get;set;}

        /// <summary>
        /// Desc:配件类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ACCESSORYTYPE {get;set;}

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
        /// Desc:是否小曲线标志（0：否 1：是） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? ISSMALLCURVE {get;set;}

    }
}
