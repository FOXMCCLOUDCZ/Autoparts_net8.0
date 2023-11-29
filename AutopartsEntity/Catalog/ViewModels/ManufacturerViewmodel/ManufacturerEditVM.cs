namespace AutopartsEntity.Catalog.ViewModels.ManufacturerViewmodel
{
    public class ManufacturerEditVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public byte[] RowVersion { get; set; } = null!;

        public int? TecDoc { get; set; }
        public string ManufacturerName { get; set; } = null!;
        public string? LogoPath { get; set; }
        public string? ManufacturerDescription { get; set; }
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