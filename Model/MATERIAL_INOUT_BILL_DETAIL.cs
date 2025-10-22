using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class MATERIAL_INOUT_BILL_DETAIL
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:单据号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string BILL_NUM {get;set;}

        /// <summary>
        /// Desc:材料分类 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPE {get;set;}

        /// <summary>
        /// Desc:材料名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NAME {get;set;}

        /// <summary>
        /// Desc:材料型号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MODEL {get;set;}

        /// <summary>
        /// Desc:材料编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MATERIAL_NO {get;set;}

        /// <summary>
        /// Desc:电子标签 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LABEL {get;set;}

        /// <summary>
        /// Desc:单个数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? SINGLE_NUM {get;set;}

        /// <summary>
        /// Desc:单个单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SINGLE_UNIT {get;set;}

        /// <summary>
        /// Desc:数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? NUM {get;set;}

        /// <summary>
        /// Desc:单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UNIT {get;set;}

        /// <summary>
        /// Desc:小计 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? SUB_TOTAL {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOTE {get;set;}

        /// <summary>
        /// Desc:所属部门（部门表的ID） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DEPID {get;set;}

    }
}
