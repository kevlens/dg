using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_TQI_PARA
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:TQI管理值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single TQIVALUE {get;set;}

        /// <summary>
        /// Desc:超过10% 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single TQIVALTEN {get;set;}

        /// <summary>
        /// Desc:超过20% 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single TQIVALTWENTY {get;set;}

        /// <summary>
        /// Desc:速度等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string N_SPEED_LEVEL {get;set;}

        /// <summary>
        /// Desc:优先作业 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single TQIVALTHIRTY {get;set;}

    }
}
