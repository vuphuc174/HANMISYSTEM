using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_SlipoutInfo
    {
        Dbconnect connect = new Dbconnect();
        public async Task<bool> AddNew(string id,string packageID,string qty,string remark,string partno,string carnumber)
        {
            if(await connect.ExeDataAsync($"Insert into SlipoutInfo(idslipout,idpack,quantity,remark,partno,carnumber) values('{id}','{packageID}','{qty}','{remark}','{partno}','{carnumber}')"))
            {
                return true;
            }
            return false;
        }
        public async Task<DataTable> GetSlipoutInfo(string id)
        {
            DataTable dt = await connect.ReadDataAsync($"select cargo.partno,cargo.partname,(select nameunit from unit where idunit=cargo.idunit) as dvt,SUM(quantity) as qty,slipoutinfo.remark from cargo inner join slipoutinfo on cargo.partno=slipoutinfo.partno  where idslipout='{id}' group by cargo.partno,cargo.partname,cargo.idunit,slipoutinfo.remark");
            return dt;
        }
    }
}
