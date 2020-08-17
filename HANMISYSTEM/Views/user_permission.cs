using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM
{
    public partial class user_permission : Form
    {
        public user_permission()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void user_permission_Load(object sender, EventArgs e)
        {
            
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            connect.exedata("delete from tbl_user_permission where username ='" + lbusername.Text + "'");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    connect.exedata("insert into tbl_user_permission (username,idwarehouse) values ('" + lbusername.Text + "','" + row.Cells["idwarehouse"].Value.ToString() + "')");
                }
                
            }
            this.Close();
        }
    }
}
