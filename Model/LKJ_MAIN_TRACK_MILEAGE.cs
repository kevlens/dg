using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class LKJ_MAIN_TRACK_MILEAGE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:序号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NUM {get;set;}

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
        /// Desc:起点—站间或站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string START_INTERVAL_OR_STATION {get;set;}

        /// <summary>
        /// Desc:起点—位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string START_PLACE {get;set;}

        /// <summary>
        /// Desc:起点—里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string START_MILEAGE {get;set;}

        /// <summary>
        /// Desc:终点—站间或站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string END_INTERVAL_OR_STATION {get;set;}

        /// <summary>
        /// Desc:终点—位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string END_PLACE {get;set;}

        /// <summary>
        /// Desc:终点—里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string END_MILEAGE {get;set;}

        /// <summary>
        /// Desc:延展长度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EXTENDED_LENGTH {get;set;}

        /// <summary>
        /// Desc:修改标注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MODIFY_TAG {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REMARKS {get;set;}

        /// <summary>
        /// Desc:创建时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CREATE_TIME {get;set;}

        /// <summary>
        /// Desc:用户名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string USER_NAME {get;set;}

        /// <summary>
        /// Desc:部门编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:线编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NUM {get;set;}

    }
}
