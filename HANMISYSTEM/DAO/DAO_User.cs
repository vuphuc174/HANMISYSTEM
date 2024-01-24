using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_User
    {
        Dbconnect connect = new Dbconnect();
        string tableName = "tbl_user";
        #region GET

        #endregion
        #region POST
        public async Task<bool> AddNew(string username,string password,string displayname)
        {
            if(await connect.ExeDataAsync($"Insert into {tableName} (username,password,name) values('{username}','{password}',N'{displayname}')"))
            {
                return true;
            }
            return false;
        }
        #endregion
        public async Task<DataTable> GetUsers()
        {
            DataTable dtuser = await connect.ReadDataAsync($"select ID,Username,Name from {tableName} ");
            return dtuser;
        }
        public async Task<DataTable> GetUsersByGroupID(string groupID)
        {
            DataTable dtuser = await connect.ReadDataAsync($"select u.ID,u.Username,u.Name from {tableName} u inner join UserGroupUser ugu on u.ID =ugu.UserID  where ugu.GroupUserID ='{groupID}' ");
            return dtuser;
        }
        public async Task<bool> ChangePassword(string id,string password)
        {
            try
            {
                await connect.ExeDataAsync($"update {tableName} set password ='{password}' where ID={id}");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> CheckExisted(string username)
        {
            DataTable dtuser = await connect.ReadDataAsync("select username from tbl_user where username='"+username+"'");
            if (dtuser.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public async Task<bool> CheckIsAdmin(string userName)
        {
            DataTable dt = await connect.ReadDataAsync($"select u.username from tbl_user u inner join UserGroupUser ugu on u.ID =ugu.UserID where ugu.GroupUserID ='ADMIN' AND u.username='{userName}'");
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public async Task<bool> ChangeDisplayName(string id, string name)
        {
            try
            {
                await connect.ExeDataAsync($"update {tableName} set name =N'{name}' where ID={id}");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
