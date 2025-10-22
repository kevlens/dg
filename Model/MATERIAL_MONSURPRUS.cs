using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class MATERIAL_MONSURPRUS
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:材料电子标签 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string MATERIALID {get;set;}

        /// <summary>
        /// Desc:统计的年 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string COUNTYEAR {get;set;}

        /// <summary>
        /// Desc:统计的月 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string COUNTMON {get;set;}

        /// <summary>
        /// Desc:月结余 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? MONSURPLUS {get;set;}

        /// <summary>
        /// Desc:部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEP_ID {get;set;}

    }
}
