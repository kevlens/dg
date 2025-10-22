using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BROKENRAIL_SOUND_SENDPHONE
    {
        
        /// <summary>
        /// Desc:发送端手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SENDER_PHONE {get;set;}

        /// <summary>
        /// Desc:发送端位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SENDER_POS {get;set;}

        /// <summary>
        /// Desc:对应主机手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HOST_PHONE {get;set;}

        /// <summary>
        /// Desc:发送端手机号数据接收时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? SENDER_RECETIME {get;set;}

        /// <summary>
        /// Desc:最后一次发送命令时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? LAST_SENDTIME {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:发送端手机号编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SENDER_PHONE_NUM {get;set;}

    }
}
