using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class SYS_MENU
    {
        
        /// <summary>
        /// Desc:菜单ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string MENU_ID {get;set;}

        /// <summary>
        /// Desc:菜单名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MENU_NAME {get;set;}

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
        /// Desc:上级菜单ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PARENT_ID {get;set;}

        /// <summary>
        /// Desc:菜单级别 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int MENU_LEVEL {get;set;}

        /// <summary>
        /// Desc:排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? MENU_ORDER {get;set;}

        /// <summary>
        /// Desc:GIS排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GIS_ORDER {get;set;}

        /// <summary>
        /// Desc:是否显示（为0不显示） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ISSHOW_FLAG {get;set;}

        /// <summary>
        /// Desc:一级菜单打开默认加载的三级菜单，需在一级菜单对应处填写三级菜单ID（8位） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEFMENU_ID {get;set;}

    }
}
