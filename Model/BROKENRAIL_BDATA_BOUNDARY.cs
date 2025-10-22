using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model
{
    public class BROKENRAIL_BDATA_BOUNDARY
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        [Key]
        public string PKID {get;set;}

        /// <summary>
        /// Desc:线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE {get;set;}

        /// <summary>
        /// Desc:小里程所属部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SMALL_DEPT {get;set;}

        /// <summary>
        /// Desc:大里程所属部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BIG_DEPT {get;set;}

    }
}
