using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_BDATA_SKYLIGHT
    {
        
        /// <summary>
        /// Desc:天窗管理主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string SKYLIGHT_ID {get;set;}

        /// <summary>
        /// Desc:授权默认起始时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SKYLIGHT_TIME_BEGIN {get;set;}

        /// <summary>
        /// Desc:授权默认结束时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SKYLIGHT_TIME_END {get;set;}

        /// <summary>
        /// Desc:录入时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CREATE_TIME {get;set;}

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
        /// Desc:公里范围起始公里 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? MILEAGE_BEGIN {get;set;}

        /// <summary>
        /// Desc:公里范围结束范围 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? MILEAGE_END {get;set;}

        /// <summary>
        /// Desc:部门编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

    }
}
