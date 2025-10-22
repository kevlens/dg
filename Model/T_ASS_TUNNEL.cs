using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_TUNNEL
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:工务段代码(用户所属工务段) 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string GWD_CODE {get;set;}

        /// <summary>
        /// Desc:部门代码（编制计划的用户所在的部门代码） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEP_CODE {get;set;}

        /// <summary>
        /// Desc:工区代码（显示时显示工区名称，计划归属的工区） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_CODE {get;set;}

        /// <summary>
        /// Desc:线编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LINE_CODE {get;set;}

        /// <summary>
        /// Desc:线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME {get;set;}

        /// <summary>
        /// Desc:辅助线编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ASSIST_LINE_CODE {get;set;}

        /// <summary>
        /// Desc:辅助线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ASSIST_LINE_NAME {get;set;}

        /// <summary>
        /// Desc:隧道号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string TUNNEL_CODE {get;set;}

        /// <summary>
        /// Desc:隧道名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TUNNEL_NAME {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:运营状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OPERATION_STATUS {get;set;}

        /// <summary>
        /// Desc:轨距 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE {get;set;}

        /// <summary>
        /// Desc:中心里程 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public Double CENTER_MILEAGE {get;set;}

        /// <summary>
        /// Desc:长链标记 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LONGCHAIN_MARKER {get;set;}

        /// <summary>
        /// Desc:隧道全长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TUNNEL_LENGTH {get;set;}

        /// <summary>
        /// Desc:开始里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? START_MILEAGE {get;set;}

        /// <summary>
        /// Desc:结束里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? END_MILEAGE {get;set;}

    }
}
