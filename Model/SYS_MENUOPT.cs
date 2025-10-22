using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class SYS_MENUOPT
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string MENUOPT_ID {get;set;}

        /// <summary>
        /// Desc:操作名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MENUOPT_NAME {get;set;}

        /// <summary>
        /// Desc:菜单外键 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MENU_ID {get;set;}

        /// <summary>
        /// Desc:图标 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_ICO {get;set;}

        /// <summary>
        /// Desc:区域 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AREA {get;set;}

        /// <summary>
        /// Desc:控制器 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTROLLER {get;set;}

        /// <summary>
        /// Desc:action 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ACTION {get;set;}

        /// <summary>
        /// Desc:说明 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOTE {get;set;}

    }
}
