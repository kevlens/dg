using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class ALL_VEHTYPE_DATA
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:车型编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string VEHTYPE_NUM {get;set;}

        /// <summary>
        /// Desc:车型英文描述 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string VEHTYPE_ENGDESC {get;set;}

        /// <summary>
        /// Desc:车型中文描述 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string VEHTYPE_CHIDESC {get;set;}

    }
}
