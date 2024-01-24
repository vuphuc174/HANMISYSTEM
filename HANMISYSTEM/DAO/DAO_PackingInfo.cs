using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_PackingInfo
    {
        Dbconnect connect = new Dbconnect();
        #region GET
        public async Task<string> GetTodayExport(string wh)
        {
            DataTable dt = await connect.ReadDataAsync($"select isnull(SUM(si.quantity),0) as quantity from slipout sl inner join slipoutinfo si on sl.idslipout =si.idslipout where idwarehouse='" + wh + "' and CONVERT(date,sl.dateout)=CONVERT(date,getdate())");
            return dt.Rows[0]["quantity"].ToString();
        }
        public async Task<string> GetTodayImport(string wh)
        {
            DataTable dt = await connect.ReadDataAsync($"select isnull(SUM(si.quantity),0) as quantity from slipout sl inner join slipoutinfo si on sl.idslipout =si.idslipout where idcustomer='" + wh + "' and CONVERT(date,sl.dateout)=CONVERT(date,getdate())");
            return dt.Rows[0]["quantity"].ToString();
        }
        public async Task<string> GetTotalProduct(string wh)
        {
            DataTable dt = await connect.ReadDataAsync($"select isnull(SUM(quantity),0) as quantity from packinginfo where idwarehouse='{wh}'");
            return dt.Rows[0]["quantity"].ToString();
        }
        public async Task<string> GetTotalPackage(string wh)
        {
            DataTable dt = await connect.ReadDataAsync($"select isnull(count(idpack),0) as quantity from packinginfo where idwarehouse='" + wh + "'");
            return dt.Rows[0]["quantity"].ToString();
        }
        public async Task<DataTable> GetPackageInfoByIDAndWarehouse(string packageID, string whID)
        {
            DataTable dtpackage = await connect.ReadDataAsync($"select * from packinginfo where idpack='{packageID}' and idwarehouse ='{whID}'");
            return dtpackage;
        }
        public async Task<string> GetPackageQty(string PackageID)
        {
            try
            {
                DataTable dt = await connect.ReadDataAsync($"select quantity from packinginfo where idpack='{PackageID}'");
                if (dt.Rows.Count > 0)
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
        public async Task<int> GetTotalPage(string searchTearm, string wh, int pageSize)
        {
            string cmd_retrieve = "ROW_NUMBER() OVER (ORDER BY pi.packingdate desc) AS row,pi.idpack,pi.partno,pi.quantity,pi.packingdate";
            DataTable dataTable;
            if (string.IsNullOrEmpty(searchTearm))
            {
                dataTable = await connect.ReadDataAsync($"with temp as  (select {cmd_retrieve} from packinginfo pi  where   pi.idwarehouse ='" + wh + "') select COUNT(*) as row from temp");
            }
            else
            {
                dataTable = await connect.ReadDataAsync($"with temp as  (select {cmd_retrieve} from packinginfo pi where ( pi.partno like '%" + searchTearm + "%'  or pi.idpack like '%" + searchTearm + "%') and pi.idwarehouse ='" + wh + "' ) select COUNT(*) as row from temp");
            }
            if (dataTable.Rows.Count > 0)
            {
                if (Convert.ToInt32(dataTable.Rows[0]["row"].ToString()) % pageSize == 0)
                {
                    return Convert.ToInt32(dataTable.Rows[0]["row"].ToString()) / pageSize;
                }
                else
                {
                    return Convert.ToInt32(dataTable.Rows[0]["row"].ToString()) / pageSize + 1;
                }
            }

            return 0;
        }
        public async Task<DataTable> GetDataByPage(int page, int pageSize, string searchTearm, string wh)
        {
            string cmd_retrieve = "ROW_NUMBER() OVER (ORDER BY pi.packingdate desc) AS row,pi.idpack,pi.partno,pi.quantity,pi.packingdate";
            DataTable dt = null;
            if (string.IsNullOrEmpty(searchTearm))
            {
                dt = await connect.ReadDataAsync($"with temp as  (select {cmd_retrieve} from packinginfo pi where   pi.idwarehouse ='" + wh + "') select t.*,c.partname  from temp t inner join cargo c on t.partno =c.partno  where row >=" + ((page * pageSize - pageSize) + 1) + " and row <= " + (page * pageSize) + " order by row");
            }
            else
            {
                dt = await connect.ReadDataAsync($"with temp as  (select {cmd_retrieve} from packinginfo pi where ( pi.partno like '%" + searchTearm + "%'  or pi.idpack like '%" + searchTearm + "%') and pi.idwarehouse ='" + wh + "') select t.*,c.partname  from temp t inner join cargo c on t.partno=c.partno  where row >=" + ((page * pageSize - pageSize) + 1) + " and row <= " + (page * pageSize) + " order by row");
            }
            return dt;
        }
        #endregion
        #region PUSH
        public async Task UpdatePackageQuantity(string packageID, string quantity)
        {
            await connect.ExeDataAsync($"update packinginfo set quantity ={quantity} where idpack='{packageID}'");
        }

        #endregion
        #region POST

        #endregion
        public async Task<bool> RemovePackage(string packageID)
        {
            if (await connect.ExeDataAsync("delete from packinginfo where idpack ='" + packageID + "'")) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task MovePackage(string packageID,string wh)
        {
            await connect.ExeDataAsync($"update PackingInfo set idwarehouse ='{wh}' where idpack ='{packageID}'");
        }
       
        public async Task<bool> CheckExisted(string PackageID)
        {
            DataTable dtPackage = await connect.ReadDataAsync("select idpack from packinginfo where idpack='"+PackageID+"'");
            if (dtPackage.Rows.Count > 0)
                return true;
            return false;
        }
    }
}
