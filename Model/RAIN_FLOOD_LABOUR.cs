using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIN_FLOOD_LABOUR
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FLOODLABOUR_ID {get;set;}

        /// <summary>
        /// Desc:专业 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LABOUR_MAJOR {get;set;}

        /// <summary>
        /// Desc:地点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLACE {get;set;}

        /// <summary>
        /// Desc:联系人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTACTS {get;set;}

        /// <summary>
        /// Desc:联系电话 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE {get;set;}

        /// <summary>
        /// Desc:职工人数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? WORKER_NUM {get;set;}

        /// <summary>
        /// Desc:民工人数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? MAGRANT_NUM {get;set;}

        /// <summary>
        /// Desc:大型机械 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BIG_MECHANICS {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEMO {get;set;}

        /// <summary>
        /// Desc:工务段代码(用户所属工务段) 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string GWD_CODE {get;set;}

        /// <summary>
        /// Desc:部门代码（车间） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEP_CODE {get;set;}

        /// <summary>
        /// Desc:工区代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_CODE {get;set;}

    }
}
