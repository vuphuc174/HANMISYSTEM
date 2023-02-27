using System;
using System.Collections.Generic;
using System.ComponentModel;
using tbl = System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Button = System.Windows.Forms.Button;

namespace HANMISYSTEM
{
    public partial class Production_history : Form
    {
        public Production_history()
        {
            InitializeComponent();
        }
        List<Button> buttons = new List<Button>();
        Dbconnect connect = new Dbconnect();
        const int pageSize = 30;
        int totalPage;
        public string wh;
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
                GetData(curPage, pageSize, txtsearch.Text, cbwarehouse.SelectedValue.ToString(), cblocation.SelectedValue.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"));
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
            SetPage = GetTotalPage(txtsearch.Text, cbwarehouse.SelectedValue.ToString(), cblocation.SelectedValue.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"));
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
        private int GetTotalPage(string searchTearm, string wh, string lineID, string statdate, string endate)
        {
            DataTable dataTable;
            string sql;
            sql = "select COUNT(*) as row  from productionhistory inner join cargo on productionhistory.partno=cargo.partno inner join warehouse on productionhistory.idwarehouse=warehouse.idwarehouse where warehouse.idwarehouse ='"+wh+"' and idlocation ='"+lineID+"' and CONVERT(date,productionhistory.productiontime) between '"+statdate+"' and '"+endate+"'  " + ((string.IsNullOrEmpty(searchTearm)) ? " " : " and productionhistory.partno like '%" + searchTearm + "%'") + "";
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
        private void GetData(int page, int pageSize, string searchTearm, string wh, string lineID, string statdate, string endate)
        {
            string sql;
            try
            {
                sql = "with temp as  (select ROW_NUMBER() over (order by productionhistory.productiontime desc) as row, idpack,cargo.partno,partname,productiontime,stoptime,remark,qty,idlocation  from productionhistory inner join cargo on productionhistory.partno=cargo.partno inner join warehouse on productionhistory.idwarehouse=warehouse.idwarehouse where warehouse.idwarehouse ='" + wh + "' and idlocation ='" + lineID + "' and CONVERT(date,productionhistory.productiontime) between '" + statdate + "' and '" + endate + "'  " + ((string.IsNullOrEmpty(searchTearm)) ? " " : " and productionhistory.partno like '%" + searchTearm + "%'") + ") select *  from temp  where row >=" + ((page * pageSize - pageSize) + 1) + " and row <= " + (page * pageSize) + " order by row asc";
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
            GetData(curPage, pageSize, txtsearch.Text, cbwarehouse.SelectedValue.ToString(), cblocation.SelectedValue.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"));
        }
        private void Production_history_Load(object sender, EventArgs e)
        {

            tbl.DataTable dt = connect.readdata("select * from warehouse");
            if (dt.Rows.Count > 0)
            {
                cbwarehouse.DataSource = dt;
                cbwarehouse.ValueMember = "idwarehouse";
                cbwarehouse.DisplayMember = "namewarehouse";
            }
            tbl.DataTable dtlocation = connect.readdata("select * from location");
            cblocation.DataSource = dtlocation;
            cblocation.DisplayMember = "namelocation1";
            cblocation.ValueMember = "idlocation";
            cblocation.SelectedValue = "L1";
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
            SetTotalPage = GetTotalPage(txtsearch.Text, cbwarehouse.SelectedValue.ToString(), cblocation.SelectedValue.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"));

            //pagelist
            UpdatePageList();
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            SetPage = 1;
            SetTotalPage = GetTotalPage(txtsearch.Text, cbwarehouse.SelectedValue.ToString(), cblocation.SelectedValue.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"));
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
            }
        }
       
    }
}
