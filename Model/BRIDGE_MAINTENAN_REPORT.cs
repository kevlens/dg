using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_MAINTENAN_REPORT
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
        /// Desc:设备类别（桥梁、隧道、涵渠、地道、灰坑、天桥、跨线桥、上跨立交桥、其它） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string EQU_CAT {get;set;}

        /// <summary>
        /// Desc:统计年月（yyyy-mm） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string REPORT_DATE {get;set;}

        /// <summary>
        /// Desc:设备总数 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int EQU_TOTAL {get;set;}

        /// <summary>
        /// Desc:扣分设备数 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int EQU_SCORE {get;set;}

        /// <summary>
        /// Desc:合格设备数 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int EQU_PASS {get;set;}

        /// <summary>
        /// Desc:不合格设备数 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int EQU_DISPASS {get;set;}

        /// <summary>
        /// Desc:保养通知书数量 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int NOTICE_NUM {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
