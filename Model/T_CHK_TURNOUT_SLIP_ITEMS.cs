using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_CHK_TURNOUT_SLIP_ITEMS
    {
        
        /// <summary>
        /// Desc:主键 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:CHK_TURNOUT主键 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FKID {get;set;}

        /// <summary>
        /// Desc:类型 （0 甲股 1乙股) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPE {get;set;}

        /// <summary>
        /// Desc:轨距_前锐角辙叉_叉后端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_HEAD_FROGTAIL {get;set;}

        /// <summary>
        /// Desc:轨距_前锐角辙叉_叉中心 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_HEAD_FROGMID {get;set;}

        /// <summary>
        /// Desc:轨距_前锐角辙叉_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_HEAD_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:轨距_前锐角辙叉_护背距离 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_HEAD_BACKGAGE {get;set;}

        /// <summary>
        /// Desc:轨距_前双转辙器_顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_HEAD_SLOPE {get;set;}

        /// <summary>
        /// Desc:轨距_前双转辙器_尖轨尖 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_HEAD_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:轨距_前双转辙器_尖轨中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_HEAD_SWITCH {get;set;}

        /// <summary>
        /// Desc:轨距_前双转辙器_尖轨跟_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_HEAD_SWITCHHEEL_STR {get;set;}

        /// <summary>
        /// Desc:轨距_前双转辙器_尖轨跟_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_HEAD_SWITCHHEEL_CUR {get;set;}

        /// <summary>
        /// Desc:轨距_钝角辙叉_可动心_跟1 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_MOVPNHEEL1 {get;set;}

        /// <summary>
        /// Desc:轨距_钝角辙叉_可动心_中1 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_MOVPNMID1 {get;set;}

        /// <summary>
        /// Desc:轨距_钝角辙叉_短中轴 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_AXLE {get;set;}

        /// <summary>
        /// Desc:轨距_钝角辙叉_导曲线中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR {get;set;}

        /// <summary>
        /// Desc:轨距_钝角辙叉_曲中外矢 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_VERSINE {get;set;}

        /// <summary>
        /// Desc:轨距_钝角辙叉_可动心_跟2 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_MOVPNHEEL2 {get;set;}

        /// <summary>
        /// Desc:轨距_钝角辙叉_可动心_中2 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_MOVPNMID2 {get;set;}

        /// <summary>
        /// Desc:轨距_后双转辙器_尖轨跟_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_TAIL_SWITCHHEEL_STR {get;set;}

        /// <summary>
        /// Desc:轨距_后双转辙器_尖轨跟_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_TAIL_SWITCHHEEL_CUR {get;set;}

        /// <summary>
        /// Desc:轨距_后双转辙器_尖轨中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_TAIL_SWITCH {get;set;}

        /// <summary>
        /// Desc:轨距_后双转辙器_尖轨尖 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_TAIL_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:轨距_后双转辙器_顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_TAIL_SLOPE {get;set;}

        /// <summary>
        /// Desc:轨距_后锐角辙叉_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_TAIL_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:轨距_后锐角辙叉_护背距离 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_TAIL_BACKGAGE {get;set;}

        /// <summary>
        /// Desc:轨距_后锐角辙叉_叉心中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_TAIL_FROGMID {get;set;}

        /// <summary>
        /// Desc:轨距_后锐角辙叉_叉后端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_TAIL_FROGTAIL {get;set;}

        /// <summary>
        /// Desc:水平_前锐角辙叉_叉后端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_HEAD_FROGTAIL {get;set;}

        /// <summary>
        /// Desc:水平_前锐角辙叉_叉中心 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_HEAD_FROGMID {get;set;}

        /// <summary>
        /// Desc:水平_前锐角辙叉_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_HEAD_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:水平_前锐角辙叉_护背距离 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_HEAD_BACKGAGE {get;set;}

        /// <summary>
        /// Desc:水平_前双转辙器_顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_HEAD_SLOPE {get;set;}

        /// <summary>
        /// Desc:水平_前双转辙器_尖轨尖 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_HEAD_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:水平_前双转辙器_尖轨中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_HEAD_SWITCH {get;set;}

        /// <summary>
        /// Desc:水平_前双转辙器_尖轨跟_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_HEAD_SWITCHHEEL_STR {get;set;}

        /// <summary>
        /// Desc:水平_前双转辙器_尖轨跟_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_HEAD_SWITCHHEEL_CUR {get;set;}

        /// <summary>
        /// Desc:水平_钝角辙叉_可动心_跟1 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_MOVPNHEEL1 {get;set;}

        /// <summary>
        /// Desc:水平_钝角辙叉_可动心_中1 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_MOVPNMID1 {get;set;}

        /// <summary>
        /// Desc:水平_钝角辙叉_短中轴 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_AXLE {get;set;}

        /// <summary>
        /// Desc:水平_钝角辙叉_导曲线中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR {get;set;}

        /// <summary>
        /// Desc:水平_钝角辙叉_曲中外矢 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_VERSINE {get;set;}

        /// <summary>
        /// Desc:水平_钝角辙叉_可动心_跟2 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_MOVPNHEEL2 {get;set;}

        /// <summary>
        /// Desc:水平_钝角辙叉_可动心_中2 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_MOVPNMID2 {get;set;}

        /// <summary>
        /// Desc:水平_后双转辙器_尖轨跟_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_TAIL_SWITCHHEEL_STR {get;set;}

        /// <summary>
        /// Desc:水平_后双转辙器_尖轨跟_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_TAIL_SWITCHHEEL_CUR {get;set;}

        /// <summary>
        /// Desc:水平_后双转辙器_尖轨中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_TAIL_SWITCH {get;set;}

        /// <summary>
        /// Desc:水平_后双转辙器_尖轨尖 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_TAIL_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:水平_后双转辙器_顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_TAIL_SLOPE {get;set;}

        /// <summary>
        /// Desc:水平_后锐角辙叉_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_TAIL_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:水平_后锐角辙叉_护背距离 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_TAIL_BACKGAGE {get;set;}

        /// <summary>
        /// Desc:水平_后锐角辙叉_叉心中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_TAIL_FROGMID {get;set;}

        /// <summary>
        /// Desc:水平_后锐角辙叉_叉后端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_TAIL_FROGTAIL {get;set;}

        /// <summary>
        /// Desc:三角坑_前锐角辙叉_叉后端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_HEAD_FROGTAIL {get;set;}

        /// <summary>
        /// Desc:三角坑_前锐角辙叉_叉中心 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_HEAD_FROGMID {get;set;}

        /// <summary>
        /// Desc:三角坑_前锐角辙叉_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_HEAD_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:三角坑_前锐角辙叉_护背距离 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_HEAD_BACKGAGE {get;set;}

        /// <summary>
        /// Desc:三角坑_前双转辙器_顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_HEAD_SLOPE {get;set;}

        /// <summary>
        /// Desc:三角坑_前双转辙器_尖轨尖 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_HEAD_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:三角坑_前双转辙器_尖轨中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_HEAD_SWITCH {get;set;}

        /// <summary>
        /// Desc:三角坑_前双转辙器_尖轨跟_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_HEAD_SWITCHHEEL_STR {get;set;}

        /// <summary>
        /// Desc:三角坑_前双转辙器_尖轨跟_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_HEAD_SWITCHHEEL_CUR {get;set;}

        /// <summary>
        /// Desc:三角坑_钝角辙叉_可动心_跟1 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_MOVPNHEEL1 {get;set;}

        /// <summary>
        /// Desc:三角坑_钝角辙叉_可动心_中1 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_MOVPNMID1 {get;set;}

        /// <summary>
        /// Desc:三角坑_钝角辙叉_短中轴 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_AXLE {get;set;}

        /// <summary>
        /// Desc:三角坑_钝角辙叉_导曲线中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR {get;set;}

        /// <summary>
        /// Desc:三角坑_钝角辙叉_曲中外矢 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_VERSINE {get;set;}

        /// <summary>
        /// Desc:三角坑_钝角辙叉_可动心_跟2 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_MOVPNHEEL2 {get;set;}

        /// <summary>
        /// Desc:三角坑_钝角辙叉_可动心_中2 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_MOVPNMID2 {get;set;}

        /// <summary>
        /// Desc:三角坑_后双转辙器_尖轨跟_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_TAIL_SWITCHHEEL_STR {get;set;}

        /// <summary>
        /// Desc:三角坑_后双转辙器_尖轨跟_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_TAIL_SWITCHHEEL_CUR {get;set;}

        /// <summary>
        /// Desc:三角坑_后双转辙器_尖轨中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_TAIL_SWITCH {get;set;}

        /// <summary>
        /// Desc:三角坑_后双转辙器_尖轨尖 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_TAIL_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:三角坑_后双转辙器_顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_TAIL_SLOPE {get;set;}

        /// <summary>
        /// Desc:三角坑_后锐角辙叉_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_TAIL_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:三角坑_后锐角辙叉_护背距离 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_TAIL_BACKGAGE {get;set;}

        /// <summary>
        /// Desc:三角坑_后锐角辙叉_叉心中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_TAIL_FROGMID {get;set;}

        /// <summary>
        /// Desc:三角坑_后锐角辙叉_叉后端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_TAIL_FROGTAIL {get;set;}

        /// <summary>
        /// Desc:临修日期及内容 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_TM_CONTENT {get;set;}

        /// <summary>
        /// Desc:检查时间/复检时间(必传) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CHK_TM {get;set;}

        /// <summary>
        /// Desc:经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? LNG {get;set;}

        /// <summary>
        /// Desc:纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? LAT {get;set;}

        /// <summary>
        /// Desc:火星经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARS_LNG {get;set;}

        /// <summary>
        /// Desc:火星纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARS_LAT {get;set;}

        /// <summary>
        /// Desc:百度经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? BAIDU_LNG {get;set;}

        /// <summary>
        /// Desc:百度纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? BAIDU_LAT {get;set;}

        /// <summary>
        /// Desc:GPS时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? GPS_TM {get;set;}

        /// <summary>
        /// Desc:0:正常;1:复检数据 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECHECK_FLAG {get;set;}

    }
}
