using HANMISYSTEM.Common;
using HANMISYSTEM.Views;
using HANMISYSTEM.Views.Accessory;
using HANMISYSTEM.Views.PartialView;
using HANMISYSTEM.Views.Producs;
using HANMISYSTEM.Views.RawMgt;
using HANMISYSTEM.Views.ReportViewer;
using HANMISYSTEM.Views.Spray;
using HANMISYSTEM.Views.UPH;
using HANMISYSTEM.Views.WorkOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            bool isNewInstance;
            string applicationName = Assembly.GetEntryAssembly()?.GetName().Name;
            using (Mutex mutex = new Mutex(true, applicationName, out isNewInstance))
            {
                if (isNewInstance)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    if (UserSession.LoggedIn)
                    {
                        MainFrm mainFrm = new MainFrm();
                        Application.Run(mainFrm);
                        if (!UserSession.LoggedIn)
                        {
                            return ;
                        }
                    }
                    else
                    {
                        login loginForm = new login();
                        if (loginForm.ShowDialog() == DialogResult.OK)
                        {
                            // User logged in successfully, proceed to the main form
                            Application.Run(new MainFrm());
                        }
                        else
                        {
                            // Login canceled or unsuccessful, exit the application
                            return;
                        }
                    }
                }
                else
                {
                    // An instance of the application is already running
                    // You can show a message or perform any desired action
                    MessageBox.Show("The application is already running.");
                }
            }

        }
    }
}
