namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("packing")]
    public partial class packing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public packing()
        {
            packingstandards = new HashSet<packingstandard>();
        }

        [Key]
        [StringLength(50)]
        public string idpacking { get; set; }

        [Required]
        [StringLength(100)]
        public string namepacking { get; set; }

        public int maxquantity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<packingstandard> packingstandards { get; set; }
    }
}
