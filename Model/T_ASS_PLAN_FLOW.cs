using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_PLAN_FLOW
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:车间代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJCODE {get;set;}

        /// <summary>
        /// Desc:车间名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJNAME {get;set;}

        /// <summary>
        /// Desc:车间主任 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJZR {get;set;}

        /// <summary>
        /// Desc:计划名称日期唯一字段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLANNAME {get;set;}

        /// <summary>
        /// Desc:计划日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RQ {get;set;}

        /// <summary>
        /// Desc:创建人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CREATER {get;set;}

        /// <summary>
        /// Desc:创建人电话 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CREATERTEL {get;set;}

        /// <summary>
        /// Desc:创建日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CREATETIME {get;set;}

        /// <summary>
        /// Desc:审核人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AUDITER {get;set;}

        /// <summary>
        /// Desc:审核日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? AUDITTIME {get;set;}

        /// <summary>
        /// Desc:下发人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SENDER {get;set;}

        /// <summary>
        /// Desc:下发日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? SENDTIME {get;set;}

        /// <summary>
        /// Desc:上报人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPORTER {get;set;}

        /// <summary>
        /// Desc:上报日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? REPORTTIME {get;set;}

        /// <summary>
        /// Desc:车间审核(0、车间未创建 1、车间主任审核2、编制完成) 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool ISCREATE {get;set;}

        /// <summary>
        /// Desc:提交审核(0、车间未提交 1、车间已提交) 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool ISSUBMIT {get;set;}

        /// <summary>
        /// Desc:审核通过(0、初审未通过 1、初审通过) 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool ISAUDIT {get;set;}

        /// <summary>
        /// Desc:是否驳回(0、初审未驳回 1、初审已驳回) 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool ISREJECT {get;set;}

        /// <summary>
        /// Desc:审核通过(0、二审未通过 1、二审通过) 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool ISAUDIT2 {get;set;}

        /// <summary>
        /// Desc:是否驳回(0、二审未驳回 1、二审已驳回) 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool ISREJECT2 {get;set;}

        /// <summary>
        /// Desc:是否归档(0、未归档 1、已归档) 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool ISFINISHED {get;set;}

        /// <summary>
        /// Desc:计划类型(0、月计划 1、周计划 2、日计划) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool PLANTYPE {get;set;}

        /// <summary>
        /// Desc:工作类型（1：综合维修；2：临时补修；3：预留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool JOBTYPE {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BZ {get;set;}

        /// <summary>
        /// Desc:段领导 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER {get;set;}

    }
}
