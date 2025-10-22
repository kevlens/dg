using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class LEDGER_INTERPHONE
    {
        
        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:对讲机编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INTERPHONE_NO {get;set;}

        /// <summary>
        /// Desc:对讲机名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INTERPHONE_NAME {get;set;}

        /// <summary>
        /// Desc:型号规格 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INTERPHONE_TYPE {get;set;}

        /// <summary>
        /// Desc:制造单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MANUFACTURE_UNIT {get;set;}

        /// <summary>
        /// Desc:制造年月 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MANUFACTURE_DATE {get;set;}

        /// <summary>
        /// Desc:固定原值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? ORIGINAL_VALUE {get;set;}

        /// <summary>
        /// Desc:单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UNIT {get;set;}

        /// <summary>
        /// Desc:数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? AMOUNT {get;set;}

        /// <summary>
        /// Desc:始用年月 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? BEGINTIME {get;set;}

        /// <summary>
        /// Desc:技术状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TECHNOLOGY_STATE {get;set;}

        /// <summary>
        /// Desc:车间名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_NAME {get;set;}

        /// <summary>
        /// Desc:班组 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_NAME {get;set;}

        /// <summary>
        /// Desc:录音功能 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECORDING {get;set;}

        /// <summary>
        /// Desc:保管人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRESERVER {get;set;}

        /// <summary>
        /// Desc:部门编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:录入时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? INPUT_DATE {get;set;}

        /// <summary>
        /// Desc:录入人员 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INPUT_USER {get;set;}

        /// <summary>
        /// Desc:所属大类 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LARGE_CLASS {get;set;}

        /// <summary>
        /// Desc:外形尺寸 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SHAPE_SIZE {get;set;}

    }
}
