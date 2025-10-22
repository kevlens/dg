using System;
using System.Linq;
using System.Text;

namespace Model
{
    public class LEDGER_BIGEQUI_TECHPARAM
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
        /// Desc:作业走行 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZYZX {get;set;}

        /// <summary>
        /// Desc:作业范围 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZYFW {get;set;}

        /// <summary>
        /// Desc:作业条件 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZYTJ {get;set;}

        /// <summary>
        /// Desc:钢轨（km/m) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GW {get;set;}

        /// <summary>
        /// Desc:轨枕 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GZ {get;set;}

        /// <summary>
        /// Desc:道床 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DC {get;set;}

        /// <summary>
        /// Desc:作业线路 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZYXL {get;set;}

        /// <summary>
        /// Desc:轨距(mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GJ {get;set;}

        /// <summary>
        /// Desc:线路最大超高（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string XLZDCG {get;set;}

        /// <summary>
        /// Desc:线路最大坡度（‰） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string XLZXPD {get;set;}

        /// <summary>
        /// Desc:最小作业曲线半径（m) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZXZYQXBJ {get;set;}

        /// <summary>
        /// Desc:最小运行曲线半径（m) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZXYXQXBJ {get;set;}

        /// <summary>
        /// Desc:环境温度（℃） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HJWD {get;set;}

        /// <summary>
        /// Desc:特殊环境 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string TSHJ {get;set;}

        /// <summary>
        /// Desc:连续工作时间（h) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LXGZSJ {get;set;}

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
        /// Desc:额定功率（kw) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJ_EDGL {get;set;}

        /// <summary>
        /// Desc:额定转速（r/min) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJ_EDZS {get;set;}

        /// <summary>
        /// Desc:最大扭矩（Nm/r/min) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJ_ZDNJ {get;set;}

        /// <summary>
        /// Desc:燃油消耗率[g/(kw.h)] 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FDJ_RYXHL {get;set;}

        /// <summary>
        /// Desc:应急发动机额定功率（kw) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string YJFDJEDGL {get;set;}

        /// <summary>
        /// Desc:传动方式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZDFS {get;set;}

        /// <summary>
        /// Desc:变速箱 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BSX {get;set;}

        /// <summary>
        /// Desc:型号规格 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BSX_XHGG {get;set;}

        /// <summary>
        /// Desc:部件厂家 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BSX_BJCJ {get;set;}

        /// <summary>
        /// Desc:数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BSX_SL {get;set;}

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
        public string FDJZ_ZFDJGL {get;set;}

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
        public string FZFDJZ_EDGL {get;set;}

        /// <summary>
        /// Desc:主发电机功率（kw) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string FZFDJZ_GL {get;set;}

        /// <summary>
        /// Desc:外形尺寸(长*宽*高mm3） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WXCC {get;set;}

        /// <summary>
        /// Desc:整机质量（t) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZJZL {get;set;}

        /// <summary>
        /// Desc:最高双向自行速度（km/h) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZGSXZXSD {get;set;}

        /// <summary>
        /// Desc:最高自行速度（km/h) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZGZXSD {get;set;}

        /// <summary>
        /// Desc:最高连挂速度（km/h) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZGLGSD {get;set;}

        /// <summary>
        /// Desc:转向架芯盘距（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZXJXPJ {get;set;}

        /// <summary>
        /// Desc:转向架I、III芯盘距（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZXJXPD_YS {get;set;}

        /// <summary>
        /// Desc:转向架III、IV芯盘距（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZXJXPD_SW {get;set;}

        /// <summary>
        /// Desc:转向架I、III、IV轴距（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZXJXPD_YSW {get;set;}

        /// <summary>
        /// Desc:工作小车转向架轴距（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GZXCZXJZJ {get;set;}

        /// <summary>
        /// Desc:转向架固定轴距（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZXJGDZJ {get;set;}

        /// <summary>
        /// Desc:从动转向架芯盘距材料小车前轴距（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZXJPJCLXCQZJ {get;set;}

        /// <summary>
        /// Desc:材料车轴至后转向架中心距（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CXCZHZXJZXJ {get;set;}

        /// <summary>
        /// Desc:材料小车前后轴距（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLXCQHZJ {get;set;}

        /// <summary>
        /// Desc:I车、III车芯盘距（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string YSCXPJ {get;set;}

        /// <summary>
        /// Desc:II车芯盘距（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ECXPJ {get;set;}

        /// <summary>
        /// Desc:车钩型式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CGXS {get;set;}

        /// <summary>
        /// Desc:缓冲装置 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HCZZ {get;set;}

        /// <summary>
        /// Desc:自运行制动方式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZYXZDFS {get;set;}

        /// <summary>
        /// Desc:紧急制动距离（m) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JJZDJL {get;set;}

        /// <summary>
        /// Desc:作业走行制动方式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZYZXZDFS {get;set;}

        /// <summary>
        /// Desc:作业走行速度（km/h) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZYZXSD {get;set;}

        /// <summary>
        /// Desc:作业效率（m/h) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZYXL_ONE {get;set;}

        /// <summary>
        /// Desc:岔区作业宽度（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CQZYKD {get;set;}

        /// <summary>
        /// Desc:每侧最大作业宽度（由轨道中心起m) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MZZDZYKD {get;set;}

        /// <summary>
        /// Desc:最大挖掘深度（由轨顶向下mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZDWJSD {get;set;}

        /// <summary>
        /// Desc:最大作业深度（由轨顶向下mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZDZYSD {get;set;}

        /// <summary>
        /// Desc:挖掘装置型式 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WJZZXS {get;set;}

        /// <summary>
        /// Desc:挖掘装置功率（kw) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WJZZGL {get;set;}

        /// <summary>
        /// Desc:筛分装置驱动功率（kw) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SFZZQDGL {get;set;}

        /// <summary>
        /// Desc:筛网有效面积m2 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SWYXMJ {get;set;}

        /// <summary>
        /// Desc:筛网层数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SWCS {get;set;}

        /// <summary>
        /// Desc:筛孔尺寸（mm） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SKCC {get;set;}

        /// <summary>
        /// Desc:道砟回填带最大摆角宽度（mm） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DZHTDZDBJKD {get;set;}

        /// <summary>
        /// Desc:回转污土输送带摆角（°） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HZWTSSDBJ {get;set;}

        /// <summary>
        /// Desc:油缸最大行程（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string YGZDXC {get;set;}

        /// <summary>
        /// Desc:磨头数量（个） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MTSL {get;set;}

        /// <summary>
        /// Desc:储砟量（m3） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CZL {get;set;}

        /// <summary>
        /// Desc:边坡整形 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string BPZX {get;set;}

        /// <summary>
        /// Desc:砂轮直径（mm） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SLZJ {get;set;}

        /// <summary>
        /// Desc:打磨电机功率（kw) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DMDJGL {get;set;}

        /// <summary>
        /// Desc:磨头横向调节量（mm） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MTHXTJL {get;set;}

        /// <summary>
        /// Desc:磨头摆角调节量（°） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MTBJTJL {get;set;}

        /// <summary>
        /// Desc:磨头与钢轨纵向夹角（°） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MTYGGZXJJ {get;set;}

        /// <summary>
        /// Desc:每遍平均打磨深度（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string MBPJDMSD {get;set;}

        /// <summary>
        /// Desc:作业精度 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZYJD {get;set;}

        /// <summary>
        /// Desc:纵向水平（mm)(纵向高低） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZXSP {get;set;}

        /// <summary>
        /// Desc:横向水平（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string HXSP {get;set;}

        /// <summary>
        /// Desc:正矢（mm)（拨道） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZSBD {get;set;}

        /// <summary>
        /// Desc:起道顺坡率（%） 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string QDSPL {get;set;}

        /// <summary>
        /// Desc:测量系统精度（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CLXXJD {get;set;}

        /// <summary>
        /// Desc:稳定装置激振频率（HZ) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WDZZJZPL {get;set;}

        /// <summary>
        /// Desc:稳定装置最大激振力（KN) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string WDZZZDJZL {get;set;}

        /// <summary>
        /// Desc:激光测量系统 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string JGCLXT {get;set;}

        /// <summary>
        /// Desc:轮径（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LJ {get;set;}

        /// <summary>
        /// Desc:转向架I、III、IV车轮直径（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZXJYSWCLZJ {get;set;}

        /// <summary>
        /// Desc:工作小车转向架（转向架II）车轮直径（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GZXCZXJCLZJ {get;set;}

        /// <summary>
        /// Desc:车钩中心高（距轨面mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string CGZXG {get;set;}

        /// <summary>
        /// Desc:最大起道量（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZDQDL {get;set;}

        /// <summary>
        /// Desc:最大拨道量（mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string ZDBDL {get;set;}

        /// <summary>
        /// Desc:捣固深度（由轨顶向下mm) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DGSD {get;set;}

        /// <summary>
        /// Desc:轨道车运行控制设备 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GDCYYKZSB {get;set;}

        /// <summary>
        /// Desc:型号规格 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GDCYYKZSB_XHGG {get;set;}

        /// <summary>
        /// Desc:部件厂家 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GDCYYKZSB_BJCJ {get;set;}

        /// <summary>
        /// Desc:数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GDCYYKZSB_NUM {get;set;}

        /// <summary>
        /// Desc:主要技术参数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string GDCYYKZSB_ZYJSCS {get;set;}

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
        public string LCWXDDTXSB_NUM {get;set;}

        /// <summary>
        /// Desc:主要技术参数 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string LCWXDDTXSB_ZYJSCS {get;set;}

        /// <summary>
        /// Desc:部门编码 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string DEPT_CODE {get;set;}

    }
}
