using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_PARA_PLACE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:位置代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CODE {get;set;}

        /// <summary>
        /// Desc:位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PLACE {get;set;}

        /// <summary>
        /// Desc:道岔类型,多个以 逗号分隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TYPE {get;set;}

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
