using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM
{
    public partial class CustomMsgBox : Form
    {
        public CustomMsgBox()
        {
            InitializeComponent();
        }
        static CustomMsgBox MsgBox; static DialogResult result = DialogResult.No;
        ////////////////////////////////////////////////////////////////////////////////
        public static DialogResult Show(string Text, string Caption, string btnYes, string btnNo,string btnCancel)
        {
            MsgBox = new CustomMsgBox();
            MsgBox.label1.Text = Text;
            MsgBox.button1.Text = btnYes;
            MsgBox.button2.Text = btnNo;
            MsgBox.button3.Text = btnCancel;
            MsgBox.Text = Caption;
            result = DialogResult.No;
            MsgBox.ShowDialog();
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes; MsgBox.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = DialogResult.No; MsgBox.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel; MsgBox.Close();
        }
    }
}
