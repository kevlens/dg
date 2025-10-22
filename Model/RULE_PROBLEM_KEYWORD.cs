using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RULE_PROBLEM_KEYWORD
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:问题库PKID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PROBLEM_PKID {get;set;}

        /// <summary>
        /// Desc:问题评估点代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string KEYWORDCODE {get;set;}

        /// <summary>
        /// Desc:问题评估点 
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

    }
}
