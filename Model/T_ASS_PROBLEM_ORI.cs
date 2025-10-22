using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_PROBLEM_ORI
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
        /// Desc:线号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_CODE {get;set;}

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
        /// Desc:线形 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_SHARP {get;set;}

        /// <summary>
        /// Desc:线路特征（曲线、道岔、桥、隧、涵、道口、短链、长链...） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_FEATURE {get;set;}

        /// <summary>
        /// Desc:车站号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_STATION_CODE {get;set;}

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
        /// Desc:病害里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_PRO_MILE {get;set;}

        /// <summary>
        /// Desc:延长（m） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_EXTEND_LEN {get;set;}

        /// <summary>
        /// Desc:病害位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_PLACE {get;set;}

        /// <summary>
        /// Desc:病害峰值 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public Single N_PRO_PEAK {get;set;}

        /// <summary>
        /// Desc:TQI值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single N_TQI_VAL {get;set;}

        /// <summary>
        /// Desc:病害详情 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_DETAIL {get;set;}

        /// <summary>
        /// Desc:超限等级。0表示不超限，动态：1,2,3,4 对应Ⅰ,Ⅱ,Ⅲ,Ⅳ,人工静态：1作业验收，2：经常保养，3：临时补修 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public bool N_OVERRUN_LEVEL {get;set;}

        /// <summary>
        /// Desc:问题级别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PRO_LEVEL {get;set;}

        /// <summary>
        /// Desc:重复次数（对动态检测设备有效，其它检测类型默认为0） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Byte? N_REPEAT_NUM {get;set;}

        /// <summary>
        /// Desc:速度等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_SPEED {get;set;}

        /// <summary>
        /// Desc:速度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_SPEED2 {get;set;}

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
        /// Desc:检查类型（静态、动态） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CHECK_TYPE {get;set;}

        /// <summary>
        /// Desc:检测设备（人工、车载、便携、轨检车、轨检仪、电子道尺、人工添乘、TQI） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CHECK_DEV {get;set;}

        /// <summary>
        /// Desc:是否有效（Y、N）默认 Y 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_EFF_FLAG {get;set;}

        /// <summary>
        /// Desc:问题扣分 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_SCORE {get;set;}

        /// <summary>
        /// Desc:标识 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MARK {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

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
        /// Desc:问题状态(0:默认，1：问题，3:问题且问题已消号且问题未抽检；7：问题且问题已消号且问题已抽检 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_PRO_STATUS {get;set;}

        /// <summary>
        /// Desc:计划工单号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_JOB_NO {get;set;}

        /// <summary>
        /// Desc:历史工单号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_HIS_JOB_NO {get;set;}

        /// <summary>
        /// Desc:整修日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? D_REPAIR_DATE {get;set;}

        /// <summary>
        /// Desc:整修人或整修负责人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_REPAIR_MAN {get;set;}

        /// <summary>
        /// Desc:整治结果 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_REPAIR_RES {get;set;}

        /// <summary>
        /// Desc:抽检日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? D_RANDOM_INS_DATE {get;set;}

        /// <summary>
        /// Desc:抽检人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_RANDOM_INS_NAME {get;set;}

        /// <summary>
        /// Desc:抽检结果描述 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_RANDOM_INS_RES {get;set;}

        /// <summary>
        /// Desc:抽检后问题状态：1：抽检合格；2：抽检不合格问题 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool C_RANDOM_INS_STATUS {get;set;}

        /// <summary>
        /// Desc:销号方式（1：人工销号；2：计划销号） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool N_CLEAR_TYPE {get;set;}

        /// <summary>
        /// Desc:逻辑删除标记（0:未删除；1：已删除） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool N_DELETE_FLAG {get;set;}

        /// <summary>
        /// Desc:复核情况 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COMPOSITE {get;set;}

    }
}
