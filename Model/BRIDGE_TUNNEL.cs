using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_TUNNEL
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string TUNNEL_ID {get;set;}

        /// <summary>
        /// Desc:工务段代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GWD_CODE {get;set;}

        /// <summary>
        /// Desc:车间代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_CODE {get;set;}

        /// <summary>
        /// Desc:工区代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_CODE {get;set;}

        /// <summary>
        /// Desc:线号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LINE_CODE {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:中心里程 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public Double CENTER_MILE {get;set;}

        /// <summary>
        /// Desc:遂道号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string TUNNEL_CODE {get;set;}

        /// <summary>
        /// Desc:遂道名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TUNNEL_NAME {get;set;}

        /// <summary>
        /// Desc:全长 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public double FULL_LENGTH {get;set;}

        /// <summary>
        /// Desc:维修长度 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public double MAINTAINCE_LENGTH {get;set;}

        /// <summary>
        /// Desc:运营状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RUN_STATUS {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
