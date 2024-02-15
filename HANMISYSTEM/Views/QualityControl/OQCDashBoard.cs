using HANMISYSTEM.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.QualityControl
{
    public partial class OQCDashBoard : Form
    {
        public OQCDashBoard()
        {
            InitializeComponent();
        }
        public MainFrm MainFormRef { get; set; }
        DAO_Department dAO_Department = new DAO_Department();
        DAO_Credential dAO_Credential = new DAO_Credential();

        private void btnUpdateAccessory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateAccessory frm = new UpdateAccessory();
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private async void btnInspectorLabelWifi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(await dAO_Credential.CheckCredential("INSPECT_LABEL_QC"))
            {
                InspectorLabelWifi frm = new InspectorLabelWifi();
                frm.WindowState = FormWindowState.Maximized;
                frm.departmentID = await dAO_Department.GetIDByCode("QC");
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào đây");
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                InspectorLabelHistory frm = new InspectorLabelHistory();
                MainFormRef.DoCreateTab("Tồn kho theo mã đóng gói", frm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
