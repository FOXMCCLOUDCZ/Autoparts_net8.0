using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutopartsRepository.Migrations
{
    /// <inheritdoc />
    public partial class AddModelTableBrandCountryCurrencyManufacturerModelWarranty : Migration
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
                    BrandName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogoPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    BrandDescription = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
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
                    ManufacturerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogoPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ManufacturerDescription = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
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
                    WarrantyPeriod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false),
                    ModelName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MadeBy = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    MadeTo = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
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
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandDescription", "BrandName", "CreateDate", "IsActive", "LogoPath", "TecDoc", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "", "SPIDAN", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3505), true, null, 1, null },
                    { 2, "", "HELLA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3570), true, null, 2, null },
                    { 3, "", "ATE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3575), true, null, 3, null },
                    { 4, "", "MANN-FILTER", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3579), true, null, 4, null },
                    { 5, "", "PIERBURG", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3583), true, null, 5, null },
                    { 6, "", "LuK", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3587), true, null, 6, null },
                    { 7, "", "EBERSPÄCHER", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3590), true, null, 7, null },
                    { 8, "", "VICTOR REINZ", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3594), true, null, 9, null },
                    { 9, "", "ELRING", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3598), true, null, 10, null },
                    { 10, "", "BorgWarner (BERU)", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3601), true, null, 11, null },
                    { 11, "", "WALKER", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3605), true, null, 13, null },
                    { 12, "", "NGK", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3608), true, null, 15, null },
                    { 13, "", "BILSTEIN", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3612), true, null, 16, null },
                    { 14, "", "KONI", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3620), true, null, 18, null },
                    { 15, "", "SWF", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3623), true, null, 19, null },
                    { 16, "", "VALEO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3627), true, null, 21, null },
                    { 17, "", "RUVILLE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3631), true, null, 23, null },
                    { 18, "", "EXIDE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3635), true, null, 24, null },
                    { 19, "", "VARTA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3638), true, null, 26, null },
                    { 20, "", "ERNST", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3642), true, null, 29, null },
                    { 21, "", "BOSCH", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3645), true, null, 30, null },
                    { 22, "", "CONTINENTAL CTAM", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3650), true, null, 31, null },
                    { 23, "", "SACHS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3653), true, null, 32, null },
                    { 24, "", "GATES", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3657), true, null, 33, null },
                    { 25, "", "KNECHT", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3660), true, null, 34, null },
                    { 26, "", "LEMFÖRDER", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3664), true, null, 35, null },
                    { 27, "", "VAN WEZEL", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3667), true, null, 36, null },
                    { 28, "", "MONROE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3671), true, null, 37, null },
                    { 29, "", "PURFLUX", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3675), true, null, 38, null },
                    { 30, "", "TEXTAR", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3678), true, null, 39, null },
                    { 31, "", "BOSAL", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3682), true, null, 41, null },
                    { 32, "", "DAYCO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3687), true, null, 42, null },
                    { 33, "", "CHAMPION", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3690), true, null, 43, null },
                    { 34, "", "BREMI", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3775), true, null, 47, null },
                    { 35, "", "JURID", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3780), true, null, 48, null },
                    { 36, "", "SKF", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3783), true, null, 50, null },
                    { 37, "", "WESTFALIA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3787), true, null, 51, null },
                    { 38, "", "FTE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3790), true, null, 54, null },
                    { 39, "", "HERTH+BUSS JAKOPARTS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3794), true, null, 55, null },
                    { 40, "", "LÖBRO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3797), true, null, 56, null },
                    { 41, "", "QUINTON HAZELL", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3801), true, null, 57, null },
                    { 42, "", "TYC", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3804), true, null, 61, null },
                    { 43, "", "BREMBO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3808), true, null, 65, null },
                    { 44, "", "DENSO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3811), true, null, 66, null },
                    { 45, "", "ams-OSRAM", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3815), true, null, 67, null },
                    { 46, "", "ZF", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3818), true, null, 68, null },
                    { 47, "", "HERTH+BUSS ELPARTS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3822), true, null, 72, null },
                    { 48, "", "PHILIPS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3825), true, null, 75, null },
                    { 49, "", "KLOKKERHOLM", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3829), true, null, 78, null },
                    { 50, "", "BorgWarner (Wahler)", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3834), true, null, 79, null },
                    { 51, "", "HENGST FILTER", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3837), true, null, 81, null },
                    { 52, "", "CONTINENTAL/VDO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3841), true, null, 83, null },
                    { 53, "", "KYB", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3844), true, null, 85, null },
                    { 54, "", "ZIMMERMANN", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3848), true, null, 86, null },
                    { 55, "", "GLASER", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3851), true, null, 88, null },
                    { 56, "", "DELPHI", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3855), true, null, 89, null },
                    { 57, "", "METZGER", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3858), true, null, 94, null },
                    { 58, "", "MAGNETI MARELLI", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3862), true, null, 95, null },
                    { 59, "", "WAECO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3865), true, null, 97, null },
                    { 60, "", "FEBI BILSTEIN", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3869), true, null, 101, null },
                    { 61, "", "BRINK", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3872), true, null, 106, null },
                    { 62, "", "BUGATTI", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3876), true, null, 109, null },
                    { 63, "", "SNR", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3880), true, null, 110, null },
                    { 64, "", "EIBACH", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3883), true, null, 112, null },
                    { 65, "", "PAYEN", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3887), true, null, 113, null },
                    { 66, "", "BUDWEG CALIPER", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3890), true, null, 114, null },
                    { 67, "", "ULO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3894), true, null, 115, null },
                    { 68, "", "LRT", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3898), true, null, 117, null },
                    { 69, "", "HJS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3903), true, null, 118, null },
                    { 70, "", "METELLI", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3906), true, null, 121, null },
                    { 71, "", "NISSENS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3910), true, null, 123, null },
                    { 72, "", "STABILUS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3913), true, null, 126, null },
                    { 73, "", "NK", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3918), true, null, 127, null },
                    { 74, "", "OPTIMAL", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3921), true, null, 129, null },
                    { 75, "", "SIDEM", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3925), true, null, 135, null },
                    { 76, "", "UFI", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3928), true, null, 137, null },
                    { 77, "", "JOHNS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3932), true, null, 138, null },
                    { 78, "", "AJUSA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3935), true, null, 139, null },
                    { 79, "", "CORTECO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3939), true, null, 140, null },
                    { 80, "", "AE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3942), true, null, 141, null },
                    { 81, "", "SOFIMA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3946), true, null, 142, null },
                    { 82, "", "MEYLE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3950), true, null, 144, null },
                    { 83, "", "SWAG", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3954), true, null, 151, null },
                    { 84, "", "DOLZ", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3957), true, null, 154, null },
                    { 85, "", "JAPANPARTS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3961), true, null, 156, null },
                    { 86, "", "ICER", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3965), true, null, 158, null },
                    { 87, "", "FACET", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3969), true, null, 159, null },
                    { 88, "", "TRW", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3973), true, null, 161, null },
                    { 89, "", "VAICO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3976), true, null, 162, null },
                    { 90, "", "AISIN", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3980), true, null, 166, null },
                    { 91, "", "DUPLI COLOR", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3983), true, null, 167, null },
                    { 92, "", "MOTIP", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3987), true, null, 168, null },
                    { 93, "", "PRESTO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3990), true, null, 169, null },
                    { 94, "", "LESJÖFORS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3994), true, null, 175, null },
                    { 95, "", "BTS Turbo", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(3997), true, null, 177, null },
                    { 96, "", "HEPU", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4001), true, null, 178, null },
                    { 97, "", "ALCO FILTER", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4005), true, null, 180, null },
                    { 98, "", "GK", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4008), true, null, 181, null },
                    { 99, "", "SCHLÜTTER TURBOLADER", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4012), true, null, 182, null },
                    { 100, "", "VEMO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4016), true, null, 183, null },
                    { 101, "", "KAMOKA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4019), true, null, 185, null },
                    { 102, "", "IMASAF", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4023), true, null, 191, null },
                    { 103, "", "FAG", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4026), true, null, 192, null },
                    { 104, "", "LPR", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4031), true, null, 197, null },
                    { 105, "", "OCAP", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4034), true, null, 198, null },
                    { 106, "", "GLYCO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4038), true, null, 202, null },
                    { 107, "", "INA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4041), true, null, 204, null },
                    { 108, "", "NRF", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4045), true, null, 205, null },
                    { 109, "", "A.B.S.", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4048), true, null, 206, null },
                    { 110, "", "CASTROL", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4053), true, null, 207, null },
                    { 111, "", "TRUCKTEC AUTOMOTIVE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4057), true, null, 209, null },
                    { 112, "", "REMY", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4060), true, null, 214, null },
                    { 113, "", "CALORSTAT by Vernet", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4064), true, null, 215, null },
                    { 114, "", "NÜRAL", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4067), true, null, 216, null },
                    { 115, "", "AIRTEX", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4070), true, null, 220, null },
                    { 116, "", "LIQUI MOLY", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4074), true, null, 222, null },
                    { 117, "", "SCT - MANNOL", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4077), true, null, 225, null },
                    { 118, "", "ELSTOCK", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4080), true, null, 226, null },
                    { 119, "", "DINEX", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4084), true, null, 233, null },
                    { 120, "", "ERA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4160), true, null, 234, null },
                    { 121, "", "FRECCIA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4165), true, null, 235, null },
                    { 122, "", "FAE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4168), true, null, 240, null },
                    { 123, "", "MEAT & DORIA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4173), true, null, 244, null },
                    { 124, "", "AVA QUALITY COOLING", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4176), true, null, 247, null },
                    { 125, "", "NIPPARTS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4180), true, null, 248, null },
                    { 126, "", "FILTRON", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4183), true, null, 256, null },
                    { 127, "", "ASHIKA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4187), true, null, 257, null },
                    { 128, "", "SASIC", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4190), true, null, 260, null },
                    { 129, "", "FAI AutoParts", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4194), true, null, 267, null },
                    { 130, "", "JP GROUP", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4197), true, null, 268, null },
                    { 131, "", "AMC", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4201), true, null, 277, null },
                    { 132, "", "MAHLE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4204), true, null, 287, null },
                    { 133, "", "SACHS PERFORMANCE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4207), true, null, 294, null },
                    { 134, "", "fri.tech.", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4211), true, null, 295, null },
                    { 135, "", "sbs", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4214), true, null, 297, null },
                    { 136, "", "WEBASTO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4218), true, null, 299, null },
                    { 137, "", "AUTEX", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4222), true, null, 300, null },
                    { 138, "", "TOPRAN", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4225), true, null, 301, null },
                    { 139, "", "K&N Filters", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4229), true, null, 305, null },
                    { 140, "", "GRAF", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4232), true, null, 310, null },
                    { 141, "", "CIFAM", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4237), true, null, 311, null },
                    { 142, "", "GENERAL RICAMBI", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4240), true, null, 316, null },
                    { 143, "", "AUTOMEGA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4244), true, null, 323, null },
                    { 144, "", "WIX FILTERS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4247), true, null, 324, null },
                    { 145, "", "BorgWarner (Schwitze", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4250), true, null, 326, null },
                    { 146, "", "BorgWarner", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4254), true, null, 327, null },
                    { 147, "", "BorgWarner (3K)", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4257), true, null, 328, null },
                    { 148, "", "ORIGINAL IMPERIUM", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4261), true, null, 331, null },
                    { 149, "", "PRASCO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4264), true, null, 340, null },
                    { 150, "", "TRW Engine Component", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4268), true, null, 347, null },
                    { 151, "", "BLUE PRINT", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4271), true, null, 350, null },
                    { 152, "", "AUTOFREN SEINSA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4275), true, null, 351, null },
                    { 153, "", "TESLA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4279), true, null, 356, null },
                    { 154, "", "ALKAR", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4282), true, null, 362, null },
                    { 155, "", "FA1", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4285), true, null, 367, null },
                    { 156, "", "GSP", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4289), true, null, 373, null },
                    { 157, "", "CENTRA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4292), true, null, 376, null },
                    { 158, "", "BOSCH DIAGNOSTICS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4296), true, null, 377, null },
                    { 159, "", "FRENKIT", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4300), true, null, 380, null },
                    { 160, "", "GOETZE ENGINE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4304), true, null, 385, null },
                    { 161, "", "MOTORAD", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4307), true, null, 388, null },
                    { 162, "", "GLYSANTIN", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4311), true, null, 389, null },
                    { 163, "", "EAI", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4314), true, null, 391, null },
                    { 164, "", "BARUM", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4318), true, null, 394, null },
                    { 165, "", "JANMOR", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4321), true, null, 397, null },
                    { 166, "", "EXEDY", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4325), true, null, 399, null },
                    { 167, "", "RAICAM", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4329), true, null, 400, null },
                    { 168, "", "MAXGEAR", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4332), true, null, 403, null },
                    { 169, "", "BM CATALYSTS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4336), true, null, 406, null },
                    { 170, "", "FREMAX", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4339), true, null, 409, null },
                    { 171, "", "ASMET", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4343), true, null, 427, null },
                    { 172, "", "RTS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4346), true, null, 430, null },
                    { 173, "", "KOLBENSCHMIDT", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4349), true, null, 432, null },
                    { 174, "", "STATIM", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4353), true, null, 433, null },
                    { 175, "", "MOTUL", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4356), true, null, 436, null },
                    { 176, "", "CoopersFiaam", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4360), true, null, 437, null },
                    { 177, "", "ENERGIZER", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4364), true, null, 443, null },
                    { 178, "", "PILKINGTON", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4368), true, null, 447, null },
                    { 179, "", "HITACHI", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4371), true, null, 449, null },
                    { 180, "", "BANDO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4375), true, null, 454, null },
                    { 181, "", "DRI", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4378), true, null, 460, null },
                    { 182, "", "RAVENOL", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4382), true, null, 461, null },
                    { 183, "", "OSVAT", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4385), true, null, 464, null },
                    { 184, "", "CS Germany", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4388), true, null, 467, null },
                    { 185, "", "BORG & BECK", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4392), true, null, 475, null },
                    { 186, "", "ClimAir", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4395), true, null, 483, null },
                    { 187, "", "NARVA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4399), true, null, 485, null },
                    { 188, "", "BRISK", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4403), true, null, 494, null },
                    { 189, "", "ZAFFO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4406), true, null, 499, null },
                    { 190, "", "EPS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4410), true, null, 4005, null },
                    { 191, "", "KW", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4414), true, null, 4006, null },
                    { 192, "", "KS TOOLS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4417), true, null, 4023, null },
                    { 193, "", "VIGOR", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4421), true, null, 4026, null },
                    { 194, "", "SHELL", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4424), true, null, 4314, null },
                    { 195, "", "Prestone", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4428), true, null, 4333, null },
                    { 196, "", "ELTA AUTOMOTIVE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4432), true, null, 4344, null },
                    { 197, "", "vika", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4435), true, null, 4346, null },
                    { 198, "", "DPA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4439), true, null, 4353, null },
                    { 199, "", "STOP&GO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4442), true, null, 4367, null },
                    { 200, "", "PETEC", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4446), true, null, 4372, null },
                    { 201, "", "Airstal", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4449), true, null, 4381, null },
                    { 202, "", "CONTINENTAL", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4453), true, null, 4434, null },
                    { 203, "", "DUNLOP", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4456), true, null, 4436, null },
                    { 204, "", "MOBIL", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4460), true, null, 4449, null },
                    { 205, "", "YUASA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4537), true, null, 4451, null },
                    { 206, "", "GS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4541), true, null, 4452, null },
                    { 207, "", "SONAX", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4545), true, null, 4457, null },
                    { 208, "", "ERT", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4548), true, null, 4512, null },
                    { 209, "", "ET ENGINETEAM", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4552), true, null, 4514, null },
                    { 210, "", "LINEX", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4555), true, null, 4536, null },
                    { 211, "", "Arnott", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4559), true, null, 4539, null },
                    { 212, "", "TEDGUM", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4563), true, null, 4593, null },
                    { 213, "", "GE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4567), true, null, 4612, null },
                    { 214, "", "GARRETT", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4571), true, null, 4615, null },
                    { 215, "", "ABAKUS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4574), true, null, 4657, null },
                    { 216, "", "ROTINGER", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4578), true, null, 4676, null },
                    { 217, "", "CAFFARO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4581), true, null, 4679, null },
                    { 218, "", "MOBILETRON", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4585), true, null, 4705, null },
                    { 219, "", "NE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4588), true, null, 4717, null },
                    { 220, "", "LIFT-TEK", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4592), true, null, 4719, null },
                    { 221, "", "MIRAGLIO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4595), true, null, 4721, null },
                    { 222, "", "HELLA GUTMANN", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4599), true, null, 4734, null },
                    { 223, "", "HAZET", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4602), true, null, 4808, null },
                    { 224, "", "Borsehung", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4606), true, null, 4815, null },
                    { 225, "", "QUARO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4609), true, null, 4821, null },
                    { 226, "", "AS-PL", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4613), true, null, 4843, null },
                    { 227, "", "Ac Rolcar", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4616), true, null, 4849, null },
                    { 228, "", "ARAL", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4620), true, null, 4866, null },
                    { 229, "", "COFLE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4624), true, null, 4871, null },
                    { 230, "", "POLMO", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4627), true, null, 4873, null },
                    { 231, "", "DYNAMAX", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4631), true, null, 4881, null },
                    { 232, "", "ALLIGATOR", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4635), true, null, 4911, null },
                    { 233, "", "GEDORE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4638), true, null, 4912, null },
                    { 234, "", "NORMA", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4642), true, null, 4923, null },
                    { 235, "", "SCHRADER", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4645), true, null, 4946, null },
                    { 236, "", "TURBORAIL", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4649), true, null, 4949, null },
                    { 237, "", "ESEN SKV", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4653), true, null, 4969, null },
                    { 238, "", "HART", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4657), true, null, 5251, null },
                    { 239, "", "ACPS-ORIS", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4660), true, null, 6102, null },
                    { 240, "", "VALVOLINE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4664), true, null, 6186, null },
                    { 241, "", "CPB", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4668), true, null, 6263, null },
                    { 242, "", "QUICK BRAKE", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4672), true, null, 6304, null },
                    { 243, "", "GKN", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4675), true, null, 6306, null },
                    { 244, "", "REPSOL", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4678), true, null, 6343, null },
                    { 245, "", "EBC Brakes", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4682), true, null, 6368, null },
                    { 246, "", "BERU by DRiV", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4686), true, null, 6441, null },
                    { 247, "", "BorgWarner (AWD)", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4690), true, null, 6444, null },
                    { 248, "", "Dr.Motor Automotive", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4694), true, null, 6534, null },
                    { 249, "", "AIC", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4697), true, null, 6558, null },
                    { 250, "", "Oyodo", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4701), true, null, 6984, null },
                    { 251, "", "JPN", new DateTime(2023, 11, 30, 11, 47, 8, 43, DateTimeKind.Local).AddTicks(4704), true, null, 6985, null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CreateDate", "CurrencyCode", "CurrencyName", "IsActive", "NumericCurrencyCode", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(4934), "CZK", "Česká koruna", true, 203, null },
                    { 2, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(4968), "EUR", "Euro", true, 978, null },
                    { 3, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(4972), "PLN", "Złoty", true, 985, null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CreateDate", "CurrencyCode", "CurrencyName", "NumericCurrencyCode", "UpdateDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(4976), "ALL", "Albánský lek", 8, null },
                    { 5, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(4979), "AMD", "Arménský dram", 51, null },
                    { 6, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(4983), "HRK", "Kuna", 191, null },
                    { 7, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(4987), "DKK", "Dánská koruna", 208, null },
                    { 8, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(4990), "HUF", "Forint", 348, null },
                    { 9, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(4994), "ISK", "Islandská koruna", 352, null },
                    { 10, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(4997), "KZT", "Tenge", 398, null },
                    { 11, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(5000), "MDL", "Moldavské leu", 498, null },
                    { 12, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(5004), "NOK", "Norská koruna", 578, null },
                    { 13, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(5007), "RUB", "Ruský rubl", 643, null },
                    { 14, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(5011), "SEK", "Švédská koruna", 752, null },
                    { 15, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(5014), "CHF", "Švýcarský frank", 756, null },
                    { 16, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(5017), "MKD", "Denár", 807, null },
                    { 17, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(5021), "GBP", "Libra šterlinků", 826, null },
                    { 18, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(5024), "RSD", "Srbský dinár", 941, null },
                    { 19, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(5028), "AZN", "Ázerbájdžánský manat", 944, null },
                    { 20, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(5031), "RON", "Rumunské leu", 946, null },
                    { 21, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(5034), "CHE", "WIR Euro", 947, null },
                    { 22, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(5038), "CHW", "WIR Frank", 948, null },
                    { 23, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(5041), "TRY", "Turecká lira", 949, null },
                    { 24, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(5044), "BYR", "Běloruský rubl", 974, null },
                    { 25, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(5048), "BGN", "Bulharská leva", 975, null },
                    { 26, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(5051), "BAM", "Konvertibilní marka", 977, null },
                    { 27, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(5054), "UAH", "Ukrajinská hřivna", 980, null },
                    { 28, new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(5058), "GEL", "Lari", 981, null }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "LogoPath", "ManufacturerDescription", "ManufacturerName", "TecDoc", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 30, 11, 47, 8, 45, DateTimeKind.Local).AddTicks(6647), true, true, null, null, "AUDI", 3854, null },
                    { 2, new DateTime(2023, 11, 30, 11, 47, 8, 45, DateTimeKind.Local).AddTicks(6686), true, true, null, null, "MAN", 1480, null },
                    { 3, new DateTime(2023, 11, 30, 11, 47, 8, 45, DateTimeKind.Local).AddTicks(6695), true, true, null, null, "SEAT", 2, null },
                    { 4, new DateTime(2023, 11, 30, 11, 47, 8, 45, DateTimeKind.Local).AddTicks(6701), true, true, null, null, "ŠKODA", 1360, null },
                    { 5, new DateTime(2023, 11, 30, 11, 47, 8, 45, DateTimeKind.Local).AddTicks(6707), true, true, null, null, "VOLKSWAGEN", 881, null }
                });

            migrationBuilder.InsertData(
                table: "Warranties",
                columns: new[] { "Id", "CreateDate", "IsActive", "UpdateDate", "WarrantyPeriod" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 30, 11, 47, 8, 47, DateTimeKind.Local).AddTicks(2502), true, null, "6 měsíců" },
                    { 2, new DateTime(2023, 11, 30, 11, 47, 8, 47, DateTimeKind.Local).AddTicks(2530), true, null, "12 měsíců" },
                    { 3, new DateTime(2023, 11, 30, 11, 47, 8, 47, DateTimeKind.Local).AddTicks(2534), true, null, "24 měsíců" },
                    { 4, new DateTime(2023, 11, 30, 11, 47, 8, 47, DateTimeKind.Local).AddTicks(2537), true, null, "36 měsíců" }
                });

            migrationBuilder.InsertData(
                table: "Warranties",
                columns: new[] { "Id", "CreateDate", "UpdateDate", "WarrantyPeriod" },
                values: new object[,]
                {
                    { 5, new DateTime(2023, 11, 30, 11, 47, 8, 47, DateTimeKind.Local).AddTicks(2540), null, "48 měsíců" },
                    { 6, new DateTime(2023, 11, 30, 11, 47, 8, 47, DateTimeKind.Local).AddTicks(2543), null, "60 měsíců" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryNameCZ", "CountryNameENG", "CreateDate", "CurrencyId", "ISOAlpha2", "ISOAlpha3", "IsActive", "NumericCountryCode", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Česká republika", "Czech Republic", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(448), 1, "CZ", "CZE", true, 203, null },
                    { 2, "Slovenská republika", "Slovakia", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(484), 2, "SK", "SVK", true, 703, null },
                    { 3, "Polsko", "Poland", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(489), 3, "PL", "POL", true, 616, null },
                    { 4, "Německo", "Germany", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(494), 2, "DE", "DEU", true, 276, null },
                    { 5, "Rakousko", "Austria", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(498), 2, "AT", "AUT", true, 40, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryNameCZ", "CountryNameENG", "CreateDate", "CurrencyId", "ISOAlpha2", "ISOAlpha3", "NumericCountryCode", "UpdateDate" },
                values: new object[,]
                {
                    { 6, "Albánie", "Albania", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(502), 4, "AL", "ALB", 8, null },
                    { 7, "Andorra", "Andorra", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(506), 2, "AD", "AND", 20, null },
                    { 8, "Arménie", "Armenia", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(510), 5, "AM", "ARM", 51, null },
                    { 9, "Ázerbájdžán", "Azerbaijan", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(514), 19, "AZ", "AZE", 31, null },
                    { 10, "Belgie", "Belgium", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(518), 2, "BE", "BEL", 56, null },
                    { 11, "Bělorusko", "Belarus", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(522), 24, "BY", "BLR", 112, null },
                    { 12, "Bosna a Hercegovina", "Bosnia and Herzegovina", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(526), 26, "BA", "BIH", 70, null },
                    { 13, "Bulharsko", "Bulgaria", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(530), 25, "BG", "BGR", 100, null },
                    { 14, "Černá Hora", "Montenegro", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(534), 2, "ME", "MNE", 499, null },
                    { 15, "Dánsko", "Denmark", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(538), 7, "DK", "DNK", 208, null },
                    { 16, "Estonsko", "Estonia", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(543), 2, "EE", "EST", 233, null },
                    { 17, "Finsko", "Finland", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(547), 2, "FI", "FIN", 246, null },
                    { 18, "Francie", "France", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(551), 2, "FR", "FRA", 250, null },
                    { 19, "Gruzie", "Georgia", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(555), 28, "GE", "GEO", 268, null },
                    { 20, "Chorvatsko", "Croatia", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(559), 6, "HR", "HRV", 191, null },
                    { 21, "Irsko", "Ireland", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(562), 2, "IE", "IRL", 372, null },
                    { 22, "Island", "Iceland", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(567), 9, "IS", "ISL", 352, null },
                    { 23, "Itálie", "Italy", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(571), 2, "IT", "ITA", 380, null },
                    { 24, "Kazachstán", "Kazakhstan", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(575), 10, "KZ", "KAZ", 398, null },
                    { 25, "Kypr (Kyperská republika)", "Cyprus", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(579), 2, "CY", "CYP", 196, null },
                    { 26, "Lichtenštejnsko (Lichtenštejnské knížectví)", "Liechtenstein", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(583), 15, "LI", "LIE", 438, null },
                    { 27, "Litva (Litevská republika)", "Lithuania", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(587), 2, "LT", "LTU", 440, null },
                    { 28, "Lotyšsko (Lotyšská republika)", "Latvia", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(592), 2, "LV", "LVA", 428, null },
                    { 29, "Lucembursko", "Luxembourg", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(596), 2, "LU", "LUX", 442, null },
                    { 30, "Maďarsko", "Hungary", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(600), 8, "HU", "HUN", 348, null },
                    { 31, "Malta", "Malta", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(604), 2, "MT", "MLT", 470, null },
                    { 32, "Moldavsko (Moldavská republika)", "Moldova", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(609), 11, "MD", "MDA", 498, null },
                    { 33, "Monako", "Monaco", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(613), 2, "MC", "MCO", 492, null },
                    { 34, "Nizozemsko", "Netherlands", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(617), 2, "NL", "NLD", 528, null },
                    { 35, "Norsko", "Norway", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(621), 12, "NO", "NOR", 578, null },
                    { 36, "Portugalsko", "Portugal", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(625), 2, "PT", "PRT", 620, null },
                    { 37, "Rumunsko", "Romania", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(629), 20, "RO", "ROU", 642, null },
                    { 38, "Rusko", "Russian Federation", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(633), 13, "RU", "RUS", 643, null },
                    { 39, "Řecko", "Greece", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(637), 2, "GR", "GRC", 300, null },
                    { 40, "San Marino", "San Marino", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(641), 2, "SM", "SMR", 674, null },
                    { 41, "Severní Makedonie (Republika Severní Makedonie)", "Macedonia, Republic of", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(645), 16, "MK", "MKD", 807, null },
                    { 42, "Slovinsko", "Slovenia", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(649), 2, "SI", "SVN", 705, null },
                    { 43, "Srbsko", "Serbia", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(653), 18, "RS", "SRB", 688, null },
                    { 44, "Španělsko", "Spain", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(741), 2, "ES", "ESP", 724, null },
                    { 45, "Švédsko", "Sweden", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(747), 14, "SE", "SWE", 752, null },
                    { 46, "Švýcarsko", "Switzerland", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(753), 21, "CH", "CHE", 756, null },
                    { 47, "Švýcarsko", "Switzerland", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(757), 15, "CH", "CHE", 756, null },
                    { 48, "Švýcarsko", "Switzerland", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(761), 22, "CH", "CHE", 756, null },
                    { 49, "Turecko", "Turkey", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(765), 23, "TR", "TUR", 792, null },
                    { 50, "Ukrajina", "Ukraine", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(769), 27, "UA", "UKR", 804, null },
                    { 51, "Vatikán (Městský stát Vatikán)", "Holy See (Vatican City State)", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(773), 2, "VA", "VAT", 336, null },
                    { 52, "Velká Británie (Spojené království)", "United Kingdom", new DateTime(2023, 11, 30, 11, 47, 8, 44, DateTimeKind.Local).AddTicks(776), 17, "GB", "GBR", 826, null }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 30, 11, 47, 8, 46, DateTimeKind.Local).AddTicks(8683), true, true, new DateTime(1976, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "100 (431, 433, 434, C2)", null },
                    { 2, new DateTime(2023, 11, 30, 11, 47, 8, 46, DateTimeKind.Local).AddTicks(8731), true, true, new DateTime(1982, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "100 (443, 444, C3)", null },
                    { 3, new DateTime(2023, 11, 30, 11, 47, 8, 46, DateTimeKind.Local).AddTicks(8739), true, true, new DateTime(1990, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "100 (4A2, C4)", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CurrencyId",
                table: "Countries",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_ManufacturerId",
                table: "Models",
                column: "ManufacturerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Warranties");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
