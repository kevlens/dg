using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_SHALLOW_FOUNDATION
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string FOUNDATION_ID {get;set;}

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
        /// Desc:桥名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BRIDGE_NAME {get;set;}

        /// <summary>
        /// Desc:桥隧号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BRIDGE_CODE {get;set;}

        /// <summary>
        /// Desc:全长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? FULL_LENGTH {get;set;}

        /// <summary>
        /// Desc:孔跨式样 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HOLESPAN_STYLE {get;set;}

        /// <summary>
        /// Desc:浅基墩台号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PIER_NUM {get;set;}

        /// <summary>
        /// Desc:梁底标高 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? BOTTOM_ELEVATION {get;set;}

        /// <summary>
        /// Desc:轨底标高 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? RAILBOTTOM_ELEVATION {get;set;}

        /// <summary>
        /// Desc:基底标高 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? BASE_ELEVATION {get;set;}

        /// <summary>
        /// Desc:一般冲刷线标高 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GENERALLINE_ELEVATION {get;set;}

        /// <summary>
        /// Desc:局部冲刷线标高 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LOCALLINE_ELEVATION {get;set;}

        /// <summary>
        /// Desc:河床最凹点标高或河床防护面标高 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROTECT_ELEVATION {get;set;}

        /// <summary>
        /// Desc:基础最大冲刷埋置深度（m） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BASE_DEPTH {get;set;}

        /// <summary>
        /// Desc:冲刷总深度（m） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SCOUR_DEPTH {get;set;}

        /// <summary>
        /// Desc:基底埋置安全值（m) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SAFE_VALUE {get;set;}

        /// <summary>
        /// Desc:埋深判别比（Λh） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DISCRIMINANT_RATIO {get;set;}

        /// <summary>
        /// Desc:流速（m/s） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CURRENT_SPEED {get;set;}

        /// <summary>
        /// Desc:判定等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JUDGE_LEVEL {get;set;}

        /// <summary>
        /// Desc:病害说明 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DISEASE_DEMO {get;set;}

        /// <summary>
        /// Desc:是否有冲刷 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SCOUR_IF {get;set;}

        /// <summary>
        /// Desc:是否山区铁路 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAILWAY_IF {get;set;}

        /// <summary>
        /// Desc:墩台、基础、河道是否防护 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROTECT_IF {get;set;}

        /// <summary>
        /// Desc:防护类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROTECT_TYPE {get;set;}

        /// <summary>
        /// Desc:防护材质 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROTECT_MATERIAL {get;set;}

        /// <summary>
        /// Desc:护底状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROTECT_STATU {get;set;}

        /// <summary>
        /// Desc:浅基墩台是否位于主河道 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DTWYZHD_IF {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
