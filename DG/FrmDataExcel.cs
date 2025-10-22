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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DG
{
    public partial class FrmDataExcel : Form
    {
        private List<BROKENRAIL_BDATA_DEVICE> deviceList { get; set; }
        private List<BROKENRAIL_BDATA_SECTION> sectionList { get; set; }
        private List<BROKENRAIL_SECTION_LINE> lineList { get; set; }
        private static TreeNode selectNode = null;
        private List<PushBasicData> operateList = new List<PushBasicData>();
        private bool isoperate = false;
        public FrmDataExcel(List<BROKENRAIL_BDATA_DEVICE> deviceList, List<BROKENRAIL_BDATA_SECTION> sectionList, List<BROKENRAIL_SECTION_LINE> lineList)
        {
            InitializeComponent();
            //Constant.SetTextBoxOnlyNumberAndMinus(this);
            this.deviceList = deviceList;
            this.sectionList = sectionList;
            this.lineList = lineList;
        }
        

        private void FrmData_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AddPointData(TreeNode sectionNode, int index, string name)
        {
            var section = (BROKENRAIL_BDATA_SECTION)sectionNode.Tag;
            foreach (var item in deviceList)
            {
                if (item.SECTION_ID == section.SECTION_ID)
                {
                    TreeNode pointNode = new TreeNode(item.POINT_NAME + "-" + item.POINT_NO);
                    pointNode.Tag = item;
                    //  pointNode.ContextMenuStrip = this.contextMenuStripPoint;

                    sectionNode.Nodes.Add(pointNode);
                }
            }

        }
             
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Level == 0)
            {
                BROKENRAIL_BDATA_SECTION section = (BROKENRAIL_BDATA_SECTION)e.Node.Tag;
                this.panelPoint.Visible = false;
                this.panelSection.Visible = true;

                txtSectionId.Text = section.SECTION_ID;
                txtSectionName.Text = section.SECTION_NAME;
                txtDeptCode.Text = section.DEPT_CODE;
                txtEndIndex.Text = section.END_SCALER_INDEX;
                txtEndMile.Text = section.END_MILE;
                txtEnvVol.Text = section.ENVIRONMENT_VOL;
                txtGcVol.Text = section.GC_VOL;
                txtLineDir.Text = section.LINE_DIR;
                txtLineName.Text = section.LINE_NAME;
                txtStartIndex.Text = section.START_SCALER_INDEX;
                txtStartMile.Text = section.START_MILE;
                txtStation.Text = section.STATION_STATION;
            }
            else
            {
                BROKENRAIL_BDATA_DEVICE device = (BROKENRAIL_BDATA_DEVICE)e.Node.Tag;
                this.panelPoint.Visible = true;
                this.panelSection.Visible = false;

                txtPointNo.Text = device.POINT_NO;
                txtPointName.Text = device.POINT_NAME;
                txtLineCode.Text = device.LINE_CODE;
                txtLineNameP.Text = device.LINE_NAME;
                txtLineDirP.Text = device.LINE_DIR;
                txtMileage.Text = device.MILEAGE_COORDINATE.ToString();
                txtLon.Text = device.LONGITUDE.ToString();
                txtLat.Text = device.LATITUDE.ToString();
                txtMarsLat.Text = device.MARSLATITUDE.ToString();
                txtMarsLon.Text = device.MARSLONGITUDE.ToString();
                txtBaiDuLat.Text = device.BAIDULATITUDE.ToString();
                txtBaiDuLon.Text = device.BAIDULONGITUDE.ToString();
                txtPointOrder.Text = device.POINT_ORDER.ToString();
                txtPointFlag.Text = device.POINT_FLAG;
                txtPointNote.Text = device.POINT_NOTE;
                txtPointPhoneNo.Text = device.POINT_PHONENO;
               // txtType.Text = device.TYPE;
                comboType.Text = device.TYPE;
                txtPosition.Text = device.POSITION;
                txtSectionIdP.Text = device.SECTION_ID;
                txtDeviceMode.Text = device.DEVICE_MODE;
                txtMatchupPhone.Text = device.MATCHUP_PHONE;
                txtPrevPhone.Text = device.PREV_PHONE;
                txtNextPhone.Text = device.NEXT_PHONE;
                txtPrevScalerMile.Text = device.PREV_SCALER_MILEAGE;
                txtNextScalerMile.Text = device.NEXT_SCALER_MILEAGE;
                txtIsEnd.Text = device.IS_END;
                txtLeftFrequency.Text = device.LEFT_FREQUENCY;
                txtRightFrequency.Text = device.RIGHT_FREQUENCY;
                txtVoltage.Text = device.VOLTAGE;

                var lineInfo = lineList.Where(o => o.POINT_NO == device.POINT_NO).First();
                if(lineInfo != null)
                {
                    txtPKID.Text = lineInfo.PKID;
                    txtPointNoL.Text = lineInfo.POINT_NO;
                    txtMileageStart.Text = lineInfo.MILEAGE_START.ToString();
                    txtMileageEnd.Text = lineInfo.MILEAGE_END.ToString();
                }
            }
        }

        private void btnSaveSection_Click(object sender, EventArgs e)
        {
            try
            {
                BROKENRAIL_BDATA_SECTION section = new BROKENRAIL_BDATA_SECTION
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
                string json = JsonConvert.SerializeObject(section);

                PushBasicData pbd = new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "UPDATE",
                    datatext = json,
                    datatype = "BROKENRAIL_BDATA_SECTION",
                    status = 0,
                    errnum = 0
                };
                operateList.Add(pbd);
                if (!isoperate)
                    isoperate = true;
            }
            catch(Exception ex)
            {
            }
        }

        private void btnSavePoint_Click(object sender, EventArgs e)
        {
            try
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

                string jsondevice = JsonConvert.SerializeObject(device);
                string jsonline = JsonConvert.SerializeObject(line);

                PushBasicData pbd = new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "UPDATE",
                    datatext = jsondevice,
                    datatype = "BROKENRAIL_BDATA_DEVICE",
                    status = 0,
                    errnum = 0
                };

                operateList.Add(pbd);

                pbd = new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "UPDATE",
                    datatext = jsonline,
                    datatype = "BROKENRAIL_SECTION_LINE",
                    status = 0,
                    errnum = 0
                };

                operateList.Add(pbd);
                if (!isoperate)
                    isoperate = true;

            }
            catch (Exception ex)
            {

            }
        }


       

        private void FrmData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("退出将清除本次操作记录！是否退出？", "退出确认",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void 生成操作SQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("此操作会生成之前所有增、删、改的操作语句，是否确认生成？","操作提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Constant.SaveFile(operateList, "");
                operateList = new List<PushBasicData>();
            }
        }


        private void 删除定标器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PushBasicData pbd = null;
            BROKENRAIL_BDATA_DEVICE device = (BROKENRAIL_BDATA_DEVICE)selectNode.Tag;

            pbd = new PushBasicData
            {
                addtime = DateTime.Now,
                dataop = "DELETE",
                datatext = JsonConvert.SerializeObject(new BROKENRAIL_DEVICE_STATUS { POINT_NO = device.POINT_NO }),
                datatype = "BROKENRAIL_DEVICE_STATUS",
                status = 0,
                errnum = 0
            };
            operateList.Add(pbd);

            pbd = new PushBasicData
            {
                addtime = DateTime.Now,
                dataop = "DELETE",
                datatext = JsonConvert.SerializeObject(new BROKENRAIL_VOLTAGE_STATUS { POINT_NO = device.POINT_NO }),
                datatype = "BROKENRAIL_VOLTAGE_STATUS",
                status = 0,
                errnum = 0
            };
            operateList.Add(pbd);

            var l = Constant.client.Queryable<BROKENRAIL_SECTION_LINE>().Where(o => o.POINT_NO == device.POINT_NO).First();
            if (l != null)
            {
                pbd = new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "DELETE",
                    datatext = JsonConvert.SerializeObject(l),
                    datatype = "BROKENRAIL_SECTION_LINE",
                    status = 0,
                    errnum = 0
                };
                operateList.Add(pbd);
            }
            string json = JsonConvert.SerializeObject(device);
            pbd = new PushBasicData
            {
                addtime = DateTime.Now,
                dataop = "DELETE",
                datatext = json,
                datatype = "BROKENRAIL_BDATA_DEVICE",
                status = 0,
                errnum = 0
            };
            operateList.Add(pbd);
            MessageBox.Show("删除定标器成功");
        }

        private void 删除区间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PushBasicData pbd = null;
            BROKENRAIL_BDATA_SECTION section = (BROKENRAIL_BDATA_SECTION)selectNode.Tag;
            foreach (TreeNode item in selectNode.Nodes)
            {
                BROKENRAIL_BDATA_DEVICE device = (BROKENRAIL_BDATA_DEVICE)item.Tag;
                BROKENRAIL_DEVICE_STATUS deviceStatus = Constant.client.Queryable<BROKENRAIL_DEVICE_STATUS>().Where(o => o.POINT_NO == device.POINT_NO).First();
                BROKENRAIL_DEVICE_STATUSHIS hisStatus = Constant.client.Queryable<BROKENRAIL_DEVICE_STATUSHIS>().Where(o => o.POINT_NO == device.POINT_NO).First();
                BROKENRAIL_VOLTAGE_STATUS volStatus = Constant.client.Queryable<BROKENRAIL_VOLTAGE_STATUS>().Where(o => o.POINT_NO == device.POINT_NO).First();
                BROKENRAIL_VOLTAGE_STATUSHIS volhisStatus = Constant.client.Queryable<BROKENRAIL_VOLTAGE_STATUSHIS>().Where(o => o.POINT_NO == device.POINT_NO).First();
                if (volStatus != null)
                {
                    pbd = new PushBasicData
                    {
                        addtime = DateTime.Now,
                        dataop = "DELETE",
                        datatext = JsonConvert.SerializeObject(volStatus),
                        datatype = "BROKENRAIL_VOLTAGE_STATUS",
                        status = 0,
                        errnum = 0
                    };
                    operateList.Add(pbd);
                }
                if (volhisStatus != null)
                {
                    pbd = new PushBasicData
                    {
                        addtime = DateTime.Now,
                        dataop = "DELETE",
                        datatext = JsonConvert.SerializeObject(volhisStatus),
                        datatype = "BROKENRAIL_VOLTAGE_STATUSHIS",
                        status = 0,
                        errnum = 0
                    };
                    operateList.Add(pbd);
                }
                if (deviceStatus != null)
                {
                    pbd = new PushBasicData
                    {
                        addtime = DateTime.Now,
                        dataop = "DELETE",
                        datatext = JsonConvert.SerializeObject(deviceStatus),
                        datatype = "BROKENRAIL_DEVICE_STATUS",
                        status = 0,
                        errnum = 0
                    };
                    operateList.Add(pbd);
                }
                if(hisStatus != null)
                {
                    pbd = new PushBasicData
                    {
                        addtime = DateTime.Now,
                        dataop = "DELETE",
                        datatext = JsonConvert.SerializeObject(hisStatus),
                        datatype = "BROKENRAIL_DEVICE_STATUSHIS",
                        status = 0,
                        errnum = 0
                    };
                    operateList.Add(pbd);
                }
                var l = Constant.client.Queryable<BROKENRAIL_SECTION_LINE>().Where(o => o.POINT_NO == device.POINT_NO).First();
                if (l != null)
                {
                    pbd = new PushBasicData
                    {
                        addtime = DateTime.Now,
                        dataop = "DELETE",
                        datatext = JsonConvert.SerializeObject(l),
                        datatype = "BROKENRAIL_SECTION_LINE",
                        status = 0,
                        errnum = 0
                    };
                    operateList.Add(pbd);
                }
                pbd = new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "DELETE",
                    datatext = JsonConvert.SerializeObject(device),
                    datatype = "BROKENRAIL_BDATA_DEVICE",
                    status = 0,
                    errnum = 0
                };
                operateList.Add(pbd);
            }
            BROKENRAIL_SECTION_STATUS sectionStatus = Constant.client.Queryable<BROKENRAIL_SECTION_STATUS>().Where(o => o.SECTION_ID == section.SECTION_ID).First();
            BROKENRAIL_SECTION_STATUSHIS sectionhisList = Constant.client.Queryable<BROKENRAIL_SECTION_STATUSHIS>().Where(o => o.SECTION_ID == section.SECTION_ID).First();
            if (sectionStatus != null)
            {
                pbd = new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "DELETE",
                    datatext = JsonConvert.SerializeObject(sectionStatus),
                    datatype = "BROKENRAIL_SECTION_STATUS",
                    status = 0,
                    errnum = 0
                };
                operateList.Add(pbd);
            }
            if (sectionhisList != null)
            {
                pbd = new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "DELETE",
                    datatext = JsonConvert.SerializeObject(sectionhisList),
                    datatype = "BROKENRAIL_SECTION_STATUSHIS",
                    status = 0,
                    errnum = 0
                };
                operateList.Add(pbd);
            }
            string json = JsonConvert.SerializeObject(section);
            pbd = new PushBasicData
            {
                addtime = DateTime.Now,
                dataop = "DELETE",
                datatext = json,
                datatype = "BROKENRAIL_BDATA_SECTION",
                status = 0,
                errnum = 0
            };
            operateList.Add(pbd);
            MessageBox.Show("删除区间成功");
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView1.SelectedNode = e.Node;
            if(e.Button == MouseButtons.Right)
            {
                selectNode = e.Node;
                if (e.Node.Level == 0)
                {
                    this.contextMenuStripSection.Show(treeView1, e.X, e.Y);
                }
                else if(e.Node.Level == 1)
                {
                    BROKENRAIL_BDATA_DEVICE device = e.Node.Tag as BROKENRAIL_BDATA_DEVICE;
                    if(device.TYPE == "定标器")
                    {
                        this.contextMenuStripPoint.Items[2].Visible = false;
                    }
                    else
                    {
                        this.contextMenuStripPoint.Items[2].Visible = true;
                    }
                    this.contextMenuStripPoint.Show(treeView1, e.X, e.Y);
                }
            }
        }

        private void 删除画线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BROKENRAIL_BDATA_DEVICE device = (BROKENRAIL_BDATA_DEVICE)selectNode.Tag;
            var line = Constant.client.Queryable<BROKENRAIL_SECTION_LINE>().Where(o => o.POINT_NO == device.POINT_NO).First();
            if (line != null)
            {
                string json = JsonConvert.SerializeObject(device);
                PushBasicData pbd = new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "DELETE",
                    datatext = json,
                    datatype = "BROKENRAIL_BDATA_DEVICE",
                    status = 0,
                    errnum = 0
                };
                operateList.Add(pbd);
                MessageBox.Show("删除画线成功");
            }
            else
            {
                MessageBox.Show("此定标器无画线数据");
            }
        }

        private void 新增区间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdd add = new FormAdd();
            add.ShowDialog();
        }

        private void 重新加载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            this.treeView1.Nodes.Clear();
            foreach (BROKENRAIL_BDATA_SECTION item in sectionList)
            {
                TreeNode sectionNode = new TreeNode(item.SECTION_NAME);
                sectionNode.Tag = item;
                // sectionNode.ContextMenuStrip = this.contextMenuStripSection;
                this.treeView1.Nodes.Add(sectionNode);
                AddPointData(sectionNode, 0, "Category");
            }
        }

        private void 分界线数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBoundary fb = new FrmBoundary();
            fb.ShowDialog();
        }

        private void 新增定标器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BROKENRAIL_BDATA_SECTION section = (BROKENRAIL_BDATA_SECTION)selectNode.Tag;
            FormDeviceAdd fda = new FormDeviceAdd(section);
            fda.ShowDialog();

        }

        private void txtPointNo_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            txtPointNoL.Text = t.Text;
        }

        public void nextnodes(TreeNode node, string text)
        {

            if (node.Text.Contains(text.Trim()))
            {
                showNodes(node); //打开节点
            }

        }
        public void showNodes(TreeNode node) //打开节点
        {
            if (node != null)
            {
                node.Expand();
                showNodes(node.Parent); //递归
            }
        }
        private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BROKENRAIL_BDATA_DEVICE device = treeView1.SelectedNode.Tag as BROKENRAIL_BDATA_DEVICE;
            BROKENRAIL_SECTION_LINE line = Constant.client.Queryable<BROKENRAIL_SECTION_LINE>().Where(o => o.POINT_NO == device.POINT_NO).First();
            
            ChangePhone cp = new ChangePhone(device, line);
            cp.ShowDialog();
        }

        private void 生成导入语句ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<PushBasicData> list = new List<PushBasicData>();
            foreach (var item in sectionList)
            {
                list.Add(new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "INSERT",
                    datatext = JsonConvert.SerializeObject(item),
                    datatype = "BROKENRAIL_BDATA_SECTION",
                    status = 0,
                    errnum = 0
                });
            }
            foreach (var item in deviceList)
            {
                list.Add(new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "INSERT",
                    datatext = JsonConvert.SerializeObject(item),
                    datatype = "BROKENRAIL_BDATA_DEVICE",
                    status = 0,
                    errnum = 0
                });
            }
            foreach (var item in lineList)
            {
                list.Add(new PushBasicData
                {
                    addtime = DateTime.Now,
                    dataop = "INSERT",
                    datatext = JsonConvert.SerializeObject(item),
                    datatype = "BROKENRAIL_SECTION_LINE",
                    status = 0,
                    errnum = 0
                });
            }
            Constant.SaveFile(list, "");
        }
    }
}
