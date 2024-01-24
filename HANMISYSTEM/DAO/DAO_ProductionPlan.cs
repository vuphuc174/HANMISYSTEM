using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_ProductionPlan
    {
        Dbconnect connect = new Dbconnect();
        public async Task<DataTable> GetProductionPlan(string lineID)
        {
            DataTable dtPlans = await connect.ReadDataAsync($"select ROW_NUMBER() over(order by p.partno) as r ,isnull(w.Code,p.WOCode) as WorkOrder,p.ID as PlanID,p.partno,c.partname,c.Color,c.Market,p.PST,p.productionplan from productionplan p  left join WorkOrder w on p.WorkOrderID=w.ID inner join cargo c on c.partno =p.partno where (p.Status is null or p.Status<> 0 )  and p.idlocation='{lineID}' and productiondate =CONVERT(date,getdate())");
            return dtPlans;
        }
        public async Task<string> GetTotalWorkOrder()
        {
            DataTable dtwo = await connect.ReadDataAsync("select count(id)+1 as total from productionplan where productiondate =convert(date,getdate())");
            return Convert.ToInt32(dtwo.Rows[0]["total"].ToString()).ToString("0000");
        }
        public async Task<string> GenerateWordOrderCode()
        {
            string prefix = "HM";
            string time = DateTime.Now.ToString("yyMMdd");
            string serials = await GetTotalWorkOrder();
            return prefix + time + serials;
        }
        #region POST
        public async Task<bool> AddNew(string partno,string whID,DateTime pst,string lineID,string quantity)
        {
            string cmd = $"insert into productionplan (partno,idwarehouse,pst,productiondate,idlocation,productionplan,WOCode) values('{partno}','{whID}','{pst.ToString("yyyy-MM-dd hh:mm:00")}','{pst.ToString("yyyy-MM-dd")}','{lineID}','{quantity}','{await GenerateWordOrderCode()}')";
            if (await connect.ExeDataAsync(cmd))
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
