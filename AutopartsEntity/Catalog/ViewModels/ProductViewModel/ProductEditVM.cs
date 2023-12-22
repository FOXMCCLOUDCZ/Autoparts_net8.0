using AutopartsEntity.Catalog.ViewModels.BrandViewModel;
using AutopartsEntity.Catalog.ViewModels.OeNumberGroupViewModel;
using AutopartsEntity.Catalog.ViewModels.ProductGroupViewModel;
using AutopartsEntity.Catalog.ViewModels.WarrantyViewModel;

namespace AutopartsEntity.Catalog.ViewModels.ProductViewModel
{
    public class ProductEditVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public byte[] RowVersion { get; set; } = null!;

        public int BrandId { get; set; }
        public BrandEditVM Brand { get; set; } = null!;
        public string ProductNumber { get; set; } = null!;
        public string? ShortNumber { get; set; }
        public int ProductGroupId { get; set; }
        public ProductGroupEditVM ProductGroup { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public int? OeNumberInGroupId { get; set; }
        public OeNumberGroupEditVM? OeNumberGroup { get; set; }
        public string? SKUCode { get; set; }
        public double? RetailPrice { get; set; }
        public double? RefundableDeposit { get; set; }
        public int PackedBy { get; set; } = 0!;
        public int WarrantyId { get; set; }
        public WarrantyEditVM Warranty { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}