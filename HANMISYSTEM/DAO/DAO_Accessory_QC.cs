using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.DAO
{
    internal class DAO_Accessory_QC
    {
        Dbconnect connect = new Dbconnect();
        DAO_SystemLog dAO_SystemLog = new DAO_SystemLog();
        DAO_Product dAO_Product = new DAO_Product();
        public async Task<DataTable> GetAccessoryByPartNo(string pn)
        {
            DataTable dt = await connect.ReadDataAsync("select Accessory from Accessory_QC where partno ='"+pn+"'");
            return dt;
        }
        public async Task<bool> CheckExisted(string pn,string accessory)
        {
            DataTable dtAcc = await connect.ReadDataAsync($"select ID from Accessory_QC where PartNo ='{pn}' and Accessory ='{accessory}'");
            if (dtAcc.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public async Task<bool> CheckValid(string pn,string accessory)
        {
            bool check_acc_existed = await dAO_Product.CheckExisted(accessory);
            bool check_pn_existed = await dAO_Product.CheckExisted(pn);
            bool check_existed = await  CheckExisted(pn, accessory);
            //check trung lap or partno khong ton tai
            if (!check_pn_existed || !check_acc_existed || check_existed==true)
            {
                await dAO_SystemLog.Add("error", $"Check valid false.Detail-> check partno existed({pn}) {check_pn_existed.ToString()} ,check accessory existed({accessory}) :{check_acc_existed.ToString()} ,check existed: {check_existed.ToString()} ");
                return false;
            }
            return true;
        }
        public async Task<bool> Delete(string pn,string accessory)
        {
            if(await connect.ExeDataAsync($"Delete from Accessory_QC where Partno ='{pn}' and Accessory ='{accessory}'"))
            {
                return true;
            }
            return false;
        }
        public async Task<bool> ADD(string pn,string accessory)
        {
            bool checkvalid = await CheckValid(pn, accessory);
            if(checkvalid)
            {
                if (await connect.ExeDataAsync($"Insert into Accessory_QC(Partno,Accessory) values('{pn}','{accessory}')"))
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}
