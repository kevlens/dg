using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class TURNOUT_PART
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PART_ID {get;set;}

        /// <summary>
        /// Desc:道岔编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUT_ID {get;set;}

        /// <summary>
        /// Desc:部件名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PART_NAME {get;set;}

        /// <summary>
        /// Desc:上线时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? PART_DATE {get;set;}

        /// <summary>
        /// Desc:单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PART_UNIT {get;set;}

        /// <summary>
        /// Desc:厂家 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PART_FAC {get;set;}

        /// <summary>
        /// Desc:负责人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PART_CHARGER {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PART_NOTE {get;set;}

        /// <summary>
        /// Desc:型号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PART_MODEL {get;set;}

    }
}
