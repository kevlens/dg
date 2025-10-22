using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_GATEMNG_STATE
    {
        
        /// <summary>
        /// Desc:门禁状态id 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string STATE_ID {get;set;}

        /// <summary>
        /// Desc:门号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATE_NO {get;set;}

        /// <summary>
        /// Desc:状态（0：关 1 ：开） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATE_FLAG {get;set;}

        /// <summary>
        /// Desc:时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? STATE_TIME {get;set;}

        /// <summary>
        /// Desc:门磁状态（0：关 1：开） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATEMAGNETS_FLAG {get;set;}

        /// <summary>
        /// Desc:门锁状态 （0：关 1：开） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATELOCK_FLAG {get;set;}

        /// <summary>
        /// Desc:读卡器状态 （0：正常 1：异常） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string READCARD_FLAG {get;set;}

        /// <summary>
        /// Desc:电源方式，电池或者AC 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POWERTYPE {get;set;}

        /// <summary>
        /// Desc:电源电压，电池电压或者AC电压 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? POWERV {get;set;}

        /// <summary>
        /// Desc:5AA5未解析纪录 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATE_LOG {get;set;}

        /// <summary>
        /// Desc:序号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATE_ORDER {get;set;}

        /// <summary>
        /// Desc:密码锁状态（0：正常 1：异常） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CODELOCK_FLAG {get;set;}

        /// <summary>
        /// Desc:可用密码组数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CODELOCK_ENABLENUM {get;set;}

        /// <summary>
        /// Desc:密码锁电量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? CODELOCK_POWERV {get;set;}

        /// <summary>
        /// Desc:开门类型(1-刷卡开门 2-远程开门 3-钥匙开门 4-异常开门 5-内侧开门0-门状态为关) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OPENGATE_TYPE {get;set;}

        /// <summary>
        /// Desc:卡号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CARD_NO {get;set;}

        /// <summary>
        /// Desc:远程开门命令号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COMMAND_NO {get;set;}

        /// <summary>
        /// Desc:电池电压 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? BATTERY_VOLTAGE {get;set;}

        /// <summary>
        /// Desc:AC电压 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? AC_VOLTAGE {get;set;}

    }
}
