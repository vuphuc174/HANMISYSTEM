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
    public partial class EditInvoice : Form
    {
        public EditInvoice()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private string kq;
        private void btnprint_Click(object sender, EventArgs e)
        {
            Printing_Slipout fr = new Printing_Slipout();
            fr.lbday.Text = DateTime.Now.ToString("dd");
            fr.lbmonth.Text = DateTime.Now.ToString("MM");
            fr.lbyear.Text = DateTime.Now.ToString("yyyy");

            DataTable dt=connect.readdata("select * from ioview where idslipout='"+lbinvoice.Text+"'");
            fr.lbinvoice.Text = lbinvoice.Text;
            fr.lbewarehouse.Text=mahoa(dt.Rows[0]["idwarehouse"].ToString());
            fr.lbiwarehouse.Text = mahoa(dt.Rows[0]["idcustomer"].ToString());
            fr.lbcarnumber.Text = txtcarno.Text;

            DataTable dt1 = connect.readdata("select cargo.partno,cargo.partname,SUM(quantity) as qty from cargo inner join slipoutinfo on cargo.partno=slipoutinfo.partno  where idslipout='" + lbinvoice.Text + "' group by cargo.partno,cargo.partname");
            fr.dataGridView1.DataSource = dt1;

            fr.ShowDialog();
        }
        private string mahoa(string s)
        {
            
            if(s=="WH001")
            {
                kq = "Production Warehouse";
            }
            if (s == "WH002")
            {
                kq = "Material Warehouse";
            }
            if (s == "WH003")
            {
                kq = "Injection Warehouse";
            }
            if (s == "WH004")
            {
                kq = "Spray Warehouse";
            }
            if (s == "WH005")
            {
                kq = "Printing Warehouse";
            }
            if (s == "WH006")
            {
                kq = "Delivery Warehouse";
            }
           
            return kq;
        }

        private void EditInvoice_Load(object sender, EventArgs e)
        {
            if (lbinvoice.Text.Substring(2, 2) == "LG")
            {
                dataGridView1.Columns["quantity"].ReadOnly = false;
                dataGridView1.Rows[0].Cells["remain"].Value = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (connect.countdata("select count(*) from packinginfo where idpack='" + dataGridView1.Rows[i].Cells["idpack"].Value.ToString() + "' and idwarehouse<>'WH007'") == 0)
                    {
                        //MessageBox.Show("oooo");
                        dataGridView1.Rows[i].Cells["remain"].Value = 0;
                    }
                    else
                    {
                        DataTable dt1 = connect.readdata("select * from packinginfo where idpack='" + dataGridView1.Rows[i].Cells["idpack"].Value.ToString() + "'");
                        dataGridView1.Rows[i].Cells["remain"].Value = dt1.Rows[0]["quantity"].ToString();
                    }
                }

            }
        }
        int qty;
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = connect.readdata("select * from packinginfo where idpack='"+dataGridView1.Rows[e.RowIndex].Cells["idpack"].Value +"' and idwarehouse <>'WH007'");
            DataTable dt1 = connect.readdata("select * from slipoutinfo where idpack='" + dataGridView1.Rows[e.RowIndex].Cells["idpack"].Value + "' and idslipout='"+lbinvoice.Text+"'");
            if(dt.Rows.Count>0)
            {
                qty =Convert.ToInt32(dt1.Rows[0]["quantity"].ToString()) + Convert.ToInt32(dt.Rows[0]["quantity"].ToString());
            }
            else
            {
                qty = Convert.ToInt32(dt1.Rows[0]["quantity"].ToString());
            }
            if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["quantity"].Value) > qty || Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["quantity"].Value)<=0)
            {
                MessageBox.Show("Not invalid");
                dataGridView1.Rows[e.RowIndex].Cells["quantity"].Value = dt1.Rows[0]["quantity"].ToString();
                dataGridView1.Rows[e.RowIndex].Cells["remain"].Value = dt.Rows[0]["quantity"].ToString();

            }
            else
            {
                dataGridView1.Rows[e.RowIndex].Cells["remain"].Value = qty -Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["quantity"].Value);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string r;
        private string mahoanguoc(string str)
        {

            if (str == "PW")
            {
                r = "WH001";
            }
            if (str == "WH")
            {
                r = "WH002";
            }
            if (str == "IW")
            {
                r = "WH003";
            }
            if (str == "WH004")
            {
                r = "SW";
            }
            if (str == "PR")
            {
                r = "WH005";
            }
            if (str == "DW")
            {
                r = "WH006";
            }
            if (str == "LG")
            {
                r = "WH007";
            }
            return r;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            for(int i=0;i<dataGridView1.Rows.Count;i++)
            {
                connect.exedata("update slipoutinfo set quantity ='" + dataGridView1.Rows[i].Cells["quantity"].Value + "' where idpack='" + dataGridView1.Rows[i].Cells["idpack"].Value + "' and idslipout='"+lbinvoice.Text+"'");
                if(Convert.ToInt32(dataGridView1.Rows[i].Cells["remain"].Value)==0)
                {
                    connect.exedata("delete from packinginfo where idpack='"+dataGridView1.Rows[i].Cells["idpack"].Value+"'");
                }
                else
                {
                    if (connect.countdata("select count (*) from packinginfo where idpack='" + dataGridView1.Rows[i].Cells["idpack"].Value + "' and idwarehouse='"+mahoanguoc(lbinvoice.Text.Substring(0,2))+"'") == 0)
                    {
                        connect.exedata("insert into packinginfo (idpack,partno,quantity,packingdate,idwarehouse) values('" + dataGridView1.Rows[i].Cells["idpack"].Value + "','" + dataGridView1.Rows[i].Cells["partno"].Value + "','" + dataGridView1.Rows[i].Cells["remain"].Value + "','"+DateTime.Now.ToString("yyyy-MM-dd")+"','"+mahoanguoc(lbinvoice.Text.Substring(0,2))+"')");
                    }
                    else
                    {
                        connect.exedata("update packinginfo set quantity ='" + dataGridView1.Rows[i].Cells["remain"].Value + "' where idpack='" + dataGridView1.Rows[i].Cells["idpack"].Value + "'");

                    }
                }
            }
        }
    }
}
