using AutopartsEntity.Catalog.ViewModels.CountryViewModel;

namespace AutopartsEntity.Catalog.ViewModels.BrandInformationViewModel
{
    public class BrandInformationEditVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public byte[] RowVersion { get; set; } = null!;

        public string? WebSite { get; set; }
        public string? GeneralInformation { get; set; }
        public int? CountryId { get; set; }
        public CountryEditVM? Country { get; set; }
    }
}