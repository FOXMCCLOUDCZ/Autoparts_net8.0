namespace AutopartsEntity.Catalog.ViewModels.BrandViewModel
{
    public class BrandEditVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public byte[] RowVersion { get; set; } = null!;

        public int? TecDoc { get; set; }
        public string Title { get; set; } = null!;
        public string? LogoPath { get; set; }
        public bool IsActive { get; set; } = false;
        public string? GeneralInformation { get; set; }
    }
}