using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class HRAIL_PROBLEM_DYN
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PROBLEM_ID {get;set;}

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
        /// Desc:线代码 
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
        /// Desc:线别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_CAT {get;set;}

        /// <summary>
        /// Desc:病害里程 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public Double PRO_MILE {get;set;}

        /// <summary>
        /// Desc:病害结束里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? PRO_MILE_END {get;set;}

        /// <summary>
        /// Desc:延长（m） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? EXTEND_LEN {get;set;}

        /// <summary>
        /// Desc:车站号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_CODE {get;set;}

        /// <summary>
        /// Desc:股道号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CODE {get;set;}

        /// <summary>
        /// Desc:道岔号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUT_CODE {get;set;}

        /// <summary>
        /// Desc:桥隧设备名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EQU_NAME {get;set;}

        /// <summary>
        /// Desc:桥隧设备号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EQU_CODE {get;set;}

        /// <summary>
        /// Desc:设备单元号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UNIT_NO {get;set;}

        /// <summary>
        /// Desc:线形（直、曲） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_SHARP {get;set;}

        /// <summary>
        /// Desc:线路特征（直线、曲线、道岔、桥、隧、涵、道口、短链、长链...） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_FEATURE {get;set;}

        /// <summary>
        /// Desc:股别（左，右） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_DIR {get;set;}

        /// <summary>
        /// Desc:侧别（锚固螺栓失效：内、外；曲线正矢：南、北侧） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SIDE_DIR {get;set;}

        /// <summary>
        /// Desc:轨道板号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_SLAB_NO {get;set;}

        /// <summary>
        /// Desc:承轨台号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SUPPORT_TRACK_NO {get;set;}

        /// <summary>
        /// Desc:铁号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIL_NO {get;set;}

        /// <summary>
        /// Desc:专项问题类别（轨缝、焊缝平直度、胶接绝缘拉开、螺栓锈蚀、锚固螺栓失效、失效枕木、凸型挡台周围填充树脂窜出、道床缺砟、道岔设备质量、曲线正矢超保养、道岔超临修、线路超临修、线路钢轨硬弯、线路基础沉降、钢轨伤损、副本预应力钢棒断裂、其他设备） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SPECIAL_PRO {get;set;}

        /// <summary>
        /// Desc:问题类别（线路、道岔、调节器、精测网、桥粱、隧道、路基、防灾、其它） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRO_CAT {get;set;}

        /// <summary>
        /// Desc:项目 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRO_ITEM {get;set;}

        /// <summary>
        /// Desc:病害代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRO_CODE {get;set;}

        /// <summary>
        /// Desc:病害名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRO_NAME {get;set;}

        /// <summary>
        /// Desc:单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRO_UNIT {get;set;}

        /// <summary>
        /// Desc:（病害）具体位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRO_PLACE {get;set;}

        /// <summary>
        /// Desc:病害幅值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? PRO_PEAK {get;set;}

        /// <summary>
        /// Desc:病害描述（详情） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRO_DETAIL {get;set;}

        /// <summary>
        /// Desc:超限等级。0表示不超限，动态：1,2,3,4 对应Ⅰ,Ⅱ,Ⅲ,Ⅳ, 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? OVERRUN_LEVEL {get;set;}

        /// <summary>
        /// Desc:伤损级别(问题级别) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRO_LEVEL {get;set;}

        /// <summary>
        /// Desc:问题等级（A、B）A：影响行车安全，B：不影响行车安全 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRO_GRADE {get;set;}

        /// <summary>
        /// Desc:问题状态(0:默认，1：问题，3:问题已消号且问题未抽检；7：问题已消号且问题已抽检 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? PRO_STATUS {get;set;}

        /// <summary>
        /// Desc:速度等级（-1:其它站线，0::0-120，1:120-160，2:160-200，3:200-250，4:250-350，5:350以上） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool SPEED {get;set;}

        /// <summary>
        /// Desc:速度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? SPEED2 {get;set;}

        /// <summary>
        /// Desc:车型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRAIN_MODEL {get;set;}

        /// <summary>
        /// Desc:车次 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRAIN_NO {get;set;}

        /// <summary>
        /// Desc:机车号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LOCO_NO {get;set;}

        /// <summary>
        /// Desc:检查计划号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_PLAN_ID {get;set;}

        /// <summary>
        /// Desc:检查部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_DEPT {get;set;}

        /// <summary>
        /// Desc:检查人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_MAN {get;set;}

        /// <summary>
        /// Desc:检查人职务 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_MAN_POST {get;set;}

        /// <summary>
        /// Desc:检查日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CHECK_DATE {get;set;}

        /// <summary>
        /// Desc:检查类型（静态、动态） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_TYPE {get;set;}

        /// <summary>
        /// Desc:检测设备（车载、便携、轨检车、动检车、探伤车、人工添乘、TQI） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_DEV {get;set;}

        /// <summary>
        /// Desc:检查类别（几何尺寸、结构检查、探伤、其它） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_CATE {get;set;}

        /// <summary>
        /// Desc:作业计划号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_PLAN_ID {get;set;}

        /// <summary>
        /// Desc:(整修)现场情况 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_SCENE {get;set;}

        /// <summary>
        /// Desc:是否重复（0：不重复；1：重复） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Byte? REPEAT_NUM {get;set;}

        /// <summary>
        /// Desc:整修日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? REPAIR_DATE {get;set;}

        /// <summary>
        /// Desc:整修负责人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_MAN {get;set;}

        /// <summary>
        /// Desc:整治结果 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_RES {get;set;}

        /// <summary>
        /// Desc:抽检日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? RANDOM_INS_DATE {get;set;}

        /// <summary>
        /// Desc:抽检部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RANDOM_INS_DEPT {get;set;}

        /// <summary>
        /// Desc:抽检人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RANDOM_INS_NAME {get;set;}

        /// <summary>
        /// Desc:抽检结果描述 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RANDOM_INS_RES {get;set;}

        /// <summary>
        /// Desc:抽检后问题状态：1：抽检合格；2：抽检不合格问题 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool RANDOM_INS_STATUS {get;set;}

        /// <summary>
        /// Desc:销号方式（1：人工销号；2：计划销号） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool CLEAR_TYPE {get;set;}

        /// <summary>
        /// Desc:销号日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CLEAR_DATE {get;set;}

        /// <summary>
        /// Desc:问题审批状态（0：未审批；1：通过审批；2：未通过审批） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool AUDIT_STATUS {get;set;}

        /// <summary>
        /// Desc:审批人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AUDIT_MAN {get;set;}

        /// <summary>
        /// Desc:审批日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? AUDIT_DATE {get;set;}

        /// <summary>
        /// Desc:问题扣分 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? SCORE {get;set;}

        /// <summary>
        /// Desc:预警标志（0：默认，1：预警） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool WARN_FLAG {get;set;}

        /// <summary>
        /// Desc:是否有效（Y、N）默认 Y 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EFF_FLAG {get;set;}

        /// <summary>
        /// Desc:标识 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MARK {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

        /// <summary>
        /// Desc:入库时间 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public DateTime CRT_TM {get;set;}

        /// <summary>
        /// Desc:录入人 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CRT_NAME {get;set;}

    }
}
