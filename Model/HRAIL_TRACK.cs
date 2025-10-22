using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class HRAIL_TRACK
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string TRACK_ID {get;set;}

        /// <summary>
        /// Desc:工务段编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string GWD_CODE {get;set;}

        /// <summary>
        /// Desc:车间编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_CODE {get;set;}

        /// <summary>
        /// Desc:工区编号 
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
        /// Desc:车站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME {get;set;}

        /// <summary>
        /// Desc:车站编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string STATION_CODE {get;set;}

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
        /// Desc:股道编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string TRACK_CODE {get;set;}

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
        /// Desc:有效长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public short VALID_LEN {get;set;}

        /// <summary>
        /// Desc:全长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? FULL_LEN {get;set;}

        /// <summary>
        /// Desc:木枕根数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? WOOD_TIE_NUM {get;set;}

        /// <summary>
        /// Desc:混凝土枕根 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? CONCRETE_TIE_NUM {get;set;}

        /// <summary>
        /// Desc:钢枕根数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? STEEL_TIE_NUM {get;set;}

        /// <summary>
        /// Desc:轨枕板根数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? BROAD_TIE_NUM {get;set;}

        /// <summary>
        /// Desc:左邻线间距 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? LEFT_SPACING {get;set;}

        /// <summary>
        /// Desc:右邻线间距 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? RIGHT_SPACING {get;set;}

        /// <summary>
        /// Desc:曲线半径 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single CURVE_RADIUS {get;set;}

        /// <summary>
        /// Desc:方向 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIR {get;set;}

        /// <summary>
        /// Desc:最大坡度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? MAX_GRADE {get;set;}

        /// <summary>
        /// Desc:坡段长度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? GRADESECT_LEN {get;set;}

        /// <summary>
        /// Desc:轨型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIL_TYPE {get;set;}

        /// <summary>
        /// Desc:延长线 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? EXTEND_LINE {get;set;}

        /// <summary>
        /// Desc:无缝延长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? EXTEN_JOINTLESS {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
