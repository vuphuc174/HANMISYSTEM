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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }   
    }
}
