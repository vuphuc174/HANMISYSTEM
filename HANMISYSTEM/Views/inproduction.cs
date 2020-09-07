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
    public partial class inproduction : Form
    {
        DateTimePicker dtp = new DateTimePicker();
        Rectangle _Rectangle;
        public inproduction()
        {
            InitializeComponent();
            dataGridView3.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp_TextChange);
        }
        private void dtp_TextChange(object sender, EventArgs e)
        {
            dataGridView3.CurrentCell.Value = dtp.Text.ToString();
        }
        Dbconnect connect = new Dbconnect();
        double qty;
        int lineqty;
        private void inproduction_Load(object sender, EventArgs e)
        {
            DataTable dtcheckpermission = connect.readdata("select t.idwarehouse,namewarehouse from tbl_user_permission t inner join warehouse w on t.idwarehouse=w.idwarehouse where username ='" + HANMISYSTEM.Properties.Settings.Default.username + "'");
            DataTable dt = connect.readdata("select PARTNO,PARTNAME,QTY,BOXQTY,BAGQTY,CARTQTY,TRAYQTY,ROLLQTY,CANQTY,PALLETQTY from view_stock_warehouse where idwarehouse ='WH002'");
            if (dt != null)
            {
                try
                {
                    datagridview4.DataSource = dt;
                }
                catch
                {

                }
            }

            if (dtcheckpermission.Rows.Count > 0)
            {
                cbwarehouse.DataSource = dtcheckpermission;
                cbwarehouse.ValueMember = "idwarehouse";
                cbwarehouse.DisplayMember = "namewarehouse";
                if (cbwarehouse.Text != "")
                {
                    DataTable dtposition = connect.readdata("select idposition,idwarehouse from position where idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "'");
                    if (dtposition.Rows.Count > 0)
                    {
                        cbposition.DataSource = dtposition;
                        cbposition.DisplayMember = "idposition";
                        cbposition.ValueMember = "idposition";
                    }

                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (datagridview4.Rows[e.RowIndex].Cells["partno"].Value.ToString() != "")
                {
                    txtpartno.Text = datagridview4.Rows[e.RowIndex].Cells["partno"].Value.ToString();
                    lbsearch.Visible = false;
                    if (connect.countdata("select count(partno) from packinginfo where partno ='" + txtpartno.Text + "' and idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "'") > 0)
                    {
                        DataTable dtposition = connect.readdata("select top 1 position ,SUM(quantity) as sl from packinginfo where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and partno='" + txtpartno.Text + "' group by position order by sl asc");
                        lbsuggest.Text = dtposition.Rows[0]["position"].ToString();
                        lbposition.Text = dtposition.Rows[0]["position"].ToString();
                        DataTable dtstock = connect.readdata("select p.Partno,Partname, sum(quantity) as Qty from packinginfo p inner join cargo c on p.partno=c.partno where idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "' and position ='" + lbsuggest.Text + "' group by p.partno,partname");
                        dataGridView2.DataSource = dtstock;
                    }
                    else
                    {
                        lbsuggest.Text = "Vui lòng chọn 1 vị trí mới";
                    }
                }
            }

        }



        private void txtpartno_Leave(object sender, EventArgs e)
        {

            if (connect.countdata("select count(partno) from packinginfo where partno ='" + txtpartno.Text + "' and idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "'") > 0)
            {
                DataTable dtposition = connect.readdata("select top 1 position ,SUM(quantity) as sl from packinginfo where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and partno='" + txtpartno.Text + "' group by position order by sl asc");
                lbsuggest.Text = dtposition.Rows[0]["position"].ToString();
            }
            else
            {
                lbsuggest.Text = "Vui lòng chọn 1 vị trí mới";
            }



        }
        bool chk;
        private void txtidpack_TextChanged(object sender, EventArgs e)
        {
            chk = true;
            txtqty.Text = "";
            if (txtidpack.Text.Length == 14)
            {
                if (connect.countdata("select count (*) from packingstandard where partno='" + txtpartno.Text + "' and  idpacking like '" + txtidpack.Text.Substring(0, 3) + "%'") == 0)
                {
                    MessageBox.Show("Phương thức đóng gói không tồn tại hoặc mã hàng không đúng");
                    txtidpack.Text = "";
                }
                else
                {
                    if (connect.countdata("select count(*) from packinginfo where idpack='" + txtidpack.Text + "'") != 0)
                    {
                        MessageBox.Show("Mã đóng gói đã tồn tại ,xin vui lòng chọn mã khác !!!");
                        txtidpack.Text = "";
                    }
                    else
                    {
                        DataTable dt = connect.readdata("select * from packingstandard where partno='" + txtpartno.Text + "' and idpacking like '" + txtidpack.Text.Substring(0, 3) + "%'");
                        txtqty.Text = dt.Rows[0]["quantity"].ToString();
                        qty = Convert.ToDouble(txtqty.Text);

                        //working behide here 
                        //tao hoa don
                        if (cbsupplier.Text == "")
                        {
                            MessageBox.Show("Xin vui lòng chon NCC");
                        }
                        else
                        {
                            if (txtinvoice.Text == "")
                            {
                                string str = mahoa1(cbsupplier.SelectedValue.ToString()) + mahoa1(cbwarehouse.SelectedValue.ToString());
                                int a = connect.countdata("select count (*) from slipout where idslipout like'" + str + "%' ") + 1;
                                txtinvoice.Text = str + DateTime.Now.ToString("yyyyMM") + a.ToString("0000");
                            }

                        }

                        //chuyen sang bang tam
                        Isnumber _isnumber = new Isnumber();
                        note = "";
                        if (cbsupplier.Text == "")
                        {
                            note += "Nhà cung cấp ,";
                        }
                        if (txtpartno.Text == "")
                        {
                            note += "Mã hàng ,";
                        }
                        if (txtidpack.Text == "" || txtidpack.Text.Length > 14)
                        {
                            note += "Mã thùng ,";
                        }
                        if (txtqty.Text == "" || _isnumber.IsNumber(txtqty.Text) == false)
                        {
                            note += "Số lượng ,";
                            txtqty.Text = qty.ToString();
                        }
                        else
                        {
                            if (Convert.ToDouble(txtqty.Text) > qty || Convert.ToDouble(txtqty.Text) <= 0 || txtqty.Text == "")
                            {
                                note += "Số lượng ,";
                                txtqty.Text = qty.ToString();
                            }
                        }

                        if (cbposition.Text == "")
                        {
                            note += "Vị trí ,";
                        }

                        // working on here
                        if (cbsupplier.SelectedValue.ToString() != cbwarehouse.SelectedValue.ToString())
                        {
                            if (note == "")
                            {
                                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                                {
                                    if (txtidpack.Text == dataGridView3.Rows[i].Cells["idpack"].Value.ToString())
                                    {
                                        chk = false;
                                    }
                                }
                                if (chk == true)
                                {

                                    if (connect.countdata("select count(idpack) from packinginfo where idpack ='" + txtidpack.Text + "'") == 0)
                                    {
                                        lineqty = 0;
                                        sumqty = 0;
                                        dataGridView3.Rows.Add(txtidpack.Text, "", txtpartno.Text, txtqty.Text, cbposition.SelectedValue.ToString());
                                        txtidpack.Text = "";
                                        txtqty.Text = "";
                                        for (int j = 0; j < dataGridView3.Rows.Count; j++)
                                        {

                                            sumqty = sumqty + Convert.ToDouble(dataGridView3.Rows[j].Cells["sl"].Value);
                                            lineqty = lineqty + 1;
                                        }
                                        txtlineqty.Text = lineqty.ToString();
                                        txtsumqty.Text = sumqty.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ma thung da ton tai");
                                        txtidpack.Text = "";
                                        txtidpack.Focus();
                                    }


                                }
                                else
                                {
                                    MessageBox.Show("Đã có trong danh sách !");
                                    txtidpack.Text = "";
                                    txtidpack.Focus();
                                }
                                lbnotify.Text = "...";
                            }
                            else
                            {
                                lbnotify.Text = "Các trường sau đây không hợp lệ : \n" + note;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Đảm bảo 2 kho là khác nhau");
                            txtidpack.Text = "";
                        }
                    }
                   
                }
            }
        }

        private void txtidpack_Leave(object sender, EventArgs e)
        {
            
        }
        private string r;
        private string mahoa1(string str)
        {

            DataTable dtsign = connect.readdata("select sign from warehouse where idwarehouse ='" + str + "'");
            try
            {
                r = dtsign.Rows[0]["sign"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return r;
        }

        string note;
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cbposition.Text == "")
            {
                MessageBox.Show("Chưa khởi tạo vị trí cho kho");
            }
            else
            {
                if (cbwarehouse.Text == cbsupplier.Text)
                {
                    MessageBox.Show("Vị trí nhập không hợp lệ");
                }
                else
                {
                    if (dataGridView3.Rows.Count <= 0)
                    {
                        MessageBox.Show("Chưa có hàng để nhập");
                    }
                    else
                    {
                        DataTable dtcategory = connect.readdata("select idcategory from warehouse where idwarehouse='" + cbsupplier.SelectedValue.ToString() + "'");
                        if (connect.countdata("select count(idslipout) from slipout where idslipout='" + txtinvoice.Text + "'") == 0)
                        {
                            if (connect.exedata("insert into slipout (idslipout,dateout,idwarehouse,idcustomer) values ('" + txtinvoice.Text + "',getdate(),'" + cbsupplier.SelectedValue.ToString() + "','" + cbwarehouse.SelectedValue.ToString() + "')"))
                            {
                                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                                {
                                    connect.exedata("insert into packinginfo (idpack,partno,quantity,packingdate,idwarehouse,position) values ('" + dataGridView3.Rows[i].Cells["idpack"].Value.ToString() + "','" + dataGridView3.Rows[i].Cells["partno1"].Value.ToString() + "','" + dataGridView3.Rows[i].Cells["sl"].Value.ToString() + "',getdate(),'" + cbwarehouse.SelectedValue.ToString() + "','" + dataGridView3.Rows[i].Cells["position"].Value.ToString() + "')");
                                    if (connect.countdata("Select count(idpack) from dateofmanufacture where idpack='" + dataGridView3.Rows[i].Cells["idpack"].Value.ToString() + "'") == 0)
                                    {
                                        connect.exedata("insert into dateofmanufacture (idpack,manufacturedate) values ('" + dataGridView3.Rows[i].Cells["idpack"].Value.ToString() + "','" + dataGridView3.Rows[i].Cells["dateofmanufacture"].Value.ToString() + "') ");
                                    }
                                    else
                                    {
                                        connect.exedata("update dateofmanufacture set manufacturedate ='" + dataGridView3.Rows[i].Cells["dateofmanufacture"].Value.ToString() + "' where idpack='" + dataGridView3.Rows[i].Cells["idpack"].Value.ToString() + "'");
                                    }
                                    connect.exedata("insert into slipoutinfo (idslipout,idpack,quantity,remark,carnumber,partno,packingdate) values ('" + txtinvoice.Text + "','" + dataGridView3.Rows[i].Cells["idpack"].Value.ToString() + "','" + dataGridView3.Rows[i].Cells["sl"].Value.ToString() + "','','','" + dataGridView3.Rows[i].Cells["partno1"].Value.ToString() + "',getdate())");
                                }
                                //if (dtcategory.Rows[0]["idcategory"].ToString()=="W2")
                                //{
                                //    for (int i = 0; i < dataGridView3.Rows.Count; i++)
                                //    {
                                //        DataTable dtbom = connect.readdata("select * from bom where partno ='" + dataGridView3.Rows[i].Cells["partno1"].Value + "'");
                                //        if(dtbom.Rows.Count!=0)
                                //        {
                                //            for(int j=0;j<dtbom.Rows.Count;j++)
                                //            {
                                //                if (connect.countdata("select count (partno) from stock where partno ='" + dtbom.Rows[j]["rawpartno"].ToString() + "' and idwarehouse='"+cbsupplier.SelectedValue.ToString()+"'") == 0)
                                //                {
                                //                    connect.exedata("insert into stock(idwarehouse,partno,quantity) valuse ('" + cbsupplier.SelectedValue.ToString() + "','" + dtbom.Rows[j]["rawpartno"].ToString() + "','" + (0 - (Convert.ToDouble(dataGridView3.Rows[i].Cells["sl"].Value) * Convert.ToDouble(dtbom.Rows[j]["quantity"].ToString()))) + "')");
                                //                }
                                //                else
                                //                {
                                //                    connect.exedata("update stock set quantity=quantity-'" + (Convert.ToDouble(dataGridView3.Rows[i].Cells["sl"].Value) * Convert.ToDouble(dtbom.Rows[j]["quantity"].ToString())) + "' where idwarehouse='" + cbsupplier.SelectedValue.ToString() + "' and partno ='" + dtbom.Rows[j]["rawpartno"].ToString() + "'");
                                //                }
                                //            }
                                //        }

                                //    }
                                //}
                                dtp.Visible = false;
                                MessageBox.Show("Thành công ,Chuyển tới trang in ...please wait");
                                Print_Layout fr_print_layout = new Print_Layout();
                                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                                {
                                    fr_print_layout.dataGridView1.Rows.Add(i + 1, dataGridView3.Rows[i].Cells["position"].Value.ToString(), dataGridView3.Rows[i].Cells["idpack"].Value.ToString(), dataGridView3.Rows[i].Cells["partno1"].Value.ToString(), dataGridView3.Rows[i].Cells["sl"].Value.ToString());
                                }
                                fr_print_layout.dataGridView1.Columns["location"].SortMode = DataGridViewColumnSortMode.Automatic;
                                fr_print_layout.Show();
                                Printing_Slipout fr = new Printing_Slipout();
                                fr.lbtieude.Text = "PHIẾU NHẬP KHO";
                                fr.label10.Text = "Lý do nhập kho";
                                fr.lbday.Text = DateTime.Now.ToString("dd");
                                fr.lbmonth.Text = DateTime.Now.ToString("MM");
                                fr.lbyear.Text = DateTime.Now.ToString("yyyy");
                                fr.lbinvoice.Text = txtinvoice.Text;
                                fr.lbewarehouse.Text = cbsupplier.Text;
                                fr.lbiwarehouse.Text = "Material warehouse";
                                fr.lbcarnumber.Text = "";
                                fr.lbreason.Text = "";
                                DataTable dt1 = connect.readdata("select cargo.partno,cargo.partname,SUM(quantity) as qty from cargo inner join slipoutinfo on cargo.partno=slipoutinfo.partno  where idslipout='" + txtinvoice.Text + "' group by cargo.partno,cargo.partname");
                                fr.dataGridView1.DataSource = dt1;
                                fr.Show();

                                txtinvoice.Text = "";
                                txtsumqty.Text = "";
                                //txtreason.Text = "";
                                //txtcarnumber.Text = "";
                                dataGridView3.Rows.Clear();
                                DataTable dt = connect.readdata("select PARTNO,PARTNAME,QTY,BOXQTY,BAGQTY,CARTQTY,TRAYQTY,ROLLQTY,CANQTY,PALLETQTY from view_stock_warehouse where idwarehouse ='WH002' ");
                                if (dt != null)
                                {
                                    datagridview4.DataSource = dt;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nhập hàng không thành công vui lòng thử lại sau ,hoặc báo cho admin");
                            }

                        }
                        else
                        {
                            string str = mahoa1(cbsupplier.SelectedValue.ToString()) + mahoa1(cbwarehouse.SelectedValue.ToString());
                            int a = connect.countdata("select count (*) from slipout where idslipout like'" + str + "%' ") + 1;
                            txtinvoice.Text = str + DateTime.Now.ToString("yyyyMM") + a.ToString("0000");
                            connect.exedata("insert into slipout (idslipout,dateout,idwarehouse,idcustomer) values ('" + txtinvoice.Text + "','" + DateTime.Now.ToString() + "','" + cbsupplier.SelectedValue.ToString() + "','" + cbwarehouse.SelectedValue.ToString() + "')");
                            for (int i = 0; i < dataGridView3.Rows.Count; i++)
                            {
                                connect.exedata("insert into packinginfo (idpack,partno,quantity,packingdate,idwarehouse,position) values ('" + dataGridView3.Rows[i].Cells["idpack"].Value.ToString() + "','" + dataGridView3.Rows[i].Cells["partno1"].Value.ToString() + "','" + dataGridView3.Rows[i].Cells["sl"].Value.ToString() + "','" + DateTime.Now.ToString() + "','" + cbwarehouse.SelectedValue.ToString() + "','" + dataGridView3.Rows[i].Cells["position"].Value.ToString() + "')");
                                connect.exedata("insert into slipoutinfo (idslipout,idpack,quantity,remark,carnumber,partno,packingdate) values ('" + txtinvoice.Text + "','" + dataGridView3.Rows[i].Cells["idpack"].Value.ToString() + "','" + dataGridView3.Rows[i].Cells["sl"].Value.ToString() + "','','','" + dataGridView3.Rows[i].Cells["partno1"].Value.ToString() + "','" + DateTime.Now.ToString() + "')");
                            }
                            MessageBox.Show("Thành công ,Chuyển tới trang in ...please wait");
                            Print_Layout fr_print_layout = new Print_Layout();
                            for (int i = 0; i < dataGridView3.Rows.Count; i++)
                            {
                                fr_print_layout.dataGridView1.Rows.Add(i + 1, dataGridView3.Rows[i].Cells["position"].Value.ToString(), dataGridView3.Rows[i].Cells["idpack"].Value.ToString(), dataGridView3.Rows[i].Cells["partno1"].Value.ToString(), dataGridView3.Rows[i].Cells["sl"].Value.ToString());
                            }
                            fr_print_layout.dataGridView1.Columns["location"].SortMode = DataGridViewColumnSortMode.Automatic;
                            fr_print_layout.Show();
                            Printing_Slipout fr = new Printing_Slipout();
                            fr.lbtieude.Text = "PHIẾU NHẬP KHO";
                            fr.label10.Text = "Lý do nhập kho";
                            fr.lbday.Text = DateTime.Now.ToString("dd");
                            fr.lbmonth.Text = DateTime.Now.ToString("MM");
                            fr.lbyear.Text = DateTime.Now.ToString("yyyy");
                            fr.lbinvoice.Text = txtinvoice.Text;
                            fr.lbewarehouse.Text = cbsupplier.Text;
                            fr.lbiwarehouse.Text = "Material warehouse";
                            fr.lbcarnumber.Text = "";
                            fr.lbreason.Text = "";
                            DataTable dt1 = connect.readdata("select cargo.partno,cargo.partname,SUM(quantity) as qty from cargo inner join slipoutinfo on cargo.partno=slipoutinfo.partno  where idslipout='" + txtinvoice.Text + "' group by cargo.partno,cargo.partname");
                            fr.dataGridView1.DataSource = dt1;
                            fr.Show();

                            txtinvoice.Text = "";
                            txtsumqty.Text = "";
                            //txtreason.Text = "";
                            //txtcarnumber.Text = "";
                            dataGridView3.Rows.Clear();
                            DataTable dt = connect.readdata("select PARTNO,PARTNAME,QTY,BOXQTY,BAGQTY,CARTQTY,TRAYQTY,ROLLQTY,CANQTY,PALLETQTY from view_stock_warehouse where idwarehouse ='WH002' ");
                            if (dt != null)
                            {
                                datagridview4.DataSource = dt;
                            }

                        }

                    }

                }

            }

        }


        private void txtqty_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtqty_Leave(object sender, EventArgs e)
        {

        }

        private void txtpartno_TextChanged(object sender, EventArgs e)
        {
            lbsearch.Visible = true;
            txtpartname.Text = "";
            lbsearch.Items.Clear();
            DataTable dtsearch = connect.readdata("select top 10 partno from cargo where partno like '%" + txtpartno.Text + "%' or partname like '%" + txtpartno.Text + "%'");
            for (int i = 0; i < dtsearch.Rows.Count; i++)
            {
                lbsearch.Items.Add(dtsearch.Rows[i]["partno"].ToString());
            }
        }

        private void lbsuggest_Click(object sender, EventArgs e)
        {
            if (lbsuggest.Text.Length >= 4 && lbsuggest.Text.Length <= 6)
            {
                cbposition.Text = lbsuggest.Text;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            if (txtpartno.Text != "")
            {
                if (connect.countdata("select count(partno) from packinginfo where partno ='" + txtpartno.Text + "' and idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "'") > 0)
                {
                    DataTable dtposition = connect.readdata("select top 1 position ,SUM(quantity) as sl from packinginfo where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and partno='" + txtpartno.Text + "' group by position order by sl asc");
                    lbsuggest.Text = dtposition.Rows[0]["position"].ToString();
                    lbposition.Text = dtposition.Rows[0]["position"].ToString();
                    DataTable dtstock = connect.readdata("select p.Partno,Partname, sum(quantity) as Qty from packinginfo p inner join cargo c on p.partno=c.partno where idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "' and position ='" + lbsuggest.Text + "' group by p.partno,partname");
                    dataGridView2.DataSource = dtstock;
                }
                else
                {
                    lbsuggest.Text = "Vui lòng chọn 1 vị trí mới";
                }
            }
        }





        private void cbsupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtinvoice.Text = "";
            lbnotify.Text = "...";
            txtidpack.Text = "";
        }
        double sumqty;
        private void btnremove_Click(object sender, EventArgs e)
        {
            if (chkcheckall.Checked == false)
            {
                foreach (DataGridViewRow item in this.dataGridView3.SelectedRows)
                {
                    dataGridView3.Rows.RemoveAt(item.Index);
                }
                sumqty = 0;
                lineqty = 0;
                //txtidpack.Text = "";
                for (int j = 0; j < dataGridView3.Rows.Count; j++)
                {
                    sumqty = sumqty + Convert.ToDouble(dataGridView3.Rows[j].Cells["sl"].Value);
                    lineqty = lineqty + 1;
                }
                txtlineqty.Text = lineqty.ToString();
                txtsumqty.Text = sumqty.ToString();

            }
            else
            {
                dataGridView3.Rows.Clear();
                chkcheckall.Checked = false;
                sumqty = 0;
                lineqty = 0;
                for (int j = 0; j < dataGridView3.Rows.Count; j++)
                {
                    lineqty = lineqty + 1;
                    sumqty = sumqty + Convert.ToDouble(dataGridView3.Rows[j].Cells["sl"].Value);
                }
                txtlineqty.Text = lineqty.ToString();
                txtsumqty.Text = sumqty.ToString();
            }

        }
        double x;
        private void dataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dtcheckpacking = connect.readdata("select idpacking,partno,quantity from packingstandard where partno ='" + dataGridView3.Rows[e.RowIndex].Cells["partno1"].Value.ToString() + "' and  idpacking ='" + dataGridView3.Rows[e.RowIndex].Cells["idpack"].Value.ToString().Substring(0, 3) + "'");
            x = Convert.ToDouble(dtcheckpacking.Rows[0]["quantity"].ToString());
            if (dataGridView3.Rows[e.RowIndex].Cells["sl"].Value == null || dataGridView3.Rows[e.RowIndex].Cells["sl"].Value.ToString() == "" || Convert.ToDouble(dataGridView3.Rows[e.RowIndex].Cells["sl"].Value) <= 0 || Convert.ToDouble(dataGridView3.Rows[e.RowIndex].Cells["sl"].Value) > x)
            {
                MessageBox.Show("Không hợp lệ !");
                dataGridView3.Rows[e.RowIndex].Cells["sl"].Value = x;
                sumqty = 0;
                for (int j = 0; j < dataGridView3.Rows.Count; j++)
                {

                    sumqty = sumqty + Convert.ToDouble(dataGridView3.Rows[j].Cells["sl"].Value);
                }
                txtsumqty.Text = sumqty.ToString();
            }
            else
            {
                sumqty = 0;
                for (int j = 0; j < dataGridView3.Rows.Count; j++)
                {

                    sumqty = sumqty + Convert.ToDouble(dataGridView3.Rows[j].Cells["sl"].Value);
                }
                txtsumqty.Text = sumqty.ToString();
            }
        }

        private void lbsearch_Click(object sender, EventArgs e)
        {
            if (lbsearch.SelectedItem != null)
            {
                txtpartno.Text = lbsearch.SelectedItem.ToString();
                DataTable dtpartname = connect.readdata("select partname from cargo where partno='" + txtpartno.Text + "'");
                if (dtpartname.Rows.Count > 0)
                {
                    txtpartname.Text = dtpartname.Rows[0]["partname"].ToString();
                }
                lbsearch.Visible = false;
            }
        }

        private void cbwarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbwarehouse.SelectedIndex != -1)
            {
                DataTable dtposition = connect.readdata("select idposition from position where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'");
                cbposition.DataSource = dtposition;
                cbposition.ValueMember = "idposition";
                cbposition.DisplayMember = "idposition";
            }
        }

        private void cbsupplier_Click(object sender, EventArgs e)
        {
            DataTable dt1 = connect.readdata("select t.idwarehouse,namewarehouse from tbl_user_supplier_permission t inner join warehouse w on t.idwarehouse=w.idwarehouse where t.idwarehouse <> '" + cbwarehouse.SelectedValue + "' and username ='" + HANMISYSTEM.Properties.Settings.Default.username + "'");
            try
            {
                cbsupplier.DataSource = dt1;
                cbsupplier.ValueMember = "idwarehouse";
                cbsupplier.DisplayMember = "namewarehouse";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 &&e.ColumnIndex!=-1)
            {
                switch (dataGridView3.Columns[e.ColumnIndex].Name)
                {
                    case "Dateofmanufacture":

                        _Rectangle = dataGridView3.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                        dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                        dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                        dtp.Visible = true;
                        dataGridView3.Rows[e.RowIndex].Cells["Dateofmanufacture"].Value = dtp.Text.ToString();
                        break;

                }
            }

        }

        private void dataGridView3_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            // dtp.Visible = false;
        }

        private void dataGridView3_Scroll(object sender, ScrollEventArgs e)
        {
            // dtp.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbsupplier.Text == "")
            {
                MessageBox.Show("Xin vui lòng chon NCC");
            }
            else
            {

                string str = mahoa1(cbsupplier.SelectedValue.ToString()) + mahoa1(cbwarehouse.SelectedValue.ToString());
                int a = connect.countdata("select count (*) from slipout where idslipout like'" + str + "%' ") + 1;
                txtinvoice.Text = str + DateTime.Now.ToString("yyyyMM") + a.ToString("0000");


            }
        }
    }

}
