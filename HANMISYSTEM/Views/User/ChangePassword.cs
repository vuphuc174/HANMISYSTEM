using HANMISYSTEM.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.User
{
    public partial class ChangePassword : Form
    {
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        // Constants for window styles
        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_STATICEDGE = 0x00020000;
        Dbconnect dbconnect = new Dbconnect();
        // Override CreateParams property to add WS_EX_STATICEDGE style
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_STATICEDGE;
                return cp;
            }
        }
        public ChangePassword()
        {
            // Set the FormBorderStyle to None so that it looks like a shadow
            this.FormBorderStyle = FormBorderStyle.None;
            // Set the opacity to a value between 0 and 1 (e.g., 0.5 for semi-transparent shadow)
            this.Opacity = 1;
            // Set the background color to a dark color to create the shadow effect
            this.BackColor = System.Drawing.Color.Black;
            InitializeComponent();
        }
        private bool CheckPassword(string user,string pass)
        {
            DataTable dt = dbconnect.readdata($"select * from tbl_user where username ='{user}' and password ='{pass}'");
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            string oldPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;


            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Xin hãy điền thông tin vào tất cả các trường.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Kiểm tra lại mật khẩu mới & nhập lại mật khẩu không trùng khớp.");
                return;
            }

            if (oldPassword == newPassword)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu cũ không được trùng nhau.");
                return;
            }

            // Simulate password change logic
            if (CheckPassword(UserSession.UserName,oldPassword))
            {
                dbconnect.exedata($"update tbl_user set password = '{newPassword}' where username ='{UserSession.UserName}'");
                MessageBox.Show("Thay đổi mật khẩu thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu. Xin hãy thử lại.");
            }
        }
    }
}
