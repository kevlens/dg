using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class JOB_PLANCONTROL_COMMAND
    {
        
        /// <summary>
        /// Desc:车间编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DEPT_CODE_CJ {get;set;}

        /// <summary>
        /// Desc:车间名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_NAME_CJ {get;set;}

        /// <summary>
        /// Desc:上道命令号前缀 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ON_STATION_PRE {get;set;}

        /// <summary>
        /// Desc:下道命令号前缀 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOWN_STATION_PRE {get;set;}

        /// <summary>
        /// Desc:上次上道获取时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? LAST_ONGET_TIME {get;set;}

        /// <summary>
        /// Desc:上道命令号最新顺序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? LASTON_STATION_ORDER {get;set;}

        /// <summary>
        /// Desc:下道命令号最新顺序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? LASTDOWN_STATION_ORDER {get;set;}

        /// <summary>
        /// Desc:上次下道获取时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? LAST_DOWNGET_TIME {get;set;}

    }
}
