using AutopartsCore.BaseEntities;

namespace AutopartsEntity.Catalog.Entities
{
    public class Model : BaseEntity
    {
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; } = null!;
        public string ModelName { get; set; } = null!;
        public DateTime MadeBy { get; set; }
        public DateTime MadeTo { get; set;}
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