using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class SCRIPTS_SECTION_LINE
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
        public Double? 经度 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? 纬度 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? 火星经度 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? 火星纬度 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? 百度经度 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? 百度纬度 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPEINFO_ID {get;set;}

        /// <summary>
        /// Desc:防洪点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPEFLOOD_ID {get;set;}

        /// <summary>
        /// Desc:道口 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPECROSS_ID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE {get;set;}

    }
}
