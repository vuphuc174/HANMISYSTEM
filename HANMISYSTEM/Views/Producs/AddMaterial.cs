using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Producs
{
    public partial class AddMaterial : Form
    {
        public AddMaterial()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        public string parrent_partno;
        private void btnUpload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load the selected image into the PictureBox
                        pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                        lbPath.Text = openFileDialog.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }
        private bool CheckPartNoExist()
        {
            DataTable dt = connect.readdata("select partno from cargo where partno ='"+txtPartno.Text+"'");
            if(dt.Rows.Count > 0)
            {
                return true;
            }    
            return false;
        }
        string ToVarbinary(byte[] data)
        {
            var sb = new StringBuilder((data.Length * 2) + 2);
            sb.Append("0x");

            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("X2"));
            }

            return sb.ToString();
        }
        private void UpdateProductImage()
        {
            if(lbPath.Text.Length>10)
            {
                try
                {
                    byte[] fileData = File.ReadAllBytes(lbPath.Text);
                    connect.StoreImage(txtPartno.Text, fileData);

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thêm hình ảnh không thành công !Chi tiết: "+ex.Message);
                }
            }
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            if(connect.exedata($"insert into accessory(Partno,Accessory) values('{parrent_partno}','{txtPartno.Text}')"))
            {
                UpdateProductImage();
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
        }

        private void txtPartno_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtPartno.Text))
            {
                lbSearch.Items.Clear();
                lbSearch.Visible = true;
                DataTable dtProducts = connect.readdata("select top 20 partno from cargo where partno like '%" + txtPartno.Text + "%'");
                if (dtProducts.Rows.Count > 0)
                {
                    for (int i = 0; i < dtProducts.Rows.Count; i++)
                    {
                        lbSearch.Items.Add(dtProducts.Rows[i]["partno"]);
                    }
                }
                else
                {
                    lbSearch.Visible = false;
                }
            }
         
        }

        private void lbSearch_Click(object sender, EventArgs e)
        {
            txtPartno.Text = lbSearch.SelectedItem.ToString();
            lbSearch.Visible = false;
        }

        private void AddMaterial_Load(object sender, EventArgs e)
        {

        }
    }
}
