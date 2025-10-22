using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class JOB_PLAN_SAFE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string SAFE_ID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_ID {get;set;}

        /// <summary>
        /// Desc:手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE {get;set;}

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
        public string DIRECTION {get;set;}

        /// <summary>
        /// Desc:里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_FZR {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? TIME_FZR {get;set;}

        /// <summary>
        /// Desc:手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_SAFEA {get;set;}

        /// <summary>
        /// Desc:里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_SAFEA {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? TIME_SAFEA {get;set;}

        /// <summary>
        /// Desc:安全防护距离一(经纬度) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? SAFE_RANGE_ONE {get;set;}

        /// <summary>
        /// Desc:手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_SAFEB {get;set;}

        /// <summary>
        /// Desc:里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_SAFEB {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? TIME_SAFEB {get;set;}

        /// <summary>
        /// Desc:安全防护距离二(经纬度) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? SAFE_RANGE_TWO {get;set;}

        /// <summary>
        /// Desc:安全防护距离一(里程) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? SAFE_RANGE_LC_ONE {get;set;}

        /// <summary>
        /// Desc:安全防护距离二(里程) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? SAFE_RANGE_LC_TWO {get;set;}

        /// <summary>
        /// Desc:工地防护员手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_SAFEGD {get;set;}

        /// <summary>
        /// Desc:工地防护员里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_SAFEGD {get;set;}

        /// <summary>
        /// Desc:工地防护员时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? TIME_SAFEGD {get;set;}

        /// <summary>
        /// Desc:工地防护员安全防护距离一(经纬度) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? SAFE_RANGE_GD {get;set;}

        /// <summary>
        /// Desc:工地防护员安全防护距离一(里程) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? SAFE_RANGE_LC_GD {get;set;}

        /// <summary>
        /// Desc:中间联络手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_SAFEZJ {get;set;}

        /// <summary>
        /// Desc:中间联络里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_SAFEZJ {get;set;}

        /// <summary>
        /// Desc:中间联络时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? TIME_SAFEZJ {get;set;}

        /// <summary>
        /// Desc:中间联络安全防护距离一(经纬度) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? SAFE_RANGE_ZJ {get;set;}

        /// <summary>
        /// Desc:中间联络安全防护距离一(里程) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? SAFE_RANGE_LC_ZJ {get;set;}

    }
}
