namespace AutopartsEntity.Catalog.ViewModels.ProductGroupViewModel
{
    public class ProductGroupCreateVM
    {
        public int? TecDoc { get; set; }
        public string ProductGroupName { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}