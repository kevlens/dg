using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class LEDGER_MECHANICAL_VEHICLE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:使用单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string USE_DEPT {get;set;}

        /// <summary>
        /// Desc:机械编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EQUIPMENT_NUM {get;set;}

        /// <summary>
        /// Desc:机械名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EQUIPMENT_NAME {get;set;}

        /// <summary>
        /// Desc:车辆型规 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string VEHICLE_MODEL {get;set;}

        /// <summary>
        /// Desc:运控型规 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MONITORING_MODEL {get;set;}

        /// <summary>
        /// Desc:列调型规 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COLUMNADJUST_MODEL {get;set;}

        /// <summary>
        /// Desc:车辆厂商 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string VEHICLE_FACTORY {get;set;}

        /// <summary>
        /// Desc:运控厂商 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MONITORING_FACTORY {get;set;}

        /// <summary>
        /// Desc:列调厂商 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COLUMNADJUST_FACTORY {get;set;}

        /// <summary>
        /// Desc:车辆出厂日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? VEHICLE_DATE {get;set;}

        /// <summary>
        /// Desc:运控出厂日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? MONITORING_DATE {get;set;}

        /// <summary>
        /// Desc:列调出厂日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? COLUMNADJUST_DATE {get;set;}

        /// <summary>
        /// Desc:上次大修日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? LASTOVERHAUL_DATE {get;set;}

        /// <summary>
        /// Desc:上次大修单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LASTOVERHAUL_UNIT {get;set;}

        /// <summary>
        /// Desc:技术状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TECHNOLOGY_STATE {get;set;}

        /// <summary>
        /// Desc:运控状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MONITORING_STATE {get;set;}

        /// <summary>
        /// Desc:列调状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COLUMNADJUST_STATE {get;set;}

        /// <summary>
        /// Desc:固定原值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? ORIGINAL_VALUE {get;set;}

        /// <summary>
        /// Desc:外形尺寸 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SHAPE_SIZE {get;set;}

        /// <summary>
        /// Desc:设置车间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SETUP_PLACE {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEMO {get;set;}

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

    }
}
