using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class TOOL_INOUTMNG_INFO
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string ID {get;set;}

        /// <summary>
        /// Desc:工单ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_ID {get;set;}

        /// <summary>
        /// Desc:计划工机具名称（计划表解析出） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TOOL_NAME {get;set;}

        /// <summary>
        /// Desc:领用工机具编号（工机具表的设备ID） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TOOL_ID {get;set;}

        /// <summary>
        /// Desc:领用工机具名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TOOL_NAME {get;set;}

        /// <summary>
        /// Desc:领用时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? BORROW_TIME {get;set;}

        /// <summary>
        /// Desc:返还工机具编号（工机具表的设备ID） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TOOL_ID_RETURN {get;set;}

        /// <summary>
        /// Desc:返还工机具名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TOOL_NAME_RETURN {get;set;}

        /// <summary>
        /// Desc:返还时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RETURN_TIME {get;set;}

        /// <summary>
        /// Desc:状态（0：领用；1：返还；3：未领用；4:丢失） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool TOOL_STATU {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REMARK {get;set;}

    }
}
