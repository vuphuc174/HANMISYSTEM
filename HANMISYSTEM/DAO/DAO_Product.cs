using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_Product
    {
        Dbconnect connect = new Dbconnect();
        public async Task<string> GetPartName(string pn)
        {
            DataTable dtProduct = await connect.ReadDataAsync("select partname from cargo where partno='"+pn+"'");
            if(dtProduct.Rows.Count>0)
            {
                return dtProduct.Rows[0]["Partname"].ToString();
            }
            return "null";
        }
        public async Task<bool> CheckExisted(string pn)
        {
            DataTable dtProduct = await connect.ReadDataAsync("select partno from cargo where partno ='" + pn + "'");
            if (dtProduct.Rows.Count > 0)
                return true;
            return false;
        }
        public async Task<DataTable> Find(string pn,int? quantity)
        {
            string condition = (quantity == null) ? "" : "top "+quantity.ToString()+"";
            string cmd = $"select {condition} partno from cargo where partno like '%" + pn + "%'";
            DataTable dtProduct = await connect.ReadDataAsync(cmd);
            return dtProduct;
        }
    }
}
