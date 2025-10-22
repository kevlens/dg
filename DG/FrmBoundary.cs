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
    public partial class FrmBoundary : Form
    {
        private static bool IsAdd = false;
        public FrmBoundary()
        {
            InitializeComponent();
            //Constant.SetTextBoxOnlyNumberAndMinus(this);
        }

        private void FrmBoundary_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IsAdd = true;
            txtPKID.Text = Guid.NewGuid().ToString();
            txtLineName.Text = "";
            txtLineDir.Text = "";
            txtBigDept.Text = "";
            txtSmallDept.Text = "";
            txtMileage.Text = "";
        }
        private bool IsFinish()
        {
            return !string.IsNullOrEmpty(txtBigDept.Text.Trim()) && !string.IsNullOrEmpty(txtLineDir.Text.Trim()) && !string.IsNullOrEmpty(txtLineName.Text.Trim())
                && !string.IsNullOrEmpty(txtSmallDept.Text.Trim()) && !string.IsNullOrEmpty(txtMileage.Text.Trim());
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsFinish())
            {
                MessageBox.Show("数据未填完整");
                return;
            }
            BROKENRAIL_BDATA_BOUNDARY bd = new BROKENRAIL_BDATA_BOUNDARY
            {
                PKID = txtPKID.Text.Trim(),
                BIG_DEPT = txtBigDept.Text.Trim(),
                LINE_DIR = txtLineDir.Text.Trim(),
                LINE_NAME = txtLineName.Text.Trim(),
                SMALL_DEPT = txtSmallDept.Text.Trim(),
                MILEAGE = Convert.ToDecimal(txtMileage.Text.Trim())
            };
            if (IsAdd)
            {
                Constant.opList.Add(new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "INSERT",
                    datatext = JsonConvert.SerializeObject(bd),
                    datatype = "BROKENRAIL_BDATA_BOUNDARY",
                    status = 0,
                    errnum = 0
                });

                listBox1.Items.Add(new Boundary
                {
                    boundary = bd,
                    text = string.Format("{0}-{1}-{2}", bd.LINE_NAME, bd.LINE_DIR, bd.MILEAGE)
                });
            }
            else
            {
                Constant.opList.Add(new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "UPDATE",
                    datatext = JsonConvert.SerializeObject(bd),
                    datatype = "BROKENRAIL_BDATA_BOUNDARY",
                    status = 0,
                    errnum = 0
                });
            }
            IsAdd = false;
        }

        private void LoadData()
        {
            var list = Constant.client.Queryable<BROKENRAIL_BDATA_BOUNDARY>().ToList();
            foreach (var item in list)
            {
                listBox1.Items.Add(new Boundary
                {
                    boundary = item,
                    text = string.Format("{0}-{1}-{2}", item.LINE_NAME, item.LINE_DIR, item.MILEAGE)
                });
            }
            listBox1.DisplayMember = "text";
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Boundary bd = (Boundary)listBox1.SelectedItem;
            txtLineName.Text = bd.boundary.LINE_NAME;
            txtLineDir.Text = bd.boundary.LINE_DIR;
            txtBigDept.Text = bd.boundary.BIG_DEPT;
            txtSmallDept.Text = bd.boundary.SMALL_DEPT;
            txtMileage.Text = bd.boundary.MILEAGE.ToString();
            txtPKID.Text = bd.boundary.PKID;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("请先选中要删除的数据");
                return;
            }
            Boundary bd = (Boundary)listBox1.SelectedItem;

            Constant.opList.Add(new PushBasicData
            {
                addtime = DateTime.Now,
                dataop = "DELETE",
                datatext = JsonConvert.SerializeObject(bd.boundary),
                datatype = "BROKENRAIL_BDATA_BOUNDARY",
                status = 0,
                errnum = 0
            });
            listBox1.Items.Remove(bd);
        }
    }


    public class Boundary
    {
        public string text { get; set; }
        public BROKENRAIL_BDATA_BOUNDARY boundary { get; set; }
    }
}
