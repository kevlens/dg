using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_CARLASTOBD
    {
        
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
        public Single 油耗 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 油耗单位 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? 里程 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? 速度 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single 剩余油量 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 剩余油量单位 {get;set;}

        /// <summary>
        /// Desc:油单价 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? OIL_PRICE {get;set;}

        /// <summary>
        /// Desc:车牌号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CAR_LICENSENO {get;set;}

    }
}
