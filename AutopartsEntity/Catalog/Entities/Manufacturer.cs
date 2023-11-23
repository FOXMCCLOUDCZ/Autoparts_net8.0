using AutopartsCore.BaseEntities;

namespace AutopartsEntity.Catalog.Entities
{
    public class Manufacturer : BaseEntity
    {
        public int? TecDoc { get; set; }
        public string Title { get; set; } = null!;
        public string? LogoPath { get; set; }
        public string? Description { get; set; }
        public bool IsAutoParts { get; set; } = false;
        public bool IsPKW { get; set; } = false;
        public bool IsLKW { get; set; } = false;
        public bool IsMotorcycle { get; set; } = false;
        public bool IsAgriculturalMachinery { get; set; } = false;
        public bool IsCompressors { get; set; } = false;
        public bool IsConstuctionAndMining { get; set; } = false;
        public bool IsElectronicDischargeMachines { get; set; } = false;
        public bool IsEngines { get; set; } = false;
        public bool IsForkLiftTruck { get; set; } = false;
        public bool IsIndustrialApplications { get; set; } = false;
        public bool IsShipsAndBoats { get; set; } = false;
        public bool IsVacuumPumps { get; set; } = false;
        public bool IsActive { get; set; } = false;
    }
}