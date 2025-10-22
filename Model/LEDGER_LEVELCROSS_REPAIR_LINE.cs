using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class LEDGER_LEVELCROSS_REPAIR_LINE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:车站编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_CODE {get;set;}

        /// <summary>
        /// Desc:专用线接入车站名（地点） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME {get;set;}

        /// <summary>
        /// Desc:线别编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINEDIR_CODE {get;set;}

        /// <summary>
        /// Desc:线别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINEDIR_NAME {get;set;}

        /// <summary>
        /// Desc:道口里程（名称） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVELCROSS_KM {get;set;}

        /// <summary>
        /// Desc:铺面材料 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PAVING_MATERIAL {get;set;}

        /// <summary>
        /// Desc:铺面宽度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? PAVEMENT_WIDTH {get;set;}

        /// <summary>
        /// Desc:栏杆种类 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIL_TYPE {get;set;}

        /// <summary>
        /// Desc:报警装置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ALARM_DEVICE {get;set;}

        /// <summary>
        /// Desc:视频监控安装 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string VIDEO_INSTALLATE {get;set;}

        /// <summary>
        /// Desc:道口性质 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CROSSE_NATURE {get;set;}

        /// <summary>
        /// Desc:产权（看守）单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PROPERTY_UNIT {get;set;}

        /// <summary>
        /// Desc:道机联控 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ROADJOINT_CONTROL {get;set;}

        /// <summary>
        /// Desc:跨越股道数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? ACROSS_TRACKS {get;set;}

        /// <summary>
        /// Desc:道路类别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ROAD_TYPE {get;set;}

        /// <summary>
        /// Desc:道路名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ROAD_NAME {get;set;}

        /// <summary>
        /// Desc:是否通行大客车、校车、公交车 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string IF_PASS {get;set;}

        /// <summary>
        /// Desc:道口标志 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ROAD_FLAG {get;set;}

        /// <summary>
        /// Desc:护桩和栅栏 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RETAIN_FENCES {get;set;}

        /// <summary>
        /// Desc:防护（警示）标志 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOOR_FLAG {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEMO {get;set;}

        /// <summary>
        /// Desc:资产 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ASSETS {get;set;}

        /// <summary>
        /// Desc:部门编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:录入时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? INPUT_DATE {get;set;}

        /// <summary>
        /// Desc:录入人员 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INPUT_USER {get;set;}

    }
}
