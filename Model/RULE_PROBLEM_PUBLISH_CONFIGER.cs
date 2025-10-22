using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RULE_PROBLEM_PUBLISH_CONFIGER
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:处分类别（处分职工人数、处分工班长人数、处分干部人数） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PUNISH_CAT {get;set;}

        /// <summary>
        /// Desc:"处分类型（离岗培训
、经济考核、撤职、处分、免职、诫勉谈话）" 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PUNISH_TYPE {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
