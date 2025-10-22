using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class REPAIR_OVERRUN
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:轨型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? RAIL_TYPE {get;set;}

        /// <summary>
        /// Desc:线路类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_TYPE {get;set;}

        /// <summary>
        /// Desc:轨枕 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIL_SLEEPER {get;set;}

        /// <summary>
        /// Desc:道床 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIL_BALLAST {get;set;}

        /// <summary>
        /// Desc:大修换轨 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? REPAIR_LARGE {get;set;}

        /// <summary>
        /// Desc:中修换轨高 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? REPAIR_MIDSIZE_MAX {get;set;}

        /// <summary>
        /// Desc:中修换轨低 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? REPAIR_MIDSIZE_MIN {get;set;}

        /// <summary>
        /// Desc:维修换轨高 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? REPAIR_SMALLSIZE_MAX {get;set;}

        /// <summary>
        /// Desc:维修换轨低 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? REPAIR_SMALLSIZE_MIN {get;set;}

        /// <summary>
        /// Desc:大机清筛 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? REPAIR_CLEANING {get;set;}

        /// <summary>
        /// Desc:成组更换道岔轨件 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? REPLACE_TURNOUT {get;set;}

        /// <summary>
        /// Desc:线路大机捣固 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? LINE_TAMPING {get;set;}

        /// <summary>
        /// Desc:道岔大机捣固 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? TURNOUT_TAMPING {get;set;}

        /// <summary>
        /// Desc:道岔换砟 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? TURNOUT_BALLAST {get;set;}

        /// <summary>
        /// Desc:桥梁换砟 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? BRIDGE_BALLAST {get;set;}

        /// <summary>
        /// Desc:钢轨打磨 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? RAIL_POLISH {get;set;}

    }
}
