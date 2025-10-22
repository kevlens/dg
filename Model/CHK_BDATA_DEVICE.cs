using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class CHK_BDATA_DEVICE
    {
        
        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DEVICE_ID {get;set;}

        /// <summary>
        /// Desc:所属部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_NO {get;set;}

        /// <summary>
        /// Desc:设备编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEVICE_NO {get;set;}

        /// <summary>
        /// Desc:设备名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEVICE_NAME {get;set;}

        /// <summary>
        /// Desc:设备备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEVICE_MEMO {get;set;}

    }
}
