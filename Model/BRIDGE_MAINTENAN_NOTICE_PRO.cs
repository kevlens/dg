using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_MAINTENAN_NOTICE_PRO
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string NOTICE_PRO_ID {get;set;}

        /// <summary>
        /// Desc:问题ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRO_ID {get;set;}

        /// <summary>
        /// Desc:问题代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRO_CODE {get;set;}

        /// <summary>
        /// Desc:具体问题 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PRO_NAME {get;set;}

        /// <summary>
        /// Desc:序号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Byte? PRO_ORDER {get;set;}

        /// <summary>
        /// Desc:ENTRY_MODE（0：自动；1：人工提取；2：人工录入） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool INPUT_MODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool PROCESS_FLAG {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool CLEAR_FLAG {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

        /// <summary>
        /// Desc:问题详情 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRO_DETAIL {get;set;}

        /// <summary>
        /// Desc:问题位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRO_PLACE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string NOTICE_ID {get;set;}

        /// <summary>
        /// Desc:问题数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Byte? PRO_NUM {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CRT_TM {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CRT_NAME {get;set;}

    }
}
