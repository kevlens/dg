using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class ALL_STATION_DATA
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
        /// Desc:车站代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_CODE {get;set;}

        /// <summary>
        /// Desc:车站名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME {get;set;}

    }
}
