using HANMISYSTEM.Views.MsgBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Producs
{
    public partial class Searching : Form
    {
        public Searching()
        {
            InitializeComponent();
        }
        public string searchTerm;
        string _partno;
        string _partname;
        Dbconnect dbconnect =new Dbconnect();
        public string PartNo()
        {
            return _partno;
        }
        public string PartName()
        {
            return _partname;
        }
        private void Searching_Load(object sender, EventArgs e)
        {
            lbSearchTerm.Text = searchTerm;
            DataTable dt =dbconnect.readdata("select top 20 partno,partname from cargo where partno like '%"+searchTerm+"%'");
            if(dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }    
            else
            {
                using(CustomMessageBox frm =new CustomMessageBox())
                {
                    frm.ShowInTaskbar = false;
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.lbContent.Text = "Không tìm thấy kết quả phù hợp nào!";
                    frm.ShowDialog();
                    this.Close();
                }
            }
            //MessageBox.Show("X" + this.Location.X.ToString() + "-----Y:" + this.Location.Y.ToString());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell is DataGridViewButtonCell)
                {
                    _partno =dataGridView1.Rows[e.RowIndex].Cells["Partno_col"].Value.ToString();
                    _partname =dataGridView1.Rows[e.RowIndex].Cells["Partname_col"].Value.ToString();
                }
            }
            this.Close();
        }
    }
}
