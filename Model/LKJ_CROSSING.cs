using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class LKJ_CROSSING
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:局名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BUREAU_NAME {get;set;}

        /// <summary>
        /// Desc:局编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BUREAU_NUM {get;set;}

        /// <summary>
        /// Desc:线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME {get;set;}

        /// <summary>
        /// Desc:线编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NUM {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:道口编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CROSSING_NUM {get;set;}

        /// <summary>
        /// Desc:道口名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CROSSING_NAME {get;set;}

        /// <summary>
        /// Desc:中心里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CENTER_MILEAGE {get;set;}

        /// <summary>
        /// Desc:道路类别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ROAD_CATEGORY {get;set;}

        /// <summary>
        /// Desc:站间或站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INTERVAL_OR_STATION {get;set;}

        /// <summary>
        /// Desc:是否道机联控 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTROL_ROAD_MACHINE {get;set;}

        /// <summary>
        /// Desc:上行道机联控提示里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTROL_ROAD_MACHINE_UP {get;set;}

        /// <summary>
        /// Desc:下行道机联控提示里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTROL_ROAD_MACHINE_DOWN {get;set;}

        /// <summary>
        /// Desc:呼叫名称、行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CALL_NAME_DIR {get;set;}

        /// <summary>
        /// Desc:修改标注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MODIFY_TAG {get;set;}

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

    }
}
