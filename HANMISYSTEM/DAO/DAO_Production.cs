using HANMISYSTEM.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_Production
    {
        SubDbConnect subDbConnect = new SubDbConnect();
        public async Task UpdateProductionResult(string factoryCode, string factoryID,string machineCode,string machineID,string partno,string quantity,string packageID,string planID,string WOCode)
        {
            String cmd = $"insert into ProductionStatistic(DocDate, FactoryCode, FactoryId, MachineCode, MachineId, ItemCode, Quantity, PackageId, PlanId,WOCode) values(CONVERT(date, getdate()), '{factoryCode}', '{factoryID}', '{machineCode}', '{machineID}', '{partno}', {quantity}, '{packageID}', '{planID}','{WOCode}')";
            await subDbConnect.ExeDataAsync(cmd);

        }
    }
}
