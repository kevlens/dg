using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_PARA_PRO_CTRL
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:动作[操作] (0：无动作；1：人工消号问题[自动入实际问题库]) 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int ACTION {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CHECK_TYPE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CHECK_DEV {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRO_ITEM {get;set;}

        /// <summary>
        /// Desc:超限等级（0,1,2,3,4）。0表示不超限（动态问题：1,2,3,4级超限；静态问题：作业验收、经常保养、临时修补） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool OVERRUN_LEVEL {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

        /// <summary>
        /// Desc:问题类型代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRO_CODE {get;set;}

    }
}
