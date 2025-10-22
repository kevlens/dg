using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class SYS_USER_PHONE_DIC
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
        public string USERNAME {get;set;}

        /// <summary>
        /// Desc:区号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AREACODE {get;set;}

        /// <summary>
        /// Desc:城市名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CITYNAME {get;set;}

        /// <summary>
        /// Desc:工区区号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORKCODE {get;set;}

    }
}
