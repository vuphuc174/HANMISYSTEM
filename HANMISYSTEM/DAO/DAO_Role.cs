using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_Role
    {
        Dbconnect connect = new Dbconnect();
        public async Task<DataTable> GetRoles()
        {
            DataTable dtRoles = await connect.ReadDataAsync("select ID,Name from Role");
            return dtRoles;
        }
        public async Task<bool> CheckRoleExisted(string id)
        {
            DataTable dtRole = await connect.ReadDataAsync("select ID from Role where ID ='" + id + "'");
            if (dtRole.Rows.Count > 0)
                return true;
            return false;
        }
        public async Task<bool> AddNewRole(string id, string name)
        {

            if (await connect.ExeDataAsync($"insert into Role(ID,Name) values('{id}',N'{name}')"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<DataTable> GetRoleInfo(string id)
        {
            DataTable dtrole = await connect.ReadDataAsync("select Name from Role where ID='"+id+"'");
            return dtrole;
        }
        public async Task<bool> UpdateRole(string id,string name)
        {
            if(await connect.ExeDataAsync("update Role set Name=N'"+name+"' where id ='" + id + "'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> DeleteRole(string id)
        {
            if(await connect.ExeDataAsync("delete from Role where ID= '" + id + "'"))
            {
                return true;
            }
            return false;
        }
    }
}
