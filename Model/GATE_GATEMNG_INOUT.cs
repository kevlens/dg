using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_GATEMNG_INOUT
    {
        
        /// <summary>
        /// Desc:门禁出入记录id 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string INOUT_ID {get;set;}

        /// <summary>
        /// Desc:门号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATE_NO {get;set;}

        /// <summary>
        /// Desc:卡号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CARD_NO {get;set;}

        /// <summary>
        /// Desc:出入记录时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? INOUT_TIME {get;set;}

        /// <summary>
        /// Desc:出入标志（0：入，1：出）读卡器门号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INOUT_FLAG {get;set;}

        /// <summary>
        /// Desc:刷卡标志    0-正常 1-开门刷卡记录 2-进出门刷卡记录 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string READCARD_FLAG {get;set;}

        /// <summary>
        /// Desc:纪录类型（0：正常，可以开门，1：不在时间段内，2：未找到卡号,3：手动清除人数） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INOUT_STATE {get;set;}

        /// <summary>
        /// Desc:5AA5未解析纪录 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INOUT_LOG {get;set;}

        /// <summary>
        /// Desc:序号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INOUT_ORDER {get;set;}

    }
}
