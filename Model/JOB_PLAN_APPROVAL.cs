using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class JOB_PLAN_APPROVAL
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PLAN_ID {get;set;}

        /// <summary>
        /// Desc:站编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_CODE {get;set;}

        /// <summary>
        /// Desc:站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME {get;set;}

        /// <summary>
        /// Desc:线编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_CODE {get;set;}

        /// <summary>
        /// Desc:线名(天窗单元) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME {get;set;}

        /// <summary>
        /// Desc:行别(行别与站内) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIRECTION {get;set;}

        /// <summary>
        /// Desc:里程(作业地点) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE {get;set;}

        /// <summary>
        /// Desc:入库时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? PUSH_TIME {get;set;}

        /// <summary>
        /// Desc:作业项目 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_PROJECT {get;set;}

        /// <summary>
        /// Desc:作业开始时间(计划上道开始时间) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CONSTRUCT_START_TIME {get;set;}

        /// <summary>
        /// Desc:作业结束时间(计划上道结束时间) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CONSTRUCT_END_TIME {get;set;}

        /// <summary>
        /// Desc:作业人数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public long CONSTRUCT_NUM {get;set;}

        /// <summary>
        /// Desc:作业人数职工 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public long JOBNUM_WORKER {get;set;}

        /// <summary>
        /// Desc:作业人数辅助 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public long JOBNUM_AUXILIARY {get;set;}

        /// <summary>
        /// Desc:携带工具(主要工机具) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CARRY_TOOLS {get;set;}

        /// <summary>
        /// Desc:施工部门编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_DPT_CODE {get;set;}

        /// <summary>
        /// Desc:施工部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_DPT {get;set;}

        /// <summary>
        /// Desc:施工负责人(作业负责人主体) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_CHARGE {get;set;}

        /// <summary>
        /// Desc:施工负责人电话 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_PHONE {get;set;}

        /// <summary>
        /// Desc:作业负责人公用 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOBHEAD_PUBLIC {get;set;}

        /// <summary>
        /// Desc:作业负责人配合 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOBHEAD_COOPERATE {get;set;}

        /// <summary>
        /// Desc:火星经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARS_LONGITUDE {get;set;}

        /// <summary>
        /// Desc:火星纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARS_LATITUDE {get;set;}

        /// <summary>
        /// Desc:审批级别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string APPROVAL_LEVELS {get;set;}

        /// <summary>
        /// Desc:维修级别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_LEVEL {get;set;}

        /// <summary>
        /// Desc:车间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORKSHOP {get;set;}

        /// <summary>
        /// Desc:作业班组主体 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOBTEAM_MAINBODY {get;set;}

        /// <summary>
        /// Desc:作业班组公用 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOBTEAM_PUBLIC {get;set;}

        /// <summary>
        /// Desc:作业班组配合 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOBTEAM_COOPERATE {get;set;}

        /// <summary>
        /// Desc:作业分类 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_TYPE {get;set;}

        /// <summary>
        /// Desc:作业地点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_ADDRESS {get;set;}

        /// <summary>
        /// Desc:登记车站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REGISTRATION_STATION {get;set;}

        /// <summary>
        /// Desc:驻站防护员所在站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GUARD_STATION {get;set;}

        /// <summary>
        /// Desc:路用车始发站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LOADCAR_STATION {get;set;}

        /// <summary>
        /// Desc:质检员 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INSPECTOR {get;set;}

        /// <summary>
        /// Desc:其它配合单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OTHER_UNIT {get;set;}

        /// <summary>
        /// Desc:是否转非常站控 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string IF_ZFCZK {get;set;}

        /// <summary>
        /// Desc:作业原因 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_REASON {get;set;}

        /// <summary>
        /// Desc:作业内容 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_CONTENT {get;set;}

        /// <summary>
        /// Desc:工作量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORKLOAD {get;set;}

        /// <summary>
        /// Desc:防护员姓名(防护员驻站) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEFEND_CHARGE {get;set;}

        /// <summary>
        /// Desc:防护员电话 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEFEND_PHONE {get;set;}

        /// <summary>
        /// Desc:防护员工地 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEFEND_WORKSIT {get;set;}

        /// <summary>
        /// Desc:防护员驻所 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEFEND_PLACE {get;set;}

        /// <summary>
        /// Desc:作业指导书或施工组织 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOBINS_ORGCON {get;set;}

        /// <summary>
        /// Desc:本单元是否有路用车配合 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIN_BDYSFYLYCPH {get;set;}

        /// <summary>
        /// Desc:相邻线天窗内是否有路用车 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIN_XLTCSFYLYC {get;set;}

        /// <summary>
        /// Desc:是否上线 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string IF_LINE {get;set;}

        /// <summary>
        /// Desc:审批人段审核小组 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string APPROVAL_SECTION {get;set;}

        /// <summary>
        /// Desc:审批人主管副段长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string APPROVAL_EXECUTIVE {get;set;}

        /// <summary>
        /// Desc:审批人工务处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string APPROVAL_WORKS {get;set;}

        /// <summary>
        /// Desc:确认码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONFIRMATION_CODE {get;set;}

        /// <summary>
        /// Desc:计划的类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TYPE {get;set;}

    }
}
