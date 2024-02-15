using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_Inspector_MAC_Address
    {
        Dbconnect connect = new Dbconnect();
        DAO_SystemLog dAO_SystemLog = new DAO_SystemLog();
        public async Task<bool> CheckDuplicate(string value, string deptID)
        {
            try
            {
                DataTable dt = await connect.ReadDataAsync("select ID from Inspector_MAC_Address where MACAddress ='" + value + "' and DepartmentID='" + deptID + "'");
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }catch{
               
            }
           return false;
        }
        public async Task Add(string value,string deptID,int judge,string packageID,string remark)
        {
            if(!await connect.ExeDataAsync($"Insert into Inspector_MAC_Address(MACAddress,InspectTime,Judge,PackageID,Remark,DepartmentID) values('{value}',getdate(),{judge},'{packageID}',N'{remark}','{deptID}')"))
            {
                await dAO_SystemLog.Add("error", "Cannot insert Inspector mac address");
            }
        }
        public async Task<string> GetOK(string deptID)
        {
            DataTable dt = await connect.ReadDataAsync("select count(ID) as quantity from Inspector_MAC_Address where DepartmentID ='"+deptID+"' and Judge =1 and convert(date,InspectTime) =convert(date,getdate())");
            return dt.Rows[0]["quantity"].ToString();
        }
        public async Task<string> GetNG(string deptID)
        {
            DataTable dt = await connect.ReadDataAsync("select count(ID) as quantity from Inspector_MAC_Address where DepartmentID ='" + deptID + "' and Judge =0 and convert(date,InspectTime) =convert(date,getdate())");
            return dt.Rows[0]["quantity"].ToString();
        }
        public async Task<DataTable> Filter(string deptID, string searchTerm, string judge,bool allTime,DateTime fromDate,DateTime toDate)
        {
            DataTable dt;
            string query = "select  ID,MACAddress,InspectTime,Judge,Remark from Inspector_MAC_Address  ";
            List<string> conditions = new List<string>();
            if (deptID != null)
            {
                conditions.Add("DepartmentID='" + deptID + "'");
            }
            if (!string.IsNullOrEmpty(judge) && judge!="2")
            {
                conditions.Add("Judge ='" + judge + "'");
            }
            if (!string.IsNullOrEmpty(searchTerm))
            {
                conditions.Add("MACAddress like '%" + searchTerm + "%'");
            }
            if(!allTime)
            {
                conditions.Add($"Convert(date,InspectTime) between '{fromDate.ToString("yyyy-MM-dd")}' and '{toDate.ToString("yyyy-MM-dd")}' ");
            }
            
            if (conditions.Count > 0)
            {
                query += "WHERE ";
                query += string.Join(" AND ", conditions);
            }
            dt = await connect.ReadDataAsync(query + " order by InspectTime desc");
            return dt;
        }

    }
}
