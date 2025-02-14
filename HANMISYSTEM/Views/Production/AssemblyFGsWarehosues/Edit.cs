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

namespace HANMISYSTEM.Views.Production.AssemblyFGsWarehosues
{
    public partial class Edit : Form
    {
        public  string _partno;
        public  string _lineID;
        public  string _factoryID;
        DAO_Product dAO_Product = new DAO_Product();
        DAO_Line dAO_Line = new DAO_Line();
        DAO_AssemblyFGsWarehouse DAO_AssemblyFGsWarehouse = new DAO_AssemblyFGsWarehouse();
        public Edit()
        {
            InitializeComponent();
        }

        private async void Edit_Load(object sender, EventArgs e)
        {
            try
            {
                txtPartno.Text = _partno;
                txtPartname.Text = await dAO_Product.GetPartName(_partno);
                DataTable dtLine = await dAO_Line.GetLineByID(_lineID);
                if (dtLine.Rows.Count > 0 && dtLine != null)
                {
                    txtLine.Text = dtLine.Rows[0]["namelocation1"].ToString();
                    txtFactory.Text = dtLine.Rows[0]["idwarehouse"].ToString();
                }
                //get quantity
                txtCurrentQuantity.Text = await DAO_AssemblyFGsWarehouse.GetInventory(_partno, _lineID);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtCurrentQuantity.Text = await DAO_AssemblyFGsWarehouse.GetInventory(_partno, _lineID);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTransferQuantity.Text, out int value) && value >= 0)
            {
                try
                {
                    await DAO_AssemblyFGsWarehouse.Update(_partno, _lineID, txtTransferQuantity.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Số lượng sau điều chỉnh không hợp lệ");
            }
            
        }
    }
}
