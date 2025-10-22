using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_OVERPASS
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string OVERPASS_ID {get;set;}

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
        /// Desc:上跨铁路主桥孔跨式样 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HOLESPAN_STYLE {get;set;}

        /// <summary>
        /// Desc:桥下线路数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? BELOW_LINENUM {get;set;}

        /// <summary>
        /// Desc:桥下线路名称及里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BELOW_LINENAME {get;set;}

        /// <summary>
        /// Desc:线路中心距桥墩最小距离左侧(m) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single DISTANCE_LEFT {get;set;}

        /// <summary>
        /// Desc:线路中心距桥墩最小距离右侧(m) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single DISTANCE_RIGHT {get;set;}

        /// <summary>
        /// Desc:钢轨顶面距梁底最小距离(m) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DISTANCE_BELOW {get;set;}

        /// <summary>
        /// Desc:主桥防护栏类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GUARD_TYPE {get;set;}

        /// <summary>
        /// Desc:防撞等级是否满足 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GUARD_LEVEL_IF {get;set;}

        /// <summary>
        /// Desc:防落物网(有/无） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROTECTNET_TYPE {get;set;}

        /// <summary>
        /// Desc:防落物网长*高 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROTECTNET_LENHEIGHT {get;set;}

        /// <summary>
        /// Desc:引道防护设施类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROTECTNET_FACTYPE {get;set;}

        /// <summary>
        /// Desc:引道防护设施是否安全 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROTECTNET_SECURE {get;set;}

        /// <summary>
        /// Desc:引道防护设施高度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? ANTIWALL_HEIGHT {get;set;}

        /// <summary>
        /// Desc:道路等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ROAD_LEVEL {get;set;}

        /// <summary>
        /// Desc:道路名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ROAD_NAME {get;set;}

        /// <summary>
        /// Desc:桥梁产权部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROPERTY_RIGHT {get;set;}

        /// <summary>
        /// Desc:所属地省别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BELONG_PROVINCE {get;set;}

        /// <summary>
        /// Desc:所属地市别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BELONG_CITY {get;set;}

        /// <summary>
        /// Desc:是否移交 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRANSFER_IF {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
