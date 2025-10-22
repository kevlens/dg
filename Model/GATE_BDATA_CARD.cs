using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_BDATA_CARD
    {
        
        /// <summary>
        /// Desc:卡编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CARD_NO {get;set;}

        /// <summary>
        /// Desc:持卡人ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMBER_ID {get;set;}

        /// <summary>
        /// Desc:所属部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:卡片标志（0-未废弃未绑 1未废弃已绑 3已废弃） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CARD_STATE {get;set;}

        /// <summary>
        /// Desc:卡新增时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CARD_INDATE {get;set;}

        /// <summary>
        /// Desc:卡废弃时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CARD_DELDATE {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CARD_NOTE {get;set;}

        /// <summary>
        /// Desc:0：门禁卡；1：机具卡；2：数人卡 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CARD_TYPE {get;set;}

        /// <summary>
        /// Desc:机具ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TOOL_ID {get;set;}

        /// <summary>
        /// Desc:卡归属段，0：工务段；1：电务段；2：通讯段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CARD_SECTION {get;set;}

    }
}
