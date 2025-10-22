using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_STATIONSTAIRS
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:车站 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_STATION {get;set;}

        /// <summary>
        /// Desc:上下线梯口 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_STAIRS {get;set;}

        /// <summary>
        /// Desc:是否有效 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_EFF_FLAG {get;set;}

        /// <summary>
        /// Desc:排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_ORDER {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

    }
}
