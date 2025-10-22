using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_GATEMNG_CARDLIST
    {
        
        /// <summary>
        /// Desc:记录ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LIST_ID {get;set;}

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
        /// Desc:卡归属段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CARD_SECTION {get;set;}

        /// <summary>
        /// Desc:记录时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? LIST_DATE {get;set;}

        /// <summary>
        /// Desc:操作用户 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OP_USER {get;set;}

        /// <summary>
        /// Desc:操作时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? OP_TIME {get;set;}

        /// <summary>
        /// Desc:操作类型(1:新增,2:删除) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? OP_TYPE {get;set;}

        /// <summary>
        /// Desc:操作结果(0:失败，1:成功) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OP_RESULT {get;set;}

    }
}
