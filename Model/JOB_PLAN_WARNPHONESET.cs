using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class JOB_PLAN_WARNPHONESET
    {
        
        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:所属部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:人员ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string MEMBER_ID {get;set;}

        /// <summary>
        /// Desc:手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_NO {get;set;}

        /// <summary>
        /// Desc:更新时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? LST_DATE {get;set;}

        /// <summary>
        /// Desc:更新登陆人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LST_USER {get;set;}

        /// <summary>
        /// Desc:备留 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EXT1 {get;set;}

        /// <summary>
        /// Desc:备留 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EXT2 {get;set;}

    }
}
