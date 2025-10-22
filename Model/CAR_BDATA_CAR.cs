using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class CAR_BDATA_CAR
    {
        
        /// <summary>
        /// Desc:汽车编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CAR_NO {get;set;}

        /// <summary>
        /// Desc:车牌号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CAR_LICENSENO {get;set;}

        /// <summary>
        /// Desc:所属部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CAR_TYPE {get;set;}

        /// <summary>
        /// Desc:品牌 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CAR_BRAND {get;set;}

        /// <summary>
        /// Desc:型号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CAR_MODEL {get;set;}

        /// <summary>
        /// Desc:购买日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CAR_BUYDATE {get;set;}

        /// <summary>
        /// Desc:用途 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CAR_PURPOSE {get;set;}

        /// <summary>
        /// Desc:燃油类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OIL_TYPE {get;set;}

        /// <summary>
        /// Desc:排量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single CAR_DISPLAYMENT {get;set;}

        /// <summary>
        /// Desc:核载人数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? CAR_LOADNO {get;set;}

        /// <summary>
        /// Desc:载重 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single CAR_LOADWEIGHT {get;set;}

        /// <summary>
        /// Desc:保险有效期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CAR_INSURANCEDATE {get;set;}

        /// <summary>
        /// Desc:检验有效期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CAR_TESTDATE {get;set;}

        /// <summary>
        /// Desc:报警车速 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? CAR_WARNSPEED {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CAR_NOTE {get;set;}

        /// <summary>
        /// Desc:百公里耗油量：升/100km--油耗 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? CAR_KWH {get;set;}

        /// <summary>
        /// Desc:油单价 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? OIL_PRICE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? LAST_TIME {get;set;}

        /// <summary>
        /// Desc:油耗单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OIL_UNIT {get;set;}

        /// <summary>
        /// Desc:里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_SUM {get;set;}

        /// <summary>
        /// Desc:速度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? CAR_SPEED {get;set;}

        /// <summary>
        /// Desc:剩余油量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single OIL_SURPLUS {get;set;}

        /// <summary>
        /// Desc:剩余油量单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OIL_SURPLUS_UNIT {get;set;}

        /// <summary>
        /// Desc:下次保养里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? MILEAGE_MAINTAIN {get;set;}

        /// <summary>
        /// Desc:超速次数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? OVERSPEED_NUM {get;set;}

        /// <summary>
        /// Desc:非超速次数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? NOOVERSPEED_NUM {get;set;}

    }
}
