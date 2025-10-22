using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RESCUE_LINE_PHOTO
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PHOTO_ID {get;set;}

        /// <summary>
        /// Desc:外键 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RESCUE_ID {get;set;}

        /// <summary>
        /// Desc:图片地址 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHOTOURL {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SMALLURL {get;set;}

    }
}
