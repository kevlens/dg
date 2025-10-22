using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class LEDGER_LEVELCROSS_PIPE_LINE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:线路编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_CODE {get;set;}

        /// <summary>
        /// Desc:线路名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME {get;set;}

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
        /// Desc:运营状况 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OPERATE_STATU {get;set;}

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
        /// Desc:看守单位 
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
        /// Desc:限界架 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BOUNDARY_FRAME {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEMO {get;set;}

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
