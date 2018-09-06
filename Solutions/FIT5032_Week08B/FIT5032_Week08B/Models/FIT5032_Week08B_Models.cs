namespace FIT5032_Week08B.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FIT5032_Week08B_Models : DbContext
    {
        public FIT5032_Week08B_Models()
            : base("name=FIT5032_Week08B_Models")
        {
        }

        public virtual DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>()
                .Property(e => e.Path)
                .IsUnicode(false);

            modelBuilder.Entity<Image>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
