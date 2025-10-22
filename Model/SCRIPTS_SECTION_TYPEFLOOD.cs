using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class SCRIPTS_SECTION_TYPEFLOOD
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string TYPEFLOOD_ID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string TYPEFLOOD_NAME {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ICON {get;set;}

        /// <summary>
        /// Desc:部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:部门名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_NAME {get;set;}

        /// <summary>
        /// Desc:级别(分1、2、3级) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPEFLOOD_LEVEL {get;set;}

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
        /// Desc:中心里程坐标 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_CENTER {get;set;}

        /// <summary>
        /// Desc:开始里程坐标 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_BEGIN {get;set;}

        /// <summary>
        /// Desc:结束里程坐标 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_END {get;set;}

        /// <summary>
        /// Desc:火星经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARSLONGITUDE {get;set;}

        /// <summary>
        /// Desc:火星纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARSLATITUDE {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPEFLOOD_NOTE {get;set;}

        /// <summary>
        /// Desc:类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FLOOD_TYPE {get;set;}

        /// <summary>
        /// Desc:预计灾害 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ESTIMATE_SITUATION {get;set;}

        /// <summary>
        /// Desc:抢险料具 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RESCUE_FACILITY {get;set;}

        /// <summary>
        /// Desc:抢险人数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? RESCUE_NUMBER {get;set;}

        /// <summary>
        /// Desc:观测制度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OBSERVATION_SYSTEM {get;set;}

        /// <summary>
        /// Desc:抢险办法 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RESCUE_WAY {get;set;}

        /// <summary>
        /// Desc:执行人员ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EXECUTIVE_ID {get;set;}

        /// <summary>
        /// Desc:执行人员 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EXECUTIVE {get;set;}

        /// <summary>
        /// Desc:包保干部ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EXECUTIVE_LEADER_ID {get;set;}

        /// <summary>
        /// Desc:包保干部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EXECUTIVE_LEADER {get;set;}

        /// <summary>
        /// Desc:侧别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_SIDE {get;set;}

        /// <summary>
        /// Desc:病害详情 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DISEASE_SITUATION {get;set;}

        /// <summary>
        /// Desc:责任工区 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DUTY_DEPT {get;set;}

        /// <summary>
        /// Desc:责任工区ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DUTY_DEPTCODE {get;set;}

    }
}
