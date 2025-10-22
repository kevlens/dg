using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class BRIDGE_OTHER_DEVICE
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string DEVICE_ID {get;set;}

        /// <summary>
        /// Desc:工务段代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GWD_CODE {get;set;}

        /// <summary>
        /// Desc:车间代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_CODE {get;set;}

        /// <summary>
        /// Desc:工区代码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_CODE {get;set;}

        /// <summary>
        /// Desc:线号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LINE_CODE {get;set;}

        /// <summary>
        /// Desc:行别 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string LINE_DIR {get;set;}

        /// <summary>
        /// Desc:中心里程 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public Double CENTER_MILE {get;set;}

        /// <summary>
        /// Desc:设备类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EQUIP_TYPE {get;set;}

        /// <summary>
        /// Desc:式样 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STYLE {get;set;}

        /// <summary>
        /// Desc:材质 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MATERIAL_QUALITY {get;set;}

        /// <summary>
        /// Desc:天桥或地道[全长（m)] 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? BRIDGETUNNE_LENGTH {get;set;}

        /// <summary>
        /// Desc:天桥或地道[全宽（m)] 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? BRIDGETUNNE_WIDTH {get;set;}

        /// <summary>
        /// Desc:引桥或引道[处数] 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? APPROACH_COUNTS {get;set;}

        /// <summary>
        /// Desc:引桥或引道[长度(m)] 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? APPROACH_LENGTH {get;set;}

        /// <summary>
        /// Desc:引桥或引道[宽度(m)] 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? APPROACH_WIDTH {get;set;}

        /// <summary>
        /// Desc:跨越或通过股道数量(股) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? ACROSSTRACKS_NUM {get;set;}

        /// <summary>
        /// Desc:桥高（m） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? BRIDGE_HEIGHT {get;set;}

        /// <summary>
        /// Desc:建成年度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BUILD_YEAR {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MEMO {get;set;}

    }
}
