using HANMISYSTEM.Module;
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
    public partial class BomDetails : Form
    {
        Dbconnect connect = new Dbconnect();
        public BomDetails()
        {
            InitializeComponent();
        }
        //cho phep copy
        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            
        if (e.KeyData == (Keys.Control | Keys.C)) {
            if (treeView1.SelectedNode != null) {
                Clipboard.SetText(treeView1.SelectedNode.Text);
            }
            e.SuppressKeyPress = true;
        
    }
        }

        private void BomDetails_MouseMove(object sender, MouseEventArgs e)
        {
            //toolTip1.SetToolTip(treeView1, "abc");
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            ExportToExcel _excel = new ExportToExcel();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataTable dtbom = connect.readdata("select b1.partno,c1.partname,rawpartno,c2.partname,quantity from bom b1 inner join cargo c1 on b1.partno=c1.partno inner join cargo c2 on b1.rawpartno= c2.partno where b1.partno ='" + lbpartno.Text + "'");
                _excel.ExportToExcelFunction(dtbom, saveFileDialog1.FileName.ToString());
            }
        }
    }
}
