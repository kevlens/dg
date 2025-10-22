using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_GATEMNG_INOUTHIS
    {
        
        /// <summary>
        /// Desc:卡号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CARD_NO {get;set;}

        /// <summary>
        /// Desc:入库时间 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public DateTime LST_TIME {get;set;}

        /// <summary>
        /// Desc:入库顺序 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LST_ORDER {get;set;}

        /// <summary>
        /// Desc:卡类型0：门禁卡；1：机具卡；2：数人卡 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CARD_TYPE {get;set;}

        /// <summary>
        /// Desc:卡归属段，0：工务段；1：电务段；2：通讯段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CARD_SECTION {get;set;}

        /// <summary>
        /// Desc:入门门号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INGATE_NO {get;set;}

        /// <summary>
        /// Desc:入门时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? INGATE_TIME {get;set;}

        /// <summary>
        /// Desc:出门门号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OUTGATE_NO {get;set;}

        /// <summary>
        /// Desc:出门时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? OUTGATE_TIME {get;set;}

        /// <summary>
        /// Desc:人员姓名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GNAME {get;set;}

        /// <summary>
        /// Desc:人员手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GMOBILE {get;set;}

        /// <summary>
        /// Desc:人员部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GDEPTNAME {get;set;}

    }
}
