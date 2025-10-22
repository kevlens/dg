using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class LKJ_STATION
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
        /// Desc:车站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME {get;set;}

        /// <summary>
        /// Desc:车站编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_CODE {get;set;}

        /// <summary>
        /// Desc:拼音字头 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SPELL_PRE {get;set;}

        /// <summary>
        /// Desc:股道数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_NUM {get;set;}

        /// <summary>
        /// Desc:中心里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CENTER_MILEAGE {get;set;}

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
        public string CREATE_TIME {get;set;}

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
