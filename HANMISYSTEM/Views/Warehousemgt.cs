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
    public partial class Warehousemgt : Form
    {
        public Warehousemgt()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void loaddata(string sql)
        {
            DataTable data = connect.readdata(sql);
            if(data.Rows.Count>0)
            {
                dataGridView1.DataSource = data;
            }
        }

        private void Warehousemgt_Load(object sender, EventArgs e)
        {
            loaddata("select warehouse.idwarehouse,namewarehouse,namecategory,sign from warehouse inner join categorywarehouse on warehouse.idcategory=categorywarehouse.idcategory");
            DataTable dtcategory = connect.readdata("select idcategory,namecategory from categorywarehouse");
            if(dtcategory.Rows.Count>0)
            {
                cbcategory.DataSource = dtcategory;
                cbcategory.DisplayMember = "namecategory";
                cbcategory.ValueMember = "idcategory";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex !=-1)
            {
                txtidwarehouse.Text = dataGridView1.Rows[e.RowIndex].Cells["idwarehouse"].Value.ToString();
                txtnamewarehouse.Text = dataGridView1.Rows[e.RowIndex].Cells["namewarehouse"].Value.ToString();
                cbcategory.Text = dataGridView1.Rows[e.RowIndex].Cells["namecategory"].Value.ToString();
                txtsign.Text = dataGridView1.Rows[e.RowIndex].Cells["sign"].Value.ToString(); ;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtnamewarehouse.Text=="" || txtsign.Text.Length!=2)
            {
                MessageBox.Show("Khong hop le !");
            }
            else
            {
                if (connect.exedata("update warehouse set namewarehouse='" + txtnamewarehouse.Text + "' ,idcategory ='" + cbcategory.SelectedValue.ToString() + "',sign='" + txtsign.Text + "' WHERE idwarehouse ='"+txtidwarehouse.Text+"'") == true)
                {
                    MessageBox.Show("Success!!!");
                    loaddata("select warehouse.idwarehouse,namewarehouse,namecategory,sign from warehouse inner join categorywarehouse on warehouse.idcategory=categorywarehouse.idcategory");
                }
                else
                {
                    MessageBox.Show("Unsuccess!!!");
                }
            }
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtnamewarehouse.Text == "" || txtsign.Text.Length != 2 || connect.countdata("select count(idwarehouse) from warehouse where sign='"+txtsign.Text+"'")==1)
            {
                MessageBox.Show("Khong hop le !");
            }
            else
            {
                if (connect.exedata("insert into warehouse(idwarehouse,namewarehouse,idcategory,sign) values ('WH0"+(Convert.ToInt32(connect.countdata("select count(idwarehouse) from warehouse"))+1)+"','"+txtnamewarehouse.Text+"','"+cbcategory.SelectedValue.ToString()+"','"+txtsign.Text+"')") == true)
                {
                    MessageBox.Show("Success!!!");
                    loaddata("select warehouse.idwarehouse,namewarehouse,namecategory,sign from warehouse inner join categorywarehouse on warehouse.idcategory=categorywarehouse.idcategory");
                    txtidwarehouse.Text = "";
                    txtnamewarehouse.Text = "";
                    txtsign.Text = "";
                }
                else
                {
                    MessageBox.Show("Unsuccess!!!");
                }
            }
        }
    }
}
