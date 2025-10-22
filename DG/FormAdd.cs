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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
            //Constant.SetTextBoxOnlyNumberAndMinus(this);
        }
        private BROKENRAIL_BDATA_SECTION section;
        private List<BROKENRAIL_BDATA_DEVICE> deviceList;
        private List<BROKENRAIL_SECTION_LINE> lineList;

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            if (!IsSectionFinish())
            {
                MessageBox.Show("请输入区间基础数据信息");
                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("请输入定标器手机号");
                return;
            }
            else
            {
                BROKENRAIL_BDATA_DEVICE device = new BROKENRAIL_BDATA_DEVICE
                {
                    POINT_NO = textBox1.Text.Trim(),
                    SECTION_ID = txtSectionId.Text.Trim()
                };
                BROKENRAIL_SECTION_LINE line = new BROKENRAIL_SECTION_LINE
                {
                    POINT_NO = textBox1.Text.Trim(),
                    PKID = Guid.NewGuid().ToString()
                };

                listBox1.Items.Add(new DEVICE_LINE
                {
                    device = device,
                    line = line,
                    POINT_NO = textBox1.Text.Trim()
                });
                listBox1.DisplayMember = "POINT_NO";
                textBox1.Text = "";
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DEVICE_LINE dl = (DEVICE_LINE)listBox1.SelectedItem;
            SetDeviceValue(dl);
        }

        private bool IsSectionFinish()
        {
            return !string.IsNullOrEmpty(txtSectionId.Text.Trim()) && !string.IsNullOrEmpty(txtSectionName.Text.Trim()) && !string.IsNullOrEmpty(txtDeptCode.Text.Trim())
                && !string.IsNullOrEmpty(txtLineName.Text.Trim()) && !string.IsNullOrEmpty(txtStartMile.Text.Trim()) && !string.IsNullOrEmpty(txtEndMile.Text.Trim())
                && !string.IsNullOrEmpty(txtGcVol.Text.Trim()) && !string.IsNullOrEmpty(txtEnvVol.Text.Trim()) && !string.IsNullOrEmpty(txtEndIndex.Text.Trim());
        }

        private bool IsDeviceFinish()
        {
            return !string.IsNullOrEmpty(txtDeviceMode.Text.Trim()) && !string.IsNullOrEmpty(txtIsEnd.Text.Trim()) &&
                    !string.IsNullOrEmpty(txtLineDirP.Text.Trim()) && !string.IsNullOrEmpty(txtLineNameP.Text.Trim()) &&
                    !string.IsNullOrEmpty(txtPointName.Text.Trim()) && !string.IsNullOrEmpty(txtPointNo.Text.Trim()) &&
                    !string.IsNullOrEmpty(txtPointNote.Text.Trim()) && !string.IsNullOrEmpty(txtPointPhoneNo.Text.Trim()) &&
                    !string.IsNullOrEmpty(txtSectionIdP.Text.Trim()) && comboType.SelectedIndex != -1 &&
                    !string.IsNullOrEmpty(txtMileage.Text.Trim()) &&
                    !string.IsNullOrEmpty(txtMarsLat.Text.Trim()) && !string.IsNullOrEmpty(txtMarsLon.Text.Trim());
        }

        private bool IsLineFinish()
        {
            return !string.IsNullOrEmpty(txtMileageStart.Text.Trim()) && !string.IsNullOrEmpty(txtMileageEnd.Text.Trim());
        }

        private void SetDeviceValue(DEVICE_LINE dl)
        {
            txtPointNo.Text = dl.device.POINT_NO;
            txtPKID.Text = dl.line.PKID;
            txtPointNoL.Text = dl.line.POINT_NO;
            txtSectionIdP.Text = dl.device.SECTION_ID;
            if (dl.device.TYPE != null)
            {
                txtPointName.Text = dl.device.POINT_NAME;
                txtLineCode.Text = dl.device.LINE_CODE;
                txtLineNameP.Text = dl.device.LINE_NAME;
                txtLineDirP.Text = dl.device.LINE_DIR;
                txtMileage.Text = dl.device.MILEAGE_COORDINATE.ToString();
                txtLon.Text = dl.device.LONGITUDE.ToString();
                txtLat.Text = dl.device.LATITUDE.ToString();
                txtMarsLat.Text = dl.device.MARSLATITUDE.ToString();
                txtMarsLon.Text = dl.device.MARSLONGITUDE.ToString();
                txtBaiDuLat.Text = dl.device.BAIDULATITUDE.ToString();
                txtBaiDuLon.Text = dl.device.BAIDULONGITUDE.ToString();
                txtPointOrder.Text = dl.device.POINT_ORDER.ToString();
                txtPointFlag.Text = dl.device.POINT_FLAG;
                txtPointNote.Text = dl.device.POINT_NOTE;
                txtPointPhoneNo.Text = dl.device.POINT_PHONENO;
                // txtType.Text = device.TYPE;
                comboType.Text = dl.device.TYPE;
                txtPosition.Text = dl.device.POSITION;
                
                txtDeviceMode.Text = dl.device.DEVICE_MODE;
                txtMatchupPhone.Text = dl.device.MATCHUP_PHONE;
                txtPrevPhone.Text = dl.device.PREV_PHONE;
                txtNextPhone.Text = dl.device.NEXT_PHONE;
                txtPrevScalerMile.Text = dl.device.PREV_SCALER_MILEAGE;
                txtNextScalerMile.Text = dl.device.NEXT_SCALER_MILEAGE;
                txtIsEnd.Text = dl.device.IS_END;
                txtLeftFrequency.Text = dl.device.LEFT_FREQUENCY;
                txtRightFrequency.Text = dl.device.RIGHT_FREQUENCY;
                txtVoltage.Text = dl.device.VOLTAGE;


                txtMileageStart.Text = dl.line.MILEAGE_START.ToString();
                txtMileageEnd.Text = dl.line.MILEAGE_END.ToString();
            }
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            section = null;
            deviceList = new List<BROKENRAIL_BDATA_DEVICE>();
            lineList = new List<BROKENRAIL_SECTION_LINE>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DEVICE_LINE dl = (DEVICE_LINE)listBox1.SelectedItem;
            if (!IsSectionFinish())
            {
                MessageBox.Show("区间基础信息不完整");
                return;
            }
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
            if (section == null)
            {
                section = new BROKENRAIL_BDATA_SECTION
                {
                    DEPT_CODE = txtDeptCode.Text.Trim(),
                    END_MILE = txtEndMile.Text.Trim(),
                    END_SCALER_INDEX = txtEndIndex.Text.Trim(),
                    ENVIRONMENT_VOL = txtEnvVol.Text.Trim(),
                    GC_VOL = txtGcVol.Text.Trim(),
                    LINE_DIR = txtLineDir.Text.Trim(),
                    LINE_NAME = txtLineName.Text.Trim(),
                    SECTION_ID = txtSectionId.Text.Trim(),
                    SECTION_NAME = txtSectionName.Text.Trim(),
                    START_MILE = txtStartMile.Text.Trim(),
                    START_SCALER_INDEX = txtStartIndex.Text.Trim(),
                    STATION_STATION = txtStation.Text.Trim()
                };
            }
            if (IsDeviceFinish() && IsLineFinish())
            {
                BROKENRAIL_BDATA_DEVICE device = new BROKENRAIL_BDATA_DEVICE
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

                dl.device = device;
                var existdevice = deviceList.Where(o => o.POINT_NO == device.POINT_NO).FirstOrDefault();
                if (existdevice != null)
                {
                    deviceList.Remove(existdevice);
                }
                deviceList.Add(device);


                BROKENRAIL_SECTION_LINE line = new BROKENRAIL_SECTION_LINE
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

                dl.line = line;
                var existline = lineList.Where(o => o.POINT_NO == line.POINT_NO).FirstOrDefault();
                if (existline != null)
                {
                    lineList.Remove(existline);
                }
                lineList.Add(line);

            //    ClearTxtValue();

            }
            MessageBox.Show("保存成功");
        }

        private void FormAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (section != null && deviceList.Count > 0 && lineList.Count > 0)
            {
                if (MessageBox.Show("是否生成新增区间的SQL文件，退出后操作记录将清除！", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (section != null && deviceList.Count > 0 && lineList.Count > 0)
                    {
                        try
                        {
                            string tranpath = Environment.CurrentDirectory + "\\SQL\\SQL穿网_ADD" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".SQL";
                            string sqlpath = Environment.CurrentDirectory + "\\SQL\\SQL_ADD" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".SQL";
                            string orapath = Environment.CurrentDirectory + "\\SQL\\ORA_ADD" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".SQL";
                            using (StreamWriter file = new StreamWriter(tranpath))
                            {
                                file.WriteLine(string.Format("INSERT INTO PushBasicData values('{0}','{1}','{2}','{3}','{4}');",
                                        "INSERT", "BROKENRAIL_BDATA_SECTION", JsonConvert.SerializeObject(section), "0", DateTime.Now));
                                foreach (var device in deviceList)
                                {
                                    file.WriteLine(string.Format("INSERT INTO PushBasicData values('{0}','{1}','{2}','{3}','{4}');",
                                        "INSERT", "BROKENRAIL_BDATA_DEVICE", JsonConvert.SerializeObject(device), "0", DateTime.Now));
                                }
                                foreach (var line in lineList)
                                {
                                    file.WriteLine(string.Format("INSERT INTO PushBasicData values('{0}','{1}','{2}','{3}','{4}');",
                                        "INSERT", "BROKENRAIL_SECTION_LINE", JsonConvert.SerializeObject(line), "0", DateTime.Now));
                                }
                            }

                            using (StreamWriter file = new StreamWriter(orapath))
                            {
                                file.WriteLine(SQLUtil.GetSQL<BROKENRAIL_BDATA_SECTION>("INSERT", section,"ORA"));
                                foreach (var device in deviceList)
                                {
                                    file.WriteLine(SQLUtil.GetSQL("INSERT", device, "ORA"));
                                }
                                foreach (var line in lineList)
                                {
                                    file.WriteLine(SQLUtil.GetSQL("INSERT", line, "ORA"));
                                }
                            }

                            using (StreamWriter file = new StreamWriter(sqlpath))
                            {
                                file.WriteLine(SQLUtil.GetSQL<BROKENRAIL_BDATA_SECTION>("INSERT", section, "SQL"));
                                foreach (var device in deviceList)
                                {
                                    file.WriteLine(SQLUtil.GetSQL("INSERT", device, "SQL"));
                                }
                                foreach (var line in lineList)
                                {
                                    file.WriteLine(SQLUtil.GetSQL("INSERT", line, "SQL"));
                                }
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
                        MessageBox.Show("区间信息不完整，请返回检查");
                        e.Cancel = true;
                    }
                }
            }
        }

        private void ClearTxtValue()
        {
            txtDeviceMode.Text = "";
            txtIsEnd.Text = "";
            txtLeftFrequency.Text = "";
            txtLineCode.Text = "";
            txtLineDirP.Text = "";
            txtLineNameP.Text = "";
            txtMatchupPhone.Text = "";
            txtNextPhone.Text = "";
            txtNextScalerMile.Text = "";
            txtPointFlag.Text = "";
            txtPointName.Text = "";
            txtPointNo.Text = "";
            txtPointNote.Text = "";
            txtPointPhoneNo.Text = "";
            txtPosition.Text = "";
            txtPrevPhone.Text = "";
            txtPrevScalerMile.Text = "";
            txtRightFrequency.Text = "";
            txtSectionIdP.Text = "";
            comboType.SelectedIndex = -1;
            txtVoltage.Text = "";
            txtPointOrder.Text = "";
            txtMileage.Text = "";
            txtBaiDuLat.Text = "";
            txtBaiDuLon.Text = "";
            txtMarsLat.Text = "";
            txtMarsLon.Text = "";
            txtLat.Text = "";
            txtLon.Text = "";
            txtPointNo.Text = "";

            txtPKID.Text = "";
            txtPointNoL.Text = "";
            txtMileageStart.Text = "";
            txtMileageEnd.Text = "";
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (section != null && deviceList.Count > 0 && lineList.Count > 0)

                if (section != null && deviceList.Count > 0 && lineList.Count > 0)
                {
                    try
                    {
                        string tranpath = Environment.CurrentDirectory + "\\SQL\\SQL穿网_新增区间" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".SQL";
                        string sqlpath = Environment.CurrentDirectory + "\\SQL\\SQL_新增区间" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".SQL";
                        string orapath = Environment.CurrentDirectory + "\\SQL\\ORA_新增区间" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".SQL";
                        using (StreamWriter file = new StreamWriter(tranpath))
                        {
                            file.WriteLine(string.Format("INSERT INTO PushBasicData values('{0}','{1}','{2}','{3}','{4}');",
                                    "INSERT", "BROKENRAIL_BDATA_SECTION", JsonConvert.SerializeObject(section), "0", DateTime.Now));
                            foreach (var device in deviceList)
                            {
                                file.WriteLine(string.Format("INSERT INTO PushBasicData values('{0}','{1}','{2}','{3}','{4}');",
                                    "INSERT", "BROKENRAIL_BDATA_DEVICE", JsonConvert.SerializeObject(device), "0", DateTime.Now));
                            }
                            foreach (var line in lineList)
                            {
                                file.WriteLine(string.Format("INSERT INTO PushBasicData values('{0}','{1}','{2}','{3}','{4}');",
                                    "INSERT", "BROKENRAIL_SECTION_LINE", JsonConvert.SerializeObject(line), "0", DateTime.Now));
                            }
                        }

                        using (StreamWriter file = new StreamWriter(orapath))
                        {
                            file.WriteLine(SQLUtil.GetSQL<BROKENRAIL_BDATA_SECTION>("INSERT", section,"ORA"));
                            foreach (var device in deviceList)
                            {
                                file.WriteLine(SQLUtil.GetSQL("INSERT", device, "ORA"));
                            }
                            foreach (var line in lineList)
                            {
                                file.WriteLine(SQLUtil.GetSQL("INSERT", line, "ORA"));
                            }
                        }
                        using (StreamWriter file = new StreamWriter(sqlpath))
                        {
                            file.WriteLine(SQLUtil.GetSQL<BROKENRAIL_BDATA_SECTION>("INSERT", section, "SQL"));
                            foreach (var device in deviceList)
                            {
                                file.WriteLine(SQLUtil.GetSQL("INSERT", device, "SQL"));
                            }
                            foreach (var line in lineList)
                            {
                                file.WriteLine(SQLUtil.GetSQL("INSERT", line, "SQL"));
                            }
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
                    MessageBox.Show("区间信息不完整，请返回检查");
                }
        }
    }
}
