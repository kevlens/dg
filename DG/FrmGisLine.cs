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
    public partial class FrmGisLine : Form
    {
        public FrmGisLine()
        {
            InitializeComponent();
            //Constant.SetTextBoxOnlyNumberAndMinus(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            T_GIS_LINE line = new T_GIS_LINE();
            line.工务段 = txtGWD.Text.Trim();
            line.火星纬度 = Convert.ToDecimal(txtMarsLat.Text.Trim());
            line.火星经度 = Convert.ToDecimal(txtMarsLon.Text.Trim());
            line.线名 = txtLineName.Text.Trim();
            line.行别 = txtDir.Text.Trim();
            line.路局 = txtLJ.Text.Trim();
            line.里程 = Convert.ToDecimal(txtMile.Text.Trim());
            line.PKID = Guid.NewGuid().ToString().Replace("-","");

            PushBasicData pbd = new PushBasicData
            {
                addtime = DateTime.Now,
                dataop = "INSERT",
                datatype = "T_GIS_LINE",
                status = 0,
                errnum = 0,
                datatext = JsonConvert.SerializeObject(line)
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
    }
}
