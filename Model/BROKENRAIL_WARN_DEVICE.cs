using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BROKENRAIL_WARN_DEVICE
    {
        
        /// <summary>
        /// Desc:报警器手机号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DEVICE_PHONE {get;set;}

        /// <summary>
        /// Desc:对应区间ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SECTION_ID {get;set;}

        /// <summary>
        /// Desc:断轨类型（声波，载波，半闭塞） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPE {get;set;}

        /// <summary>
        /// Desc:管界起始里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? BOUNDARY_START {get;set;}

        /// <summary>
        /// Desc:管界结束里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? BOUNDARY_END {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:是否启用 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string IS_ENABLE {get;set;}

    }
}
