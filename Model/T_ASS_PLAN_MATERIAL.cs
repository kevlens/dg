using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_PLAN_MATERIAL
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:计划编号（对应各计划表里的PLAN_ID） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_ID {get;set;}

        /// <summary>
        /// Desc:流程ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FLOWID {get;set;}

        /// <summary>
        /// Desc:作业地点表PKID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LOC_PKID {get;set;}

        /// <summary>
        /// Desc:材料编号（对应材料表里的PKID） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MATERIAL_ID {get;set;}

        /// <summary>
        /// Desc:材料数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? QUANTUM {get;set;}

    }
}
