using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class CURVE_RAIL
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string CURBASEID {get;set;}

        /// <summary>
        /// Desc:年份	 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string YEAR {get;set;}

        /// <summary>
        /// Desc:更换日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? CHANGEDATE {get;set;}

        /// <summary>
        /// Desc:长轨 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LONGRAIL {get;set;}

        /// <summary>
        /// Desc:普轨 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string COMMONRAIL {get;set;}

        /// <summary>
        /// Desc:使用月数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? USEMONTHS {get;set;}

        /// <summary>
        /// Desc:侧1 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? H1 {get;set;}

        /// <summary>
        /// Desc:侧2 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? H2 {get;set;}

        /// <summary>
        /// Desc:侧3 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? H3 {get;set;}

        /// <summary>
        /// Desc:侧4 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? H4 {get;set;}

        /// <summary>
        /// Desc:侧5 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? H5 {get;set;}

        /// <summary>
        /// Desc:侧6 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? H6 {get;set;}

        /// <summary>
        /// Desc:侧7 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? H7 {get;set;}

        /// <summary>
        /// Desc:侧8 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? H8 {get;set;}

        /// <summary>
        /// Desc:侧9 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? H9 {get;set;}

        /// <summary>
        /// Desc:侧10 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? H10 {get;set;}

        /// <summary>
        /// Desc:侧11 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? H11 {get;set;}

        /// <summary>
        /// Desc:侧12 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? H12 {get;set;}

        /// <summary>
        /// Desc:磨耗数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? HWEARQUANTITY {get;set;}

        /// <summary>
        /// Desc:起点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? HSTARLC {get;set;}

        /// <summary>
        /// Desc:终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? HENDLC {get;set;}

        /// <summary>
        /// Desc:长度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? HLENGTH {get;set;}

        /// <summary>
        /// Desc:磨耗速率 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? HWEARRATE {get;set;}

        /// <summary>
        /// Desc:上股调边 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HUPPEREDGE {get;set;}

        /// <summary>
        /// Desc:下股调边 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HENDEREDGE {get;set;}

        /// <summary>
        /// Desc:调边周期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? HEDGECYCLE {get;set;}

        /// <summary>
        /// Desc:调边时侧磨量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? HEDGEHNUM {get;set;}

        /// <summary>
        /// Desc:更换周期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? HCHANGECYCLE {get;set;}

        /// <summary>
        /// Desc:更换时侧磨量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? HCHANGEHNUM {get;set;}

        /// <summary>
        /// Desc:预计更换日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? HEXPECTCHANGEDATE {get;set;}

        /// <summary>
        /// Desc:换轨调边 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HCHANGERAILEDGE {get;set;}

        /// <summary>
        /// Desc:垂1 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? V1 {get;set;}

        /// <summary>
        /// Desc:垂2 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? V2 {get;set;}

        /// <summary>
        /// Desc:垂3 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? V3 {get;set;}

        /// <summary>
        /// Desc:垂4 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? V4 {get;set;}

        /// <summary>
        /// Desc:垂5 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? V5 {get;set;}

        /// <summary>
        /// Desc:垂6 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? V6 {get;set;}

        /// <summary>
        /// Desc:垂7 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? V7 {get;set;}

        /// <summary>
        /// Desc:垂8 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? V8 {get;set;}

        /// <summary>
        /// Desc:垂9 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? V9 {get;set;}

        /// <summary>
        /// Desc:垂10 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? V10 {get;set;}

        /// <summary>
        /// Desc:垂11 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? V11 {get;set;}

        /// <summary>
        /// Desc:垂12 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? V12 {get;set;}

        /// <summary>
        /// Desc:垂磨磨耗数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? VWEARQUANTITY {get;set;}

        /// <summary>
        /// Desc:垂磨起点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? VSTARLC {get;set;}

        /// <summary>
        /// Desc:垂磨终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? VENDLC {get;set;}

        /// <summary>
        /// Desc:垂磨长度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? VLENGTH {get;set;}

        /// <summary>
        /// Desc:垂磨磨耗速率 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? VWEARRATE {get;set;}

        /// <summary>
        /// Desc:垂磨上股调边 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string VUPPEREDGE {get;set;}

        /// <summary>
        /// Desc:垂磨下股调边 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string VENDEREDGE {get;set;}

        /// <summary>
        /// Desc:垂磨调边周期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? VEDGECYCLE {get;set;}

        /// <summary>
        /// Desc:垂磨调边时垂磨量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? VEDGEHNUM {get;set;}

        /// <summary>
        /// Desc:垂磨更换周期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? VCHANGECYCLE {get;set;}

        /// <summary>
        /// Desc:垂磨更换时垂磨量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? VCHANGEHNUM {get;set;}

        /// <summary>
        /// Desc:垂磨预计更换日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? VEXPECTCHANGEDATE {get;set;}

        /// <summary>
        /// Desc:垂磨换轨调边 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string VCHANGERAILEDGE {get;set;}

        /// <summary>
        /// Desc:总1 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TOTAL1 {get;set;}

        /// <summary>
        /// Desc:总2 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TOTAL2 {get;set;}

        /// <summary>
        /// Desc:总3 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TOTAL3 {get;set;}

        /// <summary>
        /// Desc:总4 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TOTAL4 {get;set;}

        /// <summary>
        /// Desc:总5 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TOTAL5 {get;set;}

        /// <summary>
        /// Desc:总6 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TOTAL6 {get;set;}

        /// <summary>
        /// Desc:总7 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TOTAL7 {get;set;}

        /// <summary>
        /// Desc:总8 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TOTAL8 {get;set;}

        /// <summary>
        /// Desc:总9 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TOTAL9 {get;set;}

        /// <summary>
        /// Desc:总10 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TOTAL10 {get;set;}

        /// <summary>
        /// Desc:总11 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TOTAL11 {get;set;}

        /// <summary>
        /// Desc:总12 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TOTAL12 {get;set;}

        /// <summary>
        /// Desc:总磨磨耗数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TWEARQUANTITY {get;set;}

        /// <summary>
        /// Desc:总磨起点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TSTARLC {get;set;}

        /// <summary>
        /// Desc:总磨终点 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TENDLC {get;set;}

        /// <summary>
        /// Desc:总磨长度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? TLENGTH {get;set;}

        /// <summary>
        /// Desc:总磨磨耗速率 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Double? TWEARRATE {get;set;}

        /// <summary>
        /// Desc:总磨上股调边 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TUPPEREDGE {get;set;}

        /// <summary>
        /// Desc:总磨下股调边 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TENDEREDGE {get;set;}

        /// <summary>
        /// Desc:总磨调边周期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? TEDGECYCLE {get;set;}

        /// <summary>
        /// Desc:总磨调边时总磨量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? TEDGEHNUM {get;set;}

        /// <summary>
        /// Desc:总磨更换周期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? TCHANGECYCLE {get;set;}

        /// <summary>
        /// Desc:总磨更换时总磨量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? TCHANGEHNUM {get;set;}

        /// <summary>
        /// Desc:总磨预计更换日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? TEXPECTCHANGEDATE {get;set;}

        /// <summary>
        /// Desc:总磨换轨调边 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TCHANGERAILEDGE {get;set;}

        /// <summary>
        /// Desc:创建日期 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? T_CRT_TM {get;set;}

        /// <summary>
        /// Desc:创建人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_CRT_NAME {get;set;}

        /// <summary>
        /// Desc:排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? N_ORDER {get;set;}

        /// <summary>
        /// Desc:备注 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string C_MEMO {get;set;}

    }
}
