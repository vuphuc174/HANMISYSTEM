namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_user()
        {
            warehouses = new HashSet<warehouse>();
            warehouses1 = new HashSet<warehouse>();
        }

        [Key]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        public int? permission { get; set; }

        [StringLength(50)]
        public string location { get; set; }

        [StringLength(50)]
        public string idwarehouse { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        [StringLength(50)]
        public string idposition { get; set; }

        [StringLength(10)]
        public string language { get; set; }

        public virtual user_position user_position { get; set; }

        public virtual warehouse warehouse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<warehouse> warehouses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<warehouse> warehouses1 { get; set; }
    }
}
