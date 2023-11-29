using AutopartsCore.BaseEntities;

namespace AutopartsEntity.Catalog.Entities
{
    public class Brand : BaseEntity
    {
        public int? TecDoc { get; set; }
        public string BrandName { get; set; } = null!;
        public string? LogoPath { get; set; }
        public bool IsActive { get; set; } = false;
        public string? BrandDescription { get; set; }
    }
}