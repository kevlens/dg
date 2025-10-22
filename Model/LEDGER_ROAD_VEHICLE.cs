using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class LEDGER_ROAD_VEHICLE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:原车种 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ORIGINCAR_TYPE {get;set;}

        /// <summary>
        /// Desc:现车种 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOWCAR_TYPE {get;set;}

        /// <summary>
        /// Desc:原车号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ORIGINCAR_NUM {get;set;}

        /// <summary>
        /// Desc:现车号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOWCAR_NUM {get;set;}

        /// <summary>
        /// Desc:辅修到期时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? MINOR_TIME {get;set;}

        /// <summary>
        /// Desc:段修到期时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? STATION_TIME {get;set;}

        /// <summary>
        /// Desc:厂修到期时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? FACTORY_TIME {get;set;}

        /// <summary>
        /// Desc:技术状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TECHNOLOGY_STATE {get;set;}

        /// <summary>
        /// Desc:设置车间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DISTRIBUTION_LOCATION {get;set;}

        /// <summary>
        /// Desc:外形尺寸 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SHAPE_SIZE {get;set;}

        /// <summary>
        /// Desc:标记 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BODY_MARK {get;set;}

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
        /// Desc:使用单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string USE_DEPT {get;set;}

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
        /// Desc:保管人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRESERVER {get;set;}

        /// <summary>
        /// Desc:所属大类 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LARGE_CLASS {get;set;}

    }
}
