using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_UserGroup
    {
        Dbconnect connect = new Dbconnect();
        string tableName = "UserGroup";
        public async Task<DataTable> GetUserGroups()
        {
            DataTable dt = await connect.ReadDataAsync($"select ID,Name from {tableName}");
            return dt;
        }
        public async Task<DataTable> FindGroupByID(string id)
        {
            DataTable dtGroup = await connect.ReadDataAsync("select ID,Name from UserGroup where ID like '%"+id+"%'");
            return dtGroup;
        }
        public async Task<DataTable> GetUserGroup(string id)
        {
            DataTable dt = await connect.ReadDataAsync($"select  case when (select GroupUserID from UserGroupUser ugu where ugu.UserID={id} and ugu.GroupUserID=ug.ID) is not null then 'true' else 'false' end as hasvalue ,ug.ID,ug.Name  from UserGroup ug ");
            return dt;  
        }
        public async Task<bool> CheckIDExisted(string id)
        {
            DataTable dt = await connect.ReadDataAsync($"select id from {tableName} where id='{id}' ");
            if(dt.Rows.Count>0)
            {
                return true;
            }
            return false;
        }
        public async Task<bool> AddNew(string id,string name)
        {
            try
            {
                string cmd = $"insert into {tableName}(ID,Name) values('{id}',N'{name}') ";
                await connect.ExeDataAsync(cmd);
                return true;
            }
            catch
            {
                return false;
            }
          
        }
    }
}
