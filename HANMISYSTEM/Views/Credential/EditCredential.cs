using HANMISYSTEM.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Credential
{
    public partial class EditCredential : Form
    {
        public EditCredential()
        {
            InitializeComponent();
        }
        DAO_UserGroup dAO_UserGroup = new DAO_UserGroup();
        public string _roleID;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCredential_Load(object sender, EventArgs e)
        {
            txtRoleID.Text = _roleID;
        }
        //private string FindSearchTerm(string data)
        //{
        //    if()
        //}
        private async void btnCheckID_Click(object sender, EventArgs e)
        {
            string data = txtGroups.Text;
            DataTable dtgroup = await dAO_UserGroup.FindGroupByID(data);
            if(dtgroup.Rows.Count>0)
            {
                if (dtgroup.Rows.Count >=1)
                {

                    //string tmp= dtgroup.Rows[0]["ID"].ToString();
                    //txtGroups.Text += tmp;
                    using(MultipleGroupNamesFound frm =new MultipleGroupNamesFound())
                    {
                        frm.ShowInTaskbar = false;
                        frm.StartPosition=FormStartPosition.CenterScreen;
                        frm._searchTerm = data;
                        frm.ShowDialog();
                    }
                }
                else
                {

                }
            }
        }

        private void txtGroups_TextChanged(object sender, EventArgs e)
        {
            if(txtGroups.Text.Length>0)
            {
                btnCheckID.Enabled = true;
                btnOK.Enabled = true;
            }
            else

            {
                btnCheckID.Enabled = false;
                btnOK.Enabled = false;

            }
        }
    }
}
