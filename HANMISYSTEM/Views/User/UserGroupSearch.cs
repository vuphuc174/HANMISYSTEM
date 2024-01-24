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
    public partial class UserGroupSearch : Form
    {
        public UserGroupSearch()
        {
            InitializeComponent();
        }
        DAO.DAO_UserGroup DAO_UserGroup = new DAO.DAO_UserGroup();
        string userGroupID;
        public string GetUserGroupID() { return userGroupID; }
        private async Task LoadData()
        {
            dataGridView1.DataSource = await DAO_UserGroup.GetUserGroups();
        }
        private async void UserGroupSearch_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0)
            {
                userGroupID = dataGridView1.Rows[e.RowIndex].Cells["ID_col"].Value.ToString();
                this.Close();
            }
        }
    }
}
