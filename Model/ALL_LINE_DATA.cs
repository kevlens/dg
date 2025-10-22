using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class ALL_LINE_DATA
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:路局编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LJ_CODE {get;set;}

        /// <summary>
        /// Desc:路局名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LJ_NAME {get;set;}

        /// <summary>
        /// Desc:线代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_CODE {get;set;}

        /// <summary>
        /// Desc:线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME {get;set;}

    }
}
