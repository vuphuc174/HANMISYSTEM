using HANMISYSTEM.DAO;
using HANMISYSTEM.Views.LineUserAssignment;
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
    public partial class LineUserAssignment : Form
    {
        public LineUserAssignment()
        {
            InitializeComponent();
        }
        DAO_LineUserAssignment dAO_LineUserAssignment = new DAO_LineUserAssignment();
        private async void LineUserAssignment_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
        private async Task LoadData()
        {
            dataGridView1.DataSource = await dAO_LineUserAssignment.GetLineUserAssignment();
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using(AddNewLineUserAssignment frm =new AddNewLineUserAssignment())
            {
                frm.StartPosition =FormStartPosition.CenterScreen;
                frm.ShowInTaskbar = false;
                frm.ShowDialog();
                await LoadData();
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
