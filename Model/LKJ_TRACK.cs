using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class LKJ_TRACK
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
        public string STATION_NUM {get;set;}

        /// <summary>
        /// Desc:股道编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_NUM {get;set;}

        /// <summary>
        /// Desc:有效长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EFFECTIVE_LENGTH {get;set;}

        /// <summary>
        /// Desc:全长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ALL_LENGTH {get;set;}

        /// <summary>
        /// Desc:曲线半径 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CURVE_RADIUS {get;set;}

        /// <summary>
        /// Desc:方向 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIRECTION {get;set;}

        /// <summary>
        /// Desc:坡度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SLOPE {get;set;}

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
        /// Desc:坡段长度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SLOPE_LENGTH {get;set;}

    }
}
