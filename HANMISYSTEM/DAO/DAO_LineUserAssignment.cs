using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_LineUserAssignment
    {
        Dbconnect connect = new Dbconnect();
        public async Task<DataTable> GetLineUserAssignment()
        {
            DataTable dt = await connect.ReadDataAsync("with temp as (SELECT    LineID,STUFF((SELECT ', ' + UserName FROM LineUserAssignment AS InnerTable WHERE InnerTable.LineID = OuterTable.LineID   FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '') AS Users FROM LineUserAssignment AS OuterTable GROUP BY LineID) select t.LineID,l.namelocation1,t.Users from temp t inner join location l on t.LineID=l.idlocation");
            return dt;
        }
        public async Task<bool> AddNew(string lineID,string username)
        {
            if(await connect.ExeDataAsync($"insert into LineUserAssignment(LineID,UserName) values('{lineID}','{username}')"))
            {
                return true;
            }
            return false;
        }
        public async Task<bool> CheckExisted(string lineID,string username)
        {
            DataTable dt = await connect.ReadDataAsync("select * from LineUserAssignment where lineID='"+lineID+"' and username='" + username + "'");
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
