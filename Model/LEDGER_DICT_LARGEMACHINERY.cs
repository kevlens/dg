using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class LEDGER_DICT_LARGEMACHINERY
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:分类ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPE_ID {get;set;}

        /// <summary>
        /// Desc:分类名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPE_NAME {get;set;}

        /// <summary>
        /// Desc:父类ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PARENT_ID {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEMO {get;set;}

    }
}
