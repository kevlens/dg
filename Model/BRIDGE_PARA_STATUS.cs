using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_PARA_STATUS
    {
        
        /// <summary>
        /// Desc:类别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM_CAT {get;set;}

        /// <summary>
        /// Desc:条目 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM_SUBCAT {get;set;}

        /// <summary>
        /// Desc:类型 
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
        /// Nullable:False 
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
        /// Desc:标记 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool FLAG {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
