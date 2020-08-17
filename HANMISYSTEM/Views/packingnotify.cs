using HANMISYSTEM.Module;
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
    public partial class packingnotify : Form
    {
        public packingnotify()
        {
            InitializeComponent();
        }
        Isnumber _isnumber = new Isnumber();
        Dbconnect connect = new Dbconnect();
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnapply_Click(object sender, EventArgs e)
        {
            if (_isnumber.IsNumber(txtquantity.Text))
            {
                if (Convert.ToInt32(txtquantity.Text) == 0 || Convert.ToInt32(txtquantity.Text) < 0)
                {
                    MessageBox.Show("Số không hợp lệ");
                    txtquantity.Text = "";
                    txtquantity.Focus();
                }
                else
                {
                    connect.exedata("insert into packingstandard (partno,idpacking,quantity) values ('" + lbpartno.Text + "','" + lbidpacking.Text + "','" + txtquantity.Text + "')");
                    this.Close();
                }
            }
        }
    }
}
