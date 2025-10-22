using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIL_SECTION_LINE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string SECTION_ID {get;set;}

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
        /// Desc:定标器编号（手机号_序号） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POINT_NO {get;set;}

        /// <summary>
        /// Desc:主机编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HOST_NO {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE {get;set;}

        /// <summary>
        /// Desc:声波断轨定标器编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SOUNDPOINT_NO {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CARRIERPOINT_NO {get;set;}

    }
}
