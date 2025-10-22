using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class CAR_PHONE_INFO
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:CAR_BDATA_CAR 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CAR_LICENSENO {get;set;}

        /// <summary>
        /// Desc:电话号码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE {get;set;}

        /// <summary>
        /// Desc:是否为定位手机（0：不是，1：是） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? IS_POSTTION {get;set;}

    }
}
