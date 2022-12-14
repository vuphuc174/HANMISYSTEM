using HANMISYSTEM.Common;
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
        string wh;
        private  void Warehouse_dashboard_Load(object sender, EventArgs e)
        {
            DataTable dtWarehouse = connect.readdata("select * from warehouse");
            cbbWarehouse.DataSource = dtWarehouse;
            cbbWarehouse.DisplayMember = "namewarehouse";
            cbbWarehouse.ValueMember = "idwarehouse";
            cbbWarehouse.SelectedValue = "WH002";
            wh = cbbWarehouse.SelectedValue.ToString();
            //await Task.Run(() => LoadData(wh));
        }
        DataTable dtproducts;
        DataTable dtpackages;
        DataTable dtnewimport;
        DataTable dtnewexport;
        private  void LoadData(string wh)
        {
            try
            {
                 dtproducts =  connect.readdata("select isnull(SUM(quantity),0) as quantity from packinginfo where idwarehouse='" + wh + "'  ");
                 dtpackages = connect.readdata("select isnull(count(idpack),0) as quantity from packinginfo where idwarehouse='" + wh + "'");
                 dtnewimport = connect.readdata("select isnull(SUM(si.quantity),0) as quantity from slipout sl inner join slipoutinfo si on sl.idslipout =si.idslipout where idcustomer='" + wh + "' and CONVERT(date,sl.dateout)=CONVERT(date,getdate())");
                 dtnewexport = connect.readdata("select isnull(SUM(si.quantity),0) as quantity from slipout sl inner join slipoutinfo si on sl.idslipout =si.idslipout where idwarehouse='"+wh+"' and CONVERT(date,sl.dateout)=CONVERT(date,getdate())");
                if(dtproducts!=null && dtpackages!=null && dtnewimport!=null && dtnewexport!=null)
                {
                    ThreadHelperClass.SetText(this, lbnewexport, Convert.ToInt32(dtnewexport.Rows[0]["quantity"].ToString()).ToString("N0"));
                    ThreadHelperClass.SetText(this, lbproducts, Convert.ToInt32(dtproducts.Rows[0]["quantity"].ToString()).ToString("N0"));
                    ThreadHelperClass.SetText(this, lbpackages, Convert.ToInt32(dtpackages.Rows[0]["quantity"].ToString()).ToString("N0"));
                    ThreadHelperClass.SetText(this, lbnewimport, Convert.ToInt32(dtnewimport.Rows[0]["quantity"].ToString()).ToString("N0"));
                }
            }
            catch(Exception ex)
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
                MainFormRef.DoCreateTab("Tồn kho theo mã hàng",inventory);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private  void cbbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbWarehouse.SelectedItem!=null)
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
    }
}
