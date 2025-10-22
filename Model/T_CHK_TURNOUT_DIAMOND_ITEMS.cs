using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_CHK_TURNOUT_DIAMOND_ITEMS
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
        /// Desc:类型 （0 甲股 1乙股） 
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
        /// Desc:轨距_前锐角辙叉_叉心中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_HEAD_FROGMID {get;set;}

        /// <summary>
        /// Desc:轨距_前锐角辙叉_叉前端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_HEAD_FROGHEAD {get;set;}

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
        /// Desc:轨距_钝角辙叉_前半部_叉前端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_OBTUHEAD_FROGHEAD {get;set;}

        /// <summary>
        /// Desc:轨距_钝角辙叉_前半部_叉心中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_OBTUHEAD_FROGMID {get;set;}

        /// <summary>
        /// Desc:轨距_钝角辙叉_前半部_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_OBTUHEAD_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:轨距_钝角辙叉_前半部_护背距离 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_OBTUHEAD_BACKGAGE {get;set;}

        /// <summary>
        /// Desc:轨距_钝角辙叉_后半部_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_OBTUTAIL_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:轨距_钝角辙叉_后半部_护背距离 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_OBTUTAIL_BACKGAGE {get;set;}

        /// <summary>
        /// Desc:轨距_钝角辙叉_后半部_叉心中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_OBTUTAIL_FROGMID {get;set;}

        /// <summary>
        /// Desc:轨距_钝角辙叉_后半部_叉后端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_OBTUTAIL_FROGTAIL {get;set;}

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
        /// Desc:轨距_后锐角辙叉_叉前端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_TAIL_FROGHEAD {get;set;}

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
        /// Desc:水平_前锐角辙叉_叉心中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_HEAD_FROGMID {get;set;}

        /// <summary>
        /// Desc:水平_前锐角辙叉_叉前端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_HEAD_FROGHEAD {get;set;}

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
        /// Desc:水平_钝角辙叉_前半部_叉前端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_OBTUHEAD_FROGHEAD {get;set;}

        /// <summary>
        /// Desc:水平_钝角辙叉_前半部_叉心中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_OBTUHEAD_FROGMID {get;set;}

        /// <summary>
        /// Desc:水平_钝角辙叉_前半部_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_OBTUHEAD_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:水平_钝角辙叉_前半部_护背距离 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_OBTUHEAD_BACKGAGE {get;set;}

        /// <summary>
        /// Desc:水平_钝角辙叉_后半部_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_OBTUTAIL_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:水平_钝角辙叉_后半部_护背距离 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_OBTUTAIL_BACKGAGE {get;set;}

        /// <summary>
        /// Desc:水平_钝角辙叉_后半部_叉心中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_OBTUTAIL_FROGMID {get;set;}

        /// <summary>
        /// Desc:水平_钝角辙叉_后半部_叉后端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_OBTUTAIL_FROGTAIL {get;set;}

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
        /// Desc:水平_后锐角辙叉_叉前端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_TAIL_FROGHEAD {get;set;}

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
        /// Desc:三角坑_前锐角辙叉_叉心中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_HEAD_FROGMID {get;set;}

        /// <summary>
        /// Desc:三角坑_前锐角辙叉_叉前端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_HEAD_FROGHEAD {get;set;}

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
        /// Desc:三角坑_钝角辙叉_前半部_叉前端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_OBTUHEAD_FROGHEAD {get;set;}

        /// <summary>
        /// Desc:三角坑_钝角辙叉_前半部_叉心中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_OBTUHEAD_FROGMID {get;set;}

        /// <summary>
        /// Desc:三角坑_钝角辙叉_前半部_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_OBTUHEAD_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:三角坑_钝角辙叉_前半部_护背距离 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_OBTUHEAD_BACKGAGE {get;set;}

        /// <summary>
        /// Desc:三角坑_钝角辙叉_后半部_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_OBTUTAIL_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:三角坑_钝角辙叉_后半部_护背距离 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_OBTUTAIL_BACKGAGE {get;set;}

        /// <summary>
        /// Desc:三角坑_钝角辙叉_后半部_叉心中 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_OBTUTAIL_FROGMID {get;set;}

        /// <summary>
        /// Desc:三角坑_钝角辙叉_后半部_叉后端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_OBTUTAIL_FROGTAIL {get;set;}

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
        /// Desc:三角坑_后锐角辙叉_叉前端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_TAIL_FROGHEAD {get;set;}

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
        /// Desc:记事 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECORD {get;set;}

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
