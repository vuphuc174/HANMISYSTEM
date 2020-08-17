using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace HANMISYSTEM
{
    class ApplicationContext
    {
        public static string serverName;
        public static string username;
        public static string password;
        //public static string permission;

        public static void Initialize()
        {
            //need to read through config here

            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(".\\Settings.xml");
                XmlNodeList serverNodeList = xDoc.GetElementsByTagName("servername");
                XmlNodeList usernameNodeList = xDoc.GetElementsByTagName("uid");
                XmlNodeList passwordNodeList = xDoc.GetElementsByTagName("pwd");

            }
            catch 
            {
                // MessageBox.Show(ex.ToString());
                //TODO: Future write to log file
                username = "user";
                password = "password";
                serverName = "localhost";
            }
        }
    }
}
