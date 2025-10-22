using DG.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DG
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DBService db = new DBService();
            string url = string.Format("data source={0};initial catalog={1};persist security info=True;user id={2};password={3};", txtUrl.Text.Trim(),txtDBName.Text.Trim(),
                txtUser.Text.Trim(), txtPass.Text.Trim());
            db.GetInstance(url);

            if(Constant.client == null)
            {
                MessageBox.Show("数据库连接失败！");
            }
            else
            {
                ThreadPool.QueueUserWorkItem(o =>
                {
                    do
                    {
                        Constant.client.Ado.ExecuteCommand("update BROKENRAIL_SECTION_STATUS_KF set SECTION_STATUS = '正常', RECORD_TIME ='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where SECTION_ID = 'pxg-dyd'");
                    } while (true);
                });
                Constant.pathext = txtUser.Text.Trim();
                this.Hide();
                FrmData fd = new FrmData();
                fd.Show();
            }
        }
    }
}
