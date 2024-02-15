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

namespace HANMISYSTEM.Views.Warehouse
{
    public partial class Warehouse_dashboard : Form
    {
        public Warehouse_dashboard()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        DAO_PackingInfo dAO_PackingInfo = new DAO_PackingInfo();
        DAO_Slipout dAO_Slipout = new DAO_Slipout();
        string wh;
        private void Warehouse_dashboard_Load(object sender, EventArgs e)
        {
            DataTable dtWarehouse = connect.readdata("select * from warehouse");
            cbbWarehouse.DataSource = dtWarehouse;
            cbbWarehouse.DisplayMember = "namewarehouse";
            cbbWarehouse.ValueMember = "idwarehouse";
            cbbWarehouse.SelectedValue = "WH002";
            wh = cbbWarehouse.SelectedValue.ToString();
            //timer1.Start();
            //await Task.Run(() => LoadData(wh));
        }

        private async void LoadData(string wh)
        {
            try
            {
                ThreadHelperClass.SetText(this, lbnewexport, Convert.ToInt32(await dAO_PackingInfo.GetTodayExport(wh)).ToString("N0"));
                ThreadHelperClass.SetText(this, lbproducts, Convert.ToDouble(await dAO_PackingInfo.GetTotalProduct(wh)).ToString("N0"));
                ThreadHelperClass.SetText(this, lbpackages, Convert.ToInt32(await dAO_PackingInfo.GetTotalPackage(wh)).ToString("N0"));
                ThreadHelperClass.SetText(this, lbnewimport, Convert.ToInt32(await dAO_PackingInfo.GetTodayImport(wh)).ToString("N0"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public MainFrm MainFormRef { get; set; }
        private void gradientPanel2_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory inventory = new Inventory();
                inventory.wh = cbbWarehouse.SelectedValue.ToString();
                MainFormRef.DoCreateTab("Tồn kho theo mã hàng", inventory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbWarehouse.SelectedItem != null)
            {
                try
                {
                    wh = cbbWarehouse.SelectedValue.ToString();
                    //await Task.Run((Action)(() => LoadData(wh)));
                    LoadData(wh);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }
        private void gradientPanel5_Click(object sender, EventArgs e)
        {
            try
            {
                InventoryBaseOnPackageID inventory = new InventoryBaseOnPackageID();
                inventory.wh = cbbWarehouse.SelectedValue.ToString();
                MainFormRef.DoCreateTab("Tồn kho theo mã đóng gói", inventory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task LoadTransaction()
        {
            dgvRecentTransaction.DataSource = await dAO_Slipout.GetTop10NewTransaction(wh);
        }
        private async void timer1_Tick(object sender, EventArgs e)
        {
            await LoadTransaction();
        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
