using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class TOOL_TOOLMNG_INOUT
    {
        
        /// <summary>
        /// Desc:电子标签ID 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string ID {get;set;}

        /// <summary>
        /// Desc:设备名称(工机具名称表的ID) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NAME {get;set;}

        /// <summary>
        /// Desc:设备类别(工机具类型表的ID) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TYPE_ID {get;set;}

        /// <summary>
        /// Desc:入库时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? INDATE {get;set;}

        /// <summary>
        /// Desc:制造单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MFRS {get;set;}

        /// <summary>
        /// Desc:所属部门（部门表的ID） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEP_ID {get;set;}

        /// <summary>
        /// Desc:设备状态（0：在库；1：领用；2：保养；3:维修；4:丢失；9：报废） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? STATU {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REMARK {get;set;}

        /// <summary>
        /// Desc:设备编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TOOLID {get;set;}

        /// <summary>
        /// Desc:设备型号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MARKER {get;set;}

        /// <summary>
        /// Desc:制造年月 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? MADEDATE {get;set;}

        /// <summary>
        /// Desc:使用年月 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? USEDATE {get;set;}

        /// <summary>
        /// Desc:入库人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INNAME {get;set;}

        /// <summary>
        /// Desc:包保人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTAINAME {get;set;}

        /// <summary>
        /// Desc:设备原值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? EQPMVALUE {get;set;}

    }
}
