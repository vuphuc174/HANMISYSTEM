using HANMISYSTEM.Common;
using HANMISYSTEM.Module;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_Production
    {
        SubDbConnect subDbConnect = new SubDbConnect();
        Dbconnect dbconnect = new Dbconnect();
        DAO_SystemLog systemLog = new DAO_SystemLog();
        public async Task<string> GetFinishedWorkOrder(string pn,string lineID )
        {
            string cmd = $"select isnull(sum(quantity),0) as qty from BravoWorkOrder where PartNo= '{pn}' and LineID ='{lineID}' and CONVERT(date,getdate()) =CONVERT(date, CreateDate)";
            DataTable dtResult =await dbconnect.ReadDataAsync(cmd);
            if(dtResult.Rows.Count > 0)
            {
                return dtResult.Rows[0]["qty"].ToString();
            }
            return "0";
        }

        public async Task<DataTable> GetBravoWorkOrder(string lineID ,string partno)
        {
            string cmd = $"select * from BravoWorkOrder where PartNo= '{partno}' and LineID ='{lineID}' and CONVERT(date,getdate()) =CONVERT(date, CreateDate)";
            DataTable dtResult = await dbconnect.ReadDataAsync(cmd);
            return dtResult;
        }
        int qty;
        string GenerateCode(string lineID,string partno)
        {
            //HMWO241128-0001
            string query = $"select count(id) as woqty from BravoWorkOrder where LineID ='{lineID}' and CONVERT(date,getdate()) =CONVERT(date, CreateDate)";
            DataTable dtWO = dbconnect.readdata(query);
            if(dtWO.Rows.Count>0)
            {
                qty = Convert.ToInt32(dtWO.Rows[0]["woqty"].ToString());
            }
            return "HMWO" +DateTime.Now.ToString("yyMMdd") +"-"+qty.ToString("0000");
        }
        public async Task CreateBravoWorkOrder(string quantity,string lineID,string partno)
        {
            string code = GenerateCode(lineID, partno);
            string cmd = $"insert into BravoWorkOrder(Code,Quantity,LineID,CreateDate,PartNo) values('{code}',{quantity},'{lineID}',getdate(),'{partno}')";
            await dbconnect.ExeDataAsync(cmd);
        }
        public async Task SubmitWorkOrder(string factoryCode, string factoryID, string machineCode, string machineID, string partno, string quantity, string packageID, string planID, string WOCode,string workprocessCode,string warẹhouseID)
        {
            String cmd = $"insert into ProductionGroup(DocDate, FactoryCode, FactoryId, MachineCode, MachineId, ItemCode, Quantity, PackageId, PlanId,WOCode,WorkProcessCode,WarehouseId,CreatedBy) values(CONVERT(date, getdate()), '{factoryCode}', '{factoryID}', '{machineCode}', '{machineID}', '{partno}', {quantity}, '{packageID}', '{planID}','{WOCode}','{workprocessCode}',{warẹhouseID},{UserSession.UserID_Bravo})";
            //await systemLog.Add("notify", cmd);
            await subDbConnect.ExeDataAsync(cmd);

        }
        public async Task UpdateProductionResult(string factoryCode, string factoryID,string machineCode,string machineID,string partno,string quantity,string packageID,string planID,string WOCode)
        {
            String cmd = $"insert into ProductionStatistic(DocDate, FactoryCode, FactoryId, MachineCode, MachineId, ItemCode, Quantity, PackageId, PlanId,WOCode) values(CONVERT(date, getdate()), '{factoryCode}', '{factoryID}', '{machineCode}', '{machineID}', '{partno}', {quantity}, '{packageID}', '{planID}','{WOCode}')";
            await subDbConnect.ExeDataAsync(cmd);

        }
        public void UpdateProductionResult_1(string factoryCode, string factoryID, string machineCode, string machineID, string partno, string quantity, string packageID, string planID, string WOCode)
        {
            String cmd = $"insert into ProductionStatistic(DocDate, FactoryCode, FactoryId, MachineCode, MachineId, ItemCode, Quantity, PackageId, PlanId,WOCode) values(CONVERT(date, getdate()), '{factoryCode}', '{factoryID}', '{machineCode}', '{machineID}', '{partno}', {quantity}, '{packageID}', '{planID}','{WOCode}')";
            subDbConnect.exedata(cmd);

        }
    }
}
