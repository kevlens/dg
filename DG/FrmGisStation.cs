using DG.Common;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DG
{
    public partial class FrmGisStation : Form
    {
        public FrmGisStation()
        {
            InitializeComponent();
            //Constant.SetTextBoxOnlyNumberAndMinus(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            T_GIS_STATION station = new T_GIS_STATION
            {
                PKID = Guid.NewGuid().ToString(),
                出站里程 = txtOutMile.Text.Trim(),
                工务段 = txtGWD.Text.Trim(),
                工务段编码 = txtGWDCode.Text.Trim(),
                工区 = txtGQ.Text.Trim(),
                显示车站标志 = txtFlag.Text.Trim(),
                横竖 = txtDirect.Text.Trim(),
                火星纬度 = string.IsNullOrEmpty(txtMarsLat.Text.Trim()) ? decimal.Zero:Convert.ToDecimal(txtMarsLat.Text.Trim()),
                火星经度 = string.IsNullOrEmpty(txtMarsLon.Text.Trim()) ? decimal.Zero : Convert.ToDecimal(txtMarsLon.Text.Trim()),
                百度纬度 = string.IsNullOrEmpty(txtBDLat.Text.Trim()) ? decimal.Zero : Convert.ToDecimal(txtBDLat.Text.Trim()),
                百度经度 = string.IsNullOrEmpty(txtBDLon.Text.Trim()) ? decimal.Zero : Convert.ToDecimal(txtBDLon.Text.Trim()),
                等级 = txtLv.Text.Trim(),
                纬度 = string.IsNullOrEmpty(txtLat.Text.Trim()) ? decimal.Zero : Convert.ToDecimal(txtLat.Text.Trim()),
                线名 = txtLineName.Text.Trim(),
                线名编码 = txtLineCode.Text.Trim(),
                经度 = string.IsNullOrEmpty(txtLon.Text.Trim()) ? decimal.Zero : Convert.ToDecimal(txtLon.Text.Trim()),
                行别 = txtLineDir.Text.Trim(),
                路局 = txtLJ.Text.Trim(),
                路局编码 = txtLJCode.Text.Trim(),
                车站 = txtStation.Text.Trim(),
                车站编码 = txtStationCode.Text.Trim(),
                进站里程 = txtInMile.Text.Trim(),
                里程 = string.IsNullOrEmpty(txtMile.Text.Trim()) ? decimal.Zero : Convert.ToDecimal(txtMile.Text.Trim()),
                领工区 = txtLGQ.Text.Trim()
            };

            PushBasicData pbd = new PushBasicData
            {
                addtime = DateTime.Now,
                dataop = "INSERT",
                datatype = "T_GIS_STATION",
                status = 0,
                errnum = 0,
                datatext = JsonConvert.SerializeObject(station)
            };

            Constant.opList.Add(pbd);

            MessageBox.Show("添加成功");
            
        }
        public void ClearText()
        {
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void FrmGisStation_Load(object sender, EventArgs e)
        {

        }
    }
}
