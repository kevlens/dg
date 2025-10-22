using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class OIL_BDATA_CURVE
    {
        
        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CURVE_ID {get;set;}

        /// <summary>
        /// Desc:所属部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:线代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_CODE {get;set;}

        /// <summary>
        /// Desc:线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:开始涂油里程(KM) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? OILMILE_BEGIN {get;set;}

        /// <summary>
        /// Desc:结束涂油里程(KM) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? OILMILE_END {get;set;}

        /// <summary>
        /// Desc:左右轨标记（0：空，1：左轨，2：右轨） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POS_FLAG {get;set;}

        /// <summary>
        /// Desc:启用停用标记（0：启用，1：停用） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ENABLE_FLAG {get;set;}

        /// <summary>
        /// Desc:新增时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CURVE_INDATE {get;set;}

        /// <summary>
        /// Desc:上次修改时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CURVE_LSTUPDATEDATE {get;set;}

        /// <summary>
        /// Desc:上次修改人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CURVE_LSTUPDATEUSER {get;set;}

        /// <summary>
        /// Desc:曲线排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? CURVE_ORDER {get;set;}

        /// <summary>
        /// Desc:曲线备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CURVE_MEMO {get;set;}

        /// <summary>
        /// Desc:曲线半径 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? CURVE_RADIUS {get;set;}

        /// <summary>
        /// Desc:曲线全长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? CURVE_LENGTH {get;set;}

        /// <summary>
        /// Desc:开始涂油里程(缓冲量)(M) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? OILMILEBUF_BEGIN {get;set;}

        /// <summary>
        /// Desc:结束涂油里程(缓冲量)(M) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? OILMILEBUF_END {get;set;}

        /// <summary>
        /// Desc:开始涂油里程(计算缓冲量后的实际值)(KM) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? OILMILEACT_BEGIN {get;set;}

        /// <summary>
        /// Desc:结束涂油里程(计算缓冲量后的实际值)(KM) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? OILMILEACT_END {get;set;}

    }
}
