namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ioview")]
    public partial class ioview
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string idslipout { get; set; }

        [StringLength(50)]
        public string idpack { get; set; }

        [StringLength(50)]
        public string idwarehouse { get; set; }

        [StringLength(50)]
        public string idcustomer { get; set; }

        [StringLength(50)]
        public string partno { get; set; }

        public int? quantity { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string fromwarehouse { get; set; }

        public DateTime? dateout { get; set; }

        public string carnumber { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string towarehouse { get; set; }
    }
}
