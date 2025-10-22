using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class SYS_USER
    {
        
        /// <summary>
        /// Desc:帐号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string USER_NAME {get;set;}

        /// <summary>
        /// Desc:密码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PASSWORD {get;set;}

        /// <summary>
        /// Desc:权限部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

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

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOTE {get;set;}

        /// <summary>
        /// Desc:所属部门代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MANAGE_DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZSNAME {get;set;}

    }
}
