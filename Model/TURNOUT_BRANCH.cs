using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class TURNOUT_BRANCH
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string BRANCH_ID {get;set;}

        /// <summary>
        /// Desc:道岔编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUT_ID {get;set;}

        /// <summary>
        /// Desc:岔枕长度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? BTANCH_LENGTH {get;set;}

        /// <summary>
        /// Desc:岔枕根数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? BRANCH_NUM {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BRANCH_NOTE {get;set;}

    }
}
