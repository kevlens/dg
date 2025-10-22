using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_LKJ_ROLEFLOW
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string GID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string ROLEID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int FLOWID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int STEPID {get;set;}

        /// <summary>
        /// Desc:0:查看;1:使用 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FLOWPERMIT {get;set;}

    }
}
