using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_LRON_OVERPASS
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LRON_OVERPASS_ID {get;set;}

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
        /// Desc:桥名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BRIDGE_NAME {get;set;}

        /// <summary>
        /// Desc:桥隧号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BRIDGE_CODE {get;set;}

        /// <summary>
        /// Desc:孔跨式样 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HOLESPAN_STYLE {get;set;}

        /// <summary>
        /// Desc:所在区间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BRIDGE_SECTION {get;set;}

        /// <summary>
        /// Desc:桥下铁路线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ROAD_LINENAME {get;set;}

        /// <summary>
        /// Desc:桥下铁路里程(km) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? ROAD_MILE {get;set;}

        /// <summary>
        /// Desc:孔位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HOLE_POSITION {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
