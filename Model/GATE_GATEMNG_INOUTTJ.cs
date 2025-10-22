using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_GATEMNG_INOUTTJ
    {
        
        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:作业门手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATE_NO {get;set;}

        /// <summary>
        /// Desc:硬件进入数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? INOUT_NUM {get;set;}

        /// <summary>
        /// Desc:关门时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? INOUT_TIME {get;set;}

        /// <summary>
        /// Desc:系统时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? XT_TIME {get;set;}

        /// <summary>
        /// Desc:系统最后一条双目进入人数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? XT_NUM {get;set;}

        /// <summary>
        /// Desc:关门时最后一条双目进入人数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? GM_NUM {get;set;}

        /// <summary>
        /// Desc:双目进入人数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? SM_NUM {get;set;}

        /// <summary>
        /// Desc:出入类型0：进，1：出 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INOUT_FLAG {get;set;}

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

    }
}
