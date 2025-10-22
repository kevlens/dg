using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class TOOL_BDATE_STOREHOURSE
    {
        
        /// <summary>
        /// Desc:仓库ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string ID {get;set;}

        /// <summary>
        /// Desc:仓库名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NAME {get;set;}

        /// <summary>
        /// Desc:所属部门（部门表的ID） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEP_ID {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REMARK {get;set;}

    }
}
