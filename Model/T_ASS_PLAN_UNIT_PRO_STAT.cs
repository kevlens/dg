using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_PLAN_UNIT_PRO_STAT
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_ID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FLOWID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LOC_PKID {get;set;}

        /// <summary>
        /// Desc:标记（0：上期；1：本期） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? FLAG {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_CODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:单元号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UNIT_NUM {get;set;}

        /// <summary>
        /// Desc:单元起点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? UNIT_START_MILE {get;set;}

        /// <summary>
        /// Desc:单元终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? UNIT_END_MILE {get;set;}

        /// <summary>
        /// Desc:车站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_CODE {get;set;}

        /// <summary>
        /// Desc:股道 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CODE {get;set;}

        /// <summary>
        /// Desc:道岔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TURNOUT_CODE {get;set;}

        /// <summary>
        /// Desc:轨向：问题数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? TRACK_PRO_NUM {get;set;}

        /// <summary>
        /// Desc:轨向：问题最大峰值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single TRACK_PRO_PEAK {get;set;}

        /// <summary>
        /// Desc:轨向：问题最大峰值所在位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_PRO_PLACE {get;set;}

        /// <summary>
        /// Desc:高低：问题数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? HILOW_PRO_NUM {get;set;}

        /// <summary>
        /// Desc:高低：问题最大峰值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single HILOW_PRO_PEAK {get;set;}

        /// <summary>
        /// Desc:高低：问题最大峰值所在位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HILOW_PRO_PLACE {get;set;}

        /// <summary>
        /// Desc:轨距：问题数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? GAUGE_PRO_NUM {get;set;}

        /// <summary>
        /// Desc:轨距：问题最大峰值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single GAUGE_PRO_PEAK {get;set;}

        /// <summary>
        /// Desc:轨距：问题最大峰值所在位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_PRO_PLACE {get;set;}

        /// <summary>
        /// Desc:水平：问题数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? HORIAONTAL_PRO_NUM {get;set;}

        /// <summary>
        /// Desc:水平：问题最大峰值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single HORIAONTAL_PRO_PEAK {get;set;}

        /// <summary>
        /// Desc:水平：问题最大峰值所在位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HORIAONTAL_PRO_PLACE {get;set;}

        /// <summary>
        /// Desc:三角坑：问题数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? TWIST_PRO_NUM {get;set;}

        /// <summary>
        /// Desc:三角坑：问题最大峰值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single TWIST_PRO_PEAK {get;set;}

        /// <summary>
        /// Desc:三角坑：问题最大峰值所在位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_PRO_PLACE {get;set;}

        /// <summary>
        /// Desc:其它：问题数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? OTHER_PRO_NUM {get;set;}

        /// <summary>
        /// Desc:其它：问题最大峰值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single OTHER_PRO_PEAK {get;set;}

        /// <summary>
        /// Desc:其它：问题最大峰值所在位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OTHER_PRO_PLACE {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

        /// <summary>
        /// Desc:入库时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CRT_TM {get;set;}

    }
}
