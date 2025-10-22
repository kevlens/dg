using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_PROBLEM
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:工务段代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_GWD_CODE {get;set;}

        /// <summary>
        /// Desc:单位编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_DEP_CODE {get;set;}

        /// <summary>
        /// Desc:单位名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_DEP_NAME {get;set;}

        /// <summary>
        /// Desc:单位属性 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_DEP_PROP {get;set;}

        /// <summary>
        /// Desc:线号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_CODE {get;set;}

        /// <summary>
        /// Desc:线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_NAME {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_DIR {get;set;}

        /// <summary>
        /// Desc:线别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_CAT {get;set;}

        /// <summary>
        /// Desc:车站号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_STATION_CODE {get;set;}

        /// <summary>
        /// Desc:车站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_STATION_NAME {get;set;}

        /// <summary>
        /// Desc:股道编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TRACK_CODE {get;set;}

        /// <summary>
        /// Desc:道岔编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TURNOUT_CODE {get;set;}

        /// <summary>
        /// Desc:项目 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_ITEM {get;set;}

        /// <summary>
        /// Desc:病害类型代码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_PRO_CODE {get;set;}

        /// <summary>
        /// Desc:病害类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_NAME {get;set;}

        /// <summary>
        /// Desc:病害里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_PRO_MILE {get;set;}

        /// <summary>
        /// Desc:病害位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_PLACE {get;set;}

        /// <summary>
        /// Desc:病害详情 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_DETAIL {get;set;}

        /// <summary>
        /// Desc:病害峰值 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public Single N_PRO_PEAK {get;set;}

        /// <summary>
        /// Desc:超限等级(0,1,2,3,4 对应Ⅰ,Ⅱ,Ⅲ,Ⅳ),0表示不超限，人工静态：1作业验收，2：经常保养，3：临时补修 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool N_OVERRUN_LEVEL {get;set;}

        /// <summary>
        /// Desc:问题级别(一般、严重、特别严重) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_LEVEL {get;set;}

        /// <summary>
        /// Desc:速度等级(-1,0,1,2,3) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_SPEED {get;set;}

        /// <summary>
        /// Desc:检查人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_INSPECTOR {get;set;}

        /// <summary>
        /// Desc:检查人职务 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_POST {get;set;}

        /// <summary>
        /// Desc:检查日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? D_CHECK_DATE {get;set;}

        /// <summary>
        /// Desc:是否生成工单（Y、N）默认 N 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_JOB_FLAG {get;set;}

        /// <summary>
        /// Desc:工单号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_JOB_NO {get;set;}

        /// <summary>
        /// Desc:是否整修（Y、N）默认 N 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_REPAIR_FLAG {get;set;}

        /// <summary>
        /// Desc:整修日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? D_REPAIR_DATE {get;set;}

        /// <summary>
        /// Desc:整治结果 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_REPAIR_RES {get;set;}

        /// <summary>
        /// Desc:检查类型（静态、动态） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CHECK_TYPE {get;set;}

        /// <summary>
        /// Desc:检测设备（人工、车载、便携、轨检车、轨检仪...） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CHECK_DEV {get;set;}

        /// <summary>
        /// Desc:消号、归档标志（Y、N） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_DOC_FLAG {get;set;}

        /// <summary>
        /// Desc:创建日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? T_CRT_TM {get;set;}

        /// <summary>
        /// Desc:创建人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CRT_NAME {get;set;}

        /// <summary>
        /// Desc:更新日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? T_UPD_TM {get;set;}

        /// <summary>
        /// Desc:更新人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string T_UPD_NAME {get;set;}

        /// <summary>
        /// Desc:是否有效（Y、N）默认 Y 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_EFF_FLAG {get;set;}

        /// <summary>
        /// Desc:有效起始时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? T_EFF_TM {get;set;}

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

        /// <summary>
        /// Desc:车次 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TRAIN_NO {get;set;}

        /// <summary>
        /// Desc:机车号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LOCO_NO {get;set;}

        /// <summary>
        /// Desc:标识 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MARK {get;set;}

        /// <summary>
        /// Desc:车型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_TRAIN_MODEL {get;set;}

        /// <summary>
        /// Desc:是否动车 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_IS_MOTOR_CAR {get;set;}

        /// <summary>
        /// Desc:线形 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_SHARP {get;set;}

        /// <summary>
        /// Desc:处理标记 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_ACCESS_FLAG {get;set;}

        /// <summary>
        /// Desc:处理日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? T_ACCESS_DATE {get;set;}

        /// <summary>
        /// Desc:重复次数（对动态检测设备车载、便携有效，其它检测类型默认为0） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Byte? N_REPEAT_NUM {get;set;}

        /// <summary>
        /// Desc:历史单号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_HIS_JOB_NO {get;set;}

        /// <summary>
        /// Desc:参与工单次数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Byte? C_HIS_JOB_NUM {get;set;}

        /// <summary>
        /// Desc:线路特征（曲线、道岔） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_FEATURE {get;set;}

    }
}
