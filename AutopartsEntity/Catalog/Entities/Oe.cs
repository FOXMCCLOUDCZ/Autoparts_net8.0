using AutopartsCore.BaseEntities;

namespace AutopartsEntity.Catalog.Entities
{
    public class Oe : BaseEntity
    {
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; } = null!;
        public string OeNumber { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}