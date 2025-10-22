using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class CURVE_RAILWEAR
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:钢轨 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int RAIL {get;set;}

        /// <summary>
        /// Desc:磨损类型 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string WEARTYPE {get;set;}

        /// <summary>
        /// Desc:最小速度 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int MINSPEED {get;set;}

        /// <summary>
        /// Desc:最大速度 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int MAXSPEED {get;set;}

        /// <summary>
        /// Desc:磨损值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? WEARVALUE {get;set;}

        /// <summary>
        /// Desc:类型 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string TYPE {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

    }
}
