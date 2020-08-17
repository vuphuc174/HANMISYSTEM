using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HANMISYSTEM
{
    public partial class login : Form
    {
        Dbconnect connect = new Dbconnect();
        public login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            DataTable dt = connect.readdata("select * from tbl_user where username ='"+txtuser.Text+"' and password='"+txtpassword.Text+"'");
            if(dt.Rows.Count>0)
            {
                
                HANMISYSTEM.Properties.Settings.Default.username = txtuser.Text;
                if(ckrememberme.Checked==true)
                {
                    HANMISYSTEM.Properties.Settings.Default.rememberme = true;
                    HANMISYSTEM.Properties.Settings.Default.password = txtpassword.Text;
                }
                else
                {
                    HANMISYSTEM.Properties.Settings.Default.password = "";
                }
                Properties.Settings.Default.Save();
                Hanmi_process fr = new Hanmi_process();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password incorrect");
                txtpassword.Text = "";
                txtpassword.Focus();
            }
            
        }

        private void login_Load(object sender, EventArgs e)
        {
            txtservername.Text = HANMISYSTEM.Properties.Settings.Default.servername;
            txtuser.Text = HANMISYSTEM.Properties.Settings.Default.username;
            txtpassword.Text = HANMISYSTEM.Properties.Settings.Default.password;
            ckrememberme.Checked = HANMISYSTEM.Properties.Settings.Default.rememberme;
            txtuid.Text = HANMISYSTEM.Properties.Settings.Default.uid;
            txtpwd.Text = HANMISYSTEM.Properties.Settings.Default.pwd;
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            HANMISYSTEM.Properties.Settings.Default.uid = txtuid.Text;
            HANMISYSTEM.Properties.Settings.Default.servername = txtservername.Text;
            HANMISYSTEM.Properties.Settings.Default.pwd = txtpwd.Text;
            HANMISYSTEM.Properties.Settings.Default.pwd=txtpwd.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Success");
        }
    
  
        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = this.Size.Height == 366 ? new Size(323, 200) : new Size(323, 366);
        }
    }
}
