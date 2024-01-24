using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_CheckAccessoryOptional
    {
        Dbconnect connect = new Dbconnect();
        DAO_Product dAO_Product = new DAO_Product();
        public async Task<bool> GetStatus(string pn)
        {
            DataTable dataTable = await connect.ReadDataAsync("select InspectLabelDate from AccessoryOptional where PartNo ='"+pn+"'");
            if(dataTable.Rows.Count > 0)
            {
                return Convert.ToBoolean(dataTable.Rows[0]["InspectLabelDate"].ToString());
            }
            return false;
        }
        public async Task<bool> CheckSettingExisted(string pn)
        {
            DataTable dt = await connect.ReadDataAsync("select ID from AccessoryOptional where PartNo ='" + pn + "'");
            if(dt.Rows.Count > 0)
            {
                return true;    
            }
            return false;
        }

        public async Task<bool> ChangeStatus(string pn,bool value)
        {

            if(!await dAO_Product.CheckExisted(pn))
            {
                return false;
            }
            else
            {
                if(await CheckSettingExisted(pn))
                {
                    if(await connect.ExeDataAsync($"update AccessoryOptional set InspectLabelDate ={((value)?1:0)} where PartNo ='"+pn+"'"))
                    {
                        return true;
                    }
                }
                else
                {
                    if (await connect.ExeDataAsync($"Insert into AccessoryOptional(PartNo,InspectLabelDate) values('{pn}',{((value)?1:0)})"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
