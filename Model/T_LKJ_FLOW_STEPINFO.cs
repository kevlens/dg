using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_LKJ_FLOW_STEPINFO
    {
        
        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int FLOWID {get;set;}

        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int STEPID {get;set;}

        /// <summary>
        /// Desc:操作名 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string STEPNAME {get;set;}

        /// <summary>
        /// Desc:地址 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PAGEURL {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int DOCFLAG {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? FLOWTYPE {get;set;}

    }
}
