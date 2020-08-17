namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_stock_injection
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string partno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string partname { get; set; }

        public int? Qty { get; set; }

        public int? Boxqty { get; set; }

        public int? Bagqty { get; set; }

        public int? Cartqty { get; set; }

        public int? Trayqty { get; set; }

        public int? Rollqty { get; set; }

        public int? Canqty { get; set; }

        public int? Palletqty { get; set; }
    }
}
