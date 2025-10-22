using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_TURNOUT
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:工务段编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_GWD_CODE {get;set;}

        /// <summary>
        /// Desc:工区编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_DEP_CODE {get;set;}

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
        /// Desc:车站名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_STATION_NAME {get;set;}

        /// <summary>
        /// Desc:车站编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_STATION_CODE {get;set;}

        /// <summary>
        /// Desc:线别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_LINE_CAT {get;set;}

        /// <summary>
        /// Desc:道岔号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_TURNOUT_CODE {get;set;}

        /// <summary>
        /// Desc:种类（单开、复交分、菱形、） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_KINDS {get;set;}

        /// <summary>
        /// Desc:辙叉号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_FROG_NO {get;set;}

        /// <summary>
        /// Desc:辙叉构造 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_FROG_STRUCT {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

        /// <summary>
        /// Desc:尖轨尖里程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? N_SWITCH_RAIL_MILE {get;set;}

    }
}
