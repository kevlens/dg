using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class MATERIAL_BDATE_MATERIALNAME
    {
        
        /// <summary>
        /// Desc:材料名称ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string ID {get;set;}

        /// <summary>
        /// Desc:材料名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NAME {get;set;}

        /// <summary>
        /// Desc:材料类型（字典表里材料类型的ID） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MATERIALTYPE_ID {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REMARK {get;set;}

    }
}
