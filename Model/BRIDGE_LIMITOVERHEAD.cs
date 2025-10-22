using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_LIMITOVERHEAD
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LIMITOVERHEAD_ID {get;set;}

        /// <summary>
        /// Desc:工务段代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GWD_CODE {get;set;}

        /// <summary>
        /// Desc:车间代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_CODE {get;set;}

        /// <summary>
        /// Desc:工区代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_CODE {get;set;}

        /// <summary>
        /// Desc:线号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LINE_CODE {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:中心里程 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public Double CENTER_MILE {get;set;}

        /// <summary>
        /// Desc:运营状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RUN_STATUS {get;set;}

        /// <summary>
        /// Desc:孔跨式样 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HOLESPAN_STYLE {get;set;}

        /// <summary>
        /// Desc:桥涵净高(m) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CULVERT_CLEANHEIGHT {get;set;}

        /// <summary>
        /// Desc:公路对应桥跨梁类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CROSS_TYPE {get;set;}

        /// <summary>
        /// Desc:公路对应桥跨孔别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CROSS_HOLETYPE {get;set;}

        /// <summary>
        /// Desc:结构型式标准 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STRUCTSTYLE_STAND {get;set;}

        /// <summary>
        /// Desc:结构型式简易 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STRUCTSTYLE_SIMPLE {get;set;}

        /// <summary>
        /// Desc:限高防护架处数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? LIMITOVERHEAD_NUM {get;set;}

        /// <summary>
        /// Desc:限高防护架净高(m) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LIMITOVERHEAD_CLEANHEIGHT {get;set;}

        /// <summary>
        /// Desc:限高防护架限高牌上数字 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? LIMITCARD_NUM {get;set;}

        /// <summary>
        /// Desc:限高防护架净宽(m)（左） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? CLEANWIDTH_LEFT {get;set;}

        /// <summary>
        /// Desc:限高防护架净宽(m)（右） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? CLEANWIDTH_RIGHT {get;set;}

        /// <summary>
        /// Desc:限高架中心距桥涵外侧距离（左） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? DISTANCE_LEFT {get;set;}

        /// <summary>
        /// Desc:限高架中心距桥涵外侧距离（右） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? DISTANCE_RIGHT {get;set;}

        /// <summary>
        /// Desc:是否经常被撞 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIT_IF {get;set;}

        /// <summary>
        /// Desc:公路路面宽度(m) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? ROAD_WIDTH {get;set;}

        /// <summary>
        /// Desc:下穿路面材质 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ROAD_MATERIAL {get;set;}

        /// <summary>
        /// Desc:公路等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ROAD_LEVEL {get;set;}

        /// <summary>
        /// Desc:公路名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ROAD_NAME {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
