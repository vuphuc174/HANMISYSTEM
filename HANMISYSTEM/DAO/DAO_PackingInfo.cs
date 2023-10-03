using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_PackingInfo
    {
        Dbconnect connect = new Dbconnect();
        public async Task<string> GetPackageQty(string PackageID)
        {
            try
            {
                DataTable dt = await connect.ReadDataAsync($"select quantity from packinginfo where idpack='{PackageID}'");
                if(dt.Rows.Count>0)
                {
                    return dt.Rows[0]["quantity"].ToString();
                }
                else
                {
                    return "0";
                }
            }
            catch
            {
                return "0";
            }
        }
    }
}
