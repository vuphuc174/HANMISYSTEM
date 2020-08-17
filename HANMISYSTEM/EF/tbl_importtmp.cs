namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_importtmp
    {
        [Key]
        [StringLength(50)]
        public string idpack { get; set; }

        [StringLength(50)]
        public string partno { get; set; }

        public int? quantity { get; set; }

        public DateTime? datein { get; set; }

        [StringLength(50)]
        public string idsupplier { get; set; }

        [StringLength(50)]
        public string idwarehouse { get; set; }

        public virtual cargo cargo { get; set; }

        public virtual warehouse warehouse { get; set; }
    }
}
