using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_AssemblyFGsWarehouse
    {
        Dbconnect connect = new Dbconnect();
        public async Task<DataTable> Filter(string partno,string lineid)
        {
            // Base SQL command
            string cmd = "SELECT af.ID, af.PartNo,(select partname from cargo c where c.partno =af.partno ) as PartName ,LineID, af.Quantity FROM AssemblyFgsWarehouse af";

            // List to hold conditions
            List<string> conditions = new List<string>();

            // Add conditions based on parameters
            if (!string.IsNullOrEmpty(partno))
            {
                conditions.Add($"PartNo LIKE '%{partno}%'");
            }
            if (!string.IsNullOrEmpty(lineid))
            {
                conditions.Add($"LineID = '{lineid}'");
            }

            // Combine conditions into a WHERE clause
            if (conditions.Count > 0)
            {
                cmd += " WHERE " + string.Join(" AND ", conditions);
            }

            // Execute query and return results
            DataTable dtResult = await connect.ReadDataAsync(cmd);
            return dtResult;
        }
        public async Task Update(string partno,string lineID,string Quantity)
        {
            string cmd = $"update AssemblyFGsWarehouse set Quantity = {Quantity} where PartNo = '{partno}' and LineID = '{lineID}'";
            await connect.ExeDataAsync(cmd);
        }
        public async Task<string> GetInventory(string partno,string lineID)
        {
            DataTable dtResult = await connect.ReadDataAsync($"select Quantity from AssemblyFGsWarehouse where lineID ='{lineID}' and partno='{partno}'");
            if(dtResult.Rows.Count>0)
            {
                return (dtResult.Rows[0]["Quantity"].ToString()=="")?"0": dtResult.Rows[0]["Quantity"].ToString();
            }
            return "0";
        }
        
    }
}
