using Microsoft.AspNetCore.Http;

namespace AutopartsEntity.Catalog.ViewModels.BrandViewModel
{
    public class BrandCreateVM
    {
        public int? TecDoc { get; set; }
        public string Title { get; set; } = null!;
        public string? LogoPath { get; set; }
        public IFormFile? LogoImg { get; set; }
        public bool IsActive { get; set; } = false;
        public string? GeneralInformation { get; set; }
    }
}