using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIN_DEVICE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 路局 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 监测点 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string 编号 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 工务段 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 车间 {get;set;}

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
        public Double? 里程 {get;set;}

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
        public int? 排序 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 区段 {get;set;}

        /// <summary>
        /// Desc:限速说明 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 限速 {get;set;}

        /// <summary>
        /// Desc:封锁说明 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 封锁 {get;set;}

        /// <summary>
        /// Desc:注意、限速、封锁、解除、正常 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 状态 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? 更改状态时间 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 负责人 {get;set;}

        /// <summary>
        /// Desc:短信接收手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE {get;set;}

    }
}
