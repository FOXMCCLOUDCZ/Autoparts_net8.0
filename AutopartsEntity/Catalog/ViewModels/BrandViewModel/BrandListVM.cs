namespace AutopartsEntity.Catalog.ViewModels.BrandViewModel
{
    public class BrandListVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; } = DateTime.Now;

        public int? TecDoc { get; set; }
        public string BrandName { get; set; } = null!;
        public string? LogoPath { get; set; }
        public bool IsActive { get; set; } = false;
        public string? BrandDescription { get; set; }
    }
}