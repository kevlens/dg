using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model
{
    public class BROKENRAIL_BDATA_SECTION
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SECTION_NAME {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string START_MILE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string END_MILE {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        [Key]
        public string SECTION_ID {get;set;}

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
        /// Desc:过车电压 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GC_VOL {get;set;}

        /// <summary>
        /// Desc:环境电压 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ENVIRONMENT_VOL {get;set;}

        /// <summary>
        /// Desc:起始定标器编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string START_SCALER_INDEX {get;set;}

        /// <summary>
        /// Desc:终止定标器编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string END_SCALER_INDEX {get;set;}

        /// <summary>
        /// Desc:站-站名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_STATION {get;set;}

    }
}
