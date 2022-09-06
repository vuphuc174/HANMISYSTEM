using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.PartialView
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            HANMISYSTEM.Properties.Settings.Default.baudrate = cbbBaudRate.Text;
            HANMISYSTEM.Properties.Settings.Default.comport = cbbCOM.Text;

            HANMISYSTEM.Properties.Settings.Default.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            string[] baudrate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            cbbBaudRate.Items.AddRange(baudrate);
            cbbCOM.DataSource = SerialPort.GetPortNames();
            if (!string.IsNullOrEmpty(HANMISYSTEM.Properties.Settings.Default.comport))
            {
                cbbCOM.Text = HANMISYSTEM.Properties.Settings.Default.comport;
            }


            if (!string.IsNullOrEmpty(HANMISYSTEM.Properties.Settings.Default.baudrate))
            {
                cbbBaudRate.Text = HANMISYSTEM.Properties.Settings.Default.baudrate;
            }
            else
            {

                cbbBaudRate.SelectedIndex = 4;
            }
           
        }

      
    }
}
