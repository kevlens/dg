using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_PARA_DYN_SCORE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CHECK_TYPE {get;set;}

        /// <summary>
        /// Desc:项目 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_ITEM {get;set;}

        /// <summary>
        /// Desc:级别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool N_LEVEL {get;set;}

        /// <summary>
        /// Desc:重复 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool N_REPEAT {get;set;}

        /// <summary>
        /// Desc:扣分 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public short N_SCORE {get;set;}

        /// <summary>
        /// Desc:无缝线路(Y、N) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_JOINTLESS {get;set;}

        /// <summary>
        /// Desc:速度下限 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public short N_MAX_SPEED {get;set;}

        /// <summary>
        /// Desc:速度上限 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public short N_MIN_SPEED {get;set;}

        /// <summary>
        /// Desc:- 
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

        /// <summary>
        /// Desc:速度等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool N_SPEED_LEVEL {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_EFF_FLAG {get;set;}

    }
}
