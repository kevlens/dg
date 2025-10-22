using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_BOUND
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string BOUND_ID {get;set;}

        /// <summary>
        /// Desc:单位代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DEP_CODE {get;set;}

        /// <summary>
        /// Desc:单位级别（0、1、2、3） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? DEP_LEV {get;set;}

        /// <summary>
        /// Desc:线代码 
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
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

        /// <summary>
        /// Desc:管界属性（0：默认；1：检查；2：维修） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool BOUND_TYPE {get;set;}

    }
}
