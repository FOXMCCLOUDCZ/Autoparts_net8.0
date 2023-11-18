using AutopartsEntity.Catalog.ViewModels.CountryViewModel;

namespace AutopartsEntity.Catalog.ViewModels.BrandInformationViewModel
{
    public class BrandInformationListVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; } = DateTime.Now;

        public string? WebSite { get; set; }
        public string? GeneralInformation { get; set; }
        public int? CountryId { get; set; }
        public CountryListVM? Country { get; set; }
    }
}