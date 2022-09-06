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
    public partial class Notify : Form
    {
        public Notify()
        {
            InitializeComponent();
        }
        public string content;
        private void Notify_Load(object sender, EventArgs e)
        {
            lbContent.Text = content;
        }
        SerialPort serialPort = new SerialPort(HANMISYSTEM.Properties.Settings.Default.comport, Convert.ToInt32(HANMISYSTEM.Properties.Settings.Default.baudrate));
        private void CallOK()
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
                //serialPort.WriteLine('\n' + "@R0" + '\r');
                //Thread.Sleep(10);
                //serialPort.WriteLine('\n' + "@Y0" + '\r');
                //Thread.Sleep(10);
                //serialPort.WriteLine('\n' + "@G1" + '\r');
                //Thread.Sleep(10);
                //serialPort.WriteLine('\n' + "@B0" + '\r');
                var chanel1 = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x01, 0x02, 0xAE };
                serialPort.Write(chanel1, 0, chanel1.Length);
                serialPort.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }
        private void btnConfirm_MouseClick(object sender, MouseEventArgs e)
        {
            CallOK();
            this.Close();
        }

        private void Notify_FormClosed(object sender, FormClosedEventArgs e)
        {
            CallOK();
        }
    }
}
