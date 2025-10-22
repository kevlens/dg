using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_PARAREPORT_TEMP
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:部门 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_DEP_CODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_DEP_NAME {get;set;}

        /// <summary>
        /// Desc:查询类别:段别,线名 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_CODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_NAME {get;set;}

        /// <summary>
        /// Desc:类型：正线 、站线 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TYPE {get;set;}

        /// <summary>
        /// Desc:检查数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? C_CHECK_COUNT {get;set;}

        /// <summary>
        /// Desc:优良 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? C_LEVEL_GOOD {get;set;}

        /// <summary>
        /// Desc:一般 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? C_LEVEL_KIND {get;set;}

        /// <summary>
        /// Desc:失格 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? C_LEVEL_POOR {get;set;}

        /// <summary>
        /// Desc:几何尺寸 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? C_JHCC_SCORE {get;set;}

        /// <summary>
        /// Desc:钢轨分数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? C_GG_SCORE {get;set;}

        /// <summary>
        /// Desc:轨枕分数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? C_GZ_SCORE {get;set;}

        /// <summary>
        /// Desc:爬行分数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? C_PX_SCORE {get;set;}

        /// <summary>
        /// Desc:道床分数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? C_DC_SCORE {get;set;}

        /// <summary>
        /// Desc:其它分数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? C_OTHER_SCORE {get;set;}

        /// <summary>
        /// Desc:曲线优良 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? C_CUR_GOOD {get;set;}

        /// <summary>
        /// Desc:曲线合格 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? C_CUR_KIND {get;set;}

        /// <summary>
        /// Desc:曲线失格 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? C_CUR_POOR {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_USER_ID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? C_DATE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_FLAG {get;set;}

        /// <summary>
        /// Desc:道岔检查数(组) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? DC_CHECK_NUM {get;set;}

        /// <summary>
        /// Desc:道岔优良 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? DC_LEVEL_GOOD {get;set;}

        /// <summary>
        /// Desc:道岔一般 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? DC_LEVEL_KIND {get;set;}

        /// <summary>
        /// Desc:道岔失格 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? DC_LEVEL_POOR {get;set;}

        /// <summary>
        /// Desc:道岔几何尺寸 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? DC_JHCC_SCORE {get;set;}

        /// <summary>
        /// Desc:道岔钢轨分数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? DC_GG_SCORE {get;set;}

        /// <summary>
        /// Desc:道岔轨枕分数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? DC_GZ_SCORE {get;set;}

        /// <summary>
        /// Desc:道岔爬行分数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? DC_PX_SCORE {get;set;}

        /// <summary>
        /// Desc:道岔道床分数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? DC_DC_SCORE {get;set;}

        /// <summary>
        /// Desc:道岔其它分数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? DC_OTHER_SCORE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

    }
}
