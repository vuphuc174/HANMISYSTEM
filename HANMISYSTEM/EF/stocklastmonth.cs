namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stocklastmonth")]
    public partial class stocklastmonth
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string partno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string idwarehouse { get; set; }

        public int? quantity { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string yearmonth { get; set; }

        public virtual cargo cargo { get; set; }

        public virtual warehouse warehouse { get; set; }
    }
}
