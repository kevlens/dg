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
    public partial class ChangePhone : Form
    {
        private BROKENRAIL_BDATA_DEVICE DEVICE { get; set; }
        private BROKENRAIL_SECTION_LINE LINE { get; set; }
        public ChangePhone(BROKENRAIL_BDATA_DEVICE device, BROKENRAIL_SECTION_LINE line)
        {
            this.DEVICE = device;
            this.LINE = line;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPointNo.Text.Trim()))
            {
                MessageBox.Show("请输入手机号");
                return;
            }
            List<PushBasicData> opList = new List<PushBasicData>();
            List<BROKENRAIL_BDATA_DEVICE> oldList = Constant.client.Queryable<BROKENRAIL_BDATA_DEVICE>().Where(o => o.POINT_NO.StartsWith(DEVICE.POINT_NO)).ToList();
            foreach (var old in oldList)
            {
                BROKENRAIL_BDATA_DEVICE newdevice = SQLUtil.DeepCopyByBin(old);
                newdevice.POINT_NO = newdevice.POINT_NO.Replace(DEVICE.POINT_NO, txtNewPointNo.Text.Trim());

                var oldLine = Constant.client.Queryable<BROKENRAIL_SECTION_LINE>().Where(o => o.POINT_NO == old.POINT_NO).First();
                BROKENRAIL_SECTION_LINE newline = SQLUtil.DeepCopyByBin(oldLine);
                newline.POINT_NO = newline.POINT_NO.Replace(DEVICE.POINT_NO,txtNewPointNo.Text.Trim());
                newline.PKID = Guid.NewGuid().ToString();

                PushBasicData pbd = new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "INSERT",
                    datatext = JsonConvert.SerializeObject(newdevice),
                    datatype = "BROKENRAIL_BDATA_DEVICE",
                    status = 0,
                    errnum = 0
                };
                opList.Add(pbd);

                pbd = new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "INSERT",
                    datatext = JsonConvert.SerializeObject(newline),
                    datatype = "BROKENRAIL_SECTION_LINE",
                    status = 0,
                    errnum = 0
                };
                opList.Add(pbd);

                pbd = new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "CHANGE",
                    datatext = old.POINT_NO + "," + newdevice.POINT_NO,
                    datatype = "BROKENRAIL_DEVICE_STATUS",
                    status = 0,
                    errnum = 0
                };
                opList.Add(pbd);
                pbd = new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "CHANGE",
                    datatext = old.POINT_NO + "," + newdevice.POINT_NO,
                    datatype = "BROKENRAIL_DEVICE_STATUSHIS",
                    status = 0,
                    errnum = 0
                };
                opList.Add(pbd);

                pbd = new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "CHANGE",
                    datatext = old.POINT_NO + "," + newdevice.POINT_NO,
                    datatype = "BROKENRAIL_VOLTAGE_STATUS",
                    status = 0,
                    errnum = 0
                };
                opList.Add(pbd);
                pbd = new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "CHANGE",
                    datatext = old.POINT_NO + "," + newdevice.POINT_NO,
                    datatype = "BROKENRAIL_VOLTAGE_STATUSHIS",
                    status = 0,
                    errnum = 0
                };
                opList.Add(pbd);

                pbd = new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "DELETE",
                    datatext = JsonConvert.SerializeObject(oldLine),
                    datatype = "BROKENRAIL_SECTION_LINE",
                    status = 0,
                    errnum = 0
                };
                opList.Add(pbd);

                pbd = new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "DELETE",
                    datatext = JsonConvert.SerializeObject(old),
                    datatype = "BROKENRAIL_BDATA_DEVICE",
                    status = 0,
                    errnum = 0
                };
                opList.Add(pbd);
            }
            Constant.SaveFile(opList, "更换手机号");
        }

        private void ChangePhone_Load(object sender, EventArgs e)
        {
            lblOldPointNo.Text = DEVICE.POINT_NO;
            lblSectionId.Text = DEVICE.SECTION_ID;
        }
    }
}
