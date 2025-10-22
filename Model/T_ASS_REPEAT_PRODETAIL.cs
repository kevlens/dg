using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_REPEAT_PRODETAIL
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:记录PKID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FKID {get;set;}

        /// <summary>
        /// Desc:问题库ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PROBLEM_ID {get;set;}

        /// <summary>
        /// Desc:选中标记 0：未选中 1：选中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool FLAG {get;set;}

    }
}
