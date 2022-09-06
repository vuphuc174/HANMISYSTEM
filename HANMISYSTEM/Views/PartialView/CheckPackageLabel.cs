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
    public partial class CheckPackageLabel : Form
    {
        public CheckPackageLabel()
        {
            InitializeComponent();
        }
        public string label;
        SerialPort serialPort = new SerialPort(HANMISYSTEM.Properties.Settings.Default.comport, Convert.ToInt32(HANMISYSTEM.Properties.Settings.Default.baudrate));
        private void CheckPackageLabel_Load(object sender, EventArgs e)
        {
            txtInput.Focus();
        }
        private void CallNG()
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
                //serialPort.WriteLine('\n' + "@R1" + '\r');
                //Thread.Sleep(10);
                //serialPort.WriteLine('\n' + "@Y0" + '\r');
                //Thread.Sleep(10);
                //serialPort.WriteLine('\n' + "@G0" + '\r');
                //Thread.Sleep(10);
                //serialPort.WriteLine('\n' + "@B1" + '\r');


                var chanel1 = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x01, 0x01, 0xAD };
                serialPort.Write(chanel1, 0, chanel1.Length);
                serialPort.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
              if(  label == txtInput.Text)
                {
                    this.Close();
                }
                else
                {
                    //call ng 
                    using (Notify f = new Notify())
                    {
                        CallNG();
                        f.content = "Label : " + txtInput.Text + " không hợp lệ.Xin hãy kiểm tra lại !!!";
                        f.ShowDialog();
                        txtInput.SelectAll();
                        txtInput.Focus();
                    }
                }
            }
        }
    }
}
