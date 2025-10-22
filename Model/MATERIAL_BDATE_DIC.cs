using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class MATERIAL_BDATE_DIC
    {
        
        /// <summary>
        /// Desc:具体字典字段ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string ID {get;set;}

        /// <summary>
        /// Desc:字典名称ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CATEGORY_ID {get;set;}

        /// <summary>
        /// Desc:字典名称 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CATEGORY_NAME {get;set;}

        /// <summary>
        /// Desc:具体字典字段名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NAME {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOTE {get;set;}

        /// <summary>
        /// Desc:排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? DICORDER {get;set;}

    }
}
