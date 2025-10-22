using DG.Common;
using Model;
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
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
           // this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<BROKENRAIL_BDATA_SECTION> section = new ExcelHelper<BROKENRAIL_BDATA_SECTION>().ToDataTable(openFileDialog1.FileName, 0, 1);
                List<BROKENRAIL_BDATA_DEVICE> device = new ExcelHelper<BROKENRAIL_BDATA_DEVICE>().ToDataTable(openFileDialog1.FileName, 1, 1);
                List<BROKENRAIL_SECTION_LINE> line = new ExcelHelper<BROKENRAIL_SECTION_LINE>().ToDataTable(openFileDialog1.FileName, 2, 1);
                if (section != null && device != null && line != null)
                {
                    FrmDataExcel FrmExcel = new FrmDataExcel(device, section, line);
                    FrmExcel.Text = openFileDialog1.FileName;
                    FrmExcel.Show();
                   // this.Hide();
                }
                else
                {
                    MessageBox.Show("文件读取错误");
                }
            }
        }
    }
}
