using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_Department
    {
        Dbconnect connect = new Dbconnect();
        public async Task<string> GetIDByCode(string code)
        {
            DataTable dt = await connect.ReadDataAsync("select ID from Department where Code ='" + code + "'");
            return dt.Rows[0]["ID"].ToString();
        }
        public async Task<DataTable> GetDeptByCodeArr(List<string> codes)
        {
            string query = "";
            if (codes.Count > 1)
            {
                query += "Code IN ('";
                query += string.Join("', '", codes);
                query += "')";
            }
            else if (codes.Count == 1)
            {
                query = "Code = '" + codes[0] + "'";
            }
            else
            {
                // Handle the case where the codes list is empty
                // You might want to throw an exception or handle it according to your requirements
            }

            DataTable dt = await connect.ReadDataAsync($"SELECT * FROM Department WHERE {query}");
            return dt;
        }
    }
}
