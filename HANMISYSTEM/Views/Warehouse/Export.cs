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
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void txtScan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13 && !string.IsNullOrEmpty(txtScan.Text))
            {
                string cmd = $"select * from packinginfo where idpack='{txtScan.Text}' and idwarehouse ='{cbbEWarehouse.SelectedValue.ToString()}'";
                DataTable dtPackage = connect.readdata(cmd);
                if(dtPackage.Rows.Count > 0)
                {

                    dgvPackageList.Rows.Add(dtPackage.Rows[0]["idpack"].ToString(), dtPackage.Rows[0]["partno"].ToString(), dtPackage.Rows[0]["quantity"].ToString(), dtPackage.Rows[0]["quantity"].ToString(),"");
                }
            }
        }

        private void Export_Load(object sender, EventArgs e)
        {
            DataTable dtcheckpermission = connect.readdata($"select t.idwarehouse,namewarehouse from tbl_user_permission t inner join warehouse w on t.idwarehouse=w.idwarehouse where username ='{UserSession.UserName}'");

            if (dtcheckpermission.Rows.Count > 0)
            {
                cbbEWarehouse.DataSource = dtcheckpermission;
                cbbEWarehouse.ValueMember = "idwarehouse";
                cbbEWarehouse.DisplayMember = "namewarehouse";
            }
        }
    }
}
