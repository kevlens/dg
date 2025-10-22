using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_BDATA_CLIENT
    {
        
        /// <summary>
        /// Desc:驻站编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CLIENT_NO {get;set;}

        /// <summary>
        /// Desc:驻站名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLIENT_NAME {get;set;}

        /// <summary>
        /// Desc:驻站区间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLIENT_SECTION {get;set;}

        /// <summary>
        /// Desc:登录密码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PASSWORD {get;set;}

        /// <summary>
        /// Desc:所属部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:线代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_CODE {get;set;}

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
        /// Desc:开始里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_START {get;set;}

        /// <summary>
        /// Desc:结束里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_END {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLIENT_NOTE {get;set;}

    }
}
