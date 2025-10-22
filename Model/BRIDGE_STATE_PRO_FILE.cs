using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_STATE_PRO_FILE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PRO_FILE_ID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PRO_ID {get;set;}

        /// <summary>
        /// Desc:类别（病害照片；......） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FILE_CAT {get;set;}

        /// <summary>
        /// Desc:文件名 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FILE_NAME {get;set;}

        /// <summary>
        /// Desc:文件说明 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FILE_DESC {get;set;}

        /// <summary>
        /// Desc:创建时间 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public DateTime CRT_TIME {get;set;}

    }
}
