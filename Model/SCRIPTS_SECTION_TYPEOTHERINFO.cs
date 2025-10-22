using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class SCRIPTS_SECTION_TYPEOTHERINFO
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string INFO_ID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string TYPE_ID {get;set;}

        /// <summary>
        /// Desc:线名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:中心里程坐标 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_CENTER {get;set;}

        /// <summary>
        /// Desc:开始里程坐标 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_BEGIN {get;set;}

        /// <summary>
        /// Desc:结束里程坐标 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_END {get;set;}

        /// <summary>
        /// Desc:火星经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARSLONGITUDE {get;set;}

        /// <summary>
        /// Desc:火星纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARSLATITUDE {get;set;}

        /// <summary>
        /// Desc:详情 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INFO_NOTE {get;set;}

        /// <summary>
        /// Desc:部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:部门名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_NAME {get;set;}

        /// <summary>
        /// Desc:通道门编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOOR_NUM {get;set;}

        /// <summary>
        /// Desc:上一个通道门里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOOR_NUM_UP {get;set;}

        /// <summary>
        /// Desc:下一个通道门里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOOR_NUM_DOWN {get;set;}

        /// <summary>
        /// Desc:钥匙管理单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOOR_GLDEPT {get;set;}

        /// <summary>
        /// Desc:钥匙管理单位联系电话 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOOR_GLDEPT_PHONE {get;set;}

        /// <summary>
        /// Desc:所属派出所 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOOR_POLICE {get;set;}

        /// <summary>
        /// Desc:所属派出所联系电话 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOOR_POLICE_PHONE {get;set;}

        /// <summary>
        /// Desc:限速区段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SPEED_LINE {get;set;}

        /// <summary>
        /// Desc:限速 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SPEED_LIMIT {get;set;}

        /// <summary>
        /// Desc:限速原因 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SPEED_CAUSE {get;set;}

        /// <summary>
        /// Desc:顺号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_NUM {get;set;}

        /// <summary>
        /// Desc:水库名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_NAME {get;set;}

        /// <summary>
        /// Desc:所在地点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_ADDR {get;set;}

        /// <summary>
        /// Desc:汇水面积 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_WAREA {get;set;}

        /// <summary>
        /// Desc:河道安全泄量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_SAFE {get;set;}

        /// <summary>
        /// Desc:区间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_BETWEEN {get;set;}

        /// <summary>
        /// Desc:里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_MILE {get;set;}

        /// <summary>
        /// Desc:距离 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_DIS {get;set;}

        /// <summary>
        /// Desc:可能影响范围 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_DISAREA {get;set;}

        /// <summary>
        /// Desc:桥涵孔径及排洪能力 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_BRIABLE {get;set;}

        /// <summary>
        /// Desc:水库设计标准 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_STAD {get;set;}

        /// <summary>
        /// Desc:水库设计水位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_WATERLD {get;set;}

        /// <summary>
        /// Desc:水库设计库容 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_CAPD {get;set;}

        /// <summary>
        /// Desc:水库设计下泄量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_DISCHARGED {get;set;}

        /// <summary>
        /// Desc:水库校核标准 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_STAC {get;set;}

        /// <summary>
        /// Desc:水库校核水位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_WATERLC {get;set;}

        /// <summary>
        /// Desc:水库校核库容 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_CAPC {get;set;}

        /// <summary>
        /// Desc:水库校核下泄量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_DISCHARGEC {get;set;}

        /// <summary>
        /// Desc:汛期运用汛前限制水位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_FLOODW {get;set;}

        /// <summary>
        /// Desc:汛期运用相应库容 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_FLOODCAP {get;set;}

        /// <summary>
        /// Desc:主坝型式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_TYPE {get;set;}

        /// <summary>
        /// Desc:主坝坝顶高程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_DAMH {get;set;}

        /// <summary>
        /// Desc:主坝防浪墙高程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_WALLH {get;set;}

        /// <summary>
        /// Desc:主坝最大坝高 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_DAMAXH {get;set;}

        /// <summary>
        /// Desc:主坝坝顶长 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_DAML {get;set;}

        /// <summary>
        /// Desc:溢洪道堰顶高程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_YANH {get;set;}

        /// <summary>
        /// Desc:溢洪道闸门型式及尺寸 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_GATETYPE {get;set;}

        /// <summary>
        /// Desc:溢洪道最大泄量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_DISCHARM {get;set;}

        /// <summary>
        /// Desc:放水管进口高程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_INH {get;set;}

        /// <summary>
        /// Desc:放水管孔径 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_RADIUS {get;set;}

        /// <summary>
        /// Desc:放水管最大泄量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_DISCHARMO {get;set;}

        /// <summary>
        /// Desc:水库等别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_LEL {get;set;}

        /// <summary>
        /// Desc:管理单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_MAN {get;set;}

        /// <summary>
        /// Desc:联络方式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_TEL {get;set;}

        /// <summary>
        /// Desc:存在问题 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_PRO {get;set;}

        /// <summary>
        /// Desc:是否病险 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_ISHEA {get;set;}

        /// <summary>
        /// Desc:防范措施 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_PROTE {get;set;}

        /// <summary>
        /// Desc:检查人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_CHECK {get;set;}

        /// <summary>
        /// Desc:包保干部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_LEAD {get;set;}

        /// <summary>
        /// Desc:检查时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? A_TIME {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_MEMO {get;set;}

        /// <summary>
        /// Desc:线别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_LINENAME {get;set;}

        /// <summary>
        /// Desc:侧别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string A_LINEDIR {get;set;}

    }
}
