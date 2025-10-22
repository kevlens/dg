using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_STATE_PRO
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
        /// Desc:检查日期 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public DateTime CHECK_DATE {get;set;}

        /// <summary>
        /// Desc:检查部门代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CHECK_DEP_CODE {get;set;}

        /// <summary>
        /// Desc:检查部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_DEP_NAME {get;set;}

        /// <summary>
        /// Desc:检查人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_MAN {get;set;}

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
        /// Desc:运营状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RUN_STATUS {get;set;}

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
        /// Desc:孔跨式样 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HOLESPAN_STYLE {get;set;}

        /// <summary>
        /// Desc:劣化类别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM_CAT {get;set;}

        /// <summary>
        /// Desc:劣化条目 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM_SUBCAT {get;set;}

        /// <summary>
        /// Desc:劣化类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM_TYPE {get;set;}

        /// <summary>
        /// Desc:（劣化）项目代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string ITEM_CODE {get;set;}

        /// <summary>
        /// Desc:（劣化）项目名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM_NAME {get;set;}

        /// <summary>
        /// Desc:单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM_UNIT {get;set;}

        /// <summary>
        /// Desc:劣化等级（0：默认；1：C；2：B；3：A1；4：AA） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool ITEM_LEVEL {get;set;}

        /// <summary>
        /// Desc:孔别（多个以逗号分隔） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HOLE_NO {get;set;}

        /// <summary>
        /// Desc:数量 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public byte PRO_NUM {get;set;}

        /// <summary>
        /// Desc:劣化说明 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRO_DESC {get;set;}

        /// <summary>
        /// Desc:评定部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EVALUATE_DEPT {get;set;}

        /// <summary>
        /// Desc:评定人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EVALUATE_MAN {get;set;}

        /// <summary>
        /// Desc:销号日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CLEAR_PRO_DATE {get;set;}

        /// <summary>
        /// Desc:销号人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLEAR_PRO_MAN {get;set;}

        /// <summary>
        /// Desc:销号方式（大修、维修、防洪、技改、其他） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLEAR_PRO_TYPE {get;set;}

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

        /// <summary>
        /// Desc:标志（既有、新增）默认值为既有 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FLAG {get;set;}

    }
}
