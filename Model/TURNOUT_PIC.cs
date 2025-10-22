using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class TURNOUT_PIC
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PIC_ID {get;set;}

        /// <summary>
        /// Desc:道岔编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string TURNOUT_ID {get;set;}

        /// <summary>
        /// Desc:文件名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FILE_NAME {get;set;}

        /// <summary>
        /// Desc:链接地址 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FILE_URL {get;set;}

        /// <summary>
        /// Desc:拍摄日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? FILE_UPTIME {get;set;}

        /// <summary>
        /// Desc:图片描述 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FILE_NOTE {get;set;}

    }
}
