using AutopartsCore.BaseEntities;

namespace AutopartsEntity.Catalog.Entities
{
    public class Warranty : BaseEntity
    {
        public string WarrantyPeriod { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}