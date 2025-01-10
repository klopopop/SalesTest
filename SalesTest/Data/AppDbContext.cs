using Microsoft.EntityFrameworkCore;
using SalesTest.Data.Configurations;
using SalesTest.Models;

namespace SalesTest.Data
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {

        public DbSet<Buyer> Buyers { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProvidedProducts> ProvidedProducts { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<SalesPoint> SalesPoints { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProvidedProductsConfiguration());
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries<BaseEntity>().AsEnumerable())
            {
                if (item.State == EntityState.Deleted)
                {
                    item.Entity.IsDeleted = true;
                    item.State = EntityState.Modified;  
                }
             
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        public new DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity => base.Set<TEntity>();



    }
}
