using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_CHK_TURNOUT_ITEMS
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
        /// Desc:轨距_前顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_SLOPE {get;set;}

        /// <summary>
        /// Desc:轨距_尖轨尖端处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:轨距_尖轨中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_SWITCH {get;set;}

        /// <summary>
        /// Desc:轨距_尖轨跟端_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_SWITCHHEEL_STR {get;set;}

        /// <summary>
        /// Desc:轨距_尖轨跟端_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_SWITCHHEEL_CUR {get;set;}

        /// <summary>
        /// Desc:轨距_直线_前 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_HEAD {get;set;}

        /// <summary>
        /// Desc:轨距_直线_中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_MID {get;set;}

        /// <summary>
        /// Desc:轨距_直线_后 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_TAIL {get;set;}

        /// <summary>
        /// Desc:轨距_导曲线_前 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_HEAD {get;set;}

        /// <summary>
        /// Desc:轨距_导曲线_中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_MID {get;set;}

        /// <summary>
        /// Desc:轨距_导曲线_后 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_TAIL {get;set;}

        /// <summary>
        /// Desc:轨距_叉心前_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_FROG_HEAD_STR {get;set;}

        /// <summary>
        /// Desc:轨距_叉心前_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_FROG_HEAD_CUR {get;set;}

        /// <summary>
        /// Desc:轨距_叉心中_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_FROG_MID_STR {get;set;}

        /// <summary>
        /// Desc:轨距_叉心中_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_FROG_MID_CUR {get;set;}

        /// <summary>
        /// Desc:轨距_叉心后_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_FROG_TAIL_STR {get;set;}

        /// <summary>
        /// Desc:轨距_叉心后_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_FROG_TAIL_CUR {get;set;}

        /// <summary>
        /// Desc:轨距_查照间隔_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CHECKGAGE_STR {get;set;}

        /// <summary>
        /// Desc:轨距_查照间隔_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CHECKGAGE_CUR {get;set;}

        /// <summary>
        /// Desc:轨距_护背距离_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_BACKGAGE_STR {get;set;}

        /// <summary>
        /// Desc:轨距_护背距离_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_BACKGAGE_CUR {get;set;}

        /// <summary>
        /// Desc:支距 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_OFFSET {get;set;}

        /// <summary>
        /// Desc:水平_前顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_SLOPE {get;set;}

        /// <summary>
        /// Desc:水平_尖轨尖端处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:水平_尖轨中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_SWITCH {get;set;}

        /// <summary>
        /// Desc:水平_尖轨跟端_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_SWITCHHEEL_STR {get;set;}

        /// <summary>
        /// Desc:水平_尖轨跟端_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_SWITCHHEEL_CUR {get;set;}

        /// <summary>
        /// Desc:水平_直线_前 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_HEAD {get;set;}

        /// <summary>
        /// Desc:水平_直线_中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_MID {get;set;}

        /// <summary>
        /// Desc:水平_直线_后 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_TAIL {get;set;}

        /// <summary>
        /// Desc:水平_导曲线_前 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_HEAD {get;set;}

        /// <summary>
        /// Desc:水平_导曲线_中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_MID {get;set;}

        /// <summary>
        /// Desc:水平_导曲线_后 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_TAIL {get;set;}

        /// <summary>
        /// Desc:水平_叉心前_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_FROG_HEAD_STR {get;set;}

        /// <summary>
        /// Desc:水平_叉心前_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_FROG_HEAD_CUR {get;set;}

        /// <summary>
        /// Desc:水平_叉心中_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_FROG_MID_STR {get;set;}

        /// <summary>
        /// Desc:水平_叉心中_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_FROG_MID_CUR {get;set;}

        /// <summary>
        /// Desc:水平_叉心后_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_FROG_TAIL_STR {get;set;}

        /// <summary>
        /// Desc:水平_叉心后_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_FROG_TAIL_CUR {get;set;}

        /// <summary>
        /// Desc:水平_查照间隔_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CHECKGAGE_STR {get;set;}

        /// <summary>
        /// Desc:水平_查照间隔_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CHECKGAGE_CUR {get;set;}

        /// <summary>
        /// Desc:水平_护背距离_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_BACKGAGE_STR {get;set;}

        /// <summary>
        /// Desc:水平_护背距离_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_BACKGAGE_CUR {get;set;}

        /// <summary>
        /// Desc:三角坑_前顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_SLOPE {get;set;}

        /// <summary>
        /// Desc:三角坑_尖轨尖端处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:三角坑_尖轨中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_SWITCH {get;set;}

        /// <summary>
        /// Desc:三角坑_尖轨跟端_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_SWITCHHEEL_STR {get;set;}

        /// <summary>
        /// Desc:三角坑_尖轨跟端_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_SWITCHHEEL_CUR {get;set;}

        /// <summary>
        /// Desc:三角坑_直线_前 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_HEAD {get;set;}

        /// <summary>
        /// Desc:三角坑_直线_中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_MID {get;set;}

        /// <summary>
        /// Desc:三角坑_直线_后 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_TAIL {get;set;}

        /// <summary>
        /// Desc:三角坑_导曲线_前 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_HEAD {get;set;}

        /// <summary>
        /// Desc:三角坑_导曲线_中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_MID {get;set;}

        /// <summary>
        /// Desc:三角坑_导曲线_后 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_TAIL {get;set;}

        /// <summary>
        /// Desc:三角坑_叉心前_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_FROG_HEAD_STR {get;set;}

        /// <summary>
        /// Desc:三角坑_叉心前_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_FROG_HEAD_CUR {get;set;}

        /// <summary>
        /// Desc:三角坑_叉心中_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_FROG_MID_STR {get;set;}

        /// <summary>
        /// Desc:三角坑_叉心中_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_FROG_MID_CUR {get;set;}

        /// <summary>
        /// Desc:三角坑_叉心后_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_FROG_TAIL_STR {get;set;}

        /// <summary>
        /// Desc:三角坑_叉心后_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_FROG_TAIL_CUR {get;set;}

        /// <summary>
        /// Desc:三角坑_查照间隔_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CHECKGAGE_STR {get;set;}

        /// <summary>
        /// Desc:三角坑_查照间隔_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CHECKGAGE_CUR {get;set;}

        /// <summary>
        /// Desc:三角坑_护背距离_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_BACKGAGE_STR {get;set;}

        /// <summary>
        /// Desc:三角坑_护背距离_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_BACKGAGE_CUR {get;set;}

        /// <summary>
        /// Desc:轨向_前顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_SLOPE {get;set;}

        /// <summary>
        /// Desc:轨向_尖轨尖端处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:轨向_尖轨中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_SWITCH {get;set;}

        /// <summary>
        /// Desc:轨向_尖轨跟端_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_SWITCHHEEL_STR {get;set;}

        /// <summary>
        /// Desc:轨向_尖轨跟端_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_SWITCHHEEL_CUR {get;set;}

        /// <summary>
        /// Desc:轨向_直线_前 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_HEAD {get;set;}

        /// <summary>
        /// Desc:轨向_直线_中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_MID {get;set;}

        /// <summary>
        /// Desc:轨向_直线_后 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_TAIL {get;set;}

        /// <summary>
        /// Desc:轨向_导曲线_前 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_HEAD {get;set;}

        /// <summary>
        /// Desc:轨向_导曲线_中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_MID {get;set;}

        /// <summary>
        /// Desc:轨向_导曲线_后 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_TAIL {get;set;}

        /// <summary>
        /// Desc:轨向_叉心前_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_FROG_HEAD_STR {get;set;}

        /// <summary>
        /// Desc:轨向_叉心前_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_FROG_HEAD_CUR {get;set;}

        /// <summary>
        /// Desc:轨向_叉心中_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_FROG_MID_STR {get;set;}

        /// <summary>
        /// Desc:轨向_叉心中_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_FROG_MID_CUR {get;set;}

        /// <summary>
        /// Desc:轨向_叉心后_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_FROG_TAIL_STR {get;set;}

        /// <summary>
        /// Desc:轨向_叉心后_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_FROG_TAIL_CUR {get;set;}

        /// <summary>
        /// Desc:轨向_查照间隔_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CHECKGAGE_STR {get;set;}

        /// <summary>
        /// Desc:轨向_查照间隔_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CHECKGAGE_CUR {get;set;}

        /// <summary>
        /// Desc:轨向_护背距离_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_BACKGAGE_STR {get;set;}

        /// <summary>
        /// Desc:轨向_护背距离_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_BACKGAGE_CUR {get;set;}

        /// <summary>
        /// Desc:高低_前顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_SLOPE {get;set;}

        /// <summary>
        /// Desc:高低_尖轨尖端处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:高低_尖轨中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_SWITCH {get;set;}

        /// <summary>
        /// Desc:高低_尖轨跟端_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_SWITCHHEEL_STR {get;set;}

        /// <summary>
        /// Desc:高低_尖轨跟端_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_SWITCHHEEL_CUR {get;set;}

        /// <summary>
        /// Desc:高低_直线_前 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_HEAD {get;set;}

        /// <summary>
        /// Desc:高低_直线_中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_MID {get;set;}

        /// <summary>
        /// Desc:高低_直线_后 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_TAIL {get;set;}

        /// <summary>
        /// Desc:高低_导曲线_前 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_HEAD {get;set;}

        /// <summary>
        /// Desc:高低_导曲线_中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_MID {get;set;}

        /// <summary>
        /// Desc:高低_导曲线_后 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_TAIL {get;set;}

        /// <summary>
        /// Desc:高低_叉心前_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_FROG_HEAD_STR {get;set;}

        /// <summary>
        /// Desc:高低_叉心前_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_FROG_HEAD_CUR {get;set;}

        /// <summary>
        /// Desc:高低_叉心中_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_FROG_MID_STR {get;set;}

        /// <summary>
        /// Desc:高低_叉心中_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_FROG_MID_CUR {get;set;}

        /// <summary>
        /// Desc:高低_叉心后_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_FROG_TAIL_STR {get;set;}

        /// <summary>
        /// Desc:高低_叉心后_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_FROG_TAIL_CUR {get;set;}

        /// <summary>
        /// Desc:高低_查照间隔_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CHECKGAGE_STR {get;set;}

        /// <summary>
        /// Desc:高低_查照间隔_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CHECKGAGE_CUR {get;set;}

        /// <summary>
        /// Desc:高低_护背距离_直 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_BACKGAGE_STR {get;set;}

        /// <summary>
        /// Desc:高低_护背距离_曲 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_BACKGAGE_CUR {get;set;}

        /// <summary>
        /// Desc:临修日期及内容 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_TM_CONTENT {get;set;}

        /// <summary>
        /// Desc:记事 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECORD {get;set;}

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
