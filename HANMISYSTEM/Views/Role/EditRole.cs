using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Role
{
    public partial class EditRole : Form
    {
        public EditRole()
        {
            InitializeComponent();
        }
        public string _roleID;
        DAO.DAO_Role dAO_Role = new DAO.DAO_Role();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void EditRole_Load(object sender, EventArgs e)
        {
            txtId.Text = _roleID;
            DataTable dtRole =await dAO_Role.GetRoleInfo(_roleID);
            try
            {
                txtName.Text = dtRole.Rows[0]["Name"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không nạp được thông tin:" +ex.Message);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Điền đầy đủ thông tin");
            }
            else
            {
                if(await dAO_Role.UpdateRole(txtId.Text, txtName.Text))
                {
                    MessageBox.Show("Thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }
    }
}
