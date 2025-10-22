using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_CHK_TURNOUT_MOVPOINT_ITEMS
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:T_CHK_TURNOUT主键 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FKID {get;set;}

        /// <summary>
        /// Desc:轨距_直_尖轨前顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_SWITCHSLOPE {get;set;}

        /// <summary>
        /// Desc:轨距_直_尖轨尖端处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:轨距_直_尖轨中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_SWITCHMIDHEAD {get;set;}

        /// <summary>
        /// Desc:轨距_直_尖轨中前部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_SWITCHMIDHEAD1 {get;set;}

        /// <summary>
        /// Desc:轨距_直_尖轨中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_SWITCHMID {get;set;}

        /// <summary>
        /// Desc:轨距_直_尖轨中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_SWITCHMIDTAIL {get;set;}

        /// <summary>
        /// Desc:轨距_直_尖轨中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_SWITCHMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:轨距_直_尖轨跟端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_SWITCHHEEL {get;set;}

        /// <summary>
        /// Desc:轨距_直_导曲线_前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_CURHEAD {get;set;}

        /// <summary>
        /// Desc:轨距_直_导曲线_中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_CURMIDHEAD {get;set;}

        /// <summary>
        /// Desc:轨距_直_导曲线_中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_CURMID {get;set;}

        /// <summary>
        /// Desc:轨距_直_导曲线_中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_CURMIDTAIL {get;set;}

        /// <summary>
        /// Desc:轨距_直_导曲线_后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_CURTAIL {get;set;}

        /// <summary>
        /// Desc:轨距_直_辙叉前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_FORGHEAD {get;set;}

        /// <summary>
        /// Desc:轨距_直_辙叉中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_FORGMID {get;set;}

        /// <summary>
        /// Desc:轨距_直_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:轨距_直_辙叉中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_FORGMIDTAIL {get;set;}

        /// <summary>
        /// Desc:轨距_直_辙叉中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_FORGMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:轨距_直_弹性可弯中心后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_ELASTAIL {get;set;}

        /// <summary>
        /// Desc:轨距_直_辙叉后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_STR_FORGTAIL {get;set;}

        /// <summary>
        /// Desc:支距 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_OFFSET {get;set;}

        /// <summary>
        /// Desc:轨距_曲_尖轨前顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_SWITCHSLOPE {get;set;}

        /// <summary>
        /// Desc:轨距_曲_尖轨尖端处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:轨距_曲_尖轨中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_SWITCHMIDHEAD {get;set;}

        /// <summary>
        /// Desc:轨距_曲_尖轨中前部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_SWITCHMIDHEAD1 {get;set;}

        /// <summary>
        /// Desc:轨距_曲_尖轨中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_SWITCHMID {get;set;}

        /// <summary>
        /// Desc:轨距_曲_尖轨中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_SWITCHMIDTAIL {get;set;}

        /// <summary>
        /// Desc:轨距_曲_尖轨中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_SWITCHMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:轨距_曲_尖轨跟端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_SWITCHHEEL {get;set;}

        /// <summary>
        /// Desc:轨距_曲_导曲线_前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_CURHEAD {get;set;}

        /// <summary>
        /// Desc:轨距_曲_导曲线_中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_CURMIDHEAD {get;set;}

        /// <summary>
        /// Desc:轨距_曲_导曲线_中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_CURMID {get;set;}

        /// <summary>
        /// Desc:轨距_曲_导曲线_中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_CURMIDTAIL {get;set;}

        /// <summary>
        /// Desc:轨距_曲_导曲线_后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_CURTAIL {get;set;}

        /// <summary>
        /// Desc:轨距_曲_辙叉前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_FORGHEAD {get;set;}

        /// <summary>
        /// Desc:轨距_曲_辙叉中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_FORGMID {get;set;}

        /// <summary>
        /// Desc:轨距_曲_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:轨距_曲_辙叉中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_FORGMIDTAIL {get;set;}

        /// <summary>
        /// Desc:轨距_曲_辙叉中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_FORGMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:轨距_曲_弹性可弯中心后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_ELASTAIL {get;set;}

        /// <summary>
        /// Desc:轨距_曲_辙叉后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GAUGE_CUR_FORGTAIL {get;set;}

        /// <summary>
        /// Desc:水平_直_尖轨前顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_SWITCHSLOPE {get;set;}

        /// <summary>
        /// Desc:水平_直_尖轨尖端处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:水平_直_尖轨中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_SWITCHMIDHEAD {get;set;}

        /// <summary>
        /// Desc:水平_直_尖轨中前部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_SWITCHMIDHEAD1 {get;set;}

        /// <summary>
        /// Desc:水平_直_尖轨中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_SWITCHMID {get;set;}

        /// <summary>
        /// Desc:水平_直_尖轨中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_SWITCHMIDTAIL {get;set;}

        /// <summary>
        /// Desc:水平_直_尖轨中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_SWITCHMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:水平_直_尖轨跟端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_SWITCHHEEL {get;set;}

        /// <summary>
        /// Desc:水平_直_导曲线_前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_CURHEAD {get;set;}

        /// <summary>
        /// Desc:水平_直_导曲线_中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_CURMIDHEAD {get;set;}

        /// <summary>
        /// Desc:水平_直_导曲线_中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_CURMID {get;set;}

        /// <summary>
        /// Desc:水平_直_导曲线_中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_CURMIDTAIL {get;set;}

        /// <summary>
        /// Desc:水平_直_导曲线_后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_CURTAIL {get;set;}

        /// <summary>
        /// Desc:水平_直_辙叉前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_FORGHEAD {get;set;}

        /// <summary>
        /// Desc:水平_直_辙叉中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_FORGMID {get;set;}

        /// <summary>
        /// Desc:水平_直_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:水平_直_辙叉中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_FORGMIDTAIL {get;set;}

        /// <summary>
        /// Desc:水平_直_辙叉中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_FORGMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:水平_直_弹性可弯中心后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_ELASTAIL {get;set;}

        /// <summary>
        /// Desc:水平_直_辙叉后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_STR_FORGTAIL {get;set;}

        /// <summary>
        /// Desc:水平_曲_尖轨前顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_SWITCHSLOPE {get;set;}

        /// <summary>
        /// Desc:水平_曲_尖轨尖端处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:水平_曲_尖轨中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_SWITCHMIDHEAD {get;set;}

        /// <summary>
        /// Desc:水平_曲_尖轨中前部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_SWITCHMIDHEAD1 {get;set;}

        /// <summary>
        /// Desc:水平_曲_尖轨中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_SWITCHMID {get;set;}

        /// <summary>
        /// Desc:水平_曲_尖轨中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_SWITCHMIDTAIL {get;set;}

        /// <summary>
        /// Desc:水平_曲_尖轨中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_SWITCHMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:水平_曲_尖轨跟端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_SWITCHHEEL {get;set;}

        /// <summary>
        /// Desc:水平_曲_导曲线_前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_CURHEAD {get;set;}

        /// <summary>
        /// Desc:水平_曲_导曲线_中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_CURMIDHEAD {get;set;}

        /// <summary>
        /// Desc:水平_曲_导曲线_中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_CURMID {get;set;}

        /// <summary>
        /// Desc:水平_曲_导曲线_中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_CURMIDTAIL {get;set;}

        /// <summary>
        /// Desc:水平_曲_导曲线_后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_CURTAIL {get;set;}

        /// <summary>
        /// Desc:水平_曲_辙叉前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_FORGHEAD {get;set;}

        /// <summary>
        /// Desc:水平_曲_辙叉中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_FORGMID {get;set;}

        /// <summary>
        /// Desc:水平_曲_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:水平_曲_辙叉中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_FORGMIDTAIL {get;set;}

        /// <summary>
        /// Desc:水平_曲_辙叉中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_FORGMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:水平_曲_弹性可弯中心后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_ELASTAIL {get;set;}

        /// <summary>
        /// Desc:水平_曲_辙叉后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEVEL_CUR_FORGTAIL {get;set;}

        /// <summary>
        /// Desc:三角坑_直_尖轨前顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_SWITCHSLOPE {get;set;}

        /// <summary>
        /// Desc:三角坑_直_尖轨尖端处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:三角坑_直_尖轨中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_SWITCHMIDHEAD {get;set;}

        /// <summary>
        /// Desc:三角坑_直_尖轨中前部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_SWITCHMIDHEAD1 {get;set;}

        /// <summary>
        /// Desc:三角坑_直_尖轨中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_SWITCHMID {get;set;}

        /// <summary>
        /// Desc:三角坑_直_尖轨中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_SWITCHMIDTAIL {get;set;}

        /// <summary>
        /// Desc:三角坑_直_尖轨中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_SWITCHMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:三角坑_直_尖轨跟端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_SWITCHHEEL {get;set;}

        /// <summary>
        /// Desc:三角坑_直_导曲线_前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_CURHEAD {get;set;}

        /// <summary>
        /// Desc:三角坑_直_导曲线_中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_CURMIDHEAD {get;set;}

        /// <summary>
        /// Desc:三角坑_直_导曲线_中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_CURMID {get;set;}

        /// <summary>
        /// Desc:三角坑_直_导曲线_中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_CURMIDTAIL {get;set;}

        /// <summary>
        /// Desc:三角坑_直_导曲线_后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_CURTAIL {get;set;}

        /// <summary>
        /// Desc:三角坑_直_辙叉前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_FORGHEAD {get;set;}

        /// <summary>
        /// Desc:三角坑_直_辙叉中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_FORGMID {get;set;}

        /// <summary>
        /// Desc:三角坑_直_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:三角坑_直_辙叉中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_FORGMIDTAIL {get;set;}

        /// <summary>
        /// Desc:三角坑_直_辙叉中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_FORGMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:三角坑_直_弹性可弯中心后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_ELASTAIL {get;set;}

        /// <summary>
        /// Desc:三角坑_直_辙叉后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_STR_FORGTAIL {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_尖轨前顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_SWITCHSLOPE {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_尖轨尖端处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_尖轨中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_SWITCHMIDHEAD {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_尖轨中前部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_SWITCHMIDHEAD1 {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_尖轨中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_SWITCHMID {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_尖轨中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_SWITCHMIDTAIL {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_尖轨中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_SWITCHMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_尖轨跟端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_SWITCHHEEL {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_导曲线_前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_CURHEAD {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_导曲线_中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_CURMIDHEAD {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_导曲线_中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_CURMID {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_导曲线_中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_CURMIDTAIL {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_导曲线_后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_CURTAIL {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_辙叉前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_FORGHEAD {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_辙叉中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_FORGMID {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_辙叉中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_FORGMIDTAIL {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_辙叉中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_FORGMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_弹性可弯中心后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_ELASTAIL {get;set;}

        /// <summary>
        /// Desc:三角坑_曲_辙叉后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TWIST_CUR_FORGTAIL {get;set;}

        /// <summary>
        /// Desc:轨向_直_尖轨前顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_SWITCHSLOPE {get;set;}

        /// <summary>
        /// Desc:轨向_直_尖轨尖端处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:轨向_直_尖轨中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_SWITCHMIDHEAD {get;set;}

        /// <summary>
        /// Desc:轨向_直_尖轨中前部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_SWITCHMIDHEAD1 {get;set;}

        /// <summary>
        /// Desc:轨向_直_尖轨中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_SWITCHMID {get;set;}

        /// <summary>
        /// Desc:轨向_直_尖轨中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_SWITCHMIDTAIL {get;set;}

        /// <summary>
        /// Desc:轨向_直_尖轨中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_SWITCHMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:轨向_直_尖轨跟端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_SWITCHHEEL {get;set;}

        /// <summary>
        /// Desc:轨向_直_导曲线_前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_CURHEAD {get;set;}

        /// <summary>
        /// Desc:轨向_直_导曲线_中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_CURMIDHEAD {get;set;}

        /// <summary>
        /// Desc:轨向_直_导曲线_中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_CURMID {get;set;}

        /// <summary>
        /// Desc:轨向_直_导曲线_中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_CURMIDTAIL {get;set;}

        /// <summary>
        /// Desc:轨向_直_导曲线_后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_CURTAIL {get;set;}

        /// <summary>
        /// Desc:轨向_直_辙叉前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_FORGHEAD {get;set;}

        /// <summary>
        /// Desc:轨向_直_辙叉中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_FORGMID {get;set;}

        /// <summary>
        /// Desc:轨向_直_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:轨向_直_辙叉中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_FORGMIDTAIL {get;set;}

        /// <summary>
        /// Desc:轨向_直_辙叉中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_FORGMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:轨向_直_弹性可弯中心后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_ELASTAIL {get;set;}

        /// <summary>
        /// Desc:轨向_直_辙叉后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_STR_FORGTAIL {get;set;}

        /// <summary>
        /// Desc:轨向_曲_尖轨前顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_SWITCHSLOPE {get;set;}

        /// <summary>
        /// Desc:轨向_曲_尖轨尖端处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:轨向_曲_尖轨中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_SWITCHMIDHEAD {get;set;}

        /// <summary>
        /// Desc:轨向_曲_尖轨中前部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_SWITCHMIDHEAD1 {get;set;}

        /// <summary>
        /// Desc:轨向_曲_尖轨中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_SWITCHMID {get;set;}

        /// <summary>
        /// Desc:轨向_曲_尖轨中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_SWITCHMIDTAIL {get;set;}

        /// <summary>
        /// Desc:轨向_曲_尖轨中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_SWITCHMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:轨向_曲_尖轨跟端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_SWITCHHEEL {get;set;}

        /// <summary>
        /// Desc:轨向_曲_导曲线_前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_CURHEAD {get;set;}

        /// <summary>
        /// Desc:轨向_曲_导曲线_中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_CURMIDHEAD {get;set;}

        /// <summary>
        /// Desc:轨向_曲_导曲线_中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_CURMID {get;set;}

        /// <summary>
        /// Desc:轨向_曲_导曲线_中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_CURMIDTAIL {get;set;}

        /// <summary>
        /// Desc:轨向_曲_导曲线_后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_CURTAIL {get;set;}

        /// <summary>
        /// Desc:轨向_曲_辙叉前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_FORGHEAD {get;set;}

        /// <summary>
        /// Desc:轨向_曲_辙叉中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_FORGMID {get;set;}

        /// <summary>
        /// Desc:轨向_曲_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:轨向_曲_辙叉中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_FORGMIDTAIL {get;set;}

        /// <summary>
        /// Desc:轨向_曲_辙叉中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_FORGMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:轨向_曲_弹性可弯中心后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_ELASTAIL {get;set;}

        /// <summary>
        /// Desc:轨向_曲_辙叉后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_CUR_FORGTAIL {get;set;}

        /// <summary>
        /// Desc:高低_直_尖轨前顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_SWITCHSLOPE {get;set;}

        /// <summary>
        /// Desc:高低_直_尖轨尖端处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:高低_直_尖轨中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_SWITCHMIDHEAD {get;set;}

        /// <summary>
        /// Desc:高低_直_尖轨中前部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_SWITCHMIDHEAD1 {get;set;}

        /// <summary>
        /// Desc:高低_直_尖轨中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_SWITCHMID {get;set;}

        /// <summary>
        /// Desc:高低_直_尖轨中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_SWITCHMIDTAIL {get;set;}

        /// <summary>
        /// Desc:高低_直_尖轨中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_SWITCHMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:高低_直_尖轨跟端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_SWITCHHEEL {get;set;}

        /// <summary>
        /// Desc:高低_直_导曲线_前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_CURHEAD {get;set;}

        /// <summary>
        /// Desc:高低_直_导曲线_中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_CURMIDHEAD {get;set;}

        /// <summary>
        /// Desc:高低_直_导曲线_中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_CURMID {get;set;}

        /// <summary>
        /// Desc:高低_直_导曲线_中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_CURMIDTAIL {get;set;}

        /// <summary>
        /// Desc:高低_直_导曲线_后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_CURTAIL {get;set;}

        /// <summary>
        /// Desc:高低_直_辙叉前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_FORGHEAD {get;set;}

        /// <summary>
        /// Desc:高低_直_辙叉中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_FORGMID {get;set;}

        /// <summary>
        /// Desc:高低_直_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:高低_直_辙叉中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_FORGMIDTAIL {get;set;}

        /// <summary>
        /// Desc:高低_直_辙叉中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_FORGMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:高低_直_弹性可弯中心后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_ELASTAIL {get;set;}

        /// <summary>
        /// Desc:高低_直_辙叉后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_STR_FORGTAIL {get;set;}

        /// <summary>
        /// Desc:高低_曲_尖轨前顺坡终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_SWITCHSLOPE {get;set;}

        /// <summary>
        /// Desc:高低_曲_尖轨尖端处 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_SWITCHPOINT {get;set;}

        /// <summary>
        /// Desc:高低_曲_尖轨中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_SWITCHMIDHEAD {get;set;}

        /// <summary>
        /// Desc:高低_曲_尖轨中前部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_SWITCHMIDHEAD1 {get;set;}

        /// <summary>
        /// Desc:高低_曲_尖轨中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_SWITCHMID {get;set;}

        /// <summary>
        /// Desc:高低_曲_尖轨中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_SWITCHMIDTAIL {get;set;}

        /// <summary>
        /// Desc:高低_曲_尖轨中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_SWITCHMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:高低_曲_尖轨跟端 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_SWITCHHEEL {get;set;}

        /// <summary>
        /// Desc:高低_曲_导曲线_前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_CURHEAD {get;set;}

        /// <summary>
        /// Desc:高低_曲_导曲线_中前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_CURMIDHEAD {get;set;}

        /// <summary>
        /// Desc:高低_曲_导曲线_中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_CURMID {get;set;}

        /// <summary>
        /// Desc:高低_曲_导曲线_中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_CURMIDTAIL {get;set;}

        /// <summary>
        /// Desc:高低_曲_导曲线_后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_CURTAIL {get;set;}

        /// <summary>
        /// Desc:高低_曲_辙叉前部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_FORGHEAD {get;set;}

        /// <summary>
        /// Desc:高低_曲_辙叉中部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_FORGMID {get;set;}

        /// <summary>
        /// Desc:高低_曲_查照间隔 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_CHECKGAGE {get;set;}

        /// <summary>
        /// Desc:高低_曲_辙叉中后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_FORGMIDTAIL {get;set;}

        /// <summary>
        /// Desc:高低_曲_辙叉中后部* 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_FORGMIDTAIL1 {get;set;}

        /// <summary>
        /// Desc:高低_曲_弹性可弯中心后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_ELASTAIL {get;set;}

        /// <summary>
        /// Desc:高低_曲_辙叉后部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HIHLOW_CUR_FORGTAIL {get;set;}

        /// <summary>
        /// Desc:记事 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECORD {get;set;}

        /// <summary>
        /// Desc:临修日期及内容 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_TM_CONTENT {get;set;}

        /// <summary>
        /// Desc:检查时间/复检时间(必传) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CHK_TM {get;set;}

        /// <summary>
        /// Desc:经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? LNG {get;set;}

        /// <summary>
        /// Desc:纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? LAT {get;set;}

        /// <summary>
        /// Desc:火星经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARS_LNG {get;set;}

        /// <summary>
        /// Desc:火星纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARS_LAT {get;set;}

        /// <summary>
        /// Desc:百度经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? BAIDU_LNG {get;set;}

        /// <summary>
        /// Desc:百度纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? BAIDU_LAT {get;set;}

        /// <summary>
        /// Desc:GPS时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? GPS_TM {get;set;}

        /// <summary>
        /// Desc:0:正常;1:复检数据 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RECHECK_FLAG {get;set;}

    }
}
