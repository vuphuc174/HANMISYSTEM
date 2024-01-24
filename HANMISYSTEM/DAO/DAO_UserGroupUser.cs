using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_UserGroupUser
    {
        Dbconnect connect = new Dbconnect();
        string tableName = "UserGroupUser";
        public async Task<DataTable> GetGroupUser(string userID)
        {
            DataTable dtGroup = await connect.ReadDataAsync($"select ugu.GroupUserID,ug.Name from {tableName} ugu inner join UserGroup ug on ugu.GroupUserID =ug.ID where ugu.UserID={userID}");
            return dtGroup;
        }
        public async Task<bool> RemoveCurrent(string userID)
        {
            try
            {
                await connect.ExeDataAsync($"delete from {tableName} where UserID ={userID}");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task AddUGU(string userID,string groupUserID)
        {
            string cmd = $"insert into {tableName}(UserID,GroupUserID) values('{userID}','{groupUserID}')";
            await connect.ExeDataAsync(cmd);
        }
    }
}
