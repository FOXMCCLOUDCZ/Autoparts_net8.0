using AutopartsCore.BaseEntities;

namespace AutopartsEntity.Catalog.Entities
{
    public class BrandInformation : BaseEntity
    {
        public string? WebSite { get; set; }
        public string? GeneralInformation { get; set; }
        public int? CountryId { get; set; }
        public Country? Country { get; set; }
    }
}