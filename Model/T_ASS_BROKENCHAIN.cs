using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_BROKENCHAIN
    {
        
        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string BROKENCHAIN_ID {get;set;}

        /// <summary>
        /// Desc:路局代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DEP_CODE {get;set;}

        /// <summary>
        /// Desc:线路代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LINE_CDOE {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:断链类型（长链、短链） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string BROKENCHAIN_TYPE {get;set;}

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
        /// Desc:断链长度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? BROKENCHAIN_LEN {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
