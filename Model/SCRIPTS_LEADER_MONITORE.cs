using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class SCRIPTS_LEADER_MONITORE
    {
        
        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:部门编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:导入日期时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? IMPORT_TIME {get;set;}

        /// <summary>
        /// Desc:导入用户 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string IMPORT_USER {get;set;}

        /// <summary>
        /// Desc:日期转换日期格式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? EXCEL_DATE {get;set;}

        /// <summary>
        /// Desc:日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EXCEL_DATEIN {get;set;}

        /// <summary>
        /// Desc:车间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHE_JIAN {get;set;}

        /// <summary>
        /// Desc:班组 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BAN_ZU {get;set;}

        /// <summary>
        /// Desc:内容等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTENT_LEVEL {get;set;}

        /// <summary>
        /// Desc:作业地点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_PLACE {get;set;}

        /// <summary>
        /// Desc:带班人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_LEADER {get;set;}

        /// <summary>
        /// Desc:车间盯控 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHEJIAN_MONITOR {get;set;}

        /// <summary>
        /// Desc:站段盯控 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_MONITOR {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOTE {get;set;}

        /// <summary>
        /// Desc:状态标志（1无轨迹无照片 2有轨迹无照片 3无轨迹有照片 4有轨迹有照片） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? STATUS_FLAG {get;set;}

        /// <summary>
        /// Desc:手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_NO {get;set;}

        /// <summary>
        /// Desc:手机号对应部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_DEPTCODE {get;set;}

    }
}
