using HANMISYSTEM.Common;
using HANMISYSTEM.DAO;
using HANMISYSTEM.Views.PartialView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.QualityControl
{
    public partial class InspectorLabelWifi : Form
    {
        public InspectorLabelWifi()
        {
            InitializeComponent();
        }
        private static InspectorLabelWifi instance;
        public static InspectorLabelWifi Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new InspectorLabelWifi();

                return instance;
            }
        }
        DAO_Inspector_MAC_Address dAO_Inspector_MAC_Address = new DAO_Inspector_MAC_Address();
        public string departmentID;
        static string GetStringAfterCharacter(string input, char delimiter)
        {
            int index = input.IndexOf(delimiter);

            if (index >= 0)
            {
                // Use Substring to get the part of the string after the delimiter
                return input.Substring(index + 1);
            }

            // If the delimiter is not found, return the original string or handle as needed
            return input;
        }
        private async void txtScan_KeyPress(object sender, KeyPressEventArgs e)
        {

            //mac=147F67C0A058
            if (e.KeyChar == 13)
            {
                try
                {
                    if(txtScan.Text.Length!=16)
                    {
                        using (Notify frm = new Notify())
                        {
                            frm.content = $"Độ dài mã không hợp lệ ({txtScan.Text.Length})";
                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        if (ContainsSpecialCharacters(GetStringAfterCharacter(txtScan.Text, '=')))
                        {
                            //MessageBox.Show("có ký tự đặc biệt");
                            using (Notify frm = new Notify())
                            {
                                frm.content = "có ký tự đặc biệt";
                                frm.ShowDialog();
                            }
                            lbLogs.Items.Add("Có chứa ký tự đặc biệt---->" + txtScan.Text);
                            dataGridView1.Rows.Add(dataGridView1.Rows.Count, txtScan.Text, DateTime.Now.ToString(), "NG");
                            await dAO_Inspector_MAC_Address.Add(txtScan.Text, departmentID, 0, "", "Có chứa ký tự đặc biệt---->" + txtScan.Text,UserSession.PartNo_Packing);


                        }
                        else
                        {
                            if (await dAO_Inspector_MAC_Address.CheckDuplicate(txtScan.Text, departmentID))
                            {
                                //MessageBox.Show("Lỗi trùng lặp---->" + txtScan.Text);
                                using (Notify frm = new Notify())
                                {
                                    frm.content = "Lỗi trùng lặp---->" + txtScan.Text;
                                    frm.ShowDialog();
                                }
                                dataGridView1.Rows.Add(dataGridView1.Rows.Count, txtScan.Text, DateTime.Now.ToString(), "NG");
                                await dAO_Inspector_MAC_Address.Add(txtScan.Text, departmentID, 0, "", "Lỗi trùng lặp---->" + txtScan.Text,UserSession.PartNo_Packing);
                            }
                            else
                            {

                                dataGridView1.Rows.Add(dataGridView1.Rows.Count, txtScan.Text, DateTime.Now.ToString(), "OK");
                                await dAO_Inspector_MAC_Address.Add(txtScan.Text, departmentID, 1, "", "",UserSession.PartNo_Packing);
                            }
                        }
                    }
                    
                    txtOK.Text = await dAO_Inspector_MAC_Address.GetOK(departmentID);
                    txtNG.Text = await dAO_Inspector_MAC_Address.GetNG(departmentID);
                    txtScan.Text = "";
                    txtScan.Focus();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
        }
        static bool ContainsSpecialCharacters(string input)
        {
            // Define a regular expression pattern for special characters
            string pattern = @"[^A-Z0-9\s]|^[a-z]";

            // Create a Regex object
            Regex regex = new Regex(pattern);

            // Use the Regex.IsMatch method to check if the string contains special characters
            return regex.IsMatch(input);
        }
    }
}
