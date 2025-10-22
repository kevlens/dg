using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_MOBILEFILE
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
        /// Nullable:False 
        /// </summary>
        public string 手机号 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public DateTime 时间 {get;set;}

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
        public Double? 经度 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 文件名 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 线名 {get;set;}

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
        public Double? 里程 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? 已提示 {get;set;}

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
        public Double? 火星经度 {get;set;}

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
        public Double? 百度经度 {get;set;}

        /// <summary>
        /// Desc:0：图片 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? 文件类型 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 下载地址 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 是否原图 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 描述 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NAME {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 上道状态 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? 拍摄时间 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? 入库时间 {get;set;}

        /// <summary>
        /// Desc:电子标签号（广州房建巡检模块用） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string E_LABLE_NO {get;set;}

        /// <summary>
        /// Desc:标签号（广州房建巡检模块用） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LABLE_NO {get;set;}

        /// <summary>
        /// Desc:计划ID（武汉计划用） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_ID {get;set;}

        /// <summary>
        /// Desc:监控顺序（武汉计划用） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? STEP_ID {get;set;}

        /// <summary>
        /// Desc:文件名（图片关联语音） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FILE_NAME {get;set;}

    }
}
