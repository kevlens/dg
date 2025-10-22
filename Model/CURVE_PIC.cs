using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class CURVE_PIC
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
        /// Nullable:False 
        /// </summary>
        public string WEARRAILPKID {get;set;}

        /// <summary>
        /// Desc:年份 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string YEAR {get;set;}

        /// <summary>
        /// Desc:月份 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MONTH {get;set;}

        /// <summary>
        /// Desc:文件名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FILENAME {get;set;}

        /// <summary>
        /// Desc:链接地址 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINKADDRESS {get;set;}

        /// <summary>
        /// Desc:分类(属于侧磨，垂磨，总磨) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WEARTYPE {get;set;}

        /// <summary>
        /// Desc:上传日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? UPLOADDATE {get;set;}

        /// <summary>
        /// Desc:创建日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? T_CRT_TM {get;set;}

        /// <summary>
        /// Desc:创建人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CRT_NAME {get;set;}

        /// <summary>
        /// Desc:排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_ORDER {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

    }
}
