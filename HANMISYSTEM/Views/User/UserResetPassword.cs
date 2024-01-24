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
    public partial class UserResetPassword : Form
    {
        public string _userID;
        public UserResetPassword()
        {
            InitializeComponent();
        }
        DAO.DAO_User dAO_User = new DAO.DAO_User();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text) || txtPassword.Text.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không hợp lệ");
            }
            else if(txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("2 trường không khớp nhau");
            }    
            else
            {
                if(await dAO_User.ChangePassword(_userID, txtPassword.Text))
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thay đổi mật khẩu thất bại!");
                }
            }    
        }
    }
}
