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
    public partial class RoleSearch : Form
    {
        public RoleSearch()
        {
            InitializeComponent();
        }
        DAO.DAO_Role DAO_Role = new DAO.DAO_Role();
        string roleID;
        private async void RoleSearch_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
        private async Task LoadData()
        {
            dataGridView1.DataSource = await DAO_Role.GetRoles();
        }
        public string GetRoleID()
        {
            return roleID;
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
                roleID = dataGridView1.Rows[e.RowIndex].Cells["ID_col"].Value.ToString();
                this.Close();
            }
        }
    }
}
