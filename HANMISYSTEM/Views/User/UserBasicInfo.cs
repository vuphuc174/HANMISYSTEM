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

namespace HANMISYSTEM.Views.User
{
    public partial class UserBasicInfo : Form
    {
        public UserBasicInfo()
        {
            InitializeComponent();
        }
        Dbconnect dbconnect = new Dbconnect();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.StartPosition = FormStartPosition.CenterScreen;
            changePassword.ShowInTaskbar = false;
            changePassword.ShowDialog();
        }

        private void UserBasicInfo_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = dbconnect.readdata("select name from tbl_user where username ='" + UserSession.UserName + "'");
                txtDisplayName.Text = dt.Rows[0]["name"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
