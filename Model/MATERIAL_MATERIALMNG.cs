using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class MATERIAL_MATERIALMNG
    {
        
        /// <summary>
        /// Desc:材料编码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string MATERIALID {get;set;}

        /// <summary>
        /// Desc:电子标签ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ID {get;set;}

        /// <summary>
        /// Desc:材料名称(材料名称表的ID) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NAME {get;set;}

        /// <summary>
        /// Desc:材料类别(材料类型表的ID) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPE_ID {get;set;}

        /// <summary>
        /// Desc:材料型号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MARKER {get;set;}

        /// <summary>
        /// Desc:单个数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? SINGELNUMBER {get;set;}

        /// <summary>
        /// Desc:单个单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SINGELPIECES {get;set;}

        /// <summary>
        /// Desc:单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PIECES {get;set;}

        /// <summary>
        /// Desc:存放位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STORAGELOCATION {get;set;}

        /// <summary>
        /// Desc:生产厂家 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MFRS {get;set;}

        /// <summary>
        /// Desc:所属部门（部门表的ID） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DEP_ID {get;set;}

        /// <summary>
        /// Desc:删除标志（0：正常；1：逻辑删除；2：无效数据） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? DELFLAG {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REMARK {get;set;}

        /// <summary>
        /// Desc:数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? QUANTITY {get;set;}

    }
}
