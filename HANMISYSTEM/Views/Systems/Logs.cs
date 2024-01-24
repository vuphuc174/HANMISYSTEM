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

namespace HANMISYSTEM.Views.Systems
{
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
        }
        DAO_SystemLog dAO_SystemLog = new DAO_SystemLog();
        private void Logs_Load(object sender, EventArgs e)
        {
            List<string> loglevel = new List<string> { "all","error", "warning", "info" };
            cbbLogLevel.DataSource= loglevel;
            cbbLogLevel.SelectedIndex = 0;
        }

        private async void btnFilter_Click(object sender, EventArgs e)
        {
            DataTable logs = await dAO_SystemLog.Filter(cbbLogLevel.Text, txtLogBy.Text, txtSearchTerm.Text);
            try
            {
                dataGridView1.DataSource = logs;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
