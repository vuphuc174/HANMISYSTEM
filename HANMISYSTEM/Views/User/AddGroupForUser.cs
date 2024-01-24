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
    public partial class AddGroupForUser : Form
    {
        public AddGroupForUser()
        {
            InitializeComponent();
        }
        DAO_UserGroup dAO_UserGroup = new DAO_UserGroup();
        DAO_UserGroupUser dAO_UserGroupUser = new DAO_UserGroupUser();
        public string _userID;
        private async void AddGroupForUser_Load(object sender, EventArgs e)
        {

            await LoadData();
        }
        private async Task LoadData()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.AutoGenerateColumns = false;
            DataTable dt = await dAO_UserGroup.GetUserGroup(_userID);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(Convert.ToBoolean(dt.Rows[i]["hasvalue"].ToString()), dt.Rows[i]["ID"].ToString(), dt.Rows[i]["Name"].ToString());
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnApply_Click(object sender, EventArgs e)
        {
            if (await dAO_UserGroupUser.RemoveCurrent(_userID))
            {
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Select_col"].Value))
                    {
                        await dAO_UserGroupUser.AddUGU(_userID,row.Cells["ID_col"].Value.ToString());
                    }
                }
                MessageBox.Show("Thành công");
                this.Close();   
            }
            else
            {
                MessageBox.Show("Lưu không thành công!");
            }
        }

        private async void btnAddNewGroup_Click(object sender, EventArgs e)
        {
            using(AddNewGroupUser frm =new AddNewGroupUser())
            {
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
                await LoadData();
            }
        }
    }
}
