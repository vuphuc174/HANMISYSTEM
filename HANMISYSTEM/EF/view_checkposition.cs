namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_checkposition
    {
        [Key]
        [StringLength(50)]
        public string idwarehouse { get; set; }

        [StringLength(50)]
        public string partno { get; set; }

        [StringLength(50)]
        public string position { get; set; }

        public int? sl { get; set; }

        public DateTime? datefirstin { get; set; }
    }
}
