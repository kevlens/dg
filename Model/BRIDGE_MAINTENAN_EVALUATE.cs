using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_MAINTENAN_EVALUATE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string EVALUATE_ID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GWD_CODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_CODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_CODE {get;set;}

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
        /// Desc:设备类别（桥梁、隧道、涵渠、地道、灰坑、天桥、跨线桥、上跨立交桥、其它） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string EQU_CAT {get;set;}

        /// <summary>
        /// Desc:中心里程 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public Double CENTER_MILE {get;set;}

        /// <summary>
        /// Desc:设备编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EQU_CODE {get;set;}

        /// <summary>
        /// Desc:设备名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EQU_NAME {get;set;}

        /// <summary>
        /// Desc:维修长度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? MAINTAINCE_LENGTH {get;set;}

        /// <summary>
        /// Desc:评定日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? EVALUATE_DATE {get;set;}

        /// <summary>
        /// Desc:平均扣分 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public double AVG_SCORE {get;set;}

        /// <summary>
        /// Desc:评定结果（0：合格；1：失格） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool EVALUATE_RES {get;set;}

        /// <summary>
        /// Desc:超限问题 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OVERRUN_PRO {get;set;}

        /// <summary>
        /// Desc:评定结果（0：合格；1：失格） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool PRE_EVALUATE_RES {get;set;}

        /// <summary>
        /// Desc:保养通知书 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOTICE_ID {get;set;}

        /// <summary>
        /// Desc:保养通知书是否下发（0：未下发；1：下发） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool NOTICE_IS_SEND {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
