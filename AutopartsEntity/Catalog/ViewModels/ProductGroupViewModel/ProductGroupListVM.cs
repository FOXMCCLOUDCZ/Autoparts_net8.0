namespace AutopartsEntity.Catalog.ViewModels.ProductGroupViewModel
{
    public class ProductGroupListVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; } = DateTime.Now;

        public int? TecDoc { get; set; }
        public string ProductGroupName { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}