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
    public partial class CredentialManagement : Form
    {
        public CredentialManagement()
        {
            InitializeComponent();
        }
        private int selectedRowIndex = -1;
        DAO.DAO_Credential daO_Credential = new DAO.DAO_Credential();
        private async void CredentialManagement_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
        private async Task LoadData()
        {
            dataGridView1.DataSource = await daO_Credential.GetGroupFollowRole();
        }

        private async void btnAddCredential_Click(object sender, EventArgs e)
        {
            using(AddNewCredential frm =new AddNewCredential())
            {
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
                await LoadData();
            }    
        }
        private async void AddMenuItem_Click(object sender, EventArgs e)
        {
            using (EditCredential frm = new EditCredential())
            {
                frm._roleID = dataGridView1.Rows[selectedRowIndex].Cells["RoleID_col"].Value.ToString();
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
                await LoadData();
            }
        }
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
                // Add menu items
                ToolStripMenuItem addMenuItem = new ToolStripMenuItem("Thêm nhóm");
                ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Sửa");
                ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");

                // Attach event handlers to menu items
                addMenuItem.Click += AddMenuItem_Click;
                //editMenuItem.Click += EditMenuItem_Click;
                //deleteMenuItem.Click += DeleteMenuItem_Click;

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
