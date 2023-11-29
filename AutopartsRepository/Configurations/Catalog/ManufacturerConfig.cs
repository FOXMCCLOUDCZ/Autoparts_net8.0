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
            builder.Property(x => x.ManufacturerName).IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.LogoPath)
                .HasMaxLength(500);
            builder.Property(x => x.ManufacturerDescription)
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

            builder.HasData(
                new Manufacturer { Id = 1, TecDoc = 3854, ManufacturerName = "AUDI", IsAutoParts = false, IsPKW = true, IsLKW = false, IsMotorcycle = false, IsAgriculturalMachinery = false, IsCompressors = false, IsConstuctionAndMining = false, IsElectronicDischargeMachines = false, IsEngines = false, IsForkLiftTruck = false, IsIndustrialApplications = false, IsShipsAndBoats = false, IsVacuumPumps = false, IsActive = true },
                new Manufacturer { Id = 2, TecDoc = 1480, ManufacturerName = "MAN", IsAutoParts = false, IsPKW = true, IsLKW = false, IsMotorcycle = false, IsAgriculturalMachinery = false, IsCompressors = false, IsConstuctionAndMining = false, IsElectronicDischargeMachines = false, IsEngines = false, IsForkLiftTruck = false, IsIndustrialApplications = false, IsShipsAndBoats = false, IsVacuumPumps = false, IsActive = true },
                new Manufacturer { Id = 3, TecDoc = 2, ManufacturerName = "SEAT", IsAutoParts = false, IsPKW = true, IsLKW = false, IsMotorcycle = false, IsAgriculturalMachinery = false, IsCompressors = false, IsConstuctionAndMining = false, IsElectronicDischargeMachines = false, IsEngines = false, IsForkLiftTruck = false, IsIndustrialApplications = false, IsShipsAndBoats = false, IsVacuumPumps = false, IsActive = true },
                new Manufacturer { Id = 4, TecDoc = 1360, ManufacturerName = "ŠKODA", IsAutoParts = false, IsPKW = true, IsLKW = false, IsMotorcycle = false, IsAgriculturalMachinery = false, IsCompressors = false, IsConstuctionAndMining = false, IsElectronicDischargeMachines = false, IsEngines = false, IsForkLiftTruck = false, IsIndustrialApplications = false, IsShipsAndBoats = false, IsVacuumPumps = false, IsActive = true },
                new Manufacturer { Id = 5, TecDoc = 881, ManufacturerName = "VOLKSWAGEN", IsAutoParts = false, IsPKW = true, IsLKW = false, IsMotorcycle = false, IsAgriculturalMachinery = false, IsCompressors = false, IsConstuctionAndMining = false, IsElectronicDischargeMachines = false, IsEngines = false, IsForkLiftTruck = false, IsIndustrialApplications = false, IsShipsAndBoats = false, IsVacuumPumps = false, IsActive = true }
                );
        }
    }
}