using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_ASS_EMP
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:姓名 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_NAME {get;set;}

        /// <summary>
        /// Desc:手机号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PHONE {get;set;}

        /// <summary>
        /// Desc:职务 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_POST {get;set;}

        /// <summary>
        /// Desc:工种 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_WORKTYPE {get;set;}

        /// <summary>
        /// Desc:资质 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_QUALIFICATIONS {get;set;}

        /// <summary>
        /// Desc:所属部门 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string C_DEP {get;set;}

        /// <summary>
        /// Desc:是否干部(0:否 ，1:是) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CADRESFLAG {get;set;}

        /// <summary>
        /// Desc:是否有效 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_EFF_FLAG {get;set;}

        /// <summary>
        /// Desc:排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_ORDER {get;set;}

        /// <summary>
        /// Desc:附注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

        /// <summary>
        /// Desc:性别 (0:男,1:女) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_PERSON_SEX {get;set;}

        /// <summary>
        /// Desc:年龄 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? C_PERSON_AGE {get;set;}

        /// <summary>
        /// Desc:职业技能等级(初级,中级....) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_JOB_LEVLE {get;set;}

    }
}
