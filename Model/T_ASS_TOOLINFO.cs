using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_TOOLINFO
    {
        
        /// <summary>
        /// Desc:工机具ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_TOOL_ID {get;set;}

        /// <summary>
        /// Desc:工机具名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TOOL_NAME {get;set;}

        /// <summary>
        /// Desc:工机具类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TOOL_TYPE {get;set;}

        /// <summary>
        /// Desc:工机具计量单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TOOL_UNIT {get;set;}

        /// <summary>
        /// Desc:安全风险提示 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_SAFETYRISKTIPS {get;set;}

        /// <summary>
        /// Desc:是否有效 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_EFF_FLAG {get;set;}

        /// <summary>
        /// Desc:排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_ORDER {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

        /// <summary>
        /// Desc:是否重点机具 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool IS_KEYTOOL {get;set;}

        /// <summary>
        /// Desc:作业指导书 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_BOOK {get;set;}

    }
}
