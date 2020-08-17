using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views
{
    public partial class user_supplier_permission : Form
    {
        public user_supplier_permission()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            connect.exedata("delete from tbl_user_supplier_permission where username ='" + lbusername.Text + "'");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    connect.exedata("insert into tbl_user_supplier_permission (username,idwarehouse) values ('" + lbusername.Text + "','" + row.Cells["idwarehouse"].Value.ToString() + "')");
                }

            }
            this.Close();
        }
    }
}
