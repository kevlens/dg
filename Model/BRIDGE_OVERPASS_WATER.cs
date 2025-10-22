using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_OVERPASS_WATER
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string OVERPASSWATER_ID {get;set;}

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
        /// Desc:孔跨式样 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HOLESPAN_STYLE {get;set;}

        /// <summary>
        /// Desc:建成年代 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BUILD_YEAR {get;set;}

        /// <summary>
        /// Desc:排水方式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DRAINAGE_STYLE {get;set;}

        /// <summary>
        /// Desc:排水设备 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DRAINAGE_EQUIP {get;set;}

        /// <summary>
        /// Desc:引道形式路面结构 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ROAD_STRUCT {get;set;}

        /// <summary>
        /// Desc:引道形式护坡形式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REVETMENT_STYLE {get;set;}

        /// <summary>
        /// Desc:积水情况严重程度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WATER_SEVERITY {get;set;}

        /// <summary>
        /// Desc:积水情况现状 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WATER_NOWSTATUS {get;set;}

        /// <summary>
        /// Desc:过道情况过道材质 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AISLE_MATERIAL {get;set;}

        /// <summary>
        /// Desc:过道情况高*宽 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AISLE_HEIGHTWIDTH {get;set;}

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
