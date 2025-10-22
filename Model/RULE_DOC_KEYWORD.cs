using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RULE_DOC_KEYWORD
    {
        
        /// <summary>
        /// Desc:制度代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DOCCODE {get;set;}

        /// <summary>
        /// Desc:关键字代码（问题评估点代码） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string KEYWORDCODE {get;set;}

        /// <summary>
        /// Desc:关键字（问题评估点） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string KEYWORD {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

        /// <summary>
        /// Desc:有效标记 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string EFF_FALG {get;set;}

        /// <summary>
        /// Desc:章节条目 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHAPTER_ITEM {get;set;}

    }
}
