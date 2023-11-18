using AutopartsEntity.Catalog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutopartsRepository.Configurations.Catalog
{
    public class CurrencyConfig : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired()
                .HasMaxLength(10);
            builder.Property(x => x.UpdateDate)
                .HasMaxLength(10);
            builder.Property(x => x.RowVersion)
                .IsRowVersion();

            builder.Property(x => x.NumericCurrencyCode).IsRequired()
                .HasMaxLength(3);
            builder.Property(x => x.CurrencyCode).IsRequired()
                .HasMaxLength(3);
            builder.Property(x => x.CurrencyName).IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.IsActive)
                .HasDefaultValue(false);

            builder.HasData(
                new Currency { Id = 1, NumericCurrencyCode = 203, CurrencyCode = "CZK", CurrencyName = "Česká koruna", IsActive = true },
                new Currency { Id = 2, NumericCurrencyCode = 978, CurrencyCode = "EUR", CurrencyName = "Euro", IsActive = true },
                new Currency { Id = 3, NumericCurrencyCode = 985, CurrencyCode = "PLN", CurrencyName = "Złoty", IsActive = true },
                new Currency { Id = 4, NumericCurrencyCode = 8, CurrencyCode = "ALL", CurrencyName = "Albánský lek", IsActive = false },
                new Currency { Id = 5, NumericCurrencyCode = 51, CurrencyCode = "AMD", CurrencyName = "Arménský dram", IsActive = false },
                new Currency { Id = 6, NumericCurrencyCode = 191, CurrencyCode = "HRK", CurrencyName = "Kuna", IsActive = false },
                new Currency { Id = 7, NumericCurrencyCode = 208, CurrencyCode = "DKK", CurrencyName = "Dánská koruna", IsActive = false },
                new Currency { Id = 8, NumericCurrencyCode = 348, CurrencyCode = "HUF", CurrencyName = "Forint", IsActive = false },
                new Currency { Id = 9, NumericCurrencyCode = 352, CurrencyCode = "ISK", CurrencyName = "Islandská koruna", IsActive = false },
                new Currency { Id = 10, NumericCurrencyCode = 398, CurrencyCode = "KZT", CurrencyName = "Tenge", IsActive = false },
                new Currency { Id = 11, NumericCurrencyCode = 498, CurrencyCode = "MDL", CurrencyName = "Moldavské leu", IsActive = false },
                new Currency { Id = 12, NumericCurrencyCode = 578, CurrencyCode = "NOK", CurrencyName = "Norská koruna", IsActive = false },
                new Currency { Id = 13, NumericCurrencyCode = 643, CurrencyCode = "RUB", CurrencyName = "Ruský rubl", IsActive = false },
                new Currency { Id = 14, NumericCurrencyCode = 752, CurrencyCode = "SEK", CurrencyName = "Švédská koruna", IsActive = false },
                new Currency { Id = 15, NumericCurrencyCode = 756, CurrencyCode = "CHF", CurrencyName = "Švýcarský frank", IsActive = false },
                new Currency { Id = 16, NumericCurrencyCode = 807, CurrencyCode = "MKD", CurrencyName = "Denár", IsActive = false },
                new Currency { Id = 17, NumericCurrencyCode = 826, CurrencyCode = "GBP", CurrencyName = "Libra šterlinků", IsActive = false },
                new Currency { Id = 18, NumericCurrencyCode = 941, CurrencyCode = "RSD", CurrencyName = "Srbský dinár", IsActive = false },
                new Currency { Id = 19, NumericCurrencyCode = 944, CurrencyCode = "AZN", CurrencyName = "Ázerbájdžánský manat", IsActive = false },
                new Currency { Id = 20, NumericCurrencyCode = 946, CurrencyCode = "RON", CurrencyName = "Rumunské leu", IsActive = false },
                new Currency { Id = 21, NumericCurrencyCode = 947, CurrencyCode = "CHE", CurrencyName = "WIR Euro", IsActive = false },
                new Currency { Id = 22, NumericCurrencyCode = 948, CurrencyCode = "CHW", CurrencyName = "WIR Frank", IsActive = false },
                new Currency { Id = 23, NumericCurrencyCode = 949, CurrencyCode = "TRY", CurrencyName = "Turecká lira", IsActive = false },
                new Currency { Id = 24, NumericCurrencyCode = 974, CurrencyCode = "BYR", CurrencyName = "Běloruský rubl", IsActive = false },
                new Currency { Id = 25, NumericCurrencyCode = 975, CurrencyCode = "BGN", CurrencyName = "Bulharská leva", IsActive = false },
                new Currency { Id = 26, NumericCurrencyCode = 977, CurrencyCode = "BAM", CurrencyName = "Konvertibilní marka", IsActive = false },
                new Currency { Id = 27, NumericCurrencyCode = 980, CurrencyCode = "UAH", CurrencyName = "Ukrajinská hřivna", IsActive = false },
                new Currency { Id = 28, NumericCurrencyCode = 981, CurrencyCode = "GEL", CurrencyName = "Lari", IsActive = false }
                );
        }
    }
}