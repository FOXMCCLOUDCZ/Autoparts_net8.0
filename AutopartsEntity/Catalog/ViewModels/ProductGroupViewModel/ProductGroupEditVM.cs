namespace AutopartsEntity.Catalog.ViewModels.ProductGroupViewModel
{
    public class ProductGroupEditVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public byte[] RowVersion { get; set; } = null!;

        public int? TecDoc { get; set; }
        public string ProductGroupName { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}