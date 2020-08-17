namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("productionplan")]
    public partial class productionplan
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string partno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string idwarehouse { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime productiondate { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string idlocation { get; set; }

        [Column("productionplan")]
        public int productionplan1 { get; set; }

        public virtual cargo cargo { get; set; }

        public virtual location location { get; set; }

        public virtual warehouse warehouse { get; set; }
    }
}
