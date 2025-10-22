using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class JOB_WARN
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FKID {get;set;}

        /// <summary>
        /// Desc:报警类型 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string WARNTYPE {get;set;}

        /// <summary>
        /// Desc:站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME {get;set;}

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
        public string DIRECTION {get;set;}

        /// <summary>
        /// Desc:里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE {get;set;}

        /// <summary>
        /// Desc:整改时限 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CORRECT_LIMIT {get;set;}

        /// <summary>
        /// Desc:报警内容 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string WARNDETAIL {get;set;}

        /// <summary>
        /// Desc:最后更新时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? LAST_TIME {get;set;}

        /// <summary>
        /// Desc:更新周期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public short UPDATE_CYCLE {get;set;}

        /// <summary>
        /// Desc:开始里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? MILEAGE_BEGIN {get;set;}

        /// <summary>
        /// Desc:结束里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? MILEAGE_END {get;set;}

        /// <summary>
        /// Desc:巡检周期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? PATROL_CYCLE {get;set;}

        /// <summary>
        /// Desc:巡检人员 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER_HOME {get;set;}

        /// <summary>
        /// Desc:巡检人手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE {get;set;}

        /// <summary>
        /// Desc:最后一次巡检日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? ENDPATROL_DATE {get;set;}

        /// <summary>
        /// Desc:开始时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? DATE_BEGIN {get;set;}

        /// <summary>
        /// Desc:结束时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? DATE_END {get;set;}

        /// <summary>
        /// Desc:施工ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORKID {get;set;}

        /// <summary>
        /// Desc:消警 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WARNDIS {get;set;}

        /// <summary>
        /// Desc:单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPCODE {get;set;}

        /// <summary>
        /// Desc:时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CREATETIME {get;set;}

        /// <summary>
        /// Desc:报警详情 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WAINCONTENT {get;set;}

        /// <summary>
        /// Desc:计划ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_ID {get;set;}

        /// <summary>
        /// Desc:作业计划类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TYPE {get;set;}

        /// <summary>
        /// Desc:0未解除,1解除报警 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TERMINATED {get;set;}

        /// <summary>
        /// Desc:备注(解除报警原因) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REMARK {get;set;}

        /// <summary>
        /// Desc:火星经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARS_LONGITUDE {get;set;}

        /// <summary>
        /// Desc:火星纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARS_LATITUDE {get;set;}

        /// <summary>
        /// Desc:手机负责人类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_TYPE {get;set;}

    }
}
