using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Module
{
    class MyButton : System.Windows.Forms.Button
    {
        public MyButton()
        {
            this.FlatStyle= FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.ForeColor = Color.FromArgb(166, 166, 166);
        }
    }
}
