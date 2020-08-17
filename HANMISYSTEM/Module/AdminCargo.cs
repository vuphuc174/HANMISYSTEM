using HANMISYSTEM.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.Module
{
    public class AdminCargo
    {
        HANMI db = null;
        public AdminCargo()
        {
            db = new HANMI();
        }
        public List<cargo> ListAll()
        {
            return db.cargoes.OrderBy(x => x.partno).ToList();
        }
    }
}
