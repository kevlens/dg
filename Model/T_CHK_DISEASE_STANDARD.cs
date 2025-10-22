using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_CHK_DISEASE_STANDARD
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
        /// Desc:速度范围(0:其他站线;1:Vmax≤120Km/h正线及到发线;2:160Km/h≥Vmax>120Km/h正线;3:Vmax>160Km/h正线;4:专用线) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SPEED_RANGE {get;set;}

        /// <summary>
        /// Desc:报警等级(0:作业验收;1:经常保养;2:临时补修;3:超极限;) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WARN_LEVEL {get;set;}

        /// <summary>
        /// Desc:对应T_CHK_DIC字段:DIC_ID用以描述道岔位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POS_CODE {get;set;}

        /// <summary>
        /// Desc:对应T_CHK_DIC字段:DIC_ID用以描述检查项目 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_ITEM {get;set;}

        /// <summary>
        /// Desc:曲线半径(0:R≤250;1:250＜R≤350;2:350＜R≤450;3:450＜R≤800;4:R＞800;) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CURVE_RADIUS_RANGE {get;set;}

        /// <summary>
        /// Desc:速度范围(0:Vmax≤120Km/h;1:160Km/h≥Vmax>120Km/h;2:Vmax>160Km/h;) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CURVE_SPEED_RANGE {get;set;}

        /// <summary>
        /// Desc:0：正线及到发线；1：其他站线；2：专用线；3：附带曲线 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CURVE_TYPE {get;set;}

        /// <summary>
        /// Desc:比较值(正) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? POSITIVE_VALUE {get;set;}

        /// <summary>
        /// Desc:比较值(负) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? NEGATIVE {get;set;}

    }
}
