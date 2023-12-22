using AutopartsCore.BaseEntities;

namespace AutopartsEntity.Catalog.Entities
{
    public class Product : BaseEntity
    {
        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
        public string ProductNumber { get; set; } = null!;
        public string? ShortNumber { get; set; }
        public int ProductGroupId { get; set; }
        public ProductGroup ProductGroup { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public int? OeNumberInGroupId { get; set; }
        public OeNumberGroup? OeNumberGroup { get; set; }
        public string? SKUCode {  get; set; }
        public double? RetailPrice { get; set; }
        public double? RefundableDeposit { get; set; }
        public int PackedBy { get; set; } = 0!;
        public int WarrantyId { get; set; }
        public Warranty Warranty { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}