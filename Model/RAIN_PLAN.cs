using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIN_PLAN
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:监测点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIN_NAME {get;set;}

        /// <summary>
        /// Desc:编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIN_CODE {get;set;}

        /// <summary>
        /// Desc:线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME {get;set;}

        /// <summary>
        /// Desc:执行工区 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_NAME {get;set;}

        /// <summary>
        /// Desc:工区编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:小里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? MILEAGE_BEGIN {get;set;}

        /// <summary>
        /// Desc:大里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? MILEAGE_END {get;set;}

        /// <summary>
        /// Desc:出巡手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIRECTION {get;set;}

        /// <summary>
        /// Desc:注意、限速、封锁、解除、正常 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATUS {get;set;}

        /// <summary>
        /// Desc:时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? UPDATETIME {get;set;}

        /// <summary>
        /// Desc:错误信息 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ERRORINFO {get;set;}

        /// <summary>
        /// Desc:实际出巡小里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? MILEAGE_BEGIN_PATROL {get;set;}

        /// <summary>
        /// Desc:实际出巡大里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? MILEAGE_END_PATROL {get;set;}

    }
}
