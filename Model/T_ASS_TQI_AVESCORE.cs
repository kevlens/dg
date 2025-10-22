using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_TQI_AVESCORE
    {
        
        /// <summary>
        /// Desc:单位编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_DEP_CODE {get;set;}

        /// <summary>
        /// Desc:线号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_CODE {get;set;}

        /// <summary>
        /// Desc:平均扣分值 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public double AVESCORE {get;set;}

        /// <summary>
        /// Desc:排名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Byte? NOM {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_DIR {get;set;}

    }
}
