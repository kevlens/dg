using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class JOB_PLAN
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PLAN_ID {get;set;}

        /// <summary>
        /// Desc:计划类别(计算保留) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TYPE {get;set;}

        /// <summary>
        /// Desc:线名（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME {get;set;}

        /// <summary>
        /// Desc:行别（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIRECTION {get;set;}

        /// <summary>
        /// Desc:开始里程（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_BEGIN {get;set;}

        /// <summary>
        /// Desc:结束里程（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MILEAGE_END {get;set;}

        /// <summary>
        /// Desc:作业工机具（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TOOL {get;set;}

        /// <summary>
        /// Desc:开始时间（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? PLANTIME_BEGIN {get;set;}

        /// <summary>
        /// Desc:结束时间（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? PLANTIME_END {get;set;}

        /// <summary>
        /// Desc:负责人姓名（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER_HOME {get;set;}

        /// <summary>
        /// Desc:使用材料（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TOOL_NAME {get;set;}

        /// <summary>
        /// Desc:手机号（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE {get;set;}

        /// <summary>
        /// Desc:维修项目（维修作业-奎屯）(客专维修-青藏) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_NAME {get;set;}

        /// <summary>
        /// Desc:工作量(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_CONTENT {get;set;}

        /// <summary>
        /// Desc:天窗计划号（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_NO {get;set;}

        /// <summary>
        /// Desc:站名-(天窗点外-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME {get;set;}

        /// <summary>
        /// Desc:车间(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CJNAME {get;set;}

        /// <summary>
        /// Desc:工区（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_GQNAME {get;set;}

        /// <summary>
        /// Desc:作业人数（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PERSON_NUM {get;set;}

        /// <summary>
        /// Desc:车站编码（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_CODE {get;set;}

        /// <summary>
        /// Desc:火星经度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARS_LONGITUDE {get;set;}

        /// <summary>
        /// Desc:火星纬度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? MARS_LATITUDE {get;set;}

        /// <summary>
        /// Desc:部门编码（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:调度命令（预留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTROL_NO {get;set;}

        /// <summary>
        /// Desc:备注22 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOTES {get;set;}

        /// <summary>
        /// Desc:工地防护员（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SAFETY_OFFICER {get;set;}

        /// <summary>
        /// Desc:段上道作业命令（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_NO {get;set;}

        /// <summary>
        /// Desc:组别、奎屯所属班组 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GROUP_NAME {get;set;}

        /// <summary>
        /// Desc:驻站防护员(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_OFFICER {get;set;}

        /// <summary>
        /// Desc:驻站地点（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_PLACE {get;set;}

        /// <summary>
        /// Desc:是否使用特种工机具（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ISTOOL {get;set;}

        /// <summary>
        /// Desc:特种工机具号码（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TOOL_NO {get;set;}

        /// <summary>
        /// Desc:上道时间（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? UPTIME_BEGIN {get;set;}

        /// <summary>
        /// Desc:下道时间（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? DOWNTIME_END {get;set;}

        /// <summary>
        /// Desc:联控时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOINTCONTROL_TIME {get;set;}

        /// <summary>
        /// Desc:驻站联络员 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_LIAISONS {get;set;}

        /// <summary>
        /// Desc:现场防护员 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LIVE_OFFICER {get;set;}

        /// <summary>
        /// Desc:东端防护员 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EAST_OFFICER {get;set;}

        /// <summary>
        /// Desc:西端防护员 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WEST_OFFICER {get;set;}

        /// <summary>
        /// Desc:月计划号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MONTH_NO {get;set;}

        /// <summary>
        /// Desc:等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_LEVEL {get;set;}

        /// <summary>
        /// Desc:登记站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_STATION {get;set;}

        /// <summary>
        /// Desc:作业命令号_封闭 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_CLOSED {get;set;}

        /// <summary>
        /// Desc:作业命令号_开通 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_OPEN {get;set;}

        /// <summary>
        /// Desc:作业时间-(天窗点外-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_TIME {get;set;}

        /// <summary>
        /// Desc:核对时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_TIME {get;set;}

        /// <summary>
        /// Desc:协调小组副组长姓名 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COORDINATE_NAME {get;set;}

        /// <summary>
        /// Desc:协调小组副组长职务 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COORDINATE_JOB {get;set;}

        /// <summary>
        /// Desc:协调小组副组长被委托人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COORDINATE_AUTHORIZENAME {get;set;}

        /// <summary>
        /// Desc:协调小组副组长被委托人职务 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COORDINATE_AUTHORIZEJOB {get;set;}

        /// <summary>
        /// Desc:作业命令号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_NO {get;set;}

        /// <summary>
        /// Desc:盯控人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WATCH_NAME {get;set;}

        /// <summary>
        /// Desc:类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLANIN_TYPE {get;set;}

        /// <summary>
        /// Desc:施工单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_DEPTNAME {get;set;}

        /// <summary>
        /// Desc:封闭命令号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLOSE_NO {get;set;}

        /// <summary>
        /// Desc:开通命令号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OPEN_NO {get;set;}

        /// <summary>
        /// Desc:安全监督员 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SAFE_OFFICER {get;set;}

        /// <summary>
        /// Desc:计划显示颜色状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_STATUS {get;set;}

        /// <summary>
        /// Desc:是否提前结束计划 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_ISEND {get;set;}

        /// <summary>
        /// Desc:线别（施工作业-奎屯）(计划-太原)(客专维修-青藏) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME_TWO {get;set;}

        /// <summary>
        /// Desc:行别（施工作业-奎屯）(计划-太原)(客专维修-青藏) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIRECTION_TWO {get;set;}

        /// <summary>
        /// Desc:日期（施工作业-奎屯)(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_DATE {get;set;}

        /// <summary>
        /// Desc:施工里程（施工作业-奎屯） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_MILEAGE {get;set;}

        /// <summary>
        /// Desc:计划时间（施工作业-奎屯） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TIME {get;set;}

        /// <summary>
        /// Desc:维修里程（维修作业-奎屯） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_MILEAGE_TWO {get;set;}

        /// <summary>
        /// Desc:维修时间（维修作业-奎屯） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TIME_TWO {get;set;}

        /// <summary>
        /// Desc:上道时间（点外作业-奎屯） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UPTIME_BEGIN_TWO {get;set;}

        /// <summary>
        /// Desc:下道时间（点外作业-奎屯） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOWNTIME_END_TWO {get;set;}

        /// <summary>
        /// Desc:作业里程（点外作业-奎屯） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_MILEAGE_THERE {get;set;}

        /// <summary>
        /// Desc:解析关键字错误信息（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ERRORINFO {get;set;}

        /// <summary>
        /// Desc:班组(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GROUP_NAME_TWO {get;set;}

        /// <summary>
        /// Desc:时段(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TIME_THREE {get;set;}

        /// <summary>
        /// Desc:作业项目班次(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLASS_NO {get;set;}

        /// <summary>
        /// Desc:内容等级(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTENT_LEVEL {get;set;}

        /// <summary>
        /// Desc:作业区间(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_SECTION {get;set;}

        /// <summary>
        /// Desc:点内点外(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TYPE_TWO {get;set;}

        /// <summary>
        /// Desc:上道人数职工(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ONROAD_EMPLOYEE_NUM {get;set;}

        /// <summary>
        /// Desc:劳务工(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ONROAD_WORKER_NUM {get;set;}

        /// <summary>
        /// Desc:实际上道人员(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ONLOAD_ACTUAL_PEOPLE {get;set;}

        /// <summary>
        /// Desc:作业机具(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TOOL_TWO {get;set;}

        /// <summary>
        /// Desc:防护员驻站(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OFFICER_STATION {get;set;}

        /// <summary>
        /// Desc:工地(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OFFICER_SAFETY {get;set;}

        /// <summary>
        /// Desc:远方(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OFFICER_FAR {get;set;}

        /// <summary>
        /// Desc:计划命令号(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_NO_TWO {get;set;}

        /// <summary>
        /// Desc:作业等级(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_LEVEL_TWO {get;set;}

        /// <summary>
        /// Desc:带班人(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADMAN {get;set;}

        /// <summary>
        /// Desc:带班人手机号(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADMAN_PHONE {get;set;}

        /// <summary>
        /// Desc:带班照片信息(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADIMG_INFO {get;set;}

        /// <summary>
        /// Desc:车间盯控(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJCONTROL {get;set;}

        /// <summary>
        /// Desc:车间盯控手机(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJCONTROL_PHONE {get;set;}

        /// <summary>
        /// Desc:车间盯控照片(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJCONTROL_IMG {get;set;}

        /// <summary>
        /// Desc:站段盯控(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZDCONTROL {get;set;}

        /// <summary>
        /// Desc:站段盯控手机(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZDCONTROL_PHONE {get;set;}

        /// <summary>
        /// Desc:站段盯控照片(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZDCONTROL_IMG {get;set;}

        /// <summary>
        /// Desc:天窗类型（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TYPE_THREE {get;set;}

        /// <summary>
        /// Desc:带班负责人（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER_HOME_TWO {get;set;}

        /// <summary>
        /// Desc:电话号码（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_TWO {get;set;}

        /// <summary>
        /// Desc:作业项目（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_NAME_TWO {get;set;}

        /// <summary>
        /// Desc:计划工作量（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_CONTENT_TWO {get;set;}

        /// <summary>
        /// Desc:上班时间（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UPTIME_BEGIN_THREE {get;set;}

        /// <summary>
        /// Desc:下班时间（广州） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOWNTIME_END_THREE {get;set;}

        /// <summary>
        /// Desc:站名2-(天窗点外-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME_TWO {get;set;}

        /// <summary>
        /// Desc:施工地点（奎屯）(客专维修-青藏) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME_THREE {get;set;}

        /// <summary>
        /// Desc:所属车间（奎屯） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CJNAME_TWO {get;set;}

        /// <summary>
        /// Desc:所属班组（奎屯） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GROUP_NAME_THREE {get;set;}

        /// <summary>
        /// Desc:维修项目（奎屯） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_NAME_THREE {get;set;}

        /// <summary>
        /// Desc:负责人姓名（奎屯） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER_HOME_THREE {get;set;}

        /// <summary>
        /// Desc:作业时间2-(天窗点外-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_TIME_TWO {get;set;}

        /// <summary>
        /// Desc:日计划号-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DAY_PLAN_NUM {get;set;}

        /// <summary>
        /// Desc:流程跟踪-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FLOW_TRACK {get;set;}

        /// <summary>
        /// Desc:所在车间-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_CJNAME {get;set;}

        /// <summary>
        /// Desc:所在工区-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_AREA {get;set;}

        /// <summary>
        /// Desc:封锁里程-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLOSE_MILEAGE {get;set;}

        /// <summary>
        /// Desc:施工类型-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_TYPE {get;set;}

        /// <summary>
        /// Desc:时间-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_TIME {get;set;}

        /// <summary>
        /// Desc:施工内容及影响范围-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_CONTENT_EFFECT {get;set;}

        /// <summary>
        /// Desc:限速及行车方式-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LIMIT_WAY {get;set;}

        /// <summary>
        /// Desc:路用列车信息-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRAIN_INFO {get;set;}

        /// <summary>
        /// Desc:行车限制卡-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DRIVE_LIMIT_CARD {get;set;}

        /// <summary>
        /// Desc:设备变化-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEVICE_CHANGE {get;set;}

        /// <summary>
        /// Desc:审核单位-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_DEPT {get;set;}

        /// <summary>
        /// Desc:运输组织-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRAFFIC_ORG {get;set;}

        /// <summary>
        /// Desc:配合单位-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COOPERATE_DEPT {get;set;}

        /// <summary>
        /// Desc:外局代码-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OTHER_DEPT_CODE {get;set;}

        /// <summary>
        /// Desc:施工日期-(施工计划-惠州段)(客专维修-青藏) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_DATE {get;set;}

        /// <summary>
        /// Desc:盯控级别-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTROL_CLASS {get;set;}

        /// <summary>
        /// Desc:未批复原因-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NO_REPLY_CAUSE {get;set;}

        /// <summary>
        /// Desc:不统计原因-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NO_COUNT_CAUSE {get;set;}

        /// <summary>
        /// Desc:施工领导人-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_LEADER {get;set;}

        /// <summary>
        /// Desc:项目名称-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ITEM_NAME {get;set;}

        /// <summary>
        /// Desc:施工负责人-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_ADMIN {get;set;}

        /// <summary>
        /// Desc:工单变更-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SHEET_CHANGE {get;set;}

        /// <summary>
        /// Desc:驻站联络员手机/电话-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_LIAISONS_TEL {get;set;}

        /// <summary>
        /// Desc:工地防护员手机/电话-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SAFETY_OFFICER_TEL {get;set;}

        /// <summary>
        /// Desc:安全关键事项-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SAFE_NOTICE {get;set;}

        /// <summary>
        /// Desc:给点时间-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GIVE_TIME {get;set;}

        /// <summary>
        /// Desc:给点分钟数-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GIVE_MINUTE {get;set;}

        /// <summary>
        /// Desc:封锁命令-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLOSE_ORDER {get;set;}

        /// <summary>
        /// Desc:开通命令-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OPEN_ORDER {get;set;}

        /// <summary>
        /// Desc:未兑现原因-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NO_ANSWER_CAUSE {get;set;}

        /// <summary>
        /// Desc:完成工作量-(施工计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AMOUNT {get;set;}

        /// <summary>
        /// Desc:审批状态-(天窗点外-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_STATE {get;set;}

        /// <summary>
        /// Desc:作业日期-(天窗点外-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_DATE {get;set;}

        /// <summary>
        /// Desc:段承认号码-(天窗点外-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SECTION_NUM {get;set;}

        /// <summary>
        /// Desc:站段-(天窗点外-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_PART {get;set;}

        /// <summary>
        /// Desc:股道-(天窗点外-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHANNEL {get;set;}

        /// <summary>
        /// Desc:线名-(天窗点外-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME_THREE {get;set;}

        /// <summary>
        /// Desc:起始里程-(天窗点外-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILEAGE_BEGIN_TWO {get;set;}

        /// <summary>
        /// Desc:结束里程-(天窗点外-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILEAGE_END_TWO {get;set;}

        /// <summary>
        /// Desc:作业内容及影响范围-(天窗点外-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_CONTENT_EFFECT {get;set;}

        /// <summary>
        /// Desc:上道人数-(天窗点外-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ON_ROAD_NUM {get;set;}

        /// <summary>
        /// Desc:防护员名单-(天窗点外-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SAFETY_OFFICER_LIST {get;set;}

        /// <summary>
        /// Desc:审批人-(天窗点外-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_MAN {get;set;}

        /// <summary>
        /// Desc:计划号-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_NUM {get;set;}

        /// <summary>
        /// Desc:申请单位-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string APPLY_DEPT {get;set;}

        /// <summary>
        /// Desc:站/区段-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_SECTION {get;set;}

        /// <summary>
        /// Desc:项目-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_ITEM {get;set;}

        /// <summary>
        /// Desc:维修类型-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_TYPE {get;set;}

        /// <summary>
        /// Desc:施工内容-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_CONTENT {get;set;}

        /// <summary>
        /// Desc:作业单位及负责人-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORE_DEPT_LEADER {get;set;}

        /// <summary>
        /// Desc:周计划未批复原因-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WEEK_PLAN_NO_REPLAY_CAUSE {get;set;}

        /// <summary>
        /// Desc:批复的周和补充计划未下达原因-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WEEK_PLAN_NO_EXECUTE_CAUSE {get;set;}

        /// <summary>
        /// Desc:是否周提报计划-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WHETHER_WEEK_PLAN_SUBMIT {get;set;}

        /// <summary>
        /// Desc:是否周计划批复-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WHETHER_WEEK_PLAN_REPLAY {get;set;}

        /// <summary>
        /// Desc:是否补充计划-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WHETHER_SUPPLY_PLAN {get;set;}

        /// <summary>
        /// Desc:驻站联络员和手机-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_LIAISONS_AND_PHO {get;set;}

        /// <summary>
        /// Desc:工地防护员和手机-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SAFETY_OFFICER_AND_PHO {get;set;}

        /// <summary>
        /// Desc:图定天窗分钟-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WINDOWS_MINUTE {get;set;}

        /// <summary>
        /// Desc:主体单位及负责人-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MAIN_DEPT_MANAGER {get;set;}

        /// <summary>
        /// Desc:周计划给点时长-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WEEK_PLAN_GIVE_TIME {get;set;}

        /// <summary>
        /// Desc:有周计划的与施工天窗综合利用-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WEEK_PLAN_WORK_WINDOW {get;set;}

        /// <summary>
        /// Desc:提前四小时报车站临时施工计划的综合利用-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FOUR_HOUR_WORK_PLAN {get;set;}

        /// <summary>
        /// Desc:有周计划的与维修天窗综合利用-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WEEK_PLAN_REPAIR_WINDOW {get;set;}

        /// <summary>
        /// Desc:提前四小时报车站临时维修计划的综合利用-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FOUR_HOUR_REPAIR_PLAN {get;set;}

        /// <summary>
        /// Desc:是否正常用给点-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WHETHER_GIVE_DOT {get;set;}

        /// <summary>
        /// Desc:设备单位-(营业线-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEVICE_DEPT {get;set;}

        /// <summary>
        /// Desc:施工地点里程-(营业线-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_SITE_DISTANCE {get;set;}

        /// <summary>
        /// Desc:开、竣工日期-(营业线-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string START_END_DATE {get;set;}

        /// <summary>
        /// Desc:施工安全存在问题-(营业线-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SAFE_QUESTION {get;set;}

        /// <summary>
        /// Desc:采取的相应措施-(营业线-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HOW_DO {get;set;}

        /// <summary>
        /// Desc:问题整改落实情况-(营业线-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string QUESTION_STATE {get;set;}

        /// <summary>
        /// Desc:慢行长度（m)-(营业线-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SLOW_LENGTH {get;set;}

        /// <summary>
        /// Desc:限速（km/h)-(营业线-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LIMIT_SPEED {get;set;}

        /// <summary>
        /// Desc:联系电话-(营业线-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTACT_TEL {get;set;}

        /// <summary>
        /// Desc:计划类别-(计划类别-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TYPE_FOUR {get;set;}

        /// <summary>
        /// Desc:给点分钟-(维修计划-惠州段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GIVE_MINUTE_TWO {get;set;}

        /// <summary>
        /// Desc:防护员驻站号码(计划-太原)（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OFFICER_STATION_NO {get;set;}

        /// <summary>
        /// Desc:类别(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TYPE_FIVE {get;set;}

        /// <summary>
        /// Desc:序号(计划-太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EXCELIN_NO {get;set;}

        /// <summary>
        /// Desc:地点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_PLACE {get;set;}

        /// <summary>
        /// Desc:施工单位及负责人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_DEPT_MEMBER {get;set;}

        /// <summary>
        /// Desc:海拉尔-工单 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_NUM {get;set;}

        /// <summary>
        /// Desc:海拉尔-计划作业日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_PLAN_DATE {get;set;}

        /// <summary>
        /// Desc:海拉尔-区间车站 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SECTION_STATION {get;set;}

        /// <summary>
        /// Desc:海拉尔-影响范围 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AREA_EFFECT {get;set;}

        /// <summary>
        /// Desc:海拉尔-走行方式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WALK_MODE {get;set;}

        /// <summary>
        /// Desc:海拉尔-作业位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_POSITION {get;set;}

        /// <summary>
        /// Desc:海拉尔-特殊地段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SPECIAL_SECTION {get;set;}

        /// <summary>
        /// Desc:海拉尔-作业项目说明 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_DESC {get;set;}

        /// <summary>
        /// Desc:海拉尔-关联问题清单 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RELATED_PROBLEM {get;set;}

        /// <summary>
        /// Desc:海拉尔-作业时间段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_TIME {get;set;}

        /// <summary>
        /// Desc:海拉尔-三员 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OFFICER_THREE {get;set;}

        /// <summary>
        /// Desc:海拉尔-使用机具及操作人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TOOL_OPERATOR {get;set;}

        /// <summary>
        /// Desc:海拉尔-站段管理 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SECTION_MANAGER {get;set;}

        /// <summary>
        /// Desc:海拉尔-其他作业部门 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OTHER_DEPT {get;set;}

        /// <summary>
        /// Desc:海拉尔-安全风险提示 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SECURITY_RISK_TIP {get;set;}

        /// <summary>
        /// Desc:海拉尔-关键风险点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string KEY_RISK {get;set;}

        /// <summary>
        /// Desc:海拉尔-领导干部 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER_MAN {get;set;}

        /// <summary>
        /// Desc:海拉尔-风险分值 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RISK_SCORE {get;set;}

        /// <summary>
        /// Desc:海拉尔-风险等级 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RISK_LEVEL {get;set;}

        /// <summary>
        /// Desc:海拉尔-是否确认变化 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_CHANGE {get;set;}

        /// <summary>
        /// Desc:海拉尔-工单状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_STATUS {get;set;}

        /// <summary>
        /// Desc:海拉尔-作业类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TYPE_SIX {get;set;}

        /// <summary>
        /// Desc:海拉尔-驻站次数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NUMBER {get;set;}

        /// <summary>
        /// Desc:西安命令票-状态 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_STATE {get;set;}

        /// <summary>
        /// Desc:西安命令票-命令票级别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COMMAND_LEVEL {get;set;}

        /// <summary>
        /// Desc:西安命令票-施工组织批准 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCTION_APPROVE {get;set;}

        /// <summary>
        /// Desc:西安命令票-批准的施工计划 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string APPROVE_PLAN {get;set;}

        /// <summary>
        /// Desc:西安命令票-审批工程师 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string APPROVE_MAN {get;set;}

        /// <summary>
        /// Desc:西安命令票-施工位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCTION_POSITION {get;set;}

        /// <summary>
        /// Desc:西安命令票-施工时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_TIME_XIAN {get;set;}

        /// <summary>
        /// Desc:西安命令票-安全监控人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SAFETY_MAN {get;set;}

        /// <summary>
        /// Desc:西安命令票-施工批准号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string APPROVE_NO {get;set;}

        /// <summary>
        /// Desc:西安命令票-安全员 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SECUTRITY_GUARD {get;set;}

        /// <summary>
        /// Desc:西安命令票-工务段 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_GWD {get;set;}

        /// <summary>
        /// Desc:西安命令票-导入日期（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? IMPORT_DATE {get;set;}

        /// <summary>
        /// Desc:西安命令票-计划得出的负责人手机号(多个)（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_LIST {get;set;}

        /// <summary>
        /// Desc:西安命令票-计划日期段开始日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? DATE_BEGIN {get;set;}

        /// <summary>
        /// Desc:西安命令票-计划日期段结束日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? DATE_END {get;set;}

        /// <summary>
        /// Desc:哈密-午休时间（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REST_TIME {get;set;}

        /// <summary>
        /// Desc:哈密-作业区间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_SECTION_ONE {get;set;}

        /// <summary>
        /// Desc:哈密-点内点外 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TYPE_SEVEN {get;set;}

        /// <summary>
        /// Desc:哈密-作业负责人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER_HOME_FOUR {get;set;}

        /// <summary>
        /// Desc:哈密-上道位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ON_ROAD_POSITION {get;set;}

        /// <summary>
        /// Desc:哈密-下道位置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOWN_ROAD_POSITION {get;set;}

        /// <summary>
        /// Desc:是否正常计划（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_FLAG {get;set;}

        /// <summary>
        /// Desc:安全防护距离一（广州计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? SAFE_RANGE_ONE {get;set;}

        /// <summary>
        /// Desc:安全防护距离二（广州计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? SAFE_RANGE_TWO {get;set;}

        /// <summary>
        /// Desc:使用机具材料(客专维修-青藏) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TOOL_THREE {get;set;}

        /// <summary>
        /// Desc:限速及行车方式变化(客专维修-青藏) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LIMISPEEDDRIVER_TYPE {get;set;}

        /// <summary>
        /// Desc:停电范围(客专维修-青藏) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string POWER_RANGE {get;set;}

        /// <summary>
        /// Desc:配合单位及负责人(客专维修-青藏) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COOPERATE_DEPT_MEMBER {get;set;}

        /// <summary>
        /// Desc:里程（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_MILEAGE_FOUR {get;set;}

        /// <summary>
        /// Desc:计划分钟（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_MINUTES {get;set;}

        /// <summary>
        /// Desc:实际时间命令号（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ACTTIME_COMMANDNO {get;set;}

        /// <summary>
        /// Desc:实际分钟（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ACTPLAN_MINUTES {get;set;}

        /// <summary>
        /// Desc:维修内容及影响范围（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_CONTENT_EFFECT_TWO {get;set;}

        /// <summary>
        /// Desc:计职（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_MEMBER {get;set;}

        /// <summary>
        /// Desc:计民（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_PEOPLE {get;set;}

        /// <summary>
        /// Desc:使用机具(日维修-青藏) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TOOL_FOUR {get;set;}

        /// <summary>
        /// Desc:日作业命令号(日维修-青藏) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DAY_PLAN_COMMANDNO {get;set;}

        /// <summary>
        /// Desc:实职（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ACTPLAN_MEMBER {get;set;}

        /// <summary>
        /// Desc:实民（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ACTPLAN_PEOPLE {get;set;}

        /// <summary>
        /// Desc:盯控干部（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WATCH_NAME_TWO {get;set;}

        /// <summary>
        /// Desc:计划作业量（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_AMOUNT {get;set;}

        /// <summary>
        /// Desc:实际作业量（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ACT_AMOUNT {get;set;}

        /// <summary>
        /// Desc:实际时间（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_TIME_THREE {get;set;}

        /// <summary>
        /// Desc:作业地点（含站）作业里程（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME_FOUR {get;set;}

        /// <summary>
        /// Desc:作业负责人姓名（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER_HOME_FIVE {get;set;}

        /// <summary>
        /// Desc:联系方式（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER_HOME_FIVE_PHONE {get;set;}

        /// <summary>
        /// Desc:防护员情况驻站（台）联络员（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OFFICER_STATION_TWO {get;set;}

        /// <summary>
        /// Desc:实际作业时间（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_TIME_FOUR {get;set;}

        /// <summary>
        /// Desc:实际撤离时间（日维修-青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLANTIME_END_TWO {get;set;}

        /// <summary>
        /// Desc:人员工具情况(日维修-青藏) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TOOL_FIVE {get;set;}

        /// <summary>
        /// Desc:命令号(日维修-青藏) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_NO_THREE {get;set;}

        /// <summary>
        /// Desc:过程监控上道（青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTROL_UP_ROAD {get;set;}

        /// <summary>
        /// Desc:下道（青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOWN_ROAD {get;set;}

        /// <summary>
        /// Desc:实际作业里程（青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ACTWORK_MILE {get;set;}

        /// <summary>
        /// Desc:起始站（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_BEGIN {get;set;}

        /// <summary>
        /// Desc:分钟（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MINUTES {get;set;}

        /// <summary>
        /// Desc:终点站（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_END {get;set;}

        /// <summary>
        /// Desc:作业负责人姓名电话号码(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER_HOME_SIX {get;set;}

        /// <summary>
        /// Desc:开始里程（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string START_MILEAGE {get;set;}

        /// <summary>
        /// Desc:劳力投入（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORKING_INPUT {get;set;}

        /// <summary>
        /// Desc:结束里程（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string END_MILEAGE {get;set;}

        /// <summary>
        /// Desc:派遣单号（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SEND_NUMBER {get;set;}

        /// <summary>
        /// Desc:困难地段（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIFFICULT_SECTION {get;set;}

        /// <summary>
        /// Desc:次数（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NUMBERS {get;set;}

        /// <summary>
        /// Desc:进入栅栏时间（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INPUTFENCE_TIME {get;set;}

        /// <summary>
        /// Desc:申请站（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ENTRY_STATION {get;set;}

        /// <summary>
        /// Desc:封锁时间（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string END_TIME {get;set;}

        /// <summary>
        /// Desc:联络单号（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LIAISONS_NO {get;set;}

        /// <summary>
        /// Desc:开通时间（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BEGIN_TIME {get;set;}

        /// <summary>
        /// Desc:把关人（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATE_KEEPER {get;set;}

        /// <summary>
        /// Desc:配合施工负责人（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER_HOME_SEVEN {get;set;}

        /// <summary>
        /// Desc:限制行车/卡号（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LIMIT_DRIVING {get;set;}

        /// <summary>
        /// Desc:手机（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MOBILE_PHOTO {get;set;}

        /// <summary>
        /// Desc:限速要求（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SPEEDLIMIT_CMD {get;set;}

        /// <summary>
        /// Desc:配合施工单位（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COOPERATE_CONSTRUCT_DEPT {get;set;}

        /// <summary>
        /// Desc:施工方案（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_SCHEME {get;set;}

        /// <summary>
        /// Desc:施工把关人（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_GATE_KEEPER {get;set;}

        /// <summary>
        /// Desc:次日工长动向（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FOREMAN_TREND {get;set;}

        /// <summary>
        /// Desc:股道道岔（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_RAIL {get;set;}

        /// <summary>
        /// Desc:作业方式（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PRACTICES {get;set;}

        /// <summary>
        /// Desc:中间防护员（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MIDDLE_OFFICER {get;set;}

        /// <summary>
        /// Desc:股别（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLASS_SHARES {get;set;}

        /// <summary>
        /// Desc:作业组合（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORKGROUP {get;set;}

        /// <summary>
        /// Desc:安全协议号（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SECURITY_PROTOCOLS {get;set;}

        /// <summary>
        /// Desc:天窗计划编号（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SKYLIGHT_PLAN_NUMBER {get;set;}

        /// <summary>
        /// Desc:维修等级（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_LEVEL {get;set;}

        /// <summary>
        /// Desc:主要使用机具（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MAIN_PLAN_TOOL_FOUR {get;set;}

        /// <summary>
        /// Desc:单元编号（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NUIT_NO {get;set;}

        /// <summary>
        /// Desc:工区班组（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GROUP_NAME_FOUR {get;set;}

        /// <summary>
        /// Desc:计划下道时间（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_DOWNROAD_TIME {get;set;}

        /// <summary>
        /// Desc:机具使用人（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MACHINE_USER {get;set;}

        /// <summary>
        /// Desc:工地负责人手机（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER_HOME_SITE_PHONE {get;set;}

        /// <summary>
        /// Desc:工地负责人（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER_HOME_SITE {get;set;}

        /// <summary>
        /// Desc:计划上道时间（新长） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_ONROAD_TIME {get;set;}

        /// <summary>
        /// Desc:单位编号（北京） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_GWD_ONE {get;set;}

        /// <summary>
        /// Desc:起点里程（北京） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILEAGE_BEGIN_THERE {get;set;}

        /// <summary>
        /// Desc:终点里程（北京） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILEAGE_END_THERE {get;set;}

        /// <summary>
        /// Desc:起点里程1（北京） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILEAGE_BEGIN_FOUR {get;set;}

        /// <summary>
        /// Desc:终点里程1（北京） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILEAGE_END_FOUR {get;set;}

        /// <summary>
        /// Desc:车站名（北京） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME_FIVE {get;set;}

        /// <summary>
        /// Desc:下行站界（北京） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME_DOWN {get;set;}

        /// <summary>
        /// Desc:上行站界（北京） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME_UP {get;set;}

        /// <summary>
        /// Desc:道岔（北京） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRACK_RAIL_ONE {get;set;}

        /// <summary>
        /// Desc:桥号（北京） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BRIDGE_NUM {get;set;}

        /// <summary>
        /// Desc:防护员（北京） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SAFETY_OFFICER_ONE {get;set;}

        /// <summary>
        /// Desc:驻站员（北京） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_OFFICER_ONE {get;set;}

        /// <summary>
        /// Desc:重点机具（北京） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TOOL_SIX {get;set;}

        /// <summary>
        /// Desc:汽车动向及驾驶员（北京） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CAR_DRIVER {get;set;}

        /// <summary>
        /// Desc:工长去向（北京） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FOREMAN_TREND_ONE {get;set;}

        /// <summary>
        /// Desc:临时工人数（北京） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ONROAD_NUM_ONE {get;set;}

        /// <summary>
        /// Desc:机械号（北京） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MACHINE_NUM {get;set;}

        /// <summary>
        /// Desc:汽车号（北京） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CAR_NUM {get;set;}

        /// <summary>
        /// Desc:计划日期(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_DATE_ONE {get;set;}

        /// <summary>
        /// Desc:线路名称(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME_FOUR {get;set;}

        /// <summary>
        /// Desc:天窗单元名称(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SKYLIGHT_NAME {get;set;}

        /// <summary>
        /// Desc:天窗单元起点车站(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SKYLIGHT_NAME_START {get;set;}

        /// <summary>
        /// Desc:天窗单元终点车站(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SKYLIGHT_NAME_END {get;set;}

        /// <summary>
        /// Desc:作业起始里程(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILEAGE_BEGIN_FIVE {get;set;}

        /// <summary>
        /// Desc:作业终止里程(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILEAGE_END_FIVE {get;set;}

        /// <summary>
        /// Desc:作业级别(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_LEVEL_THREE {get;set;}

        /// <summary>
        /// Desc:天窗类别(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TYPE_EIGHT {get;set;}

        /// <summary>
        /// Desc:天窗级别(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_LEVEL_FOUR {get;set;}

        /// <summary>
        /// Desc:主体作业班组(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GROUP_NAME_FIVE {get;set;}

        /// <summary>
        /// Desc:共用作业班组(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GROUP_NAME_SIX {get;set;}

        /// <summary>
        /// Desc:配合作业班组(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GROUP_NAME_SEVEN {get;set;}

        /// <summary>
        /// Desc:作业分类(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_CATEGORIES {get;set;}

        /// <summary>
        /// Desc:作业门位置(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GATE_LOCATION {get;set;}

        /// <summary>
        /// Desc:登记车站(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REGISTER_NAME {get;set;}

        /// <summary>
        /// Desc:驻站防护员所在站(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME_OFFICER {get;set;}

        /// <summary>
        /// Desc:路用车始发站(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAILWAY_STATION {get;set;}

        /// <summary>
        /// Desc:主体作业负责人(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER_HOME_MAIN {get;set;}

        /// <summary>
        /// Desc:共用作业负责人(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER_HOME_SHARE {get;set;}

        /// <summary>
        /// Desc:配合作业负责人(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER_HOME_MATE {get;set;}

        /// <summary>
        /// Desc:质检员(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INSPECTOR_NAME {get;set;}

        /// <summary>
        /// Desc:其他配合单位(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OTHER_MATE_DEPT {get;set;}

        /// <summary>
        /// Desc:是否转非常站控(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string IS_STATION_CONTROL {get;set;}

        /// <summary>
        /// Desc:作业原因(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_CAUSE {get;set;}

        /// <summary>
        /// Desc:主要工机具(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TOOL_MAIN {get;set;}

        /// <summary>
        /// Desc:小车执机人(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CAR_HOLDER {get;set;}

        /// <summary>
        /// Desc:驻所防护员(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_OFFICER_TWO {get;set;}

        /// <summary>
        /// Desc:职工作业人数(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PERSON_NUM_ONE {get;set;}

        /// <summary>
        /// Desc:辅助工作业人数(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PERSON_NUM_TWO {get;set;}

        /// <summary>
        /// Desc:本单元是否有路用车配合(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAILWAY_ISMATE {get;set;}

        /// <summary>
        /// Desc:相邻线天窗内是否有路用车(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAILWAY_ISMATE_NEAR {get;set;}

        /// <summary>
        /// Desc:是否上线(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string IS_ONLINE {get;set;}

        /// <summary>
        /// Desc:起讫时间(分)(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TIME_FOUR {get;set;}

        /// <summary>
        /// Desc:主要备料(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MATERIAL_MAIN {get;set;}

        /// <summary>
        /// Desc:状态(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_STATE_ONE {get;set;}

        /// <summary>
        /// Desc:包保干部(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHARGE_NAME {get;set;}

        /// <summary>
        /// Desc:确认码(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONFIRM_CODE {get;set;}

        /// <summary>
        /// Desc:段(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_GWD_TWO {get;set;}

        /// <summary>
        /// Desc:区间或车站(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SECTION_STATION_ONE {get;set;}

        /// <summary>
        /// Desc:作业地点起点里程(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILEAGE_BEGIN_SIX {get;set;}

        /// <summary>
        /// Desc:道岔号或股道编号(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHANNEL_NUM {get;set;}

        /// <summary>
        /// Desc:天窗作业是否天窗(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string IS_SKYLIGHT {get;set;}

        /// <summary>
        /// Desc:起讫时间时长(分)(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TIME_FIVE {get;set;}

        /// <summary>
        /// Desc:是否共用(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string IS_SHARE {get;set;}

        /// <summary>
        /// Desc:是否有路用车配合(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAILWAY_ISMATE_ONE {get;set;}

        /// <summary>
        /// Desc:主要工机具名称(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TOOL_MAIN_NAME {get;set;}

        /// <summary>
        /// Desc:执机人(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CAR_HOLDER_NAME {get;set;}

        /// <summary>
        /// Desc:职务(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LEADER_HOME_JOB {get;set;}

        /// <summary>
        /// Desc:把关人员姓名电话号码(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_HOME_NAME {get;set;}

        /// <summary>
        /// Desc:职务1(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_HOME_JOB {get;set;}

        /// <summary>
        /// Desc:防护员姓名及联系方式驻站电话号码(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_OFFICER_PHONE {get;set;}

        /// <summary>
        /// Desc:工地电话号码(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SAFETY_OFFICER_PHONE {get;set;}

        /// <summary>
        /// Desc:中间联络电话号码(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LIAISON_PHONE {get;set;}

        /// <summary>
        /// Desc:远端电话号码(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SAFETY_PHONE {get;set;}

        /// <summary>
        /// Desc:作业人数职工(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PERSON_NUM_THREE {get;set;}

        /// <summary>
        /// Desc:其他(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PERSON_NUM_OTHER {get;set;}

        /// <summary>
        /// Desc:车间审核审核人(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_CHECK_NAME {get;set;}

        /// <summary>
        /// Desc:审核意见(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_CHECK_AGREE {get;set;}

        /// <summary>
        /// Desc:段审批审批人(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DUAN_CHECK_NAME {get;set;}

        /// <summary>
        /// Desc:审批意见(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DUAN_CHECK_AGREE {get;set;}

        /// <summary>
        /// Desc:主管副段长(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DUAN_CHECK_SECONDNAME {get;set;}

        /// <summary>
        /// Desc:审核意见1(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DUAN_CHECK_SECONDAGREE {get;set;}

        /// <summary>
        /// Desc:工作量(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_CONTENT_THREE {get;set;}

        /// <summary>
        /// Desc:驻站手机与防护范围，南昌普铁用（计算保留） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_OFFICER_PHONE_MILEAGE {get;set;}

        /// <summary>
        /// Desc:影响范围及有关要求（集宁） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string AREA_EFFECT_ONE {get;set;}

        /// <summary>
        /// Desc:线别/站名（集宁） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME_SIX {get;set;}

        /// <summary>
        /// Desc:里程范围（集宁） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_MILEAGE_FIVE {get;set;}

        /// <summary>
        /// Desc:参加人数（集宁） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PERSON_NUM_FOUR {get;set;}

        /// <summary>
        /// Desc:供电臂（怀化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SUPPLY_ARM {get;set;}

        /// <summary>
        /// Desc:驻站联络员（巡线手机）（南昌巡检） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_LIAISONS_TEL_TWO {get;set;}

        /// <summary>
        /// Desc:工地防护员（巡线手机）（南昌巡检） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SAFETY_OFFICER_TEL_TWO {get;set;}

        /// <summary>
        /// Desc:巡查巡检人（巡线手机）（南昌巡检） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INSPECTION_TEL {get;set;}

        /// <summary>
        /// Desc:计划时间起始时间（南昌巡检） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLANTIME_BEGIN_THREE {get;set;}

        /// <summary>
        /// Desc:终止时间（南昌巡检） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLANTIME_END_THREE {get;set;}

        /// <summary>
        /// Desc:计划里程开始里程（南昌巡检） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILEAGE_BEGIN_SEVEN {get;set;}

        /// <summary>
        /// Desc:终止里程（南昌巡检） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MILEAGE_END_SEVEN {get;set;}

        /// <summary>
        /// Desc:检查情况（南昌巡检） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INSPECTION_CONDITIONS {get;set;}

        /// <summary>
        /// Desc:检查人（南昌巡检） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string INSPECTION_USER {get;set;}

        /// <summary>
        /// Desc:开始调度命令号(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTROL_NO_BEGIN {get;set;}

        /// <summary>
        /// Desc:结束调度命令号(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTROL_NO_END {get;set;}

        /// <summary>
        /// Desc:作业人员(武汉高铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_PERSON {get;set;}

        /// <summary>
        /// Desc:风险等级(太原专用,保留字段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SAFE_LEVEL {get;set;}

        /// <summary>
        /// Desc:计划作业地点(北京高铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_NAME_ONE {get;set;}

        /// <summary>
        /// Desc:作业项目及内容(北京高铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_NAME_CONTENT {get;set;}

        /// <summary>
        /// Desc:是否天窗(北京高铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string IS_SKYLIGHT_ONE {get;set;}

        /// <summary>
        /// Desc:上线通道(北京高铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UP_LINE_PATH {get;set;}

        /// <summary>
        /// Desc:下线通道(北京高铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOWN_LINE_PATH {get;set;}

        /// <summary>
        /// Desc:路工(北京高铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ROAD_WORKER_NUM {get;set;}

        /// <summary>
        /// Desc:委外工程人员(北京高铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OUTSOURCING_PERSON_NUM {get;set;}

        /// <summary>
        /// Desc:其他单位人员(北京高铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OTHER_UNIT_PERSON_NUM {get;set;}

        /// <summary>
        /// Desc:车间盯控干部(北京高铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_CONTROLER {get;set;}

        /// <summary>
        /// Desc:段盯控干部(北京高铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string D_CONTROLER {get;set;}

        /// <summary>
        /// Desc:驻 所（站）员(北京高铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_PERSON_NAME {get;set;}

        /// <summary>
        /// Desc:工务小车登记编号(北京高铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORKS_CAR_NO {get;set;}

        /// <summary>
        /// Desc:负责人类型(保留字段) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONELIST_TYPE {get;set;}

        /// <summary>
        /// Desc:计划开始日期(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? PLANTIME_DATE {get;set;}

        /// <summary>
        /// Desc:计划开始时间(南昌) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLANTIME_TIME {get;set;}

        /// <summary>
        /// Desc:工单号（青藏西宁） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_NUM_ONE {get;set;}

        /// <summary>
        /// Desc:实际时间及命令号（青藏西宁） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORKTIME_COMMANDNO {get;set;}

        /// <summary>
        /// Desc:人员（青藏西宁） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_PERSON_ONE {get;set;}

        /// <summary>
        /// Desc:通话（青藏西宁） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COMMUNICATION_CONTENT {get;set;}

        /// <summary>
        /// Desc:问题（青藏西宁） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JOB_PROBLEM {get;set;}

        /// <summary>
        /// Desc:抽查人（青藏西宁） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TEST_PEOPLE {get;set;}

        /// <summary>
        /// Desc:编制单位(绥化) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UNIT_DEPTNAME {get;set;}

        /// <summary>
        /// Desc:计划状态（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_STATE_TWO {get;set;}

        /// <summary>
        /// Desc:作业号（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_NO {get;set;}

        /// <summary>
        /// Desc:班次（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GROUP_TURN {get;set;}

        /// <summary>
        /// Desc:作业时段（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLANTIME_SECTION {get;set;}

        /// <summary>
        /// Desc:职工数（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PERSON_NUM_FIVE {get;set;}

        /// <summary>
        /// Desc:机具（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_TOOL_SEVEN {get;set;}

        /// <summary>
        /// Desc:驻站防护人（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OFFICER_STATION_THREE {get;set;}

        /// <summary>
        /// Desc:现场防护人（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LIVE_OFFICER_TWO {get;set;}

        /// <summary>
        /// Desc:远方防护人（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OFFICER_FAR_TWO {get;set;}

        /// <summary>
        /// Desc:工区留守人数（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_LEFTNUM {get;set;}

        /// <summary>
        /// Desc:工区值班人（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_DUTY {get;set;}

        /// <summary>
        /// Desc:工区上报人（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_REPORTER {get;set;}

        /// <summary>
        /// Desc:工区上报时间（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GQ_REPORTTIME {get;set;}

        /// <summary>
        /// Desc:车间盯控人（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJCONTROL_TWO {get;set;}

        /// <summary>
        /// Desc:车间审批人（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_CHECK_NAME_TWO {get;set;}

        /// <summary>
        /// Desc:车间审核上报时间（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_CHECK_REPORTTIME {get;set;}

        /// <summary>
        /// Desc:段盯控人（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DUAN_WATCH {get;set;}

        /// <summary>
        /// Desc:段审批人（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DUAN_CHECK {get;set;}

        /// <summary>
        /// Desc:段审批时间（绥化） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DUAN_CHECK_TIME {get;set;}

        /// <summary>
        /// Desc:计划ID（呼和） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EXCELIN_ID {get;set;}

        /// <summary>
        /// Desc:区间/站内(呼和) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SECTION_STATION_TWO {get;set;}

        /// <summary>
        /// Desc:调度审批意见（呼和） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTROL_CHECK_AGREE {get;set;}

        /// <summary>
        /// Desc:消号标志（呼和） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DESTROYNO_FLAG {get;set;}

        /// <summary>
        /// Desc:详细（呼和） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DETAIL_CONTENT {get;set;}

        /// <summary>
        /// Desc:安全预想（呼和） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SAFE_EXPECTATION {get;set;}

        /// <summary>
        /// Desc:周计划（呼和） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WHETHER_WEEKPLAN {get;set;}

        /// <summary>
        /// Desc:施工主体单位（呼和） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_DEPT_MANAGER {get;set;}

        /// <summary>
        /// Desc:路用车（呼和） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAIL_WAY {get;set;}

        /// <summary>
        /// Desc:业务处室（呼和） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BUSINESS_OFFICE {get;set;}

        /// <summary>
        /// Desc:会签（呼和） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COUNTER_SIGN {get;set;}

        /// <summary>
        /// Desc:行车限速卡（呼和） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SPEED_LIMIT_CARD {get;set;}

        /// <summary>
        /// Desc:审核流程（呼和） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_FLOW {get;set;}

        /// <summary>
        /// Desc:审核处室（呼和） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_OFFICE {get;set;}

        /// <summary>
        /// Desc:电话（呼和） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PHONE_THREE {get;set;}

        /// <summary>
        /// Desc:路用车信息（呼和） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAILWAY_INFO {get;set;}

        /// <summary>
        /// Desc:计划来源(绥化) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_FROM {get;set;}

        /// <summary>
        /// Desc:小车令(绥化) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CAR_COMMANDNO {get;set;}

        /// <summary>
        /// Desc:状态位(合肥日计划) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATE_BIT {get;set;}

        /// <summary>
        /// Desc:驻站(合肥日计划 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OFFICER_STATION_FOUR {get;set;}

        /// <summary>
        /// Desc:所属单位(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ORGCJ_DEPT {get;set;}

        /// <summary>
        /// Desc:非工务配合单位(南昌普铁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OTHER_COOPERATE_DEPT {get;set;}

        /// <summary>
        /// Desc:中间联络人（南昌普铁） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LIAISON_MEMBER {get;set;}

        /// <summary>
        /// Desc:职工(西宁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PERSON_NUM_SIX {get;set;}

        /// <summary>
        /// Desc:作业单位（西宁） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_DEPTNAME_TWO {get;set;}

        /// <summary>
        /// Desc:作业地点线别（沈阳） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LINE_NAME_FIVE {get;set;}

        /// <summary>
        /// Desc:里程或位置（沈阳） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_MILEAGE_SIX {get;set;}

        /// <summary>
        /// Desc:作业分组（沈阳） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GROUP_NAME_EIGHT {get;set;}

        /// <summary>
        /// Desc:车间审核（沈阳） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CJ_CHECK_NAME_THREE {get;set;}

        /// <summary>
        /// Desc:施工、维修序号（沈阳） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_NUM_TWO {get;set;}

        /// <summary>
        /// Desc:远端防护员前（沈阳） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FAR_OFFICER_FRONT {get;set;}

        /// <summary>
        /// Desc:后（沈阳） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FAR_OFFICER_BACK {get;set;}

        /// <summary>
        /// Desc:说明栏（沈阳） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOTES_TWO {get;set;}

        /// <summary>
        /// Desc:设备ID号(西宁) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEVICE_CODE {get;set;}

        /// <summary>
        /// Desc:限界（天津） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LIMITATION_BOUNDS {get;set;}

        /// <summary>
        /// Desc:远端防护员（沈阳） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FAR_OFFICER {get;set;}

        /// <summary>
        /// Desc:编号(湖东车辆) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EXCELIN_NO_ONE {get;set;}

        /// <summary>
        /// Desc:天窗日期(湖东车辆) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_DATE_ONE {get;set;}

        /// <summary>
        /// Desc:天窗时间(湖东车辆) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WORK_TIME_FIVE {get;set;}

        /// <summary>
        /// Desc:计划里程（青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PLAN_MILEAGE_SEVEN {get;set;}

        /// <summary>
        /// Desc:驻站（台）联络员（青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string STATION_LIAISONS_ONE {get;set;}

        /// <summary>
        /// Desc:实际上道时间/作业命令号（青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string UPTIME_IN {get;set;}

        /// <summary>
        /// Desc:实际下道时间（青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DOWNTIME_IN {get;set;}

        /// <summary>
        /// Desc:施工等级（青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_LEVEL {get;set;}

        /// <summary>
        /// Desc:调度命令号（封锁/开通）（青藏） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONTROL_NO_ONE {get;set;}

        /// <summary>
        /// Desc:审批级别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_LEVEL {get;set;}

        /// <summary>
        /// Desc:维修级别 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string REPAIR_LEVEL_TWO {get;set;}

        /// <summary>
        /// Desc:天窗单元 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SKYLIGHT_UNIT {get;set;}

        /// <summary>
        /// Desc:行别或站内 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DIRECTION_THREE {get;set;}

        /// <summary>
        /// Desc:作业班组主体 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GROUP_NAME_NINE {get;set;}

        /// <summary>
        /// Desc:共用 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GROUP_NAME_TEN {get;set;}

        /// <summary>
        /// Desc:配合 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GROUP_NAME_ELEVEN {get;set;}

        /// <summary>
        /// Desc:施工作业负责人主体 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_LEADER_MAIN {get;set;}

        /// <summary>
        /// Desc:施工作业负责人共用 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_LEADER_SHARE {get;set;}

        /// <summary>
        /// Desc:施工作业负责人配合 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CONSTRUCT_LEADER_MATE {get;set;}

        /// <summary>
        /// Desc:驻所 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string OFFICER_RESIDENCE {get;set;}

        /// <summary>
        /// Desc:辅助 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string PERSON_NUM_COOPERATE {get;set;}

        /// <summary>
        /// Desc:作业指导书或施工组织 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GUID_CONSTRUCTION {get;set;}

        /// <summary>
        /// Desc:路用列车本单元是否有路用车配合 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TRAIN_INFO_SELF {get;set;}

        /// <summary>
        /// Desc:审批人段审核小组 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_GROUP_DUAN {get;set;}

        /// <summary>
        /// Desc:路局 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CHECK_GROUP_JU {get;set;}

        /// <summary>
        /// Desc:天窗命令号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SKYLIGHT_CMD_NO {get;set;}

        /// <summary>
        /// Desc:是否APP回复 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string APP_HASREPLAY {get;set;}

        /// <summary>
        /// Desc:是否导入到断轨计划(太原) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RAILPLAN_STATE {get;set;}

        /// <summary>
        /// Desc:APP上一步操作步骤（武汉桥） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string APP_LSTSTEP {get;set;}

        /// <summary>
        /// Desc:补充说明 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string NOTES_THREE {get;set;}

        /// <summary>
        /// Desc:月计 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MONTH_NO_ONE {get;set;}

        /// <summary>
        /// Desc:日计 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DAY_PLAN_NUM_ONE {get;set;}

        /// <summary>
        /// Desc:封锁/开通命令 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLOSE_OPEN_ORDER {get;set;}

        /// <summary>
        /// Desc:现场防护 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LIVE_OFFICER_ONE {get;set;}

    }
}
