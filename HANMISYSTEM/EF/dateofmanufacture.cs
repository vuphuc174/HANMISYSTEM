namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dateofmanufacture")]
    public partial class dateofmanufacture
    {
        [Key]
        [StringLength(50)]
        public string idpack { get; set; }

        [Column(TypeName = "date")]
        public DateTime manufacturedate { get; set; }
    }
}
