using AutopartsEntity.Catalog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutopartsRepository.Configurations.Catalog
{
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            //builder.HasIndex(x => x.NumericCountryCode).IsUnique();
            //builder.HasIndex(x => x.ISOAlpha2).IsUnique();
            //builder.HasIndex(x => x.ISOAlpha3).IsUnique();

            builder.Property(x => x.CreateDate).IsRequired()
                .HasMaxLength(10);
            builder.Property(x => x.UpdateDate)
                .HasMaxLength(10);
            builder.Property(x => x.RowVersion)
                .IsRowVersion();

            builder.Property(x => x.NumericCountryCode).IsRequired()
                .HasMaxLength(3);
            builder.Property(x => x.ISOAlpha2).IsRequired()
                .HasMaxLength(2);
            builder.Property(x => x.ISOAlpha3).IsRequired()
                .HasMaxLength(3);
            builder.Property(x => x.CountryNameCZ).IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.CountryNameENG).IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.IsActive)
                .HasDefaultValue(false);
            builder.Property(x => x.CurrencyId).IsRequired();

            builder.HasData(
                new Country { Id = 1, NumericCountryCode = 203, ISOAlpha2 = "CZ", ISOAlpha3 = "CZE", CountryNameCZ = "Česká republika", CountryNameENG = "Czech Republic", CurrencyId = 1, IsActive = true },
                new Country { Id = 2, NumericCountryCode = 703, ISOAlpha2 = "SK", ISOAlpha3 = "SVK", CountryNameCZ = "Slovenská republika", CountryNameENG = "Slovakia", CurrencyId = 2, IsActive = true },
                new Country { Id = 3, NumericCountryCode = 616, ISOAlpha2 = "PL", ISOAlpha3 = "POL", CountryNameCZ = "Polsko", CountryNameENG = "Poland", CurrencyId = 3, IsActive = true },
                new Country { Id = 4, NumericCountryCode = 276, ISOAlpha2 = "DE", ISOAlpha3 = "DEU", CountryNameCZ = "Německo", CountryNameENG = "Germany", CurrencyId = 2, IsActive = true },
                new Country { Id = 5, NumericCountryCode = 40, ISOAlpha2 = "AT", ISOAlpha3 = "AUT", CountryNameCZ = "Rakousko", CountryNameENG = "Austria", CurrencyId = 2, IsActive = true },
                new Country { Id = 6, NumericCountryCode = 8, ISOAlpha2 = "AL", ISOAlpha3 = "ALB", CountryNameCZ = "Albánie", CountryNameENG = "Albania", CurrencyId = 4, IsActive = false },
                new Country { Id = 7, NumericCountryCode = 20, ISOAlpha2 = "AD", ISOAlpha3 = "AND", CountryNameCZ = "Andorra", CountryNameENG = "Andorra", CurrencyId = 2, IsActive = false },
                new Country { Id = 8, NumericCountryCode = 51, ISOAlpha2 = "AM", ISOAlpha3 = "ARM", CountryNameCZ = "Arménie", CountryNameENG = "Armenia", CurrencyId = 5, IsActive = false },
                new Country { Id = 9, NumericCountryCode = 31, ISOAlpha2 = "AZ", ISOAlpha3 = "AZE", CountryNameCZ = "Ázerbájdžán", CountryNameENG = "Azerbaijan", CurrencyId = 19, IsActive = false },
                new Country { Id = 10, NumericCountryCode = 56, ISOAlpha2 = "BE", ISOAlpha3 = "BEL", CountryNameCZ = "Belgie", CountryNameENG = "Belgium", CurrencyId = 2, IsActive = false },
                new Country { Id = 11, NumericCountryCode = 112, ISOAlpha2 = "BY", ISOAlpha3 = "BLR", CountryNameCZ = "Bělorusko", CountryNameENG = "Belarus", CurrencyId = 24, IsActive = false },
                new Country { Id = 12, NumericCountryCode = 70, ISOAlpha2 = "BA", ISOAlpha3 = "BIH", CountryNameCZ = "Bosna a Hercegovina", CountryNameENG = "Bosnia and Herzegovina", CurrencyId = 26, IsActive = false },
                new Country { Id = 13, NumericCountryCode = 100, ISOAlpha2 = "BG", ISOAlpha3 = "BGR", CountryNameCZ = "Bulharsko", CountryNameENG = "Bulgaria", CurrencyId = 25, IsActive = false },
                new Country { Id = 14, NumericCountryCode = 499, ISOAlpha2 = "ME", ISOAlpha3 = "MNE", CountryNameCZ = "Černá Hora", CountryNameENG = "Montenegro", CurrencyId = 2, IsActive = false },
                new Country { Id = 15, NumericCountryCode = 208, ISOAlpha2 = "DK", ISOAlpha3 = "DNK", CountryNameCZ = "Dánsko", CountryNameENG = "Denmark", CurrencyId = 7, IsActive = false },
                new Country { Id = 16, NumericCountryCode = 233, ISOAlpha2 = "EE", ISOAlpha3 = "EST", CountryNameCZ = "Estonsko", CountryNameENG = "Estonia", CurrencyId = 2, IsActive = false },
                new Country { Id = 17, NumericCountryCode = 246, ISOAlpha2 = "FI", ISOAlpha3 = "FIN", CountryNameCZ = "Finsko", CountryNameENG = "Finland", CurrencyId = 2, IsActive = false },
                new Country { Id = 18, NumericCountryCode = 250, ISOAlpha2 = "FR", ISOAlpha3 = "FRA", CountryNameCZ = "Francie", CountryNameENG = "France", CurrencyId = 2, IsActive = false },
                new Country { Id = 19, NumericCountryCode = 268, ISOAlpha2 = "GE", ISOAlpha3 = "GEO", CountryNameCZ = "Gruzie", CountryNameENG = "Georgia", CurrencyId = 28, IsActive = false },
                new Country { Id = 20, NumericCountryCode = 191, ISOAlpha2 = "HR", ISOAlpha3 = "HRV", CountryNameCZ = "Chorvatsko", CountryNameENG = "Croatia", CurrencyId = 6, IsActive = false },
                new Country { Id = 21, NumericCountryCode = 372, ISOAlpha2 = "IE", ISOAlpha3 = "IRL", CountryNameCZ = "Irsko", CountryNameENG = "Ireland", CurrencyId = 2, IsActive = false },
                new Country { Id = 22, NumericCountryCode = 352, ISOAlpha2 = "IS", ISOAlpha3 = "ISL", CountryNameCZ = "Island", CountryNameENG = "Iceland", CurrencyId = 9, IsActive = false },
                new Country { Id = 23, NumericCountryCode = 380, ISOAlpha2 = "IT", ISOAlpha3 = "ITA", CountryNameCZ = "Itálie", CountryNameENG = "Italy", CurrencyId = 2, IsActive = false },
                new Country { Id = 24, NumericCountryCode = 398, ISOAlpha2 = "KZ", ISOAlpha3 = "KAZ", CountryNameCZ = "Kazachstán", CountryNameENG = "Kazakhstan", CurrencyId = 10, IsActive = false },
                new Country { Id = 25, NumericCountryCode = 196, ISOAlpha2 = "CY", ISOAlpha3 = "CYP", CountryNameCZ = "Kypr (Kyperská republika)", CountryNameENG = "Cyprus", CurrencyId = 2, IsActive = false },
                new Country { Id = 26, NumericCountryCode = 438, ISOAlpha2 = "LI", ISOAlpha3 = "LIE", CountryNameCZ = "Lichtenštejnsko (Lichtenštejnské knížectví)", CountryNameENG = "Liechtenstein", CurrencyId = 15, IsActive = false },
                new Country { Id = 27, NumericCountryCode = 440, ISOAlpha2 = "LT", ISOAlpha3 = "LTU", CountryNameCZ = "Litva (Litevská republika)", CountryNameENG = "Lithuania", CurrencyId = 2, IsActive = false },
                new Country { Id = 28, NumericCountryCode = 428, ISOAlpha2 = "LV", ISOAlpha3 = "LVA", CountryNameCZ = "Lotyšsko (Lotyšská republika)", CountryNameENG = "Latvia", CurrencyId = 2, IsActive = false },
                new Country { Id = 29, NumericCountryCode = 442, ISOAlpha2 = "LU", ISOAlpha3 = "LUX", CountryNameCZ = "Lucembursko", CountryNameENG = "Luxembourg", CurrencyId = 2, IsActive = false },
                new Country { Id = 30, NumericCountryCode = 348, ISOAlpha2 = "HU", ISOAlpha3 = "HUN", CountryNameCZ = "Maďarsko", CountryNameENG = "Hungary", CurrencyId = 8, IsActive = false },
                new Country { Id = 31, NumericCountryCode = 470, ISOAlpha2 = "MT", ISOAlpha3 = "MLT", CountryNameCZ = "Malta", CountryNameENG = "Malta", CurrencyId = 2, IsActive = false },
                new Country { Id = 32, NumericCountryCode = 498, ISOAlpha2 = "MD", ISOAlpha3 = "MDA", CountryNameCZ = "Moldavsko (Moldavská republika)", CountryNameENG = "Moldova", CurrencyId = 11, IsActive = false },
                new Country { Id = 33, NumericCountryCode = 492, ISOAlpha2 = "MC", ISOAlpha3 = "MCO", CountryNameCZ = "Monako", CountryNameENG = "Monaco", CurrencyId = 2, IsActive = false },
                new Country { Id = 34, NumericCountryCode = 528, ISOAlpha2 = "NL", ISOAlpha3 = "NLD", CountryNameCZ = "Nizozemsko", CountryNameENG = "Netherlands", CurrencyId = 2, IsActive = false },
                new Country { Id = 35, NumericCountryCode = 578, ISOAlpha2 = "NO", ISOAlpha3 = "NOR", CountryNameCZ = "Norsko", CountryNameENG = "Norway", CurrencyId = 12, IsActive = false },
                new Country { Id = 36, NumericCountryCode = 620, ISOAlpha2 = "PT", ISOAlpha3 = "PRT", CountryNameCZ = "Portugalsko", CountryNameENG = "Portugal", CurrencyId = 2, IsActive = false },
                new Country { Id = 37, NumericCountryCode = 642, ISOAlpha2 = "RO", ISOAlpha3 = "ROU", CountryNameCZ = "Rumunsko", CountryNameENG = "Romania", CurrencyId = 20, IsActive = false },
                new Country { Id = 38, NumericCountryCode = 643, ISOAlpha2 = "RU", ISOAlpha3 = "RUS", CountryNameCZ = "Rusko", CountryNameENG = "Russian Federation", CurrencyId = 13, IsActive = false },
                new Country { Id = 39, NumericCountryCode = 300, ISOAlpha2 = "GR", ISOAlpha3 = "GRC", CountryNameCZ = "Řecko", CountryNameENG = "Greece", CurrencyId = 2, IsActive = false },
                new Country { Id = 40, NumericCountryCode = 674, ISOAlpha2 = "SM", ISOAlpha3 = "SMR", CountryNameCZ = "San Marino", CountryNameENG = "San Marino", CurrencyId = 2, IsActive = false },
                new Country { Id = 41, NumericCountryCode = 807, ISOAlpha2 = "MK", ISOAlpha3 = "MKD", CountryNameCZ = "Severní Makedonie (Republika Severní Makedonie)", CountryNameENG = "Macedonia, Republic of", CurrencyId = 16, IsActive = false },
                new Country { Id = 42, NumericCountryCode = 705, ISOAlpha2 = "SI", ISOAlpha3 = "SVN", CountryNameCZ = "Slovinsko", CountryNameENG = "Slovenia", CurrencyId = 2, IsActive = false },
                new Country { Id = 43, NumericCountryCode = 688, ISOAlpha2 = "RS", ISOAlpha3 = "SRB", CountryNameCZ = "Srbsko", CountryNameENG = "Serbia", CurrencyId = 18, IsActive = false },
                new Country { Id = 44, NumericCountryCode = 724, ISOAlpha2 = "ES", ISOAlpha3 = "ESP", CountryNameCZ = "Španělsko", CountryNameENG = "Spain", CurrencyId = 2, IsActive = false },
                new Country { Id = 45, NumericCountryCode = 752, ISOAlpha2 = "SE", ISOAlpha3 = "SWE", CountryNameCZ = "Švédsko", CountryNameENG = "Sweden", CurrencyId = 14, IsActive = false },
                new Country { Id = 46, NumericCountryCode = 756, ISOAlpha2 = "CH", ISOAlpha3 = "CHE", CountryNameCZ = "Švýcarsko", CountryNameENG = "Switzerland", CurrencyId = 21, IsActive = false },
                new Country { Id = 47, NumericCountryCode = 756, ISOAlpha2 = "CH", ISOAlpha3 = "CHE", CountryNameCZ = "Švýcarsko", CountryNameENG = "Switzerland", CurrencyId = 15, IsActive = false },
                new Country { Id = 48, NumericCountryCode = 756, ISOAlpha2 = "CH", ISOAlpha3 = "CHE", CountryNameCZ = "Švýcarsko", CountryNameENG = "Switzerland", CurrencyId = 22, IsActive = false },
                new Country { Id = 49, NumericCountryCode = 792, ISOAlpha2 = "TR", ISOAlpha3 = "TUR", CountryNameCZ = "Turecko", CountryNameENG = "Turkey", CurrencyId = 23, IsActive = false },
                new Country { Id = 50, NumericCountryCode = 804, ISOAlpha2 = "UA", ISOAlpha3 = "UKR", CountryNameCZ = "Ukrajina", CountryNameENG = "Ukraine", CurrencyId = 27, IsActive = false },
                new Country { Id = 51, NumericCountryCode = 336, ISOAlpha2 = "VA", ISOAlpha3 = "VAT", CountryNameCZ = "Vatikán (Městský stát Vatikán)", CountryNameENG = "Holy See (Vatican City State)", CurrencyId = 2, IsActive = false },
                new Country { Id = 52, NumericCountryCode = 826, ISOAlpha2 = "GB", ISOAlpha3 = "GBR", CountryNameCZ = "Velká Británie (Spojené království)", CountryNameENG = "United Kingdom", CurrencyId = 17, IsActive = false }
                );
        }
    }
}