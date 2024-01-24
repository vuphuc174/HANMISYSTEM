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

namespace HANMISYSTEM.Views.User
{
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
        }
        DAO_User dAO_User = new DAO_User();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtDisplayName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Điền đầy đủ các trường cần thiết !");
            }
            else if(await dAO_User.CheckExisted(txtUsername.Text))
            {
                MessageBox.Show("Username đã được sử dụng!");
            }    
            else if(txtPassword.Text !=txtConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!");
            }
            else if(txtPassword.Text.Contains(" "))
            {
                MessageBox.Show("Mật khẩu chưa ký tự không hợp lệ!");
            }
            else
            {
                if(await dAO_User.AddNew(txtUsername.Text, txtPassword.Text, txtDisplayName.Text))
                {
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
        }
    }
}
