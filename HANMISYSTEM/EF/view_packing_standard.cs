namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_packing_standard
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string partno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string partname { get; set; }

        public int? BOX { get; set; }

        public int? BAG { get; set; }

        public int? CRT { get; set; }

        public int? TRA { get; set; }

        public int? ROL { get; set; }

        public int? PAL { get; set; }

        public int? CAN { get; set; }
    }
}
