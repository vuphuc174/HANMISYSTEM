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

namespace HANMISYSTEM.Views
{
    public partial class ReleaseAndReceiveHistory : Form
    {
        public ReleaseAndReceiveHistory()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private const int pagesize = 20;
        public int pagenumber = 1;
        string sql;
        private void cbwarehouse_Click(object sender, EventArgs e)
        {
            DataTable dt = connect.readdata("select idwarehouse,namewarehouse from warehouse");
            if (dt != null)
            {
                cbwarehouse.DataSource = dt;
                cbwarehouse.DisplayMember = "namewarehouse";
                cbwarehouse.ValueMember = "idwarehouse";
            }
        }
        private void loaddata(string sql)
        {
            DataTable dt = connect.readdata(sql);
            try
            {
                dataGridView1.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.ToString());
            }
        }
        private void cbwarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbwarehouse.Text != "")
            {
                panel1.Visible = true;
                cbfilter.Enabled = true;
                txtidpack.Text = "";
                txtpagenumber.Text = "1";
                sql = "select a.* from (select ROW_NUMBER() over (order by dateout desc) as r, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where s.idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "') a where r >=1 and r<=20 order by r asc";
                loaddata(sql);
                cbfilter.SelectedIndex = 1;
            }
        }

        private void ReleaseAndReceiveHistory_Load(object sender, EventArgs e)
        {

        }
        bool checkSelect;
        string sqlstr;
        string encrypt;
        private void btnprint_Click(object sender, EventArgs e)
        {
            sqlstr = "";
            checkSelect = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Index!=-1)
                {
                    if (Convert.ToBoolean(row.Cells["select"].Value) == true)
                    {
                        checkSelect = true;
                        break;
                    }

                }
               
            }
            if (checkSelect == false)
            {
                MessageBox.Show("Chưa có mã hoá đơn nào được chọn !");
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["select"];
                    if (Convert.ToBoolean(cell.Value))
                    {
                        if (sqlstr == "")
                        {
                            sqlstr = " where idslipout='" + row.Cells["idinvoice"].Value.ToString() + "'";
                        }
                        else
                        {
                            sqlstr += " or idslipout='" + row.Cells["idinvoice"].Value.ToString() + "'";
                        }
                    }
                }
                Printing_Slipout fr = new Printing_Slipout();
                fr.lbday.Text = DateTime.Now.ToString("dd");
                fr.lbmonth.Text = DateTime.Now.ToString("MM");
                fr.lbyear.Text = DateTime.Now.ToString("yyyy");
                if (cbfilter.Text == "IN")
                {
                    fr.lbiwarehouse.Text = cbwarehouse.Text;
                }
                else
                {
                    fr.lbewarehouse.Text = cbwarehouse.Text;
                }
                //fr.lbewarehouse.Text = cbwarehouse.Text;
                //fr.lbiwarehouse.Text = cbiwarehouse.Text;
                DataTable dt1 = connect.readdata("select ROW_NUMBER() over(order by s.partno asc) as stt,s.partno,c.partname,u.nameunit as dvt,SUM(quantity) as qty from slipoutinfo s inner join cargo c on s.partno=c.partno inner join unit u on u.idunit=c.idunit " + sqlstr + " group by s.partno,c.partname,u.nameunit");
                fr.dataGridView1.DataSource = dt1;
                fr.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.ColumnIndex==0)
            //{
            //    if(Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["select"].Value))
            //    {
            //        if (string.IsNullOrEmpty(encrypt))
            //        {
            //            encrypt = dataGridView1.Rows[e.RowIndex].Cells["idinvoice"].Value.ToString().Substring(0, 4).Substring(2, 2);
            //        }
            //        else
            //        {
            //            var temp= dataGridView1.Rows[e.RowIndex].Cells["idinvoice"].Value.ToString().Substring(0, 4).Substring(2, 2);
            //            if(temp==encrypt)
            //            {
            //                dataGridView1.Rows[e.RowIndex].Cells["select"].Value = true;
            //            }
            //            else
            //            {
            //                dataGridView1.Rows[e.RowIndex].Cells["select"].Value = false;
            //            }
            //        }
            //    }
            //}
        }

        private void cbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbwarehouse.SelectedIndex == -1 || cbwarehouse.SelectedItem == null)
            {
            }
            else
            {
                txtpagenumber.Text = "1";
                txtidpack.Text = "";
                if (cbfilter.Text == "IN")
                {

                    sql = "select a.* from (select ROW_NUMBER() over (order by dateout desc) as r, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where s.idcustomer='" + cbwarehouse.SelectedValue.ToString() + "') a where r >=1 and r<=20 order by r asc";
                    loaddata(sql);
                }
                else
                {

                    sql = "select a.* from (select ROW_NUMBER() over (order by dateout desc) as r, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where s.idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "') a where r >=1 and r<=20 order by r asc";
                    loaddata(sql);
                }
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            pagenumber = Convert.ToInt32(txtpagenumber.Text) + 1;
            txtpagenumber.Text = pagenumber.ToString();
            txtidpack.Text = "";
            switch (cbfilter.Text)
            {
                case "IN":
                    sql = "select a.* from (select ROW_NUMBER() over (order by dateout desc) as r, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where s.idcustomer='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) order by r asc";
                    break;
                case "OUT":
                    sql = "select a.* from (select ROW_NUMBER() over (order by dateout desc) as r, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where s.idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) order by r asc";
                    break;
            }
            loaddata(sql);
        }
        string cmd;
        private void btnend_Click(object sender, EventArgs e)
        {
            txtidpack.Text = "";
            switch (cbfilter.Text)
            {
                case "IN":
                    cmd = "select a.* from (select ROW_NUMBER() over (order by dateout desc) as r, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where s.idcustomer='" + cbwarehouse.SelectedValue.ToString() + "') a order by r desc";
                    break;
                case "OUT":
                    cmd = "select a.* from (select ROW_NUMBER() over (order by dateout desc) as r, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where s.idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "') a order by r desc";
                    break;
            }
            DataTable dtcheckmaxpage = connect.readdata(cmd);
            if (dtcheckmaxpage.Rows.Count > 0)
            {
                if (Convert.ToDouble(Convert.ToInt32(dtcheckmaxpage.Rows[0]["r"].ToString()) % pagesize) > 0)
                {
                    pagenumber = Convert.ToInt32(dtcheckmaxpage.Rows[0]["r"].ToString()) / pagesize + 1;
                }
                else
                {
                    pagenumber = Convert.ToInt32(dtcheckmaxpage.Rows[0]["r"].ToString()) / pagesize;
                }
            }
            txtpagenumber.Text = pagenumber.ToString();

            switch (cbfilter.Text)
            {

                case "IN":
                    sql = "select a.* from (select ROW_NUMBER() over (order by dateout desc) as r, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where s.idcustomer='" + cbwarehouse.SelectedValue.ToString() + "') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) order by r asc";
                    break;
                case "OUT":
                    sql = "select a.* from (select ROW_NUMBER() over (order by dateout desc) as r, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where s.idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) order by r asc";
                    break;
            }


            loaddata(sql);
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            pagenumber = Convert.ToInt32(txtpagenumber.Text) - 1;
            txtpagenumber.Text = pagenumber.ToString();

            switch (cbfilter.Text)
            {
                case "IN":
                    sql = "select a.* from (select ROW_NUMBER() over (order by dateout desc) as r, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where s.idcustomer='" + cbwarehouse.SelectedValue.ToString() + "') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) order by r asc";
                    break;
                case "OUT":
                    sql = "select a.* from (select ROW_NUMBER() over (order by dateout desc) as r, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where s.idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) order by r asc";
                    break;
            }


            loaddata(sql);
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            pagenumber = 1;
            txtpagenumber.Text = pagenumber.ToString();

            switch (cbfilter.Text)
            {
                case "IN":
                    sql = "select a.* from (select ROW_NUMBER() over (order by dateout desc) as r, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where s.idcustomer='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<=(" + pagenumber + " * " + pagesize + "+1) order by r asc";
                    loaddata(sql);
                    break;
                case "OUT":
                    sql = "select a.* from (select ROW_NUMBER() over (order by dateout desc) as r, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where s.idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<=(" + pagenumber + " * " + pagesize + "+1) order by r asc";
                    loaddata(sql);
                    break;

            }


        }
        Isnumber _isnumber = new Isnumber();
        private void txtpagenumber_TextChanged(object sender, EventArgs e)
        {
            if (_isnumber.IsNumber(txtpagenumber.Text) == true)
            {

                if (Convert.ToInt32(txtpagenumber.Text) <= 0)
                {
                    txtpagenumber.Text = "1";
                    switch (cbfilter.Text)
                    {
                        case "IN":
                            sql = "select a.* from (select ROW_NUMBER() over (order by dateout desc) as r, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where s.idcustomer='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<=(" + pagenumber + " * " + pagesize + "+1) order by r asc";
                            loaddata(sql);
                            break;
                        case "OUT":
                            sql = "select a.* from (select ROW_NUMBER() over (order by dateout desc) as r, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where s.idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<=(" + pagenumber + " * " + pagesize + "+1) order by r asc";
                            loaddata(sql);
                            break;

                    }
                }
            }
        }

        private void txtidpack_TextChanged(object sender, EventArgs e)
        {
            txtpagenumber.Text = "1";

            switch (cbfilter.Text)
            {

                case "IN":
                    sql = "select a.* from (select ROW_NUMBER() over (order by dateout desc) as r, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where s.idcustomer='" + cbwarehouse.SelectedValue.ToString() + "' and s.idslipout like '%"+txtidpack.Text+"%') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<=(" + pagenumber + " * " + pagesize + "+1) order by r asc";
                    loaddata(sql);
                    break;
                case "OUT":
                    sql = "select a.* from (select ROW_NUMBER() over (order by dateout desc) as r, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where s.idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "' and s.idslipout like '%" + txtidpack.Text + "%') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<=(" + pagenumber + " * " + pagesize + "+1) order by r asc";
                    loaddata(sql);
                    break;

            }

            loaddata(sql);
        }
    }
}
