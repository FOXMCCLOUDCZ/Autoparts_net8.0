using AutopartsEntity.Catalog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutopartsRepository.Configurations.Catalog
{
    public class ProductGroupConfig : IEntityTypeConfiguration<ProductGroup>
    {
        public void Configure(EntityTypeBuilder<ProductGroup> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired()
                .HasMaxLength(10);
            builder.Property(x => x.UpdateDate)
                .HasMaxLength(10);
            builder.Property(x => x.RowVersion)
                .IsRowVersion();

            builder.Property(x => x.TecDoc)
                .HasMaxLength(6);
            builder.Property(x => x.ProductGroupName).IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.IsActive)
                .HasDefaultValue(false);

            builder.HasData(
                new ProductGroup { Id = 1, TecDoc = 4, ProductGroupName = "Olejový filtr", IsActive = true }
                );
        }
    }
}