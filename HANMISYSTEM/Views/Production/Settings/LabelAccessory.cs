using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Production.Settings
{
    public partial class LabelAccessory : Form
    {
        public LabelAccessory()
        {
            InitializeComponent();
        }
        Dbconnect dbconnect = new Dbconnect();
        private void txtParentPart_TextChanged(object sender, EventArgs e)
        {
            lbParent.Items.Clear();
            if (txtParentPart.Text.Length > 0)
            {
                lbParent.Visible = true;
                DataTable dataTable = dbconnect.readdata("Select top 10 partno from cargo where partno like '%" + txtParentPart.Text + "%'");
                if (dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        lbParent.Items.Add(dataTable.Rows[i]["partno"].ToString());
                    }
                }
            }
            else
            {
                lbParent.Visible = false;
            }

        }

        private void lbParent_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void lbParent_Click(object sender, EventArgs e)
        {
            txtParentPart.Text = lbParent.SelectedItem.ToString();
            LoadAccessory();
            lbParent.Visible = false;
        }

        private void txtChildPart_TextChanged(object sender, EventArgs e)
        {
            lbChildPart.Items.Clear();
            if (txtParentPart.Text.Length > 0)
            {
                lbChildPart.Visible = true;
                DataTable dataTable = dbconnect.readdata("Select top 10 partno from cargo where partno like '%" + txtChildPart.Text + "%'");
                if (dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        lbChildPart.Items.Add(dataTable.Rows[i]["partno"].ToString());
                    }
                }
            }
            else
            {
                lbChildPart.Visible = false;
            }
        }

        private void lbChildPart_Click(object sender, EventArgs e)
        {
            txtChildPart.Text = lbChildPart.SelectedItem.ToString();
            lbChildPart.Visible = false;
        }
        private void LoadAccessory()
        {
            DataTable dt = dbconnect.readdata("select LabelAccessory from LabelAccessory where LabelPartNo ='"+txtParentPart.Text+"'");
            dataGridView1.DataSource = dt;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckValid())
            {
                try
                {
                    dbconnect.exedata("Insert into LabelAccessory(LabelPartNo,LabelAccessory) values('" + txtParentPart.Text + "','" + txtChildPart.Text + "')");
                    MessageBox.Show("Thêm thành công");
                    LoadAccessory();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thành công (Err: " + ex.Message + ")");
                }
            }
            else
            {
                MessageBox.Show("Thông tin đầu vào không hợp lệ hoặc đã tồn tại");
            }
        }
        private bool CheckValid()
        {
            DataTable dt = dbconnect.readdata("select * from LabelAccessory where LabelPartNo ='" + txtParentPart.Text + "'");
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            if (string.IsNullOrEmpty(txtParentPart.Text) || string.IsNullOrEmpty(txtChildPart.Text))
            {
                return false;
            }
            if (txtParentPart.Text == txtChildPart.Text)
            {
                return false;
            }
            return true;

        }

        private void btnRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                dbconnect.exedata("delete from LabelAccessory where LabelPartNo ='"+txtParentPart.Text+"'");
                MessageBox.Show("Xoá thành công");
                LoadAccessory();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xoá không thành công ,err: " +ex.Message);
            }
        }
    }
}
