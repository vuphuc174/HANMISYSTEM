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

namespace HANMISYSTEM.Views.Production
{
    public partial class BravoWorkOrderManagement : Form
    {
        DAO_Line dAO_Line = new DAO_Line();
        DAO_BravoWorkOrder dAO_BravoWorkOrder = new DAO_BravoWorkOrder();
        public BravoWorkOrderManagement()
        {
            InitializeComponent();
        }

        private async void BravoWorkOrderManagement_Load(object sender, EventArgs e)
        {
            try
            {
                cbbLine.DataSource = await dAO_Line.GetLines();
                cbbLine.DisplayMember = "namelocation1";
                cbbLine.ValueMember = "idlocation";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = await dAO_BravoWorkOrder.Filter(txtSearchTerm.Text, cbbLine.SelectedValue.ToString(),dtpfromDate.Value.ToString("yyyy-MM-dd"),dtptoDate.Value.ToString("yyyy-MM-dd"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
