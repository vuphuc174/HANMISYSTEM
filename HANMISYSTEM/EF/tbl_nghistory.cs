namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_nghistory
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string partno { get; set; }

        [StringLength(50)]
        public string idlocation { get; set; }

        public int? quantity { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string idwarehouse { get; set; }

        public DateTime? productiontime { get; set; }

        [StringLength(100)]
        public string defect { get; set; }

        public virtual cargo cargo { get; set; }

        public virtual location location { get; set; }

        public virtual warehouse warehouse { get; set; }
    }
}
