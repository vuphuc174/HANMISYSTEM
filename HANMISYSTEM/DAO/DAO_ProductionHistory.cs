using HANMISYSTEM.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_ProductionHistory
    {
        Dbconnect connect = new Dbconnect();
        public async Task<DataTable> GetPackageList(string partno,string lineID,DateTime fromDate,DateTime toDate)
        {
            DataTable packageList = await connect.ReadDataAsync($"select ph.idpack,ph.partno,SUM(qty) as quantity,pi.packingdate  from productionhistory ph inner join packinginfo pi on ph.idpack =pi.idpack where ph.idlocation ='{lineID}' and ph.partno ='{partno}' and CONVERT(date,productiontime) between '{fromDate.ToString("yyyy-MM-dd")}' and '{toDate.ToString("yyyy-MM-dd")}'  group by ph.idpack,ph.partno,pi.packingdate");
            return packageList;
        }
        public async Task<string> GetProductOutput(string partno,string lineID)
        {
            try
            {
                DataTable dt = await connect.ReadDataAsync($"select SUM(qty) as quantity from productionhistory where CONVERT(date,productiontime) =CONVERT(date,getdate()) and idlocation ='{lineID}' and partno='{partno}'");
                if(dt.Rows.Count > 0)
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
