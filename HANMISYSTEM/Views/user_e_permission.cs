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
    public partial class user_e_permission : Form
    {
        public user_e_permission()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            connect.exedata("delete from tbl_user_e_permission where username ='" + lbusername.Text + "'");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    connect.exedata("insert into tbl_user_e_permission (username,idwarehouse) values ('" + lbusername.Text + "','" + row.Cells["idwarehouse"].Value.ToString() + "')");
                }

            }
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbusername_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
