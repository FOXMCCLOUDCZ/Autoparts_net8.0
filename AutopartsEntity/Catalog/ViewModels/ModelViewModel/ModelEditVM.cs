using AutopartsEntity.Catalog.Entities;

namespace AutopartsEntity.Catalog.ViewModels.ModelViewModel
{
    public class ModelEditVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public byte[] RowVersion { get; set; } = null!;

        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; } = null!;
        public string ModelName { get; set; } = null!;
        public DateTime MadeBy { get; set; }
        public DateTime? MadeTo { get; set; } = null;
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