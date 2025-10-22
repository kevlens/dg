using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class ALL_VIDEOFILE_DATA
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:硬件设备ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 设备号 {get;set;}

        /// <summary>
        /// Desc:软件设备PKID，多为手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 手机号 {get;set;}

        /// <summary>
        /// Desc:1 视频监控 2 护网监控 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? 类型 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? 时间 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 下载地址 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 是否原图 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 描述 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? 文件类型 {get;set;}

    }
}
