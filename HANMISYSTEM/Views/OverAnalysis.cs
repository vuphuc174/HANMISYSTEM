using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HANMISYSTEM
{
    public partial class OverAnalysis : Form
    {
        public OverAnalysis()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        static string sn = HANMISYSTEM.Properties.Settings.Default.servername;
        static string uid = HANMISYSTEM.Properties.Settings.Default.uid;
        static string pwd = HANMISYSTEM.Properties.Settings.Default.pwd;
        //Thiết lập số bản ghi trên 1 trang.
        int PageSize = 8;
        //private object page;
        private void OverAnalysis_Load(object sender, EventArgs e)
        {
            this.LoadData(1);

            
        }
        private string m;
        private string getproceduce(string wh)
        {
            if(wh=="WH001")
            {
                m = "GetCargoWarehousePaging";
            }
            if (wh == "WH002")
            {
                m = "GetCargoWarehousePaging";
            }
            if (wh == "WH003")
            {
                m = "GetCargoWarehousePaging";
            }
            if (wh == "WH004")
            {
                m = "GetCargoWarehousePaging";
            }
            if (wh == "WH005")
            {
                m = "GetCargoWarehousePaging";
            }
            if (wh == "WH006")
            {
                m = "GetCargoWarehousePaging";
            }
            return m;
        }
        private void LoadData(int pageIndex)
        {

            //Chuỗi kết nối
            string constring = @"Data Source=" + sn + ";Initial Catalog=HANMI;Trusted_Connection=yes;uid = " + uid + ";pwd= " + pwd + ";  Integrated Security=true ;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                //Gọi câu lệnh SQL lưu trữ trong Stored Procedure có tên GetMatHangPaging
                using (SqlCommand cmd = new SqlCommand("GetCargoWarehousePaging", con))
                {
                    //Truyền vào các tham số PageIndex, PageSize cho Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PageIndex", pageIndex);
                    cmd.Parameters.AddWithValue("@PageSize", PageSize);
                    //Lấy ra tham số RecordCount của Store Procedured
                    cmd.Parameters.Add("@RecordCount", SqlDbType.Int, 4);
                    cmd.Parameters["@RecordCount"].Direction = ParameterDirection.Output;
                    con.Open();
                    //Thực thi câu lệnh truy vấn và gán cho đối tượng DataTable
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView1.DataSource = dt;
                    con.Close();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                       
                        // inventory last month
                        DataTable dtqty = connect.readdata("select quantity  from stocklastmonth where partno='" + dataGridView1.Rows[i].Cells["Partno"].Value + "' and idwarehouse='WH001' and yearmonth= '" +monthdesc() + "'");
                        if (dtqty.Rows.Count > 0)
                        {
                            dataGridView1.Rows[i].Cells["lastmonthinventory"].Value = dtqty.Rows[0]["quantity"].ToString();
                        }
                        // in from another department
                        DataTable dtinother = connect.readdata("select partno,sum(quantity) as qty from slipout  inner join slipoutinfo on slipout.idslipout=slipoutinfo.idslipout where idcustomer='WH001' and partno='"+dataGridView1.Rows[i].Cells["Partno"].Value+"' group by partno");
                        if(dtinother.Rows.Count>0)
                        {
                            dataGridView1.Rows[i].Cells["inother"].Value=dtinother.Rows[0]["qty"].ToString();
                        }

                        // out  another department
                        DataTable dtoutother = connect.readdata("select partno,sum(quantity) as qty from slipout  inner join slipoutinfo on slipout.idslipout=slipoutinfo.idslipout where idwarehouse='" + cbwarehouse.SelectedValue + "' and partno='" + dataGridView1.Rows[i].Cells["Partno"].Value + "' group by partno");
                        if (dtoutother.Rows.Count > 0)
                        {
                            dataGridView1.Rows[i].Cells["outother"].Value = dtoutother.Rows[0]["qty"].ToString();
                        }

                        // in production
                        DataTable dtinproduction = connect.readdata("select quantity from productivity where partno='"+dataGridView1.Rows[i].Cells["Partno"].Value+"' and idwarehouse='WH001' and yearmonth='"+DateTime.Now.ToString("yyyy-MM")+"'  ");
                        if (dtinproduction.Rows.Count > 0)
                        {
                            dataGridView1.Rows[i].Cells["Inproduction"].Value = dtinproduction.Rows[0]["quantity"].ToString();
                        }
                        //DataTable dtoutproduction = connect.readdata("select quantity from tbl_feedproduction where idwarehouse'"+cbwarehouse.SelectedValue+"' and partno='"+dataGridView1.Rows[i].Cells["Partno"].Value+"'");

                    }
                    int recordCount = Convert.ToInt32(cmd.Parameters["@RecordCount"].Value);
                    this.HienThiThanhDieuHuong(recordCount, pageIndex);
                }
            }
        }
        private string monthdesc()
        {
            int m = Convert.ToInt32(DateTime.Now.Month.ToString());
            int y = Convert.ToInt32(DateTime.Now.Year.ToString());
            if(m==1)
            {
                y = y - 1;
                m = 12;
            }
            else
            {
                m = m - 1;
            }
            if(m>=10)
            {
                return y + "-" + m;
            }
            else
            {
                return y + "-" + m.ToString("00");
            }
            
        }
        private void HienThiThanhDieuHuong(int recordCount, int currentPage)
        {
            //Sử dụng đối tượng List để chứa danh sách các trang
            List <Page>  pages= new List<Page>();
            int startIndex, endIndex;
            int pagerSpan = 8;

            //Tính toán để hiển thị các trang.
            double dblPageCount = (double)((decimal)recordCount / Convert.ToDecimal(PageSize));
            int pageCount = (int)Math.Ceiling(dblPageCount);
            startIndex = currentPage > 1 && currentPage + pagerSpan - 1 < pagerSpan ? currentPage : 1; endIndex = pageCount > pagerSpan ? pagerSpan : pageCount;
            if (currentPage > pagerSpan % 2)
            {
                if (currentPage == 2)
                {
                    endIndex = 8;
                }
                else
                {
                    endIndex = currentPage + 2;
                }
            }
            else
            {
                endIndex = (pagerSpan - currentPage) + 1;
            }

            if (endIndex - (pagerSpan - 1) > startIndex)
            {
                startIndex = endIndex - (pagerSpan - 1);
            }

            if (endIndex > pageCount)
            {
                endIndex = pageCount;
                startIndex = ((endIndex - pagerSpan) + 1) > 0 ? (endIndex - pagerSpan) + 1 : 1;
            }

            //Add nút trang đầu.
            if (currentPage > 1)
            {
                pages.Add(new Page { Text = "Trang đầu", Value = "1" });
            }

            //Add nút < 1)
            {
                pages.Add(new Page { Text = "<<", Value = (currentPage - 1).ToString() });
            }

            for (int i = startIndex; i <= endIndex; i++) { pages.Add(new Page { Text = i.ToString(), Value = i.ToString(), Selected = i == currentPage }); } //Add nút >>.
            if (currentPage < pageCount)
            {
                pages.Add(new Page { Text = ">>", Value = (currentPage + 1).ToString() });
            }

            //Add nút Trang cuối.
            if (currentPage != pageCount)
            {
                pages.Add(new Page { Text = "Trang cuối", Value = pageCount.ToString() });
            }

            //Xóa các nút trên trang.
            panel1.Controls.Clear();

            //Lặp và add các Buttons cho trang.
            int count = 0;
            foreach (Page page in pages)
            {
                Button btnPage = new Button();
                btnPage.Location = new System.Drawing.Point(100 * count, 20);
                btnPage.Size = new System.Drawing.Size(100, 50);
                btnPage.Name = page.Value;
                btnPage.Text = page.Text;
                btnPage.Enabled = !page.Selected;
                btnPage.Click += new System.EventHandler(this.Page_Click);
                panel1.Controls.Add(btnPage);
                count++;
            }
        }
        //Viết sự kiện khi kích trên nút phân trang
        private void Page_Click(object sender, EventArgs e)
        {
            Button btnPager = (sender as Button);
            this.LoadData(int.Parse(btnPager.Name));
        }
        //Tạo class Page để lưu trữ các thuộc tính của Page
        public class Page
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public bool Selected { get; set; }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void cbwarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.LoadData(1);
        }

     

        
    }
}
