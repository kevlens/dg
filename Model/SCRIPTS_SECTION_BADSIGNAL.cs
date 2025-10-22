using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class SCRIPTS_SECTION_BADSIGNAL
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:部门编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POSITION {get;set;}

        /// <summary>
        /// Desc:开始里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_START {get;set;}

        /// <summary>
        /// Desc:结束里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_END {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOTE {get;set;}

        /// <summary>
        /// Desc:0信号不良地段，1无法上传地段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPE {get;set;}

    }
}
