using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_Warehouse
    {
        Dbconnect connect = new Dbconnect();
        public async Task<bool> CheckApprovalStatus(string wh)
        {
            DataTable dt = await connect.ReadDataAsync("select approval from warehouse where idwarehouse ='"+ wh + "'");
            if (dt.Rows[0]["approval"].ToString()=="True" || dt.Rows[0]["approval"].ToString() == "1") { return true; } 
            return false;   
        }
        public async Task<DataTable> GetWarehousesByCateGory(string cateID)
        {
            DataTable dt = await connect.ReadDataAsync("select idwarehouse,namewarehouse from warehouse where idcategory ='"+cateID+"'");
            return dt;
        }
        public async Task<string> GetSign(string whID)
        {
            DataTable dt = await connect.ReadDataAsync("select sign from warehouse where idwarehouse ='"+whID+"'");
            try
            {
                return dt.Rows[0]["sign"].ToString();
            }catch
            {
                throw;
            }
        }
        public async Task<string> GetCategoryID(string whID)
        {
            DataTable dt = await connect.ReadDataAsync("select idcategory from warehouse where idwarehouse ='" + whID + "'");
            try
            {
                return dt.Rows[0]["idcategory"].ToString();
            }
            catch
            {
                throw;
            }
        }
    }
}
