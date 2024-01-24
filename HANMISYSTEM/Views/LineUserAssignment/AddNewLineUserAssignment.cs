using HANMISYSTEM.DAO;
using HANMISYSTEM.Views.Line;
using HANMISYSTEM.Views.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.LineUserAssignment
{
    public partial class AddNewLineUserAssignment : Form
    {
        public AddNewLineUserAssignment()
        {
            InitializeComponent();
        }
        DAO_Line dAO_Line = new DAO_Line();
        DAO_User dAO_User = new DAO_User();
        DAO_LineUserAssignment dAO_LineUserAssignment = new DAO_LineUserAssignment();
        private void AddNewLineUserAssignment_Load(object sender, EventArgs e)
        {

        }

        private void btnUserSearch_Click(object sender, EventArgs e)
        {
            using (UserSearch frm = new UserSearch())
            {
                frm.ShowInTaskbar = false;
                frm._group = "PROD_MEMBER";
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
                txtUserList.Text = frm.GetUsers();
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLineSearch_Click(object sender, EventArgs e)
        {
            using(LineSearch frm =new LineSearch())
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowInTaskbar = false;
                frm.ShowDialog();
                txtLineID.Text = frm.GetLineID();
            }
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            string note="";
            if(!await dAO_Line.CheckExist(txtLineID.Text))
            {
                MessageBox.Show("Mã chuyền không hợp lệ");
            }
            else
            {
                if (txtUserList.Text == "")
                {
                    MessageBox.Show("Trường user rỗng !");
                }
                else
                {
                    string[] users = txtUserList.Text.Split(';');
                    for (int i = 0; i < users.Length; i++)
                    {
                        if (!await dAO_User.CheckExisted(users[i]))
                        {
                            //save issue
                            note += "user không tồn tại (" + users[i] + ")";
                        }
                        else
                        {
                            if (await dAO_LineUserAssignment.CheckExisted(txtLineID.Text, users[i]))
                            {
                                //save issue
                                note += "Phân công đã tồn tại +(" + txtLineID.Text + "," + users[i] + ")";
                            }
                            else
                            {
                                await dAO_LineUserAssignment.AddNew(txtLineID.Text, users[i]);
                            }
                        }
                    }
                    if (note == "")
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                    {
                        MessageBox.Show(note);
                    }    
                    this.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
