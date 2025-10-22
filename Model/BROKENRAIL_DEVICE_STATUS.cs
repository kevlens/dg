using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model
{
    public class BROKENRAIL_DEVICE_STATUS
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        
        public string PKID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        [Key]
        public string POINT_NO {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POINT_STATUS {get;set;}

        /// <summary>
        /// Desc:1显示给客户 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string IS_SHOW {get;set;}

        /// <summary>
        /// Desc:客户看 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RECORD_TIME {get;set;}

        /// <summary>
        /// Desc:公司看 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RECORD_TIME2 {get;set;}

    }
}
