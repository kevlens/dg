using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_BDATA_INFO
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:段编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:是否显示车站(默认否) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ISSHOW_STATION {get;set;}

        /// <summary>
        /// Desc:远程开门授权类型(帐号授权,指纹授权，默认帐号授权) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOOR_LONGAUTH {get;set;}

        /// <summary>
        /// Desc:门禁授权类型(帐号授权,自动授权，默认自动授权) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OPEN_AUTHTYPE {get;set;}

        /// <summary>
        /// Desc:授权时间类型(天窗时间,计划时间,驻站时间，默认天窗时间) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AUTHTIME_TYPE {get;set;}

        /// <summary>
        /// Desc:授权方式(手动,自动，默认手动授权) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AUTH_TYPE {get;set;}

        /// <summary>
        /// Desc:是否显示人员逗留报警(默认否) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PERSON_WALK {get;set;}

        /// <summary>
        /// Desc:长时间开门不关报警时长(分钟，默认10分钟) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OPENDOOR_TIME {get;set;}

        /// <summary>
        /// Desc:是否启用照明灯(默认关) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LIGHT_ISOPEN {get;set;}

        /// <summary>
        /// Desc:操作用户 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OP_USER {get;set;}

        /// <summary>
        /// Desc:操作时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? OP_TIME {get;set;}

        /// <summary>
        /// Desc:长时间开门不关报警时长操作结果(0:失败，1:成功)
 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? OPENDOOR_BACKRESULT {get;set;}

        /// <summary>
        /// Desc:是否启用照明灯操作结果(0:失败，1:成功)
 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? LIGHTISOPEN_BACKRESULT {get;set;}

        /// <summary>
        /// Desc:返回时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? BACK_TIME {get;set;}

        /// <summary>
        /// Desc:定时拍照功能开关(非0表示间隔时间分钟数，0关，默认关) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TAKEPIC_ISOPEN {get;set;}

    }
}
