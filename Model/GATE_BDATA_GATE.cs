using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class GATE_BDATA_GATE
    {
        
        /// <summary>
        /// Desc:门编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string GATE_NO {get;set;}

        /// <summary>
        /// Desc:门名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATE_NAME {get;set;}

        /// <summary>
        /// Desc:经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? LONGITUDE {get;set;}

        /// <summary>
        /// Desc:纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? LATITUDE {get;set;}

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
        /// Desc:百度经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? BAIDULONGITUDE {get;set;}

        /// <summary>
        /// Desc:百度纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? BAIDULATITUDE {get;set;}

        /// <summary>
        /// Desc:部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:对应客户端id 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLIENT_NO {get;set;}

        /// <summary>
        /// Desc:线代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_CODE {get;set;}

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
        /// Desc:里程坐标 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_COORDINATE {get;set;}

        /// <summary>
        /// Desc:反转门号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATE_CONVERTNO {get;set;}

        /// <summary>
        /// Desc:"门类型：0：疏散通道；1：防护栅栏；2：保养点

" 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? GATE_TYPE {get;set;}

        /// <summary>
        /// Desc:门禁编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATE_ID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 播放路径 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INTERCOM_STATUS {get;set;}

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
        /// Desc:定时拍照功能开关(非0表示间隔时间分钟数，0关，默认关) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TAKEPIC_ISOPEN {get;set;}

        /// <summary>
        /// Desc:锁开自动关闭时长（分钟，默认1，最大10） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AUTOCLOSE_TIME {get;set;}

        /// <summary>
        /// Desc:人员逗留报警时长（分钟，默认1，最大10） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PERSONWALK_TIME {get;set;}

        /// <summary>
        /// Desc:监控自动关闭时长（分钟，默认2，最大10） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WATCHCLOSE_TIME {get;set;}

        /// <summary>
        /// Desc:触发自动拍照（0:否，1:开) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AUTO_PHOTOGRAPH {get;set;}

        /// <summary>
        /// Desc:双目摄像头MAC 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MAC_VIDEO {get;set;}

        /// <summary>
        /// Desc:是否启用人员逗留（0:否，1:开) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AUTO_PERSONWALK {get;set;}

        /// <summary>
        /// Desc:是否蓝牙 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string IS_BLUETOOTH {get;set;}

        /// <summary>
        /// Desc:蓝牙密码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BULETOOTH_PASSWORD {get;set;}

        /// <summary>
        /// Desc:新蓝牙密码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NEW_BULETOOTH_PASSWORD {get;set;}

    }
}
