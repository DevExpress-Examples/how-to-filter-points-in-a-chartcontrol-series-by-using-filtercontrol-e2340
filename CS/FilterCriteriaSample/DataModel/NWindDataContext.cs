namespace FilterCriteriaSample {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NWindDataContext : DbContext {
        public NWindDataContext()
            : base("name=NWindDataContext") {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Product>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.EAN13)
                .IsUnicode(false);
        }
    }
}
