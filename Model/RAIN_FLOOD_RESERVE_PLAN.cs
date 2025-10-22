using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIN_FLOOD_RESERVE_PLAN
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string RESERVEPLAN_ID {get;set;}

        /// <summary>
        /// Desc:工务段代码(用户所属工务段) 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string GWD_CODE {get;set;}

        /// <summary>
        /// Desc:部门代码（车间） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEP_CODE {get;set;}

        /// <summary>
        /// Desc:工区代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_CODE {get;set;}

        /// <summary>
        /// Desc:线编号 
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
        /// Desc:上传时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? UPLOAD_DATE {get;set;}

        /// <summary>
        /// Desc:文档上传地址 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORD_URL {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEMO {get;set;}

        /// <summary>
        /// Desc:文档标题 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORD_TITLE {get;set;}

    }
}
