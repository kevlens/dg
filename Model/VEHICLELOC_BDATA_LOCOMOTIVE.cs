using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class VEHICLELOC_BDATA_LOCOMOTIVE
    {
        
        /// <summary>
        /// Desc:机车号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int LOCOMOTIVE_NO {get;set;}

        /// <summary>
        /// Desc:机车型号中英文描述 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LOCOMOTIVE_TYPE {get;set;}

        /// <summary>
        /// Desc:所属部门（局名称） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:机务段名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JWD_NAME {get;set;}

        /// <summary>
        /// Desc:机务段下单位名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JWDDW_NAME {get;set;}

        /// <summary>
        /// Desc:手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_NO {get;set;}

        /// <summary>
        /// Desc:机车类型（0：支配 1：非支配-长备 2：非支配-出租，出助 3：配属） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LOCOMOTIVE_FLAG {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LOCOMOTIVE_MEMO {get;set;}

        /// <summary>
        /// Desc:机车型号编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LOCOMOTIVE_NUMBER {get;set;}

    }
}
