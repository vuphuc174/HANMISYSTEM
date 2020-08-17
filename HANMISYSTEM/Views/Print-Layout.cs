using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;

namespace HANMISYSTEM
{
    public partial class Print_Layout : Form
    {
        public Print_Layout()
        {
            InitializeComponent();
        }
        private PrintDocument printdoc1 = new PrintDocument();
        PrintPreviewDialog previewdlg = new PrintPreviewDialog();
        Panel pannel = null;
        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            printdoc1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }
        void printdoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }
        public void Print(Panel pnl)
        {
            pannel = pnl;
            GetPrintArea(pnl);
            previewdlg.Document = printdoc1;
            previewdlg.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printdoc1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
            Print(panel1);
            this.Close();
        }
        public void inlist()
        {
            printdoc1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
            Print(panel1);
            
        }


    }
}
