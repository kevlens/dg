using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_MAINTENAN_NOTICE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string NOTICE_ID {get;set;}

        /// <summary>
        /// Desc:工务段代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string GWD_CODE {get;set;}

        /// <summary>
        /// Desc:车间代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_CODE {get;set;}

        /// <summary>
        /// Desc:维修工区代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_CODE {get;set;}

        /// <summary>
        /// Desc:检查工区代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_GQ_CODE {get;set;}

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
        /// Desc:设备类别（桥梁、隧道、涵渠、地道、灰坑、天桥、跨线桥、上跨立交桥、其它） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string EQU_CAT {get;set;}

        /// <summary>
        /// Desc:设备号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EQU_CODE {get;set;}

        /// <summary>
        /// Desc:检查日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CHECK_DATE {get;set;}

        /// <summary>
        /// Desc:要求处理日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? ACCESS_DATE {get;set;}

        /// <summary>
        /// Desc:评定日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? EVALUATE_DATE {get;set;}

        /// <summary>
        /// Desc:签发部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ISSUE_DEPT {get;set;}

        /// <summary>
        /// Desc:签发时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? ISSUE_DATE {get;set;}

        /// <summary>
        /// Desc:状态（0：默认；1：生成；3：下发；7：签收；15：归档） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? NOTICE_STATUS {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

        /// <summary>
        /// Desc:签发人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ISSUER {get;set;}

        /// <summary>
        /// Desc:设备名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EQU_NAME {get;set;}

        /// <summary>
        /// Desc:实际处理日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? ACTUAL_PROC_DATE {get;set;}

    }
}
