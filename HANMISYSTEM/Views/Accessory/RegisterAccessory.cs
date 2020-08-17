using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Accessory
{
    public partial class RegisterAccessory : Form
    {
        public RegisterAccessory()
        {
            InitializeComponent();
        }
        Dbconnect dbconnect = new Dbconnect();
        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            if (txtModel.Text.Length > 0)
            {
                lbSearch.Items.Clear();
                lbSearch.Visible = true;
                DataTable dtProducts = dbconnect.readdata("select top 10 partno from cargo where partno like '%" + txtModel.Text + "%'");
                if (dtProducts.Rows.Count > 0)
                {
                    for (int i = 0; i < dtProducts.Rows.Count; i++)
                    {
                        lbSearch.Items.Add(dtProducts.Rows[i]["partno"]);
                    }
                }
            }
        }

        private void lbSearch_Click(object sender, EventArgs e)
        {
            txtModel.Text = lbSearch.SelectedItem.ToString();
            string sql = "select Accessory.Accessory,cargo.partname from Accessory inner join cargo on Accessory.Accessory=cargo.partno where Accessory.PartNo='" + txtModel.Text + "'";
            loaddata(sql);
            lbSearch.Visible = false;
        }
        public void loaddata(string str)
        {
            DataTable dt = dbconnect.readdata(str);
            dataGridView1.DataSource = dt;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dbconnect.countdata("select count(partno) from cargo where partno ='" + txtModel.Text + "'") != 0 && dbconnect.countdata("select count(partno) from cargo where partno ='" + txtAccessory.Text + "'") != 0 && txtAccessory.Text != txtModel.Text && dbconnect.countdata("select count(PartNo) from Accessory where PartNo='" + txtModel.Text + "' and Accessory='" + txtAccessory.Text + "'") == 0)
            {
                dbconnect.exedata("insert into Accessory(PartNo,Accessory) values('" + txtModel.Text + "','" + txtAccessory.Text + "')");
                MessageBox.Show("Thành công");
                string sql = "select Accessory.Accessory,cargo.partname from Accessory inner join cargo on Accessory.Accessory=cargo.partno where Accessory.PartNo='" + txtModel.Text + "'";
                loaddata(sql);
            }
            else
            {
                MessageBox.Show("Check lại thông tin");
            }
        }

        private void txtAccessory_TextChanged(object sender, EventArgs e)
        {
            if (txtModel.Text.Length > 0)
            {
                listBox1.Items.Clear();
                listBox1.Visible = true;
                DataTable dtProducts = dbconnect.readdata("select top 10 partno from cargo where partno like '%" + txtAccessory.Text + "%'");
                if (dtProducts.Rows.Count > 0)
                {
                    for (int i = 0; i < dtProducts.Rows.Count; i++)
                    {
                        listBox1.Items.Add(dtProducts.Rows[i]["partno"]);
                    }
                }
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            txtAccessory.Text = listBox1.SelectedItem.ToString();
            listBox1.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you want to delete this one?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    dbconnect.exedata("delete from Accessory where PartNo='" + txtModel.Text + "' and Accessory='" + dataGridView1.Rows[e.RowIndex].Cells["Accessory"].Value.ToString() + "'");
                    string sql = "select Accessory.Accessory,cargo.partname from Accessory inner join cargo on Accessory.Accessory=cargo.partno where Accessory.PartNo='" + txtModel.Text + "'";
                    loaddata(sql);
                }

            }
        }
    }
}
