using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class TURNOUT_BASE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string TURNOUT_ID {get;set;}

        /// <summary>
        /// Desc:单位编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ORG_CODE {get;set;}

        /// <summary>
        /// Desc:线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NO {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIRECTION {get;set;}

        /// <summary>
        /// Desc:车站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION {get;set;}

        /// <summary>
        /// Desc:车站编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_CODE {get;set;}

        /// <summary>
        /// Desc:线别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_TYPE {get;set;}

        /// <summary>
        /// Desc:道岔编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string TURNOUT_NO {get;set;}

        /// <summary>
        /// Desc:道岔种类 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUT_TYPE {get;set;}

        /// <summary>
        /// Desc:轨枕类别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SKEEOERS_TYPE {get;set;}

        /// <summary>
        /// Desc:轨型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUT_CATE {get;set;}

        /// <summary>
        /// Desc:辙叉号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FROG_NO {get;set;}

        /// <summary>
        /// Desc:辙叉构造 
        /// Default:- 
        /// Nullable:True 
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
        public long TURNOUT_LENGTH {get;set;}

        /// <summary>
        /// Desc:扳道器种类 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SWITCH_TYPE {get;set;}

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
        /// Desc:设计总图号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DESIGN_DRAWNO {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUT_NOTE {get;set;}

        /// <summary>
        /// Desc:供应厂家 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUT_FAC {get;set;}

        /// <summary>
        /// Desc:测量设计人员 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEASURER {get;set;}

        /// <summary>
        /// Desc:测量人职务 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEASURER_DUTY {get;set;}

        /// <summary>
        /// Desc:预铺负责人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LAYER {get;set;}

        /// <summary>
        /// Desc:预铺人职务 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LAYER_DUTY {get;set;}

        /// <summary>
        /// Desc:预铺时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? LAYER_TIME {get;set;}

        /// <summary>
        /// Desc:上线负责人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ONLINER {get;set;}

        /// <summary>
        /// Desc:上线人职务 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ONLINE_DUTY {get;set;}

        /// <summary>
        /// Desc:上线时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? ONLINE_TIME {get;set;}

        /// <summary>
        /// Desc:验收人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECKER {get;set;}

        /// <summary>
        /// Desc:验收人职务 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECKER_DUTY {get;set;}

        /// <summary>
        /// Desc:轨枕厂家 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SKEEOERS_FACTORY {get;set;}

        /// <summary>
        /// Desc:轨枕上线时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? SKEEOERS_ONLINE {get;set;}

        /// <summary>
        /// Desc:轨枕伤损 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SKEEOERS_DAMAGE {get;set;}

        /// <summary>
        /// Desc:轨枕更换时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? SKEEOERS_REPLACETIME {get;set;}

        /// <summary>
        /// Desc:基本轨上线时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? STOCK_ONLINE {get;set;}

        /// <summary>
        /// Desc:基本轨更换时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? STOCK_REPLACETIME {get;set;}

        /// <summary>
        /// Desc:尖轨上线时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? BLADE_ONLINE {get;set;}

        /// <summary>
        /// Desc:开向 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BLADE_DIRECT {get;set;}

        /// <summary>
        /// Desc:尖轨图号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BLADE_DRAWNO {get;set;}

        /// <summary>
        /// Desc:尖轨通过总重 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? BLADE_WEIGHT {get;set;}

        /// <summary>
        /// Desc:尖轨更换时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? BLADE_REPLACETIME {get;set;}

        /// <summary>
        /// Desc:辙叉厂家 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FROG_FACTORY {get;set;}

        /// <summary>
        /// Desc:辙叉上线时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? FROG_ONLINE {get;set;}

        /// <summary>
        /// Desc:辙叉图号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FROG_DRAWNO {get;set;}

        /// <summary>
        /// Desc:辙叉通过总重 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? FROG_WEIGHT {get;set;}

        /// <summary>
        /// Desc:辙叉更换时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? FROG_REPLACETIME {get;set;}

        /// <summary>
        /// Desc:年度通过总重 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? ANNUAL_WEIGHT {get;set;}

        /// <summary>
        /// Desc:累计通过总重 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? TOTAL_WEIGHT {get;set;}

        /// <summary>
        /// Desc:记事 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_NOTE {get;set;}

        /// <summary>
        /// Desc:是否拆除（0、未拆除，1、已拆除） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool REMOVE_FLAG {get;set;}

        /// <summary>
        /// Desc:岔枕图片 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SLEEPER_PICURL {get;set;}

        /// <summary>
        /// Desc:钢轨图片 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIL_PICURL {get;set;}

        /// <summary>
        /// Desc:工区编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_DEP_CODE {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

        /// <summary>
        /// Desc:联锁类别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LOCK_TYPE {get;set;}

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
        public Double? N_SWITCH_RAIL_MILE {get;set;}

        /// <summary>
        /// Desc:交分标记（F1、F2、F5...） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CROSS_MARK {get;set;}

        /// <summary>
        /// Desc:道岔类型（Ⅲ型 、提速、其它） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TURNOUT_TYPE {get;set;}

        /// <summary>
        /// Desc:轨距类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_GAUGE_TYPE {get;set;}

        /// <summary>
        /// Desc:运营状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_RUN_STATUS {get;set;}

        /// <summary>
        /// Desc:线编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NUM {get;set;}

    }
}
