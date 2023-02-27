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
    public partial class DebugRelay : Form
    {
        public DebugRelay()
        {
            InitializeComponent();
        }
        SerialPort serialPort = new SerialPort(HANMISYSTEM.Properties.Settings.Default.comport, Convert.ToInt32(HANMISYSTEM.Properties.Settings.Default.baudrate));
        private void DebugRelay_Load(object sender, EventArgs e)
        {
            lbpushnotifytype.Text = (HANMISYSTEM.Properties.Settings.Default.pushnotifytype == "1") ? "1 kênh relay" : "2 kênh relay";
            lbcom.Text = HANMISYSTEM.Properties.Settings.Default.comport;
            lbbaudrate.Text = HANMISYSTEM.Properties.Settings.Default.baudrate;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReadStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
                serialPort.DataReceived +=new SerialDataReceivedEventHandler(port_DataReceived);
                //var readstatus = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x00, 0x00, 0xAB };
                //int tmp =serialPort.Read(readstatus, 0, readstatus.Length);
                //MessageBox.Show(tmp.ToString());
                //serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var readstatus = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x00, 0x00, 0xAB };
            serialPort.Read(readstatus, 0, readstatus.Length);
            this.Invoke(new EventHandler(DoUpDate));
        }
        private void DoUpDate(object s, EventArgs e)
        {
            richTextBox1.Text = serialPort.ReadLine();
        }
        private void btnOpenCH1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
                //chanel 1
                var chanel1 = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x01, 0x01, 0xAD };
                serialPort.Write(chanel1, 0, chanel1.Length);
                serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCloseCH1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
                //chanel 1
                var chanel1 = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x01, 0x02, 0xAE };
                serialPort.Write(chanel1, 0, chanel1.Length);
                serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpenCH2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
                //chanel 2
                var chanel2 = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x02, 0x01, 0xAE };
                serialPort.Write(chanel2, 0, chanel2.Length);
                serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCLoseCH2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
                //chanel 2
                var chanel2 = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x02, 0x02, 0xAF };
                serialPort.Write(chanel2, 0, chanel2.Length);
                serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void myButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
