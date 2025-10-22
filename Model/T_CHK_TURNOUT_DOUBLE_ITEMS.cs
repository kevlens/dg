using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_CHK_TURNOUT_DOUBLE_ITEMS
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:T_CHK_TURNOUT主键 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FKID {get;set;}

        /// <summary>
        /// Desc:轨距_基本轨接头前顺坡点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_SLOPE {get;set;}

        /// <summary>
        /// Desc:轨距_基本轨接头处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_LAYUP {get;set;}

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
        /// Desc:轨距_尖轨跟端_左 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_SWITCHHEEL_LFT {get;set;}

        /// <summary>
        /// Desc:轨距_尖轨跟端_右 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_SWITCHHEEL_RHT {get;set;}

        /// <summary>
        /// Desc:轨距_左曲股_前 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_LFT_HEAD {get;set;}

        /// <summary>
        /// Desc:轨距_左曲股_中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_LFT_MID {get;set;}

        /// <summary>
        /// Desc:轨距_左曲股_后 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_LFT_TAIL {get;set;}

        /// <summary>
        /// Desc:轨距_右曲股_前 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_RHT_HEAD {get;set;}

        /// <summary>
        /// Desc:轨距_右曲股_中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_RHT_MID {get;set;}

        /// <summary>
        /// Desc:轨距_右曲股_后 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_RHT_TAIL {get;set;}

        /// <summary>
        /// Desc:轨距_叉心前_左 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_FROG_HEAD_LFT {get;set;}

        /// <summary>
        /// Desc:轨距_叉心前_右 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_FROG_HEAD_RHT {get;set;}

        /// <summary>
        /// Desc:轨距_叉心中_左 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_FROG_MID_LFT {get;set;}

        /// <summary>
        /// Desc:轨距_叉心中_右 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_FROG_MID_RHT {get;set;}

        /// <summary>
        /// Desc:轨距_叉心后_左 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_FROG_TAIL_LFT {get;set;}

        /// <summary>
        /// Desc:轨距_叉心后_右 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_FROG_TAIL_RHT {get;set;}

        /// <summary>
        /// Desc:轨距_查照间隔1391_左 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CHECKGAGE_LFT {get;set;}

        /// <summary>
        /// Desc:轨距_查照间隔1391_右 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CHECKGAGE_RHT {get;set;}

        /// <summary>
        /// Desc:轨距_护背距离1348_左 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_BACKGAGE_LFT {get;set;}

        /// <summary>
        /// Desc:轨距_护背距离1348_右 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_BACKGAGE_RHT {get;set;}

        /// <summary>
        /// Desc:支距 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_OFFSET {get;set;}

        /// <summary>
        /// Desc:水平_基本轨接头前顺坡点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_SLOPE {get;set;}

        /// <summary>
        /// Desc:水平_基本轨接头处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_LAYUP {get;set;}

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
        /// Desc:水平_尖轨跟端_左 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_SWITCHHEEL_LFT {get;set;}

        /// <summary>
        /// Desc:水平_尖轨跟端_右 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_SWITCHHEEL_RHT {get;set;}

        /// <summary>
        /// Desc:水平_左曲股_前 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_LFT_HEAD {get;set;}

        /// <summary>
        /// Desc:水平_左曲股_中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_LFT_MID {get;set;}

        /// <summary>
        /// Desc:水平_左曲股_后 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_LFT_TAIL {get;set;}

        /// <summary>
        /// Desc:水平_右曲股_前 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_RHT_HEAD {get;set;}

        /// <summary>
        /// Desc:水平_右曲股_中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_RHT_MID {get;set;}

        /// <summary>
        /// Desc:水平_右曲股_后 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_RHT_TAIL {get;set;}

        /// <summary>
        /// Desc:水平_叉心前_左 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_FROG_HEAD_LFT {get;set;}

        /// <summary>
        /// Desc:水平_叉心前_右 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_FROG_HEAD_RHT {get;set;}

        /// <summary>
        /// Desc:水平_叉心中_左 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_FROG_MID_LFT {get;set;}

        /// <summary>
        /// Desc:水平_叉心中_右 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_FROG_MID_RHT {get;set;}

        /// <summary>
        /// Desc:水平_叉心后_左 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_FROG_TAIL_LFT {get;set;}

        /// <summary>
        /// Desc:水平_叉心后_右 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_FROG_TAIL_RHT {get;set;}

        /// <summary>
        /// Desc:水平_查照间隔1391_左 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CHECKGAGE_LFT {get;set;}

        /// <summary>
        /// Desc:水平_查照间隔1391_右 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CHECKGAGE_RHT {get;set;}

        /// <summary>
        /// Desc:水平_护背距离1348_左 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_BACKGAGE_LFT {get;set;}

        /// <summary>
        /// Desc:水平_护背距离1348_右 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_BACKGAGE_RHT {get;set;}

        /// <summary>
        /// Desc:三角坑_基本轨接头前顺坡点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_SLOPE {get;set;}

        /// <summary>
        /// Desc:三角坑_基本轨接头处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_LAYUP {get;set;}

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
        /// Desc:三角坑_尖轨跟端_左 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_SWITCHHEEL_LFT {get;set;}

        /// <summary>
        /// Desc:三角坑_尖轨跟端_右 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_SWITCHHEEL_RHT {get;set;}

        /// <summary>
        /// Desc:三角坑_左曲股_前 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_LFT_HEAD {get;set;}

        /// <summary>
        /// Desc:三角坑_左曲股_中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_LFT_MID {get;set;}

        /// <summary>
        /// Desc:三角坑_左曲股_后 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_LFT_TAIL {get;set;}

        /// <summary>
        /// Desc:三角坑_右曲股_前 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_RHT_HEAD {get;set;}

        /// <summary>
        /// Desc:三角坑_右曲股_中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_RHT_MID {get;set;}

        /// <summary>
        /// Desc:三角坑_右曲股_后 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_RHT_TAIL {get;set;}

        /// <summary>
        /// Desc:三角坑_叉心前_左 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_FROG_HEAD_LFT {get;set;}

        /// <summary>
        /// Desc:三角坑_叉心前_右 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_FROG_HEAD_RHT {get;set;}

        /// <summary>
        /// Desc:三角坑_叉心中_左 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_FROG_MID_LFT {get;set;}

        /// <summary>
        /// Desc:三角坑_叉心中_右 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_FROG_MID_RHT {get;set;}

        /// <summary>
        /// Desc:三角坑_叉心后_左 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_FROG_TAIL_LFT {get;set;}

        /// <summary>
        /// Desc:三角坑_叉心后_右 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_FROG_TAIL_RHT {get;set;}

        /// <summary>
        /// Desc:三角坑_查照间隔1391_左 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CHECKGAGE_LFT {get;set;}

        /// <summary>
        /// Desc:三角坑_查照间隔1391_右 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CHECKGAGE_RHT {get;set;}

        /// <summary>
        /// Desc:三角坑_护背距离1348_左 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_BACKGAGE_LFT {get;set;}

        /// <summary>
        /// Desc:三角坑_护背距离1348_右 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_BACKGAGE_RHT {get;set;}

        /// <summary>
        /// Desc:记事 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECORD {get;set;}

        /// <summary>
        /// Desc:紧急工作量及其它 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CRITICAL_ACTIVITY {get;set;}

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
        public DateTime? T_GPS_TM {get;set;}

        /// <summary>
        /// Desc:0:正常;1:复检数据 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECHECK_FLAG {get;set;}

    }
}
