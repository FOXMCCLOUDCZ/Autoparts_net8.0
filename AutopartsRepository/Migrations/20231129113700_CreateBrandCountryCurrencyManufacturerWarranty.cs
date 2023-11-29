using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutopartsRepository.Migrations
{
    /// <inheritdoc />
    public partial class CreateBrandCountryCurrencyManufacturerWarranty : Migration
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

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandDescription", "BrandName", "CreateDate", "IsActive", "LogoPath", "TecDoc", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "", "SPIDAN", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(418), true, null, 1, null },
                    { 2, "", "HELLA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(469), true, null, 2, null },
                    { 3, "", "ATE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(473), true, null, 3, null },
                    { 4, "", "MANN-FILTER", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(477), true, null, 4, null },
                    { 5, "", "PIERBURG", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(481), true, null, 5, null },
                    { 6, "", "LuK", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(484), true, null, 6, null },
                    { 7, "", "EBERSPÄCHER", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(488), true, null, 7, null },
                    { 8, "", "VICTOR REINZ", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(491), true, null, 9, null },
                    { 9, "", "ELRING", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(495), true, null, 10, null },
                    { 10, "", "BorgWarner (BERU)", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(498), true, null, 11, null },
                    { 11, "", "WALKER", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(502), true, null, 13, null },
                    { 12, "", "NGK", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(506), true, null, 15, null },
                    { 13, "", "BILSTEIN", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(509), true, null, 16, null },
                    { 14, "", "KONI", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(513), true, null, 18, null },
                    { 15, "", "SWF", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(517), true, null, 19, null },
                    { 16, "", "VALEO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(521), true, null, 21, null },
                    { 17, "", "RUVILLE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(524), true, null, 23, null },
                    { 18, "", "EXIDE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(527), true, null, 24, null },
                    { 19, "", "VARTA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(531), true, null, 26, null },
                    { 20, "", "ERNST", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(534), true, null, 29, null },
                    { 21, "", "BOSCH", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(539), true, null, 30, null },
                    { 22, "", "CONTINENTAL CTAM", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(542), true, null, 31, null },
                    { 23, "", "SACHS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(546), true, null, 32, null },
                    { 24, "", "GATES", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(549), true, null, 33, null },
                    { 25, "", "KNECHT", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(553), true, null, 34, null },
                    { 26, "", "LEMFÖRDER", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(556), true, null, 35, null },
                    { 27, "", "VAN WEZEL", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(560), true, null, 36, null },
                    { 28, "", "MONROE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(563), true, null, 37, null },
                    { 29, "", "PURFLUX", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(567), true, null, 38, null },
                    { 30, "", "TEXTAR", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(570), true, null, 39, null },
                    { 31, "", "BOSAL", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(573), true, null, 41, null },
                    { 32, "", "DAYCO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(577), true, null, 42, null },
                    { 33, "", "CHAMPION", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(580), true, null, 43, null },
                    { 34, "", "BREMI", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(584), true, null, 47, null },
                    { 35, "", "JURID", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(588), true, null, 48, null },
                    { 36, "", "SKF", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(591), true, null, 50, null },
                    { 37, "", "WESTFALIA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(595), true, null, 51, null },
                    { 38, "", "FTE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(598), true, null, 54, null },
                    { 39, "", "HERTH+BUSS JAKOPARTS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(602), true, null, 55, null },
                    { 40, "", "LÖBRO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(605), true, null, 56, null },
                    { 41, "", "QUINTON HAZELL", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(610), true, null, 57, null },
                    { 42, "", "TYC", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(613), true, null, 61, null },
                    { 43, "", "BREMBO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(617), true, null, 65, null },
                    { 44, "", "DENSO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(620), true, null, 66, null },
                    { 45, "", "ams-OSRAM", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(624), true, null, 67, null },
                    { 46, "", "ZF", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(627), true, null, 68, null },
                    { 47, "", "HERTH+BUSS ELPARTS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(631), true, null, 72, null },
                    { 48, "", "PHILIPS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(634), true, null, 75, null },
                    { 49, "", "KLOKKERHOLM", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(638), true, null, 78, null },
                    { 50, "", "BorgWarner (Wahler)", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(641), true, null, 79, null },
                    { 51, "", "HENGST FILTER", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(654), true, null, 81, null },
                    { 52, "", "CONTINENTAL/VDO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(657), true, null, 83, null },
                    { 53, "", "KYB", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(661), true, null, 85, null },
                    { 54, "", "ZIMMERMANN", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(664), true, null, 86, null },
                    { 55, "", "GLASER", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(669), true, null, 88, null },
                    { 56, "", "DELPHI", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(672), true, null, 89, null },
                    { 57, "", "METZGER", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(676), true, null, 94, null },
                    { 58, "", "MAGNETI MARELLI", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(679), true, null, 95, null },
                    { 59, "", "WAECO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(683), true, null, 97, null },
                    { 60, "", "FEBI BILSTEIN", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(687), true, null, 101, null },
                    { 61, "", "BRINK", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(690), true, null, 106, null },
                    { 62, "", "BUGATTI", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(694), true, null, 109, null },
                    { 63, "", "SNR", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(697), true, null, 110, null },
                    { 64, "", "EIBACH", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(700), true, null, 112, null },
                    { 65, "", "PAYEN", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(704), true, null, 113, null },
                    { 66, "", "BUDWEG CALIPER", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(707), true, null, 114, null },
                    { 67, "", "ULO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(710), true, null, 115, null },
                    { 68, "", "LRT", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(714), true, null, 117, null },
                    { 69, "", "HJS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(717), true, null, 118, null },
                    { 70, "", "METELLI", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(721), true, null, 121, null },
                    { 71, "", "NISSENS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(724), true, null, 123, null },
                    { 72, "", "STABILUS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(727), true, null, 126, null },
                    { 73, "", "NK", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(731), true, null, 127, null },
                    { 74, "", "OPTIMAL", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(734), true, null, 129, null },
                    { 75, "", "SIDEM", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(738), true, null, 135, null },
                    { 76, "", "UFI", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(742), true, null, 137, null },
                    { 77, "", "JOHNS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(746), true, null, 138, null },
                    { 78, "", "AJUSA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(749), true, null, 139, null },
                    { 79, "", "CORTECO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(752), true, null, 140, null },
                    { 80, "", "AE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(756), true, null, 141, null },
                    { 81, "", "SOFIMA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(759), true, null, 142, null },
                    { 82, "", "MEYLE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(763), true, null, 144, null },
                    { 83, "", "SWAG", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(766), true, null, 151, null },
                    { 84, "", "DOLZ", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(770), true, null, 154, null },
                    { 85, "", "JAPANPARTS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(773), true, null, 156, null },
                    { 86, "", "ICER", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(776), true, null, 158, null },
                    { 87, "", "FACET", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(780), true, null, 159, null },
                    { 88, "", "TRW", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(784), true, null, 161, null },
                    { 89, "", "VAICO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(788), true, null, 162, null },
                    { 90, "", "AISIN", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(791), true, null, 166, null },
                    { 91, "", "DUPLI COLOR", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(795), true, null, 167, null },
                    { 92, "", "MOTIP", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(798), true, null, 168, null },
                    { 93, "", "PRESTO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(801), true, null, 169, null },
                    { 94, "", "LESJÖFORS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(805), true, null, 175, null },
                    { 95, "", "BTS Turbo", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(809), true, null, 177, null },
                    { 96, "", "HEPU", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(812), true, null, 178, null },
                    { 97, "", "ALCO FILTER", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(816), true, null, 180, null },
                    { 98, "", "GK", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(820), true, null, 181, null },
                    { 99, "", "SCHLÜTTER TURBOLADER", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(824), true, null, 182, null },
                    { 100, "", "VEMO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(827), true, null, 183, null },
                    { 101, "", "KAMOKA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(830), true, null, 185, null },
                    { 102, "", "IMASAF", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(834), true, null, 191, null },
                    { 103, "", "FAG", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(837), true, null, 192, null },
                    { 104, "", "LPR", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(840), true, null, 197, null },
                    { 105, "", "OCAP", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(844), true, null, 198, null },
                    { 106, "", "GLYCO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(847), true, null, 202, null },
                    { 107, "", "INA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(851), true, null, 204, null },
                    { 108, "", "NRF", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(855), true, null, 205, null },
                    { 109, "", "A.B.S.", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(858), true, null, 206, null },
                    { 110, "", "CASTROL", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(862), true, null, 207, null },
                    { 111, "", "TRUCKTEC AUTOMOTIVE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(866), true, null, 209, null },
                    { 112, "", "REMY", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(870), true, null, 214, null },
                    { 113, "", "CALORSTAT by Vernet", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(874), true, null, 215, null },
                    { 114, "", "NÜRAL", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(877), true, null, 216, null },
                    { 115, "", "AIRTEX", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(881), true, null, 220, null },
                    { 116, "", "LIQUI MOLY", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(885), true, null, 222, null },
                    { 117, "", "SCT - MANNOL", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(888), true, null, 225, null },
                    { 118, "", "ELSTOCK", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(891), true, null, 226, null },
                    { 119, "", "DINEX", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(895), true, null, 233, null },
                    { 120, "", "ERA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(898), true, null, 234, null },
                    { 121, "", "FRECCIA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(902), true, null, 235, null },
                    { 122, "", "FAE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(905), true, null, 240, null },
                    { 123, "", "MEAT & DORIA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(909), true, null, 244, null },
                    { 124, "", "AVA QUALITY COOLING", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(913), true, null, 247, null },
                    { 125, "", "NIPPARTS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(916), true, null, 248, null },
                    { 126, "", "FILTRON", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(919), true, null, 256, null },
                    { 127, "", "ASHIKA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(923), true, null, 257, null },
                    { 128, "", "SASIC", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(926), true, null, 260, null },
                    { 129, "", "FAI AutoParts", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(930), true, null, 267, null },
                    { 130, "", "JP GROUP", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(934), true, null, 268, null },
                    { 131, "", "AMC", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(938), true, null, 277, null },
                    { 132, "", "MAHLE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(942), true, null, 287, null },
                    { 133, "", "SACHS PERFORMANCE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(945), true, null, 294, null },
                    { 134, "", "fri.tech.", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(949), true, null, 295, null },
                    { 135, "", "sbs", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(952), true, null, 297, null },
                    { 136, "", "WEBASTO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(964), true, null, 299, null },
                    { 137, "", "AUTEX", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(967), true, null, 300, null },
                    { 138, "", "TOPRAN", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(972), true, null, 301, null },
                    { 139, "", "K&N Filters", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(975), true, null, 305, null },
                    { 140, "", "GRAF", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(980), true, null, 310, null },
                    { 141, "", "CIFAM", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(983), true, null, 311, null },
                    { 142, "", "GENERAL RICAMBI", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(986), true, null, 316, null },
                    { 143, "", "AUTOMEGA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(991), true, null, 323, null },
                    { 144, "", "WIX FILTERS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(995), true, null, 324, null },
                    { 145, "", "BorgWarner (Schwitze", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(998), true, null, 326, null },
                    { 146, "", "BorgWarner", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1002), true, null, 327, null },
                    { 147, "", "BorgWarner (3K)", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1005), true, null, 328, null },
                    { 148, "", "ORIGINAL IMPERIUM", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1008), true, null, 331, null },
                    { 149, "", "PRASCO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1013), true, null, 340, null },
                    { 150, "", "TRW Engine Component", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1016), true, null, 347, null },
                    { 151, "", "BLUE PRINT", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1020), true, null, 350, null },
                    { 152, "", "AUTOFREN SEINSA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1023), true, null, 351, null },
                    { 153, "", "TESLA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1026), true, null, 356, null },
                    { 154, "", "ALKAR", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1030), true, null, 362, null },
                    { 155, "", "FA1", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1033), true, null, 367, null },
                    { 156, "", "GSP", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1036), true, null, 373, null },
                    { 157, "", "CENTRA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1040), true, null, 376, null },
                    { 158, "", "BOSCH DIAGNOSTICS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1043), true, null, 377, null },
                    { 159, "", "FRENKIT", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1047), true, null, 380, null },
                    { 160, "", "GOETZE ENGINE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1050), true, null, 385, null },
                    { 161, "", "MOTORAD", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1054), true, null, 388, null },
                    { 162, "", "GLYSANTIN", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1057), true, null, 389, null },
                    { 163, "", "EAI", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1060), true, null, 391, null },
                    { 164, "", "BARUM", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1064), true, null, 394, null },
                    { 165, "", "JANMOR", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1068), true, null, 397, null },
                    { 166, "", "EXEDY", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1071), true, null, 399, null },
                    { 167, "", "RAICAM", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1074), true, null, 400, null },
                    { 168, "", "MAXGEAR", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1079), true, null, 403, null },
                    { 169, "", "BM CATALYSTS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1082), true, null, 406, null },
                    { 170, "", "FREMAX", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1086), true, null, 409, null },
                    { 171, "", "ASMET", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1089), true, null, 427, null },
                    { 172, "", "RTS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1092), true, null, 430, null },
                    { 173, "", "KOLBENSCHMIDT", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1096), true, null, 432, null },
                    { 174, "", "STATIM", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1099), true, null, 433, null },
                    { 175, "", "MOTUL", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1102), true, null, 436, null },
                    { 176, "", "CoopersFiaam", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1106), true, null, 437, null },
                    { 177, "", "ENERGIZER", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1109), true, null, 443, null },
                    { 178, "", "PILKINGTON", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1113), true, null, 447, null },
                    { 179, "", "HITACHI", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1116), true, null, 449, null },
                    { 180, "", "BANDO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1120), true, null, 454, null },
                    { 181, "", "DRI", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1123), true, null, 460, null },
                    { 182, "", "RAVENOL", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1126), true, null, 461, null },
                    { 183, "", "OSVAT", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1130), true, null, 464, null },
                    { 184, "", "CS Germany", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1133), true, null, 467, null },
                    { 185, "", "BORG & BECK", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1137), true, null, 475, null },
                    { 186, "", "ClimAir", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1141), true, null, 483, null },
                    { 187, "", "NARVA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1145), true, null, 485, null },
                    { 188, "", "BRISK", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1149), true, null, 494, null },
                    { 189, "", "ZAFFO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1152), true, null, 499, null },
                    { 190, "", "EPS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1156), true, null, 4005, null },
                    { 191, "", "KW", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1159), true, null, 4006, null },
                    { 192, "", "KS TOOLS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1162), true, null, 4023, null },
                    { 193, "", "VIGOR", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1166), true, null, 4026, null },
                    { 194, "", "SHELL", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1170), true, null, 4314, null },
                    { 195, "", "Prestone", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1173), true, null, 4333, null },
                    { 196, "", "ELTA AUTOMOTIVE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1177), true, null, 4344, null },
                    { 197, "", "vika", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1181), true, null, 4346, null },
                    { 198, "", "DPA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1184), true, null, 4353, null },
                    { 199, "", "STOP&GO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1188), true, null, 4367, null },
                    { 200, "", "PETEC", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1191), true, null, 4372, null },
                    { 201, "", "Airstal", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1195), true, null, 4381, null },
                    { 202, "", "CONTINENTAL", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1198), true, null, 4434, null },
                    { 203, "", "DUNLOP", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1201), true, null, 4436, null },
                    { 204, "", "MOBIL", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1205), true, null, 4449, null },
                    { 205, "", "YUASA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1209), true, null, 4451, null },
                    { 206, "", "GS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1212), true, null, 4452, null },
                    { 207, "", "SONAX", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1216), true, null, 4457, null },
                    { 208, "", "ERT", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1219), true, null, 4512, null },
                    { 209, "", "ET ENGINETEAM", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1223), true, null, 4514, null },
                    { 210, "", "LINEX", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1226), true, null, 4536, null },
                    { 211, "", "Arnott", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1229), true, null, 4539, null },
                    { 212, "", "TEDGUM", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1233), true, null, 4593, null },
                    { 213, "", "GE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1236), true, null, 4612, null },
                    { 214, "", "GARRETT", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1240), true, null, 4615, null },
                    { 215, "", "ABAKUS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1243), true, null, 4657, null },
                    { 216, "", "ROTINGER", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1247), true, null, 4676, null },
                    { 217, "", "CAFFARO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1250), true, null, 4679, null },
                    { 218, "", "MOBILETRON", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1253), true, null, 4705, null },
                    { 219, "", "NE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1257), true, null, 4717, null },
                    { 220, "", "LIFT-TEK", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1260), true, null, 4719, null },
                    { 221, "", "MIRAGLIO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1264), true, null, 4721, null },
                    { 222, "", "HELLA GUTMANN", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1277), true, null, 4734, null },
                    { 223, "", "HAZET", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1280), true, null, 4808, null },
                    { 224, "", "Borsehung", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1284), true, null, 4815, null },
                    { 225, "", "QUARO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1288), true, null, 4821, null },
                    { 226, "", "AS-PL", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1291), true, null, 4843, null },
                    { 227, "", "Ac Rolcar", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1295), true, null, 4849, null },
                    { 228, "", "ARAL", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1298), true, null, 4866, null },
                    { 229, "", "COFLE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1302), true, null, 4871, null },
                    { 230, "", "POLMO", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1305), true, null, 4873, null },
                    { 231, "", "DYNAMAX", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1308), true, null, 4881, null },
                    { 232, "", "ALLIGATOR", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1312), true, null, 4911, null },
                    { 233, "", "GEDORE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1315), true, null, 4912, null },
                    { 234, "", "NORMA", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1319), true, null, 4923, null },
                    { 235, "", "SCHRADER", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1322), true, null, 4946, null },
                    { 236, "", "TURBORAIL", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1326), true, null, 4949, null },
                    { 237, "", "ESEN SKV", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1330), true, null, 4969, null },
                    { 238, "", "HART", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1335), true, null, 5251, null },
                    { 239, "", "ACPS-ORIS", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1338), true, null, 6102, null },
                    { 240, "", "VALVOLINE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1342), true, null, 6186, null },
                    { 241, "", "CPB", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1345), true, null, 6263, null },
                    { 242, "", "QUICK BRAKE", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1349), true, null, 6304, null },
                    { 243, "", "GKN", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1352), true, null, 6306, null },
                    { 244, "", "REPSOL", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1355), true, null, 6343, null },
                    { 245, "", "EBC Brakes", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1359), true, null, 6368, null },
                    { 246, "", "BERU by DRiV", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1362), true, null, 6441, null },
                    { 247, "", "BorgWarner (AWD)", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1365), true, null, 6444, null },
                    { 248, "", "Dr.Motor Automotive", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1369), true, null, 6534, null },
                    { 249, "", "AIC", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1372), true, null, 6558, null },
                    { 250, "", "Oyodo", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1376), true, null, 6984, null },
                    { 251, "", "JPN", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(1379), true, null, 6985, null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CreateDate", "CurrencyCode", "CurrencyName", "IsActive", "NumericCurrencyCode", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(389), "CZK", "Česká koruna", true, 203, null },
                    { 2, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(419), "EUR", "Euro", true, 978, null },
                    { 3, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(424), "PLN", "Złoty", true, 985, null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CreateDate", "CurrencyCode", "CurrencyName", "NumericCurrencyCode", "UpdateDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(427), "ALL", "Albánský lek", 8, null },
                    { 5, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(431), "AMD", "Arménský dram", 51, null },
                    { 6, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(435), "HRK", "Kuna", 191, null },
                    { 7, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(438), "DKK", "Dánská koruna", 208, null },
                    { 8, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(442), "HUF", "Forint", 348, null },
                    { 9, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(445), "ISK", "Islandská koruna", 352, null },
                    { 10, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(448), "KZT", "Tenge", 398, null },
                    { 11, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(452), "MDL", "Moldavské leu", 498, null },
                    { 12, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(455), "NOK", "Norská koruna", 578, null },
                    { 13, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(459), "RUB", "Ruský rubl", 643, null },
                    { 14, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(462), "SEK", "Švédská koruna", 752, null },
                    { 15, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(466), "CHF", "Švýcarský frank", 756, null },
                    { 16, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(469), "MKD", "Denár", 807, null },
                    { 17, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(472), "GBP", "Libra šterlinků", 826, null },
                    { 18, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(476), "RSD", "Srbský dinár", 941, null },
                    { 19, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(479), "AZN", "Ázerbájdžánský manat", 944, null },
                    { 20, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(482), "RON", "Rumunské leu", 946, null },
                    { 21, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(486), "CHE", "WIR Euro", 947, null },
                    { 22, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(489), "CHW", "WIR Frank", 948, null },
                    { 23, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(492), "TRY", "Turecká lira", 949, null },
                    { 24, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(496), "BYR", "Běloruský rubl", 974, null },
                    { 25, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(499), "BGN", "Bulharská leva", 975, null },
                    { 26, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(503), "BAM", "Konvertibilní marka", 977, null },
                    { 27, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(506), "UAH", "Ukrajinská hřivna", 980, null },
                    { 28, new DateTime(2023, 11, 29, 12, 36, 59, 149, DateTimeKind.Local).AddTicks(509), "GEL", "Lari", 981, null }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsPKW", "LogoPath", "ManufacturerDescription", "ManufacturerName", "TecDoc", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 29, 12, 36, 59, 150, DateTimeKind.Local).AddTicks(3158), true, true, null, null, "AUDI", 3854, null },
                    { 2, new DateTime(2023, 11, 29, 12, 36, 59, 150, DateTimeKind.Local).AddTicks(3212), true, true, null, null, "MAN", 1480, null },
                    { 3, new DateTime(2023, 11, 29, 12, 36, 59, 150, DateTimeKind.Local).AddTicks(3223), true, true, null, null, "SEAT", 2, null },
                    { 4, new DateTime(2023, 11, 29, 12, 36, 59, 150, DateTimeKind.Local).AddTicks(3230), true, true, null, null, "ŠKODA", 1360, null },
                    { 5, new DateTime(2023, 11, 29, 12, 36, 59, 150, DateTimeKind.Local).AddTicks(3237), true, true, null, null, "VOLKSWAGEN", 881, null }
                });

            migrationBuilder.InsertData(
                table: "Warranties",
                columns: new[] { "Id", "CreateDate", "IsActive", "UpdateDate", "WarrantyPeriod" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 29, 12, 36, 59, 150, DateTimeKind.Local).AddTicks(8879), true, null, "6 měsíců" },
                    { 2, new DateTime(2023, 11, 29, 12, 36, 59, 150, DateTimeKind.Local).AddTicks(8910), true, null, "12 měsíců" },
                    { 3, new DateTime(2023, 11, 29, 12, 36, 59, 150, DateTimeKind.Local).AddTicks(8916), true, null, "24 měsíců" },
                    { 4, new DateTime(2023, 11, 29, 12, 36, 59, 150, DateTimeKind.Local).AddTicks(8921), true, null, "36 měsíců" }
                });

            migrationBuilder.InsertData(
                table: "Warranties",
                columns: new[] { "Id", "CreateDate", "UpdateDate", "WarrantyPeriod" },
                values: new object[,]
                {
                    { 5, new DateTime(2023, 11, 29, 12, 36, 59, 150, DateTimeKind.Local).AddTicks(8926), null, "48 měsíců" },
                    { 6, new DateTime(2023, 11, 29, 12, 36, 59, 150, DateTimeKind.Local).AddTicks(8931), null, "60 měsíců" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryNameCZ", "CountryNameENG", "CreateDate", "CurrencyId", "ISOAlpha2", "ISOAlpha3", "IsActive", "NumericCountryCode", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Česká republika", "Czech Republic", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6210), 1, "CZ", "CZE", true, 203, null },
                    { 2, "Slovenská republika", "Slovakia", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6243), 2, "SK", "SVK", true, 703, null },
                    { 3, "Polsko", "Poland", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6248), 3, "PL", "POL", true, 616, null },
                    { 4, "Německo", "Germany", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6252), 2, "DE", "DEU", true, 276, null },
                    { 5, "Rakousko", "Austria", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6257), 2, "AT", "AUT", true, 40, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryNameCZ", "CountryNameENG", "CreateDate", "CurrencyId", "ISOAlpha2", "ISOAlpha3", "NumericCountryCode", "UpdateDate" },
                values: new object[,]
                {
                    { 6, "Albánie", "Albania", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6261), 4, "AL", "ALB", 8, null },
                    { 7, "Andorra", "Andorra", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6265), 2, "AD", "AND", 20, null },
                    { 8, "Arménie", "Armenia", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6268), 5, "AM", "ARM", 51, null },
                    { 9, "Ázerbájdžán", "Azerbaijan", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6272), 19, "AZ", "AZE", 31, null },
                    { 10, "Belgie", "Belgium", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6276), 2, "BE", "BEL", 56, null },
                    { 11, "Bělorusko", "Belarus", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6280), 24, "BY", "BLR", 112, null },
                    { 12, "Bosna a Hercegovina", "Bosnia and Herzegovina", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6285), 26, "BA", "BIH", 70, null },
                    { 13, "Bulharsko", "Bulgaria", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6289), 25, "BG", "BGR", 100, null },
                    { 14, "Černá Hora", "Montenegro", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6293), 2, "ME", "MNE", 499, null },
                    { 15, "Dánsko", "Denmark", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6299), 7, "DK", "DNK", 208, null },
                    { 16, "Estonsko", "Estonia", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6303), 2, "EE", "EST", 233, null },
                    { 17, "Finsko", "Finland", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6308), 2, "FI", "FIN", 246, null },
                    { 18, "Francie", "France", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6313), 2, "FR", "FRA", 250, null },
                    { 19, "Gruzie", "Georgia", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6318), 28, "GE", "GEO", 268, null },
                    { 20, "Chorvatsko", "Croatia", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6323), 6, "HR", "HRV", 191, null },
                    { 21, "Irsko", "Ireland", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6328), 2, "IE", "IRL", 372, null },
                    { 22, "Island", "Iceland", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6333), 9, "IS", "ISL", 352, null },
                    { 23, "Itálie", "Italy", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6338), 2, "IT", "ITA", 380, null },
                    { 24, "Kazachstán", "Kazakhstan", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6343), 10, "KZ", "KAZ", 398, null },
                    { 25, "Kypr (Kyperská republika)", "Cyprus", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6348), 2, "CY", "CYP", 196, null },
                    { 26, "Lichtenštejnsko (Lichtenštejnské knížectví)", "Liechtenstein", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6353), 15, "LI", "LIE", 438, null },
                    { 27, "Litva (Litevská republika)", "Lithuania", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6358), 2, "LT", "LTU", 440, null },
                    { 28, "Lotyšsko (Lotyšská republika)", "Latvia", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6364), 2, "LV", "LVA", 428, null },
                    { 29, "Lucembursko", "Luxembourg", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6369), 2, "LU", "LUX", 442, null },
                    { 30, "Maďarsko", "Hungary", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6374), 8, "HU", "HUN", 348, null },
                    { 31, "Malta", "Malta", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6380), 2, "MT", "MLT", 470, null },
                    { 32, "Moldavsko (Moldavská republika)", "Moldova", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6385), 11, "MD", "MDA", 498, null },
                    { 33, "Monako", "Monaco", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6453), 2, "MC", "MCO", 492, null },
                    { 34, "Nizozemsko", "Netherlands", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6457), 2, "NL", "NLD", 528, null },
                    { 35, "Norsko", "Norway", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6461), 12, "NO", "NOR", 578, null },
                    { 36, "Portugalsko", "Portugal", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6465), 2, "PT", "PRT", 620, null },
                    { 37, "Rumunsko", "Romania", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6469), 20, "RO", "ROU", 642, null },
                    { 38, "Rusko", "Russian Federation", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6473), 13, "RU", "RUS", 643, null },
                    { 39, "Řecko", "Greece", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6477), 2, "GR", "GRC", 300, null },
                    { 40, "San Marino", "San Marino", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6481), 2, "SM", "SMR", 674, null },
                    { 41, "Severní Makedonie (Republika Severní Makedonie)", "Macedonia, Republic of", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6484), 16, "MK", "MKD", 807, null },
                    { 42, "Slovinsko", "Slovenia", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6488), 2, "SI", "SVN", 705, null },
                    { 43, "Srbsko", "Serbia", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6493), 18, "RS", "SRB", 688, null },
                    { 44, "Španělsko", "Spain", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6497), 2, "ES", "ESP", 724, null },
                    { 45, "Švédsko", "Sweden", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6501), 14, "SE", "SWE", 752, null },
                    { 46, "Švýcarsko", "Switzerland", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6504), 21, "CH", "CHE", 756, null },
                    { 47, "Švýcarsko", "Switzerland", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6508), 15, "CH", "CHE", 756, null },
                    { 48, "Švýcarsko", "Switzerland", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6512), 22, "CH", "CHE", 756, null },
                    { 49, "Turecko", "Turkey", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6516), 23, "TR", "TUR", 792, null },
                    { 50, "Ukrajina", "Ukraine", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6519), 27, "UA", "UKR", 804, null },
                    { 51, "Vatikán (Městský stát Vatikán)", "Holy See (Vatican City State)", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6523), 2, "VA", "VAT", 336, null },
                    { 52, "Velká Británie (Spojené království)", "United Kingdom", new DateTime(2023, 11, 29, 12, 36, 59, 148, DateTimeKind.Local).AddTicks(6527), 17, "GB", "GBR", 826, null }
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
