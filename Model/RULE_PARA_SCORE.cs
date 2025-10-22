using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RULE_PARA_SCORE
    {
        
        /// <summary>
        /// Desc:问题扣分主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:制度代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DOCCODE {get;set;}

        /// <summary>
        /// Desc:关键字代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string KEYWORDCODE {get;set;}

        /// <summary>
        /// Desc:条目 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHAPTER_ITEM {get;set;}

        /// <summary>
        /// Desc:责任对象(段、车间、工区、个人) 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DUTY_OBJECT {get;set;}

        /// <summary>
        /// Desc:匹配次数 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public byte MATCH_NUMBER {get;set;}

        /// <summary>
        /// Desc:权重比例 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? WEIGHT {get;set;}

        /// <summary>
        /// Desc:分类 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? CAT {get;set;}

        /// <summary>
        /// Desc:扣分值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? SCORE {get;set;}

        /// <summary>
        /// Desc:有效标记 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string EFF_FALG {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

        /// <summary>
        /// Desc:问题级别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROBLEM_LEVEL {get;set;}

    }
}
