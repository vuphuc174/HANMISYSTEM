namespace HANMISYSTEM.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cargo")]
    public partial class cargo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cargo()
        {
            boms = new HashSet<bom>();
            boms1 = new HashSet<bom>();
            bomdaibans = new HashSet<bomdaiban>();
            bomdaibans1 = new HashSet<bomdaiban>();
            packinginfoes = new HashSet<packinginfo>();
            packingstandards = new HashSet<packingstandard>();
            productionplans = new HashSet<productionplan>();
            productionstatus = new HashSet<productionstatu>();
            stocks = new HashSet<stock>();
            stocklastmonths = new HashSet<stocklastmonth>();
            tbl_importtmp = new HashSet<tbl_importtmp>();
            tbl_nghistory = new HashSet<tbl_nghistory>();
            updatestatus = new HashSet<updatestatu>();
        }

        [Key]
        [StringLength(50)]
        public string partno { get; set; }

        [Required]
        [StringLength(100)]
        public string partname { get; set; }

        [Required]
        [StringLength(50)]
        public string idcategory { get; set; }

        public string specificationinfo { get; set; }

        public int? productivity { get; set; }

        [StringLength(10)]
        public string idunit { get; set; }

        [StringLength(50)]
        public string process { get; set; }

        [StringLength(50)]
        public string tradingpartnumber { get; set; }

        [StringLength(200)]
        public string othername { get; set; }
        [StringLength(50)]
        public string idwarehouse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bom> boms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bom> boms1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bomdaiban> bomdaibans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bomdaiban> bomdaibans1 { get; set; }

        public virtual category category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<packinginfo> packinginfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<packingstandard> packingstandards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<productionplan> productionplans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<productionstatu> productionstatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stock> stocks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stocklastmonth> stocklastmonths { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_importtmp> tbl_importtmp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_nghistory> tbl_nghistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<updatestatu> updatestatus { get; set; }

        public virtual unit unit { get; set; }
    }
}
