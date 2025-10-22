using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_STATE_REPORT
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string REPORT_ID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string GWD_CODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CJ_CODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string GQ_CODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_CODE {get;set;}

        /// <summary>
        /// Desc:设备类别（桥梁、隧道、涵渠） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string EQU_CAT {get;set;}

        /// <summary>
        /// Desc:统计年份（yyyy） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string REPORT_DATE {get;set;}

        /// <summary>
        /// Desc:设备数 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int EQU_TOTAL {get;set;}

        /// <summary>
        /// Desc:B级及以上 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int LEV_OVER_B {get;set;}

        /// <summary>
        /// Desc:AA级劣化
 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int LEV_AA {get;set;}

        /// <summary>
        /// Desc:A1级劣化
 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int LEV_A1 {get;set;}

        /// <summary>
        /// Desc:C级劣化
 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? LEV_C {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

        /// <summary>
        /// Desc:B级劣化
 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int LEV_B {get;set;}

    }
}
