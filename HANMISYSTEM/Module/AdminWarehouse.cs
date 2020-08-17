using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using HANMISYSTEM.EF;

namespace HANMISYSTEM.Module
{
     class  AdminWarehouse
    {
         HANMI db = null;
        public  List<warehouse> ListAllWarehouse()
        {
            return db.warehouses.ToList();
        }
    }
}
