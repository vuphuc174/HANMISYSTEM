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
            //save push notify type
            if(radioButton1.Checked==true)
            {
                HANMISYSTEM.Properties.Settings.Default.pushnotifytype = "1";
            }
            else
            {
                HANMISYSTEM.Properties.Settings.Default.pushnotifytype = "2";
            }
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
            //push notify type 1,2
            if(!string.IsNullOrEmpty(HANMISYSTEM.Properties.Settings.Default.pushnotifytype))
            {
                switch(HANMISYSTEM.Properties.Settings.Default.pushnotifytype) 
                {
                    case "1":
                        radioButton1.Checked = true;
                        break;
                    case "2":
                        radioButton2.Checked = true;
                        break;
                    default:
                        radioButton1.Checked = true;
                        break;
                }
            }
            else
            {
                radioButton1.Checked = true;
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            DebugRelay frm = new DebugRelay();
            frm.ShowDialog();
        }
    }
}
