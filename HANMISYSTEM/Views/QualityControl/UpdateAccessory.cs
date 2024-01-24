using HANMISYSTEM.DAO;
using HANMISYSTEM.Views.Producs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.QualityControl
{
    public partial class UpdateAccessory : Form
    {
        public UpdateAccessory()
        {
            InitializeComponent();
        }
        DAO_Product dAO_Product = new DAO_Product();
        DAO_Accessory_QC dAO_Accessory_QC = new DAO_Accessory_QC();
        DAO_Credential dAO_Credential = new DAO_Credential();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            if (txtPartno.Text.Length > 0)
            {
                DataTable dtProducts = await dAO_Product.Find(txtPartno.Text, null);
                if (dtProducts.Rows.Count > 0)
                {
                    if (dtProducts.Rows.Count == 1)
                    {
                        txtPartName.Text = await dAO_Product.GetPartName(txtPartno.Text);
                        dataGridView1.DataSource = await dAO_Accessory_QC.GetAccessoryByPartNo(txtPartno.Text);
                    }
                    else
                    {
                        Searching frm = new Searching();
                        frm.searchTerm = txtPartno.Text;
                        frm.ShowInTaskbar = false;
                        frm.StartPosition = FormStartPosition.CenterParent;
                        frm.ShowDialog();
                        if (frm.PartNo() != "")
                        {
                            txtPartno.Text = frm.PartNo();
                            txtPartName.Text = await dAO_Product.GetPartName(frm.PartNo());
                            dataGridView1.DataSource = await dAO_Accessory_QC.GetAccessoryByPartNo(frm.PartNo());

                        }
                        else
                        {
                            txtPartno.Text = "";
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy!");
                }
            }
            else
            {
                MessageBox.Show("Điền vào giá trị cần tìm kiếm!");
            }
        }

        private async void txtAccessory_TextChanged(object sender, EventArgs e)
        {
            if (txtAccessory.Text.Length > 0)
            {
                lbSearch.Visible = true;
                lbSearch.Items.Clear();
                DataTable dtsearch = await dAO_Product.Find(txtAccessory.Text, 15);
                if (dtsearch.Rows.Count > 0)
                {
                    for (int i = 0; i < dtsearch.Rows.Count; i++)
                    {
                        lbSearch.Items.Add(dtsearch.Rows[i]["partno"].ToString());
                    }
                }
            }
            else
            {
                lbSearch.Visible = false;
            }

        }

        private void lbSearch_Click(object sender, EventArgs e)
        {
            if (lbSearch.SelectedItem != null)
            {
                txtAccessory.Text = lbSearch.SelectedItem.ToString();
                lbSearch.Visible = false;
            }
        }

        private async void btnADD_Click(object sender, EventArgs e)
        {
            if (await dAO_Credential.CheckCredential("ADD_ACCESSORY_QC"))
            {
                if (txtPartno.Text.Length > 0 && txtAccessory.Text.Length > 0)
                {
                    if (await dAO_Accessory_QC.ADD(txtPartno.Text, txtAccessory.Text))
                    {
                        MessageBox.Show("Them thanh cong");
                        //load accessory
                        dataGridView1.DataSource = await dAO_Accessory_QC.GetAccessoryByPartNo(txtPartno.Text);
                    }
                    else
                    {
                        MessageBox.Show("Them that bai");
                    }
                }
                else
                {
                    MessageBox.Show("Cần điền đẩy đủ các trường");
                }


            }
            else
            {
                MessageBox.Show("You dont have permission!Please contact administrator");
            }

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (await dAO_Credential.CheckCredential("DELETE_ACCESSORY_QC"))
            {
                DialogResult dialogResult = MessageBox.Show("Xac nhan xoa!", "Notify", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    string logs = "";
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Selection_col"].Value))
                        {
                            if (await dAO_Accessory_QC.Delete(txtPartno.Text, row.Cells["Accessory_col"].Value.ToString()))
                            {
                                logs += "xoa thanh cong (" + txtPartno.Text + "," + row.Cells["Accessory_col"].Value.ToString() + ") \n";
                            }

                        }
                    }
                    //load accessory
                    dataGridView1.DataSource = await dAO_Accessory_QC.GetAccessoryByPartNo(txtPartno.Text);
                }
            }
            else
            {
                MessageBox.Show("You dont have permission!Please contact administrator");
            }

        }
    }
}
