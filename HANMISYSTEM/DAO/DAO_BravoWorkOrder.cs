using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_BravoWorkOrder
    {
        Dbconnect connect = new Dbconnect();
        public async Task<DataTable> Filter(string searchTearm, string lineid,string fromDate,string toDate)
        {
            // Base SQL command
            string cmd = "SELECT bw.ID, bw.PartNo,(select partname from cargo c where c.partno =bw.partno ) as PartName ,bw.LineID,bw.Code,bw.CreateDate, bw.Quantity FROM BravoWorkOrder bw ";

            // List to hold conditions
            List<string> conditions = new List<string>();

            // Add conditions based on parameters
            if (!string.IsNullOrEmpty(searchTearm))
            {
                conditions.Add($"PartNo LIKE '%{searchTearm}%' or Code like '%{searchTearm}%'");
            }
            if (!string.IsNullOrEmpty(lineid))
            {
                conditions.Add($"LineID = '{lineid}'");
            }
            conditions.Add($"convert(date,CreateDate) between '{fromDate}' and '{toDate}'");
            // Combine conditions into a WHERE clause
            if (conditions.Count > 0)
            {
                cmd += " WHERE " + string.Join(" AND ", conditions) +" Order by CreateDate desc";
            }

            // Execute query and return results
                DataTable dtResult = await connect.ReadDataAsync(cmd);
            return dtResult;
        }
    }
}
