using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_TRACK
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
        /// Nullable:False 
        /// </summary>
        public string C_GWD_CODE {get;set;}

        /// <summary>
        /// Desc:单位编号 
        /// Default:- 
        /// Nullable:False 
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
        /// Desc:车站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_STATION_NAME {get;set;}

        /// <summary>
        /// Desc:车站编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_STATION_CODE {get;set;}

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
        /// Desc:股道编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TRACK_CODE {get;set;}

        /// <summary>
        /// Desc:线路类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_TYPE {get;set;}

        /// <summary>
        /// Desc:轨距类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_GAUGE_TYPE {get;set;}

        /// <summary>
        /// Desc:有效长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public short N_VALID_LEN {get;set;}

        /// <summary>
        /// Desc:全长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_FULL_LEN {get;set;}

        /// <summary>
        /// Desc:木枕根数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_WOOD_TIE_NUM {get;set;}

        /// <summary>
        /// Desc:混凝土枕根 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_CONCRETE_TIE_NUM {get;set;}

        /// <summary>
        /// Desc:钢枕根数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_STEEL_TIE_NUM {get;set;}

        /// <summary>
        /// Desc:轨枕板根数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_BROAD_TIE_NUM {get;set;}

        /// <summary>
        /// Desc:左邻线间距 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_LEFT_SPACING {get;set;}

        /// <summary>
        /// Desc:右邻线间距 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_RIGHT_SPACING {get;set;}

        /// <summary>
        /// Desc:曲线半径 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single N_CURVE_RADIUS {get;set;}

        /// <summary>
        /// Desc:方向 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_DIR {get;set;}

        /// <summary>
        /// Desc:最大坡度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_MAX_GRADE {get;set;}

        /// <summary>
        /// Desc:坡段长度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_GRADESECT_LEN {get;set;}

        /// <summary>
        /// Desc:轨型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_RAIL_TYPE {get;set;}

        /// <summary>
        /// Desc:延长线 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_EXTEND_LINE {get;set;}

        /// <summary>
        /// Desc:无缝延长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_EXTEN_JOINTLESS {get;set;}

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
        /// Desc:是否有效 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_EFF_FLAG {get;set;}

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

    }
}
