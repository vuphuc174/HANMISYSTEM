using HANMISYSTEM.Common;
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

namespace HANMISYSTEM.Views.Production.BravoWorkOrder
{
    public partial class AddBravoWorkOrder : Form
    {
        public string _partno;
        public string _lineID;
        public string _factoryID;
        string inv;
        DAO_Product dAO_Product = new DAO_Product();
        DAO_Production dAO_Production = new DAO_Production();
        DAO_Line dAO_Line = new DAO_Line();
        static string _workprocesscode = "LAPRAP2-1542";
        static string _warehouseId = "1970561";
        public AddBravoWorkOrder()
        {
            InitializeComponent();
        }
        public class Mapping_Line
        {
            public string factoryCode;
            public string factoryID;
            public string machineCode;
            public string machineID;
        }
        Mapping_Line _mapping_Line = new Mapping_Line();
        private async void AddBravoWorkOrder_Load(object sender, EventArgs e)
        {
            try
            {
                txtPartno.Text = _partno;
                txtPartname.Text = await dAO_Product.GetPartName(_partno);
                txtBravoUserID.Text = UserSession.UserID_Bravo;
                DataTable dtLine = await dAO_Line.GetLineByID(_lineID);
                DAO_AssemblyFGsWarehouse dAO_AssemblyFGsWarehouse = new DAO_AssemblyFGsWarehouse();
                if (dtLine.Rows.Count > 0 && dtLine != null)
                {
                    txtLine.Text = dtLine.Rows[0]["namelocation1"].ToString();
                    txtFactory.Text = dtLine.Rows[0]["idwarehouse"].ToString();
                }
                //get quantity
                inv = await dAO_AssemblyFGsWarehouse.GetInventory(_partno, _lineID);
                lbMax.Text = inv.ToString();
                txtCurrentQuantity.Text = inv.ToString();

                //mappng line
                DataTable dtMappingLine = await dAO_Line.GetBravoLineDetails(_lineID);
                try
                {
                    if (dtMappingLine.Rows.Count > 0)
                    {
                        _mapping_Line.factoryCode = dtMappingLine.Rows[0]["FactoryCode"].ToString();
                        _mapping_Line.factoryID = dtMappingLine.Rows[0]["FactoryID"].ToString();
                        _mapping_Line.machineCode = dtMappingLine.Rows[0]["Code"].ToString();
                        _mapping_Line.machineID = dtMappingLine.Rows[0]["Id"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi nạp dữ liệu mapping line(bravo): " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCurrentQuantity.Text, out int value) && value >= 0 && value <= Convert.ToDouble(inv))
            {
                DialogResult result = MessageBox.Show(
           "Xác nhận tạo WO",
           "Confirmation",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question
       );
                if (result == DialogResult.Yes)
                {
                    await dAO_Production.SubmitWorkOrder(_mapping_Line.factoryCode, _mapping_Line.factoryID, _mapping_Line.machineCode, _mapping_Line.machineID, _partno, txtCurrentQuantity.Text, "", "", "", _workprocesscode, _warehouseId);
                    Task.Delay(200).Wait();
                    await dAO_Production.CreateBravoWorkOrder(txtCurrentQuantity.Text,_lineID, _partno);
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Số lượng nhập vào không hợp lệ!");
            }
        }

        private void lbMax_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtCurrentQuantity.Text = lbMax.Text;
        }
    }
}
