using Microsoft.EntityFrameworkCore;
using SalesTest.Models;

namespace SalesTest.Data
{
    public class AppDbContext(DbContextOptions options):DbContext(options)
    {

        public DbSet<Buyer> Buyers { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProvidedProducts> ProvidedProducts { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<SalesPoint> SalesPoints { get; set; }
    }
}
