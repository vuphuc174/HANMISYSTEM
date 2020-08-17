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

namespace HANMISYSTEM.Views.BOM
{
    public partial class EditBOM : Form
    {
        public EditBOM()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        Isnumber isnumber = new Isnumber();
        public DataTable dtbom;
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //DataTable dtbom = connect.readdata("select rawpartno,(select partname from cargo where partno=bom.rawpartno) as partname,(select nameunit from unit where idunit =(select idunit from cargo where partno =bom.rawpartno)) as unit,quantity,(select Name from BomProcess where ID =(select ProcessID from cargo where partno=bom.rawpartno)) as Process from bom where partno='" + fr.txtpartno.Text + "'");

        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.ColumnIndex==1)
            //{
            //    DataTable  dtnewrow = connect.readdata("select partname,nameunit,1 as quantity,name from cargo c inner join unit u on c.idunit=u.idunit inner join BomProcess b on c.ProcessID =b.ID where partno  ='"+dataGridView1.Rows[e.RowIndex].Cells["partno"].Value.ToString()+"'");
            //    if(dtnewrow.Rows.Count>0)
            //    {
            //        dtbom.Rows.Add(dataGridView1.Rows[e.RowIndex].Cells["partno"].Value.ToString(), dtnewrow.Rows[0]["partname"].ToString(), dtnewrow.Rows[0]["nameunit"].ToString(), dtnewrow.Rows[0]["quantity"].ToString(), dtnewrow.Rows[0]["name"].ToString());
            //        dataGridView1.DataSource = dtbom;
            //    }
            //    else
            //    {
            //        MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells["partno"].Value.ToString());
            //    }
            //}
            if(e.ColumnIndex==3)
            {
                //if(isnumber.IsNumber(dataGridView1.Rows[e.RowIndex].Cells["quantity"].Value.ToString())==false)
                //{
                //    MessageBox.Show("sai");
                //}
            }
        }

        private void txtaddpartno_TextChanged(object sender, EventArgs e)
        {
            lbsearch.Visible = true;
            lbaddpartname.Text = "";
            lbsearch.Items.Clear();
            DataTable dtsearch = connect.readdata("select top 15 partno from cargo where partno like '%" + txtaddpartno.Text + "%' or partname like '%" + txtaddpartno.Text + "%'");
            for (int i = 0; i < dtsearch.Rows.Count; i++)
            {
                lbsearch.Items.Add(dtsearch.Rows[i]["partno"].ToString());
            }
        }

        private void lbsearch_Click(object sender, EventArgs e)
        {
            if (lbsearch.SelectedItem != null)
            {
                txtaddpartno.Text = lbsearch.SelectedItem.ToString();
                DataTable dtpartname = connect.readdata("select partname from cargo where partno ='"+txtaddpartno.Text+"'");
                if(dtpartname.Rows.Count>0)
                {
                    lbaddpartname.Text = dtpartname.Rows[0]["partname"].ToString();
                }
                lbsearch.Visible = false;

            }
        }
        private bool checkdup;
        private void btnadd_Click(object sender, EventArgs e)
        {
            checkdup = true;

            if (txtaddpartno.Text != "")
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (txtaddpartno.Text == row.Cells["partno"].Value.ToString() || txtaddpartno.Text == txtpartno.Text)
                    {
                        checkdup = false;
                        break;
                    }
                }
                if (checkdup == false)
                {
                    MessageBox.Show("Mã này đã có ! ");
                    txtaddpartno.Text = "";
                    lbsearch.Visible = false;
                }
                else
                {
                    DataTable dtnewrow = connect.readdata("select partname,nameunit,1 as quantity,name from cargo c inner join unit u on c.idunit=u.idunit inner join BomProcess b on c.ProcessID =b.ID where partno  ='" + txtaddpartno.Text + "'");
                    if (dtnewrow.Rows.Count > 0)
                    {
                        dtbom.Rows.Add(txtaddpartno.Text, dtnewrow.Rows[0]["partname"].ToString(), dtnewrow.Rows[0]["nameunit"].ToString(), dtnewrow.Rows[0]["quantity"].ToString(), dtnewrow.Rows[0]["name"].ToString());
                        txtaddpartno.Text = "";
                        lbsearch.Visible = false;
                    }
                }

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int total = dataGridView1.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["Select"].Value) == true).Count();
            if (total > 0)
            {
                string message = $"Are you sure want to delete {total} row?";
                if (total > 1)
                    message = $"Are you sure want to delete {total} rows";
                if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = dataGridView1.RowCount - 1; i >= 0; i--)
                    {
                        DataGridViewRow row = dataGridView1.Rows[i];
                        //Check row selected
                        if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                        {
                            dataGridView1.Rows.RemoveAt(row.Index);
                        }
                    }
                }
            }
        }

        private void btnundo_Click(object sender, EventArgs e)
        {
            dtbom = connect.readdata("select rawpartno,(select partname from cargo where partno=bom.rawpartno) as partname,(select nameunit from unit where idunit =(select idunit from cargo where partno =bom.rawpartno)) as unit,quantity,(select Name from BomProcess where ID =(select ProcessID from cargo where partno=bom.rawpartno)) as Process from bom where partno='" + txtpartno.Text + "'");
            dataGridView1.DataSource = dtbom;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Lỗi ! " + anError.Context.ToString());

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            HANMISYSTEM.Module.ExportToExcel _excel = new ExportToExcel();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _excel.ExportToExcelFunction(dtbom, saveFileDialog1.FileName.ToString());
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            connect.exedata("delete from bom where partno ='"+txtpartno.Text+"'");
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                connect.exedata("insert into bom values ('" + txtpartno.Text + "','" + row.Cells["partno"].Value.ToString() + "','" + row.Cells["quantity"].Value.ToString() + "')");
            }
                MessageBox.Show("Thành công");

        }
    }
}
