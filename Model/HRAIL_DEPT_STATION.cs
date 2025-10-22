using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class HRAIL_DEPT_STATION
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DEPTSTATION_ID {get;set;}

        /// <summary>
        /// Desc:部门代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:车站代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string STATION_CODE {get;set;}

        /// <summary>
        /// Desc:标记 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool FLAG {get;set;}

    }
}
