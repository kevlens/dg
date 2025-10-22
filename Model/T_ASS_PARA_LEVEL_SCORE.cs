using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_PARA_LEVEL_SCORE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:设备等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool N_LEVEL {get;set;}

        /// <summary>
        /// Desc:说明 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_DESC {get;set;}

        /// <summary>
        /// Desc:最小扣分 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public short N_SCORE_MIN {get;set;}

        /// <summary>
        /// Desc:最大扣分 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public short N_SCORE_MAX {get;set;}

        /// <summary>
        /// Desc:类型（0:普速；1：客专、高铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool N_TYPE {get;set;}

        /// <summary>
        /// Desc:类别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CAT {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_ORDER {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_EFF_FLAG {get;set;}

    }
}
