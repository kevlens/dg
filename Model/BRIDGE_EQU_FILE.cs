using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_EQU_FILE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string EQU_ID {get;set;}

        /// <summary>
        /// Desc:设备类别（桥梁、隧道、涵渠、地道、灰坑、天桥、跨线桥、上跨立交桥、其它） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string EQU_CAT {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LINE_CODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public Double CENTER_MILE {get;set;}

        /// <summary>
        /// Desc:设备号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EQU_CODE {get;set;}

        /// <summary>
        /// Desc:检定报告、照片 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FILE_CAT {get;set;}

        /// <summary>
        /// Desc:日期 
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

    }
}
