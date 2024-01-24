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

namespace HANMISYSTEM.Views.Line
{
    public partial class LineSearch : Form
    {
        public LineSearch()
        {
            InitializeComponent();
        }
        string lineID;
        public string GetLineID()
        {
            return lineID;
        }
        DAO_Line dAO_Line = new DAO_Line();
        private async void LineSearch_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
        private async Task LoadData()
        {
            dataGridView1.DataSource = await dAO_Line.GetLines();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0)
            {
                lineID = dataGridView1.Rows[e.RowIndex].Cells["LineID_col"].Value.ToString();
                this.Close();
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
