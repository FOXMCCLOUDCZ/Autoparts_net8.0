using AutopartsEntity.Catalog.ViewModels.BrandInformationViewModel;

namespace AutopartsEntity.Catalog.ViewModels.BrandViewModel
{
    public class BrandCreateVM
    {
        public int? TecDoc { get; set; }
        public string Title { get; set; } = null!;
        public string? LogoPath { get; set; }
        public bool IsActive { get; set; } = false;

        public int? BrandInformationId { get; set; }
        public BrandInformationCreateVM? BrandInformation { get; set; }
    }
}