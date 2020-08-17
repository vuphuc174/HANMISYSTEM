using HANMISYSTEM.Views;
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
    public partial class Usermgt : Form
    {
        public Usermgt()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void loaddata(string sql)
        {
            DataTable dtload = connect.readdata(sql);
            try
            {
                dataGridView1.DataSource = dtload;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Usermgt_Load(object sender, EventArgs e)
        {
            loaddata("select username,name,(select namewarehouse from warehouse w where w.idwarehouse=u.idwarehouse) as namewarehouse,(select nameposition from user_position p where p.idposition =u.idposition) as nameposition from  tbl_user u");
            DataTable dtwarehouse = connect.readdata("select idwarehouse,namewarehouse from warehouse where idcategory ='W1' or idcategory ='W2'");
            cbdepartment.DataSource = dtwarehouse;
            cbdepartment.DisplayMember = "namewarehouse";
            cbdepartment.ValueMember = "idwarehouse";

            DataTable dtposition = connect.readdata("select * from user_position");
            cbposition.DataSource = dtposition;
            cbposition.DisplayMember = "nameposition";
            cbposition.ValueMember = "idposition";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex !=-1)
            {
                txtusername.Text = dataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString();
                txtname.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                cbdepartment.Text = dataGridView1.Rows[e.RowIndex].Cells["namewarehouse"].Value.ToString();
                cbposition.Text = dataGridView1.Rows[e.RowIndex].Cells["nameposition"].Value.ToString();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(txtusername.Text==""  || txtname.Text=="")
            {
                MessageBox.Show("Không được bỏ trống thông tin");
            }
            else
            {
                if(connect.countdata("select count(username) from tbl_user where username ='"+txtusername.Text+"'")!=0)
                {
                    MessageBox.Show("Tải khoản đã tồn tại ");
                }
                else
                {
                    if(connect.exedata("insert into tbl_user (username,password,name,idwarehouse,idposition) values ('"+txtusername.Text+"','"+txtpassword.Text+"','"+txtname.Text+"','"+cbdepartment.SelectedValue.ToString()+"','"+cbposition.SelectedValue.ToString()+"')")==true)
                    {
                        MessageBox.Show("Thành công");
                        txtusername.Text = "";
                        txtpassword.Text = "";
                        txtname.Text = "";
                        loaddata("select username,name,(select namewarehouse from warehouse w where w.idwarehouse=u.idwarehouse) as namewarehouse,(select nameposition from user_position p where p.idposition =u.idposition) as nameposition from  tbl_user u");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtusername.Text==""  || txtname.Text=="")
            {
                MessageBox.Show("Không được bỏ trống thông tin");
            }
            else
            {
                if(connect.countdata("select count(username) from tbl_user where username ='"+txtusername.Text+"'")==0)
                {
                    MessageBox.Show("Tải khoản chưa đã tồn tại ");
                }
                else
                {
                    if (connect.exedata("update tbl_user set name='"+txtname.Text+"' ,password='"+txtpassword.Text+"' ,idwarehouse='"+cbdepartment.SelectedValue.ToString()+"' ,idposition ='"+cbposition.SelectedValue.ToString()+"' where username ='"+txtusername.Text+"'") == true)
                    {
                        MessageBox.Show("Thành công");
                        txtusername.Text = "";
                        txtpassword.Text = "";
                        txtname.Text = "";
                        loaddata("select username,name,(select namewarehouse from warehouse w where w.idwarehouse=u.idwarehouse) as namewarehouse,(select nameposition from user_position p where p.idposition =u.idposition) as nameposition from  tbl_user u");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
        }
        private string sql;
        private void btndelete_Click(object sender, EventArgs e)
        {
            sql = "";
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if(Convert.ToBoolean(row.Cells[0].Value))
                {
                    if (sql == "")
                    {
                        sql = sql + "'" + row.Cells["username"].Value.ToString() + "'";
                    }
                    else
                    {
                        sql = sql + "or username= '" + row.Cells["username"].Value.ToString() + "'";
                    }
                }
            }
            if(connect.exedata("delete from tbl_user where username ="+sql+"")==true)
            {
            }
            else
            {
                MessageBox.Show("ko ok");
            }
            loaddata("select username,name,(select namewarehouse from warehouse w where w.idwarehouse=u.idwarehouse) as namewarehouse,(select nameposition from user_position p where p.idposition =u.idposition) as nameposition from  tbl_user u");
        }
        private int id;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenu ctx = new ContextMenu();

            MenuItem mItem1 = new MenuItem();
            mItem1.Text = "Tùy chỉnh kho nhập";
            mItem1.Click += new System.EventHandler(this.menuItem1_Click);
            ctx.MenuItems.Add(mItem1);

            MenuItem mItem2 = new MenuItem();
            mItem2.Text = "Tùy chỉnh kho xuất";
            mItem2.Click += new System.EventHandler(this.menuItem2_Click);
            ctx.MenuItems.Add(mItem2);

            MenuItem mItem3 = new MenuItem();
            mItem3.Text = "Tùy chỉnh nhà cung cấp";
            mItem3.Click += new System.EventHandler(this.menuItem3_Click);
            ctx.MenuItems.Add(mItem3);


            id = dataGridView1.HitTest(e.X, e.Y).RowIndex;

            if (e.Button == MouseButtons.Right)
            {
                Point pt = new Point(e.X, e.Y);
                ctx.Show(dataGridView1, pt);
            }
        }
        user_permission fr = new user_permission();
        user_e_permission fr1 = new user_e_permission();
        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            fr.dataGridView1.Rows.Clear();
            fr.lbusername.Text = dataGridView1.Rows[id].Cells["username"].Value.ToString();
            CheckBox ck = new CheckBox();
            if (id != -1)
            {
                DataTable dtwarehouse = connect.readdata("Select namewarehouse,idwarehouse from warehouse where idcategory ='W1' or idcategory='W2'  ");
                for (int i = 0; i < dtwarehouse.Rows.Count; i++)
                {
                    if(connect.countdata("select count(username) from tbl_user_permission where username ='"+dataGridView1.Rows[id].Cells["username"].Value.ToString()+"' and idwarehouse= '"+dtwarehouse.Rows[i]["idwarehouse"].ToString()+"'")==0)
                    {
                        fr.dataGridView1.Rows.Add(false,dtwarehouse.Rows[i]["idwarehouse"].ToString(), dtwarehouse.Rows[i]["namewarehouse"].ToString());
                    }
                    else
                    {
                        fr.dataGridView1.Rows.Add(true,dtwarehouse.Rows[i]["idwarehouse"].ToString(), dtwarehouse.Rows[i]["namewarehouse"].ToString());
                    }
                    
                }
                
                fr.ShowDialog();
            }


        }
        private void menuItem2_Click(object sender, System.EventArgs e)
        {
            fr1.dataGridView1.Rows.Clear();
            fr1.lbusername.Text = dataGridView1.Rows[id].Cells["username"].Value.ToString();
            CheckBox ck = new CheckBox();
            if (id != -1)
            {
                DataTable dtwarehouse = connect.readdata("Select namewarehouse,idwarehouse from warehouse ");
                for (int i = 0; i < dtwarehouse.Rows.Count; i++)
                {
                    if (connect.countdata("select count(username) from tbl_user_e_permission where username ='" + dataGridView1.Rows[id].Cells["username"].Value.ToString() + "' and idwarehouse= '" + dtwarehouse.Rows[i]["idwarehouse"].ToString() + "'") == 0)
                    {
                        fr1.dataGridView1.Rows.Add(false, dtwarehouse.Rows[i]["idwarehouse"].ToString(), dtwarehouse.Rows[i]["namewarehouse"].ToString());
                    }
                    else
                    {
                        fr1.dataGridView1.Rows.Add(true, dtwarehouse.Rows[i]["idwarehouse"].ToString(), dtwarehouse.Rows[i]["namewarehouse"].ToString());
                    }

                }

                fr1.ShowDialog();
            }


        }
        user_supplier_permission fr2 = new user_supplier_permission();
        private void menuItem3_Click(object sender, System.EventArgs e)
        {
            fr2.dataGridView1.Rows.Clear();
            fr2.lbusername.Text = dataGridView1.Rows[id].Cells["username"].Value.ToString();
            CheckBox ck = new CheckBox();
            if (id != -1)
            {
                DataTable dtwarehouse = connect.readdata("Select namewarehouse,idwarehouse from warehouse ");
                for (int i = 0; i < dtwarehouse.Rows.Count; i++)
                {
                    if (connect.countdata("select count(username) from tbl_user_supplier_permission where username ='" + dataGridView1.Rows[id].Cells["username"].Value.ToString() + "' and idwarehouse= '" + dtwarehouse.Rows[i]["idwarehouse"].ToString() + "'") == 0)
                    {
                        fr2.dataGridView1.Rows.Add(false, dtwarehouse.Rows[i]["idwarehouse"].ToString(), dtwarehouse.Rows[i]["namewarehouse"].ToString());
                    }
                    else
                    {
                        fr2.dataGridView1.Rows.Add(true, dtwarehouse.Rows[i]["idwarehouse"].ToString(), dtwarehouse.Rows[i]["namewarehouse"].ToString());
                    }

                }

                fr2.ShowDialog();
            }


        }
    }
}
