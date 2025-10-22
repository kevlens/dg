using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RULE_DOC
    {
        
        /// <summary>
        /// Desc:制度代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DOCCODE {get;set;}

        /// <summary>
        /// Desc:制度名称 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DOCNAME {get;set;}

        /// <summary>
        /// Desc:文号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOCNO {get;set;}

        /// <summary>
        /// Desc:关键字 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string KEYWORD {get;set;}

        /// <summary>
        /// Desc:摘要 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ABSTRACT {get;set;}

        /// <summary>
        /// Desc:制度分类 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DOCCAT {get;set;}

        /// <summary>
        /// Desc:专业分类 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROFESSIONCAT {get;set;}

        /// <summary>
        /// Desc:文档内容 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTENT {get;set;}

        /// <summary>
        /// Desc:文件名 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FILE_NAME {get;set;}

        /// <summary>
        /// Desc:文件格式/文件扩展名 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FILE_FORMAT {get;set;}

        /// <summary>
        /// Desc:文件路径 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FILE_PATH {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FILE_PATH_TXT {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FILE_PATH_HTML {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FILE_PATH_PDF {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

        /// <summary>
        /// Desc:有效标记( Y/N) 
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
        /// Nullable:True 
        /// </summary>
        public DateTime? CREATETIME {get;set;}

        /// <summary>
        /// Desc: 状态（0/1） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool DOCSTATUS {get;set;}

        /// <summary>
        /// Desc:归属单位(路局、站段、总公司) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPART_IN {get;set;}

        /// <summary>
        /// Desc:创建人单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPART_CREATE {get;set;}

        /// <summary>
        /// Desc:归属部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OFFICE_IN {get;set;}

        /// <summary>
        /// Desc:创建人部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OFFICE_CREATE {get;set;}

    }
}
