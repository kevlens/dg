using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIL_CARRIERSECTION_WARN
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string SECTION_ID {get;set;}

        /// <summary>
        /// Desc:正常，断轨 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SECTION_STATUS {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RECORD_TIME {get;set;}

        /// <summary>
        /// Desc:0客户，1或者null开发 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string IS_SHOW {get;set;}

    }
}
