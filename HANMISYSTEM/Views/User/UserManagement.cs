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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }
        DAO_User _dao = new DAO_User();
        DAO_UserGroupUser dAO_UserGroupUser = new DAO_UserGroupUser();
        private async void UserManagement_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await _dao.GetUsers();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserID.Text))
            {
                using (UserResetPassword frm = new UserResetPassword())
                {
                    frm._userID = txtUserID.Text;
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowInTaskbar = false;
                    frm.ShowDialog(); 
                }
            }
            else
            {
                MessageBox.Show("Chưa có tài khoản nào được chọn!");
            }
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                btnResetPassword.Enabled = true;
                txtUserID.Text = dataGridView1.Rows[e.RowIndex].Cells["UserID_col"].Value.ToString();
                txtUserName.Text = dataGridView1.Rows[e.RowIndex].Cells["UserName_col"].Value.ToString();
                txtDisplayName.Text = dataGridView1.Rows[e.RowIndex].Cells["Name_col"].Value.ToString();

                //load usergroupuser
                dataGridView2.DataSource =await dAO_UserGroupUser.GetGroupUser(dataGridView1.Rows[e.RowIndex].Cells["UserID_col"].Value.ToString());
            }
        }

        private async void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserID.Text))
            {
                using(AddGroupForUser frm = new AddGroupForUser())
                {
                    frm._userID = txtUserID.Text;
                    frm.StartPosition=FormStartPosition.CenterParent;
                    frm.ShowInTaskbar = false;
                    frm.ShowDialog();
                    dataGridView2.DataSource =await dAO_UserGroupUser.GetGroupUser(txtUserID.Text);
                }
            }
            else
            {
                MessageBox.Show("Chưa có tài khoản nào được chọn!");
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtDisplayName.Text) && !string.IsNullOrEmpty(txtUserID.Text))
            {
                if(await _dao.ChangeDisplayName(txtUserID.Text, txtDisplayName.Text))
                {
                    MessageBox.Show("Cập nhật thành công");
                    dataGridView1.DataSource = await _dao.GetUsers();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }    
            }    
        }

        private void btnOpenLineUserAssigment_Click(object sender, EventArgs e)
        {
            using(LineUserAssignment frm =new LineUserAssignment())
            {
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }

        private async void btnAddNew_Click(object sender, EventArgs e)
        {
            using(AddNewUser frm =new AddNewUser())
            {
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
                dataGridView1.DataSource = await _dao.GetUsers();
            }
        }
    }
}
