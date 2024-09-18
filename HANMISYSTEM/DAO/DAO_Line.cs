using HANMISYSTEM.Module;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_Line
    {
        Dbconnect connect = new Dbconnect();
        SubDbConnect subDbConnect = new SubDbConnect();
        public async Task<DataTable> GetLines()
        {
            DataTable dtlines = await connect.ReadDataAsync("select idlocation ,namelocation1 from location");
            return dtlines; 
        }
        public async Task<DataTable> GetMappingLine()
        {
            DataTable dtLines = await subDbConnect.ReadDataAsync("select * from vB20Machine where FactoryCode ='F2-ASSY'");
            return dtLines;
        }
        public async Task<DataTable> GetBravoLineDetails(string code)
        {
            DataTable dt = await subDbConnect.ReadDataAsync("select * from vB20Machine where Code ='"+code+"'");
            return dt;
        }
        public async Task<string> GetBravoLineIDByLineID(string lineID)
        {
            DataTable dtlines = await connect.ReadDataAsync("select Bravo_LineID from Mapping_Line where LineID ='"+lineID+"'");
            if(dtlines.Rows.Count > 0)
            {
                return dtlines.Rows[0]["Bravo_LineID"].ToString();
            }
            return "";
        }
        public async Task<bool> CheckExist(string id)
        {
            DataTable dtline=await connect.ReadDataAsync("select * from location where idlocation ='"+id+"'");
            if (dtline.Rows.Count > 0)
                return true;
            return false;   
        }
    }
}
