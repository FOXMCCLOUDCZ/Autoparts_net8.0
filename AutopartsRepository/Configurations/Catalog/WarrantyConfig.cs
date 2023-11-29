using AutopartsEntity.Catalog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutopartsRepository.Configurations.Catalog
{
    public class WarrantyConfig : IEntityTypeConfiguration<Warranty>
    {
        public void Configure(EntityTypeBuilder<Warranty> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired()
                .HasMaxLength(10);
            builder.Property(x => x.UpdateDate)
                .HasMaxLength(10);
            builder.Property(x => x.RowVersion)
                .IsRowVersion();

            builder.Property(x => x.WarrantyPeriod).IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.IsActive).IsRequired()
                .HasDefaultValue(false);

            builder.HasData(
                new Warranty { Id = 1, WarrantyPeriod = "6 měsíců", IsActive = true },
                new Warranty { Id = 2, WarrantyPeriod = "12 měsíců", IsActive = true },
                new Warranty { Id = 3, WarrantyPeriod = "24 měsíců", IsActive = true },
                new Warranty { Id = 4, WarrantyPeriod = "36 měsíců", IsActive = true },
                new Warranty { Id = 5, WarrantyPeriod = "48 měsíců", IsActive = false },
                new Warranty { Id = 6, WarrantyPeriod = "60 měsíců", IsActive = false }
            );
        }
    }
}