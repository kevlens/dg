using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_BDATA_LIMIT
    {
        
        /// <summary>
        /// Desc:管界表主键ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LIMIT_ID {get;set;}

        /// <summary>
        /// Desc:部门编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

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
        /// Desc:管界里程开始 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? MILEAGE_BEGIN {get;set;}

        /// <summary>
        /// Desc:管界里程结束 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? MILEAGE_END {get;set;}

        /// <summary>
        /// Desc:线数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? LINE_NUM {get;set;}

        /// <summary>
        /// Desc:管界线路步长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? LIMIT_LENGTH {get;set;}

        /// <summary>
        /// Desc:创建时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CREATE_TIME {get;set;}

        /// <summary>
        /// Desc:管界备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LIMIT_NOTE {get;set;}

    }
}
