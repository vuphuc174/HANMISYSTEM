namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("packingstandard")]
    public partial class packingstandard
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string partno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string idpacking { get; set; }

        public double quantity { get; set; }

        public virtual cargo cargo { get; set; }

        public virtual packing packing { get; set; }
    }
}
