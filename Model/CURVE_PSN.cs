using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class CURVE_PSN
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:工区姓名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQEMPNAME {get;set;}

        /// <summary>
        /// Desc:工区职务 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQEMPPOST {get;set;}

        /// <summary>
        /// Desc:工区检查日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? GQEMPCHECKDATE {get;set;}

        /// <summary>
        /// Desc:车间姓名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJEMPNAME {get;set;}

        /// <summary>
        /// Desc:车间职务 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJEMPPOST {get;set;}

        /// <summary>
        /// Desc:车间检查日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CJEMPCHECKDATE {get;set;}

        /// <summary>
        /// Desc:段姓名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GWDEMPNAME {get;set;}

        /// <summary>
        /// Desc:段职务 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GWDEMPPOST {get;set;}

        /// <summary>
        /// Desc:段检查日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? GWDEMPCHECKDATE {get;set;}

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
