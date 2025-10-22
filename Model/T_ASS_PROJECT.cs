using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_PROJECT
    {
        
        /// <summary>
        /// Desc:项目代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PROJECTCODE {get;set;}

        /// <summary>
        /// Desc:项目类型(默认为1，1：维修项目；2：施工项目；3：设备周期检查，4：设备专项检查，5：添乘检查，6：日常检查，7：不定期检查，８：其它检查；９：外委施工；10,:它作业) 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_PROJECTTYPE {get;set;}

        /// <summary>
        /// Desc:项目名称 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_PROJECTNAME {get;set;}

        /// <summary>
        /// Desc:单位（计量单位） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_UNIT {get;set;}

        /// <summary>
        /// Desc:安全风险提示 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_SAFETYRISKTIPS {get;set;}

        /// <summary>
        /// Desc:是否有效 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_EFF_FLAG {get;set;}

        /// <summary>
        /// Desc:排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_ORDER {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

        /// <summary>
        /// Desc:作业指导书 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_BOOK {get;set;}

        /// <summary>
        /// Desc:类别：（线路、桥隧、安全防护设施及环境、线上、线下、动态检查、其它） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_PROJECTCATEGORY {get;set;}

        /// <summary>
        /// Desc:主要机具材料 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TOOLS_MATERIALS {get;set;}

        /// <summary>
        /// Desc:作业程序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_OPERATION_SEQUENCE {get;set;}

    }
}
