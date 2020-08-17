namespace HANMISYSTEM.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HANMI : DbContext
    {
        public HANMI()
            : base("name=HANMI")
        {
        }

        public virtual DbSet<bom> boms { get; set; }
        public virtual DbSet<bomdaiban> bomdaibans { get; set; }
        public virtual DbSet<cargo> cargoes { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<categorywarehouse> categorywarehouses { get; set; }
        public virtual DbSet<dateofmanufacture> dateofmanufactures { get; set; }
        public virtual DbSet<location> locations { get; set; }
        public virtual DbSet<packing> packings { get; set; }
        public virtual DbSet<packinginfo> packinginfoes { get; set; }
        public virtual DbSet<packingstandard> packingstandards { get; set; }
        public virtual DbSet<productionplan> productionplans { get; set; }
        public virtual DbSet<productionstatu> productionstatus { get; set; }
        public virtual DbSet<runingstatu> runingstatus { get; set; }
        public virtual DbSet<slipout> slipouts { get; set; }
        public virtual DbSet<stocklastmonth> stocklastmonths { get; set; }
        public virtual DbSet<tbl_importtmp> tbl_importtmp { get; set; }
        public virtual DbSet<tbl_user> tbl_user { get; set; }
        public virtual DbSet<unit> units { get; set; }
        public virtual DbSet<updatestatu> updatestatus { get; set; }
        public virtual DbSet<user_position> user_position { get; set; }
        public virtual DbSet<warehouse> warehouses { get; set; }
        public virtual DbSet<position> positions { get; set; }
        public virtual DbSet<stock> stocks { get; set; }
        public virtual DbSet<tbl_nghistory> tbl_nghistory { get; set; }
        public virtual DbSet<ioview> ioviews { get; set; }
        public virtual DbSet<overview> overviews { get; set; }
        public virtual DbSet<view_checkposition> view_checkposition { get; set; }
        public virtual DbSet<view_packing_standard> view_packing_standard { get; set; }
        public virtual DbSet<view_report_delivery> view_report_delivery { get; set; }
        public virtual DbSet<view_report_injection> view_report_injection { get; set; }
        public virtual DbSet<view_report_printing> view_report_printing { get; set; }
        public virtual DbSet<view_report_production> view_report_production { get; set; }
        public virtual DbSet<view_report_resin> view_report_resin { get; set; }
        public virtual DbSet<view_report_warehouse> view_report_warehouse { get; set; }
        public virtual DbSet<view_stock_injection> view_stock_injection { get; set; }
        public virtual DbSet<view_stock_injection_location> view_stock_injection_location { get; set; }
        public virtual DbSet<view_stock_printing_location> view_stock_printing_location { get; set; }
        public virtual DbSet<view_stock_production> view_stock_production { get; set; }
        public virtual DbSet<view_stock_resin> view_stock_resin { get; set; }
        public virtual DbSet<view_stock_warehouse> view_stock_warehouse { get; set; }
        public virtual DbSet<view_stock_warehouse_location> view_stock_warehouse_location { get; set; }
        public virtual DbSet<view_stock_warehouse1> view_stock_warehouse1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<bom>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<bom>()
                .Property(e => e.rawpartno)
                .IsUnicode(false);

            modelBuilder.Entity<bomdaiban>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<bomdaiban>()
                .Property(e => e.rawpartno)
                .IsUnicode(false);

            modelBuilder.Entity<cargo>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<cargo>()
                .Property(e => e.idcategory)
                .IsUnicode(false);

            modelBuilder.Entity<cargo>()
                .Property(e => e.idunit)
                .IsUnicode(false);

            modelBuilder.Entity<cargo>()
                .Property(e => e.process)
                .IsUnicode(false);

            modelBuilder.Entity<cargo>()
                .Property(e => e.tradingpartnumber)
                .IsUnicode(false);

            modelBuilder.Entity<cargo>()
                .HasMany(e => e.boms)
                .WithRequired(e => e.cargo)
                .HasForeignKey(e => e.partno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cargo>()
                .HasMany(e => e.boms1)
                .WithRequired(e => e.cargo1)
                .HasForeignKey(e => e.rawpartno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cargo>()
                .HasMany(e => e.bomdaibans)
                .WithRequired(e => e.cargo)
                .HasForeignKey(e => e.partno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cargo>()
                .HasMany(e => e.bomdaibans1)
                .WithRequired(e => e.cargo1)
                .HasForeignKey(e => e.rawpartno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cargo>()
                .HasMany(e => e.packingstandards)
                .WithRequired(e => e.cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cargo>()
                .HasMany(e => e.productionplans)
                .WithRequired(e => e.cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cargo>()
                .HasMany(e => e.productionstatus)
                .WithRequired(e => e.cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cargo>()
                .HasMany(e => e.stocks)
                .WithRequired(e => e.cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cargo>()
                .HasMany(e => e.stocklastmonths)
                .WithRequired(e => e.cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cargo>()
                .HasMany(e => e.tbl_nghistory)
                .WithRequired(e => e.cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cargo>()
                .HasMany(e => e.updatestatus)
                .WithRequired(e => e.cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<category>()
                .Property(e => e.idcategory)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .HasMany(e => e.cargoes)
                .WithRequired(e => e.category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<categorywarehouse>()
                .Property(e => e.idcategory)
                .IsUnicode(false);

            modelBuilder.Entity<dateofmanufacture>()
                .Property(e => e.idpack)
                .IsUnicode(false);

            modelBuilder.Entity<location>()
                .Property(e => e.idlocation)
                .IsUnicode(false);

            modelBuilder.Entity<location>()
                .Property(e => e.idwarehouse)
                .IsUnicode(false);

            modelBuilder.Entity<location>()
                .HasMany(e => e.productionplans)
                .WithRequired(e => e.location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<location>()
                .HasMany(e => e.productionstatus)
                .WithRequired(e => e.location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<location>()
                .HasMany(e => e.runingstatus)
                .WithRequired(e => e.location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<location>()
                .HasMany(e => e.updatestatus)
                .WithRequired(e => e.location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<packing>()
                .Property(e => e.idpacking)
                .IsUnicode(false);

            modelBuilder.Entity<packing>()
                .HasMany(e => e.packingstandards)
                .WithRequired(e => e.packing)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<packinginfo>()
                .Property(e => e.idpack)
                .IsUnicode(false);

            modelBuilder.Entity<packinginfo>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<packinginfo>()
                .Property(e => e.idlocation)
                .IsUnicode(false);

            modelBuilder.Entity<packinginfo>()
                .Property(e => e.idwarehouse)
                .IsUnicode(false);

            modelBuilder.Entity<packinginfo>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<packingstandard>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<packingstandard>()
                .Property(e => e.idpacking)
                .IsUnicode(false);

            modelBuilder.Entity<productionplan>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<productionplan>()
                .Property(e => e.idwarehouse)
                .IsUnicode(false);

            modelBuilder.Entity<productionplan>()
                .Property(e => e.idlocation)
                .IsUnicode(false);

            modelBuilder.Entity<productionstatu>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<productionstatu>()
                .Property(e => e.idwarehouse)
                .IsUnicode(false);

            modelBuilder.Entity<productionstatu>()
                .Property(e => e.idlocation)
                .IsUnicode(false);

            modelBuilder.Entity<runingstatu>()
                .Property(e => e.idwarehouse)
                .IsUnicode(false);

            modelBuilder.Entity<runingstatu>()
                .Property(e => e.idlocation)
                .IsUnicode(false);

            modelBuilder.Entity<runingstatu>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<runingstatu>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<slipout>()
                .Property(e => e.idslipout)
                .IsUnicode(false);

            modelBuilder.Entity<slipout>()
                .Property(e => e.idwarehouse)
                .IsUnicode(false);

            modelBuilder.Entity<slipout>()
                .Property(e => e.idcustomer)
                .IsUnicode(false);

            modelBuilder.Entity<stocklastmonth>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<stocklastmonth>()
                .Property(e => e.idwarehouse)
                .IsUnicode(false);

            modelBuilder.Entity<stocklastmonth>()
                .Property(e => e.yearmonth)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_importtmp>()
                .Property(e => e.idpack)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_importtmp>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_importtmp>()
                .Property(e => e.idsupplier)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_importtmp>()
                .Property(e => e.idwarehouse)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_user>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_user>()
                .Property(e => e.idwarehouse)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_user>()
                .Property(e => e.idposition)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_user>()
                .Property(e => e.language)
                .IsUnicode(false);

            modelBuilder.Entity<unit>()
                .Property(e => e.idunit)
                .IsUnicode(false);

            modelBuilder.Entity<updatestatu>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<updatestatu>()
                .Property(e => e.idlocation)
                .IsUnicode(false);

            modelBuilder.Entity<user_position>()
                .Property(e => e.idposition)
                .IsUnicode(false);

            modelBuilder.Entity<warehouse>()
                .Property(e => e.idwarehouse)
                .IsUnicode(false);

            modelBuilder.Entity<warehouse>()
                .Property(e => e.idcategory)
                .IsUnicode(false);

            modelBuilder.Entity<warehouse>()
                .Property(e => e.sign)
                .IsUnicode(false);

            modelBuilder.Entity<warehouse>()
                .HasMany(e => e.packinginfoes)
                .WithRequired(e => e.warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<warehouse>()
                .HasMany(e => e.productionplans)
                .WithRequired(e => e.warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<warehouse>()
                .HasMany(e => e.productionstatus)
                .WithRequired(e => e.warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<warehouse>()
                .HasMany(e => e.runingstatus)
                .WithRequired(e => e.warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<warehouse>()
                .HasMany(e => e.stocklastmonths)
                .WithRequired(e => e.warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<warehouse>()
                .HasMany(e => e.tbl_user)
                .WithOptional(e => e.warehouse)
                .HasForeignKey(e => e.idwarehouse);

            modelBuilder.Entity<warehouse>()
                .HasMany(e => e.stocks)
                .WithRequired(e => e.warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<warehouse>()
                .HasMany(e => e.tbl_nghistory)
                .WithRequired(e => e.warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<warehouse>()
                .HasMany(e => e.tbl_user1)
                .WithMany(e => e.warehouses)
                .Map(m => m.ToTable("tbl_user_e_permission").MapLeftKey("idwarehouse").MapRightKey("username"));

            modelBuilder.Entity<warehouse>()
                .HasMany(e => e.tbl_user2)
                .WithMany(e => e.warehouses1)
                .Map(m => m.ToTable("tbl_user_permission").MapLeftKey("idwarehouse").MapRightKey("username"));

            modelBuilder.Entity<position>()
                .Property(e => e.idposition)
                .IsUnicode(false);

            modelBuilder.Entity<position>()
                .Property(e => e.idwarehouse)
                .IsUnicode(false);

            modelBuilder.Entity<stock>()
                .Property(e => e.idwarehouse)
                .IsUnicode(false);

            modelBuilder.Entity<stock>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_nghistory>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_nghistory>()
                .Property(e => e.idlocation)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_nghistory>()
                .Property(e => e.idwarehouse)
                .IsUnicode(false);

            modelBuilder.Entity<ioview>()
                .Property(e => e.idslipout)
                .IsUnicode(false);

            modelBuilder.Entity<ioview>()
                .Property(e => e.idpack)
                .IsUnicode(false);

            modelBuilder.Entity<ioview>()
                .Property(e => e.idwarehouse)
                .IsUnicode(false);

            modelBuilder.Entity<ioview>()
                .Property(e => e.idcustomer)
                .IsUnicode(false);

            modelBuilder.Entity<ioview>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<overview>()
                .Property(e => e.idlocation)
                .IsUnicode(false);

            modelBuilder.Entity<overview>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<view_checkposition>()
                .Property(e => e.idwarehouse)
                .IsUnicode(false);

            modelBuilder.Entity<view_checkposition>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<view_checkposition>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<view_packing_standard>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<view_report_delivery>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<view_report_injection>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<view_report_printing>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<view_report_production>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<view_report_resin>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<view_report_warehouse>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<view_stock_injection>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<view_stock_injection_location>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<view_stock_injection_location>()
                .Property(e => e.idpack)
                .IsUnicode(false);

            modelBuilder.Entity<view_stock_injection_location>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<view_stock_printing_location>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<view_stock_printing_location>()
                .Property(e => e.idpack)
                .IsUnicode(false);

            modelBuilder.Entity<view_stock_printing_location>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<view_stock_production>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<view_stock_resin>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<view_stock_warehouse>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<view_stock_warehouse>()
                .Property(e => e.idwarehouse)
                .IsUnicode(false);

            modelBuilder.Entity<view_stock_warehouse_location>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<view_stock_warehouse_location>()
                .Property(e => e.idpack)
                .IsUnicode(false);

            modelBuilder.Entity<view_stock_warehouse_location>()
                .Property(e => e.partno)
                .IsUnicode(false);

            modelBuilder.Entity<view_stock_warehouse_location>()
                .Property(e => e.idwarehouse)
                .IsUnicode(false);

            modelBuilder.Entity<view_stock_warehouse1>()
                .Property(e => e.Partno)
                .IsUnicode(false);
        }
    }
}
