using HANMISYSTEM.Module;
using HANMISYSTEM.Views.PartialView;
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
        List<Button> buttons = new List<Button>();
        Dbconnect connect = new Dbconnect();
        const int pageSize = 30;
        int totalPage;
        public int SetTotalPage
        {
            get { return totalPage; }
            set
            {
                totalPage = value;
                UpdateLabels();
                UpdatePageList();
            }
        }
        int curPage;
        int SetPage
        {
            get { return curPage; }
            set
            {
                curPage = value;
                UpdateLabels();
                LoadMorePage();
                GoLastPage();
                ShowLessPage();
                UpdatePageList();
                CheckGoPageButton();
                GetData(curPage, pageSize, txtsearch.Text);
            }
        }
        private void CheckGoPageButton()
        {
            if(Convert.ToInt32(p6.Text) < totalPage)
            {
                p7.Visible = true;
            }
            else
            {
                p7.Visible=false;
            }
        }
        private void GoLastPage()
        {
            if (curPage == totalPage)
            {
                int num;
                num = totalPage % 6;
                for (int i = 0; i < num; i++)
                {
                    buttons[i].Text = (totalPage - num + 1 + i).ToString();
                    buttons[i].Visible = true;
                }
            }
        }
        private void ShowLessPage()
        {
            if (curPage.ToString() == p1.Text && curPage >= 4)
            {
                foreach (Button button in buttons)
                {
                    if (button.Text != "...")
                        button.Text = (Convert.ToInt32(button.Text) - 3).ToString();
                }
            }
        }
        private void LoadMorePage()
        {
            if (curPage.ToString() == p6.Text && curPage < totalPage)
            {
                foreach (Button button in buttons)
                {
                    if (button.Text != "...")
                        button.Text = (Convert.ToInt32(button.Text) + 3).ToString();
                }
            }
        }
        private void SetActivePage()
        {
            foreach (Button button in buttons)
            {
                if (button.Text == curPage.ToString())
                {
                    button.BackColor = Color.FromArgb(30, 140, 240);
                    button.ForeColor = Color.White;
                }
            }
        }
        private void SetPageListVisible()
        {
            foreach (Button button in buttons)
            {
                button.Visible = false;
            }
        }
        private void RemoveActive()
        {
            foreach (Button button in buttons)
            {
                button.BackColor = SystemColors.Control;
                button.ForeColor = Color.Black;
            }
        }
        private void HideAllPageNotExist()
        {
            foreach (Button button in buttons)
            {
                if (button.Text != "...")
                {
                    if (Convert.ToInt32(button.Text) > totalPage)
                    {
                        button.Visible = false;
                        p7.Visible = false;
                    }
                }

            }
        }
        private void UpdatePageList()
        {
            try
            {
                SetPageListVisible();

                if (totalPage > 0)
                {
                    RemoveActive();
                    //show page list
                    //if page is last
                    if (curPage == totalPage)
                    {
                        int num;
                        num = totalPage % 6;
                        if (num > 0)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                buttons[i].Text = (totalPage - num + 1 + i).ToString();
                                if (Convert.ToInt32(buttons[i].Text) <= totalPage)
                                    buttons[i].Visible = true;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                buttons[i].Text = (totalPage - 6 + 1 + i).ToString();
                                if (Convert.ToInt32(buttons[i].Text) <= totalPage)
                                    buttons[i].Visible = true;
                            }
                        }
                    }
                    else
                    {
                        //go page not inside current page list
                        if (!CheckContain(curPage.ToString()))
                        {
                            int num = (curPage / 6);
                            if(curPage%6==0)
                            {
                                for (int i = 0; i < 6; i++)
                                {
                                        buttons[i].Text = (num * 6 - 5 + i).ToString();
                                        if (Convert.ToInt32(buttons[i].Text) <= totalPage || buttons[i].Text=="..." )
                                            buttons[i].Visible = true;
                                }
                               
                            }
                            else
                            {
                                for (int i = 0; i < 6; i++)
                                {
                     
                                        buttons[i].Text = ((num + 1) * 6 - 5 + i).ToString();
                                        if (Convert.ToInt32(buttons[i].Text) <= totalPage || buttons[i].Text == "...")
                                            buttons[i].Visible = true;
                               
                              
                                }
                            }


                        }
                        else
                        {
                            for (int i = 0; i <= ((totalPage >= 6) ? 6 : totalPage - 1); i++)
                            {
                                if (buttons[i].Text != "..." && curPage == 1)
                                {
                                    buttons[i].Text = (i + 1).ToString();
                                }
                                buttons[i].Visible = true;
                            }
                        }

                    }
                    SetActivePage();
                    HideAllPageNotExist();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private bool CheckContain(string page)
        {
            foreach(Button button in buttons)
            {
                if (button.Text == page)
                    return true; 
            }
            return false;
        }
        private void UpdateLabels()
        {
            lbCurrentPage.Text = curPage.ToString();
            lbTotalPage.Text = totalPage.ToString();
        }
        private void loaddata(string cmd)
        {
            try
            {
                DataTable dt = connect.readdata(cmd);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                throw;
            }
        }
        private void Packing_standard_Load(object sender, EventArgs e)
        {
            //
            buttons.Add(p1);
            buttons.Add(p2);
            buttons.Add(p3);
            buttons.Add(p4);
            buttons.Add(p5);
            buttons.Add(p6);
            buttons.Add(p7);
            foreach (Button button in buttons)
            {
                if (button.Text != "...")
                {
                    button.Click += btn_gopage;
                }
            }
            SetPage = 1;
            //GetData(1, pageSize, "");
            SetTotalPage = GetTotalPage(txtsearch.Text);

            //pagelist
            UpdatePageList();
        }
        public void btn_gopage(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SetPage = Convert.ToInt32(btn.Text);
            GetData(curPage, pageSize, txtsearch.Text);
        }
        private int GetTotalPage(string searchTearm)
        {
            DataTable dataTable;
            if (string.IsNullOrEmpty(searchTearm))
            {
                dataTable = connect.readdata("select count(*) as  row from view_packing_standard order by row desc");
            }
            else
            {
                dataTable = connect.readdata("select count(*) as row from view_packing_standard where partno like '%" + searchTearm + "%'");
            }
            if (dataTable.Rows.Count > 0)
            {
                if (Convert.ToInt32(dataTable.Rows[0]["row"].ToString()) % pageSize == 0)
                {
                    return Convert.ToInt32(dataTable.Rows[0]["row"].ToString()) / pageSize;
                }
                else
                {
                    return Convert.ToInt32(dataTable.Rows[0]["row"].ToString()) / pageSize + 1;
                }
            }

            return 0;
        }

        private void GetData(int page, int pageSize, string searchTearm)
        {
            try
            {
                if (string.IsNullOrEmpty(searchTearm))
                {
                    loaddata("with temp as(select *,ROW_NUMBER() over (order by partno asc) as row from view_packing_standard)select * from temp  where row >=" + ((page * pageSize - pageSize) + 1) + " and row <= " + (page * pageSize) + "");
                }
                else
                {
                    loaddata("with temp as(select *,ROW_NUMBER() over (order by partno asc) as row from view_packing_standard where partno like '%" + searchTearm + "%')select * from temp  where row >=" + ((page * pageSize - pageSize) + 1) + " and row <= " + (page * pageSize) + "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private bool ChangePackingMethod(string pn)
        {
            DataTable dtPO = connect.readdata("select ChangePackingMethod from PackingOptional where PartNo ='" + pn + "'");
            if (dtPO.Rows.Count > 0)
            {
                if (dtPO.Rows[0]["ChangePackingMethod"].ToString() == "True")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        private bool CheckLabel(string pn)
        {
            DataTable dtPO = connect.readdata("select CheckLabel from PackingOptional where PartNo ='" + pn + "'");
            if (dtPO.Rows.Count > 0)
            {
                if (dtPO.Rows[0]["CheckLabel"].ToString() == "True")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
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



            txtboxqty.Enabled = false;
            txtbagqty.Enabled = false;
            txtcrtqty.Enabled = false;
            txttrayqty.Enabled = false;
            txtrollqty.Enabled = false;
            txtpalletqty.Enabled = false;
            txtcanqty.Enabled = false;

            if (e.RowIndex != -1)
            {
                //
                if (ChangePackingMethod(dataGridView1.Rows[e.RowIndex].Cells["partno"].Value.ToString()))
                {
                    chkChangePackingMethod.Checked = true;
                }
                else
                {
                    chkChangePackingMethod.Checked = false;
                }
                //
                if (CheckLabel(dataGridView1.Rows[e.RowIndex].Cells["partno"].Value.ToString()))
                {
                    chkCheckLabelPackage.Checked = true;
                }
                else
                {
                    chkCheckLabelPackage.Checked = false;
                }
                txtpartno.Text = dataGridView1.Rows[e.RowIndex].Cells["partno"].Value.ToString();
                txtpartname.Text = dataGridView1.Rows[e.RowIndex].Cells["partname"].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells["BOX"].Value.ToString() == "1")
                {
                    chkbox.Checked = true;
                    txtboxqty.Enabled = true;
                    DataTable dtboxqty = connect.readdata("select quantity from packingstandard where partno='" + dataGridView1.Rows[e.RowIndex].Cells["partno"].Value + "' and idpacking='BOX'");
                    txtboxqty.Text = dtboxqty.Rows[0]["quantity"].ToString();
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

            SetPage = 1;
            //GetData(curPage, pageSize, txtsearch.Text);
            SetTotalPage = GetTotalPage(txtsearch.Text);
        }
        //private string str;
        private async Task SavePackingOptional(string pn, bool cpm, bool cl)
        {
            await connect.ExeDataAsync("Update PackingOptional set ChangePackingMethod =" + (cpm ? "1" : "0") + " ,CheckLabel=" + (cl ? "1" : "0") + " where PartNo= '" + pn + "' ");
        }
        private async void btnsave_Click(object sender, EventArgs e)
        {

            //box
            if (chkbox.Checked == true)
            {
                DataTable dt = connect.readdata("select partno from packingstandard where partno='" + txtpartno.Text + "' and idpacking='BOX'");
                if (dt.Rows.Count > 0)
                {
                    connect.exedata("update packingstandard set quantity='" + txtboxqty.Text + "' where partno='" + txtpartno.Text + "' and idpacking ='BOX'");
                }
                else
                {
                    connect.exedata("insert into packingstandard (partno,idpacking,quantity) values('" + txtpartno.Text + "','BOX','" + txtboxqty.Text + "')");
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
            if (txtpartno.Text != "")
            {
                //save packingoptional
                //err1
                try
                {
                    await SavePackingOptional(txtpartno.Text, chkChangePackingMethod.Checked, chkCheckLabelPackage.Checked);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("err1 :" + ex.Message);
                }
                MessageBox.Show("Success");
                GetData(curPage, pageSize, txtsearch.Text);
                txtpartno.Text = "";
                txtpartname.Text = "";
                txtboxqty.Text = "";
                txtbagqty.Text = "";
                txtcrtqty.Text = "";
                chkCheckLabelPackage.Checked = false;
                chkChangePackingMethod.Checked = false;
            }
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        private void txtboxqty_Validated(object sender, EventArgs e)
        {

            if (IsNumber(txtboxqty.Text) == false || txtboxqty.Text == "")
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
            if (txtpartno.Text != "")
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
            if (chkbox.Checked == true)
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
            if (chkbag.Checked == true)
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
            if (chkcrt.Checked == true)
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
            if (chktray.Checked == true)
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
            if (chkroll.Checked == true)
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (curPage < totalPage)
            {
                SetPage++;
                //GetData(curPage, pageSize, txtsearch.Text);
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (curPage > 1)
            {
                SetPage--;
                //GetData(curPage, pageSize, txtsearch.Text);
            }
        }

        private void btnGoFirst_Click(object sender, EventArgs e)
        {
            SetPage = 1;
            //GetData(curPage, pageSize, txtsearch.Text);
        }

        private void p7_Click(object sender, EventArgs e)
        {
            using (PageSearch frm = new PageSearch())
            {
                frm.totalPage = totalPage;
                frm.ShowDialog();

                SetPage = frm.SendPageIndex();
            }



        }

        private void btnGoLast_Click(object sender, EventArgs e)
        {
            SetPage = GetTotalPage(txtsearch.Text);
            //GetData(curPage, pageSize, txtsearch.Text);
        }
    }
}
