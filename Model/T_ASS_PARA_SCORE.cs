using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_PARA_SCORE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:检查类型（静态、动态） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_CHECK_TYPE {get;set;}

        /// <summary>
        /// Desc:类别（线路、道岔） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_CAT {get;set;}

        /// <summary>
        /// Desc:项目（轨道几何尺寸、钢轨...） 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_ITEM {get;set;}

        /// <summary>
        /// Desc:项目内容（轨距、水平、三角坑） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TYPE {get;set;}

        /// <summary>
        /// Desc:项目内容编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TYPE_CODE {get;set;}

        /// <summary>
        /// Desc:标准（作业标准、经常保养、I级、Ⅱ级 ） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_STANDARD {get;set;}

        /// <summary>
        /// Desc:线别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_CAT {get;set;}

        /// <summary>
        /// Desc:是否无缝线路（Y、N） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_JOINTLESS {get;set;}

        /// <summary>
        /// Desc:速度上限值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public short N_MAX_SPEED {get;set;}

        /// <summary>
        /// Desc:速度下限值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public short N_MIN_SPEED {get;set;}

        /// <summary>
        /// Desc:偏差上限值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_MAX_DEVIATION {get;set;}

        /// <summary>
        /// Desc:偏差下限值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_MIN_DEVIATION {get;set;}

        /// <summary>
        /// Desc:超限等级(0,1,2,3,4 对应Ⅰ、Ⅱ、Ⅲ、Ⅳ) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool N_LEVEL {get;set;}

        /// <summary>
        /// Desc:扣分值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public short N_SCORE {get;set;}

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
