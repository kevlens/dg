using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class SCRIPT_SECTION_BRIDGETUNNEL
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
        public string LINE_NAME {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COMMENTS {get;set;}

        /// <summary>
        /// Desc:0桥梁,1隧道 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? TYPE {get;set;}

        /// <summary>
        /// Desc:长度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? LENGTH {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? MARSLONGITUDE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? MARSLATITUDE {get;set;}

    }
}
