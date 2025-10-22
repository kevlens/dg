using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_PARA_PRO_TYPE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CHECK_TYPE {get;set;}

        /// <summary>
        /// Desc:标识类型（线路、轨道、道岔） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_CAT {get;set;}

        /// <summary>
        /// Desc:项目 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_ITEM {get;set;}

        /// <summary>
        /// Desc:病害名称 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_TYPE {get;set;}

        /// <summary>
        /// Desc:病害代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_TYPE_CODE {get;set;}

        /// <summary>
        /// Desc:度量单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_UNIT {get;set;}

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
