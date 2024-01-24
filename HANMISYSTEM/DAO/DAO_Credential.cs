using HANMISYSTEM.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_Credential
    {
        Dbconnect connect =new Dbconnect();
        DAO_User dAO_User = new DAO_User();
        public async Task<DataTable> GetCredentials()
        {
            DataTable dtCredentials = await connect.ReadDataAsync("select ID,RoleID,UserGroupID from Credential");
            return dtCredentials;
        }
        public async Task<bool> CheckCredential(string roleID)
        {
            if (UserSession.Credentials.Contains(roleID) || await dAO_User.CheckIsAdmin(UserSession.UserName))
                return true;
            return false;
        }
        public async Task<DataTable> GetGroupFollowRole()
        {
            DataTable dt = await connect.ReadDataAsync("SELECT    RoleID,    STUFF((        SELECT ', ' + UserGroupID FROM Credential AS InnerTable WHERE InnerTable.RoleID = OuterTable.RoleID   FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '') AS UserGroupIDs FROM Credential AS OuterTable GROUP BY RoleID; ");
            return dt;
        }
        public async  Task<List<string>> GetListCredential(string userID)
        {
            DataTable dtCredentials = await connect.ReadDataAsync($"select c.RoleID from UserGroupUser ugu inner join Credential c on ugu.GroupUserID =c.UserGroupID where ugu.UserID='{userID}'");
            List<string> credentials = new List<string>();
            if(dtCredentials.Rows.Count>0)
            {
                for(int i=0;i<dtCredentials.Rows.Count;i++)
                {
                    credentials.Add(dtCredentials.Rows[i]["RoleID"].ToString());
                }
            }
            return credentials;
        }
        public async Task<bool> AddNewCredential(string userGroupID,string roleID)
        {
            string cmd = $"insert into Credential(UsergroupID,RoleID) values('{userGroupID}','{roleID}')";
            if (await connect.ExeDataAsync(cmd))
            {
                return true;
            }
            return false;
        }
        public async  Task<bool> CheckExist(string userGroupID,string roleID)
        {
            DataTable dt = await connect.ReadDataAsync($"select * from Credential where UserGroupID ='{userGroupID}' and RoleID ='{roleID}'");
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
    }
}
