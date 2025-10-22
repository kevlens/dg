using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_COMBINEDRAW
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:单位编码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_DEP_CODE {get;set;}

        /// <summary>
        /// Desc:线编码 
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
        /// Desc:文件格式/文件扩展名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_FILE_FORMAT {get;set;}

        /// <summary>
        /// Desc:文件名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_FILE_NAME {get;set;}

        /// <summary>
        /// Desc:文件路径 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_FILE_PATH {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

        /// <summary>
        /// Desc:是否有效(Y/N) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_EFF_FLAG {get;set;}

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

    }
}
