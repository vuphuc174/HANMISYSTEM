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

namespace HANMISYSTEM.Views.RawMgt
{
    public partial class ReturnSupplier : Form
    {
        public ReturnSupplier()
        {
            InitializeComponent();
        }
        Dbconnect dbconnect = new Dbconnect();
        DataTable dtReturnSupplier;
        private void ReturnSupplier_Load(object sender, EventArgs e)
        {
            DataTable dtwarehouse = dbconnect.readdata("select idwarehouse,namewarehouse from warehouse where idcategory='W2' and idwarehouse='WH014'");
            cbwarehouse.DataSource = dtwarehouse;
            cbwarehouse.DisplayMember = "namewarehouse";
            cbwarehouse.ValueMember = "idwarehouse";

            DataTable dtsupplier = dbconnect.readdata("select idwarehouse,namewarehouse from warehouse where idcategory='W3' or idwarehouse='WH009' or idwarehouse='WH010'");
            cbSupplier.DataSource = dtsupplier;
            cbSupplier.DisplayMember = "namewarehouse";
            cbSupplier.ValueMember = "idwarehouse";

            cbFilterSupplier.DataSource = dtsupplier;
            cbFilterSupplier.DisplayMember = "namewarehouse";
            cbFilterSupplier.ValueMember = "idwarehouse";

            if (cbwarehouse.Text != "")
            {
                dtReturnSupplier = dbconnect.readdata("select rs.ID,rs.Partno,(select partname from cargo where partno=rs.PartNo) as PartName,(select namewarehouse from warehouse where idwarehouse=rs.IdSupplier) as Supplier,rs.Quantity,rs.ReturnDate from ReturnSupplier rs where rs.Idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "'");
                dataGridView1.DataSource = dtReturnSupplier;
            }
        }

        private void txtPartNo_TextChanged(object sender, EventArgs e)
        {
            lbsearch.Visible = true;
            lbsearch.Items.Clear();
            DataTable dtsearch = dbconnect.readdata("select top 15 PartNo from cargo where  PartNo like '%" + txtPartNo.Text + "%' or partname like '%" + txtPartNo.Text + "%' ");
            for (int i = 0; i < dtsearch.Rows.Count; i++)
            {
                lbsearch.Items.Add(dtsearch.Rows[i]["PartNo"].ToString());
            }
        }

        private void lbsearch_Click(object sender, EventArgs e)
        {
            if (lbsearch.SelectedItem != null)
            {
                txtPartNo.Text = lbsearch.SelectedItem.ToString();
                DataTable dtPartName = dbconnect.readdata("select PartName from cargo where partno='" + txtPartNo.Text + "'");
                txtPartName.Text = dtPartName.Rows[0]["PartName"].ToString();
                lbsearch.Visible = false;
            }
        }
        Isnumber isnumber = new Isnumber();
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtPartNo.Text == "" || isnumber.IsNumber(txtQuantity.Text) == false || isnumber.IsPositive(txtQuantity.Text) == false || txtReason.Text == "")
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ");
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Bạn có chắc chắn muốn trả lại hàng ", "Xác nhận", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    if (dbconnect.exedata("insert into ReturnSupplier (PartNo,Idwarehouse,Quantity,IdSupplier,Reson,ReturnDate,ReturnBy) values('" + txtPartNo.Text + "','" + cbwarehouse.SelectedValue.ToString() + "','" + txtQuantity.Text + "','" + cbSupplier.SelectedValue.ToString() + "','" + txtReason.Text + "',getdate(),'" + HANMISYSTEM.Properties.Settings.Default.username + "')") == true)
                    {
                        if (dbconnect.countdata("select count(partno) from stock where partno='" + txtPartNo.Text + "' and idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "'") != 0)
                        {
                            dbconnect.exedata("update stock set quantity =quantity-" + txtQuantity.Text + " where idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "' and partno='" + txtPartNo.Text + "'");
                        }
                        else
                        {
                            dbconnect.exedata("insert into stock (idwarehouse,partno,quantity) values ('" + cbwarehouse.SelectedValue.ToString() + "','" + txtPartNo.Text + "','-" + txtQuantity.Text + "')");
                        }
                        txtQuantity.Text = "";
                        txtPartNo.Text = "";
                        lbsearch.Visible = false;
                        txtPartName.Text = "";
                        txtReason.Text = "";

                    }
                }
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("PartNo like '%{0}%'", txtsearch.Text);
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            if (btnfilter.Text == "Lọc")
            {
                dtReturnSupplier = dbconnect.readdata("select rs.ID,rs.Partno,(select partname from cargo where partno=rs.PartNo) as PartName,(select namewarehouse from warehouse where idwarehouse=rs.IdSupplier) as Supplier,rs.Quantity,rs.ReturnDate from ReturnSupplier rs where rs.Idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "' and Convert(date,rs.ReturnDate)='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and IdSupplier='" + cbFilterSupplier.SelectedValue.ToString() + "'");
                dataGridView1.DataSource = dtReturnSupplier;
                btnfilter.Text = "Bỏ Lọc";
                txtsearch.Text = "";
            }
            else
            {
                dtReturnSupplier = dbconnect.readdata("select rs.ID,rs.Partno,(select partname from cargo where partno=rs.PartNo) as PartName,(select namewarehouse from warehouse where idwarehouse=rs.IdSupplier) as Supplier,rs.Quantity,rs.ReturnDate from ReturnSupplier rs where rs.Idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "'");
                dataGridView1.DataSource = dtReturnSupplier;
                txtsearch.Text = "";
                btnfilter.Text = "Lọc";
            }

        }

        private void cbwarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtReturnSupplier = dbconnect.readdata("select rs.ID,rs.Partno,(select partname from cargo where partno=rs.PartNo) as PartName,(select namewarehouse from warehouse where idwarehouse=rs.IdSupplier) as Supplier,rs.Quantity,rs.ReturnDate from ReturnSupplier rs where rs.Idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "'");
            dataGridView1.DataSource = dtReturnSupplier;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataTable dtReturnSupplier = dbconnect.readdata("select Reson,ReturnBy from ReturnSupplier where ID='" + dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString() + "'"); ;
                dataGridView1.Rows[e.RowIndex].Cells["ID"].ToolTipText = "Lý do trả : " + dtReturnSupplier.Rows[0]["Reson"].ToString() + "- trả hàng bởi " + dtReturnSupplier.Rows[0]["ReturnBy"].ToString();
            }

        }
    }
}
