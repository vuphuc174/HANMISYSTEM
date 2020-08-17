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
    public partial class checkinventory : Form
    {
        public checkinventory()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void checkinventory_Load(object sender, EventArgs e)
        {
            DataTable dtwarehouse = connect.readdata("select * from warehouse");
            cbwarehouse.DataSource = dtwarehouse;
            cbwarehouse.DisplayMember = "namewarehouse";
            cbwarehouse.ValueMember = "idwarehouse";
            cbwarehouse.SelectedValue = "WH002";
        }

        private void txtpartno_TextChanged(object sender, EventArgs e)
        {
            listsearch.Visible = true;
            listsearch.Items.Clear();
            DataTable dtsearch = connect.readdata("select top 10 partno from cargo where partno like '%" + txtpartno.Text + "%' or partname like '%" + txtpartno.Text + "%'");
            for (int i = 0; i < dtsearch.Rows.Count; i++)
            {
                listsearch.Items.Add(dtsearch.Rows[i]["partno"].ToString());
            }
        }

        private void listsearch_Click(object sender, EventArgs e)
        {
            if (listsearch.SelectedItem != null)
            {
                txtpartno.Text = listsearch.SelectedItem.ToString();
                DataTable dtpartname = connect.readdata("select partname from cargo where partno ='" + txtpartno.Text + "'");
                txtpartname.Text=dtpartname.Rows[0]["partname"].ToString();
                listsearch.Visible = false;
            }   
        }

        private void txtidpack_TextChanged(object sender, EventArgs e)
        {
            if(txtidpack.Text.Length>=14)
            {
                if(connect.countdata("select idpack from packinginfo where idpack='"+txtidpack.Text+"' and partno ='"+txtpartno.Text+"'")==0)
                {
                    MessageBox.Show("Mã thùng không hợp lệ");
                    txtidpack.Text = "";
                    txtidpack.Focus();
                }
                else
                {
                    DataTable dtcheckbox =connect.readdata("select quantity,position from packinginfo where idpack ='"+txtidpack.Text+"'");
                    dataGridView1.Rows.Add(txtpartno.Text,txtpartname.Text,txtidpack.Text,dtcheckbox.Rows[0]["position"].ToString(),dtcheckbox.Rows[0]["quantity"].ToString());
                    txtpartno.Text = "";
                    txtpartname.Text = "";
                    txtidpack.Text = "";
                }
            }
            
        }
        double sumqty;
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            sumqty = 0;
            txtsumqty.Text = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                sumqty += Convert.ToDouble(row.Cells["quantity"].Value.ToString());
            }
            txtsumqty.Text = sumqty.ToString();
        }

        private void btndeleteall_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        



        
    }
}
