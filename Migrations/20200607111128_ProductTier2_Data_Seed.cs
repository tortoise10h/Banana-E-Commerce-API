using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class ProductTier2_Data_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 780, DateTimeKind.Utc).AddTicks(8406), new DateTime(2020, 6, 7, 11, 11, 25, 780, DateTimeKind.Utc).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 781, DateTimeKind.Utc).AddTicks(4930), new DateTime(2020, 6, 7, 11, 11, 25, 781, DateTimeKind.Utc).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 781, DateTimeKind.Utc).AddTicks(5042), new DateTime(2020, 6, 7, 11, 11, 25, 781, DateTimeKind.Utc).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 781, DateTimeKind.Utc).AddTicks(5048), new DateTime(2020, 6, 7, 11, 11, 25, 781, DateTimeKind.Utc).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(3889), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6463), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6527), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6534), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6541), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6548), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6554), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6561), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6566), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6572), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6735), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6742), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6748), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6754), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6760), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6766), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6772), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6779), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6785), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6790), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6796), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6802), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6808), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6809) });

            migrationBuilder.InsertData(
                table: "ProductTiers",
                columns: new[] { "Id", "AfterDiscountPrice", "CreatedAt", "DiscountPercentage", "IsDeleted", "KgSale", "PriceCurrency", "PricePerKg", "ProductId", "Quantity", "SalePrice", "TierId", "UpdatedAt" },
                values: new object[,]
                {
                    { 29, 80000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6843), 0, false, 1.0, 1, 80000.0, 6, 0.0, 80000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6845) },
                    { 26, 243000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6825), 0, false, 2.7000000000000002, 1, 90000.0, 3, 0.0, 243000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6827) },
                    { 25, 100000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6819), 0, false, 1.0, 1, 110000.0, 2, 0.0, 110000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6821) },
                    { 27, 130000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6831), 0, false, 1.0, 1, 130000.0, 4, 0.0, 130000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6834) },
                    { 28, 45000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6837), 0, false, 1.0, 1, 45000.0, 5, 0.0, 45000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6839) },
                    { 38, 700000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6905), 0, false, 1.0, 1, 700000.0, 15, 0.0, 700000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6907) },
                    { 30, 75000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6849), 0, false, 1.0, 1, 75000.0, 7, 0.0, 75000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6851) },
                    { 39, 400000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6911), 0, false, 1.0, 1, 400000.0, 16, 0.0, 400000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6913) },
                    { 32, 66000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6862), 0, false, 1.0, 1, 66000.0, 9, 0.0, 66000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6864) },
                    { 40, 480000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6916), 0, false, 1.0, 1, 480000.0, 17, 0.0, 480000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6918) },
                    { 41, 330000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6922), 0, false, 1.0, 1, 330000.0, 18, 0.0, 330000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6924) },
                    { 31, 65000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6856), 0, false, 1.0, 1, 65000.0, 8, 0.0, 65000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6858) },
                    { 42, 700000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6930), 0, false, 1.0, 1, 700000.0, 19, 0.0, 700000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6932) },
                    { 43, 400000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6935), 0, false, 0.5, 1, 400000.0, 20, 0.0, 400000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6937) },
                    { 44, 900000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6941), 0, false, 3.0, 1, 900000.0, 21, 0.0, 900000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6943) },
                    { 45, 230000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6947), 0, false, 1.0, 1, 230000.0, 22, 0.0, 230000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6949) },
                    { 46, 300000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6952), 0, false, 1.0, 1, 300000.0, 23, 0.0, 300000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6954) },
                    { 24, 100000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6814), 0, false, 1.0, 1, 100000.0, 1, 0.0, 100000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6815) },
                    { 33, 58000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6868), 0, false, 1.0, 1, 58000.0, 10, 0.0, 58000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6870) },
                    { 34, 260000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6875), 0, false, 1.0, 1, 260000.0, 11, 0.0, 260000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6877) },
                    { 37, 620000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6898), 0, false, 1.0, 1, 620000.0, 14, 0.0, 620000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6900) },
                    { 36, 100000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6891), 0, false, 1.0, 1, 100000.0, 13, 0.0, 100000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6894) },
                    { 35, 70000.0, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6881), 0, false, 1.0, 1, 70000.0, 12, 0.0, 70000.0, 2, new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6883) }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(3970), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8546), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8771), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8779), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8786), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8793), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8800), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8806), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8813), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8819), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8825), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8832), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8839), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8846), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8852), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8859), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8865), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8872), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8879), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8886), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8895), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8903), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8910), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 775, DateTimeKind.Utc).AddTicks(3389), new DateTime(2020, 6, 7, 11, 11, 25, 775, DateTimeKind.Utc).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 775, DateTimeKind.Utc).AddTicks(6064), new DateTime(2020, 6, 7, 11, 11, 25, 775, DateTimeKind.Utc).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 775, DateTimeKind.Utc).AddTicks(6138), new DateTime(2020, 6, 7, 11, 11, 25, 775, DateTimeKind.Utc).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 775, DateTimeKind.Utc).AddTicks(6145), new DateTime(2020, 6, 7, 11, 11, 25, 775, DateTimeKind.Utc).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 780, DateTimeKind.Utc).AddTicks(3545), new DateTime(2020, 6, 7, 11, 11, 25, 780, DateTimeKind.Utc).AddTicks(4372) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(4682), new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(6140), new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(6195), new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(6199), new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(7611), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8829), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8866), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8870), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8874), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8877), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8881), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8884), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8899), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8903), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8906), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8910), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8913), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8917), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8920), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8924), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8927), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8931), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8935), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8938), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8941), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8945), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8948), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(9208), new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1602), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1670), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1674), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1678), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1681), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1685), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1689), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1692), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1696), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1699), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1703), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1707), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1710), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1714), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1718), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1721), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1724), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1728), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1731), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1735), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1739), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1742), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 148, DateTimeKind.Utc).AddTicks(3899), new DateTime(2020, 6, 7, 11, 4, 22, 148, DateTimeKind.Utc).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 148, DateTimeKind.Utc).AddTicks(5196), new DateTime(2020, 6, 7, 11, 4, 22, 148, DateTimeKind.Utc).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 148, DateTimeKind.Utc).AddTicks(5249), new DateTime(2020, 6, 7, 11, 4, 22, 148, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 148, DateTimeKind.Utc).AddTicks(5252), new DateTime(2020, 6, 7, 11, 4, 22, 148, DateTimeKind.Utc).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(2103), new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(2544) });
        }
    }
}
