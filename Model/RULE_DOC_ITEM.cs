using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RULE_DOC_ITEM
    {
        
        /// <summary>
        /// Desc:制度代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DOCCODE {get;set;}

        /// <summary>
        /// Desc:分解条目代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string ITEMCODE {get;set;}

        /// <summary>
        /// Desc:分解条目内容 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string ITEMCONTENT {get;set;}

        /// <summary>
        /// Desc:文档页签 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BOOKMARK {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

        /// <summary>
        /// Desc:有效标示 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string EFF_FLAG {get;set;}

        /// <summary>
        /// Desc:创建人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CREATOR {get;set;}

        /// <summary>
        /// Desc:创建时间 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public DateTime CREATETIME {get;set;}

    }
}
