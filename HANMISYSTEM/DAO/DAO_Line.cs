using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_Line
    {
        Dbconnect connect = new Dbconnect();
        public async Task<DataTable> GetLines()
        {
            DataTable dtlines = await connect.ReadDataAsync("select idlocation ,namelocation1 from location");
            return dtlines; 
        }
        public async Task<bool> CheckExist(string id)
        {
            DataTable dtline=await connect.ReadDataAsync("select * from location where idlocation ='"+id+"'");
            if (dtline.Rows.Count > 0)
                return true;
            return false;   
        }
    }
}
