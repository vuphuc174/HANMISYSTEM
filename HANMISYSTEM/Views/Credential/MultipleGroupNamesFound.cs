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

namespace HANMISYSTEM.Views.Credential
{
    public partial class MultipleGroupNamesFound : Form
    {
        public MultipleGroupNamesFound()
        {
            InitializeComponent();
        }
        public string _searchTerm;
        DAO_UserGroup dAO_UserGroup = new DAO_UserGroup();
        private async void MultipleGroupNamesFound_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
        private async Task LoadData()
        {
            dataGridView1.DataSource = await dAO_UserGroup.FindGroupByID(_searchTerm);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
