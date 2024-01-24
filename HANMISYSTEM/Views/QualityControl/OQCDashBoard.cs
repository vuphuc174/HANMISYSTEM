using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.QualityControl
{
    public partial class OQCDashBoard : Form
    {
        public OQCDashBoard()
        {
            InitializeComponent();
        }



        private void btnUpdateAccessory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateAccessory frm = new UpdateAccessory();
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}
