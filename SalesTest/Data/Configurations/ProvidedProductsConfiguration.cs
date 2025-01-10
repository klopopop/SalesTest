using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SalesTest.Models;

namespace SalesTest.Data.Configurations
{
    public class ProvidedProductsConfiguration : IEntityTypeConfiguration<ProvidedProducts>
    {
        public void Configure(EntityTypeBuilder<ProvidedProducts> builder)
        {
            builder.HasOne(e => e.Product).WithMany(e => e.ProvidedProducts).HasForeignKey(e => e.ProductId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.SalesPoint).WithMany(e => e.ProvidedProducts).HasForeignKey(e => e.SalesPointId).OnDelete(DeleteBehavior.NoAction);
            builder.HasKey(k => new { k.SalesPointId, k.ProductId });

        }
    }
}
