using HANMISYSTEM.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM
{
    public partial class NG_Singlepart : Form
    {
        public NG_Singlepart()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void cbwarehouse_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            

        }
        private void LoadDataToCollection()
        {
            AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();
            SqlDataReader reader = connect.readerdata("select partno from cargo");
            if (reader != null)
            {
                while (reader.Read())
                {
                    auto2.Add(reader["partno"].ToString());
                }
            }

            txtpartno.AutoCompleteMode = AutoCompleteMode.Append;
            txtpartno.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtpartno.AutoCompleteCustomSource = auto2;

            txtpartno.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtpartno.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtpartno.AutoCompleteCustomSource = auto2;


        }

        private void NG_Singlepart_Load(object sender, EventArgs e)
        {
            LoadDataToCollection();
            DataTable dt = connect.readdata("select * from warehouse");
            cbwarehouse.DataSource = dt;
            cbwarehouse.ValueMember = "idwarehouse";
            cbwarehouse.DisplayMember = "namewarehouse";
            cbwarehouse.SelectedIndex = 1;

            DataTable dt1 = connect.readdata("select cargo.partno,partname,sum(quantity) as qty from tbl_nghistory inner join cargo on tbl_nghistory.partno=cargo.partno where cargo.idwarehouse='" + cbwarehouse.SelectedValue + "' group by cargo.partno,partname");
            if (dt1.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt1;
            }
        }

        private void cbwarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable DT = (DataTable)dataGridView1.DataSource;
            if (DT != null)
                DT.Clear();
            DataTable dt = connect.readdata("select cargo.partno,partname,sum(quantity) as qty from tbl_nghistory inner join cargo on tbl_nghistory.partno=cargo.partno where cargo.idwarehouse='" + cbwarehouse.SelectedValue + "' group by cargo.partno,partname");
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }

        }

        private void txtpartno_Leave(object sender, EventArgs e)
        {
            
        }
        Isnumber _isnumber = new Isnumber();
        private void txtqty_Validated(object sender, EventArgs e)
        {
            if(_isnumber.IsNumber(txtqty.Text)==false)
            {
                MessageBox.Show("Invalid");
                txtqty.Text = "";
                txtqty.Focus();
            }
        }

        private void txtpartno_Validated(object sender, EventArgs e)
        {
            DataTable dt = connect.readdata("select partname from cargo where partno='" + txtpartno.Text + "'");
            if (dt.Rows.Count > 0)
            {
                txtpartname.Text = dt.Rows[0]["partname"].ToString();
                txtqty.Focus();
            }
            else
            {
                MessageBox.Show("Partno doesnt exist");
                txtpartno.Text = "";
                //txtpartno.Focus();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtpartname.Text==""  || txtqty.Text == "")
            {
                MessageBox.Show("Do not empty field ");
                
            }
            else
            {
                if (connect.exedata("insert into tbl_nghistory(partno,quantity,idwarehouse,productiontime,defect) values ('" + txtpartno.Text + "','" + txtqty.Text + "','" + cbwarehouse.SelectedValue + "','" + DateTime.Now.ToString() + "','" + txtdefect.Text + "')"))
                {
                    DataTable dtpn=connect.readdata("select idcategory from cargo where partno='"+txtpartno.Text+"'");
                    if(dtpn.Rows.Count>0 && cbwarehouse.SelectedValue.ToString() != "WH002" )
                    {
                        if(dtpn.Rows[0]["idcategory"].ToString()=="3")
                        {
                            DataTable dtng = connect.readdata("select * from bom where partno='"+txtpartno.Text+"'");
                            if(dtng.Rows.Count>0)
                            {
                                for(int i=0;i<dtng.Rows.Count;i++)
                                {
                                    connect.exedata("insert into tbl_nghistory (partno,quantity,idwarehouse,productiontime) values ('"+dtng.Rows[i]["rawpartno"].ToString()+"','"+(Convert.ToDouble(dtng.Rows[i]["quantity"].ToString())*Convert.ToInt32(txtqty.Text))+"','"+cbwarehouse.SelectedValue+"','"+DateTime.Now.ToString()+"')");
                                }
                            }
                        }
                    }
                    MessageBox.Show("Success");
                    txtpartno.Text = "";
                    txtdefect.Text = "";
                    DataTable dt1 = connect.readdata("select cargo.partno,partname,sum(quantity) as qty from tbl_nghistory inner join cargo on tbl_nghistory.partno=cargo.partno where idwarehouse='" + cbwarehouse.SelectedValue + "' group by cargo.partno,partname");
                    if (dt1.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt1;
                    }
                }
                else
                {
                    MessageBox.Show("fail!");
                }
            }
        }

        private void txtpartno_TextChanged(object sender, EventArgs e)
        {
            txtqty.Text = "";
            txtpartname.Text = "";
        }
    }
}
