using AutopartsEntity.Catalog.Entities;

namespace AutopartsEntity.Catalog.ViewModels.PkwViewModel
{
    public class PkwCreateVM
    {
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; } = null!;
        public int ModelId { get; set; }
        public Model Model { get; set; } = null!;
        public DateTime MadeBy { get; set; }
        public DateTime? MadeTo { get; set; } = null;
        public string VehicleType { get; set; } = null!;
        public int VehicleTechnicalDataId { get; set; }
        public VehicleTechnicalData? VehicleTechnicalData { get; set; }
        public ICollection<ParentPkwEngine>? ParentPkwEngines { get; set; }
    }
}