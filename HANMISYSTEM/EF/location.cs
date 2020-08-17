namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("location")]
    public partial class location
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public location()
        {
            packinginfoes = new HashSet<packinginfo>();
            productionplans = new HashSet<productionplan>();
            productionstatus = new HashSet<productionstatu>();
            runingstatus = new HashSet<runingstatu>();
            tbl_nghistory = new HashSet<tbl_nghistory>();
            updatestatus = new HashSet<updatestatu>();
        }

        [Key]
        [StringLength(50)]
        public string idlocation { get; set; }

        [Required]
        [StringLength(100)]
        public string namelocation { get; set; }

        [StringLength(50)]
        public string idwarehouse { get; set; }

        [StringLength(100)]
        public string namelocation1 { get; set; }

        public virtual warehouse warehouse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<packinginfo> packinginfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<productionplan> productionplans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<productionstatu> productionstatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<runingstatu> runingstatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_nghistory> tbl_nghistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<updatestatu> updatestatus { get; set; }
    }
}
