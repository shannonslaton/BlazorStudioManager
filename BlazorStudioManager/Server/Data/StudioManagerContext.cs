using Microsoft.EntityFrameworkCore;
using BlazorStudioManager.Shared;
using BlazorStudioManager.Shared.Models;
using BlazorStudioManager.Shared.IdentityModels;

namespace BlazorStudioManager.Server.Data
{
    public partial class StudioManagerContext : DbContext
    {
        public StudioManagerContext(DbContextOptions<StudioManagerContext> options) : base(options)
        {
        }

        public virtual DbSet<Catalog> Catalogs { get; set; }
        public virtual DbSet<DropDownOption> DropDownOptions { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Catalog>(entity =>
            {
                entity.HasKey(e => e.RecId);
            });

            modelBuilder.Entity<Catalog>().HasData(
                new Catalog() { RecId = 1, CatalogName = "Performance"},
                new Catalog() { RecId = 2, CatalogName = "Sound" },
                new Catalog() { RecId = 3, CatalogName = "Lights" }
            );

            modelBuilder.Entity<DropDownOption>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.HasIndex(e => new { e.DdoType, e.DdoTitle })
                    .IsUnique();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
