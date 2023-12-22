using AutopartsCore.BaseEntities;

namespace AutopartsEntity.Catalog.Entities
{
    public class ProductGroup : BaseEntity
    {
        public int? TecDoc { get; set; }
        public string ProductGroupName { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}