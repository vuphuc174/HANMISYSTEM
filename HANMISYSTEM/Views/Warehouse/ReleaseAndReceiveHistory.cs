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
        List<Button> buttons = new List<Button>();
        Dbconnect connect = new Dbconnect();
        const int pageSize = 30;
        int totalPage;
        public string wh;
        public Form MainFormRef { get; set; }
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
                GetData(curPage, pageSize, txtsearch.Text, cbbWarehouse.SelectedValue.ToString(), cbfilter.Text, startDate.Value.ToString("yyyy-MM-dd"), endDate.Value.ToString("yyyy-MM-dd"));
            }
        }
        private void CheckGoPageButton()
        {
            if (Convert.ToInt32(p6.Text) < totalPage)
            {
                p7.Visible = true;
            }
            else
            {
                p7.Visible = false;
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
                            if (curPage % 6 == 0)
                            {
                                for (int i = 0; i < 6; i++)
                                {
                                    buttons[i].Text = (num * 6 - 5 + i).ToString();
                                    if (Convert.ToInt32(buttons[i].Text) <= totalPage || buttons[i].Text == "...")
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
            foreach (Button button in buttons)
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
        private void btnGoLast_Click(object sender, EventArgs e)
        {
            SetPage = GetTotalPage(txtsearch.Text, cbbWarehouse.SelectedValue.ToString(), cbfilter.Text, startDate.Value.ToString("yyyy-MM-dd"), endDate.Value.ToString("yyyy-MM-dd"));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnGoFirst_Click(object sender, EventArgs e)
        {
            SetPage = 1;
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
        private int GetTotalPage(string searchTearm, string wh,string kind,string statdate,string endate)
        {
            DataTable dataTable;
            string sql;
            if(kind=="IN")
            {
                sql = "with temp as(select ROW_NUMBER() over (order by dateout desc) as row, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where  s.idcustomer='"+wh+"' and convert(date,s.dateout) between '"+statdate+"' and '"+endate+ "'  " + ((string.IsNullOrEmpty(searchTearm)) ? " " : " and si.idslipout like '%"+searchTearm+"%'") + " ) select count(*) as row from temp";
            }
            else
            {
                sql = "with temp as(select ROW_NUMBER() over (order by dateout desc) as row, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where  s.idwarehouse='" + wh + "' and convert(date,s.dateout) between '" + statdate + "' and '" + endate + "'  " + ((string.IsNullOrEmpty(searchTearm)) ? " " : " and si.idslipout like '%" + searchTearm + "%'") + " ) select count(*) as row from temp";
            }
            dataTable = connect.readdata(sql);
            
            
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
        private void GetData(int page, int pageSize, string searchTearm, string wh, string kind, string statdate, string endate)
        {
            string sql;
            try
            {
                if (kind=="IN")
                {
                    sql="with temp as  (select ROW_NUMBER() over (order by dateout desc) as row, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where  s.idcustomer='" + wh + "' and convert(date,s.dateout) between '" + statdate + "' and '" + endate + "'  " + ((string.IsNullOrEmpty(searchTearm)) ? " " : " and si.idslipout like '%" + searchTearm + "%'") + ") select *  from temp  where row >=" + ((page * pageSize - pageSize) + 1) + " and row <= " + (page * pageSize) + " order by row asc";
                }
                else
                {
                    sql="with temp as  (select ROW_NUMBER() over (order by dateout desc) as row, idslipout,dateout,w.namewarehouse as warehouse,w1.namewarehouse as customer,(select COUNT(idpack) from slipoutinfo where idslipout =s.idslipout)as packqty from slipout s inner join warehouse w on  w.idwarehouse=s.idwarehouse inner join warehouse w1 on w1.idwarehouse=s.idcustomer where  s.idwarehouse='" + wh + "' and convert(date,s.dateout) between '" + statdate + "' and '" + endate + "'  " + ((string.IsNullOrEmpty(searchTearm)) ? " " : " and si.idslipout like '%" + searchTearm + "%'") + ") select *  from temp  where row >=" + ((page * pageSize - pageSize) + 1) + " and row <= " + (page * pageSize) + " order by row asc";
                }
                loaddata(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void btn_gopage(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SetPage = Convert.ToInt32(btn.Text);
            GetData(curPage, pageSize, txtsearch.Text, cbbWarehouse.SelectedValue.ToString(),cbfilter.Text,startDate.Value.ToString("yyyy-MM-dd"),endDate.Value.ToString("yyyy-MM-dd"));
        }
        private void ReleaseAndReceiveHistory_Load(object sender, EventArgs e)
        {
            DataTable dtWarehouse = connect.readdata("select * from warehouse");
            cbbWarehouse.DataSource = dtWarehouse;
            cbbWarehouse.DisplayMember = "namewarehouse";
            cbbWarehouse.ValueMember = "idwarehouse";
            if (!string.IsNullOrEmpty(wh))
            {
                cbbWarehouse.SelectedValue = wh;
            }
            cbfilter.SelectedIndex = 0;
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
            SetTotalPage = GetTotalPage(txtsearch.Text, cbbWarehouse.SelectedValue.ToString(), cbfilter.Text, startDate.Value.ToString("yyyy-MM-dd"), endDate.Value.ToString("yyyy-MM-dd"));

            //pagelist
            UpdatePageList();
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
                    fr.lbiwarehouse.Text = cbbWarehouse.Text;
                }
                else
                {
                    fr.lbewarehouse.Text = cbbWarehouse.Text;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SetPage = 1;
            SetTotalPage = GetTotalPage(txtsearch.Text, cbbWarehouse.SelectedValue.ToString(), cbfilter.Text, startDate.Value.ToString("yyyy-MM-dd"), endDate.Value.ToString("yyyy-MM-dd"));
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {

        }
    }
}
