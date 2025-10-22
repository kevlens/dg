using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_GATEMNG_AUTHORIZATION
    {
        
        /// <summary>
        /// Desc:授权主键ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string AUTHORIZATION_ID {get;set;}

        /// <summary>
        /// Desc:卡号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CARD_NO {get;set;}

        /// <summary>
        /// Desc:门号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATE_NO {get;set;}

        /// <summary>
        /// Desc:授权开始时间（驻站员） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? AUTHORIZATIONTIME_BEGIN {get;set;}

        /// <summary>
        /// Desc:授权结束时间（驻站员） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? AUTHORIZATIONTIME_END {get;set;}

        /// <summary>
        /// Desc:下发状态（0：未下发 1：下发成功 2：下发失败 3：作废） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ISSUE_STATE {get;set;}

        /// <summary>
        /// Desc:下发时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? ISSUE_DATE {get;set;}

        /// <summary>
        /// Desc:0：计划 1：手动授权 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPE {get;set;}

        /// <summary>
        /// Desc:计划单号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_NO {get;set;}

        /// <summary>
        /// Desc:持卡人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMBER_NAME {get;set;}

        /// <summary>
        /// Desc:inout_ 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? IN_TIME {get;set;}

        /// <summary>
        /// Desc:inout_ 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? OUT_TIME {get;set;}

        /// <summary>
        /// Desc:流程FLAG 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FLOW_ORDER {get;set;}

        /// <summary>
        /// Desc:行车调度命令号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRAIN_NO {get;set;}

        /// <summary>
        /// Desc:工务命令号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_NO {get;set;}

        /// <summary>
        /// Desc:下发行车调度命令号驻站员ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRAIN_MEMBER {get;set;}

        /// <summary>
        /// Desc:下发工务命令号调度员ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_MEMBER {get;set;}

        /// <summary>
        /// Desc:计划开始时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? PLANTIME_BEGIN {get;set;}

        /// <summary>
        /// Desc:计划结束时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? PLANTIME_END {get;set;}

        /// <summary>
        /// Desc:驻站客户端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLIENT_NO {get;set;}

        /// <summary>
        /// Desc:反转门号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATE_CONVERTNO {get;set;}

        /// <summary>
        /// Desc:授权用户 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AUTHOPT_USER {get;set;}

        /// <summary>
        /// Desc:授权操作时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? AUTHOPT_TIME {get;set;}

        /// <summary>
        /// Desc:卡归属段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AUTHOPT_SECTION {get;set;}

        /// <summary>
        /// Desc:授权备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AUTHOPT_NOTE {get;set;}

        /// <summary>
        /// Desc:门所属的部门（局或段编码） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATE_DEPTCODE {get;set;}

        /// <summary>
        /// Desc:默认为0,删除授权为1 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? DELAUTH_FLAG {get;set;}

        /// <summary>
        /// Desc:删除授权操作用户 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DELAUTHOPT_USER {get;set;}

        /// <summary>
        /// Desc:删除授权操作时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? DELAUTHOPT_TIME {get;set;}

        /// <summary>
        /// Desc:授权操作返回时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? AUTHBACK_TIME {get;set;}

        /// <summary>
        /// Desc:"授权操作结果(0:失败，1:成功)
" 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? AUTHBACK_RUSULT {get;set;}

        /// <summary>
        /// Desc:删除授权返回时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? DELAUTHBACK_TIME {get;set;}

        /// <summary>
        /// Desc:删除授权结果(0:失败，1:成功) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? DELAUTHBACK_RUSULT {get;set;}

    }
}
