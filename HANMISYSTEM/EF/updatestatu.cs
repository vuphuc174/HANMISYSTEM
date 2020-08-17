namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class updatestatu
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string partno { get; set; }

        public double? currenttarget { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime productiondate { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string idlocation { get; set; }

        public virtual cargo cargo { get; set; }

        public virtual location location { get; set; }
    }
}
