namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class productionstatu
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
        [Column(Order = 2)]
        [StringLength(50)]
        public string idlocation { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime productiondate { get; set; }

        public DateTime? starttime { get; set; }

        public DateTime? stoptime { get; set; }

        public double? lastesttarget { get; set; }

        public string remark { get; set; }

        public DateTime? continuetime { get; set; }

        public virtual cargo cargo { get; set; }

        public virtual location location { get; set; }

        public virtual warehouse warehouse { get; set; }
    }
}
