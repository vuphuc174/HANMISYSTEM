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
    public partial class StockFollowLoction : Form
    {
        public StockFollowLoction()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private async Task LoadData(string whLabel)
        {
            try
            {
                string cmd = $"select pi.idpack,pi.partno,c.partname,pi.quantity,pi.packingdate from packinginfo pi inner join cargo c on pi.partno =c.partno where pi.idwarehouse ='WH002' and position ='{whLabel}' order by packingdate desc";
                DataTable dt = await connect.ReadDataAsync(cmd);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private int GetWarehouseLabelSum()
        {
            try
            {
                DataTable dt = connect.readdata("select count(*) as qty from position where idwarehouse ='WH002'");
                return Convert.ToInt32(dt.Rows[0]["qty"].ToString());
            }
            catch
            {
                return 0;
            }
        }
        private void StockFollowLoction_Load(object sender, EventArgs e)
        {
            DataTable dtwarehouse = connect.readdata("select * from warehouse where  idwarehouse ='WH002'");
            cbwarehouse.DataSource = dtwarehouse;
            cbwarehouse.ValueMember = "idwarehouse";
            cbwarehouse.DisplayMember = "namewarehouse";

            DataTable dtWarehouseLabel = connect.readdata("select top 29 position,COUNT(idpack) as c from packinginfo where idwarehouse ='WH002' and position <> '' group by position order by c desc");
            for(int i=0;i<dtWarehouseLabel.Rows.Count;i++)
            {
                Label item =new Label();
                item.Text = dtWarehouseLabel.Rows[i]["position"].ToString() +"("+ dtWarehouseLabel.Rows[i]["c"].ToString() +")";
                item.BackColor =ColorTranslator.FromHtml(Themes.Dark_Theme.bg_label) ;
                item.ForeColor = ColorTranslator.FromHtml(Themes.Dark_Theme.label_color);
                item.Click += new EventHandler(btnViewWarehouseLabel_CLick);
                item.Margin = new Padding(5);
                item.Padding = new Padding(5);
               
                item.AutoSize = true;
                item.TextAlign=ContentAlignment.MiddleCenter;
                //item.Dock = DockStyle.Left;
                flpWarehouseLabel.Controls.Add(item);
            }
            Label loadALL = new Label();
            loadALL.Name = "loadALl";
            loadALL.Text = "Xem tất cả";
            loadALL.BackColor = ColorTranslator.FromHtml(Themes.Dark_Theme.bg_label);
            loadALL.ForeColor = ColorTranslator.FromHtml(Themes.Dark_Theme.label_color);

            loadALL.Margin = new Padding(5);
            loadALL.Padding = new Padding(5);

            loadALL.AutoSize = true;
            loadALL.TextAlign = ContentAlignment.MiddleCenter;
            loadALL.Click += new EventHandler(btnLoadALL_CLick);
            flpWarehouseLabel.Controls.Add(loadALL);
        }
        private void btnLoadALL_CLick(object sender,EventArgs e)
        {
            string cmd = "with temp as (select *,ROW_NUMBER() over(order by c desc) as r from(select position, COUNT(idpack) as c from packinginfo where idwarehouse = 'WH002' and position <> '' group by position) as sub) select* from temp where r > 29";
            DataTable dtWarehouseLabel = connect.readdata(cmd);
            for (int i = 0; i < dtWarehouseLabel.Rows.Count; i++)
            {
                Label item = new Label();
                item.Text = dtWarehouseLabel.Rows[i]["position"].ToString() + "(" + dtWarehouseLabel.Rows[i]["c"].ToString() + ")";
                item.BackColor = ColorTranslator.FromHtml(Themes.Dark_Theme.bg_label);
                item.ForeColor = ColorTranslator.FromHtml(Themes.Dark_Theme.label_color);
                item.Click += new EventHandler(btnViewWarehouseLabel_CLick);
                item.Margin = new Padding(5);
                item.Padding = new Padding(5);

                item.AutoSize = true;
                item.TextAlign = ContentAlignment.MiddleCenter;
                //item.Dock = DockStyle.Left;
                flpWarehouseLabel.Controls.Add(item);
            }
            Control[] foundControls =flpWarehouseLabel.Controls.Find("loadAll", true);
            if (foundControls.Length > 0)
            {
                // You found the control, and you can access it using foundControls[0]
                Control foundControl = foundControls[0];
                foundControl.Visible = false;
                // Do something with the found control
            }
        }
        private async void btnViewWarehouseLabel_CLick(object sender, EventArgs e)
        {
            string whLabel = ((Label)sender).Text;
            whLabel = whLabel.Substring(0,whLabel.IndexOf("("));
            lbWarehouseLabel.Text = whLabel;
            await LoadData(whLabel);
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

            }
        }

        
        private void cbwarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtsearch.Text.ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool rowContainsSearchTerm = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm))
                    {
                        rowContainsSearchTerm = true;
                        break;
                    }
                }

                row.Visible = rowContainsSearchTerm;
            }
        }
    }
}
