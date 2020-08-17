namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_stock_production
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string partno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string partname { get; set; }

        public int? qty { get; set; }

        public int? boxqty { get; set; }

        public int? bagqty { get; set; }

        public int? cartqty { get; set; }
    }
}
