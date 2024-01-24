using HANMISYSTEM.DAO;
using HANMISYSTEM.Views.Role;
using HANMISYSTEM.Views.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Credential
{
    public partial class AddNewCredential : Form
    {
        public AddNewCredential()
        {
            InitializeComponent();
        }
        DAO_Credential dAO_Credential = new DAO_Credential();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRoleSearch_Click(object sender, EventArgs e)
        {
            using (RoleSearch frm = new RoleSearch())
            {
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
                txtRoleID.Text = frm.GetRoleID();
            }
        }

        private void btnUserGroupSearch_Click(object sender, EventArgs e)
        {
            using (UserGroupSearch frm = new UserGroupSearch())
            {
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
                txtUserGroupID.Text = frm.GetUserGroupID();
            }
        }
        private bool CheckState()
        {
            if (string.IsNullOrEmpty(txtUserGroupID.Text) || string.IsNullOrEmpty(txtRoleID.Text))
            {
                return false;
            }
            return true;

        }
        private async void btnOK_Click(object sender, EventArgs e)
        {
            if (CheckState())
            {
                if (await dAO_Credential.CheckExist(txtUserGroupID.Text, txtRoleID.Text))
                {
                    MessageBox.Show("Phân quyền đã tồn tại");
                }
                else
                {
                    if (await dAO_Credential.AddNewCredential(txtUserGroupID.Text, txtRoleID.Text))
                    {
                        MessageBox.Show("Thêm thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }

            }
            else
            {
                MessageBox.Show("Thông tin nhập vào không hợp lệ");
            }


        }
    }
}
