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
        public string pushnotifytype;
        public string label;
        SerialPort serialPort = new SerialPort(HANMISYSTEM.Properties.Settings.Default.comport, Convert.ToInt32(HANMISYSTEM.Properties.Settings.Default.baudrate));
        Dbconnect dbconnect = new Dbconnect();
        private void CheckPackageLabel_Load(object sender, EventArgs e)
        {
            //set push notify type 
            if (!string.IsNullOrEmpty(HANMISYSTEM.Properties.Settings.Default.pushnotifytype))
            {
                pushnotifytype = HANMISYSTEM.Properties.Settings.Default.pushnotifytype;
            }
            else
            {
                pushnotifytype = "1";
            }
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


                //var chanel1 = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x01, 0x01, 0xAD };
                //serialPort.Write(chanel1, 0, chanel1.Length);
                ////chanel 2
                if (pushnotifytype == "1")
                {
                    //chanel 1
                    var chanel1 = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x01, 0x01, 0xAD };
                    serialPort.Write(chanel1, 0, chanel1.Length);
                }
                else
                {
                    ////chanel 2
                    var chanel2 = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x02, 0x01, 0xAE };
                    serialPort.Write(chanel2, 0, chanel2.Length);
                }
                //Thread.Sleep(10);
                serialPort.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txtInput.Text.Length>0)
            {
                if (label == txtInput.Text)
                {
                    if (CheckLabelAccessory())
                    {
                        txtChildPart.Visible = true;
                        txtChildPart.Focus();
                    }
                    else
                    {
                        this.Close();
                    }
                    
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
        private bool CheckLabelAccessory()
        {
            DataTable dt = dbconnect.readdata("select * from LabelAccessory where LabelPartNo ='" + label + "'");
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChildPart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DataTable dt = dbconnect.readdata("select * from LabelAccessory where LabelPartNo ='"+ label+"' and LabelAccessory ='"+txtChildPart.Text+"'");
                if(dt.Rows.Count > 0)
                {
                    this.Close();
                }
                else

                {
                    //call ng 
                    using (Notify f = new Notify())
                    {
                        CallNG();
                        f.content = "Label : " + txtInput.Text + " & "+txtChildPart.Text +" không hợp lệ.Xin hãy kiểm tra lại !!!";
                        f.ShowDialog();
                        txtChildPart.Text = "";
                        txtInput.SelectAll();
                        txtInput.Focus();
                    }
                }
            }
        }
    }
}
