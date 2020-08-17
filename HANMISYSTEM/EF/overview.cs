namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("overview")]
    public partial class overview
    {
        public long? r { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string idlocation { get; set; }

        [StringLength(100)]
        public string namelocation1 { get; set; }

        public int? inventory { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string partno { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int productionplan { get; set; }

        public int? actual { get; set; }

        public int? ng { get; set; }

        [StringLength(151)]
        public string namelocation { get; set; }
    }
}
