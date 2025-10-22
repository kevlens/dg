using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIN_FLOOD_STOCK_PHOTO
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PHOTO_ID {get;set;}

        /// <summary>
        /// Desc:防洪备料外键 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FLOODSTOCK_ID {get;set;}

        /// <summary>
        /// Desc:图片地址 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHOTOURL {get;set;}

        /// <summary>
        /// Desc:小图片地址 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SMALLURL {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEMO {get;set;}

    }
}
