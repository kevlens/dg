using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_TEMREPAIR_PLAN
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:工单号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_JOB_NO {get;set;}

        /// <summary>
        /// Desc:是否有效 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_EFF_FLAG {get;set;}

        /// <summary>
        /// Desc:计划整修开始日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? T_PLANREAPIR_DATE {get;set;}

        /// <summary>
        /// Desc:工务段编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_GWD_CODE {get;set;}

        /// <summary>
        /// Desc:单位编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_DEP_CODE {get;set;}

        /// <summary>
        /// Desc:单位名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_DEP_NAME {get;set;}

        /// <summary>
        /// Desc:单位属性 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_DEP_PROP {get;set;}

        /// <summary>
        /// Desc:问题库编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_FKID {get;set;}

        /// <summary>
        /// Desc:备留字段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_RESERVE {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

        /// <summary>
        /// Desc:创建日期，编制日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? T_CRT_TM {get;set;}

        /// <summary>
        /// Desc:创建人，编制人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CRT_NAME {get;set;}

        /// <summary>
        /// Desc:实际整修开始日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? C_REPAIR_DATE {get;set;}

        /// <summary>
        /// Desc:整修结果 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_REPAIR_RES {get;set;}

        /// <summary>
        /// Desc:工单审批人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_APPROVER {get;set;}

        /// <summary>
        /// Desc:复查结果 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_RECIEW_RESU {get;set;}

        /// <summary>
        /// Desc:整修负责人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_REPAIR_LEADER {get;set;}

        /// <summary>
        /// Desc:抽检结果 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_SAMP_RES {get;set;}

    }
}
