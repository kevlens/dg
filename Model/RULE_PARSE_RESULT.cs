using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RULE_PARSE_RESULT
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PDKID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PROBLEM_PKID {get;set;}

        /// <summary>
        /// Desc:问题评估点代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PROBLEM_KEYWORDCODE {get;set;}

        /// <summary>
        /// Desc:问题评估点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROBLEM_KEYWORD {get;set;}

        /// <summary>
        /// Desc:制度代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DOCCODE {get;set;}

        /// <summary>
        /// Desc:章节条目 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHAPTER_ITEM {get;set;}

        /// <summary>
        /// Desc:匹配次数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? MATCHING_NUM {get;set;}

        /// <summary>
        /// Desc:分值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? SCORE {get;set;}

        /// <summary>
        /// Desc:分析日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? PROCESS_DATE {get;set;}

        /// <summary>
        /// Desc:部门代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CREATOR {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
