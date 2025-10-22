using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class TURNOUT_HIS_RAIL
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string RAIL_ID {get;set;}

        /// <summary>
        /// Desc:历史编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HISTORY_ID {get;set;}

        /// <summary>
        /// Desc:道岔种类 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIL_TYPE {get;set;}

        /// <summary>
        /// Desc:长度（mm） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public long RAIL_LENGTH {get;set;}

        /// <summary>
        /// Desc:更换时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RAIL_UPDATE {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIL_NOTE {get;set;}

    }
}
