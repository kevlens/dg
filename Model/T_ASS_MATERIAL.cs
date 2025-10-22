using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_MATERIAL
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:材料名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MATERIALNAME {get;set;}

        /// <summary>
        /// Desc:材料类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MATERIAL_TYPE {get;set;}

        /// <summary>
        /// Desc:材料计量单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MATERIAL_UNIT {get;set;}

        /// <summary>
        /// Desc:风险提示 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_SAFETYRISKTIPS {get;set;}

        /// <summary>
        /// Desc:是否有效 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_EFF_FLAG {get;set;}

        /// <summary>
        /// Desc:排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_ORDER {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

    }
}
