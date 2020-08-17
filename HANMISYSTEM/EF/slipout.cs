namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("slipout")]
    public partial class slipout
    {
        [Key]
        [StringLength(15)]
        public string idslipout { get; set; }

        public DateTime? dateout { get; set; }

        [StringLength(50)]
        public string idwarehouse { get; set; }

        [StringLength(50)]
        public string idcustomer { get; set; }

        public virtual warehouse warehouse { get; set; }
    }
}
