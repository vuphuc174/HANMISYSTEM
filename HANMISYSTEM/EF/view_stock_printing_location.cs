namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_stock_printing_location
    {
        [StringLength(50)]
        public string position { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string idpack { get; set; }

        [StringLength(50)]
        public string partno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string partname { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int quantity { get; set; }
    }
}
