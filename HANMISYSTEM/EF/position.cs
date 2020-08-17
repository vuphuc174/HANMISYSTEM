namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("position")]
    public partial class position
    {
        [Key]
        [StringLength(50)]
        public string idposition { get; set; }

        [StringLength(50)]
        public string idwarehouse { get; set; }

        public virtual warehouse warehouse { get; set; }
    }
}
