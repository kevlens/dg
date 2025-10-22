using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIL_BDATA_SENDPHONENO
    {
        
        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string SENDPHONENO_NO {get;set;}

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
        public string MOBILE {get;set;}

        /// <summary>
        /// Desc:发送角色（0：厂家维护号码 1：报警发送号码） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SEND_ROLE {get;set;}

        /// <summary>
        /// Desc:更新者 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UPDATE_USER {get;set;}

        /// <summary>
        /// Desc:更新日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? UPDATE_DATE {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SENDPHONENO_NOTE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SECTION_ID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SEND_NAME {get;set;}

        /// <summary>
        /// Desc:管界起始里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? BOUNDARY_START {get;set;}

        /// <summary>
        /// Desc:管界结束里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? BOUNDARY_END {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:是否启用 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string IS_ENABLE {get;set;}

    }
}
