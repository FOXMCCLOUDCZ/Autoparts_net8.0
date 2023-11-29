using AutopartsCore.BaseEntities;

namespace AutopartsEntity.Catalog.Entities
{
    public class Pkw : BaseEntity
    {
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; } = null!;
        public int ModelId { get; set; }
        public Model Model { get; set; } = null!;
        public DateTime MadeBy { get; set; }
        public DateTime MadeTo { get; set; }
        public string VehicleType { get; set; } = null!;
        public int VehicleTechnicalDataId { get; set; }
        public TechnicalData? VehicleTechnicalData { get; set; }
        public ICollection<ParentPkwEngine>? ParentPkwEngines { get; set; }
    }
}