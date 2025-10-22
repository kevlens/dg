using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_SEND_MSG
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int ID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 手机号 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 内容 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? 类型 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? 时间 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? 次数 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 方式 {get;set;}

        /// <summary>
        /// Desc:1：授权开门，2：远程开门，3：索要门禁状态，4：索要白名单，5：白名单增减 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? 记录类型 {get;set;}

        /// <summary>
        /// Desc:相关记录ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 记录ID {get;set;}

    }
}
