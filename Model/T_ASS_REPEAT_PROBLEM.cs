using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_REPEAT_PROBLEM
    {
        
        /// <summary>
        /// Desc:主键  
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:部门代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_DEP_CODE {get;set;}

        /// <summary>
        /// Desc:线代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_CODE {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_DIR {get;set;}

        /// <summary>
        /// Desc:车站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_STATION_CODE {get;set;}

        /// <summary>
        /// Desc:股道 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TRACK_CODE {get;set;}

        /// <summary>
        /// Desc:道岔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TURNOUT_CODE {get;set;}

        /// <summary>
        /// Desc:病害项目 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_ITEM {get;set;}

        /// <summary>
        /// Desc:病害代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_CODE {get;set;}

        /// <summary>
        /// Desc:重复次数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_REPEAT_NUM {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

        /// <summary>
        /// Desc:前后里程范围 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_MILE_RANGE {get;set;}

        /// <summary>
        /// Desc:检查设备 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CHECK_DEV {get;set;}

        /// <summary>
        /// Desc:起点里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_START_MILE {get;set;}

        /// <summary>
        /// Desc:终点里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_END_MILE {get;set;}

        /// <summary>
        /// Desc:用户 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_USER {get;set;}

    }
}
