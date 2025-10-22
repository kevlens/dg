using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class MATERIAL_INOUT_BILL
    {
        
        /// <summary>
        /// Desc:单据编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string BILL_NUM {get;set;}

        /// <summary>
        /// Desc:单据日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? BILL_DATE {get;set;}

        /// <summary>
        /// Desc:领料人/采购员 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OPERATOR {get;set;}

        /// <summary>
        /// Desc:部门代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOTE {get;set;}

        /// <summary>
        /// Desc:单据类型（0入库，1出库） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BILL_TYPE {get;set;}

    }
}
