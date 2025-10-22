using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_CHK_VISUAL_ITEMS
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:检查类型(0:线路检查;1:曲线正矢;2:单开道岔;3:菱形道岔;4:交分道岔;5:双开道岔；6:可动心轨单开道岔；7:直观项检查) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_TYPE {get;set;}

        /// <summary>
        /// Desc:主表PKID(便于统计) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FKID {get;set;}

        /// <summary>
        /// Desc:子表PKID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEMFKID {get;set;}

        /// <summary>
        /// Desc:对应T_CHK_DIC字段:DIC_ID用以描述道岔位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POS_CODE {get;set;}

        /// <summary>
        /// Desc:病害类型对应T_CHK_DIC字段:DIC_ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DISE_TYPE {get;set;}

        /// <summary>
        /// Desc:病害情况 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DISE_STITUATION {get;set;}

        /// <summary>
        /// Desc:病害数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DISE_NUM {get;set;}

        /// <summary>
        /// Desc:病害项目对应T_CHK_DIC字段:DIC_ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DISE_PROJECT {get;set;}

        /// <summary>
        /// Desc:病害单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DISE_COMPANY {get;set;}

        /// <summary>
        /// Desc:扣分标准 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STANDARD_DEDUCTION {get;set;}

        /// <summary>
        /// Desc:病害等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DISE_LEVEL {get;set;}

        /// <summary>
        /// Desc:病害位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DISE_POS {get;set;}

        /// <summary>
        /// Desc:经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? LNG {get;set;}

        /// <summary>
        /// Desc:纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? LAT {get;set;}

        /// <summary>
        /// Desc:火星经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARS_LNG {get;set;}

        /// <summary>
        /// Desc:火星纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARS_LAT {get;set;}

        /// <summary>
        /// Desc:百度经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? BAIDU_LNG {get;set;}

        /// <summary>
        /// Desc:百度纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? BAIDU_LAT {get;set;}

        /// <summary>
        /// Desc:GPS时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? GPS_TM {get;set;}

        /// <summary>
        /// Desc:检查时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CHK_TM {get;set;}

        /// <summary>
        /// Desc:手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_NO {get;set;}

    }
}
