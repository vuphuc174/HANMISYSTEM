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
    public partial class UserSearch : Form
    {
        public UserSearch()
        {
            InitializeComponent();
        }
        DAO_User dAO_User = new DAO_User();
        string users;
        public string _group;
        public string GetUsers()
        {
            return users;
        }
        private async void UserSearch_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
        private async Task LoadData()
        {
            dataGridView1.AutoGenerateColumns = false;
            if (string.IsNullOrEmpty(_group))
            {
                dataGridView1.DataSource = await dAO_User.GetUsers();
            }
            else
            {
                dataGridView1.DataSource = await dAO_User.GetUsersByGroupID(_group);
            }
        }

        private void btnGetSelectedUsers_Click(object sender, EventArgs e)
        {
            users = "";
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Checkbox_col"].Value != null && (bool)row.Cells["Checkbox_col"].Value)
                {
                    if (users == "")
                    {
                        users += row.Cells["UserName_col"].Value.ToString();
                    }
                    else
                    {
                        users+=";"+ row.Cells["UserName_col"].Value.ToString();
                    }
                }
            }
            this.Close();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
