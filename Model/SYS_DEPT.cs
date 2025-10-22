using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class SYS_DEPT
    {
        
        /// <summary>
        /// Desc:部门编码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:部门名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_NAME {get;set;}

        /// <summary>
        /// Desc:上级部门编码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PARENT_CODE {get;set;}

        /// <summary>
        /// Desc:图标 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_ICO {get;set;}

        /// <summary>
        /// Desc:打开状态（1：打开；0：关闭） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATUS_FLAG {get;set;}

        /// <summary>
        /// Desc:逻辑删除标志(0：正常，1：删除) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEL_FLAG {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOTE {get;set;}

        /// <summary>
        /// Desc:排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? DEPT_ORDER {get;set;}

        /// <summary>
        /// Desc:部门标记 (0：单位；1：部门) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? DEPT_FLAG {get;set;}

    }
}
