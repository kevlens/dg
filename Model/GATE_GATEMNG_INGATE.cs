using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_GATEMNG_INGATE
    {
        
        /// <summary>
        /// Desc:门号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATE_NO {get;set;}

        /// <summary>
        /// Desc:卡号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CARD_NO {get;set;}

        /// <summary>
        /// Desc:出入记录时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? INOUT_TIME {get;set;}

        /// <summary>
        /// Desc:纪录类型（0：正常，可以开门，1：不在时间段内，2：未找到卡号） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INOUT_STATE {get;set;}

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

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INOUT_ORDER {get;set;}

        /// <summary>
        /// Desc:0进,1出 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INOROUT {get;set;}

        /// <summary>
        /// Desc:出门门号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATE_NO_OUT {get;set;}

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
        /// Desc:进门时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? IN_TIME {get;set;}

        /// <summary>
        /// Desc:出门时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? OUT_TIME {get;set;}

        /// <summary>
        /// Desc:绑定人所在段级部门编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DDEPT_CODE {get;set;}

        /// <summary>
        /// Desc:绑定人所在段级部门名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DDEPT_NAME {get;set;}

    }
}
