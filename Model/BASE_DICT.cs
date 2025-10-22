using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BASE_DICT
    {
        
        /// <summary>
        /// Desc:父编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_P_ID {get;set;}

        /// <summary>
        /// Desc:父名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_P_NAME {get;set;}

        /// <summary>
        /// Desc:字典编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_DICT_ID {get;set;}

        /// <summary>
        /// Desc:字典值 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_DICT_VALUE {get;set;}

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
        public Byte? N_ORDER {get;set;}

        /// <summary>
        /// Desc:是否叶子 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_EFF_LEAF {get;set;}

    }
}
