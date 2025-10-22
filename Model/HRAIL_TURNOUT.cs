using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class HRAIL_TURNOUT
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string TURNOUT_ID {get;set;}

        /// <summary>
        /// Desc:工务段代码 
        /// Default:- 
        /// Nullable:False 
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
        /// Desc:线编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LINE_CODE {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:车站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME {get;set;}

        /// <summary>
        /// Desc:车站号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string STATION_CODE {get;set;}

        /// <summary>
        /// Desc:线别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_CAT {get;set;}

        /// <summary>
        /// Desc:运营状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RUN_STATUS {get;set;}

        /// <summary>
        /// Desc:道岔编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string TURNOUT_NO {get;set;}

        /// <summary>
        /// Desc:道岔类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUT_TYPE {get;set;}

        /// <summary>
        /// Desc:轨距类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_TYPE {get;set;}

        /// <summary>
        /// Desc:种类 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string GAUGE_MODEL {get;set;}

        /// <summary>
        /// Desc:交分标记 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CROSS_MARK {get;set;}

        /// <summary>
        /// Desc:左右开 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEFTRIGHT_OPEN {get;set;}

        /// <summary>
        /// Desc:轨型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIL_TYPE {get;set;}

        /// <summary>
        /// Desc:辙叉号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FROG_NO {get;set;}

        /// <summary>
        /// Desc:辙叉构造 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FROG_STRUCTURE {get;set;}

        /// <summary>
        /// Desc:辙叉长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? FROG_LENGTH {get;set;}

        /// <summary>
        /// Desc:尖轨类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BLADE_TYPE {get;set;}

        /// <summary>
        /// Desc:左尖轨长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? BLADE_LEFTLEN {get;set;}

        /// <summary>
        /// Desc:右尖轨长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? BLADE_RIGHTLEN {get;set;}

        /// <summary>
        /// Desc:道岔全长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? TURNOUT_LENGTH {get;set;}

        /// <summary>
        /// Desc:扳道器种类 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SWITCH_TYPE {get;set;}

        /// <summary>
        /// Desc:联锁类别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LOCK_TYPE {get;set;}

        /// <summary>
        /// Desc:岔枕根数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? BRANCH_NUM {get;set;}

        /// <summary>
        /// Desc:普枕根数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? GENERAL_NUM {get;set;}

        /// <summary>
        /// Desc:混凝土枕根数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? CONCRETE_NUM {get;set;}

        /// <summary>
        /// Desc:不符技规 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_NORULE {get;set;}

        /// <summary>
        /// Desc:尖轨尖里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? BLADE_MILE {get;set;}

        /// <summary>
        /// Desc:直向速度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? H_SPEED {get;set;}

        /// <summary>
        /// Desc:侧向速度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? V_SPEED {get;set;}

        /// <summary>
        /// Desc:铺设年度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LAY_YEAR {get;set;}

        /// <summary>
        /// Desc:设计总图号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_NO {get;set;}

        /// <summary>
        /// Desc:过渡枕类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRANPILLOW_TYPE {get;set;}

        /// <summary>
        /// Desc:过渡枕数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? TRANPILLOW_NUM {get;set;}

        /// <summary>
        /// Desc:岔前轨长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? FORKFRONT_RAILLEN {get;set;}

        /// <summary>
        /// Desc:岔后轨长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? FORKAFTER_RAILLEN {get;set;}

        /// <summary>
        /// Desc:岔尾里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? FORKEND_MILE {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
