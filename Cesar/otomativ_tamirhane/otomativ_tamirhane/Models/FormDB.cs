namespace otomativ_tamirhane.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FormDB : DbContext
    {
        public FormDB()
            : base("name=FormDB")
        {
        }

        public virtual DbSet<arac_ID> arac_ID { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<yeni_kayit> yeni_kayit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<yeni_kayit>()
                .HasOptional(e => e.arac_ID)
                .WithRequired(e => e.yeni_kayit);
        }
    }
}
