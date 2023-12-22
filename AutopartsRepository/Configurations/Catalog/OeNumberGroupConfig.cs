using AutopartsEntity.Catalog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutopartsRepository.Configurations.Catalog
{
    public class OeNumberGroupConfig : IEntityTypeConfiguration<OeNumberGroup>
    {
        public void Configure(EntityTypeBuilder<OeNumberGroup> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired()
                .HasMaxLength(10);
            builder.Property(x => x.UpdateDate)
                .HasMaxLength(10);
            builder.Property(x => x.RowVersion)
                .IsRowVersion();

            builder.Property(x => x.OeNumberInGroupId).IsRequired();
            builder.Property(x => x.OeId).IsRequired();

            builder.HasData(
                new OeNumberGroup { Id = 1, OeId = 1, OeNumberInGroupId = 1 },
                new OeNumberGroup { Id = 2, OeId = 2, OeNumberInGroupId = 1 },
                new OeNumberGroup { Id = 3, OeId = 3, OeNumberInGroupId = 1 },
                new OeNumberGroup { Id = 4, OeId = 4, OeNumberInGroupId = 1 },
                new OeNumberGroup { Id = 5, OeId = 5, OeNumberInGroupId = 1 },
                new OeNumberGroup { Id = 6, OeId = 6, OeNumberInGroupId = 1 },
                new OeNumberGroup { Id = 7, OeId = 7, OeNumberInGroupId = 1 },
                new OeNumberGroup { Id = 8, OeId = 8, OeNumberInGroupId = 1 },
                new OeNumberGroup { Id = 9, OeId = 9, OeNumberInGroupId = 1 },
                new OeNumberGroup { Id = 10, OeId = 10, OeNumberInGroupId = 1 },
                new OeNumberGroup { Id = 11, OeId = 11, OeNumberInGroupId = 1 },
                new OeNumberGroup { Id = 12, OeId = 12, OeNumberInGroupId = 1 },
                new OeNumberGroup { Id = 13, OeId = 13, OeNumberInGroupId = 1 },
                new OeNumberGroup { Id = 14, OeId = 14, OeNumberInGroupId = 1 }
                );
        }
    }
}