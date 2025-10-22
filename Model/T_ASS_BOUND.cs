using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_BOUND
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:单位代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_DEP_CODE {get;set;}

        /// <summary>
        /// Desc:单位级别（0、1、2、3） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int N_DEP_LEV {get;set;}

        /// <summary>
        /// Desc:线代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_LINE_CODE {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_LINE_DIR {get;set;}

        /// <summary>
        /// Desc:线别 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_LINE_CAT {get;set;}

        /// <summary>
        /// Desc:起点里程 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public Double N_START_MILE {get;set;}

        /// <summary>
        /// Desc:终点里程 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public Double N_END_MILE {get;set;}

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

        /// <summary>
        /// Desc:管界属性（0：默认；1：检查；2：维修） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool BOUND_TYPE {get;set;}

    }
}
