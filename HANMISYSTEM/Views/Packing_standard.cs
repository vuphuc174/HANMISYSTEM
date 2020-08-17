using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM
{
    public partial class Packing_standard : Form
    {
        public Packing_standard()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void loaddata(string cmd)
        {
            DataTable dt = connect.readdata(cmd);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }

        }
        private void Packing_standard_Load(object sender, EventArgs e)
        {
            loaddata("select partno,partname,box,bag,crt,tra,rol,pal,can from view_packing_standard");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtboxqty.Text = "";
            txtbagqty.Text = "";
            txtcrtqty.Text = "";
            txttrayqty.Text = "";
            txtrollqty.Text = "";
            txtpalletqty.Text = "";
            txtcanqty.Text = "";

            

            txtboxqty.Enabled=false;
            txtbagqty.Enabled = false;
            txtcrtqty.Enabled = false;
            txttrayqty.Enabled = false;
            txtrollqty.Enabled = false;
            txtpalletqty.Enabled = false;
            txtcanqty.Enabled = false;

            if(e.RowIndex !=-1)
            {
                txtpartno.Text=dataGridView1.Rows[e.RowIndex].Cells["partno"].Value.ToString();
                txtpartname.Text = dataGridView1.Rows[e.RowIndex].Cells["partname"].Value.ToString();
                if(dataGridView1.Rows[e.RowIndex].Cells["BOX"].Value.ToString()=="1")
                {
                    chkbox.Checked = true;
                    txtboxqty.Enabled = true;
                    DataTable dtboxqty = connect.readdata("select quantity from packingstandard where partno='"+dataGridView1.Rows[e.RowIndex].Cells["partno"].Value+"' and idpacking='BOX'");
                    txtboxqty.Text=dtboxqty.Rows[0]["quantity"].ToString();
                }
                else
                {
                    chkbox.Checked = false;
                    txtboxqty.Enabled = false;
                }
                if (dataGridView1.Rows[e.RowIndex].Cells["BAG"].Value.ToString() == "1")
                {
                    chkbag.Checked = true;
                    txtbagqty.Enabled = true;
                    DataTable dtboxqty = connect.readdata("select quantity from packingstandard where partno='" + dataGridView1.Rows[e.RowIndex].Cells["partno"].Value + "' and idpacking='BAG'");
                    txtbagqty.Text = dtboxqty.Rows[0]["quantity"].ToString();
                }
                else
                {
                    chkbag.Checked = false;
                    txtbagqty.Enabled = false;
                }
                if (dataGridView1.Rows[e.RowIndex].Cells["CRT"].Value.ToString() == "1")
                {
                    chkcrt.Checked = true;
                    txtcrtqty.Enabled = true;
                    DataTable dtboxqty = connect.readdata("select quantity from packingstandard where partno='" + dataGridView1.Rows[e.RowIndex].Cells["partno"].Value + "' and idpacking='CRT'");
                    txtcrtqty.Text = dtboxqty.Rows[0]["quantity"].ToString();
                }
                else
                {
                    chkcrt.Checked = false;
                    txtcrtqty.Enabled = false;
                }
                if (dataGridView1.Rows[e.RowIndex].Cells["PAL"].Value.ToString() == "1")
                {
                    chkpallet.Checked = true;
                    txtpalletqty.Enabled = true;
                    DataTable dtboxqty = connect.readdata("select quantity from packingstandard where partno='" + dataGridView1.Rows[e.RowIndex].Cells["partno"].Value + "' and idpacking='PAL'");
                    txtpalletqty.Text = dtboxqty.Rows[0]["quantity"].ToString();
                }
                else
                {
                    chkpallet.Checked = false;
                    txtpalletqty.Enabled = false;
                }
                if (dataGridView1.Rows[e.RowIndex].Cells["CAN"].Value.ToString() == "1")
                {
                    chkcan.Checked = true;
                    txtcanqty.Enabled = true;
                    DataTable dtboxqty = connect.readdata("select quantity from packingstandard where partno='" + dataGridView1.Rows[e.RowIndex].Cells["partno"].Value + "' and idpacking='CAN'");
                    txtcanqty.Text = dtboxqty.Rows[0]["quantity"].ToString();
                }
                else
                {
                    chkcan.Checked = false;
                    txtcanqty.Enabled = false;
                }
                if (dataGridView1.Rows[e.RowIndex].Cells["TRA"].Value.ToString() == "1")
                {
                    chktray.Checked = true;
                    txttrayqty.Enabled = true;
                    DataTable dtboxqty = connect.readdata("select quantity from packingstandard where partno='" + dataGridView1.Rows[e.RowIndex].Cells["partno"].Value + "' and idpacking='TRA'");
                    txttrayqty.Text = dtboxqty.Rows[0]["quantity"].ToString();
                }
                else
                {
                    chktray.Checked = false;
                    txttrayqty.Enabled = false;
                }
                if (dataGridView1.Rows[e.RowIndex].Cells["ROL"].Value.ToString() == "1")
                {
                    chkroll.Checked = true;
                    txtrollqty.Enabled = true;
                    DataTable dtboxqty = connect.readdata("select quantity from packingstandard where partno='" + dataGridView1.Rows[e.RowIndex].Cells["partno"].Value + "' and idpacking='ROL'");
                    txtrollqty.Text = dtboxqty.Rows[0]["quantity"].ToString();
                }
                else
                {
                    chkroll.Checked = false;
                    txtrollqty.Enabled = false;
                }

                //qty


            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if(txtsearch.Text!="")
            {
                DataTable dt = connect.readdata("select partno,partname,box,bag,crt,tra,rol,pal,can from view_packing_standard where partno like '%"+txtsearch.Text+"%' or partname like '%"+txtsearch.Text+"%'");
                dataGridView1.DataSource = dt;
            }
        }
        //private string str;
        private void btnsave_Click(object sender, EventArgs e)
        {
            //box
            if(chkbox.Checked==true)
            {
                DataTable dt = connect.readdata("select partno from packingstandard where partno='"+txtpartno.Text+"' and idpacking='BOX'");
                if (dt.Rows.Count > 0)
                {
                    connect.exedata("update packingstandard set quantity='" + txtboxqty.Text + "' where partno='" + txtpartno.Text + "' and idpacking ='BOX'");
                }
                else
                {
                    connect.exedata("insert into packingstandard (partno,idpacking,quantity) values('"+txtpartno.Text+"','BOX','"+txtboxqty.Text+"')");
                }
                
                
            }
            else
            {
                DataTable dt = connect.readdata("select partno from packingstandard where partno='" + txtpartno.Text + "' and idpacking='BOX'");
                if (dt.Rows.Count > 0)
                {
                    connect.exedata("delete from packingstandard where partno='" + txtpartno.Text + "' and idpacking ='BOX'");
                }
                
            }
            //bag
            if (chkbag.Checked == true)
            {
                DataTable dt = connect.readdata("select partno from packingstandard where partno='" + txtpartno.Text + "' and idpacking='BAG'");
                if (dt.Rows.Count > 0)
                {
                    connect.exedata("update packingstandard set quantity='" + txtbagqty.Text + "' where partno='" + txtpartno.Text + "' and idpacking ='BAG'");
                }
                else
                {
                    connect.exedata("insert into packingstandard (partno,idpacking,quantity) values('" + txtpartno.Text + "','BAG','" + txtbagqty.Text + "')");
                }
               
            }
            else
            {
                DataTable dt = connect.readdata("select partno from packingstandard where partno='" + txtpartno.Text + "' and idpacking='BAG'");
                if (dt.Rows.Count > 0)
                {
                    connect.exedata("delete from packingstandard where partno='" + txtpartno.Text + "' and idpacking ='BAG'");
                }
                

            }

            //cart
            if (chkcrt.Checked == true)
            {
                DataTable dt = connect.readdata("select partno from packingstandard where partno='" + txtpartno.Text + "' and idpacking='CRT'");
                if (dt.Rows.Count > 0)
                {
                    connect.exedata("update packingstandard set quantity='" + txtcrtqty.Text + "' where partno='" + txtpartno.Text + "' and idpacking ='CRT'");
                }
                else
                {
                    connect.exedata("insert into packingstandard (partno,idpacking,quantity) values('" + txtpartno.Text + "','CRT','" + txtcrtqty.Text + "')");
                }
                
            }
            else
            {
                DataTable dt = connect.readdata("select partno from packingstandard where partno='" + txtpartno.Text + "' and idpacking='CRT'");
                if (dt.Rows.Count > 0)
                {
                    connect.exedata("delete from packingstandard where partno='" + txtpartno.Text + "' and idpacking ='CRT'");
                }
                
            }

            //tray
            if (chktray.Checked == true)
            {
                DataTable dt = connect.readdata("select partno from packingstandard where partno='" + txtpartno.Text + "' and idpacking='TRA'");
                if (dt.Rows.Count > 0)
                {
                    connect.exedata("update packingstandard set quantity='" + txttrayqty.Text + "' where partno='" + txtpartno.Text + "' and idpacking ='TRA'");
                }
                else
                {
                    connect.exedata("insert into packingstandard (partno,idpacking,quantity) values('" + txtpartno.Text + "','TRA','" + txttrayqty.Text + "')");
                }

            }
            else
            {
                DataTable dt = connect.readdata("select partno from packingstandard where partno='" + txtpartno.Text + "' and idpacking='TRA'");
                if (dt.Rows.Count > 0)
                {
                    connect.exedata("delete from packingstandard where partno='" + txtpartno.Text + "' and idpacking ='TRA'");
                }

            }

            //roll
            if (chkroll.Checked == true)
            {
                DataTable dt = connect.readdata("select partno from packingstandard where partno='" + txtpartno.Text + "' and idpacking='ROL'");
                if (dt.Rows.Count > 0)
                {
                    connect.exedata("update packingstandard set quantity='" + txtrollqty.Text + "' where partno='" + txtpartno.Text + "' and idpacking ='ROL'");
                }
                else
                {
                    connect.exedata("insert into packingstandard (partno,idpacking,quantity) values('" + txtpartno.Text + "','ROL','" + txtrollqty.Text + "')");
                }

            }
            else
            {
                DataTable dt = connect.readdata("select partno from packingstandard where partno='" + txtpartno.Text + "' and idpacking='ROL'");
                if (dt.Rows.Count > 0)
                {
                    connect.exedata("delete from packingstandard where partno='" + txtpartno.Text + "' and idpacking ='ROL'");
                }

            }

            //pallet
            if (chkpallet.Checked == true)
            {
                DataTable dt = connect.readdata("select partno from packingstandard where partno='" + txtpartno.Text + "' and idpacking='PAL'");
                if (dt.Rows.Count > 0)
                {
                    connect.exedata("update packingstandard set quantity='" + txtpalletqty.Text + "' where partno='" + txtpartno.Text + "' and idpacking ='PAL'");
                }
                else
                {
                    connect.exedata("insert into packingstandard (partno,idpacking,quantity) values('" + txtpartno.Text + "','PAL','" + txtpalletqty.Text + "')");
                }

            }
            else
            {
                DataTable dt = connect.readdata("select partno from packingstandard where partno='" + txtpartno.Text + "' and idpacking='PAL'");
                if (dt.Rows.Count > 0)
                {
                    connect.exedata("delete from packingstandard where partno='" + txtpartno.Text + "' and idpacking ='PAL'");
                }

            }
            //can
            if (chkcan.Checked == true)
            {
                DataTable dt = connect.readdata("select partno from packingstandard where partno='" + txtpartno.Text + "' and idpacking='CAN'");
                if (dt.Rows.Count > 0)
                {
                    connect.exedata("update packingstandard set quantity='" + txtcanqty.Text + "' where partno='" + txtpartno.Text + "' and idpacking ='CAN'");
                }
                else
                {
                    connect.exedata("insert into packingstandard (partno,idpacking,quantity) values('" + txtpartno.Text + "','CAN','" + txtcanqty.Text + "')");
                }

            }
            else
            {
                DataTable dt = connect.readdata("select partno from packingstandard where partno='" + txtpartno.Text + "' and idpacking='CAN'");
                if (dt.Rows.Count > 0)
                {
                    connect.exedata("delete from packingstandard where partno='" + txtpartno.Text + "' and idpacking ='CAN'");
                }

            }
            if(txtpartno.Text!="")
            {
                MessageBox.Show("Success");
                loaddata("select partno,partname,box,bag,crt,tra,rol,pal,can from view_packing_standard");
                txtpartno.Text = "";
                txtpartname.Text = "";
                txtboxqty.Text = "";
                txtbagqty.Text = "";
                txtcrtqty.Text = "";
            }
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        private void txtboxqty_Validated(object sender, EventArgs e)
        {
            
            if(IsNumber(txtboxqty.Text)==false || txtboxqty.Text=="")
            {
                MessageBox.Show("must be number");
            }
            else
            {
                DataTable dt = connect.readdata("select maxquantity from packing where idpacking ='BOX'");
                if (Convert.ToDouble(txtboxqty.Text) <= 0 || Convert.ToDouble(txtboxqty.Text) > Convert.ToDouble(dt.Rows[0]["maxquantity"].ToString()))
                {
                    MessageBox.Show("Invalid !!!");
                }
            }
            
        }

        private void txtpartno_TextChanged(object sender, EventArgs e)
        {
            if(txtpartno.Text!="")
            {
                chkbox.Enabled = true;
                chkbag.Enabled = true;
                chkcrt.Enabled = true;
                chktray.Enabled = true;
                chkroll.Enabled = true;
                chkpallet.Enabled = true;
                chkcan.Enabled = true;

            }
        }

        private void chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbox.Checked==true)
            {
                txtboxqty.Enabled = true;
            }
            else
            {
                txtboxqty.Text = "";
                txtboxqty.Enabled = false;
            }
            
        }

        private void chkbag_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbag.Checked==true)
            {
                txtbagqty.Enabled = true;
            }
            else
            {
                txtbagqty.Text = "";
                txtbagqty.Enabled = false;
            }
            
        }

        private void chkcrt_CheckedChanged(object sender, EventArgs e)
        {
            if(chkcrt.Checked==true)
            {
                txtcrtqty.Enabled = true;
            }
            else
            {
                txtcrtqty.Text = "";
                txtcrtqty.Enabled = false;
            }
            
        }

        private void chktray_CheckedChanged(object sender, EventArgs e)
        {
            if(chktray.Checked==true)
            {
                txttrayqty.Enabled = true;
            }
            else
            {
                txttrayqty.Text = "";
                txttrayqty.Enabled = false;
            }
            
        }

        private void chkroll_CheckedChanged(object sender, EventArgs e)
        {
            if(chkroll.Checked==true)
            {
                txtrollqty.Enabled = true;
            }
            else
            {
                txtrollqty.Text = "";
                txtrollqty.Enabled = false;
            }

            
        }

        private void chkpallet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpallet.Checked == true)
            {
                txtpalletqty.Enabled = true;
            }
            else
            {
                txtpalletqty.Text = "";
                txtpalletqty.Enabled = false;
            }
        }

        private void chkcan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcan.Checked == true)
            {
                txtcanqty.Enabled = true;
            }
            else
            {
                txtcanqty.Text = "";
                txtcanqty.Enabled = false;
            }
        }

       
    }
}
