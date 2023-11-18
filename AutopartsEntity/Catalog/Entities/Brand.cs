using AutopartsCore.BaseEntities;

namespace AutopartsEntity.Catalog.Entities
{
    public class Brand : BaseEntity
    {
        public int? TecDoc { get; set; }
        public string Title { get; set; } = null!;
        public string? LogoPath { get; set; }
        public bool IsActive { get; set; } = false;

        public int? BrandInformationId { get; set; }
        public BrandInformation? BrandInformation { get; set; }
    }
}