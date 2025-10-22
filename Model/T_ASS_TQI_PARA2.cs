using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_TQI_PARA2
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:线编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_CODE {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_DIR {get;set;}

        /// <summary>
        /// Desc:起点里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_START_MILE {get;set;}

        /// <summary>
        /// Desc:终点里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_END_MILE {get;set;}

        /// <summary>
        /// Desc:TQI限值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Single TQIVALUE {get;set;}

        /// <summary>
        /// Desc:等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool TQI_LEVEL {get;set;}

        /// <summary>
        /// Desc:扣分值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public short N_SCORE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public bool N_FLAG {get;set;}

    }
}
