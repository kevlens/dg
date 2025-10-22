using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class SYS_STATIONMEMBER_NO
    {
        
        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string NO_ID {get;set;}

        /// <summary>
        /// Desc:所属部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:车间名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_NAME {get;set;}

        /// <summary>
        /// Desc:工区名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_NAME {get;set;}

        /// <summary>
        /// Desc:驻站员姓名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMBER_NAME {get;set;}

        /// <summary>
        /// Desc:车站名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME {get;set;}

        /// <summary>
        /// Desc:电话 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TEL_NO {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
