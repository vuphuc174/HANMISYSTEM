using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.Common
{
    internal class UserSession
    {
        public static bool LoggedIn { get; set; }
        public static string UserID { get; set; }
        public static string Name { get; set; }
        public static string UserName { get; set; }
        public static string UserGroupID { get; set; }
        public static string Lang { get; set; }
        public static string PartNo_Packing { get; set; }   
        public static List<string> Credentials { get; set; }  
    }
}
