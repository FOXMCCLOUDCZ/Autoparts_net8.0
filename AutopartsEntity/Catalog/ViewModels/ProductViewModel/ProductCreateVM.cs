using AutopartsEntity.Catalog.ViewModels.BrandViewModel;
using AutopartsEntity.Catalog.ViewModels.OeNumberGroupViewModel;
using AutopartsEntity.Catalog.ViewModels.ProductGroupViewModel;
using AutopartsEntity.Catalog.ViewModels.WarrantyViewModel;

namespace AutopartsEntity.Catalog.ViewModels.ProductViewModel
{
    public class ProductCreateVM
    {
        public int BrandId { get; set; }
        public BrandCreateVM Brand { get; set; } = null!;
        public string ProductNumber { get; set; } = null!;
        public string? ShortNumber { get; set; }
        public int ProductGroupId { get; set; }
        public ProductGroupCreateVM ProductGroup { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public int? OeNumberInGroupId { get; set; }
        public OeNumberGroupCreateVM? OeNumberGroup { get; set; }
        public string? SKUCode { get; set; }
        public double? RetailPrice { get; set; }
        public double? RefundableDeposit { get; set; }
        public int PackedBy { get; set; } = 0!;
        public int WarrantyId { get; set; }
        public WarrantyCreateVM Warranty { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}