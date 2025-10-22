using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_GATEMNG_LONGDISHISTORY
    {
        
        /// <summary>
        /// Desc:远程开门主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string AUTHHISTORY_ID {get;set;}

        /// <summary>
        /// Desc:门编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATE_NO {get;set;}

        /// <summary>
        /// Desc:远程开门用户 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AUTHOPT_USER {get;set;}

        /// <summary>
        /// Desc:远程开门操作时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? AUTHOPT_TIME {get;set;}

        /// <summary>
        /// Desc:远程开门结果(0：成功 1：失败) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AUTHOPT_RESULT {get;set;}

        /// <summary>
        /// Desc:远程开门命令号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COMMAND_NO {get;set;}

        /// <summary>
        /// Desc:开门原因 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OPEN_REASON {get;set;}

    }
}
