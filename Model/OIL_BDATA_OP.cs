using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class OIL_BDATA_OP
    {
        
        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string OP_ID {get;set;}

        /// <summary>
        /// Desc:操作人名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OP_NAME {get;set;}

        /// <summary>
        /// Desc:操作人自填所属部门名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OP_DEPTNAME {get;set;}

        /// <summary>
        /// Desc:操作人备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OP_MEMO {get;set;}

        /// <summary>
        /// Desc:操作人编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string OP_NO {get;set;}

    }
}
