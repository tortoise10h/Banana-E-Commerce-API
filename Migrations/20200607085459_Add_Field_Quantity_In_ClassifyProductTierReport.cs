using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Add_Field_Quantity_In_ClassifyProductTierReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Quantity",
                table: "ClassifyProductReports",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 371, DateTimeKind.Utc).AddTicks(7127), new DateTime(2020, 6, 7, 8, 54, 58, 371, DateTimeKind.Utc).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 372, DateTimeKind.Utc).AddTicks(74), new DateTime(2020, 6, 7, 8, 54, 58, 372, DateTimeKind.Utc).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 372, DateTimeKind.Utc).AddTicks(152), new DateTime(2020, 6, 7, 8, 54, 58, 372, DateTimeKind.Utc).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 372, DateTimeKind.Utc).AddTicks(181), new DateTime(2020, 6, 7, 8, 54, 58, 372, DateTimeKind.Utc).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(9967), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1226), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1262), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1267), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1270), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1274), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1278), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1281), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1285), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1288), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1292), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1296), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1300), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1303), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1304) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1307), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1308) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1310), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1314), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1336), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1340), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1344), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1347), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1351), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1354), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 372, DateTimeKind.Utc).AddTicks(5901), new DateTime(2020, 6, 7, 8, 54, 58, 372, DateTimeKind.Utc).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(79), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(192), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(195) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(200), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(207), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(214), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(220), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(227), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(233), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(239), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(246), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(253), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(260), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(267), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(273), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(280), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(287), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(293), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(299), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(305), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(312), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(318), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(324), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 368, DateTimeKind.Utc).AddTicks(9068), new DateTime(2020, 6, 7, 8, 54, 58, 368, DateTimeKind.Utc).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 369, DateTimeKind.Utc).AddTicks(575), new DateTime(2020, 6, 7, 8, 54, 58, 369, DateTimeKind.Utc).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 369, DateTimeKind.Utc).AddTicks(628), new DateTime(2020, 6, 7, 8, 54, 58, 369, DateTimeKind.Utc).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 369, DateTimeKind.Utc).AddTicks(631), new DateTime(2020, 6, 7, 8, 54, 58, 369, DateTimeKind.Utc).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 371, DateTimeKind.Utc).AddTicks(4029), new DateTime(2020, 6, 7, 8, 54, 58, 371, DateTimeKind.Utc).AddTicks(4552) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ClassifyProductReports");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(2441), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(3906), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(3950), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(3953), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(5226), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6603), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6640), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6644), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6647), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6651), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6655), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6659), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6662), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6667), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6670), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6674), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6677), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6681), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6685), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6688), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6692), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6696), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6699), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6703), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6706), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6709), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6713), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(7037), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9392), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9454), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9458), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9462), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9466), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9470), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9473), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9477), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9480), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9484), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9488), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9492), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9496), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9499), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9503), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9507), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9511), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9515), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9518), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9522), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9547), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9550), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 381, DateTimeKind.Utc).AddTicks(1789), new DateTime(2020, 6, 6, 5, 35, 20, 381, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 381, DateTimeKind.Utc).AddTicks(3108), new DateTime(2020, 6, 6, 5, 35, 20, 381, DateTimeKind.Utc).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 381, DateTimeKind.Utc).AddTicks(3161), new DateTime(2020, 6, 6, 5, 35, 20, 381, DateTimeKind.Utc).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 381, DateTimeKind.Utc).AddTicks(3165), new DateTime(2020, 6, 6, 5, 35, 20, 381, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 382, DateTimeKind.Utc).AddTicks(9715), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(156) });
        }
    }
}
