using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Accessory
{
    public partial class LayoutSetting : Form
    {
        public LayoutSetting()
        {
            InitializeComponent();
        }

        private void LayoutSetting_Load(object sender, EventArgs e)
        {
            string ag_width = string.IsNullOrEmpty(HANMISYSTEM.Properties.Settings.Default.accessory_group_width) ? "150" : HANMISYSTEM.Properties.Settings.Default.accessory_group_width;
            string ag_height = string.IsNullOrEmpty(HANMISYSTEM.Properties.Settings.Default.accessory_group_height) ? "200" : HANMISYSTEM.Properties.Settings.Default.accessory_group_height;
            string al_height = string.IsNullOrEmpty(HANMISYSTEM.Properties.Settings.Default.accessory_label_height) ? "30" : HANMISYSTEM.Properties.Settings.Default.accessory_label_height;
            string ai_height = string.IsNullOrEmpty(HANMISYSTEM.Properties.Settings.Default.accessory_image_height) ? "60" : HANMISYSTEM.Properties.Settings.Default.accessory_image_height;

            txtGroupHeight.Text = ag_height;
            txtGroupWidth.Text = ag_width;
            txtLabelHeight.Text = al_height;
            txtImageHeight.Text = ai_height;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                HANMISYSTEM.Properties.Settings.Default.accessory_group_width = txtGroupWidth.Text;
                HANMISYSTEM.Properties.Settings.Default.accessory_group_height = txtGroupHeight.Text;
                HANMISYSTEM.Properties.Settings.Default.accessory_label_height = txtLabelHeight.Text;
                HANMISYSTEM.Properties.Settings.Default.accessory_image_height = txtImageHeight.Text;
                HANMISYSTEM.Properties.Settings.Default.Save();
                this.Close();
                //DialogResult result;
                //result = MessageBox.Show("Khởi động lại ứng dụng để áp dụng thay đổi", "Thông báo", MessageBoxButtons.YesNo);
                //if (result == DialogResult.Yes)
                //{
                //    Application.Restart();
                //}
                //else
                //{
                //    this.Close();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
