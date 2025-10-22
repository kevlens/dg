using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_PARA_MAINTENAN
    {
        
        /// <summary>
        /// Desc:项目类别 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string ITEM_TYPE {get;set;}

        /// <summary>
        /// Desc:项目代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string ITEM_CODE {get;set;}

        /// <summary>
        /// Desc:项目名称 
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
        /// Desc:扣分 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public byte ITEM_SCORE {get;set;}

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
