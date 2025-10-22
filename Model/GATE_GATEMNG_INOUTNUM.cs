using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_GATEMNG_INOUTNUM
    {
        
        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:作业门手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATE_NO {get;set;}

        /// <summary>
        /// Desc:出入类型0：进，1：出 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INOUT_FLAG {get;set;}

        /// <summary>
        /// Desc:人员或机具0-人员 1-机具 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INOUT_TYPE {get;set;}

        /// <summary>
        /// Desc:出入数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? INOUT_NUM {get;set;}

        /// <summary>
        /// Desc:出入开门时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? INOUT_TIME {get;set;}

        /// <summary>
        /// Desc:5AA5未解析纪录 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INOUT_LOG {get;set;}

        /// <summary>
        /// Desc:卡号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CARD_NO {get;set;}

    }
}
