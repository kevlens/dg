using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class CONFIR_CAR_WARN
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:计划ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CARPLAN_PKID {get;set;}

        /// <summary>
        /// Desc:报警内容 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WARN_CONTENT {get;set;}

        /// <summary>
        /// Desc:报警时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? WARN_TIME {get;set;}

        /// <summary>
        /// Desc:报警类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WARN_TYPE {get;set;}

        /// <summary>
        /// Desc:报警状态（0报警，1解除） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WARN_STATE {get;set;}

        /// <summary>
        /// Desc:解除报警用户名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RELEASE_USER {get;set;}

        /// <summary>
        /// Desc:解除报警时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RELEASE_TIME {get;set;}

        /// <summary>
        /// Desc:部门编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:解除报警内容 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RELEASE_NOTE {get;set;}

    }
}
