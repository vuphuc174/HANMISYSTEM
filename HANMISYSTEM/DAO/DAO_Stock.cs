using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_Stock
    {
        Dbconnect connect = new Dbconnect();
        public async Task<bool> CheckStockExisted(string partno,string whID)
        {
            DataTable dt = await connect.ReadDataAsync($"select partno from stock where partno='{partno}' and idwarehouse='{whID}'");
            if(dt.Rows.Count > 0) { return true; }
            return false;
        }
        public async Task AddStock(string partno,string whID,string quantity)
        {
            if(await CheckStockExisted(partno, whID))
            {
                await connect.ExeDataAsync($"update stock set quantity = quantity + {quantity} where idwarehouse='{whID}' and partno='{partno}'");
            }
            else
            {
                await connect.ExeDataAsync($"insert into Stock(idwarehouse,partno,quantity) values('{whID}','{partno}',{quantity})");
            }
        }
    }
}
