using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_MAINTENAN_PRO
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PRO_ID {get;set;}

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
        /// Desc:检查日期 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public DateTime CHECK_DATE {get;set;}

        /// <summary>
        /// Desc:检查部门代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_DEP_CODE {get;set;}

        /// <summary>
        /// Desc:检查部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_DEP_NAME {get;set;}

        /// <summary>
        /// Desc:检查人（多个以逗号分隔） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_MAN {get;set;}

        /// <summary>
        /// Desc:项目类别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM_TYPE {get;set;}

        /// <summary>
        /// Desc:具体问题代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string ITEM_CODE {get;set;}

        /// <summary>
        /// Desc:具体问题 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM_NAME {get;set;}

        /// <summary>
        /// Desc:具体位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRO_PLACE {get;set;}

        /// <summary>
        /// Desc:单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM_UNIT {get;set;}

        /// <summary>
        /// Desc:扣分标准 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Byte? ITEM_SCORE {get;set;}

        /// <summary>
        /// Desc:（检查）问题数量 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public byte CHECK_PRO_NUM {get;set;}

        /// <summary>
        /// Desc:（销号）问题数量 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public byte CLEAR_PRO_NUM {get;set;}

        /// <summary>
        /// Desc:（现存）问题数量 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public byte EXIST_PRO_NUM {get;set;}

        /// <summary>
        /// Desc:销号负责人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLEAR_PRO_LEADER {get;set;}

        /// <summary>
        /// Desc:销号日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CLEAR_PRO_DATE {get;set;}

        /// <summary>
        /// Desc:现场复查人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECHECK_MAN {get;set;}

        /// <summary>
        /// Desc:复查日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RECHECK_DATE {get;set;}

        /// <summary>
        /// Desc:复查结果 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECHECK_RES {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

        /// <summary>
        /// Desc:问题状态（0：默认；1：销记） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? PRO_STATUS {get;set;}

        /// <summary>
        /// Desc:问题说明 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRO_DESC {get;set;}

        /// <summary>
        /// Desc:创建日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CRT_TM {get;set;}

        /// <summary>
        /// Desc:创建人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CRT_NAME {get;set;}

    }
}
