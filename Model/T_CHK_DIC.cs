using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_CHK_DIC
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:字典ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DIC_ID {get;set;}

        /// <summary>
        /// Desc:检查类型(0:线路检查;1:曲线正矢;2:单开道岔;3:菱形道岔;4:交分道岔;5:双开道岔；6:可动心轨单开道岔) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_TYPE {get;set;}

        /// <summary>
        /// Desc:类型(0:直观项目下拉单;1:几何病害，位置) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPE_FLAG {get;set;}

        /// <summary>
        /// Desc:0:项目（横）,1:位置（纵） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POS_FLAG {get;set;}

        /// <summary>
        /// Desc:来源DIC_ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PAR_ID {get;set;}

        /// <summary>
        /// Desc:描述 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIC_DESC {get;set;}

        /// <summary>
        /// Desc:简单描述 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIC_SAMPDESC {get;set;}

        /// <summary>
        /// Desc:病害单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIS_UNIT {get;set;}

        /// <summary>
        /// Desc:扣分标准 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MINUS_STANDARD {get;set;}

        /// <summary>
        /// Desc:病害等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIS_LEVEL {get;set;}

        /// <summary>
        /// Desc:病害问题类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIS_TYPE {get;set;}

    }
}
