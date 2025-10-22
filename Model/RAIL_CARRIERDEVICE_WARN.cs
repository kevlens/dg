using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIL_CARRIERDEVICE_WARN
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POINT_NO {get;set;}

        /// <summary>
        /// Desc:故障，正常 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POINT_STATUS {get;set;}

        /// <summary>
        /// Desc:0客户，1or NULL开发 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string IS_SHOW {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RECORD_TIME {get;set;}

    }
}
