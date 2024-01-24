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
    public partial class AddNewGroupUser : Form
    {
        public AddNewGroupUser()
        {
            InitializeComponent();
        }
        DAO_UserGroup dAO_UserGroup = new DAO_UserGroup();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Contains(" ") || string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Kiểm tra trường dữ liệu");
            }
            else if(await dAO_UserGroup.CheckIDExisted(txtID.Text))
            {
                MessageBox.Show("Mã nhóm đã tồn tại !");
            }
            else
            {
                if(await dAO_UserGroup.AddNew(txtID.Text,txtName.Text))
                {
                    MessageBox.Show("Thêm nhóm thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm nhóm không thành công");
                }    
            }    
        }
    }
}
