using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_GATEMNG_WARNING
    {
        
        /// <summary>
        /// Desc:警报id 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string WARNING_ID {get;set;}

        /// <summary>
        /// Desc:门号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATE_NO {get;set;}

        /// <summary>
        /// Desc:警报内容 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WARNING_INFO {get;set;}

        /// <summary>
        /// Desc:警报日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? WARNING_TIME {get;set;}

        /// <summary>
        /// Desc:警报类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WARNING_TYPE {get;set;}

        /// <summary>
        /// Desc:5AA5未解析纪录 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WARNING_LOG {get;set;}

        /// <summary>
        /// Desc:1:人员逗留,2:通道门开启时间超过预设值，3：连续5分钟无读卡记录,但通道门未关闭，4：电池电量低于警戒值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? WARNING_FLAG {get;set;}

        /// <summary>
        /// Desc:数据类型(1或空:门禁，2：预设值前仍有人，3：天窗点外仍有人，4：未知卡号进入) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WARNING_FROM {get;set;}

        /// <summary>
        /// Desc:卡号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CARD_NO {get;set;}

        /// <summary>
        /// Desc:人员姓名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GNAME {get;set;}

        /// <summary>
        /// Desc:人员手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GMOBILE {get;set;}

        /// <summary>
        /// Desc:人员部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GDEPTNAME {get;set;}

        /// <summary>
        /// Desc:授权ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AUTHHIS_ID {get;set;}

        /// <summary>
        /// Desc:解除报警时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? UNWARN_TIME {get;set;}

        /// <summary>
        /// Desc:解除报警用户 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UNWARN_USER {get;set;}

        /// <summary>
        /// Desc:解除报警原因 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UNWARN_REASON {get;set;}

        /// <summary>
        /// Desc:卡归属段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AUTHOPT_SECTION {get;set;}

    }
}
