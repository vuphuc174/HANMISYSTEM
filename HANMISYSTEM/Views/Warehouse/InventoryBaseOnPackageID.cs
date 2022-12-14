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

namespace HANMISYSTEM.Views.Warehouse
{
    public partial class InventoryBaseOnPackageID : Form
    {
        public InventoryBaseOnPackageID()
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
                GetData(curPage, pageSize, txtsearch.Text, cbbWarehouse.SelectedValue.ToString());
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
            SetPage = GetTotalPage(txtsearch.Text, cbbWarehouse.SelectedValue.ToString());
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
        private int GetTotalPage(string searchTearm, string wh)
        {
            DataTable dataTable;
            if (string.IsNullOrEmpty(searchTearm))
            {
                dataTable = connect.readdata("with temp as  (select ROW_NUMBER() over (Order by pi.partno asc) as row,	pi.idpack,	pi.partno,c.partname, pi.quantity,	pi.packingdate from packinginfo pi inner join cargo c on pi.partno=c.partno where   pi.idwarehouse ='"+wh+"') select COUNT(*) as row from temp");
            }
            else
            {
                dataTable = connect.readdata("with temp as  (select ROW_NUMBER() over (Order by pi.partno asc) as row,	pi.idpack,	pi.partno,c.partname, pi.quantity,	pi.packingdate from packinginfo pi inner join cargo c on pi.partno=c.partno where ( pi.partno like '%"+searchTearm+"%'  or pi.idpack like '%"+searchTearm+ "%') and pi.idwarehouse ='" + wh + "' ) select COUNT(*) as row from temp");
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
        private void GetData(int page, int pageSize, string searchTearm, string wh)
        {
            try
            {
                if (string.IsNullOrEmpty(searchTearm))
                {
                    loaddata("with temp as  (select ROW_NUMBER() over (Order by pi.partno asc) as row,	pi.idpack,	pi.partno,c.partname, pi.quantity,	pi.packingdate from packinginfo pi inner join cargo c on pi.partno=c.partno where   pi.idwarehouse ='" + wh + "') select *  from temp  where row >=" + ((page * pageSize - pageSize) + 1) + " and row <= " + (page * pageSize) + "");
                }
                else
                {
                    loaddata("with temp as  (select ROW_NUMBER() over (Order by pi.partno asc) as row,	pi.idpack,	pi.partno,c.partname, pi.quantity,	pi.packingdate from packinginfo pi inner join cargo c on pi.partno=c.partno where ( pi.partno like '%" + searchTearm + "%'  or pi.idpack like '%" + searchTearm + "%') and pi.idwarehouse ='" + wh + "') select *  from temp  where row >=" + ((page * pageSize - pageSize) + 1) + " and row <= " + (page * pageSize) + "");
                }
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
            GetData(curPage, pageSize, txtsearch.Text, cbbWarehouse.SelectedValue.ToString());
        }
        private void InventoryBaseOnPackageID_Load(object sender, EventArgs e)
        {
            DataTable dtWarehouse = connect.readdata("select * from warehouse");
            cbbWarehouse.DataSource = dtWarehouse;
            cbbWarehouse.DisplayMember = "namewarehouse";
            cbbWarehouse.ValueMember = "idwarehouse";
            if (!string.IsNullOrEmpty(wh))
            {
                cbbWarehouse.SelectedValue = wh;
            }
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
            SetTotalPage = GetTotalPage(txtsearch.Text, cbbWarehouse.SelectedValue.ToString());

            //pagelist
            UpdatePageList();
        }
        

        private void cbbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPage = 1;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            SetPage = 1;
            SetTotalPage = GetTotalPage(txtsearch.Text, cbbWarehouse.SelectedValue.ToString());
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            DataTable dt;
            ExportToExcel exportToExcel = new ExportToExcel();

            if (string.IsNullOrEmpty(txtsearch.Text))
            {
                dt = connect.readdata("with temp as  (select ROW_NUMBER() over (Order by pi.partno asc) as row,	pi.idpack,	pi.partno,c.partname, pi.quantity,	pi.packingdate from packinginfo pi inner join cargo c on pi.partno=c.partno where   pi.idwarehouse ='" + wh + "') select *  from temp");
            }
            else
            {
                dt = connect.readdata("with temp as  (select ROW_NUMBER() over (Order by pi.partno asc) as row,	pi.idpack,	pi.partno,c.partname, pi.quantity,	pi.packingdate from packinginfo pi inner join cargo c on pi.partno=c.partno where ( pi.partno like '%" + txtsearch.Text + "%'  or pi.idpack like '%" + txtsearch.Text + "%') and pi.idwarehouse ='" + wh + "' ) select *  from temp");
            }
            saveFileDialog1.FileName = "HM_" + cbbWarehouse.Text;
            saveFileDialog1.Filter =
                "*.xlsx|*.xls";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                exportToExcel.ExportToExcelFunction(dt, saveFileDialog1.FileName.ToString());
            }
        }
    }
}
