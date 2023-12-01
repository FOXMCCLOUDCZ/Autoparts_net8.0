using AutopartsEntity.Catalog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutopartsRepository.Configurations.Catalog
{
    public class ModelConfig : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired()
                .HasMaxLength(10);
            builder.Property(x => x.UpdateDate)
                .HasMaxLength(10);
            builder.Property(x => x.RowVersion)
                .IsRowVersion();

            builder.Property(x => x.ManufacturerId).IsRequired();
            builder.Property(x => x.ModelName).IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.MadeBy).IsRequired()
                .HasMaxLength(10);
            builder.Property(x => x.MadeTo).IsRequired()
                .HasMaxLength(10);
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
                new Model { Id = 1, ManufacturerId = 1, ModelName = "100 (431, 433, 434, C2)", MadeBy = new DateTime(1976,6,1), MadeTo = new DateTime(1984,8,31), IsPKW = true, IsLKW = false, IsMotorcycle = false, IsAgriculturalMachinery = false, IsCompressors = false, IsConstuctionAndMining = false, IsElectronicDischargeMachines = false, IsEngines = false, IsForkLiftTruck = false, IsIndustrialApplications = false, IsShipsAndBoats = false, IsVacuumPumps = false, IsActive = true },
                new Model { Id = 2, ManufacturerId = 1, ModelName = "100 (443, 444, C3)", MadeBy = new DateTime(1982,8,1), MadeTo = new DateTime(1991,7,31), IsPKW = true, IsLKW = false, IsMotorcycle = false, IsAgriculturalMachinery = false, IsCompressors = false, IsConstuctionAndMining = false, IsElectronicDischargeMachines = false, IsEngines = false, IsForkLiftTruck = false, IsIndustrialApplications = false, IsShipsAndBoats = false, IsVacuumPumps = false, IsActive = true },
                new Model { Id = 3, ManufacturerId = 1, ModelName = "100 (4A2, C4)", MadeBy = new DateTime(1990,12,1), MadeTo = new DateTime(1994,7,31), IsPKW = true, IsLKW = false, IsMotorcycle = false, IsAgriculturalMachinery = false, IsCompressors = false, IsConstuctionAndMining = false, IsElectronicDischargeMachines = false, IsEngines = false, IsForkLiftTruck = false, IsIndustrialApplications = false, IsShipsAndBoats = false, IsVacuumPumps = false, IsActive = true }
                );
        }
    }
}