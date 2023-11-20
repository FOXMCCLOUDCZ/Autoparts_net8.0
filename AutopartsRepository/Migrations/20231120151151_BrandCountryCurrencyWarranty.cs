using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutopartsRepository.Migrations
{
    /// <inheritdoc />
    public partial class BrandCountryCurrencyWarranty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TecDoc = table.Column<int>(type: "int", maxLength: 6, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogoPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    GeneralInformation = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumericCurrencyCode = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CurrencyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Warranties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warranties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumericCountryCode = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    ISOAlpha2 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ISOAlpha3 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CountryNameCZ = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CountryNameENG = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Countries_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreateDate", "GeneralInformation", "IsActive", "LogoPath", "TecDoc", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1215), "", true, null, 1, "SPIDAN", null },
                    { 2, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1276), "", true, null, 2, "HELLA", null },
                    { 3, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1291), "", true, null, 3, "ATE", null },
                    { 4, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1295), "", true, null, 4, "MANN-FILTER", null },
                    { 5, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1299), "", true, null, 5, "PIERBURG", null },
                    { 6, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1302), "", true, null, 6, "LuK", null },
                    { 7, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1307), "", true, null, 7, "EBERSPÄCHER", null },
                    { 8, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1310), "", true, null, 9, "VICTOR REINZ", null },
                    { 9, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1315), "", true, null, 10, "ELRING", null },
                    { 10, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1319), "", true, null, 11, "BorgWarner (BERU)", null },
                    { 11, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1322), "", true, null, 13, "WALKER", null },
                    { 12, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1326), "", true, null, 15, "NGK", null },
                    { 13, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1331), "", true, null, 16, "BILSTEIN", null },
                    { 14, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1334), "", true, null, 18, "KONI", null },
                    { 15, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1338), "", true, null, 19, "SWF", null },
                    { 16, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1342), "", true, null, 21, "VALEO", null },
                    { 17, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1345), "", true, null, 23, "RUVILLE", null },
                    { 18, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1349), "", true, null, 24, "EXIDE", null },
                    { 19, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1353), "", true, null, 26, "VARTA", null },
                    { 20, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1356), "", true, null, 29, "ERNST", null },
                    { 21, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1360), "", true, null, 30, "BOSCH", null },
                    { 22, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1363), "", true, null, 31, "CONTINENTAL CTAM", null },
                    { 23, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1367), "", true, null, 32, "SACHS", null },
                    { 24, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1371), "", true, null, 33, "GATES", null },
                    { 25, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1374), "", true, null, 34, "KNECHT", null },
                    { 26, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1378), "", true, null, 35, "LEMFÖRDER", null },
                    { 27, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1381), "", true, null, 36, "VAN WEZEL", null },
                    { 28, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1385), "", true, null, 37, "MONROE", null },
                    { 29, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1389), "", true, null, 38, "PURFLUX", null },
                    { 30, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1393), "", true, null, 39, "TEXTAR", null },
                    { 31, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1397), "", true, null, 41, "BOSAL", null },
                    { 32, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1401), "", true, null, 42, "DAYCO", null },
                    { 33, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1404), "", true, null, 43, "CHAMPION", null },
                    { 34, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1408), "", true, null, 47, "BREMI", null },
                    { 35, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1412), "", true, null, 48, "JURID", null },
                    { 36, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1416), "", true, null, 50, "SKF", null },
                    { 37, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1420), "", true, null, 51, "WESTFALIA", null },
                    { 38, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1423), "", true, null, 54, "FTE", null },
                    { 39, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1427), "", true, null, 55, "HERTH+BUSS JAKOPARTS", null },
                    { 40, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1430), "", true, null, 56, "LÖBRO", null },
                    { 41, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1434), "", true, null, 57, "QUINTON HAZELL", null },
                    { 42, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1438), "", true, null, 61, "TYC", null },
                    { 43, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1441), "", true, null, 65, "BREMBO", null },
                    { 44, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1445), "", true, null, 66, "DENSO", null },
                    { 45, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1449), "", true, null, 67, "ams-OSRAM", null },
                    { 46, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1453), "", true, null, 68, "ZF", null },
                    { 47, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1456), "", true, null, 72, "HERTH+BUSS ELPARTS", null },
                    { 48, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1460), "", true, null, 75, "PHILIPS", null },
                    { 49, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1464), "", true, null, 78, "KLOKKERHOLM", null },
                    { 50, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1468), "", true, null, 79, "BorgWarner (Wahler)", null },
                    { 51, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1471), "", true, null, 81, "HENGST FILTER", null },
                    { 52, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1476), "", true, null, 83, "CONTINENTAL/VDO", null },
                    { 53, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1479), "", true, null, 85, "KYB", null },
                    { 54, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1483), "", true, null, 86, "ZIMMERMANN", null },
                    { 55, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1486), "", true, null, 88, "GLASER", null },
                    { 56, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1490), "", true, null, 89, "DELPHI", null },
                    { 57, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1494), "", true, null, 94, "METZGER", null },
                    { 58, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1497), "", true, null, 95, "MAGNETI MARELLI", null },
                    { 59, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1501), "", true, null, 97, "WAECO", null },
                    { 60, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1505), "", true, null, 101, "FEBI BILSTEIN", null },
                    { 61, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1508), "", true, null, 106, "BRINK", null },
                    { 62, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1512), "", true, null, 109, "BUGATTI", null },
                    { 63, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1515), "", true, null, 110, "SNR", null },
                    { 64, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1519), "", true, null, 112, "EIBACH", null },
                    { 65, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1523), "", true, null, 113, "PAYEN", null },
                    { 66, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1526), "", true, null, 114, "BUDWEG CALIPER", null },
                    { 67, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1533), "", true, null, 115, "ULO", null },
                    { 68, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1537), "", true, null, 117, "LRT", null },
                    { 69, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1540), "", true, null, 118, "HJS", null },
                    { 70, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1544), "", true, null, 121, "METELLI", null },
                    { 71, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1547), "", true, null, 123, "NISSENS", null },
                    { 72, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1551), "", true, null, 126, "STABILUS", null },
                    { 73, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1560), "", true, null, 127, "NK", null },
                    { 74, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1563), "", true, null, 129, "OPTIMAL", null },
                    { 75, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1567), "", true, null, 135, "SIDEM", null },
                    { 76, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1570), "", true, null, 137, "UFI", null },
                    { 77, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1574), "", true, null, 138, "JOHNS", null },
                    { 78, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1578), "", true, null, 139, "AJUSA", null },
                    { 79, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1581), "", true, null, 140, "CORTECO", null },
                    { 80, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1585), "", true, null, 141, "AE", null },
                    { 81, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1588), "", true, null, 142, "SOFIMA", null },
                    { 82, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1592), "", true, null, 144, "MEYLE", null },
                    { 83, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1595), "", true, null, 151, "SWAG", null },
                    { 84, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1599), "", true, null, 154, "DOLZ", null },
                    { 85, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1608), "", true, null, 156, "JAPANPARTS", null },
                    { 86, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1611), "", true, null, 158, "ICER", null },
                    { 87, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1615), "", true, null, 159, "FACET", null },
                    { 88, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1619), "", true, null, 161, "TRW", null },
                    { 89, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1668), "", true, null, 162, "VAICO", null },
                    { 90, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1672), "", true, null, 166, "AISIN", null },
                    { 91, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1675), "", true, null, 167, "DUPLI COLOR", null },
                    { 92, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1679), "", true, null, 168, "MOTIP", null },
                    { 93, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1683), "", true, null, 169, "PRESTO", null },
                    { 94, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1686), "", true, null, 175, "LESJÖFORS", null },
                    { 95, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1690), "", true, null, 177, "BTS Turbo", null },
                    { 96, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1693), "", true, null, 178, "HEPU", null },
                    { 97, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1697), "", true, null, 180, "ALCO FILTER", null },
                    { 98, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1700), "", true, null, 181, "GK", null },
                    { 99, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1704), "", true, null, 182, "SCHLÜTTER TURBOLADER", null },
                    { 100, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1708), "", true, null, 183, "VEMO", null },
                    { 101, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1711), "", true, null, 185, "KAMOKA", null },
                    { 102, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1715), "", true, null, 191, "IMASAF", null },
                    { 103, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1720), "", true, null, 192, "FAG", null },
                    { 104, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1724), "", true, null, 197, "LPR", null },
                    { 105, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1728), "", true, null, 198, "OCAP", null },
                    { 106, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1731), "", true, null, 202, "GLYCO", null },
                    { 107, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1735), "", true, null, 204, "INA", null },
                    { 108, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1740), "", true, null, 205, "NRF", null },
                    { 109, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1743), "", true, null, 206, "A.B.S.", null },
                    { 110, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1747), "", true, null, 207, "CASTROL", null },
                    { 111, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1750), "", true, null, 209, "TRUCKTEC AUTOMOTIVE", null },
                    { 112, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1754), "", true, null, 214, "REMY", null },
                    { 113, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1758), "", true, null, 215, "CALORSTAT by Vernet", null },
                    { 114, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1761), "", true, null, 216, "NÜRAL", null },
                    { 115, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1765), "", true, null, 220, "AIRTEX", null },
                    { 116, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1768), "", true, null, 222, "LIQUI MOLY", null },
                    { 117, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1772), "", true, null, 225, "SCT - MANNOL", null },
                    { 118, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1775), "", true, null, 226, "ELSTOCK", null },
                    { 119, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1779), "", true, null, 233, "DINEX", null },
                    { 120, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1783), "", true, null, 234, "ERA", null },
                    { 121, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1787), "", true, null, 235, "FRECCIA", null },
                    { 122, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1791), "", true, null, 240, "FAE", null },
                    { 123, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1795), "", true, null, 244, "MEAT & DORIA", null },
                    { 124, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1798), "", true, null, 247, "AVA QUALITY COOLING", null },
                    { 125, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1802), "", true, null, 248, "NIPPARTS", null },
                    { 126, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1806), "", true, null, 256, "FILTRON", null },
                    { 127, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1809), "", true, null, 257, "ASHIKA", null },
                    { 128, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1813), "", true, null, 260, "SASIC", null },
                    { 129, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1817), "", true, null, 267, "FAI AutoParts", null },
                    { 130, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1821), "", true, null, 268, "JP GROUP", null },
                    { 131, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1824), "", true, null, 277, "AMC", null },
                    { 132, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1828), "", true, null, 287, "MAHLE", null },
                    { 133, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1832), "", true, null, 294, "SACHS PERFORMANCE", null },
                    { 134, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1835), "", true, null, 295, "fri.tech.", null },
                    { 135, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1839), "", true, null, 297, "sbs", null },
                    { 136, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1842), "", true, null, 299, "WEBASTO", null },
                    { 137, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1846), "", true, null, 300, "AUTEX", null },
                    { 138, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1850), "", true, null, 301, "TOPRAN", null },
                    { 139, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1854), "", true, null, 305, "K&N Filters", null },
                    { 140, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1858), "", true, null, 310, "GRAF", null },
                    { 141, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1861), "", true, null, 311, "CIFAM", null },
                    { 142, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1865), "", true, null, 316, "GENERAL RICAMBI", null },
                    { 143, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1868), "", true, null, 323, "AUTOMEGA", null },
                    { 144, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1872), "", true, null, 324, "WIX FILTERS", null },
                    { 145, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1875), "", true, null, 326, "BorgWarner (Schwitze", null },
                    { 146, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1879), "", true, null, 327, "BorgWarner", null },
                    { 147, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1882), "", true, null, 328, "BorgWarner (3K)", null },
                    { 148, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1886), "", true, null, 331, "ORIGINAL IMPERIUM", null },
                    { 149, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1890), "", true, null, 340, "PRASCO", null },
                    { 150, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1893), "", true, null, 347, "TRW Engine Component", null },
                    { 151, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1897), "", true, null, 350, "BLUE PRINT", null },
                    { 152, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1900), "", true, null, 351, "AUTOFREN SEINSA", null },
                    { 153, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1904), "", true, null, 356, "TESLA", null },
                    { 154, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1907), "", true, null, 362, "ALKAR", null },
                    { 155, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1911), "", true, null, 367, "FA1", null },
                    { 156, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1914), "", true, null, 373, "GSP", null },
                    { 157, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1918), "", true, null, 376, "CENTRA", null },
                    { 158, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1922), "", true, null, 377, "BOSCH DIAGNOSTICS", null },
                    { 159, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1926), "", true, null, 380, "FRENKIT", null },
                    { 160, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1929), "", true, null, 385, "GOETZE ENGINE", null },
                    { 161, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1933), "", true, null, 388, "MOTORAD", null },
                    { 162, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1936), "", true, null, 389, "GLYSANTIN", null },
                    { 163, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1940), "", true, null, 391, "EAI", null },
                    { 164, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1944), "", true, null, 394, "BARUM", null },
                    { 165, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1947), "", true, null, 397, "JANMOR", null },
                    { 166, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1951), "", true, null, 399, "EXEDY", null },
                    { 167, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1954), "", true, null, 400, "RAICAM", null },
                    { 168, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1958), "", true, null, 403, "MAXGEAR", null },
                    { 169, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1961), "", true, null, 406, "BM CATALYSTS", null },
                    { 170, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1965), "", true, null, 409, "FREMAX", null },
                    { 171, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1968), "", true, null, 427, "ASMET", null },
                    { 172, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1972), "", true, null, 430, "RTS", null },
                    { 173, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1976), "", true, null, 432, "KOLBENSCHMIDT", null },
                    { 174, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1986), "", true, null, 433, "STATIM", null },
                    { 175, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1990), "", true, null, 436, "MOTUL", null },
                    { 176, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1994), "", true, null, 437, "CoopersFiaam", null },
                    { 177, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(1998), "", true, null, 443, "ENERGIZER", null },
                    { 178, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2001), "", true, null, 447, "PILKINGTON", null },
                    { 179, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2005), "", true, null, 449, "HITACHI", null },
                    { 180, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2009), "", true, null, 454, "BANDO", null },
                    { 181, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2012), "", true, null, 460, "DRI", null },
                    { 182, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2016), "", true, null, 461, "RAVENOL", null },
                    { 183, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2019), "", true, null, 464, "OSVAT", null },
                    { 184, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2023), "", true, null, 467, "CS Germany", null },
                    { 185, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2027), "", true, null, 475, "BORG & BECK", null },
                    { 186, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2030), "", true, null, 483, "ClimAir", null },
                    { 187, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2034), "", true, null, 485, "NARVA", null },
                    { 188, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2037), "", true, null, 494, "BRISK", null },
                    { 189, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2041), "", true, null, 499, "ZAFFO", null },
                    { 190, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2044), "", true, null, 4005, "EPS", null },
                    { 191, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2048), "", true, null, 4006, "KW", null },
                    { 192, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2052), "", true, null, 4023, "KS TOOLS", null },
                    { 193, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2055), "", true, null, 4026, "VIGOR", null },
                    { 194, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2060), "", true, null, 4314, "SHELL", null },
                    { 195, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2064), "", true, null, 4333, "Prestone", null },
                    { 196, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2067), "", true, null, 4344, "ELTA AUTOMOTIVE", null },
                    { 197, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2071), "", true, null, 4346, "vika", null },
                    { 198, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2075), "", true, null, 4353, "DPA", null },
                    { 199, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2078), "", true, null, 4367, "STOP&GO", null },
                    { 200, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2082), "", true, null, 4372, "PETEC", null },
                    { 201, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2086), "", true, null, 4381, "Airstal", null },
                    { 202, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2089), "", true, null, 4434, "CONTINENTAL", null },
                    { 203, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2093), "", true, null, 4436, "DUNLOP", null },
                    { 204, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2097), "", true, null, 4449, "MOBIL", null },
                    { 205, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2101), "", true, null, 4451, "YUASA", null },
                    { 206, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2104), "", true, null, 4452, "GS", null },
                    { 207, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2108), "", true, null, 4457, "SONAX", null },
                    { 208, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2112), "", true, null, 4512, "ERT", null },
                    { 209, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2115), "", true, null, 4514, "ET ENGINETEAM", null },
                    { 210, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2119), "", true, null, 4536, "LINEX", null },
                    { 211, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2123), "", true, null, 4539, "Arnott", null },
                    { 212, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2127), "", true, null, 4593, "TEDGUM", null },
                    { 213, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2131), "", true, null, 4612, "GE", null },
                    { 214, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2134), "", true, null, 4615, "GARRETT", null },
                    { 215, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2138), "", true, null, 4657, "ABAKUS", null },
                    { 216, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2142), "", true, null, 4676, "ROTINGER", null },
                    { 217, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2145), "", true, null, 4679, "CAFFARO", null },
                    { 218, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2149), "", true, null, 4705, "MOBILETRON", null },
                    { 219, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2153), "", true, null, 4717, "NE", null },
                    { 220, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2156), "", true, null, 4719, "LIFT-TEK", null },
                    { 221, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2160), "", true, null, 4721, "MIRAGLIO", null },
                    { 222, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2163), "", true, null, 4734, "HELLA GUTMANN", null },
                    { 223, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2167), "", true, null, 4808, "HAZET", null },
                    { 224, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2171), "", true, null, 4815, "Borsehung", null },
                    { 225, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2174), "", true, null, 4821, "QUARO", null },
                    { 226, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2178), "", true, null, 4843, "AS-PL", null },
                    { 227, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2181), "", true, null, 4849, "Ac Rolcar", null },
                    { 228, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2185), "", true, null, 4866, "ARAL", null },
                    { 229, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2189), "", true, null, 4871, "COFLE", null },
                    { 230, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2193), "", true, null, 4873, "POLMO", null },
                    { 231, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2197), "", true, null, 4881, "DYNAMAX", null },
                    { 232, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2201), "", true, null, 4911, "ALLIGATOR", null },
                    { 233, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2204), "", true, null, 4912, "GEDORE", null },
                    { 234, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2208), "", true, null, 4923, "NORMA", null },
                    { 235, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2212), "", true, null, 4946, "SCHRADER", null },
                    { 236, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2215), "", true, null, 4949, "TURBORAIL", null },
                    { 237, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2219), "", true, null, 4969, "ESEN SKV", null },
                    { 238, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2223), "", true, null, 5251, "HART", null },
                    { 239, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2226), "", true, null, 6102, "ACPS-ORIS", null },
                    { 240, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2230), "", true, null, 6186, "VALVOLINE", null },
                    { 241, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2234), "", true, null, 6263, "CPB", null },
                    { 242, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2238), "", true, null, 6304, "QUICK BRAKE", null },
                    { 243, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2241), "", true, null, 6306, "GKN", null },
                    { 244, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2245), "", true, null, 6343, "REPSOL", null },
                    { 245, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2249), "", true, null, 6368, "EBC Brakes", null },
                    { 246, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2253), "", true, null, 6441, "BERU by DRiV", null },
                    { 247, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2256), "", true, null, 6444, "BorgWarner (AWD)", null },
                    { 248, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2260), "", true, null, 6534, "Dr.Motor Automotive", null },
                    { 249, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2264), "", true, null, 6558, "AIC", null },
                    { 250, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2267), "", true, null, 6984, "Oyodo", null },
                    { 251, new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(2271), "", true, null, 6985, "JPN", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CreateDate", "CurrencyCode", "CurrencyName", "IsActive", "NumericCurrencyCode", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5295), "CZK", "Česká koruna", true, 203, null },
                    { 2, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5333), "EUR", "Euro", true, 978, null },
                    { 3, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5337), "PLN", "Złoty", true, 985, null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CreateDate", "CurrencyCode", "CurrencyName", "NumericCurrencyCode", "UpdateDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5341), "ALL", "Albánský lek", 8, null },
                    { 5, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5345), "AMD", "Arménský dram", 51, null },
                    { 6, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5348), "HRK", "Kuna", 191, null },
                    { 7, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5352), "DKK", "Dánská koruna", 208, null },
                    { 8, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5355), "HUF", "Forint", 348, null },
                    { 9, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5359), "ISK", "Islandská koruna", 352, null },
                    { 10, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5363), "KZT", "Tenge", 398, null },
                    { 11, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5366), "MDL", "Moldavské leu", 498, null },
                    { 12, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5370), "NOK", "Norská koruna", 578, null },
                    { 13, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5373), "RUB", "Ruský rubl", 643, null },
                    { 14, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5377), "SEK", "Švédská koruna", 752, null },
                    { 15, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5380), "CHF", "Švýcarský frank", 756, null },
                    { 16, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5384), "MKD", "Denár", 807, null },
                    { 17, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5387), "GBP", "Libra šterlinků", 826, null },
                    { 18, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5391), "RSD", "Srbský dinár", 941, null },
                    { 19, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5394), "AZN", "Ázerbájdžánský manat", 944, null },
                    { 20, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5398), "RON", "Rumunské leu", 946, null },
                    { 21, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5401), "CHE", "WIR Euro", 947, null },
                    { 22, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5405), "CHW", "WIR Frank", 948, null },
                    { 23, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5408), "TRY", "Turecká lira", 949, null },
                    { 24, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5412), "BYR", "Běloruský rubl", 974, null },
                    { 25, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5415), "BGN", "Bulharská leva", 975, null },
                    { 26, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5419), "BAM", "Konvertibilní marka", 977, null },
                    { 27, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5422), "UAH", "Ukrajinská hřivna", 980, null },
                    { 28, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(5425), "GEL", "Lari", 981, null }
                });

            migrationBuilder.InsertData(
                table: "Warranties",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(9917), true, "6 měsíců", null },
                    { 2, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(9949), true, "12 měsíců", null },
                    { 3, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(9953), true, "24 měsíců", null },
                    { 4, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(9956), true, "36 měsíců", null }
                });

            migrationBuilder.InsertData(
                table: "Warranties",
                columns: new[] { "Id", "CreateDate", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 5, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(9959), "48 měsíců", null },
                    { 6, new DateTime(2023, 11, 20, 16, 11, 49, 752, DateTimeKind.Local).AddTicks(9962), "60 měsíců", null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryNameCZ", "CountryNameENG", "CreateDate", "CurrencyId", "ISOAlpha2", "ISOAlpha3", "IsActive", "NumericCountryCode", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Česká republika", "Czech Republic", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9587), 1, "CZ", "CZE", true, 203, null },
                    { 2, "Slovenská republika", "Slovakia", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9632), 2, "SK", "SVK", true, 703, null },
                    { 3, "Polsko", "Poland", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9638), 3, "PL", "POL", true, 616, null },
                    { 4, "Německo", "Germany", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9642), 2, "DE", "DEU", true, 276, null },
                    { 5, "Rakousko", "Austria", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9647), 2, "AT", "AUT", true, 40, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryNameCZ", "CountryNameENG", "CreateDate", "CurrencyId", "ISOAlpha2", "ISOAlpha3", "NumericCountryCode", "UpdateDate" },
                values: new object[,]
                {
                    { 6, "Albánie", "Albania", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9651), 4, "AL", "ALB", 8, null },
                    { 7, "Andorra", "Andorra", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9655), 2, "AD", "AND", 20, null },
                    { 8, "Arménie", "Armenia", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9661), 5, "AM", "ARM", 51, null },
                    { 9, "Ázerbájdžán", "Azerbaijan", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9665), 19, "AZ", "AZE", 31, null },
                    { 10, "Belgie", "Belgium", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9670), 2, "BE", "BEL", 56, null },
                    { 11, "Bělorusko", "Belarus", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9675), 24, "BY", "BLR", 112, null },
                    { 12, "Bosna a Hercegovina", "Bosnia and Herzegovina", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9681), 26, "BA", "BIH", 70, null },
                    { 13, "Bulharsko", "Bulgaria", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9691), 25, "BG", "BGR", 100, null },
                    { 14, "Černá Hora", "Montenegro", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9696), 2, "ME", "MNE", 499, null },
                    { 15, "Dánsko", "Denmark", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9701), 7, "DK", "DNK", 208, null },
                    { 16, "Estonsko", "Estonia", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9705), 2, "EE", "EST", 233, null },
                    { 17, "Finsko", "Finland", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9710), 2, "FI", "FIN", 246, null },
                    { 18, "Francie", "France", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9715), 2, "FR", "FRA", 250, null },
                    { 19, "Gruzie", "Georgia", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9719), 28, "GE", "GEO", 268, null },
                    { 20, "Chorvatsko", "Croatia", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9733), 6, "HR", "HRV", 191, null },
                    { 21, "Irsko", "Ireland", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9737), 2, "IE", "IRL", 372, null },
                    { 22, "Island", "Iceland", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9741), 9, "IS", "ISL", 352, null },
                    { 23, "Itálie", "Italy", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9745), 2, "IT", "ITA", 380, null },
                    { 24, "Kazachstán", "Kazakhstan", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9750), 10, "KZ", "KAZ", 398, null },
                    { 25, "Kypr (Kyperská republika)", "Cyprus", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9754), 2, "CY", "CYP", 196, null },
                    { 26, "Lichtenštejnsko (Lichtenštejnské knížectví)", "Liechtenstein", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9758), 15, "LI", "LIE", 438, null },
                    { 27, "Litva (Litevská republika)", "Lithuania", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9761), 2, "LT", "LTU", 440, null },
                    { 28, "Lotyšsko (Lotyšská republika)", "Latvia", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9765), 2, "LV", "LVA", 428, null },
                    { 29, "Lucembursko", "Luxembourg", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9769), 2, "LU", "LUX", 442, null },
                    { 30, "Maďarsko", "Hungary", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9773), 8, "HU", "HUN", 348, null },
                    { 31, "Malta", "Malta", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9778), 2, "MT", "MLT", 470, null },
                    { 32, "Moldavsko (Moldavská republika)", "Moldova", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9782), 11, "MD", "MDA", 498, null },
                    { 33, "Monako", "Monaco", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9786), 2, "MC", "MCO", 492, null },
                    { 34, "Nizozemsko", "Netherlands", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9790), 2, "NL", "NLD", 528, null },
                    { 35, "Norsko", "Norway", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9794), 12, "NO", "NOR", 578, null },
                    { 36, "Portugalsko", "Portugal", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9798), 2, "PT", "PRT", 620, null },
                    { 37, "Rumunsko", "Romania", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9801), 20, "RO", "ROU", 642, null },
                    { 38, "Rusko", "Russian Federation", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9805), 13, "RU", "RUS", 643, null },
                    { 39, "Řecko", "Greece", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9809), 2, "GR", "GRC", 300, null },
                    { 40, "San Marino", "San Marino", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9813), 2, "SM", "SMR", 674, null },
                    { 41, "Severní Makedonie (Republika Severní Makedonie)", "Macedonia, Republic of", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9817), 16, "MK", "MKD", 807, null },
                    { 42, "Slovinsko", "Slovenia", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9821), 2, "SI", "SVN", 705, null },
                    { 43, "Srbsko", "Serbia", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9825), 18, "RS", "SRB", 688, null },
                    { 44, "Španělsko", "Spain", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9829), 2, "ES", "ESP", 724, null },
                    { 45, "Švédsko", "Sweden", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9832), 14, "SE", "SWE", 752, null },
                    { 46, "Švýcarsko", "Switzerland", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9836), 21, "CH", "CHE", 756, null },
                    { 47, "Švýcarsko", "Switzerland", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9840), 15, "CH", "CHE", 756, null },
                    { 48, "Švýcarsko", "Switzerland", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9844), 22, "CH", "CHE", 756, null },
                    { 49, "Turecko", "Turkey", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9848), 23, "TR", "TUR", 792, null },
                    { 50, "Ukrajina", "Ukraine", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9852), 27, "UA", "UKR", 804, null },
                    { 51, "Vatikán (Městský stát Vatikán)", "Holy See (Vatican City State)", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9856), 2, "VA", "VAT", 336, null },
                    { 52, "Velká Británie (Spojené království)", "United Kingdom", new DateTime(2023, 11, 20, 16, 11, 49, 751, DateTimeKind.Local).AddTicks(9860), 17, "GB", "GBR", 826, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CurrencyId",
                table: "Countries",
                column: "CurrencyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Warranties");

            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}
