using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HANMISYSTEM.Common
{
    internal class PackingController
    {
        Dbconnect connect = new Dbconnect();
        public bool CheckLabel(string code)
        {
            DataTable dtpo = connect.readdata("select CheckLabel from PackingOptional where Partno='" + code + "' ");
            if (dtpo.Rows.Count > 0)
            {
                if (dtpo.Rows[0]["CheckLabel"].ToString() == "True")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool CheckChangePackingMethod(string code)
        {
            DataTable dtpo = connect.readdata("select ChangePackingMethod from PackingOptional where Partno='" + code + "' ");
            if (dtpo.Rows.Count > 0)
            {
                if (dtpo.Rows[0]["ChangePackingMethod"].ToString() == "True")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
