using HANMISYSTEM.Module;
using HANMISYSTEM.Views.BOM;
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
    public partial class BOMList : Form
    {
        public BOMList()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        DataTable dtfg;
        int dtcount;
        private int pagesize = 20;
        private int page = 1;
        private int maxsize;
        private int active;

        private void BOMList_Load(object sender, EventArgs e)
        {
            dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='3' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
            dataGridView1.DataSource = dtfg;
            active = 3;
            btnfg.BackColor = Color.AliceBlue;
            txtpage.Text = page.ToString();
            dtcount = connect.countdata("select count(partno) from cargo where idcategory='3'");
            if (dtcount > 0)
            {
                if (Convert.ToDouble(dtcount % pagesize) > 0)
                {
                    maxsize = dtcount / pagesize + 1;
                }
                else
                {
                    maxsize = dtcount / pagesize;
                }
                llmaxpage.Text = maxsize.ToString();
            }
        }

        private void btnfg_Click(object sender, EventArgs e)
        {
            active = 3;
            txtsearch.Text = "";
            btnsemi.BackColor = Color.White;
            btnraw.BackColor = Color.White;
            btnfg.BackColor = Color.AliceBlue;
            page = 1;
            txtpage.Text = page.ToString();
            dtcount = connect.countdata("select count(partno) from cargo where idcategory='3'");
            if (dtcount > 0)
            {
                if (Convert.ToDouble(dtcount % pagesize) > 0)
                {
                    maxsize = dtcount / pagesize + 1;
                }
                else
                {
                    maxsize = dtcount / pagesize;
                }
                llmaxpage.Text = maxsize.ToString();
            }
            dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='3' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
            dataGridView1.DataSource = dtfg;

        }

        private void btnsemi_Click(object sender, EventArgs e)
        {
            active = 2;
            txtsearch.Text = "";
            btnsemi.BackColor = Color.AliceBlue;
            btnraw.BackColor = Color.White;
            btnfg.BackColor = Color.White;
            page = 1;
            txtpage.Text = page.ToString();
            dtcount = connect.countdata("select count(partno) from cargo where idcategory='2'");
            if (dtcount > 0)
            {
                if (Convert.ToDouble(dtcount % pagesize) > 0)
                {
                    maxsize = dtcount / pagesize + 1;
                }
                else
                {
                    maxsize = dtcount / pagesize;
                }
                llmaxpage.Text = maxsize.ToString();
            }
            dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='2' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
            dataGridView1.DataSource = dtfg;
        }

        private void btnraw_Click(object sender, EventArgs e)
        {
            active = 1;
            txtsearch.Text = "";
            btnsemi.BackColor = Color.White;
            btnraw.BackColor = Color.AliceBlue;
            btnfg.BackColor = Color.White;
            page = 1;
            txtpage.Text = page.ToString();
            dtcount = connect.countdata("select count(partno) from cargo where idcategory='1'");
            if (dtcount > 0)
            {
                if (Convert.ToDouble(dtcount % pagesize) > 0)
                {
                    maxsize = dtcount / pagesize + 1;
                }
                else
                {
                    maxsize = dtcount / pagesize;
                }
                llmaxpage.Text = maxsize.ToString();
            }
            dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='1' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
            dataGridView1.DataSource = dtfg;
        }

        private void btnfirstpage_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text.Length > 0)
            {
                switch (active)
                {
                    case 1:
                        page = 1;
                        txtpage.Text = page.ToString();
                        dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='1' and partno like '%" + txtsearch.Text + "%' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                        dataGridView1.DataSource = dtfg;
                        break;
                    case 2:
                        page = 1;
                        txtpage.Text = page.ToString();
                        dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='2' and partno like '%" + txtsearch.Text + "%') a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                        dataGridView1.DataSource = dtfg;
                        break;
                    case 3:
                        page = 1;
                        txtpage.Text = page.ToString();
                        dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='3' and partno like '%" + txtsearch.Text + "%') a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                        dataGridView1.DataSource = dtfg;
                        break;
                }
            }
            else
            {
                switch (active)
                {
                    case 1:
                        page = 1;
                        txtpage.Text = page.ToString();
                        dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='1' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                        dataGridView1.DataSource = dtfg;
                        break;
                    case 2:
                        page = 1;
                        txtpage.Text = page.ToString();
                        dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='2' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                        dataGridView1.DataSource = dtfg;
                        break;
                    case 3:
                        page = 1;
                        txtpage.Text = page.ToString();
                        dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='3' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                        dataGridView1.DataSource = dtfg;
                        break;
                }
            }

        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if (txtpage.Text != "1")
            {
                if (txtsearch.Text.Length > 0)
                {
                    switch (active)
                    {
                        case 1:
                            page = page - 1;
                            txtpage.Text = page.ToString();
                            dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='1' and partno like '%" + txtsearch.Text + "%') a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                            dataGridView1.DataSource = dtfg;
                            break;
                        case 2:
                            page = page - 1;
                            txtpage.Text = page.ToString();
                            dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='2' and partno like '%" + txtsearch.Text + "%') a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                            dataGridView1.DataSource = dtfg;
                            break;
                        case 3:
                            page = page - 1;
                            txtpage.Text = page.ToString();
                            dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='3' and partno like '%" + txtsearch.Text + "%') a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                            dataGridView1.DataSource = dtfg;
                            break;
                    }
                }
                else
                {
                    switch (active)
                    {
                        case 1:
                            page = page - 1;
                            txtpage.Text = page.ToString();
                            dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='1' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                            dataGridView1.DataSource = dtfg;
                            break;
                        case 2:
                            page = page - 1;
                            txtpage.Text = page.ToString();
                            dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='2' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                            dataGridView1.DataSource = dtfg;
                            break;
                        case 3:
                            page = page - 1;
                            txtpage.Text = page.ToString();
                            dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='3' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                            dataGridView1.DataSource = dtfg;
                            break;
                    }
                }

            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (txtpage.Text != (maxsize).ToString())
            {
                if (txtsearch.Text.Length > 0)
                {
                    switch (active)
                    {
                        case 1:
                            page = page + 1;
                            txtpage.Text = page.ToString();
                            dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='1' and partno like '%" + txtsearch.Text + "%') a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                            dataGridView1.DataSource = dtfg;
                            break;
                        case 2:
                            page = page + 1;
                            txtpage.Text = page.ToString();
                            dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='2' and partno like '%" + txtsearch.Text + "%') a where rowindex >" + ((page - 1) * pagesize) + " and rowindex<" + (page * pagesize + 1) + "");
                            dataGridView1.DataSource = dtfg;
                            break;
                        case 3:
                            page = page + 1;
                            txtpage.Text = page.ToString();
                            dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='3' and partno like '%" + txtsearch.Text + "%') a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                            dataGridView1.DataSource = dtfg;
                            break;
                    }
                }
                else
                {
                    switch (active)
                    {
                        case 1:
                            page = page + 1;
                            txtpage.Text = page.ToString();
                            dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='1' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                            dataGridView1.DataSource = dtfg;
                            break;
                        case 2:
                            page = page + 1;
                            txtpage.Text = page.ToString();
                            dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='2' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex<" + (page * pagesize + 1) + "");
                            dataGridView1.DataSource = dtfg;
                            break;
                        case 3:
                            page = page + 1;
                            txtpage.Text = page.ToString();
                            dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='3' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                            dataGridView1.DataSource = dtfg;
                            break;
                    }
                }

            }
        }

        private void llmaxpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtsearch.Text.Length > 0)
            {
                switch (active)
                {
                    case 1:
                        page = Convert.ToInt32(llmaxpage.Text);
                        txtpage.Text = page.ToString();
                        dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='1' and partno like '%" + txtsearch.Text + "%') a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                        dataGridView1.DataSource = dtfg;
                        break;
                    case 2:
                        page = Convert.ToInt32(llmaxpage.Text);
                        txtpage.Text = page.ToString();
                        dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='2' and partno like '%" + txtsearch.Text + "%') a where rowindex >" + ((page - 1) * pagesize) + " and rowindex<" + (page * pagesize + 1) + "");
                        dataGridView1.DataSource = dtfg;
                        break;
                    case 3:
                        page = Convert.ToInt32(llmaxpage.Text);
                        txtpage.Text = page.ToString();
                        dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='3' and partno like '%" + txtsearch.Text + "%') a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                        dataGridView1.DataSource = dtfg;
                        break;
                }
            }
            else
            {
                switch (active)
                {
                    case 1:
                        page = Convert.ToInt32(llmaxpage.Text);
                        txtpage.Text = page.ToString();
                        dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='1' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                        dataGridView1.DataSource = dtfg;
                        break;
                    case 2:
                        page = Convert.ToInt32(llmaxpage.Text);
                        txtpage.Text = page.ToString();
                        dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='2' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex<" + (page * pagesize + 1) + "");
                        dataGridView1.DataSource = dtfg;
                        break;
                    case 3:
                        page = Convert.ToInt32(llmaxpage.Text);
                        txtpage.Text = page.ToString();
                        dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='3' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                        dataGridView1.DataSource = dtfg;
                        break;
                }
            }

        }
        Isnumber isnum = new Isnumber();
        private void txtpage_TextChanged(object sender, EventArgs e)
        {
            if (isnum.IsNumber(txtpage.Text) == false)
            {
                txtpage.Text = page.ToString();
            }
            else
            {
                if (Convert.ToInt32(txtpage.Text) < 0)
                {
                    txtpage.Text = page.ToString();
                }
                if (Convert.ToInt32(txtpage.Text) > maxsize)
                {
                    txtpage.Text = page.ToString();
                }
            }

        }

        private void txtpage_Enter(object sender, EventArgs e)
        {

        }

        private void txtpage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (active)
                {
                    case 1:
                        page = Convert.ToInt32(txtpage.Text);
                        txtpage.Text = page.ToString();
                        dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='1' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                        dataGridView1.DataSource = dtfg;
                        break;
                    case 2:
                        page = Convert.ToInt32(txtpage.Text);
                        txtpage.Text = page.ToString();
                        dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='2' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex<" + (page * pagesize + 1) + "");
                        dataGridView1.DataSource = dtfg;
                        break;
                    case 3:
                        page = Convert.ToInt32(txtpage.Text);
                        txtpage.Text = page.ToString();
                        dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='3' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                        dataGridView1.DataSource = dtfg;
                        break;
                }
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            switch (active)
            {
                case 1:
                    page = 1;
                    dtcount = connect.countdata("select count(partno) from cargo where idcategory='1' and partno like '%" + txtsearch.Text + "%'");
                    if (dtcount > 0)
                    {
                        if (Convert.ToDouble(dtcount % pagesize) > 0)
                        {
                            maxsize = dtcount / pagesize + 1;
                        }
                        else
                        {
                            maxsize = dtcount / pagesize;
                        }
                        llmaxpage.Text = maxsize.ToString();
                    }
                    txtpage.Text = page.ToString();
                    dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='1' and partno like '%" + txtsearch.Text + "%' ) a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                    dataGridView1.DataSource = dtfg;
                    break;
                case 2:
                    page = 1;
                    txtpage.Text = page.ToString();
                    dtcount = connect.countdata("select count(partno) from cargo where idcategory='2' and partno like '%" + txtsearch.Text + "%'");
                    if (dtcount > 0)
                    {
                        if (Convert.ToDouble(dtcount % pagesize) > 0)
                        {
                            maxsize = dtcount / pagesize + 1;
                        }
                        else
                        {
                            maxsize = dtcount / pagesize;
                        }
                        llmaxpage.Text = maxsize.ToString();
                    }
                    dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='2' and partno like '%" + txtsearch.Text + "%') a where rowindex >" + ((page - 1) * pagesize) + " and rowindex<" + (page * pagesize + 1) + "");
                    dataGridView1.DataSource = dtfg;
                    break;
                case 3:
                    page = 1;
                    txtpage.Text = page.ToString();
                    dtcount = connect.countdata("select count(partno) from cargo where idcategory='3' and partno like '%" + txtsearch.Text + "%'");
                    if (dtcount > 0)
                    {
                        if (Convert.ToDouble(dtcount % pagesize) > 0)
                        {
                            maxsize = dtcount / pagesize + 1;
                        }
                        else
                        {
                            maxsize = dtcount / pagesize;
                        }
                        llmaxpage.Text = maxsize.ToString();
                    }
                    dtfg = connect.readdata("select a.* from (select ROW_NUMBER() over(order by partno desc) as rowindex,partno,partname,isnull((select name from bomprocess where id=c.processID),'OUTSOURCE') as process,(select count(partno) from bom where partno =c.partno) as rawquantity from cargo c where idcategory='3' and partno like '%" + txtsearch.Text + "%') a where rowindex >" + ((page - 1) * pagesize) + " and rowindex <" + (page * pagesize + 1) + "");
                    dataGridView1.DataSource = dtfg;
                    break;
            }
        }
        private int id;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenu ctx = new ContextMenu();

            MenuItem mItem1 = new MenuItem();
            mItem1.Text = "Quy trình tiếp theo";
            mItem1.Click += new System.EventHandler(this.menuItem1_Click);
            ctx.MenuItems.Add(mItem1);

            MenuItem mItem2 = new MenuItem();
            mItem2.Text = "Quy trình trước đó";
            mItem2.Click += new System.EventHandler(this.menuItem2_Click);
            ctx.MenuItems.Add(mItem2);
            

            MenuItem mItem3 = new MenuItem();
            mItem3.Text = "Danh sách nguyên vật liệu";
            mItem3.Click += new System.EventHandler(this.menuItem3_Click);
            ctx.MenuItems.Add(mItem3);

            MenuItem mItem4 = new MenuItem();
            mItem4.Text = "Chỉnh sửa BOM";
            mItem4.Click += new System.EventHandler(this.menuItem4_Click);
            ctx.MenuItems.Add(mItem4);

            id = dataGridView1.HitTest(e.X, e.Y).RowIndex;

            if (e.Button == MouseButtons.Right)
            {
                Point pt = new Point(e.X, e.Y);
                ctx.Show(dataGridView1, pt);
            }
        }
        //quy trinh tiep theo
        public void menuItem1_Click(object sender, System.EventArgs e)
        {
            BOMDetail fr = new BOMDetail();
            fr.lbpartno.Text = dataGridView1.Rows[id].Cells["partno"].Value.ToString();
            DataTable dtprocess = connect.readdata("select isnull(Name,'OUTSOURCE') as name from BomProcess where ID=isnull((select ProcessID from cargo where partno ='" + fr.lbpartno.Text + "'),5)");
            fr.lbprocess.Text = dtprocess.Rows[0]["name"].ToString();
            //fr.dtbom = connect.readdata("select rawpartno,quantity,(select partname from cargo where partno =b.rawpartno) as partname,isnull((select nameunit from unit where idunit=(select idunit from cargo where partno =b.rawpartno) ),'EA') as unit,isnull((select Sum(Quantity) from packinginfo where partno=b.rawpartno and idwarehouse='WH002'),'0') as Inventory from bom b where partno='"+fr.lbpartno.Text+"'");
            fr.dtbom = connect.readdata("select partno as rawpartno,(select partname from cargo where partno=bom.partno) as partname,quantity,isnull((select SUM(quantity) from packinginfo where partno=bom.partno),0) as inventory,(select nameunit from unit where idunit =(select idunit from cargo where partno=bom.partno)) as unit from bom where rawpartno ='"+fr.lbpartno.Text+"'");
            fr.dataGridView1.DataSource = fr.dtbom;
            fr.Show();
        }
        
        //quy trinh truoc
        public void menuItem2_Click(object sender, System.EventArgs e)
        {
            BOMDetail fr = new BOMDetail();
            fr.lbpartno.Text = dataGridView1.Rows[id].Cells["partno"].Value.ToString();
            DataTable dtprocess = connect.readdata("select isnull(Name,'OUTSOURCE') as name from BomProcess where ID=isnull((select ProcessID from cargo where partno ='"+fr.lbpartno.Text+"'),5)");
            fr.lbprocess.Text = dtprocess.Rows[0]["name"].ToString();
            //fr.dtbom = connect.readdata("select rawpartno,quantity,(select partname from cargo where partno =b.rawpartno) as partname,isnull((select nameunit from unit where idunit=(select idunit from cargo where partno =b.rawpartno) ),'EA') as unit,isnull((select Sum(Quantity) from packinginfo where partno=b.rawpartno and idwarehouse='WH002'),'0') as Inventory from bom b where partno='"+fr.lbpartno.Text+"'");
            fr.dtbom = connect.readdata("WITH RPL(LEVEL, PART, SUBPART, SUB, QUANTITY, Orderpath) AS(SELECT 1, ROOT.partno, ROOT.rawpartno, convert(varchar(MAX), ROOT.rawpartno) sub, ROOT.QUANTITY, CONVERT(VARCHAR(MAX), ROOT.rawpartno) OrderPath FROM bom ROOT where ROOT.partno = '"+fr.lbpartno.Text+"' UNION ALL SELECT PARENT.LEVEL + 1, CHILD.partno, CHILD.rawpartno, REPLACE(PARENT.SUB, PARENT.SUB, REPLICATE('        ', PARENT.LEVEL) + CHILD.rawpartno), CHILD.QUANTITY, PARENT.Orderpath + PARENT.SUBPART + CHILD.rawpartno FROM RPL PARENT, bom CHILD WHERE PARENT.SUBPART = LTRIM(CHILD.partno)) SELECT  SUB as rawpartno, LEVEL, (select partname from cargo c where c.partno = RPL.SUBPART) as partname,(select nameunit from unit where idunit = (select idunit from cargo c where c.partno = RPL.SUBPART))as unit, isnull((select SUM(quantity) from packinginfo where partno = RPL.SUBPART),'0') as Inventory, QUANTITY FROM RPL order by Orderpath; ");
            fr.dataGridView1.DataSource = fr.dtbom;
            fr.Show();
        }
        //tat ca nguyen vat lieu
        public void menuItem3_Click(object sender, System.EventArgs e)
        {
            BOMDetail fr = new BOMDetail();
            fr.btnactive.Enabled = false;
            fr.lbpartno.Text = dataGridView1.Rows[id].Cells["partno"].Value.ToString();
            DataTable dtprocess = connect.readdata("select isnull(Name,'OUTSOURCE') as name from BomProcess where ID=isnull((select ProcessID from cargo where partno ='" + fr.lbpartno.Text + "'),5)");
            fr.lbprocess.Text = dtprocess.Rows[0]["name"].ToString();
            fr.dtbom = connect.readdata("with temp(partno,rawpartno,quantity) as (select partno,rawpartno,quantity from bom  where partno='"+fr.lbpartno.Text+"' union all select a.partno,b.rawpartno,a.quantity*b.quantity  from temp as a, bom as b where a.rawpartno=b.partno )  select  rawpartno, (select partname from cargo c where c.partno =temp1.rawpartno) as partname, (select nameunit from unit inner join cargo on unit.idunit=cargo.idunit where cargo.partno=temp1.rawpartno) as unit,SUM(quantity) as quantity,isnull((select SUM(quantity) from packinginfo where partno=temp1.rawpartno),'0') as Inventory from (select   * from temp t1  where (select count(rawpartno) from  bom b1 where t1.rawpartno=b1.partno ) =0) as temp1  inner join cargo c1 on temp1.partno=c1.partno group by temp1.partno,rawpartno order by temp1.partno asc");
            fr.dataGridView1.DataSource = fr.dtbom;
            fr.Show();
        }
        //Chỉnh sửa BOM
        public void menuItem4_Click(object sender, System.EventArgs e)
        {
            DataTable dtmodel = connect.readdata("select partname,isnull((select Name from BomProcess where ID =cargo.ProcessID),'OutSource') as Process from cargo where partno='"+ dataGridView1.Rows[id].Cells["partno"].Value.ToString() + "'");
            EditBOM fr = new EditBOM();
            fr.txtpartno.Text = dataGridView1.Rows[id].Cells["partno"].Value.ToString();
            if(dtmodel.Rows.Count>0)
            {
                fr.lbpartname.Text = dtmodel.Rows[0]["partname"].ToString();
                fr.lbprocess.Text= dtmodel.Rows[0]["Process"].ToString();
                fr.Show();
            }
            fr.dtbom = connect.readdata("select rawpartno,(select partname from cargo where partno=bom.rawpartno) as partname,(select nameunit from unit where idunit =(select idunit from cargo where partno =bom.rawpartno)) as unit,quantity,(select Name from BomProcess where ID =(select ProcessID from cargo where partno=bom.rawpartno)) as Process from bom where partno='"+fr.txtpartno.Text+"'");
            fr.dataGridView1.DataSource = fr.dtbom;
        }
    }
}
