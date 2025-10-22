using DG.Common;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DG
{
    public partial class FormDeviceAdd : Form
    {
        private BROKENRAIL_BDATA_SECTION SECTION { get; set; }

        private BROKENRAIL_BDATA_DEVICE device { get; set; }
        private BROKENRAIL_SECTION_LINE line { get; set; }
        public FormDeviceAdd(BROKENRAIL_BDATA_SECTION section)
        {
            InitializeComponent();
            //Constant.SetTextBoxOnlyNumberAndMinus(this);
            this.SECTION = section;
            txtSectionIdP.Text = this.SECTION.SECTION_ID;
            txtPKID.Text = Guid.NewGuid().ToString();
        }

        private bool IsDeviceFinish()
        {
            return !string.IsNullOrEmpty(txtDeviceMode.Text.Trim()) && !string.IsNullOrEmpty(txtIsEnd.Text.Trim()) &&
                    !string.IsNullOrEmpty(txtLineDirP.Text.Trim()) && !string.IsNullOrEmpty(txtLineNameP.Text.Trim()) &&
                    !string.IsNullOrEmpty(txtPointName.Text.Trim()) && !string.IsNullOrEmpty(txtPointNo.Text.Trim()) &&
                    !string.IsNullOrEmpty(txtPointNote.Text.Trim()) && !string.IsNullOrEmpty(txtPointPhoneNo.Text.Trim()) &&
                    !string.IsNullOrEmpty(txtSectionIdP.Text.Trim()) && comboType.SelectedIndex != -1 &&
                    !string.IsNullOrEmpty(txtMileage.Text.Trim()) && !string.IsNullOrEmpty(txtPointNo.Text.Trim()) &&
                    !string.IsNullOrEmpty(txtMarsLat.Text.Trim()) && !string.IsNullOrEmpty(txtMarsLon.Text.Trim());
        }

        private bool IsLineFinish()
        {
            return !string.IsNullOrEmpty(txtMileageStart.Text.Trim()) && !string.IsNullOrEmpty(txtMileageEnd.Text.Trim());
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsDeviceFinish())
            {
                MessageBox.Show("定标器基础信息不完整");
                return;
            }
            if (!IsLineFinish())
            {
                MessageBox.Show("画线基础信息不完整");
                return;
            }
            device = new BROKENRAIL_BDATA_DEVICE
            {
                DEVICE_MODE = txtDeviceMode.Text.Trim(),
                IS_END = txtIsEnd.Text.Trim(),
                LEFT_FREQUENCY = txtLeftFrequency.Text.Trim(),
                LINE_CODE = txtLineCode.Text.Trim(),
                LINE_DIR = txtLineDirP.Text.Trim(),
                LINE_NAME = txtLineNameP.Text.Trim(),
                MATCHUP_PHONE = txtMatchupPhone.Text.Trim(),
                NEXT_PHONE = txtNextPhone.Text.Trim(),
                NEXT_SCALER_MILEAGE = txtNextScalerMile.Text.Trim(),
                POINT_FLAG = txtPointFlag.Text.Trim(),
                POINT_NAME = txtPointName.Text.Trim(),
                POINT_NO = txtPointNo.Text.Trim(),
                POINT_NOTE = txtPointNote.Text.Trim(),
                POINT_PHONENO = txtPointPhoneNo.Text.Trim(),
                POSITION = txtPosition.Text.Trim(),
                PREV_PHONE = txtPrevPhone.Text.Trim(),
                PREV_SCALER_MILEAGE = txtPrevScalerMile.Text.Trim(),
                RIGHT_FREQUENCY = txtRightFrequency.Text.Trim(),
                SECTION_ID = txtSectionIdP.Text.Trim(),
                TYPE = comboType.SelectedItem.ToString(),// txtType.Text.Trim(),
                VOLTAGE = txtVoltage.Text.Trim()
            };
            if (string.IsNullOrEmpty(txtPointOrder.Text.Trim()))
                device.POINT_ORDER = null;
            else
                device.POINT_ORDER = int.Parse(txtPointOrder.Text.Trim());

            if (string.IsNullOrEmpty(txtMileage.Text.Trim()))
                device.MILEAGE_COORDINATE = null;
            else
                device.MILEAGE_COORDINATE = decimal.Parse(txtMileage.Text.Trim());


            if (string.IsNullOrEmpty(txtBaiDuLat.Text.Trim()))
                device.BAIDULATITUDE = null;
            else
                device.BAIDULATITUDE = decimal.Parse(txtBaiDuLat.Text.Trim());

            if (string.IsNullOrEmpty(txtBaiDuLon.Text.Trim()))
                device.BAIDULONGITUDE = null;
            else
                device.BAIDULONGITUDE = decimal.Parse(txtBaiDuLon.Text.Trim());

            if (string.IsNullOrEmpty(txtMarsLat.Text.Trim()))
                device.MARSLATITUDE = null;
            else
                device.MARSLATITUDE = decimal.Parse(txtMarsLat.Text.Trim());

            if (string.IsNullOrEmpty(txtMarsLon.Text.Trim()))
                device.MARSLONGITUDE = null;
            else
                device.MARSLONGITUDE = decimal.Parse(txtMarsLon.Text.Trim());

            if (string.IsNullOrEmpty(txtLat.Text.Trim()))
                device.LATITUDE = null;
            else
                device.LATITUDE = decimal.Parse(txtLat.Text.Trim());

            if (string.IsNullOrEmpty(txtLon.Text.Trim()))
                device.LONGITUDE = null;
            else
                device.LONGITUDE = decimal.Parse(txtLon.Text.Trim());

            line = new BROKENRAIL_SECTION_LINE
            {
                PKID = txtPKID.Text.Trim(),
                POINT_NO = txtPointNoL.Text.Trim()
            };

            if (string.IsNullOrEmpty(txtMileageStart.Text.Trim()))
                line.MILEAGE_START = null;
            else
                line.MILEAGE_START = decimal.Parse(txtMileageStart.Text.Trim());

            if (string.IsNullOrEmpty(txtMileageEnd.Text.Trim()))
                line.MILEAGE_END = null;
            else
                line.MILEAGE_END = decimal.Parse(txtMileageEnd.Text.Trim());

            MessageBox.Show("保存成功");

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (device != null && line != null)
            {
                try
                {
                    string tranpath = Environment.CurrentDirectory + "\\SQL\\SQL穿网_新增定标器" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".SQL";
                    string sqlpath = Environment.CurrentDirectory + "\\SQL\\SQL_新增定标器" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".SQL";
                    string orapath = Environment.CurrentDirectory + "\\SQL\\ORA_新增定标器" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".SQL";
                    using (StreamWriter file = new StreamWriter(tranpath))
                    {
                        file.WriteLine(string.Format("INSERT INTO PushBasicData values('{0}','{1}','{2}','{3}','{4}');",
                            "INSERT", "BROKENRAIL_BDATA_DEVICE", JsonConvert.SerializeObject(device), "0", DateTime.Now));

                        file.WriteLine(string.Format("INSERT INTO PushBasicData values('{0}','{1}','{2}','{3}','{4}');",
                            "INSERT", "BROKENRAIL_SECTION_LINE", JsonConvert.SerializeObject(line), "0", DateTime.Now));

                    }

                    using (StreamWriter file = new StreamWriter(orapath))
                    {
                        file.WriteLine(SQLUtil.GetSQL("INSERT", device, "ORA"));

                        file.WriteLine(SQLUtil.GetSQL("INSERT", line, "ORA"));
                    }

                    using (StreamWriter file = new StreamWriter(sqlpath))
                    {
                        file.WriteLine(SQLUtil.GetSQL("INSERT", device, "SQL"));

                        file.WriteLine(SQLUtil.GetSQL("INSERT", line, "SQL"));
                    }
                    MessageBox.Show("生成SQL文件成功");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("生成SQL文件失败");
                }
            }
            else
            {
                MessageBox.Show("先保存数据，再生成SQL语句");
            }
        }

        private void txtPointNo_TextChanged(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            txtPointNoL.Text = box.Text.Trim();
        }
    }
}
