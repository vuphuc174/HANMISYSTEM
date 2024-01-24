using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_Slipout
    {
        Dbconnect connect = new Dbconnect();
        public async Task<DataTable> GetWarehouseInOut(string id,string type,DateTime fromDate,DateTime toDate)
        {
            string cmd;
            switch(type)
            {
                case "ALL":
                    cmd = $"select si.partno,c.partname,w.namewarehouse as namewarehouse,w1.namewarehouse as entryplace,SUM(si.quantity) as quantity from slipout s inner join warehouse w on s.idwarehouse =w.idwarehouse inner join warehouse w1 on s.idcustomer =w1.idwarehouse inner join slipoutinfo si on s.idslipout =si.idslipout inner join cargo c on si.partno =c.partno where (s.idwarehouse ='{id}' or s.idcustomer ='{id}') and convert(date,s.dateout) between '{fromDate.ToString("yyyy-MM-dd")}' and '{toDate.ToString("yyyy-MM-dd")}'   group by si.partno,c.partname ,w.namewarehouse,w1.namewarehouse";
                    break;
                case "IN":
                    cmd= $"select si.partno,c.partname,w.namewarehouse as namewarehouse,w1.namewarehouse as entryplace,SUM(si.quantity) as quantity from slipout s inner join warehouse w on s.idwarehouse =w.idwarehouse inner join warehouse w1 on s.idcustomer =w1.idwarehouse inner join slipoutinfo si on s.idslipout =si.idslipout inner join cargo c on si.partno =c.partno where s.idcustomer ='{id}' and convert(date,s.dateout) between '{fromDate.ToString("yyyy-MM-dd")}' and '{toDate.ToString("yyyy-MM-dd")}'   group by si.partno,c.partname ,w.namewarehouse,w1.namewarehouse";
                    break;
                case "OUT":
                    cmd= $"select si.partno,c.partname,w.namewarehouse as namewarehouse,w1.namewarehouse as entryplace,SUM(si.quantity) as quantity from slipout s inner join warehouse w on s.idwarehouse =w.idwarehouse inner join warehouse w1 on s.idcustomer =w1.idwarehouse inner join slipoutinfo si on s.idslipout =si.idslipout inner join cargo c on si.partno =c.partno where s.idwarehouse ='{id}'  and convert(date,s.dateout) between '{fromDate.ToString("yyyy-MM-dd")}' and '{toDate.ToString("yyyy-MM-dd")}'   group by si.partno,c.partname ,w.namewarehouse,w1.namewarehouse";
                    break;
                default:
                    cmd= $"select si.partno,c.partname,w.namewarehouse as namewarehouse,w1.namewarehouse as entryplace,SUM(si.quantity) as quantity from slipout s inner join warehouse w on s.idwarehouse =w.idwarehouse inner join warehouse w1 on s.idcustomer =w1.idwarehouse inner join slipoutinfo si on s.idslipout =si.idslipout inner join cargo c on si.partno =c.partno where (s.idwarehouse ='{id}' or s.idcustomer ='{id}') and convert(date,s.dateout) between '{fromDate.ToString("yyyy-MM-dd")}' and '{toDate.ToString("yyyy-MM-dd")}'   group by si.partno,c.partname ,w.namewarehouse,w1.namewarehouse";
                    break;

            }
            DataTable dt = await connect.ReadDataAsync(cmd);
            return dt;
        }
        public async Task<DataTable> GetTop10NewTransaction(string wh)
        {
            DataTable dt = await connect.ReadDataAsync($"SELECT top 15 s.idslipout, s.dateout, s.idwarehouse, s.idcustomer, COUNT(si.idpack) AS quantity FROM slipout s INNER JOIN slipoutinfo si ON s.idslipout = si.idslipout WHERE s.idwarehouse = '{wh}' OR s.idcustomer = '{wh}' GROUP BY s.idslipout, s.dateout, s.idwarehouse, s.idcustomer ORDER BY s.dateout DESC");
            return dt;
        }
        public async Task<DataTable> GetSlipoutDetails(string id)
        {
            DataTable dt = await connect.ReadDataAsync("select idslipout,idpack,quantity,carnumber,partno from slipoutinfo where idslipout ='"+id+"'");
            return dt;
        }
        public async Task<int> GetTotalToday(string prefix)
        {
            DataTable dt = await connect.ReadDataAsync("select count(idslipout) as quantity from slipout where idslipout like '%"+prefix+"%'");
            return Convert.ToInt32(dt.Rows[0]["quantity"].ToString());
        }
        public async Task<bool> AddNew(string id,string ewh,string iwh,string status)
        {
            if(await connect.ExeDataAsync($"insert into slipout(idslipout,dateout,idwarehouse,idcustomer,status) values('{id}',getdate(),'{ewh}','{iwh}','{status}')"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
