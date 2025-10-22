using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_EQU_CLEARANCE_FILE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FILE_ID {get;set;}

        /// <summary>
        /// Desc:限界表主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CLEARANCE_ID {get;set;}

        /// <summary>
        /// Desc:限界资料、CAD限界图 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FILE_CAT {get;set;}

        /// <summary>
        /// Desc:上传日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? FILE_DATE {get;set;}

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

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
