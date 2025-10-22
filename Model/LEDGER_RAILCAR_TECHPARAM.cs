using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class LEDGER_RAILCAR_TECHPARAM
    {
        
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string PKID {get;set;}

        /// <summary>
        /// Desc:设备分类 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SBFL {get;set;}

        /// <summary>
        /// Desc:现有数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SBSL {get;set;}

        /// <summary>
        /// Desc:整车 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZC {get;set;}

        /// <summary>
        /// Desc:设备名称 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SBMC {get;set;}

        /// <summary>
        /// Desc:型号规格 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string XHGG {get;set;}

        /// <summary>
        /// Desc:生产单位 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SCDW {get;set;}

        /// <summary>
        /// Desc:轨距 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GJ {get;set;}

        /// <summary>
        /// Desc:车轮直径 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLZJ {get;set;}

        /// <summary>
        /// Desc:车辆定距 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLDJ {get;set;}

        /// <summary>
        /// Desc:构造速度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GZSD {get;set;}

        /// <summary>
        /// Desc:制动方式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZDFS {get;set;}

        /// <summary>
        /// Desc:车钩中心高度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CGZXGD {get;set;}

        /// <summary>
        /// Desc:燃油箱总容量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string RYXZRL {get;set;}

        /// <summary>
        /// Desc:轴距 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZJ {get;set;}

        /// <summary>
        /// Desc:轴列式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZLS {get;set;}

        /// <summary>
        /// Desc:最高运行速度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZGYXSD {get;set;}

        /// <summary>
        /// Desc:传动形式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZDXS {get;set;}

        /// <summary>
        /// Desc:通过最小曲线半径 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TGZXQXBJ {get;set;}

        /// <summary>
        /// Desc:整备重量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZBZL {get;set;}

        /// <summary>
        /// Desc:外形尺寸 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WXCC {get;set;}

        /// <summary>
        /// Desc:发动机 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJ {get;set;}

        /// <summary>
        /// Desc:型号规格 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJ_XHGG {get;set;}

        /// <summary>
        /// Desc:部件厂家 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJ_BJCJ {get;set;}

        /// <summary>
        /// Desc:数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJ_SL {get;set;}

        /// <summary>
        /// Desc:类型 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJ_LX {get;set;}

        /// <summary>
        /// Desc:缸径×行程 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJGJXC {get;set;}

        /// <summary>
        /// Desc:空载时最高转速 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string KZSZGZS {get;set;}

        /// <summary>
        /// Desc:气门间隙 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string QMJX {get;set;}

        /// <summary>
        /// Desc:发动机型号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJXH {get;set;}

        /// <summary>
        /// Desc:排量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJXH_PL {get;set;}

        /// <summary>
        /// Desc:怠速 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJXH_DS {get;set;}

        /// <summary>
        /// Desc:发火顺序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJXH_FHSX {get;set;}

        /// <summary>
        /// Desc:额定功率/转速 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJXH_EDGL {get;set;}

        /// <summary>
        /// Desc:液力变矩器（变速箱） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string YLBJQ {get;set;}

        /// <summary>
        /// Desc:型号规格 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string YLBJQ_XHGG {get;set;}

        /// <summary>
        /// Desc:部件厂家 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string YLBJQ_BJCJ {get;set;}

        /// <summary>
        /// Desc:数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string YLBJQ_SL {get;set;}

        /// <summary>
        /// Desc:动力自动换挡变速箱主要技术参数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DLZDHDBSXZYJSCS {get;set;}

        /// <summary>
        /// Desc:型号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string XH {get;set;}

        /// <summary>
        /// Desc:液力驱动效率 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string YLQDXL {get;set;}

        /// <summary>
        /// Desc:闭锁驱动效率 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BSQDXL {get;set;}

        /// <summary>
        /// Desc:额定输入功率 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EDSRGL {get;set;}

        /// <summary>
        /// Desc:允许油压 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string YXYY {get;set;}

        /// <summary>
        /// Desc:允许油温 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string YXYW {get;set;}

        /// <summary>
        /// Desc:换向操作方式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HXCZFS {get;set;}

        /// <summary>
        /// Desc:驱动 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string QD {get;set;}

        /// <summary>
        /// Desc:主齿轮泵 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZYLK {get;set;}

        /// <summary>
        /// Desc:机油加热器 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JYJRQ {get;set;}

        /// <summary>
        /// Desc:重量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZL {get;set;}

        /// <summary>
        /// Desc:失速扭矩比 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SSNJB {get;set;}

        /// <summary>
        /// Desc:油压（发动机转速2100rpm时） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string YY {get;set;}

        /// <summary>
        /// Desc:额定输入转速 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string EDSRZS {get;set;}

        /// <summary>
        /// Desc:允许油压降 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string YSYYJ {get;set;}

        /// <summary>
        /// Desc:换挡操作方式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HJCZFS {get;set;}

        /// <summary>
        /// Desc:换挡方法 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HDFF {get;set;}

        /// <summary>
        /// Desc:减速比 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JSB {get;set;}

        /// <summary>
        /// Desc:后油泵（用于润滑） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HYB {get;set;}

        /// <summary>
        /// Desc:推荐油液 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TJYY {get;set;}

        /// <summary>
        /// Desc:发电机组 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJZ {get;set;}

        /// <summary>
        /// Desc:型号规格 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJZ_XHGG {get;set;}

        /// <summary>
        /// Desc:部件厂家 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJZ_BJCJ {get;set;}

        /// <summary>
        /// Desc:数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJZ_SL {get;set;}

        /// <summary>
        /// Desc:发电机组额度功率（KVA) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJZ_FDJZEDGL {get;set;}

        /// <summary>
        /// Desc:主发电机功率（kw) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZFDJGL {get;set;}

        /// <summary>
        /// Desc:辅助发电机组 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FZFDJZ {get;set;}

        /// <summary>
        /// Desc:型号规格 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FZFDJZ_XHGG {get;set;}

        /// <summary>
        /// Desc:部件厂家 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FZFDJZ_BJCJ {get;set;}

        /// <summary>
        /// Desc:数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FZFDJZ_SL {get;set;}

        /// <summary>
        /// Desc:发电机组额度功率（KVA) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJZEDGL {get;set;}

        /// <summary>
        /// Desc:主发电机功率（kw) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZFDJGL_ONE {get;set;}

        /// <summary>
        /// Desc:轨道车运行控制设备 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GDCYXKJSB {get;set;}

        /// <summary>
        /// Desc:型号规格 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GDCYXKJSB_XHGG {get;set;}

        /// <summary>
        /// Desc:部件厂家 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GDCYXKJSB_BJCJ {get;set;}

        /// <summary>
        /// Desc:数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GDCYXKJSB_SL {get;set;}

        /// <summary>
        /// Desc:主要技术参数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZYJSCS {get;set;}

        /// <summary>
        /// Desc:列车无线调度通信设备 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LCWXDDTXSB {get;set;}

        /// <summary>
        /// Desc:型号规格 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LCWXDDTXSB_XHGG {get;set;}

        /// <summary>
        /// Desc:部件厂家 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LCWXDDTXSB_BJCJ {get;set;}

        /// <summary>
        /// Desc:数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LCWXDDTXSB_SL {get;set;}

        /// <summary>
        /// Desc:主要技术参数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LCWXDDTXSB_ZJJSCS {get;set;}

        /// <summary>
        /// Desc:部门编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

    }
}
