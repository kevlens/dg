using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class LEDGER_TRAFFIC_VEHICLES
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:车号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CAR_NUMBER {get;set;}

        /// <summary>
        /// Desc:车辆类别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CAR_TYPE {get;set;}

        /// <summary>
        /// Desc:车辆名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CAR_NAME {get;set;}

        /// <summary>
        /// Desc:车辆型号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CAR_MODEL {get;set;}

        /// <summary>
        /// Desc:产地 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ORIGIN_PLACE {get;set;}

        /// <summary>
        /// Desc:T 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string T_SEAT {get;set;}

        /// <summary>
        /// Desc:入户时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? BEGIN_TIME {get;set;}

        /// <summary>
        /// Desc:固定原值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? ORIGINAL_VALUE {get;set;}

        /// <summary>
        /// Desc:运行公里 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? RUN_KM {get;set;}

        /// <summary>
        /// Desc:款源 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MONEY_SOURCE {get;set;}

        /// <summary>
        /// Desc:产权单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROPERTY_UNIT {get;set;}

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
        /// Desc:工区名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_NAME {get;set;}

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
        /// Desc:设置车间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DISTRIBUTION_LOCATION {get;set;}

        /// <summary>
        /// Desc:设置班组 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SETUP_TEAM {get;set;}

        /// <summary>
        /// Desc:司机 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DRIVER {get;set;}

        /// <summary>
        /// Desc:副司机 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPUTY_DRIVER {get;set;}

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
