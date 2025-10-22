using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIN_SECTION_LINE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string RAIN_SECTION_ID {get;set;}

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
        public decimal? MILEAGE {get;set;}

        /// <summary>
        /// Desc:线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 区段 {get;set;}

        /// <summary>
        /// Desc:编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 监测点 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 路局 {get;set;}

        /// <summary>
        /// Desc:小里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? 起始里程 {get;set;}

        /// <summary>
        /// Desc:大里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? 结束里程 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 执行车间 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 执行工区 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 工区编码 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? 工区中心里程 {get;set;}

        /// <summary>
        /// Desc:出巡小里程方向手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 出巡小里程方向手机号 {get;set;}

        /// <summary>
        /// Desc:出巡大里程方向手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 出巡大里程方向手机号 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 行别 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? 区段编号 {get;set;}

    }
}
