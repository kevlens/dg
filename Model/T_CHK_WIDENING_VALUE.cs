using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_CHK_WIDENING_VALUE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:检查类型(0:线路检查;1:曲线正矢;2:单开道岔;3:菱形道岔;4:交分道岔;5:双开道岔；6:可动心轨单开道岔) 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CHECK_TYPE {get;set;}

        /// <summary>
        /// Desc:道岔编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUT_CODE {get;set;}

        /// <summary>
        /// Desc:对应T_CHK_DIC字段:DIC_ID用以描述道岔位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUT_POS {get;set;}

        /// <summary>
        /// Desc:曲线半径(0:R≥295;1:295＞R≥245;2:245＞R≥195;3:R＜195) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CURVE_RADIUS_RANGE {get;set;}

        /// <summary>
        /// Desc:速度范围(0:Vmax≤120Km/h;1:160Km/h≥Vmax>120Km/h;2:Vmax>160Km/h;) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SPEED_RANGE {get;set;}

        /// <summary>
        /// Desc:对应T_CHK_DIC字段:DIC_ID用以描述站线种类(正线线路,正线道岔,站线线路,站线道岔等) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_TYPE {get;set;}

        /// <summary>
        /// Desc:报警等级(0:作业验收;1:经常保养;2:临时补修;3:超极限;) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WARN_LEVEL {get;set;}

        /// <summary>
        /// Desc:对应加宽值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? WIDENING_VALUE {get;set;}

        /// <summary>
        /// Desc:备留字段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WIDENING_TYPE1 {get;set;}

        /// <summary>
        /// Desc:备留字段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WIDENING_TYPE2 {get;set;}

        /// <summary>
        /// Desc:备留字段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WIDENING_TYPE3 {get;set;}

        /// <summary>
        /// Desc:备留字段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WIDENING_TYPE4 {get;set;}

        /// <summary>
        /// Desc:备留字段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WIDENING_TYPE5 {get;set;}

    }
}
