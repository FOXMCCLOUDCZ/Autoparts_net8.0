using AutopartsEntity.Catalog.ViewModels.CountryViewModel;

namespace AutopartsEntity.Catalog.ViewModels.BrandInformationViewModel
{
    public class BrandInformationCreateVM
    {
        public string? WebSite { get; set; }
        public string? GeneralInformation { get; set; }
        public int? CountryId { get; set; }
        public CountryCreateVM? Country { get; set; }
    }
}