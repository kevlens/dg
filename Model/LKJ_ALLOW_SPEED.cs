using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class LKJ_ALLOW_SPEED
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

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
        /// Desc:区段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SECTION {get;set;}

        /// <summary>
        /// Desc:线路允许速度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_ALLOW_SPEED {get;set;}

        /// <summary>
        /// Desc:车站过岔速度——直向 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FORK_SPEED_STRAIGHT {get;set;}

        /// <summary>
        /// Desc:车站过岔速度——侧向 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FORK_SPEED_SIDE {get;set;}

        /// <summary>
        /// Desc:长期限制慢行—地点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LIMIT_PLACE {get;set;}

        /// <summary>
        /// Desc:长期限制慢行—速度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LIMIT_SPEED {get;set;}

        /// <summary>
        /// Desc:长期限制慢行—原因 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LIMIT_CAUSE {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REMARKS {get;set;}

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

        /// <summary>
        /// Desc:线类别（例如：兰青线、拉日线等等） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_TYPE {get;set;}

    }
}
