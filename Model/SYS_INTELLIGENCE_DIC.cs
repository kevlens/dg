using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class SYS_INTELLIGENCE_DIC
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DIC_ID {get;set;}

        /// <summary>
        /// Desc:资质名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIC_NAME {get;set;}

        /// <summary>
        /// Desc:图标 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIC_ICON {get;set;}

        /// <summary>
        /// Desc:顺序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? DIC_ORDER {get;set;}

        /// <summary>
        /// Desc:所属部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIC_MEMO {get;set;}

        /// <summary>
        /// Desc:预留 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOTE1 {get;set;}

        /// <summary>
        /// Desc:预留 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOTE2 {get;set;}

    }
}
