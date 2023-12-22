using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutopartsRepository.Migrations
{
    /// <inheritdoc />
    public partial class InitTest : Migration
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
                name: "ProductGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TecDoc = table.Column<int>(type: "int", maxLength: 6, nullable: true),
                    ProductGroupName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroups", x => x.Id);
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
                name: "Model",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false),
                    ModelName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MadeBy = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    MadeTo = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: true),
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
                    table.PrimaryKey("PK_Model", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Model_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false),
                    OeNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oes_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OeNumberGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OeNumberInGroupId = table.Column<int>(type: "int", nullable: false),
                    OeId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OeNumberGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OeNumberGroups_Oes_OeId",
                        column: x => x.OeId,
                        principalTable: "Oes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    ProductNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShortNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ProductGroupId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OeNumberInGroupId = table.Column<int>(type: "int", nullable: true),
                    OeNumberGroupId = table.Column<int>(type: "int", nullable: true),
                    SKUCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    RetailPrice = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    RefundableDeposit = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    PackedBy = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    WarrantyId = table.Column<int>(type: "int", nullable: false, defaultValue: 3),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_OeNumberGroups_OeNumberGroupId",
                        column: x => x.OeNumberGroupId,
                        principalTable: "OeNumberGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_ProductGroups_ProductGroupId",
                        column: x => x.ProductGroupId,
                        principalTable: "ProductGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Warranties_WarrantyId",
                        column: x => x.WarrantyId,
                        principalTable: "Warranties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandDescription", "BrandName", "CreateDate", "IsActive", "LogoPath", "TecDoc", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "", "SPIDAN", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9520), true, null, 1, null },
                    { 2, "", "HELLA", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9582), true, null, 2, null },
                    { 3, "", "ATE", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9587), true, null, 3, null },
                    { 4, "", "MANN-FILTER", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9590), true, null, 4, null },
                    { 5, "", "PIERBURG", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9594), true, null, 5, null },
                    { 6, "", "LuK", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9597), true, null, 6, null },
                    { 7, "", "EBERSPÄCHER", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9601), true, null, 7, null },
                    { 8, "", "VICTOR REINZ", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9605), true, null, 9, null },
                    { 9, "", "ELRING", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9608), true, null, 10, null },
                    { 10, "", "BorgWarner (BERU)", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9612), true, null, 11, null },
                    { 11, "", "WALKER", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9615), true, null, 13, null },
                    { 12, "", "NGK", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9619), true, null, 15, null },
                    { 13, "", "BILSTEIN", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9622), true, null, 16, null },
                    { 14, "", "KONI", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9626), true, null, 18, null },
                    { 15, "", "SWF", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9629), true, null, 19, null },
                    { 16, "", "VALEO", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9633), true, null, 21, null },
                    { 17, "", "RUVILLE", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9637), true, null, 23, null },
                    { 18, "", "EXIDE", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9640), true, null, 24, null },
                    { 19, "", "VARTA", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9644), true, null, 26, null },
                    { 20, "", "ERNST", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9647), true, null, 29, null },
                    { 21, "", "BOSCH", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9651), true, null, 30, null },
                    { 22, "", "CONTINENTAL CTAM", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9655), true, null, 31, null },
                    { 23, "", "SACHS", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9659), true, null, 32, null },
                    { 24, "", "GATES", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9662), true, null, 33, null },
                    { 25, "", "KNECHT", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9666), true, null, 34, null },
                    { 26, "", "LEMFÖRDER", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9719), true, null, 35, null },
                    { 27, "", "VAN WEZEL", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9724), true, null, 36, null },
                    { 28, "", "MONROE", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9728), true, null, 37, null },
                    { 29, "", "PURFLUX", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9731), true, null, 38, null },
                    { 30, "", "TEXTAR", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9735), true, null, 39, null },
                    { 31, "", "BOSAL", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9738), true, null, 41, null },
                    { 32, "", "DAYCO", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9742), true, null, 42, null },
                    { 33, "", "CHAMPION", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9745), true, null, 43, null },
                    { 34, "", "BREMI", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9749), true, null, 47, null },
                    { 35, "", "JURID", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9752), true, null, 48, null },
                    { 36, "", "SKF", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9756), true, null, 50, null },
                    { 37, "", "WESTFALIA", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9759), true, null, 51, null },
                    { 38, "", "FTE", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9762), true, null, 54, null },
                    { 39, "", "HERTH+BUSS JAKOPARTS", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9766), true, null, 55, null },
                    { 40, "", "LÖBRO", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9771), true, null, 56, null },
                    { 41, "", "QUINTON HAZELL", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9775), true, null, 57, null },
                    { 42, "", "TYC", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9779), true, null, 61, null },
                    { 43, "", "BREMBO", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9782), true, null, 65, null },
                    { 44, "", "DENSO", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9786), true, null, 66, null },
                    { 45, "", "ams-OSRAM", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9789), true, null, 67, null },
                    { 46, "", "ZF", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9793), true, null, 68, null },
                    { 47, "", "HERTH+BUSS ELPARTS", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9796), true, null, 72, null },
                    { 48, "", "PHILIPS", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9800), true, null, 75, null },
                    { 49, "", "KLOKKERHOLM", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9803), true, null, 78, null },
                    { 50, "", "BorgWarner (Wahler)", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9806), true, null, 79, null },
                    { 51, "", "HENGST FILTER", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9810), true, null, 81, null },
                    { 52, "", "CONTINENTAL/VDO", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9813), true, null, 83, null },
                    { 53, "", "KYB", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9817), true, null, 85, null },
                    { 54, "", "ZIMMERMANN", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9820), true, null, 86, null },
                    { 55, "", "GLASER", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9824), true, null, 88, null },
                    { 56, "", "DELPHI", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9828), true, null, 89, null },
                    { 57, "", "METZGER", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9832), true, null, 94, null },
                    { 58, "", "MAGNETI MARELLI", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9836), true, null, 95, null },
                    { 59, "", "WAECO", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9840), true, null, 97, null },
                    { 60, "", "FEBI BILSTEIN", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9844), true, null, 101, null },
                    { 61, "", "BRINK", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9848), true, null, 106, null },
                    { 62, "", "BUGATTI", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9851), true, null, 109, null },
                    { 63, "", "SNR", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9854), true, null, 110, null },
                    { 64, "", "EIBACH", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9858), true, null, 112, null },
                    { 65, "", "PAYEN", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9861), true, null, 113, null },
                    { 66, "", "BUDWEG CALIPER", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9865), true, null, 114, null },
                    { 67, "", "ULO", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9868), true, null, 115, null },
                    { 68, "", "LRT", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9872), true, null, 117, null },
                    { 69, "", "HJS", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9875), true, null, 118, null },
                    { 70, "", "METELLI", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9879), true, null, 121, null },
                    { 71, "", "NISSENS", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9883), true, null, 123, null },
                    { 72, "", "STABILUS", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9888), true, null, 126, null },
                    { 73, "", "NK", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9892), true, null, 127, null },
                    { 74, "", "OPTIMAL", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9897), true, null, 129, null },
                    { 75, "", "SIDEM", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9900), true, null, 135, null },
                    { 76, "", "UFI", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9903), true, null, 137, null },
                    { 77, "", "JOHNS", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9907), true, null, 138, null },
                    { 78, "", "AJUSA", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9911), true, null, 139, null },
                    { 79, "", "CORTECO", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9914), true, null, 140, null },
                    { 80, "", "AE", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9918), true, null, 141, null },
                    { 81, "", "SOFIMA", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9921), true, null, 142, null },
                    { 82, "", "MEYLE", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9925), true, null, 144, null },
                    { 83, "", "SWAG", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9928), true, null, 151, null },
                    { 84, "", "DOLZ", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9932), true, null, 154, null },
                    { 85, "", "JAPANPARTS", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9935), true, null, 156, null },
                    { 86, "", "ICER", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9939), true, null, 158, null },
                    { 87, "", "FACET", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9942), true, null, 159, null },
                    { 88, "", "TRW", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9946), true, null, 161, null },
                    { 89, "", "VAICO", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9949), true, null, 162, null },
                    { 90, "", "AISIN", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9953), true, null, 166, null },
                    { 91, "", "DUPLI COLOR", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9956), true, null, 167, null },
                    { 92, "", "MOTIP", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9960), true, null, 168, null },
                    { 93, "", "PRESTO", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9963), true, null, 169, null },
                    { 94, "", "LESJÖFORS", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9967), true, null, 175, null },
                    { 95, "", "BTS Turbo", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9971), true, null, 177, null },
                    { 96, "", "HEPU", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9975), true, null, 178, null },
                    { 97, "", "ALCO FILTER", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9978), true, null, 180, null },
                    { 98, "", "GK", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9982), true, null, 181, null },
                    { 99, "", "SCHLÜTTER TURBOLADER", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9985), true, null, 182, null },
                    { 100, "", "VEMO", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9989), true, null, 183, null },
                    { 101, "", "KAMOKA", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9992), true, null, 185, null },
                    { 102, "", "IMASAF", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9996), true, null, 191, null },
                    { 103, "", "FAG", new DateTime(2023, 12, 22, 14, 54, 20, 708, DateTimeKind.Local).AddTicks(9999), true, null, 192, null },
                    { 104, "", "LPR", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(3), true, null, 197, null },
                    { 105, "", "OCAP", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6), true, null, 198, null },
                    { 106, "", "GLYCO", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(10), true, null, 202, null },
                    { 107, "", "INA", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(13), true, null, 204, null },
                    { 108, "", "NRF", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(17), true, null, 205, null },
                    { 109, "", "A.B.S.", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(157), true, null, 206, null },
                    { 110, "", "CASTROL", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(162), true, null, 207, null },
                    { 111, "", "TRUCKTEC AUTOMOTIVE", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(166), true, null, 209, null },
                    { 112, "", "REMY", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(169), true, null, 214, null },
                    { 113, "", "CALORSTAT by Vernet", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(174), true, null, 215, null },
                    { 114, "", "NÜRAL", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(177), true, null, 216, null },
                    { 115, "", "AIRTEX", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(181), true, null, 220, null },
                    { 116, "", "LIQUI MOLY", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(184), true, null, 222, null },
                    { 117, "", "SCT - MANNOL", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(188), true, null, 225, null },
                    { 118, "", "ELSTOCK", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(191), true, null, 226, null },
                    { 119, "", "DINEX", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(195), true, null, 233, null },
                    { 120, "", "ERA", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(199), true, null, 234, null },
                    { 121, "", "FRECCIA", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(202), true, null, 235, null },
                    { 122, "", "FAE", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(206), true, null, 240, null },
                    { 123, "", "MEAT & DORIA", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(209), true, null, 244, null },
                    { 124, "", "AVA QUALITY COOLING", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(213), true, null, 247, null },
                    { 125, "", "NIPPARTS", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(216), true, null, 248, null },
                    { 126, "", "FILTRON", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(220), true, null, 256, null },
                    { 127, "", "ASHIKA", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(223), true, null, 257, null },
                    { 128, "", "SASIC", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(226), true, null, 260, null },
                    { 129, "", "FAI AutoParts", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(230), true, null, 267, null },
                    { 130, "", "JP GROUP", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(234), true, null, 268, null },
                    { 131, "", "AMC", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(238), true, null, 277, null },
                    { 132, "", "MAHLE", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(242), true, null, 287, null },
                    { 133, "", "SACHS PERFORMANCE", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(246), true, null, 294, null },
                    { 134, "", "fri.tech.", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(250), true, null, 295, null },
                    { 135, "", "sbs", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(253), true, null, 297, null },
                    { 136, "", "WEBASTO", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(257), true, null, 299, null },
                    { 137, "", "AUTEX", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(260), true, null, 300, null },
                    { 138, "", "TOPRAN", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(264), true, null, 301, null },
                    { 139, "", "K&N Filters", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(267), true, null, 305, null },
                    { 140, "", "GRAF", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(270), true, null, 310, null },
                    { 141, "", "CIFAM", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(274), true, null, 311, null },
                    { 142, "", "GENERAL RICAMBI", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(277), true, null, 316, null },
                    { 143, "", "AUTOMEGA", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(281), true, null, 323, null },
                    { 144, "", "WIX FILTERS", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(284), true, null, 324, null },
                    { 145, "", "BorgWarner (Schwitze", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(287), true, null, 326, null },
                    { 146, "", "BorgWarner", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(292), true, null, 327, null },
                    { 147, "", "BorgWarner (3K)", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(296), true, null, 328, null },
                    { 148, "", "ORIGINAL IMPERIUM", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(300), true, null, 331, null },
                    { 149, "", "PRASCO", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(304), true, null, 340, null },
                    { 150, "", "TRW Engine Component", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(307), true, null, 347, null },
                    { 151, "", "BLUE PRINT", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(311), true, null, 350, null },
                    { 152, "", "AUTOFREN SEINSA", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(314), true, null, 351, null },
                    { 153, "", "TESLA", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(318), true, null, 356, null },
                    { 154, "", "ALKAR", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(322), true, null, 362, null },
                    { 155, "", "FA1", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(326), true, null, 367, null },
                    { 156, "", "GSP", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(329), true, null, 373, null },
                    { 157, "", "CENTRA", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(333), true, null, 376, null },
                    { 158, "", "BOSCH DIAGNOSTICS", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(336), true, null, 377, null },
                    { 159, "", "FRENKIT", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(339), true, null, 380, null },
                    { 160, "", "GOETZE ENGINE", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(343), true, null, 385, null },
                    { 161, "", "MOTORAD", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(346), true, null, 388, null },
                    { 162, "", "GLYSANTIN", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(349), true, null, 389, null },
                    { 163, "", "EAI", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(353), true, null, 391, null },
                    { 164, "", "BARUM", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(356), true, null, 394, null },
                    { 165, "", "JANMOR", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(360), true, null, 397, null },
                    { 166, "", "EXEDY", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(363), true, null, 399, null },
                    { 167, "", "RAICAM", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(368), true, null, 400, null },
                    { 168, "", "MAXGEAR", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(373), true, null, 403, null },
                    { 169, "", "BM CATALYSTS", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(376), true, null, 406, null },
                    { 170, "", "FREMAX", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(379), true, null, 409, null },
                    { 171, "", "ASMET", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(383), true, null, 427, null },
                    { 172, "", "RTS", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(387), true, null, 430, null },
                    { 173, "", "KOLBENSCHMIDT", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(391), true, null, 432, null },
                    { 174, "", "STATIM", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(394), true, null, 433, null },
                    { 175, "", "MOTUL", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(398), true, null, 436, null },
                    { 176, "", "CoopersFiaam", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(403), true, null, 437, null },
                    { 177, "", "ENERGIZER", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(406), true, null, 443, null },
                    { 178, "", "PILKINGTON", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(410), true, null, 447, null },
                    { 179, "", "HITACHI", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(414), true, null, 449, null },
                    { 180, "", "BANDO", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(417), true, null, 454, null },
                    { 181, "", "DRI", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(421), true, null, 460, null },
                    { 182, "", "RAVENOL", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(424), true, null, 461, null },
                    { 183, "", "OSVAT", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(428), true, null, 464, null },
                    { 184, "", "CS Germany", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(432), true, null, 467, null },
                    { 185, "", "BORG & BECK", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(435), true, null, 475, null },
                    { 186, "", "ClimAir", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(439), true, null, 483, null },
                    { 187, "", "NARVA", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(442), true, null, 485, null },
                    { 188, "", "BRISK", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(445), true, null, 494, null },
                    { 189, "", "ZAFFO", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(449), true, null, 499, null },
                    { 190, "", "EPS", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(452), true, null, 4005, null },
                    { 191, "", "KW", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(455), true, null, 4006, null },
                    { 192, "", "KS TOOLS", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(459), true, null, 4023, null },
                    { 193, "", "VIGOR", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(462), true, null, 4026, null },
                    { 194, "", "SHELL", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(560), true, null, 4314, null },
                    { 195, "", "Prestone", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(565), true, null, 4333, null },
                    { 196, "", "ELTA AUTOMOTIVE", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(569), true, null, 4344, null },
                    { 197, "", "vika", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(573), true, null, 4346, null },
                    { 198, "", "DPA", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(576), true, null, 4353, null },
                    { 199, "", "STOP&GO", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(580), true, null, 4367, null },
                    { 200, "", "PETEC", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(583), true, null, 4372, null },
                    { 201, "", "Airstal", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(587), true, null, 4381, null },
                    { 202, "", "CONTINENTAL", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(591), true, null, 4434, null },
                    { 203, "", "DUNLOP", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(594), true, null, 4436, null },
                    { 204, "", "MOBIL", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(598), true, null, 4449, null },
                    { 205, "", "YUASA", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(601), true, null, 4451, null },
                    { 206, "", "GS", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(605), true, null, 4452, null },
                    { 207, "", "SONAX", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(608), true, null, 4457, null },
                    { 208, "", "ERT", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(611), true, null, 4512, null },
                    { 209, "", "ET ENGINETEAM", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(615), true, null, 4514, null },
                    { 210, "", "LINEX", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(618), true, null, 4536, null },
                    { 211, "", "Arnott", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(622), true, null, 4539, null },
                    { 212, "", "TEDGUM", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(626), true, null, 4593, null },
                    { 213, "", "GE", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(629), true, null, 4612, null },
                    { 214, "", "GARRETT", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(633), true, null, 4615, null },
                    { 215, "", "ABAKUS", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(636), true, null, 4657, null },
                    { 216, "", "ROTINGER", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(640), true, null, 4676, null },
                    { 217, "", "CAFFARO", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(643), true, null, 4679, null },
                    { 218, "", "MOBILETRON", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(647), true, null, 4705, null },
                    { 219, "", "NE", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(651), true, null, 4717, null },
                    { 220, "", "LIFT-TEK", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(655), true, null, 4719, null },
                    { 221, "", "MIRAGLIO", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(659), true, null, 4721, null },
                    { 222, "", "HELLA GUTMANN", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(662), true, null, 4734, null },
                    { 223, "", "HAZET", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(666), true, null, 4808, null },
                    { 224, "", "Borsehung", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(669), true, null, 4815, null },
                    { 225, "", "QUARO", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(673), true, null, 4821, null },
                    { 226, "", "AS-PL", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(676), true, null, 4843, null },
                    { 227, "", "Ac Rolcar", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(680), true, null, 4849, null },
                    { 228, "", "ARAL", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(683), true, null, 4866, null },
                    { 229, "", "COFLE", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(687), true, null, 4871, null },
                    { 230, "", "POLMO", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(690), true, null, 4873, null },
                    { 231, "", "DYNAMAX", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(693), true, null, 4881, null },
                    { 232, "", "ALLIGATOR", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(697), true, null, 4911, null },
                    { 233, "", "GEDORE", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(700), true, null, 4912, null },
                    { 234, "", "NORMA", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(704), true, null, 4923, null },
                    { 235, "", "SCHRADER", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(708), true, null, 4946, null },
                    { 236, "", "TURBORAIL", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(711), true, null, 4949, null },
                    { 237, "", "ESEN SKV", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(715), true, null, 4969, null },
                    { 238, "", "HART", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(719), true, null, 5251, null },
                    { 239, "", "ACPS-ORIS", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(723), true, null, 6102, null },
                    { 240, "", "VALVOLINE", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(726), true, null, 6186, null },
                    { 241, "", "CPB", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(730), true, null, 6263, null },
                    { 242, "", "QUICK BRAKE", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(733), true, null, 6304, null },
                    { 243, "", "GKN", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(737), true, null, 6306, null },
                    { 244, "", "REPSOL", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(740), true, null, 6343, null },
                    { 245, "", "EBC Brakes", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(743), true, null, 6368, null },
                    { 246, "", "BERU by DRiV", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(747), true, null, 6441, null },
                    { 247, "", "BorgWarner (AWD)", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(750), true, null, 6444, null },
                    { 248, "", "Dr.Motor Automotive", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(754), true, null, 6534, null },
                    { 249, "", "AIC", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(758), true, null, 6558, null },
                    { 250, "", "Oyodo", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(761), true, null, 6984, null },
                    { 251, "", "JPN", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(764), true, null, 6985, null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CreateDate", "CurrencyCode", "CurrencyName", "IsActive", "NumericCurrencyCode", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(925), "CZK", "Česká koruna", true, 203, null },
                    { 2, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(952), "EUR", "Euro", true, 978, null },
                    { 3, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(956), "PLN", "Złoty", true, 985, null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CreateDate", "CurrencyCode", "CurrencyName", "NumericCurrencyCode", "UpdateDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(959), "ALL", "Albánský lek", 8, null },
                    { 5, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(963), "AMD", "Arménský dram", 51, null },
                    { 6, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(966), "HRK", "Kuna", 191, null },
                    { 7, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(969), "DKK", "Dánská koruna", 208, null },
                    { 8, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(973), "HUF", "Forint", 348, null },
                    { 9, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(976), "ISK", "Islandská koruna", 352, null },
                    { 10, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(980), "KZT", "Tenge", 398, null },
                    { 11, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(983), "MDL", "Moldavské leu", 498, null },
                    { 12, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(986), "NOK", "Norská koruna", 578, null },
                    { 13, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(990), "RUB", "Ruský rubl", 643, null },
                    { 14, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(993), "SEK", "Švédská koruna", 752, null },
                    { 15, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(997), "CHF", "Švýcarský frank", 756, null },
                    { 16, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(1000), "MKD", "Denár", 807, null },
                    { 17, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(1004), "GBP", "Libra šterlinků", 826, null },
                    { 18, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(1008), "RSD", "Srbský dinár", 941, null },
                    { 19, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(1011), "AZN", "Ázerbájdžánský manat", 944, null },
                    { 20, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(1015), "RON", "Rumunské leu", 946, null },
                    { 21, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(1018), "CHE", "WIR Euro", 947, null },
                    { 22, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(1022), "CHW", "WIR Frank", 948, null },
                    { 23, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(1025), "TRY", "Turecká lira", 949, null },
                    { 24, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(1029), "BYR", "Běloruský rubl", 974, null },
                    { 25, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(1033), "BGN", "Bulharská leva", 975, null },
                    { 26, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(1036), "BAM", "Konvertibilní marka", 977, null },
                    { 27, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(1039), "UAH", "Ukrajinská hřivna", 980, null },
                    { 28, new DateTime(2023, 12, 22, 14, 54, 20, 710, DateTimeKind.Local).AddTicks(1043), "GEL", "Lari", 981, null }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "LogoPath", "ManufacturerDescription", "ManufacturerName", "TecDoc", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 22, 14, 54, 20, 711, DateTimeKind.Local).AddTicks(5622), true, true, null, null, "AUDI", 3854, null },
                    { 2, new DateTime(2023, 12, 22, 14, 54, 20, 711, DateTimeKind.Local).AddTicks(5690), true, true, null, null, "MAN", 1480, null },
                    { 3, new DateTime(2023, 12, 22, 14, 54, 20, 711, DateTimeKind.Local).AddTicks(5711), true, true, null, null, "SEAT", 2, null },
                    { 4, new DateTime(2023, 12, 22, 14, 54, 20, 711, DateTimeKind.Local).AddTicks(5730), true, true, null, null, "ŠKODA", 1360, null },
                    { 5, new DateTime(2023, 12, 22, 14, 54, 20, 711, DateTimeKind.Local).AddTicks(5750), true, true, null, null, "VOLKSWAGEN", 881, null }
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "CreateDate", "IsActive", "ProductGroupName", "TecDoc", "UpdateDate" },
                values: new object[] { 1, new DateTime(2023, 12, 22, 14, 54, 20, 723, DateTimeKind.Local).AddTicks(211), true, "Olejový filtr", 4, null });

            migrationBuilder.InsertData(
                table: "Warranties",
                columns: new[] { "Id", "CreateDate", "IsActive", "UpdateDate", "WarrantyPeriod" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 22, 14, 54, 20, 723, DateTimeKind.Local).AddTicks(3778), true, null, "6 měsíců" },
                    { 2, new DateTime(2023, 12, 22, 14, 54, 20, 723, DateTimeKind.Local).AddTicks(3808), true, null, "12 měsíců" },
                    { 3, new DateTime(2023, 12, 22, 14, 54, 20, 723, DateTimeKind.Local).AddTicks(3812), true, null, "24 měsíců" },
                    { 4, new DateTime(2023, 12, 22, 14, 54, 20, 723, DateTimeKind.Local).AddTicks(3815), true, null, "36 měsíců" }
                });

            migrationBuilder.InsertData(
                table: "Warranties",
                columns: new[] { "Id", "CreateDate", "UpdateDate", "WarrantyPeriod" },
                values: new object[,]
                {
                    { 5, new DateTime(2023, 12, 22, 14, 54, 20, 723, DateTimeKind.Local).AddTicks(3818), null, "48 měsíců" },
                    { 6, new DateTime(2023, 12, 22, 14, 54, 20, 723, DateTimeKind.Local).AddTicks(3821), null, "60 měsíců" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryNameCZ", "CountryNameENG", "CreateDate", "CurrencyId", "ISOAlpha2", "ISOAlpha3", "IsActive", "NumericCountryCode", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Česká republika", "Czech Republic", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6498), 1, "CZ", "CZE", true, 203, null },
                    { 2, "Slovenská republika", "Slovakia", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6532), 2, "SK", "SVK", true, 703, null },
                    { 3, "Polsko", "Poland", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6537), 3, "PL", "POL", true, 616, null },
                    { 4, "Německo", "Germany", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6542), 2, "DE", "DEU", true, 276, null },
                    { 5, "Rakousko", "Austria", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6546), 2, "AT", "AUT", true, 40, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryNameCZ", "CountryNameENG", "CreateDate", "CurrencyId", "ISOAlpha2", "ISOAlpha3", "NumericCountryCode", "UpdateDate" },
                values: new object[,]
                {
                    { 6, "Albánie", "Albania", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6550), 4, "AL", "ALB", 8, null },
                    { 7, "Andorra", "Andorra", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6554), 2, "AD", "AND", 20, null },
                    { 8, "Arménie", "Armenia", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6559), 5, "AM", "ARM", 51, null },
                    { 9, "Ázerbájdžán", "Azerbaijan", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6563), 19, "AZ", "AZE", 31, null },
                    { 10, "Belgie", "Belgium", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6566), 2, "BE", "BEL", 56, null },
                    { 11, "Bělorusko", "Belarus", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6570), 24, "BY", "BLR", 112, null },
                    { 12, "Bosna a Hercegovina", "Bosnia and Herzegovina", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6574), 26, "BA", "BIH", 70, null },
                    { 13, "Bulharsko", "Bulgaria", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6578), 25, "BG", "BGR", 100, null },
                    { 14, "Černá Hora", "Montenegro", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6582), 2, "ME", "MNE", 499, null },
                    { 15, "Dánsko", "Denmark", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6586), 7, "DK", "DNK", 208, null },
                    { 16, "Estonsko", "Estonia", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6590), 2, "EE", "EST", 233, null },
                    { 17, "Finsko", "Finland", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6594), 2, "FI", "FIN", 246, null },
                    { 18, "Francie", "France", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6598), 2, "FR", "FRA", 250, null },
                    { 19, "Gruzie", "Georgia", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6602), 28, "GE", "GEO", 268, null },
                    { 20, "Chorvatsko", "Croatia", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6606), 6, "HR", "HRV", 191, null },
                    { 21, "Irsko", "Ireland", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6609), 2, "IE", "IRL", 372, null },
                    { 22, "Island", "Iceland", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6613), 9, "IS", "ISL", 352, null },
                    { 23, "Itálie", "Italy", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6618), 2, "IT", "ITA", 380, null },
                    { 24, "Kazachstán", "Kazakhstan", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6622), 10, "KZ", "KAZ", 398, null },
                    { 25, "Kypr (Kyperská republika)", "Cyprus", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6626), 2, "CY", "CYP", 196, null },
                    { 26, "Lichtenštejnsko (Lichtenštejnské knížectví)", "Liechtenstein", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6630), 15, "LI", "LIE", 438, null },
                    { 27, "Litva (Litevská republika)", "Lithuania", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6709), 2, "LT", "LTU", 440, null },
                    { 28, "Lotyšsko (Lotyšská republika)", "Latvia", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6715), 2, "LV", "LVA", 428, null },
                    { 29, "Lucembursko", "Luxembourg", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6719), 2, "LU", "LUX", 442, null },
                    { 30, "Maďarsko", "Hungary", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6722), 8, "HU", "HUN", 348, null },
                    { 31, "Malta", "Malta", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6726), 2, "MT", "MLT", 470, null },
                    { 32, "Moldavsko (Moldavská republika)", "Moldova", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6730), 11, "MD", "MDA", 498, null },
                    { 33, "Monako", "Monaco", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6734), 2, "MC", "MCO", 492, null },
                    { 34, "Nizozemsko", "Netherlands", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6738), 2, "NL", "NLD", 528, null },
                    { 35, "Norsko", "Norway", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6742), 12, "NO", "NOR", 578, null },
                    { 36, "Portugalsko", "Portugal", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6746), 2, "PT", "PRT", 620, null },
                    { 37, "Rumunsko", "Romania", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6750), 20, "RO", "ROU", 642, null },
                    { 38, "Rusko", "Russian Federation", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6754), 13, "RU", "RUS", 643, null },
                    { 39, "Řecko", "Greece", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6758), 2, "GR", "GRC", 300, null },
                    { 40, "San Marino", "San Marino", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6762), 2, "SM", "SMR", 674, null },
                    { 41, "Severní Makedonie (Republika Severní Makedonie)", "Macedonia, Republic of", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6766), 16, "MK", "MKD", 807, null },
                    { 42, "Slovinsko", "Slovenia", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6770), 2, "SI", "SVN", 705, null },
                    { 43, "Srbsko", "Serbia", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6774), 18, "RS", "SRB", 688, null },
                    { 44, "Španělsko", "Spain", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6778), 2, "ES", "ESP", 724, null },
                    { 45, "Švédsko", "Sweden", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6782), 14, "SE", "SWE", 752, null },
                    { 46, "Švýcarsko", "Switzerland", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6786), 21, "CH", "CHE", 756, null },
                    { 47, "Švýcarsko", "Switzerland", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6789), 15, "CH", "CHE", 756, null },
                    { 48, "Švýcarsko", "Switzerland", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6793), 22, "CH", "CHE", 756, null },
                    { 49, "Turecko", "Turkey", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6797), 23, "TR", "TUR", 792, null },
                    { 50, "Ukrajina", "Ukraine", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6801), 27, "UA", "UKR", 804, null },
                    { 51, "Vatikán (Městský stát Vatikán)", "Holy See (Vatican City State)", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6805), 2, "VA", "VAT", 336, null },
                    { 52, "Velká Británie (Spojené království)", "United Kingdom", new DateTime(2023, 12, 22, 14, 54, 20, 709, DateTimeKind.Local).AddTicks(6808), 17, "GB", "GBR", 826, null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6221), true, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "100 C1 kupé (817)", null },
                    { 2, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6285), true, new DateTime(1968, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "100 C1 limuzína (801, 803, 805, 807, 811, 813, F104)", null },
                    { 3, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6296), true, new DateTime(1977, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "100 C2 kombi (435, 436)", null },
                    { 4, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6303), true, new DateTime(1976, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "100 C2 limuzína (431, 433, 434)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 5, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6310), true, true, new DateTime(1982, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "100 C3 kombi (445, 446)", null },
                    { 6, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6317), true, true, new DateTime(1982, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "100 C3 limuzína (443, 444)", null },
                    { 7, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6323), true, true, new DateTime(1990, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "100 C4 kombi (4A5)", null },
                    { 8, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6330), true, true, new DateTime(1990, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "100 C4 limuzína (4A2)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[] { 9, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6336), true, new DateTime(1979, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "200 C2 limuzína (437, 438)", null });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 10, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6342), true, true, new DateTime(1983, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "200 C3 kombi (447, 448)", null },
                    { 11, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6349), true, true, new DateTime(1983, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "200 C3 limuzína (447, 448)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 12, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6355), true, new DateTime(1974, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "50 (863)", null },
                    { 13, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6362), true, new DateTime(1968, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "60 (613, 615)", null },
                    { 14, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6368), true, new DateTime(1968, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "60 kombi (613, 615)", null },
                    { 15, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6375), true, new DateTime(1968, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "75 (613, 615)", null },
                    { 16, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6381), true, new DateTime(1968, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "75 kombi (615)", null },
                    { 17, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6390), true, new DateTime(1966, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "80 (613)", null },
                    { 18, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6396), true, new DateTime(1972, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "80 B1 limuzína (80, 82)", null },
                    { 19, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6404), true, new DateTime(1978, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "80 B2 limuzína (811, 813, 814, 819, 853)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 20, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6410), true, true, new DateTime(1986, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "80 B3 limuzína (893, 894, 8A2)", null },
                    { 21, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6416), true, true, new DateTime(1991, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "80 B4 kombi (8C5)", null },
                    { 22, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6423), true, true, new DateTime(1991, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "80 B4 limuzína (8C2)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 23, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6429), true, new DateTime(1966, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "80 kombi (613)", null },
                    { 24, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6435), true, new DateTime(1984, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "90 B2 (813, 814, 853)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 25, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6442), true, true, new DateTime(1987, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "90 B3 (893, 894, 8A2)", null },
                    { 26, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6449), true, true, new DateTime(2010, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A1 (8X1, 8XK)", null },
                    { 27, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6456), true, true, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "A1 Allstreet (GBH)", null },
                    { 28, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6462), true, true, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "A1 City Carver (GBH)", null },
                    { 29, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6468), true, true, new DateTime(2011, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A1 Sportback (8XA, 8XF)", null },
                    { 30, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6474), true, true, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "A1 Sportback (GBA)", null },
                    { 31, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6480), true, true, new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A2 (8Z0)", null },
                    { 32, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6486), true, true, new DateTime(1996, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A3 (8L1)", null },
                    { 33, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6493), true, true, new DateTime(2003, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A3 (8P1)", null },
                    { 34, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6499), true, true, new DateTime(2012, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A3 (8V1, 8VK)", null },
                    { 35, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6505), true, true, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "A3 AllStreet (8YH)", null },
                    { 36, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6512), true, true, new DateTime(2008, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A3 kabrio (8P7)", null },
                    { 37, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6518), true, true, new DateTime(2013, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "A3 kabrio (8V7, 8VE)", null },
                    { 38, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6525), true, true, new DateTime(2013, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A3 limuzína (8VS, 8VM)", null },
                    { 39, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6531), true, true, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "A3 limuzína (8YS)", null },
                    { 40, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6539), true, true, new DateTime(2004, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A3 Sportback (8PA)", null },
                    { 41, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6545), true, true, new DateTime(2012, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A3 Sportback (8VA, 8VF)", null },
                    { 42, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6551), true, true, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "A3 Sportback (8YA)", null },
                    { 43, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6558), true, true, new DateTime(1994, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A4 B5 (8D2)", null },
                    { 44, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6565), true, true, new DateTime(1994, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A4 B5 kombi (8D5)", null },
                    { 45, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6571), true, true, new DateTime(2000, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A4 B6 (8E2)", null },
                    { 46, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6578), true, true, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A4 B6 kabrio (8H7)", null },
                    { 47, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6584), true, true, new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A4 B6 kombi (8E5)", null },
                    { 48, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6590), true, true, new DateTime(2004, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A4 B7 (8EC)", null },
                    { 49, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6597), true, true, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A4 B7 kabrio (8HE)", null },
                    { 50, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6603), true, true, new DateTime(2004, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A4 B7 kombi (8ED)", null },
                    { 51, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6611), true, true, new DateTime(2007, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A4 B8 (8K2)", null },
                    { 52, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6617), true, true, new DateTime(2009, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A4 B8 Allroad (8KH)", null },
                    { 53, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6738), true, true, new DateTime(2007, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A4 B8 kombi (8K5)", null },
                    { 54, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6748), true, true, new DateTime(2015, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "A4 B9 (8W2, 8WC)", null },
                    { 55, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6755), true, true, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "A4 B9 Allroad (8WH, 8WJ)", null },
                    { 56, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6761), true, true, new DateTime(2015, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "A4 B9 kombi (8W5)", null },
                    { 57, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6767), true, true, new DateTime(2007, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A5 (8T3)", null },
                    { 58, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6773), true, true, new DateTime(2016, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "A5 (F53, F5P)", null },
                    { 59, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6780), true, true, new DateTime(2009, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A5 kabrio (8F7)", null },
                    { 60, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6787), true, true, new DateTime(2016, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "A5 kabrio (F57)", null },
                    { 61, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6793), true, true, new DateTime(2007, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A5 Sportback (8TA)", null },
                    { 62, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6799), true, true, new DateTime(2016, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "A5 Sportback (F5A, F5F)", null },
                    { 63, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6805), true, true, new DateTime(1994, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A6 C4 (4A2)", null },
                    { 64, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6811), true, true, new DateTime(1994, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A6 C4 kombi (4A5)", null },
                    { 65, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6818), true, true, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A6 C5 (4B2)", null },
                    { 66, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6824), true, true, new DateTime(1997, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A6 C5 kombi (4B5)", null },
                    { 67, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6831), true, true, new DateTime(2004, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A6 C6 (4F2)", null },
                    { 68, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6837), true, true, new DateTime(2006, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A6 C6 Allroad (4FH)", null },
                    { 69, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6843), true, true, new DateTime(2004, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A6 C6 kombi (4F5)", null },
                    { 70, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6850), true, true, new DateTime(2010, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A6 C7 (4G2, 4GC)", null },
                    { 71, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6856), true, true, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A6 C7 Allroad (4GH, 4GJ)", null },
                    { 72, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6862), true, true, new DateTime(2011, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A6 C7 kombi (4G5, 4GD)", null },
                    { 73, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6868), true, true, new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "A6 C8 (4A2)", null },
                    { 74, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6874), true, true, new DateTime(2018, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "A6 C8 Allroad (4AH)", null },
                    { 75, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6880), true, true, new DateTime(2018, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "A6 C8 kombi (4A5)", null },
                    { 76, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6886), true, true, new DateTime(2010, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A7 Sportback (4GA, 4GF)", null },
                    { 77, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6893), true, true, new DateTime(2017, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "A7 Sportback (4KA)", null },
                    { 78, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6898), true, true, new DateTime(1994, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A8 D2 (4D2, 4D8)", null },
                    { 79, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6904), true, true, new DateTime(2002, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A8 D3 (4E2, 4E8)", null },
                    { 80, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6911), true, true, new DateTime(2009, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A8 D4 (4H2, 4H8, 4HC, 4HL)", null },
                    { 81, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6917), true, true, new DateTime(2017, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "A8 D5 (4N2, 4N8, 4NC, 4NL)", null },
                    { 82, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6923), true, true, new DateTime(2000, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "ALLROAD C5 (4BH)", null },
                    { 83, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6930), true, true, new DateTime(1991, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "CABRIOLET B3 (8G7)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[] { 84, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6936), true, new DateTime(1980, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "COUPE B2 (81, 855, 856)", null });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 85, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6943), true, true, new DateTime(1988, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "COUPE B3 (89, 8B3)", null },
                    { 86, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6949), true, true, new DateTime(2018, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "E-TRON (GEN)", null },
                    { 87, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6955), true, true, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "E-TRON GT (F83)", null },
                    { 88, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6962), true, true, new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "E-TRON Sportback (GEA)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 89, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6968), true, new DateTime(1965, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "F103 (613, 615)", null },
                    { 90, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6975), true, new DateTime(1966, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "F103 kombi (613, 615)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 91, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6981), true, true, new DateTime(2016, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Q2 (GAB, GAG)", null },
                    { 92, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6988), true, true, new DateTime(2011, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Q3 (8UB, 8UG)", null },
                    { 93, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(6995), true, true, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Q3 (F3B)", null },
                    { 94, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7001), true, true, new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Q3 Sportback (F3N)", null },
                    { 95, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7007), true, true, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Q4 Sportback (F4N)", null },
                    { 96, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7013), true, true, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Q4 SUV (F4B)", null },
                    { 97, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7019), true, true, new DateTime(2008, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Q5 (8RB)", null },
                    { 98, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7026), true, true, new DateTime(2016, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Q5 (FYB, FYG)", null },
                    { 99, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7032), true, true, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Q5 Sportback (FYT)", null },
                    { 100, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7039), true, true, new DateTime(2006, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Q7 (4LB)", null },
                    { 101, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7046), true, true, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Q7 (4MB, 4MG)", null },
                    { 102, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7052), true, true, new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Q8 (4MN)", null },
                    { 103, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7058), true, true, new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Q8 E-TRON Sportback (GET)", null },
                    { 104, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7064), true, true, new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Q8 E-TRON SUV (GEG)", null },
                    { 105, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7070), true, true, new DateTime(1980, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "QUATTRO (85)", null },
                    { 106, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7077), true, true, new DateTime(2007, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "R8 (422, 423)", null },
                    { 107, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7083), true, true, new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "R8 (4S3, 4SP)", null },
                    { 108, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7089), true, true, new DateTime(2010, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "R8 Spyder (427, 429)", null },
                    { 109, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7096), true, true, new DateTime(2016, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "R8 Spyder (4S9, 4SR)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[] { 110, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7102), true, new DateTime(1966, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "SUPER 90", null });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 111, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7109), true, true, new DateTime(2006, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "TT (8J3)", null },
                    { 112, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7115), true, true, new DateTime(1998, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "TT (8N3)", null },
                    { 113, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7121), true, true, new DateTime(2014, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "TT (FV3, FVP)", null },
                    { 114, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7127), true, true, new DateTime(2007, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "TT Roadster (8J9)", null },
                    { 115, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7134), true, true, new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "TT Roadster (8N9)", null },
                    { 116, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7142), true, true, new DateTime(2014, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "TT Roadster (FV9, FVR)", null },
                    { 117, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7148), true, true, new DateTime(1988, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "V8 (441, 442, 4C2, 4C8)", null },
                    { 118, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7155), true, true, new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "TGE dodávka (UY_, UX_)", null },
                    { 119, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7161), true, true, new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "TGE autobus", null },
                    { 120, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7167), true, true, new DateTime(2016, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "TGE valník/podvozek (UZ_)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 121, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7268), true, new DateTime(1968, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "124", null },
                    { 122, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7276), true, new DateTime(1972, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "127 (127A)", null },
                    { 123, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7282), true, new DateTime(1976, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "128 (128A)", null },
                    { 124, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7289), true, new DateTime(1973, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "132 (132A)", null },
                    { 125, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7296), true, new DateTime(1974, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "133 (133A)", null },
                    { 126, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7302), true, new DateTime(1963, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "600 (110B)", null },
                    { 127, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7309), true, new DateTime(1966, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "850 (100GD)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 128, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7315), true, true, new DateTime(2010, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "ALHAMBRA (710, 711)", null },
                    { 129, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7321), true, true, new DateTime(1996, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "ALHAMBRA (7V8, 7V9)", null },
                    { 130, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7327), true, true, new DateTime(2004, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "ALTEA (5P1)", null },
                    { 131, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7333), true, true, new DateTime(2006, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "ALTEA XL (5P5, 5P8)", null },
                    { 132, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7339), true, true, new DateTime(2017, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "ARONA (KJ7, KJP)", null },
                    { 133, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7345), true, true, new DateTime(1997, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "AROSA (6H1)", null },
                    { 134, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7352), true, true, new DateTime(2016, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "ATECA (KH7, KHP)", null },
                    { 135, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7358), true, true, new DateTime(1993, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "CORDOBA (6K1, 6K2)", null },
                    { 136, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7366), true, true, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "CORDOBA (6L2)", null },
                    { 137, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7372), true, true, new DateTime(1996, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "CORDOBA Vario (6K5)", null },
                    { 138, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7378), true, true, new DateTime(2008, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "EXEO (3R2)", null },
                    { 139, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7384), true, true, new DateTime(2009, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "EXEO ST (3R5)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[] { 140, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7391), true, new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "FURA (25A)", null });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 141, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7398), true, true, new DateTime(1984, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "IBIZA I (21A)", null },
                    { 142, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7404), true, true, new DateTime(1993, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "IBIZA II (6K1)", null },
                    { 143, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7410), true, true, new DateTime(2002, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "IBIZA III (6L1)", null },
                    { 144, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7416), true, true, new DateTime(2008, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "IBIZA IV (6J5, 6P1)", null },
                    { 145, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7423), true, true, new DateTime(2008, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "IBIZA IV SPORTCOUPE (6J1, 6P5)", null },
                    { 146, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7429), true, true, new DateTime(2010, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "IBIZA IV ST (6J8, 6P8)", null },
                    { 147, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7435), true, true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "IBIZA V (KJ1, KJG)", null },
                    { 148, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7441), true, true, new DateTime(1995, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "INCA (6K9)", null },
                    { 149, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7448), true, true, new DateTime(1999, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "LEON (1M1)", null },
                    { 150, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7454), true, true, new DateTime(2005, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "LEON (1P1)", null },
                    { 151, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7460), true, true, new DateTime(2012, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "LEON (5F1)", null },
                    { 152, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7467), true, true, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "LEON (KL1)", null },
                    { 153, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7472), true, true, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "LEON SC (5F5)", null },
                    { 154, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7479), true, true, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "LEON Sportstourer (KL8)", null },
                    { 155, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7484), true, true, new DateTime(2012, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "LEON ST (5F8)", null },
                    { 156, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7490), true, true, new DateTime(1984, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "MALAGA (23A)", null },
                    { 157, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7498), true, true, new DateTime(1986, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "MARBELLA (28)", null },
                    { 158, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7504), true, true, new DateTime(1986, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "MARBELLA Van (28A)", null },
                    { 159, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7510), true, true, new DateTime(2011, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "MII (KF1, KE1)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 160, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7516), true, new DateTime(1980, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "PANDA (141A)", null },
                    { 161, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7522), true, new DateTime(1978, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "RITMO (138)", null },
                    { 162, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7528), true, new DateTime(1982, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "RONDA (22A)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 163, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7535), true, true, new DateTime(2018, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "TARRACO (KN2)", null },
                    { 164, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7540), true, true, new DateTime(1987, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "TERRA (24)", null },
                    { 165, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7548), true, true, new DateTime(1987, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "TERRA Van (24A)", null },
                    { 166, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7554), true, true, new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "TOLEDO I (1L2)", null },
                    { 167, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7560), true, true, new DateTime(1998, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "TOLEDO II (1M2)", null },
                    { 168, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7566), true, true, new DateTime(2004, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "TOLEDO III (5P2)", null },
                    { 169, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7573), true, true, new DateTime(2012, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "TOLEDO IV (KG3)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 170, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7579), true, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "100", null },
                    { 171, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7585), true, new DateTime(1969, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "110", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[] { 172, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7592), true, true, new DateTime(1985, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "130", null });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[] { 173, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7599), true, new DateTime(1964, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "1000MB", null });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 174, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7605), true, true, new DateTime(1976, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "105,120 (742)", null },
                    { 175, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7611), true, true, new DateTime(1983, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "105,120 (744)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 176, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7617), true, new DateTime(1970, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "110 kupé", null },
                    { 177, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7624), true, new DateTime(1969, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "1100MB", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 178, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7630), true, true, new DateTime(2011, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "CITIGO (NF1)", null },
                    { 179, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7636), true, true, new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "E-CITIGO (NE1)", null },
                    { 180, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7643), true, true, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "ENYAQ iV kupé (5AC)", null },
                    { 181, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7649), true, true, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "ENYAQ iV SUV (5AZ)", null },
                    { 182, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7655), true, true, new DateTime(1999, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FABIA I (6Y2)", null },
                    { 183, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7661), true, true, new DateTime(2000, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FABIA I kombi (6Y5)", null },
                    { 184, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7668), true, true, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FABIA I praktik (6Y5)", null },
                    { 185, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7674), true, true, new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FABIA I Sedan (6Y3)", null },
                    { 186, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7680), true, true, new DateTime(2006, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FABIA II (542)", null },
                    { 187, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7687), true, true, new DateTime(2007, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FABIA II kombi (545)", null },
                    { 188, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7694), true, true, new DateTime(2006, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FABIA II praktik (545)", null },
                    { 189, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7770), true, true, new DateTime(2014, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FABIA III (NJ3)", null },
                    { 190, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7777), true, true, new DateTime(2014, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FABIA III kombi (NJ5)", null },
                    { 191, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7784), true, true, new DateTime(2014, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FABIA III praktik (NJ5)", null },
                    { 192, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7790), true, true, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "FABIA IV (PJ3)", null },
                    { 193, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7796), true, true, new DateTime(1989, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FAVORIT (781)", null },
                    { 194, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7802), true, true, new DateTime(1988, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FAVORIT Forman (785)", null },
                    { 195, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7808), true, true, new DateTime(1992, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FAVORIT pick-up (787)", null },
                    { 196, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7815), true, true, new DateTime(1995, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FELICIA Cube Van (6U5)", null },
                    { 197, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7821), true, true, new DateTime(1994, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FELICIA I (6U1)", null },
                    { 198, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7827), true, true, new DateTime(1995, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FELICIA I kombi (6U5)", null },
                    { 199, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7834), true, true, new DateTime(1995, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FELICIA I pick-up (6UF, 6U7)", null },
                    { 200, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7840), true, true, new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FELICIA II (6U1)", null },
                    { 201, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7846), true, true, new DateTime(1995, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "FELICIA II kombi (6U5)", null },
                    { 202, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7852), true, true, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "KAMIQ (NW4)", null },
                    { 203, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7858), true, true, new DateTime(2017, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "KAROQ (NU7, ND7)", null },
                    { 204, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7864), true, true, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "KODIAQ (NS7, NV7, NS6)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[] { 205, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7870), true, new DateTime(1959, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "OCTAVIA", null });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 206, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7876), true, true, new DateTime(1996, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "OCTAVIA I (1U2)", null },
                    { 207, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7883), true, true, new DateTime(1998, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "OCTAVIA I kombi (1U5)", null },
                    { 208, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7889), true, true, new DateTime(2004, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "OCTAVIA II (1Z3)", null },
                    { 209, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7895), true, true, new DateTime(2004, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "OCTAVIA II kombi (1Z5)", null },
                    { 210, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7901), true, true, new DateTime(2012, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "OCTAVIA III (5E3, NL3, NR3)", null },
                    { 211, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7907), true, true, new DateTime(2012, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "OCTAVIA III kombi (5E5, 5E6)", null },
                    { 212, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7914), true, true, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "OCTAVIA IV (NX3, NN3)", null },
                    { 213, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7920), true, true, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "OCTAVIA IV kombi (NX5)", null },
                    { 214, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7926), true, true, new DateTime(1983, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "RAPID (120G, 130G, 135G)", null },
                    { 215, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7932), true, true, new DateTime(2012, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "RAPID (NH3, NK3, NK6)", null },
                    { 216, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7938), true, true, new DateTime(2012, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "RAPID Spaceback (NH1)", null },
                    { 217, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7945), true, true, new DateTime(2006, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "ROOMSTER (5J7)", null },
                    { 218, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7951), true, true, new DateTime(2007, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "ROOMSTER praktik (5J)", null },
                    { 219, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7957), true, true, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "SCALA (NW1)", null },
                    { 220, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7964), true, true, new DateTime(2001, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "SUPERB I (3U4)", null },
                    { 221, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7970), true, true, new DateTime(2008, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "SUPERB II (3T4)", null },
                    { 222, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7976), true, true, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "SUPERB II kombi (3T5)", null },
                    { 223, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7983), true, true, new DateTime(2015, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "SUPERB III (3V3)", null },
                    { 224, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7989), true, true, new DateTime(2015, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "SUPERB III kombi (3V5)", null },
                    { 225, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(7995), true, true, new DateTime(2009, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "YETI (5L)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 226, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8001), true, new DateTime(1942, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1945, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "166", null },
                    { 227, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8007), true, new DateTime(1969, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "181", null },
                    { 228, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8014), true, new DateTime(1968, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "411,412", null },
                    { 229, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8021), true, new DateTime(1961, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "1500,1600 (31)", null },
                    { 230, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8027), true, new DateTime(1965, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "1500,1600 hatchback (31)", null },
                    { 231, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8033), true, new DateTime(1961, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "1500,1600 kombi (36)", null },
                    { 232, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8039), true, new DateTime(1969, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "412 kombi", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 233, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8045), true, true, new DateTime(2010, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "AMAROK (2HA, 2HB, S1B, S6B, S7A, S7B)", null },
                    { 234, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8052), true, true, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "AMAROK (T1A, T1B)", null },
                    { 235, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8057), true, true, new DateTime(2017, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "ARTEON (3H7, 3H8)", null },
                    { 236, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8063), true, true, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "ARTEON SHOOTING BRAKE (3H9)", null },
                    { 237, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8070), true, true, new DateTime(2016, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "ATLAS (CA1, CA2, CA3)", null },
                    { 238, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8076), true, true, new DateTime(2011, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "BEETLE (5C1, 5C2)", null },
                    { 239, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8082), true, true, new DateTime(2011, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "BEETLE kabrio (5C7, 5C8)", null },
                    { 240, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8088), true, true, new DateTime(1998, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "BORA (1J2)", null },
                    { 241, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8094), true, true, new DateTime(1999, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "BORA kombi (1J6)", null },
                    { 242, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8101), true, true, new DateTime(2015, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "CADDY ALLTRACK dodávka (SAA)", null },
                    { 243, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8107), true, true, new DateTime(2015, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "CADDY ALLTRACK kombi (SAB)", null },
                    { 244, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8113), true, true, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "CADDY CALIFORNIA V (SBB, SBJ)", null },
                    { 245, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8120), true, true, new DateTime(1979, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "CADDY I (14)", null },
                    { 246, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8126), true, true, new DateTime(1995, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "CADDY II kombi (9K9B)", null },
                    { 247, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8132), true, true, new DateTime(1995, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "CADDY II pick-up (9K9A)", null },
                    { 248, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8139), true, true, new DateTime(1996, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "CADDY II pick-up (9U7)", null },
                    { 249, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8145), true, true, new DateTime(2004, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "CADDY III dodávka (2KA, 2KH, 2CA, 2CH)", null },
                    { 250, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8151), true, true, new DateTime(2004, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "CADDY III kombi (2KB, 2KJ, 2CB, 2CJ)", null },
                    { 251, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8158), true, true, new DateTime(2015, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "CADDY IV dodávka (SAA, SAH)", null },
                    { 252, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8163), true, true, new DateTime(2015, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "CADDY IV kombi (SAB, SAJ)", null },
                    { 253, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8170), true, true, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "CADDY V dodávka (SBA, SBH)", null },
                    { 254, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8176), true, true, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "CADDY V kombi (SBB, SBJ)", null },
                    { 255, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8182), true, true, new DateTime(1990, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "CALIFORNIA T4 Camper (7DJ, 7DK, 70J)", null },
                    { 256, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8188), true, true, new DateTime(2003, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "CALIFORNIA T5 Camper (7EC, 7EF, 7EG, 7HF)", null },
                    { 257, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8194), true, true, new DateTime(2015, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "CALIFORNIA T6 Camper (SGC, SGG, SHC)", null },
                    { 258, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8266), true, true, new DateTime(2011, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "CC (358, B7)", null },
                    { 259, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8274), true, true, new DateTime(1987, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "CORRADO (53I)", null },
                    { 260, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8280), true, true, new DateTime(2006, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "CRAFTER 30-35 autobus (2E_)", null },
                    { 261, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8288), true, true, new DateTime(2006, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "CRAFTER 30-50 dodávka (2E_)", null },
                    { 262, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8294), true, true, new DateTime(2006, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "CRAFTER 30-50 valník/podvozek (2F_)", null },
                    { 263, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8300), true, true, new DateTime(2016, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "CRAFTER autobus (SYI, SYJ)", null },
                    { 264, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8306), true, true, new DateTime(2016, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "CRAFTER dodávka (SY_, SX_)", null },
                    { 265, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8312), true, true, new DateTime(2016, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "CRAFTER valník/podvozek (SZ_)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 266, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8317), true, new DateTime(1977, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "DERBY (86)", null },
                    { 267, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8324), true, new DateTime(1981, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "DERBY (86C, 80)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 268, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8330), true, true, new DateTime(2006, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "EOS (1F7, 1F8)", null },
                    { 269, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8337), true, true, new DateTime(2003, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "FOX (5Z1, 5Z3, 5Z4)", null },
                    { 270, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8343), true, true, new DateTime(2014, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "GOLF ALLTRACK VII kombi (BA5, BV5)", null },
                    { 271, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8349), true, true, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "GOLF ALLTRACK VIII (CG5)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[] { 272, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8355), true, new DateTime(1974, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "GOLF I (17)", null });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 273, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8361), true, true, new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "GOLF I kabrio (155)", null },
                    { 274, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8367), true, true, new DateTime(1983, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "GOLF II (19E, 1G1)", null },
                    { 275, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8373), true, true, new DateTime(1989, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "GOLF III (1H1)", null },
                    { 276, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8380), true, true, new DateTime(1993, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "GOLF III kabrio (1E7)", null },
                    { 277, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8387), true, true, new DateTime(1993, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "GOLF III kombi (1H5)", null },
                    { 278, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8393), true, true, new DateTime(1997, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "GOLF IV (1J1)", null },
                    { 279, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8399), true, true, new DateTime(1998, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "GOLF IV kabrio (1E7)", null },
                    { 280, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8405), true, true, new DateTime(1999, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "GOLF IV kombi (1J5)", null },
                    { 281, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8412), true, true, new DateTime(1997, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "GOLF IV pick-up (1J1)", null },
                    { 282, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8418), true, true, new DateTime(2004, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "GOLF PLUS V (5M1, 521)", null },
                    { 283, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8424), true, true, new DateTime(2014, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "GOLF SPORTSVAN VII (AM1, AN1)", null },
                    { 284, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8430), true, true, new DateTime(2003, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "GOLF V (1K1)", null },
                    { 285, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8437), true, true, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "GOLF V kombi (1K5)", null },
                    { 286, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8443), true, true, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "GOLF VI (5K1)", null },
                    { 287, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8450), true, true, new DateTime(2011, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "GOLF VI kabrio (517)", null },
                    { 288, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8456), true, true, new DateTime(2009, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "GOLF VI kombi (AJ5)", null },
                    { 289, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8462), true, true, new DateTime(2012, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "GOLF VII (5G1, BQ1, BE1, BE2)", null },
                    { 290, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8468), true, true, new DateTime(2013, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "GOLF VII kombi (BA5, BV5)", null },
                    { 291, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8475), true, true, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "GOLF VIII (CD1)", null },
                    { 292, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8481), true, true, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "GOLF VIII (CG5)", null },
                    { 293, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8487), true, true, new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "GRAND CALIFORNIA Camper (SCB, SCC)", null },
                    { 294, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8493), true, true, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "ID. Buzz autobus (EBB)", null },
                    { 295, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8499), true, true, new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "ID. Buzz dodávka (EBA)", null },
                    { 296, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8505), true, true, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "ID.3 (E11, E12)", null },
                    { 297, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8511), true, true, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "ID.4 (E21)", null },
                    { 298, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8517), true, true, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "ID.5 (E39)", null },
                    { 299, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8522), true, true, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "ID.7", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 300, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8528), true, new DateTime(1979, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "ILTIS (183)", null },
                    { 301, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8534), true, new DateTime(1978, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "JETTA I (16)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 302, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8541), true, true, new DateTime(1983, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "JETTA II (19E, 1G2, 165)", null },
                    { 303, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8547), true, true, new DateTime(2004, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "JETTA III (1K2)", null },
                    { 304, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8554), true, true, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "JETTA IV (162, 163, AV3, AV2)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[] { 305, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8560), true, new DateTime(1970, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "K 70 (48)", null });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[] { 306, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8566), true, true, new DateTime(1947, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "KAEFER", null });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 307, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8572), true, new DateTime(1949, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "KAEFER kabrio (15)", null },
                    { 308, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8578), true, new DateTime(1957, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "KARMANN GHIA kabrio (14, 34)", null },
                    { 309, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8584), true, new DateTime(1955, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "KARMANN GHIA kupé (14, 34)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 310, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8591), true, true, new DateTime(2014, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "LOAD UP (121, 122, BL1, BL2)", null },
                    { 311, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8597), true, true, new DateTime(1975, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "LT 28-35 I autobus (281-363)", null },
                    { 312, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8604), true, true, new DateTime(1975, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "LT 28-35 I dodávka (281-363)", null },
                    { 313, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8610), true, true, new DateTime(1975, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "LT 28-35 I valník/podvozek (281-363)", null },
                    { 314, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8616), true, true, new DateTime(1996, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "LT 28-35 II autobus (2DB, 2DE, 2DK)", null },
                    { 315, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8622), true, true, new DateTime(1996, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "LT 28-46 II dodávka (2DA, 2DD, 2DH)", null },
                    { 316, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8629), true, true, new DateTime(1996, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "LT 28-46 II valník/podvozek (2DC, 2DF, 2DG, 2DL, 2DM)", null },
                    { 317, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8636), true, true, new DateTime(1975, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "LT 40-55 I dodávka (291-512)", null },
                    { 318, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8642), true, true, new DateTime(1975, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "LT 40-55 I valník/podvozek (293-909)", null },
                    { 319, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8648), true, true, new DateTime(1998, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "LUPO (6X1, 6E1)", null },
                    { 320, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8655), true, true, new DateTime(2003, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "MULTIVAN T5 (7HM, 7HN, 7HF, 7EF, 7EM, 7EN)", null },
                    { 321, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8661), true, true, new DateTime(2015, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "MULTIVAN T6 (SGF, SGM, SGN, SHM, SHN)", null },
                    { 322, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8666), true, true, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "MULTIVAN T7 (STM, STN)", null },
                    { 323, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8672), true, true, new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "NEW BEETLE (9C1, 1C1)", null },
                    { 324, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8678), true, true, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "NEW BEETLE kabrio (1Y7)", null },
                    { 325, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8684), true, true, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "PASSAT ALLTRACK B7 (365)", null },
                    { 326, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8758), true, true, new DateTime(2015, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "PASSAT ALLTRACK B8 (3G5, CB5)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 327, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8765), true, new DateTime(1973, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "PASSAT B1 (32)", null },
                    { 328, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8771), true, new DateTime(1973, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "PASSAT B1 kombi (33)", null },
                    { 329, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8777), true, new DateTime(1979, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "PASSAT B2 (32B)", null },
                    { 330, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8783), true, new DateTime(1980, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "PASSAT B2 kombi (33B)", null },
                    { 331, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8789), true, new DateTime(1982, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "PASSAT B2 sedan (32B)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 332, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8796), true, true, new DateTime(1988, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "PASSAT B3/B4 (3A2, 35I)", null },
                    { 333, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8804), true, true, new DateTime(1988, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "PASSAT B3/B4 kombi (3A5, 35I)", null },
                    { 334, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8810), true, true, new DateTime(1996, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "PASSAT B5 (3B2)", null },
                    { 335, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8816), true, true, new DateTime(1997, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "PASSAT B5 kombi (3B5)", null },
                    { 336, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8823), true, true, new DateTime(2000, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "PASSAT B5.5 (3B3)", null },
                    { 337, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8829), true, true, new DateTime(2000, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "PASSAT B5.5 kombi (3B6)", null },
                    { 338, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8835), true, true, new DateTime(2005, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "PASSAT B6 (3C2)", null },
                    { 339, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8841), true, true, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "PASSAT B6 kombi (3C5)", null },
                    { 340, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8848), true, true, new DateTime(2010, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "PASSAT B7 (362)", null },
                    { 341, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8855), true, true, new DateTime(2010, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "PASSAT B7 kombi (365)", null },
                    { 342, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8861), true, true, new DateTime(2014, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "PASSAT B8 (3G2, CB2)", null },
                    { 343, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8867), true, true, new DateTime(2014, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "PASSAT B8 kombi (3G5, CB5)", null },
                    { 344, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8873), true, true, new DateTime(2008, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "PASSAT CC B6 (357)", null },
                    { 345, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8879), true, true, new DateTime(2002, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "PHAETON (3D1, 3D2, 3D3, 3D4, 3D6, 3D7, 3D8, 3D9)", null },
                    { 346, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8885), true, true, new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "POLO (6N2)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[] { 347, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8892), true, new DateTime(1975, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "POLO (86)", null });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 348, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8898), true, true, new DateTime(2001, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "POLO (9N_, 9A_)", null },
                    { 349, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8904), true, true, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "POLO CLASSIC (86C, 80)", null },
                    { 350, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8912), true, true, new DateTime(1981, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "POLO II (86C, 80)", null },
                    { 351, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8918), true, true, new DateTime(1981, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "POLO II kupé (86C, 80)", null },
                    { 352, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8924), true, true, new DateTime(1992, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "POLO II pick-up (86CF)", null },
                    { 353, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8930), true, true, new DateTime(1994, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "POLO III (6N1)", null },
                    { 354, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8936), true, true, new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "POLO III CLASSIC (6V2)", null },
                    { 355, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8943), true, true, new DateTime(1994, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "POLO III pick-up / Hatchback (6N1)", null },
                    { 356, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8949), true, true, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "POLO IV sedan (9A4, 9A2, 9N2, 9A6)", null },
                    { 357, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8959), true, true, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "POLO IV sedan (9N2)", null },
                    { 358, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8965), true, true, new DateTime(1997, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "POLO kombi (6V5)", null },
                    { 359, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8971), true, true, new DateTime(2009, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "POLO pick-up (6R)", null },
                    { 360, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8977), true, true, new DateTime(1995, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "POLO pick-up / kombi (6V5)", null },
                    { 361, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8983), true, true, new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "POLO PLAYA", null },
                    { 362, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8989), true, true, new DateTime(2009, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "POLO V (6R1, 6C1)", null },
                    { 363, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(8995), true, true, new DateTime(2009, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "POLO V sedan (602, 604, 612, 614)", null },
                    { 364, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9000), true, true, new DateTime(2017, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "POLO VI (AW1, BZ1, AE1)", null },
                    { 365, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9007), true, true, new DateTime(2008, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "ROUTAN", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[] { 366, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9014), true, new DateTime(1981, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "SANTANA (32B)", null });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[] { 367, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9021), true, true, new DateTime(2008, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "SCIROCCO (137, 138)", null });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[] { 368, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9027), true, new DateTime(1974, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "SCIROCCO (53)", null });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 369, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9034), true, true, new DateTime(1980, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "SCIROCCO (53B)", null },
                    { 370, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9040), true, true, new DateTime(1995, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "SHARAN (7M6, 7M8, 7M9)", null },
                    { 371, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9046), true, true, new DateTime(2010, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "SHARAN (7N1, 7N2)", null },
                    { 372, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9052), true, true, new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "T-CROSS (C11)", null },
                    { 373, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9059), true, true, new DateTime(2017, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "T-ROC (A11, D11)", null },
                    { 374, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9065), true, true, new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "T-ROC kabrio (AC7, AC8)", null },
                    { 375, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9071), true, true, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "TAIGO (CS1)", null },
                    { 376, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9076), true, true, new DateTime(1989, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TARO", null },
                    { 377, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9082), true, true, new DateTime(2007, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TIGUAN (5N_)", null },
                    { 378, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9088), true, true, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "TIGUAN (AD1, AX1)", null },
                    { 379, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9094), true, true, new DateTime(2017, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "TIGUAN ALLSPACE (BW2, BJ2)", null },
                    { 380, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9100), true, true, new DateTime(2002, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TOUAREG (7LA, 7L6, 7L7)", null },
                    { 381, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9106), true, true, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TOUAREG (7P5, 7P6)", null },
                    { 382, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9114), true, true, new DateTime(2017, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "TOUAREG (CR7, RC8)", null },
                    { 383, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9120), true, true, new DateTime(2003, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TOURAN (1T1, 1T2)", null },
                    { 384, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9126), true, true, new DateTime(2010, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TOURAN (1T3)", null },
                    { 385, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9133), true, true, new DateTime(2015, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "TOURAN (5T1)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 386, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9139), true, new DateTime(1950, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TRANSPORTER T1 autobus (22, 24, 25, 28)", null },
                    { 387, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9145), true, new DateTime(1950, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TRANSPORTER T1 dodávka (21, 23)", null },
                    { 388, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9151), true, new DateTime(1950, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TRANSPORTER T1 valník/podvozek (26)", null },
                    { 389, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9159), true, new DateTime(1967, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TRANSPORTER T2 autobus (22, 23, 24)", null },
                    { 390, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9165), true, new DateTime(1968, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TRANSPORTER T2 dodávka (21, 23)", null },
                    { 391, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9172), true, new DateTime(1968, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TRANSPORTER T2 valník/podvozek (21, 26)", null }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "MadeBy", "MadeTo", "ManufacturerId", "ModelName", "UpdateDate" },
                values: new object[,]
                {
                    { 392, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9178), true, true, new DateTime(1979, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TRANSPORTER T3 autobus (25_)", null },
                    { 393, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9184), true, true, new DateTime(1979, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TRANSPORTER T3 dodávka (24_, 25_)", null },
                    { 394, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9256), true, true, new DateTime(1979, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TRANSPORTER T3 valník/podvozek (24_)", null },
                    { 395, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9264), true, true, new DateTime(1990, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TRANSPORTER T4 autobus (70B, 70C, 7DB, 7DK, 70J, 70K, 7DC, 7DJ)", null },
                    { 396, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9271), true, true, new DateTime(1990, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TRANSPORTER T4 dodávka (70A, 70H, 7DA, 7DH)", null },
                    { 397, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9279), true, true, new DateTime(1990, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TRANSPORTER T4 valník/podvozek (70E, 70L, 70M, 7DE, 7DL, 7DM)", null },
                    { 398, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9285), true, true, new DateTime(2003, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TRANSPORTER T5 autobus (7HB, 7HJ, 7EB, 7EJ)", null },
                    { 399, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9291), true, true, new DateTime(2003, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "TRANSPORTER T5 dodávka (7HA, 7HH, 7EA, 7EH)", null },
                    { 400, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9297), true, true, new DateTime(2003, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "TRANSPORTER T5 valník/podvozek (7JD, 7JE, 7JL, 7JY, 7JZ, 7FD)", null },
                    { 401, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9303), true, true, new DateTime(2015, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "TRANSPORTER T6 / CARAVELLE T6 autobus (SGB, SGJ, SHB, SHJ)", null },
                    { 402, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9309), true, true, new DateTime(2015, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "TRANSPORTER T6 dodávka (SGA, SGH, SHA, SHH)", null },
                    { 403, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9315), true, true, new DateTime(2015, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "TRANSPORTER T6 valník/podvozek (SFD, SFE, SFL, SFZ, SJD, SJE)", null },
                    { 404, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9321), true, true, new DateTime(2011, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "UP (121, 122, 123, BL1, BL2, BL3)", null },
                    { 405, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9327), true, true, new DateTime(1991, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "VENTO (1H2)", null },
                    { 406, new DateTime(2023, 12, 22, 14, 54, 20, 720, DateTimeKind.Local).AddTicks(9333), true, true, new DateTime(2014, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "XL1 (6Z!)", null }
                });

            migrationBuilder.InsertData(
                table: "Oes",
                columns: new[] { "Id", "CreateDate", "IsActive", "ManufacturerId", "OeNumber", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(4953), true, 1, "03N 115 466", null },
                    { 2, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(4985), true, 1, "03N 115 562", null },
                    { 3, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(4989), true, 1, "03N 115 562 B", null },
                    { 4, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(4992), true, 2, "65.05504-6000", null },
                    { 5, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(4995), true, 2, "65.05504-6002", null },
                    { 6, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(4998), true, 3, "03N 115 466", null },
                    { 7, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(5001), true, 3, "03N 115 562", null },
                    { 8, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(5005), true, 3, "03N 115 562 B", null },
                    { 9, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(5008), true, 4, "03N 115 466", null },
                    { 10, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(5011), true, 4, "03N 115 562", null },
                    { 11, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(5014), true, 4, "03N 115 562 B", null },
                    { 12, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(5017), true, 5, "03N 115 466", null },
                    { 13, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(5020), true, 5, "03N 115 562", null },
                    { 14, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(5024), true, 5, "03N 115 562 B", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CreateDate", "IsActive", "OeNumberGroupId", "OeNumberInGroupId", "PackedBy", "ProductGroupId", "ProductName", "ProductNumber", "RefundableDeposit", "RetailPrice", "SKUCode", "ShortNumber", "UpdateDate", "WarrantyId" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6015), true, null, 1, 1, 1, "Test názvu", "HU 7020 z", 0.0, 0.0, "", "", null, 3 },
                    { 2, 21, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6050), true, null, 1, 1, 1, "", "F 026 407 157", 0.0, 0.0, "", "P7157", null, 3 },
                    { 3, 60, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6057), true, null, 1, 1, 1, "", "47827", 0.0, 0.0, "", "", null, 3 },
                    { 4, 76, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6062), true, null, 1, 1, 1, "", "25.144.00", 0.0, 0.0, "", "", null, 3 },
                    { 5, 51, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6072), true, null, 1, 1, 1, "", "E340H D247", 0.0, 0.0, "", "", null, 3 },
                    { 6, 58, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6077), true, null, 1, 1, 1, "", "153071760762", 0.0, 0.0, "", "71760762", null, 3 },
                    { 7, 16, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6082), true, null, 1, 1, 1, "", "586617", 0.0, 0.0, "", "", null, 3 },
                    { 8, 16, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6088), true, null, 1, 1, 1, "", "728732", 0.0, 0.0, "", "", null, 3 },
                    { 9, 33, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6093), true, null, 1, 1, 1, "", "COF100673E", 0.0, 0.0, "", "", null, 3 },
                    { 10, 152, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6099), true, null, 1, 1, 1, "", "ADV182125", 0.0, 0.0, "", "", null, 3 },
                    { 11, 128, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6104), true, null, 1, 1, 1, "", "10-ECO025", 0.0, 0.0, "", "", null, 3 },
                    { 12, 174, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6109), true, null, 1, 1, 1, "", "50014549", 0.0, 0.0, "", "", null, 3 },
                    { 13, 102, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6115), true, null, 1, 1, 1, "", "A210891", 0.0, 0.0, "", "", null, 3 },
                    { 14, 101, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6120), true, null, 1, 1, 1, "", "F117601", 0.0, 0.0, "", "", null, 3 },
                    { 15, 29, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6126), true, null, 1, 1, 1, "", "L991", 0.0, 0.0, "", "", null, 3 },
                    { 16, 127, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6131), true, null, 1, 1, 1, "", "OE 688/3", 0.0, 0.0, "", "", null, 3 },
                    { 17, 133, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6137), true, null, 1, 1, 1, "", "OX 787D", 0.0, 0.0, "", "", null, 3 },
                    { 18, 118, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6142), true, null, 1, 1, 1, "", "SH 4088 L", 0.0, 0.0, "", "", null, 3 },
                    { 19, 112, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6147), true, null, 1, 1, 1, "", "07.18.054", 0.0, 0.0, "", "", null, 3 },
                    { 20, 82, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6152), true, null, 1, 1, 1, "", "100 322 0019", 0.0, 0.0, "", "", null, 3 },
                    { 21, 139, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6158), true, null, 1, 1, 1, "", "114 419", 0.0, 0.0, "", "", null, 3 },
                    { 22, 124, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6163), true, null, 1, 1, 1, "", "14147", 0.0, 0.0, "", "", null, 3 },
                    { 23, 225, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6168), true, null, 1, 1, 1, "", "B10532", 0.0, 0.0, "", "", null, 3 },
                    { 24, 85, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6173), true, null, 1, 1, 1, "", "FO-ECO025", 0.0, 0.0, "", "", null, 3 },
                    { 25, 39, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6180), true, null, 1, 1, 1, "", "J1310809", 0.0, 0.0, "", "", null, 3 },
                    { 26, 97, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6185), true, null, 1, 1, 1, "", "MD-731", 0.0, 0.0, "", "", null, 3 },
                    { 27, 25, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6191), true, null, 1, 1, 1, "", "OX 787D", 0.0, 0.0, "", "", null, 3 },
                    { 28, 81, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6196), true, null, 1, 1, 1, "", "S 5144 PE", 0.0, 0.0, "", "", null, 3 },
                    { 29, 89, new DateTime(2023, 12, 22, 14, 54, 20, 722, DateTimeKind.Local).AddTicks(6201), true, null, 1, 1, 1, "", "V10-2825", 0.0, 0.0, "", "", null, 3 }
                });

            migrationBuilder.InsertData(
                table: "OeNumberGroups",
                columns: new[] { "Id", "CreateDate", "OeId", "OeNumberInGroupId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(8157), 1, 1, null },
                    { 2, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(8182), 2, 1, null },
                    { 3, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(8186), 3, 1, null },
                    { 4, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(8189), 4, 1, null },
                    { 5, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(8192), 5, 1, null },
                    { 6, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(8195), 6, 1, null },
                    { 7, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(8198), 7, 1, null },
                    { 8, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(8201), 8, 1, null },
                    { 9, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(8204), 9, 1, null },
                    { 10, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(8207), 10, 1, null },
                    { 11, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(8210), 11, 1, null },
                    { 12, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(8213), 12, 1, null },
                    { 13, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(8216), 13, 1, null },
                    { 14, new DateTime(2023, 12, 22, 14, 54, 20, 721, DateTimeKind.Local).AddTicks(8219), 14, 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CurrencyId",
                table: "Countries",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Model_ManufacturerId",
                table: "Model",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_OeNumberGroups_OeId",
                table: "OeNumberGroups",
                column: "OeId");

            migrationBuilder.CreateIndex(
                name: "IX_Oes_ManufacturerId",
                table: "Oes",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OeNumberGroupId",
                table: "Products",
                column: "OeNumberGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductGroupId",
                table: "Products",
                column: "ProductGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_WarrantyId",
                table: "Products",
                column: "WarrantyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Model");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "OeNumberGroups");

            migrationBuilder.DropTable(
                name: "ProductGroups");

            migrationBuilder.DropTable(
                name: "Warranties");

            migrationBuilder.DropTable(
                name: "Oes");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
