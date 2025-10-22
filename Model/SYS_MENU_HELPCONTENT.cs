using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class SYS_MENU_HELPCONTENT
    {
        
        /// <summary>
        /// Desc:ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CONTENT_ID {get;set;}

        /// <summary>
        /// Desc:系统ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MENU_ID {get;set;}

        /// <summary>
        /// Desc:文档内容 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HELP_CONTENT {get;set;}

        /// <summary>
        /// Desc:排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTENT_ORDER {get;set;}

        /// <summary>
        /// Desc:更新日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? UPDATE_DATE {get;set;}

        /// <summary>
        /// Desc:更新者 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UPDATE_USER {get;set;}

    }
}
