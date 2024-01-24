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
    public partial class AddNewRole : Form
    {
        public AddNewRole()
        {
            InitializeComponent();
        }
        DAO.DAO_Role dAO_Role = new DAO.DAO_Role();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(btnOK.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Điền đầy đủ các trường yêu cầu");
            }
            else if(txtId.Text.Contains(" "))
            {
                MessageBox.Show("Mã Role không được chứa khoảng trắng!");
            }
            else if( await dAO_Role.CheckRoleExisted(txtId.Text) )
            {
                MessageBox.Show("Mã Role đã tồn tại!");
            }
            else
            {
                if(await dAO_Role.AddNewRole(txtId.Text, txtName.Text))
                {
                    MessageBox.Show("Thêm Role thành công!");
                    this.Close();
      
                }
                else
                {
                    MessageBox.Show("Thêm role thất bại");
                }    
            }
        }
    }
}
