using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Systems
{
    public partial class AboutVersion : Form
    {
        public AboutVersion()
        {
            InitializeComponent();

        }
        private string host = "http://192.168.1.248:8086/";
        private void CheckUpdate()
        {
            try
            {
                var urlVersion = host + "version.html";
                var newVersion = (new WebClient().DownloadString(urlVersion));
                var currentVersion = Application.ProductVersion.ToString();
                newVersion = newVersion.Replace(".", "");
                currentVersion = currentVersion.Replace(".", "");
                //this.Invoke(new Action(() =>
                //{
                if (Convert.ToInt32(newVersion) > Convert.ToInt32(currentVersion))
                {
                    lbheader.Text = "A New Version is Available.\r\nDo you want to Update ?\r\n";
                    lbnew.Text = (new WebClient().DownloadString(urlVersion));
                    btnCheckUpdate.Enabled = true;
                    lbnew.Show();
                    labelnew.Show();
                    btnUpdate.Show();
                }
                else
                {
                    lbheader.Text = "The version is up to date";

                    btnCheckUpdate.Enabled = true;
                    lbnew.Hide();
                    labelnew.Hide();
                    btnUpdate.Hide();

                }
                //}));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void CreateRunFile()
        {
            string batchFilePath = "run.bat";
            string downloadFilePath = AppDomain.CurrentDomain.BaseDirectory + @"HANMISYSTEM_SETUP.msi";
            // Specify the batch script content
            StringBuilder batchScript = new StringBuilder();
            batchScript.AppendLine("@echo off");
            batchScript.AppendLine("Taskkill /f /im HANMISYSTEM.exe");
            batchScript.AppendLine(":exit");
            batchScript.AppendLine($"msiexec.exe /i \"{downloadFilePath}\" /QN");
            batchScript.AppendLine($"del \"{downloadFilePath}\";");
            batchScript.AppendLine($"cd \"{AppDomain.CurrentDomain.BaseDirectory}\"");
            batchScript.AppendLine("start HANMISYSTEM.exe");

            // Write the batch script content to the batch file
            File.WriteAllText(batchFilePath, batchScript.ToString());

            //// Run the batch file
            //ProcessStartInfo psi = new ProcessStartInfo
            //{
            //    FileName = "cmd.exe",
            //    RedirectStandardInput = true,
            //    UseShellExecute = false,
            //    CreateNoWindow = true
            //};

            //Process process = new Process { StartInfo = psi };
            //process.Start();

            //StreamWriter sw = process.StandardInput;
            //sw.WriteLine($"cd {Directory.GetCurrentDirectory()}");
            //sw.WriteLine(batchFilePath);
            //sw.Close();

            //process.WaitForExit();
            //process.Close();
        }
        private void initScript()
        {
            CreateRunFile();
            string path = Application.StartupPath + @"\run.bat";

            Process p = new Process();
            p.StartInfo.FileName = path;
            p.StartInfo.Arguments = "";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.Verb = "runas";
            p.Start();
            Environment.Exit(1);

        }
        private void Web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                initScript();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCheckUpdate_Click(object sender, EventArgs e)
        {
            CheckUpdate();
           
        }

        private void AboutVersion_Load(object sender, EventArgs e)
        {
            lbnew.Hide();
            labelnew.Hide();
            btnUpdate.Hide();
            lbcurrent.Text = Application.ProductVersion.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient web = new WebClient();
                web.DownloadFileCompleted += Web_DownloadFileCompleted;
                string filePath = host + "update/HANMISYSTEM_SETUP.msi";
                web.DownloadFileAsync(new Uri(filePath), @".\HANMISYSTEM_SETUP.msi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
