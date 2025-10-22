using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class CURVE_BASE_EXT
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:轨撑 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? RAILBRACE {get;set;}

        /// <summary>
        /// Desc:轨距杆 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? GAUGEROD {get;set;}

        /// <summary>
        /// Desc:打磨时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? POLISHINGTIME {get;set;}

        /// <summary>
        /// Desc:打磨周期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? GRINDINGCYCLE {get;set;}

        /// <summary>
        /// Desc:是否涂油固态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FLAGSOLIDOIL {get;set;}

        /// <summary>
        /// Desc:是否涂油液态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FLAGLIQUIDOIL {get;set;}

        /// <summary>
        /// Desc:三维观测桩数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? OBSERVATIONQUANTITY {get;set;}

        /// <summary>
        /// Desc:侧磨照片 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HWEARPHOTO {get;set;}

        /// <summary>
        /// Desc:提醒信息 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ALERTMESSAGE {get;set;}

        /// <summary>
        /// Desc:换轨标志 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? FLAGCHANGERAIL {get;set;}

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
        /// Desc:排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_ORDER {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

        /// <summary>
        /// Desc:轨型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? RAILTYPE {get;set;}

    }
}
