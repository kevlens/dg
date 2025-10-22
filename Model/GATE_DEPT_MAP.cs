using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_DEPT_MAP
    {
        
        /// <summary>
        /// Desc:门与部门关系表 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DEPT_GATE_ID {get;set;}

        /// <summary>
        /// Desc:部门编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:门禁号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATE_NO {get;set;}

    }
}
