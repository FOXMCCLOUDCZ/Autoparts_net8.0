using AutopartsEntity.Catalog.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AutopartsRepository.Configurations.Catalog
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired()
                .HasMaxLength(10);
            builder.Property(x => x.UpdateDate)
                .HasMaxLength(10);
            builder.Property(x => x.RowVersion)
                .IsRowVersion();

            builder.Property(x => x.BrandId).IsRequired();
            builder.Property(x => x.ProductNumber).IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.ShortNumber)
                .HasMaxLength(20);
            builder.Property(x => x.ProductGroupId).IsRequired();
            builder.Property(x => x.ProductName)
                .HasMaxLength(100);
            builder.Property(x => x.OeNumberInGroupId);
            builder.Property(x => x.SKUCode)
                .HasMaxLength(20);
            builder.Property(x => x.RetailPrice)
                .HasDefaultValue(0.00);
            builder.Property(x => x.RefundableDeposit)
                .HasDefaultValue(0.00);
            builder.Property(x => x.PackedBy).IsRequired()
                .HasDefaultValue(1);
            builder.Property(x => x.WarrantyId).IsRequired()
                .HasDefaultValue(3);
            builder.Property(x => x.IsActive)
                .HasDefaultValue(false);

            builder.HasData(
                new Product { Id = 1, BrandId = 4, ProductNumber = "HU 7020 z", ShortNumber = "", ProductGroupId = 1, ProductName = "Test názvu", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 2, BrandId = 21, ProductNumber = "F 026 407 157", ShortNumber = "P7157", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 3, BrandId = 60, ProductNumber = "47827", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 4, BrandId = 76, ProductNumber = "25.144.00", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 5, BrandId = 51, ProductNumber = "E340H D247", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 6, BrandId = 58, ProductNumber = "153071760762", ShortNumber = "71760762", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 7, BrandId = 16, ProductNumber = "586617", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 8, BrandId = 16, ProductNumber = "728732", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 9, BrandId = 33, ProductNumber = "COF100673E", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 10, BrandId = 152, ProductNumber = "ADV182125", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 11, BrandId = 128, ProductNumber = "10-ECO025", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 12, BrandId = 174, ProductNumber = "50014549", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 13, BrandId = 102, ProductNumber = "A210891", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 14, BrandId = 101, ProductNumber = "F117601", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 15, BrandId = 29, ProductNumber = "L991", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 16, BrandId = 127, ProductNumber = "OE 688/3", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 17, BrandId = 133, ProductNumber = "OX 787D", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 18, BrandId = 118, ProductNumber = "SH 4088 L", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 19, BrandId = 112, ProductNumber = "07.18.054", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 20, BrandId = 82, ProductNumber = "100 322 0019", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 21, BrandId = 139, ProductNumber = "114 419", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 22, BrandId = 124, ProductNumber = "14147", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 23, BrandId = 225, ProductNumber = "B10532", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 24, BrandId = 85, ProductNumber = "FO-ECO025", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 25, BrandId = 39, ProductNumber = "J1310809", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 26, BrandId = 97, ProductNumber = "MD-731", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 27, BrandId = 25, ProductNumber = "OX 787D", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 28, BrandId = 81, ProductNumber = "S 5144 PE", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true },
                new Product { Id = 29, BrandId = 89, ProductNumber = "V10-2825", ShortNumber = "", ProductGroupId = 1, ProductName = "", OeNumberInGroupId = 1, SKUCode = "", RetailPrice = 0.00, RefundableDeposit = 0.00, PackedBy = 1, WarrantyId = 3, IsActive = true }
                );
        }
    }
}