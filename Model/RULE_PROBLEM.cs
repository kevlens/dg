using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RULE_PROBLEM
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:部门代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:检查人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INSPECTOR {get;set;}

        /// <summary>
        /// Desc:检查人单位 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string INSPECT_DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:检查人职务 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INSPECT_POST {get;set;}

        /// <summary>
        /// Desc:检查时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? INSPECT_TIME {get;set;}

        /// <summary>
        /// Desc:具体问题 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROBLEM {get;set;}

        /// <summary>
        /// Desc:专业分类 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PROFESSION_CAT {get;set;}

        /// <summary>
        /// Desc:问题性质 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PROBLEM_NATURE {get;set;}

        /// <summary>
        /// Desc:问题级别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROBLEM_LEVEL {get;set;}

        /// <summary>
        /// Desc:考核分值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? SCORE {get;set;}

        /// <summary>
        /// Desc:整改期限 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECTIFICATION_DEADLINE {get;set;}

        /// <summary>
        /// Desc:整改状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECTIFICATION_STATUS {get;set;}

        /// <summary>
        /// Desc:整改及追责情况 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECTIFICATION_DESC {get;set;}

        /// <summary>
        /// Desc:通报编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BULLETIN_NO {get;set;}

        /// <summary>
        /// Desc:局领导批示 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHIEF_INSTR {get;set;}

        /// <summary>
        /// Desc:处长批示 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIRECTOR_INSTR {get;set;}

        /// <summary>
        /// Desc:其它 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ORTHER {get;set;}

        /// <summary>
        /// Desc:参与分析标记 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string ANALYSIS_FLAG {get;set;}

        /// <summary>
        /// Desc:问题消记标记 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DOC_FLAG {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

        /// <summary>
        /// Desc:录入人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CREATOR {get;set;}

        /// <summary>
        /// Desc:录入时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CREATETIME {get;set;}

        /// <summary>
        /// Desc:岗位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB {get;set;}

        /// <summary>
        /// Desc:检查人部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INSPECT_OFFICE {get;set;}

        /// <summary>
        /// Desc:录入人部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CREATOR_OFFICE {get;set;}

    }
}
