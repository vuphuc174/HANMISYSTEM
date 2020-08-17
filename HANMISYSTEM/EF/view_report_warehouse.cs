namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_report_warehouse
    {
        [Key]
        [StringLength(50)]
        public string partno { get; set; }

        public int? stocklastmonth { get; set; }

        public int? inother { get; set; }

        public int? inproduction { get; set; }

        public int? outother { get; set; }

        public int? inventory { get; set; }

        public int? ng { get; set; }

        public int? lost { get; set; }
    }
}
