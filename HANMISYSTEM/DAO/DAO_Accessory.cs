using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_Accessory
    {
        Dbconnect connect = new Dbconnect();
        public async Task<DataTable> GetAccessoryByPartNo(string pn)
        {
            DataTable dtaccessory = await connect.ReadDataAsync("select accessory from Accessory where PartNo ='"+pn+"'");
            return dtaccessory;
        }
    }
}
