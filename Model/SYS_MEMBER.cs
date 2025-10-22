using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class SYS_MEMBER
    {
        
        /// <summary>
        /// Desc:人员ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string MEMBER_ID {get;set;}

        /// <summary>
        /// Desc:人员名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NAME {get;set;}

        /// <summary>
        /// Desc:定位手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MOBILE {get;set;}

        /// <summary>
        /// Desc:职位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB {get;set;}

        /// <summary>
        /// Desc:联系方式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOTE {get;set;}

        /// <summary>
        /// Desc:更新日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? UPDATE_DATE {get;set;}

        /// <summary>
        /// Desc:所属部门编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:更新者 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UPDATE_USER {get;set;}

        /// <summary>
        /// Desc:逻辑删除标志(0：正常，1：删除) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEL_FLAG {get;set;}

        /// <summary>
        /// Desc:是否定位手机标志(0：不是，1：是) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LOCATION_FLAG {get;set;}

        /// <summary>
        /// Desc:资质 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INTELLIGENCE {get;set;}

        /// <summary>
        /// Desc:级别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POS_LEVEL {get;set;}

        /// <summary>
        /// Desc:手机状态（0：正常，1：故障） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MOBILE_STATE {get;set;}

        /// <summary>
        /// Desc:T6对讲机设备ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEVICE_ID {get;set;}

        /// <summary>
        /// Desc:手机串号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_ID {get;set;}

    }
}
