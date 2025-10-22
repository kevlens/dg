using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class RAIN_DEVICE_PLANLOG
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 编号 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 监测点 {get;set;}

        /// <summary>
        /// Desc:注意、限速、封锁、解除、正常 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string 状态 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? 更改状态时间 {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

    }
}
