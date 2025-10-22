using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIN_PLAN_WARN
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:监测点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIN_NAME {get;set;}

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
        /// Desc:工区编码 
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

        /// <summary>
        /// Desc:编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIN_CODE {get;set;}

        /// <summary>
        /// Desc:执行工区 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_NAME {get;set;}

        /// <summary>
        /// Desc:手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE {get;set;}

        /// <summary>
        /// Desc:出巡计划内容 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_CONTENT {get;set;}

    }
}
