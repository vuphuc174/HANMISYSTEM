using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.MsgBox
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
