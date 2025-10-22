using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_UNIT625
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FKID {get;set;}

        /// <summary>
        /// Desc:工务段编码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_GWD_CODE {get;set;}

        /// <summary>
        /// Desc:工区编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:单元号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int N_UNIT_NUM {get;set;}

        /// <summary>
        /// Desc:小单元号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int N_UNIT625_NUM {get;set;}

        /// <summary>
        /// Desc:线编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_LINE_CODE {get;set;}

        /// <summary>
        /// Desc:线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_NAME {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_LINE_DIR {get;set;}

        /// <summary>
        /// Desc:起点里程 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public Double N_START_MILE {get;set;}

        /// <summary>
        /// Desc:终点里程 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public Double N_END_MILE {get;set;}

        /// <summary>
        /// Desc:线路特征 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_FEATURE {get;set;}

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

    }
}
