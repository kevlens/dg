using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class TOOL_BDATE_TOOLNAME
    {
        
        /// <summary>
        /// Desc:工机具名称ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string ID {get;set;}

        /// <summary>
        /// Desc:工机具名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NAME {get;set;}

        /// <summary>
        /// Desc:工机具类型（字典表里工机具类型的ID） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TOOLTYPE_ID {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REMARK {get;set;}

    }
}
