using AutopartsEntity.Catalog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutopartsRepository.Configurations.Catalog
{
    internal class OeConfig : IEntityTypeConfiguration<Oe>
    {
        public void Configure(EntityTypeBuilder<Oe> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired()
                .HasMaxLength(10);
            builder.Property(x => x.UpdateDate)
                .HasMaxLength(10);
            builder.Property(x => x.RowVersion)
                .IsRowVersion();

            builder.Property(x => x.ManufacturerId).IsRequired();
            builder.Property(x => x.OeNumber).IsRequired()
                .HasMaxLength(20);
            builder.Property(x => x.IsActive)
                .HasDefaultValue(false);

            builder.HasData(
                new Oe { Id = 1, ManufacturerId = 1, OeNumber = "03N 115 466", IsActive = true },
                new Oe { Id = 2, ManufacturerId = 1, OeNumber = "03N 115 562", IsActive = true },
                new Oe { Id = 3, ManufacturerId = 1, OeNumber = "03N 115 562 B", IsActive = true },
                new Oe { Id = 4, ManufacturerId = 2, OeNumber = "65.05504-6000", IsActive = true },
                new Oe { Id = 5, ManufacturerId = 2, OeNumber = "65.05504-6002", IsActive = true },
                new Oe { Id = 6, ManufacturerId = 3, OeNumber = "03N 115 466", IsActive = true },
                new Oe { Id = 7, ManufacturerId = 3, OeNumber = "03N 115 562", IsActive = true },
                new Oe { Id = 8, ManufacturerId = 3, OeNumber = "03N 115 562 B", IsActive = true },
                new Oe { Id = 9, ManufacturerId = 4, OeNumber = "03N 115 466", IsActive = true },
                new Oe { Id = 10, ManufacturerId = 4, OeNumber = "03N 115 562", IsActive = true },
                new Oe { Id = 11, ManufacturerId = 4, OeNumber = "03N 115 562 B", IsActive = true },
                new Oe { Id = 12, ManufacturerId = 5, OeNumber = "03N 115 466", IsActive = true },
                new Oe { Id = 13, ManufacturerId = 5, OeNumber = "03N 115 562", IsActive = true },
                new Oe { Id = 14, ManufacturerId = 5, OeNumber = "03N 115 562 B", IsActive = true }
                );
        }
    }
}