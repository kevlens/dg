using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class CURVE_CWR
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:铺设日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? LAYINGDATE {get;set;}

        /// <summary>
        /// Desc:结构形式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STRUCTUREFORM {get;set;}

        /// <summary>
        /// Desc:设计锁温 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? DLOCKTEMPERATURE {get;set;}

        /// <summary>
        /// Desc:实际锁温 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? ALOCKTEMPERATURE {get;set;}

        /// <summary>
        /// Desc:春夏秋设计锁温 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? SSADLOCKTEMPERATURE {get;set;}

        /// <summary>
        /// Desc:春夏秋实际锁温 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? SSAALOCKTEMPERATURE {get;set;}

        /// <summary>
        /// Desc:春夏秋放散日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? SSABLEEDINGDATE {get;set;}

        /// <summary>
        /// Desc:秋冬春设计锁温 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? AWSDLOCKTEMPERATURE {get;set;}

        /// <summary>
        /// Desc:秋冬春实际锁温 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? AWSALOCKTEMPERATURE {get;set;}

        /// <summary>
        /// Desc:秋冬春放散日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? AWSBLEEDINGDATE {get;set;}

        /// <summary>
        /// Desc:创建日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? T_CRT_TM {get;set;}

        /// <summary>
        /// Desc:创建人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CRT_NAME {get;set;}

        /// <summary>
        /// Desc:排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_ORDER {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

    }
}
