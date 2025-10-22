using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class HRAIL_PARA_PROITEM
    {
        
        /// <summary>
        /// Desc:检查类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_TYPE {get;set;}

        /// <summary>
        /// Desc:项目（问题）类别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM_CAT {get;set;}

        /// <summary>
        /// Desc:项目（问题）类型 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string ITEM_TYPE {get;set;}

        /// <summary>
        /// Desc:项目（问题）代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string ITEM_CODE {get;set;}

        /// <summary>
        /// Desc:项目（问题）名称 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string ITEM_NAME {get;set;}

        /// <summary>
        /// Desc:项目（问题）单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM_UNIT {get;set;}

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
