using AutopartsEntity.Catalog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutopartsRepository.Configurations.Catalog
{
    public class ManufacturerConfig : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired()
                .HasMaxLength(10);
            builder.Property(x => x.UpdateDate)
                .HasMaxLength(10);
            builder.Property(x => x.RowVersion)
                .IsRowVersion();

            builder.Property(x => x.TecDoc)
                .HasMaxLength(6);
            builder.Property(x => x.Title).IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.LogoPath)
                .HasMaxLength(500);
            builder.Property(x => x.Description)
                .HasMaxLength(2000);
            builder.Property(x => x.IsAutoParts)
                .HasDefaultValue(false);
            builder.Property(x => x.IsPKW)
                .HasDefaultValue(false);
            builder.Property(x => x.IsLKW)
                .HasDefaultValue(false);
            builder.Property(x => x.IsMotorcycle)
                .HasDefaultValue(false);
            builder.Property(x => x.IsAgriculturalMachinery)
                .HasDefaultValue(false);
            builder.Property(x => x.IsCompressors)
                .HasDefaultValue(false);
            builder.Property(x => x.IsConstuctionAndMining)
                .HasDefaultValue(false);
            builder.Property(x => x.IsElectronicDischargeMachines)
                .HasDefaultValue(false);
            builder.Property(x => x.IsEngines)
                .HasDefaultValue(false);
            builder.Property(x => x.IsForkLiftTruck)
                .HasDefaultValue(false);
            builder.Property(x => x.IsIndustrialApplications)
                .HasDefaultValue(false);
            builder.Property(x => x.IsShipsAndBoats)
                .HasDefaultValue(false);
            builder.Property(x => x.IsVacuumPumps)
                .HasDefaultValue(false);
            builder.Property(x => x.IsActive)
                .HasDefaultValue(false);
        }
    }
}