using HANMISYSTEM.Views.Role;
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
    public partial class RoleManagement : Form
    {
        public RoleManagement()
        {
            InitializeComponent();
        }
        DAO.DAO_Role dAO_Role = new DAO.DAO_Role();
        private async Task LoadData()
        {
            try
            {
                dataGridView1.DataSource = await dAO_Role.GetRoles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được :(( :" + ex.Message);
            }
        }

        private async void PermissionManagement_Load(object sender, EventArgs e)
        {
            await LoadData();

        }
        private async void AddMenuItem_Click(object sender, EventArgs e)
        {
            using (AddNewRole frm = new AddNewRole())
            {
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
                await LoadData();
            }
        }
        private async void EditMenuItem_Click(object sender, EventArgs e)
        {


            using (EditRole frm = new EditRole())
            {
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm._roleID = dataGridView1.Rows[selectedRowIndex].Cells["ID_col"].Value.ToString();
                frm.lbHeader.Text += "<" + dataGridView1.Rows[selectedRowIndex].Cells["ID_col"].Value.ToString() + ">";
                frm.ShowDialog();
                await LoadData();
            }


        }
        private async void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xoá role", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's choice
            if (result == DialogResult.Yes)
            {
               if( await dAO_Role.DeleteRole(dataGridView1.Rows[selectedRowIndex].Cells["ID_col"].Value.ToString()))
                {
                    MessageBox.Show("Xoá thành công role");
                    await LoadData();
                }
               else
                {
                    MessageBox.Show("Xoá không thành công");
                }    
            }
        }
        private async void btnAddRole_Click(object sender, EventArgs e)
        {
            using (AddNewRole frm = new AddNewRole())
            {
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
                await LoadData();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {


        }
        private int selectedRowIndex = -1;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
                // Add menu items
                ToolStripMenuItem addMenuItem = new ToolStripMenuItem("Thêm");
                ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Sửa");
                ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");

                // Attach event handlers to menu items
                addMenuItem.Click += AddMenuItem_Click;
                editMenuItem.Click += EditMenuItem_Click;
                deleteMenuItem.Click += DeleteMenuItem_Click;

                // Add items to the ContextMenuStrip
                contextMenuStrip1.Items.Add(addMenuItem);
                contextMenuStrip1.Items.Add(editMenuItem);
                contextMenuStrip1.Items.Add(deleteMenuItem);

                // Assign the ContextMenuStrip to the DataGridView
                dataGridView1.ContextMenuStrip = contextMenuStrip1;
                DataGridView.HitTestInfo hitTestInfo = dataGridView1.HitTest(e.X, e.Y);
                if (hitTestInfo.Type == DataGridViewHitTestType.Cell && hitTestInfo.RowIndex >= 0)
                {
                    selectedRowIndex = hitTestInfo.RowIndex; // Store the selected row index
                    dataGridView1.CurrentCell = dataGridView1.Rows[selectedRowIndex].Cells[0]; // Highlight the clicked cell
                    dataGridView1.ContextMenuStrip.Show(dataGridView1, dataGridView1.PointToClient(Cursor.Position));
                }



            }
        }
    }
}
