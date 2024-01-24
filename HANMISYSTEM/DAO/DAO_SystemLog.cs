using HANMISYSTEM.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_SystemLog
    {
        Dbconnect connect = new Dbconnect();
        public async Task Add(string level, string message)
        {
            await connect.ExeDataAsync($"Insert into SystemLog(LogTime,LogLevel,LogMessage,LogBy) values(getdate(),'{level}','{message}','{UserSession.UserName}')");
        }
        public async Task<DataTable> Filter(string level, string logby, string searchTerm)
        {
            DataTable logs;
            string query = "select top 100 ID,LogTime,LogLevel,LogMessage,LogBy from SystemLog  ";
            List<string> conditions = new List<string>();
            if(level!="all" && level!=null)
            {
                conditions.Add("LogLevel='"+level+"'");
            }
            if (!string.IsNullOrEmpty(logby))
            {
                conditions.Add("Logby ='" + logby + "'");
            }
            if (!string.IsNullOrEmpty(searchTerm))
            {
                conditions.Add("LogMessage like '%" + searchTerm + "%'");
            }
            if (conditions.Count > 0)
            {
                query += "WHERE ";
                query += string.Join(" AND ", conditions);
            }
            logs = await connect.ReadDataAsync(query +" order by LogTime desc");
            return logs;
        }

    }
}
