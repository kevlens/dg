using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_SERVER_TEMP
    {
        
        /// <summary>
        /// Desc:作业门手机号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string GATE_NO {get;set;}

        /// <summary>
        /// Desc:出入类型0：进，1：出 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string INOUT_FLAG {get;set;}

        /// <summary>
        /// Desc:人员或机具0-人员 1-机具 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string INOUT_TYPE {get;set;}

        /// <summary>
        /// Desc:出入数量 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int INOUT_NUM {get;set;}

        /// <summary>
        /// Desc:出入开门时间 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public DateTime INOUT_TIME {get;set;}

        /// <summary>
        /// Desc:卡号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CARD_NO {get;set;}

    }
}
