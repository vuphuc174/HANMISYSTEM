namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("packinginfo")]
    public partial class packinginfo
    {
        [Key]
        [StringLength(50)]
        public string idpack { get; set; }

        [StringLength(50)]
        public string partno { get; set; }

        public int quantity { get; set; }

        public DateTime packingdate { get; set; }

        [StringLength(50)]
        public string idlocation { get; set; }

        [Required]
        [StringLength(50)]
        public string idwarehouse { get; set; }

        [StringLength(50)]
        public string position { get; set; }

        public virtual cargo cargo { get; set; }

        public virtual location location { get; set; }

        public virtual warehouse warehouse { get; set; }
    }
}
