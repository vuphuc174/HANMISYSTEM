namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("categorywarehouse")]
    public partial class categorywarehouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public categorywarehouse()
        {
            warehouses = new HashSet<warehouse>();
        }

        [Key]
        [StringLength(50)]
        public string idcategory { get; set; }

        [Required]
        [StringLength(50)]
        public string namecategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<warehouse> warehouses { get; set; }
    }
}
