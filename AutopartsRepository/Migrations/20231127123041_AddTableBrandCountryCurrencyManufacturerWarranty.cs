using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutopartsRepository.Migrations
{
    /// <inheritdoc />
    public partial class AddTableBrandCountryCurrencyManufacturerWarranty : Migration
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
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TecDoc = table.Column<int>(type: "int", maxLength: 6, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogoPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsAutoParts = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsPKW = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsLKW = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsMotorcycle = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsAgriculturalMachinery = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsCompressors = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsConstuctionAndMining = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsElectronicDischargeMachines = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsEngines = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsForkLiftTruck = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsIndustrialApplications = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsShipsAndBoats = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsVacuumPumps = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
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
                    { 1, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8552), "", true, null, 1, "SPIDAN", null },
                    { 2, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8608), "", true, null, 2, "HELLA", null },
                    { 3, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8613), "", true, null, 3, "ATE", null },
                    { 4, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8616), "", true, null, 4, "MANN-FILTER", null },
                    { 5, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8620), "", true, null, 5, "PIERBURG", null },
                    { 6, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8623), "", true, null, 6, "LuK", null },
                    { 7, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8627), "", true, null, 7, "EBERSPÄCHER", null },
                    { 8, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8630), "", true, null, 9, "VICTOR REINZ", null },
                    { 9, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8634), "", true, null, 10, "ELRING", null },
                    { 10, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8637), "", true, null, 11, "BorgWarner (BERU)", null },
                    { 11, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8641), "", true, null, 13, "WALKER", null },
                    { 12, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8644), "", true, null, 15, "NGK", null },
                    { 13, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8648), "", true, null, 16, "BILSTEIN", null },
                    { 14, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8709), "", true, null, 18, "KONI", null },
                    { 15, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8715), "", true, null, 19, "SWF", null },
                    { 16, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8718), "", true, null, 21, "VALEO", null },
                    { 17, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8723), "", true, null, 23, "RUVILLE", null },
                    { 18, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8726), "", true, null, 24, "EXIDE", null },
                    { 19, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8729), "", true, null, 26, "VARTA", null },
                    { 20, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8733), "", true, null, 29, "ERNST", null },
                    { 21, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8737), "", true, null, 30, "BOSCH", null },
                    { 22, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8741), "", true, null, 31, "CONTINENTAL CTAM", null },
                    { 23, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8745), "", true, null, 32, "SACHS", null },
                    { 24, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8748), "", true, null, 33, "GATES", null },
                    { 25, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8752), "", true, null, 34, "KNECHT", null },
                    { 26, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8755), "", true, null, 35, "LEMFÖRDER", null },
                    { 27, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8759), "", true, null, 36, "VAN WEZEL", null },
                    { 28, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8763), "", true, null, 37, "MONROE", null },
                    { 29, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8766), "", true, null, 38, "PURFLUX", null },
                    { 30, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8770), "", true, null, 39, "TEXTAR", null },
                    { 31, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8773), "", true, null, 41, "BOSAL", null },
                    { 32, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8777), "", true, null, 42, "DAYCO", null },
                    { 33, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8780), "", true, null, 43, "CHAMPION", null },
                    { 34, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8784), "", true, null, 47, "BREMI", null },
                    { 35, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8787), "", true, null, 48, "JURID", null },
                    { 36, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8791), "", true, null, 50, "SKF", null },
                    { 37, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8794), "", true, null, 51, "WESTFALIA", null },
                    { 38, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8797), "", true, null, 54, "FTE", null },
                    { 39, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8801), "", true, null, 55, "HERTH+BUSS JAKOPARTS", null },
                    { 40, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8805), "", true, null, 56, "LÖBRO", null },
                    { 41, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8808), "", true, null, 57, "QUINTON HAZELL", null },
                    { 42, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8812), "", true, null, 61, "TYC", null },
                    { 43, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8815), "", true, null, 65, "BREMBO", null },
                    { 44, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8819), "", true, null, 66, "DENSO", null },
                    { 45, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8823), "", true, null, 67, "ams-OSRAM", null },
                    { 46, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8826), "", true, null, 68, "ZF", null },
                    { 47, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8830), "", true, null, 72, "HERTH+BUSS ELPARTS", null },
                    { 48, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8833), "", true, null, 75, "PHILIPS", null },
                    { 49, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8837), "", true, null, 78, "KLOKKERHOLM", null },
                    { 50, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8840), "", true, null, 79, "BorgWarner (Wahler)", null },
                    { 51, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8844), "", true, null, 81, "HENGST FILTER", null },
                    { 52, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8847), "", true, null, 83, "CONTINENTAL/VDO", null },
                    { 53, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8851), "", true, null, 85, "KYB", null },
                    { 54, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8854), "", true, null, 86, "ZIMMERMANN", null },
                    { 55, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8858), "", true, null, 88, "GLASER", null },
                    { 56, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8861), "", true, null, 89, "DELPHI", null },
                    { 57, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8865), "", true, null, 94, "METZGER", null },
                    { 58, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8869), "", true, null, 95, "MAGNETI MARELLI", null },
                    { 59, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8872), "", true, null, 97, "WAECO", null },
                    { 60, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8876), "", true, null, 101, "FEBI BILSTEIN", null },
                    { 61, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8880), "", true, null, 106, "BRINK", null },
                    { 62, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8884), "", true, null, 109, "BUGATTI", null },
                    { 63, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8888), "", true, null, 110, "SNR", null },
                    { 64, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8891), "", true, null, 112, "EIBACH", null },
                    { 65, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8896), "", true, null, 113, "PAYEN", null },
                    { 66, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8900), "", true, null, 114, "BUDWEG CALIPER", null },
                    { 67, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8904), "", true, null, 115, "ULO", null },
                    { 68, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8908), "", true, null, 117, "LRT", null },
                    { 69, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8912), "", true, null, 118, "HJS", null },
                    { 70, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8916), "", true, null, 121, "METELLI", null },
                    { 71, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8920), "", true, null, 123, "NISSENS", null },
                    { 72, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8923), "", true, null, 126, "STABILUS", null },
                    { 73, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8927), "", true, null, 127, "NK", null },
                    { 74, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8930), "", true, null, 129, "OPTIMAL", null },
                    { 75, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8934), "", true, null, 135, "SIDEM", null },
                    { 76, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8938), "", true, null, 137, "UFI", null },
                    { 77, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8942), "", true, null, 138, "JOHNS", null },
                    { 78, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8945), "", true, null, 139, "AJUSA", null },
                    { 79, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8949), "", true, null, 140, "CORTECO", null },
                    { 80, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8952), "", true, null, 141, "AE", null },
                    { 81, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8956), "", true, null, 142, "SOFIMA", null },
                    { 82, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8960), "", true, null, 144, "MEYLE", null },
                    { 83, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8963), "", true, null, 151, "SWAG", null },
                    { 84, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8967), "", true, null, 154, "DOLZ", null },
                    { 85, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8970), "", true, null, 156, "JAPANPARTS", null },
                    { 86, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8974), "", true, null, 158, "ICER", null },
                    { 87, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8977), "", true, null, 159, "FACET", null },
                    { 88, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8981), "", true, null, 161, "TRW", null },
                    { 89, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8984), "", true, null, 162, "VAICO", null },
                    { 90, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8988), "", true, null, 166, "AISIN", null },
                    { 91, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8991), "", true, null, 167, "DUPLI COLOR", null },
                    { 92, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8995), "", true, null, 168, "MOTIP", null },
                    { 93, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(8998), "", true, null, 169, "PRESTO", null },
                    { 94, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9003), "", true, null, 175, "LESJÖFORS", null },
                    { 95, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9006), "", true, null, 177, "BTS Turbo", null },
                    { 96, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9010), "", true, null, 178, "HEPU", null },
                    { 97, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9139), "", true, null, 180, "ALCO FILTER", null },
                    { 98, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9145), "", true, null, 181, "GK", null },
                    { 99, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9148), "", true, null, 182, "SCHLÜTTER TURBOLADER", null },
                    { 100, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9152), "", true, null, 183, "VEMO", null },
                    { 101, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9155), "", true, null, 185, "KAMOKA", null },
                    { 102, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9159), "", true, null, 191, "IMASAF", null },
                    { 103, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9163), "", true, null, 192, "FAG", null },
                    { 104, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9167), "", true, null, 197, "LPR", null },
                    { 105, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9170), "", true, null, 198, "OCAP", null },
                    { 106, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9174), "", true, null, 202, "GLYCO", null },
                    { 107, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9177), "", true, null, 204, "INA", null },
                    { 108, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9181), "", true, null, 205, "NRF", null },
                    { 109, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9184), "", true, null, 206, "A.B.S.", null },
                    { 110, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9188), "", true, null, 207, "CASTROL", null },
                    { 111, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9191), "", true, null, 209, "TRUCKTEC AUTOMOTIVE", null },
                    { 112, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9196), "", true, null, 214, "REMY", null },
                    { 113, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9199), "", true, null, 215, "CALORSTAT by Vernet", null },
                    { 114, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9203), "", true, null, 216, "NÜRAL", null },
                    { 115, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9206), "", true, null, 220, "AIRTEX", null },
                    { 116, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9210), "", true, null, 222, "LIQUI MOLY", null },
                    { 117, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9213), "", true, null, 225, "SCT - MANNOL", null },
                    { 118, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9217), "", true, null, 226, "ELSTOCK", null },
                    { 119, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9220), "", true, null, 233, "DINEX", null },
                    { 120, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9224), "", true, null, 234, "ERA", null },
                    { 121, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9227), "", true, null, 235, "FRECCIA", null },
                    { 122, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9231), "", true, null, 240, "FAE", null },
                    { 123, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9234), "", true, null, 244, "MEAT & DORIA", null },
                    { 124, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9237), "", true, null, 247, "AVA QUALITY COOLING", null },
                    { 125, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9241), "", true, null, 248, "NIPPARTS", null },
                    { 126, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9245), "", true, null, 256, "FILTRON", null },
                    { 127, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9248), "", true, null, 257, "ASHIKA", null },
                    { 128, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9251), "", true, null, 260, "SASIC", null },
                    { 129, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9255), "", true, null, 267, "FAI AutoParts", null },
                    { 130, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9258), "", true, null, 268, "JP GROUP", null },
                    { 131, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9265), "", true, null, 277, "AMC", null },
                    { 132, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9268), "", true, null, 287, "MAHLE", null },
                    { 133, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9272), "", true, null, 294, "SACHS PERFORMANCE", null },
                    { 134, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9275), "", true, null, 295, "fri.tech.", null },
                    { 135, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9279), "", true, null, 297, "sbs", null },
                    { 136, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9282), "", true, null, 299, "WEBASTO", null },
                    { 137, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9286), "", true, null, 300, "AUTEX", null },
                    { 138, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9289), "", true, null, 301, "TOPRAN", null },
                    { 139, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9293), "", true, null, 305, "K&N Filters", null },
                    { 140, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9297), "", true, null, 310, "GRAF", null },
                    { 141, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9300), "", true, null, 311, "CIFAM", null },
                    { 142, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9303), "", true, null, 316, "GENERAL RICAMBI", null },
                    { 143, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9307), "", true, null, 323, "AUTOMEGA", null },
                    { 144, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9310), "", true, null, 324, "WIX FILTERS", null },
                    { 145, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9314), "", true, null, 326, "BorgWarner (Schwitze", null },
                    { 146, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9317), "", true, null, 327, "BorgWarner", null },
                    { 147, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9321), "", true, null, 328, "BorgWarner (3K)", null },
                    { 148, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9325), "", true, null, 331, "ORIGINAL IMPERIUM", null },
                    { 149, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9329), "", true, null, 340, "PRASCO", null },
                    { 150, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9332), "", true, null, 347, "TRW Engine Component", null },
                    { 151, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9336), "", true, null, 350, "BLUE PRINT", null },
                    { 152, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9339), "", true, null, 351, "AUTOFREN SEINSA", null },
                    { 153, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9343), "", true, null, 356, "TESLA", null },
                    { 154, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9346), "", true, null, 362, "ALKAR", null },
                    { 155, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9350), "", true, null, 367, "FA1", null },
                    { 156, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9354), "", true, null, 373, "GSP", null },
                    { 157, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9357), "", true, null, 376, "CENTRA", null },
                    { 158, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9361), "", true, null, 377, "BOSCH DIAGNOSTICS", null },
                    { 159, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9364), "", true, null, 380, "FRENKIT", null },
                    { 160, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9367), "", true, null, 385, "GOETZE ENGINE", null },
                    { 161, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9371), "", true, null, 388, "MOTORAD", null },
                    { 162, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9375), "", true, null, 389, "GLYSANTIN", null },
                    { 163, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9378), "", true, null, 391, "EAI", null },
                    { 164, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9383), "", true, null, 394, "BARUM", null },
                    { 165, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9387), "", true, null, 397, "JANMOR", null },
                    { 166, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9390), "", true, null, 399, "EXEDY", null },
                    { 167, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9395), "", true, null, 400, "RAICAM", null },
                    { 168, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9399), "", true, null, 403, "MAXGEAR", null },
                    { 169, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9403), "", true, null, 406, "BM CATALYSTS", null },
                    { 170, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9407), "", true, null, 409, "FREMAX", null },
                    { 171, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9410), "", true, null, 427, "ASMET", null },
                    { 172, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9414), "", true, null, 430, "RTS", null },
                    { 173, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9417), "", true, null, 432, "KOLBENSCHMIDT", null },
                    { 174, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9421), "", true, null, 433, "STATIM", null },
                    { 175, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9424), "", true, null, 436, "MOTUL", null },
                    { 176, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9428), "", true, null, 437, "CoopersFiaam", null },
                    { 177, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9431), "", true, null, 443, "ENERGIZER", null },
                    { 178, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9435), "", true, null, 447, "PILKINGTON", null },
                    { 179, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9438), "", true, null, 449, "HITACHI", null },
                    { 180, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9442), "", true, null, 454, "BANDO", null },
                    { 181, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9445), "", true, null, 460, "DRI", null },
                    { 182, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9541), "", true, null, 461, "RAVENOL", null },
                    { 183, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9545), "", true, null, 464, "OSVAT", null },
                    { 184, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9549), "", true, null, 467, "CS Germany", null },
                    { 185, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9553), "", true, null, 475, "BORG & BECK", null },
                    { 186, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9557), "", true, null, 483, "ClimAir", null },
                    { 187, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9560), "", true, null, 485, "NARVA", null },
                    { 188, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9564), "", true, null, 494, "BRISK", null },
                    { 189, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9567), "", true, null, 499, "ZAFFO", null },
                    { 190, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9571), "", true, null, 4005, "EPS", null },
                    { 191, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9574), "", true, null, 4006, "KW", null },
                    { 192, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9577), "", true, null, 4023, "KS TOOLS", null },
                    { 193, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9581), "", true, null, 4026, "VIGOR", null },
                    { 194, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9585), "", true, null, 4314, "SHELL", null },
                    { 195, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9588), "", true, null, 4333, "Prestone", null },
                    { 196, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9592), "", true, null, 4344, "ELTA AUTOMOTIVE", null },
                    { 197, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9595), "", true, null, 4346, "vika", null },
                    { 198, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9599), "", true, null, 4353, "DPA", null },
                    { 199, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9602), "", true, null, 4367, "STOP&GO", null },
                    { 200, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9606), "", true, null, 4372, "PETEC", null },
                    { 201, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9609), "", true, null, 4381, "Airstal", null },
                    { 202, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9613), "", true, null, 4434, "CONTINENTAL", null },
                    { 203, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9617), "", true, null, 4436, "DUNLOP", null },
                    { 204, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9621), "", true, null, 4449, "MOBIL", null },
                    { 205, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9624), "", true, null, 4451, "YUASA", null },
                    { 206, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9627), "", true, null, 4452, "GS", null },
                    { 207, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9631), "", true, null, 4457, "SONAX", null },
                    { 208, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9634), "", true, null, 4512, "ERT", null },
                    { 209, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9638), "", true, null, 4514, "ET ENGINETEAM", null },
                    { 210, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9641), "", true, null, 4536, "LINEX", null },
                    { 211, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9645), "", true, null, 4539, "Arnott", null },
                    { 212, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9648), "", true, null, 4593, "TEDGUM", null },
                    { 213, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9652), "", true, null, 4612, "GE", null },
                    { 214, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9655), "", true, null, 4615, "GARRETT", null },
                    { 215, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9659), "", true, null, 4657, "ABAKUS", null },
                    { 216, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9662), "", true, null, 4676, "ROTINGER", null },
                    { 217, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9666), "", true, null, 4679, "CAFFARO", null },
                    { 218, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9669), "", true, null, 4705, "MOBILETRON", null },
                    { 219, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9673), "", true, null, 4717, "NE", null },
                    { 220, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9676), "", true, null, 4719, "LIFT-TEK", null },
                    { 221, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9681), "", true, null, 4721, "MIRAGLIO", null },
                    { 222, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9684), "", true, null, 4734, "HELLA GUTMANN", null },
                    { 223, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9688), "", true, null, 4808, "HAZET", null },
                    { 224, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9691), "", true, null, 4815, "Borsehung", null },
                    { 225, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9695), "", true, null, 4821, "QUARO", null },
                    { 226, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9698), "", true, null, 4843, "AS-PL", null },
                    { 227, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9701), "", true, null, 4849, "Ac Rolcar", null },
                    { 228, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9705), "", true, null, 4866, "ARAL", null },
                    { 229, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9708), "", true, null, 4871, "COFLE", null },
                    { 230, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9712), "", true, null, 4873, "POLMO", null },
                    { 231, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9716), "", true, null, 4881, "DYNAMAX", null },
                    { 232, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9719), "", true, null, 4911, "ALLIGATOR", null },
                    { 233, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9722), "", true, null, 4912, "GEDORE", null },
                    { 234, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9726), "", true, null, 4923, "NORMA", null },
                    { 235, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9729), "", true, null, 4946, "SCHRADER", null },
                    { 236, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9733), "", true, null, 4949, "TURBORAIL", null },
                    { 237, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9737), "", true, null, 4969, "ESEN SKV", null },
                    { 238, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9740), "", true, null, 5251, "HART", null },
                    { 239, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9743), "", true, null, 6102, "ACPS-ORIS", null },
                    { 240, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9747), "", true, null, 6186, "VALVOLINE", null },
                    { 241, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9750), "", true, null, 6263, "CPB", null },
                    { 242, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9754), "", true, null, 6304, "QUICK BRAKE", null },
                    { 243, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9757), "", true, null, 6306, "GKN", null },
                    { 244, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9760), "", true, null, 6343, "REPSOL", null },
                    { 245, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9764), "", true, null, 6368, "EBC Brakes", null },
                    { 246, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9767), "", true, null, 6441, "BERU by DRiV", null },
                    { 247, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9771), "", true, null, 6444, "BorgWarner (AWD)", null },
                    { 248, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9774), "", true, null, 6534, "Dr.Motor Automotive", null },
                    { 249, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9778), "", true, null, 6558, "AIC", null },
                    { 250, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9781), "", true, null, 6984, "Oyodo", null },
                    { 251, new DateTime(2023, 11, 27, 13, 30, 39, 471, DateTimeKind.Local).AddTicks(9785), "", true, null, 6985, "JPN", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CreateDate", "CurrencyCode", "CurrencyName", "IsActive", "NumericCurrencyCode", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(88), "CZK", "Česká koruna", true, 203, null },
                    { 2, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(119), "EUR", "Euro", true, 978, null },
                    { 3, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(123), "PLN", "Złoty", true, 985, null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CreateDate", "CurrencyCode", "CurrencyName", "NumericCurrencyCode", "UpdateDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(127), "ALL", "Albánský lek", 8, null },
                    { 5, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(130), "AMD", "Arménský dram", 51, null },
                    { 6, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(134), "HRK", "Kuna", 191, null },
                    { 7, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(137), "DKK", "Dánská koruna", 208, null },
                    { 8, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(141), "HUF", "Forint", 348, null },
                    { 9, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(145), "ISK", "Islandská koruna", 352, null },
                    { 10, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(148), "KZT", "Tenge", 398, null },
                    { 11, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(152), "MDL", "Moldavské leu", 498, null },
                    { 12, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(155), "NOK", "Norská koruna", 578, null },
                    { 13, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(158), "RUB", "Ruský rubl", 643, null },
                    { 14, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(162), "SEK", "Švédská koruna", 752, null },
                    { 15, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(165), "CHF", "Švýcarský frank", 756, null },
                    { 16, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(169), "MKD", "Denár", 807, null },
                    { 17, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(172), "GBP", "Libra šterlinků", 826, null },
                    { 18, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(176), "RSD", "Srbský dinár", 941, null },
                    { 19, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(179), "AZN", "Ázerbájdžánský manat", 944, null },
                    { 20, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(183), "RON", "Rumunské leu", 946, null },
                    { 21, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(186), "CHE", "WIR Euro", 947, null },
                    { 22, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(190), "CHW", "WIR Frank", 948, null },
                    { 23, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(193), "TRY", "Turecká lira", 949, null },
                    { 24, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(197), "BYR", "Běloruský rubl", 974, null },
                    { 25, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(201), "BGN", "Bulharská leva", 975, null },
                    { 26, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(204), "BAM", "Konvertibilní marka", 977, null },
                    { 27, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(208), "UAH", "Ukrajinská hřivna", 980, null },
                    { 28, new DateTime(2023, 11, 27, 13, 30, 39, 473, DateTimeKind.Local).AddTicks(211), "GEL", "Lari", 981, null }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "CreateDate", "Description", "IsActive", "IsPKW", "LogoPath", "TecDoc", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1415), null, true, true, null, 3854, "ABARTH", null },
                    { 2, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1449), null, true, true, null, 1480, "AIXAM", null },
                    { 3, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1456), null, true, true, null, 2, "ALFA ROMEO", null },
                    { 4, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1462), null, true, true, null, 1360, "ARO", null },
                    { 5, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1468), null, true, true, null, 881, "ASTON MARTIN", null },
                    { 6, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1475), null, true, true, null, 5, "AUDI", null },
                    { 7, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1556), null, true, true, null, 6, "AUSTIN", null },
                    { 8, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1564), null, true, true, null, 799, "AUTOBIANCHI", null },
                    { 9, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1570), null, true, true, null, 815, "BENTLEY", null },
                    { 10, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1576), null, true, true, null, 16, "BMW", null },
                    { 11, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1582), null, true, true, null, 788, "BUGATTI", null },
                    { 12, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1589), null, true, true, null, 816, "BUICK", null },
                    { 13, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1594), null, true, true, null, 819, "CADILLAC", null },
                    { 14, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1600), null, true, true, null, 21, "CITROËN", null },
                    { 15, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1605), null, true, true, null, 139, "DACIA", null },
                    { 16, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1615), null, true, true, null, 185, "DAEWOO", null },
                    { 17, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1621), null, true, true, null, 24, "DAF", null },
                    { 18, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1627), null, true, true, null, 25, "DAIHATSU", null },
                    { 19, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1634), null, true, true, null, 29, "DODGE", null },
                    { 20, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1640), null, true, true, null, 4468, "DS", null },
                    { 21, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1646), null, true, true, null, 3332, "EMGRAND", null },
                    { 22, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1653), null, true, true, null, 700, "FERRARI", null },
                    { 23, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1659), null, true, true, null, 35, "FIAT", null },
                    { 24, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1665), null, true, true, null, 36, "FORD", null },
                    { 25, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1671), null, true, true, null, 776, "FORD USA", null },
                    { 26, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1677), null, true, true, null, 148, "GAZ", null },
                    { 27, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1683), null, true, true, null, 2590, "GEELY", null },
                    { 28, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1688), null, true, true, null, 831, "GEO", null },
                    { 29, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1694), null, true, true, null, 2903, "GREAT WALL", null },
                    { 30, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1700), null, true, true, null, 45, "HONDA", null },
                    { 31, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1707), null, true, true, null, 1506, "HUMMER", null },
                    { 32, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1712), null, true, true, null, 183, "HYUNDAI", null },
                    { 33, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1718), null, true, true, null, 2887, "CHERY", null },
                    { 34, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1724), null, true, true, null, 138, "CHEVROLET", null },
                    { 35, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1729), null, true, true, null, 20, "CHRYSLER", null },
                    { 36, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1735), null, true, true, null, 1526, "INFINITI", null },
                    { 37, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1741), null, true, true, null, 54, "ISUZU", null },
                    { 38, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1746), null, true, true, null, 55, "IVECO", null },
                    { 39, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1752), null, true, true, null, 56, "JAGUAR", null },
                    { 40, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1759), null, true, true, null, 882, "JEEP", null },
                    { 41, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1764), null, true, true, null, 184, "KIA", null },
                    { 42, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1770), null, true, true, null, 2760, "KTM", null },
                    { 43, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1776), null, true, true, null, 63, "LADA", null },
                    { 44, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1782), null, true, true, null, 701, "LAMBORGHINI", null },
                    { 45, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1787), null, true, true, null, 64, "LANCIA", null },
                    { 46, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1793), null, true, true, null, 1820, "LAND ROVER", null },
                    { 47, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1799), null, true, true, null, 1380, "LDV", null },
                    { 48, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1804), null, true, true, null, 842, "LEXUS", null },
                    { 49, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1810), null, true, true, null, 1200, "LINCOLN", null },
                    { 50, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1816), null, true, true, null, 802, "LOTUS", null },
                    { 51, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1821), null, true, true, null, 69, "MAN", null },
                    { 52, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1827), null, true, true, null, 771, "MASERATI", null },
                    { 53, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1833), null, true, true, null, 72, "MAZDA", null },
                    { 54, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1839), null, true, true, null, 74, "MERCEDES-BENZ", null },
                    { 55, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1844), null, true, true, null, 75, "MG", null },
                    { 56, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1850), null, true, true, null, 1523, "MINI", null },
                    { 57, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1855), null, true, true, null, 77, "MITSUBISHI", null },
                    { 58, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1861), null, true, true, null, 813, "MOSKVICH", null },
                    { 59, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1867), null, true, true, null, 80, "NISSAN", null },
                    { 60, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1873), null, true, true, null, 84, "OPEL", null },
                    { 61, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1878), null, true, true, null, 88, "PEUGEOT", null },
                    { 62, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1883), null, true, true, null, 850, "PLYMOUTH", null },
                    { 63, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1889), null, true, true, null, 774, "PONTIAC", null },
                    { 64, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1894), null, true, true, null, 92, "PORSCHE", null },
                    { 65, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1900), null, true, true, null, 778, "PROTON", null },
                    { 66, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1906), null, true, true, null, 93, "RENAULT", null },
                    { 67, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1911), null, true, true, null, 694, "RENAULT TRUCKS", null },
                    { 68, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1918), null, true, true, null, 705, "ROLLS-ROYCE", null },
                    { 69, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1923), null, true, true, null, 95, "ROVER", null },
                    { 70, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1930), null, true, true, null, 99, "SAAB", null },
                    { 71, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1936), null, true, true, null, 104, "SEAT", null },
                    { 72, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1942), null, true, true, null, 106, "ŠKODA", null },
                    { 73, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1947), null, true, true, null, 1138, "SMART", null },
                    { 74, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1953), null, true, true, null, 175, "SSANGYONG", null },
                    { 75, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1959), null, true, true, null, 107, "SUBARU", null },
                    { 76, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1965), null, true, true, null, 109, "SUZUKI", null },
                    { 77, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1970), null, true, true, null, 110, "TALBOT", null },
                    { 78, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1976), null, true, true, null, 3328, "TESLA", null },
                    { 79, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1981), null, true, true, null, 111, "TOYOTA", null },
                    { 80, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1987), null, true, true, null, 187, "TRABANT", null },
                    { 81, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1992), null, true, true, null, 121, "VOLKSWAGEN", null },
                    { 82, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(1998), null, true, true, null, 120, "VOLVO", null },
                    { 83, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(2004), null, true, true, null, 186, "WARTBURG", null }
                });

            migrationBuilder.InsertData(
                table: "Warranties",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(5676), true, "6 měsíců", null },
                    { 2, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(5703), true, "12 měsíců", null },
                    { 3, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(5707), true, "24 měsíců", null },
                    { 4, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(5711), true, "36 měsíců", null }
                });

            migrationBuilder.InsertData(
                table: "Warranties",
                columns: new[] { "Id", "CreateDate", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 5, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(5714), "48 měsíců", null },
                    { 6, new DateTime(2023, 11, 27, 13, 30, 39, 474, DateTimeKind.Local).AddTicks(5717), "60 měsíců", null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryNameCZ", "CountryNameENG", "CreateDate", "CurrencyId", "ISOAlpha2", "ISOAlpha3", "IsActive", "NumericCountryCode", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Česká republika", "Czech Republic", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5115), 1, "CZ", "CZE", true, 203, null },
                    { 2, "Slovenská republika", "Slovakia", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5153), 2, "SK", "SVK", true, 703, null },
                    { 3, "Polsko", "Poland", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5158), 3, "PL", "POL", true, 616, null },
                    { 4, "Německo", "Germany", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5163), 2, "DE", "DEU", true, 276, null },
                    { 5, "Rakousko", "Austria", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5167), 2, "AT", "AUT", true, 40, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryNameCZ", "CountryNameENG", "CreateDate", "CurrencyId", "ISOAlpha2", "ISOAlpha3", "NumericCountryCode", "UpdateDate" },
                values: new object[,]
                {
                    { 6, "Albánie", "Albania", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5171), 4, "AL", "ALB", 8, null },
                    { 7, "Andorra", "Andorra", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5176), 2, "AD", "AND", 20, null },
                    { 8, "Arménie", "Armenia", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5180), 5, "AM", "ARM", 51, null },
                    { 9, "Ázerbájdžán", "Azerbaijan", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5185), 19, "AZ", "AZE", 31, null },
                    { 10, "Belgie", "Belgium", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5189), 2, "BE", "BEL", 56, null },
                    { 11, "Bělorusko", "Belarus", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5194), 24, "BY", "BLR", 112, null },
                    { 12, "Bosna a Hercegovina", "Bosnia and Herzegovina", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5198), 26, "BA", "BIH", 70, null },
                    { 13, "Bulharsko", "Bulgaria", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5202), 25, "BG", "BGR", 100, null },
                    { 14, "Černá Hora", "Montenegro", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5206), 2, "ME", "MNE", 499, null },
                    { 15, "Dánsko", "Denmark", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5210), 7, "DK", "DNK", 208, null },
                    { 16, "Estonsko", "Estonia", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5214), 2, "EE", "EST", 233, null },
                    { 17, "Finsko", "Finland", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5306), 2, "FI", "FIN", 246, null },
                    { 18, "Francie", "France", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5311), 2, "FR", "FRA", 250, null },
                    { 19, "Gruzie", "Georgia", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5315), 28, "GE", "GEO", 268, null },
                    { 20, "Chorvatsko", "Croatia", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5320), 6, "HR", "HRV", 191, null },
                    { 21, "Irsko", "Ireland", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5324), 2, "IE", "IRL", 372, null },
                    { 22, "Island", "Iceland", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5328), 9, "IS", "ISL", 352, null },
                    { 23, "Itálie", "Italy", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5333), 2, "IT", "ITA", 380, null },
                    { 24, "Kazachstán", "Kazakhstan", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5337), 10, "KZ", "KAZ", 398, null },
                    { 25, "Kypr (Kyperská republika)", "Cyprus", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5341), 2, "CY", "CYP", 196, null },
                    { 26, "Lichtenštejnsko (Lichtenštejnské knížectví)", "Liechtenstein", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5344), 15, "LI", "LIE", 438, null },
                    { 27, "Litva (Litevská republika)", "Lithuania", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5348), 2, "LT", "LTU", 440, null },
                    { 28, "Lotyšsko (Lotyšská republika)", "Latvia", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5352), 2, "LV", "LVA", 428, null },
                    { 29, "Lucembursko", "Luxembourg", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5357), 2, "LU", "LUX", 442, null },
                    { 30, "Maďarsko", "Hungary", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5361), 8, "HU", "HUN", 348, null },
                    { 31, "Malta", "Malta", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5365), 2, "MT", "MLT", 470, null },
                    { 32, "Moldavsko (Moldavská republika)", "Moldova", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5368), 11, "MD", "MDA", 498, null },
                    { 33, "Monako", "Monaco", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5372), 2, "MC", "MCO", 492, null },
                    { 34, "Nizozemsko", "Netherlands", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5376), 2, "NL", "NLD", 528, null },
                    { 35, "Norsko", "Norway", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5380), 12, "NO", "NOR", 578, null },
                    { 36, "Portugalsko", "Portugal", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5385), 2, "PT", "PRT", 620, null },
                    { 37, "Rumunsko", "Romania", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5390), 20, "RO", "ROU", 642, null },
                    { 38, "Rusko", "Russian Federation", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5395), 13, "RU", "RUS", 643, null },
                    { 39, "Řecko", "Greece", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5399), 2, "GR", "GRC", 300, null },
                    { 40, "San Marino", "San Marino", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5403), 2, "SM", "SMR", 674, null },
                    { 41, "Severní Makedonie (Republika Severní Makedonie)", "Macedonia, Republic of", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5407), 16, "MK", "MKD", 807, null },
                    { 42, "Slovinsko", "Slovenia", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5411), 2, "SI", "SVN", 705, null },
                    { 43, "Srbsko", "Serbia", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5415), 18, "RS", "SRB", 688, null },
                    { 44, "Španělsko", "Spain", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5419), 2, "ES", "ESP", 724, null },
                    { 45, "Švédsko", "Sweden", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5423), 14, "SE", "SWE", 752, null },
                    { 46, "Švýcarsko", "Switzerland", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5427), 21, "CH", "CHE", 756, null },
                    { 47, "Švýcarsko", "Switzerland", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5431), 15, "CH", "CHE", 756, null },
                    { 48, "Švýcarsko", "Switzerland", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5435), 22, "CH", "CHE", 756, null },
                    { 49, "Turecko", "Turkey", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5439), 23, "TR", "TUR", 792, null },
                    { 50, "Ukrajina", "Ukraine", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5444), 27, "UA", "UKR", 804, null },
                    { 51, "Vatikán (Městský stát Vatikán)", "Holy See (Vatican City State)", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5448), 2, "VA", "VAT", 336, null },
                    { 52, "Velká Británie (Spojené království)", "United Kingdom", new DateTime(2023, 11, 27, 13, 30, 39, 472, DateTimeKind.Local).AddTicks(5453), 17, "GB", "GBR", 826, null }
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
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Warranties");

            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}
