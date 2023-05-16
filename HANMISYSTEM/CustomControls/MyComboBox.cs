using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.CustomControls
{
    internal class MyComboBox:ComboBox
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x200; // WS_EX_CLIENTEDGE
                return cp;
            }
        }

    }
}
