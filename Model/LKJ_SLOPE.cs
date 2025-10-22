using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class LKJ_SLOPE
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
        /// Desc:起点里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string START_MILEAGE {get;set;}

        /// <summary>
        /// Desc:终点里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string END_MILEAGE {get;set;}

        /// <summary>
        /// Desc:坡度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SLOPE {get;set;}

        /// <summary>
        /// Desc:坡长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SLOPE_LENGTH {get;set;}

        /// <summary>
        /// Desc:长短链——里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LONG_SHORT_CHAIN_MILEAGE {get;set;}

        /// <summary>
        /// Desc:长短链——长度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LONG_SHORT_CHAIN_LENGTH {get;set;}

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
