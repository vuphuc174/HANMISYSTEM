namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_stock_warehouse
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string partno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string partname { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string idwarehouse { get; set; }

        public int? QTY { get; set; }

        public int? BOXQTY { get; set; }

        public int? BAGQTY { get; set; }

        public int? CARTQTY { get; set; }

        public int? Trayqty { get; set; }

        public int? Rollqty { get; set; }

        public int? Canqty { get; set; }

        public int? Palletqty { get; set; }
    }
}
