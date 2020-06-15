using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class ProductTiers_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 898, DateTimeKind.Utc).AddTicks(8224), new DateTime(2020, 6, 15, 0, 4, 41, 898, DateTimeKind.Utc).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 898, DateTimeKind.Utc).AddTicks(9683), new DateTime(2020, 6, 15, 0, 4, 41, 898, DateTimeKind.Utc).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 898, DateTimeKind.Utc).AddTicks(9749), new DateTime(2020, 6, 15, 0, 4, 41, 898, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 898, DateTimeKind.Utc).AddTicks(9752), new DateTime(2020, 6, 15, 0, 4, 41, 898, DateTimeKind.Utc).AddTicks(9753) });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Method", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(4216), 1, false, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(4604) },
                    { 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(5634), 1, false, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(5647) }
                });

            migrationBuilder.InsertData(
                table: "ProductTiers",
                columns: new[] { "Id", "AfterDiscountPrice", "CreatedAt", "DiscountPercentage", "IsDeleted", "KgSale", "PriceCurrency", "PricePerKg", "ProductId", "Quantity", "SalePrice", "TierId", "UpdatedAt" },
                values: new object[,]
                {
                    { 4, 130000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2675), 0, false, 1.0, 1, 130000.0, 4, 39.0, 130000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2676) },
                    { 29, 80000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2764), 0, false, 1.0, 1, 80000.0, 6, 0.0, 80000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2765) },
                    { 30, 75000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2768), 0, false, 1.0, 1, 75000.0, 7, 0.0, 75000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2769) },
                    { 31, 65000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2771), 0, false, 1.0, 1, 65000.0, 8, 0.0, 65000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2773) },
                    { 32, 66000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2775), 0, false, 1.0, 1, 66000.0, 9, 0.0, 66000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2776) },
                    { 33, 58000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2778), 0, false, 1.0, 1, 58000.0, 10, 0.0, 58000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2779) },
                    { 34, 260000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2782), 0, false, 1.0, 1, 260000.0, 11, 0.0, 260000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2783) },
                    { 35, 70000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2804), 0, false, 1.0, 1, 70000.0, 12, 0.0, 70000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2805) },
                    { 36, 100000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2807), 0, false, 1.0, 1, 100000.0, 13, 0.0, 100000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2808) },
                    { 37, 620000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2811), 0, false, 1.0, 1, 620000.0, 14, 0.0, 620000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2812) },
                    { 2, 100000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2635), 0, false, 1.0, 1, 110000.0, 2, 50.0, 110000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2647) },
                    { 39, 400000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2817), 0, false, 1.0, 1, 400000.0, 16, 0.0, 400000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2818) },
                    { 40, 480000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2821), 0, false, 1.0, 1, 480000.0, 17, 0.0, 480000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2822) },
                    { 3, 243000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2669), 0, false, 2.7000000000000002, 1, 90000.0, 3, 62.0, 243000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2671) },
                    { 42, 700000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2828), 0, false, 1.0, 1, 700000.0, 19, 0.0, 700000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2829) },
                    { 43, 400000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2831), 0, false, 0.5, 1, 400000.0, 20, 0.0, 400000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2832) },
                    { 44, 900000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2834), 0, false, 3.0, 1, 900000.0, 21, 0.0, 900000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2836) },
                    { 45, 230000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2838), 0, false, 1.0, 1, 230000.0, 22, 0.0, 230000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2839) },
                    { 46, 300000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2841), 0, false, 1.0, 1, 300000.0, 23, 0.0, 300000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2842) },
                    { 1, 100000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(1341), 0, false, 1.0, 1, 100000.0, 1, 57.0, 100000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(1744) },
                    { 28, 45000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2761), 0, false, 1.0, 1, 45000.0, 5, 0.0, 45000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2762) },
                    { 27, 130000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2757), 0, false, 1.0, 1, 130000.0, 4, 0.0, 130000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2758) },
                    { 41, 330000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2824), 0, false, 1.0, 1, 330000.0, 18, 0.0, 330000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2825) },
                    { 25, 100000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2750), 0, false, 1.0, 1, 110000.0, 2, 0.0, 110000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2751) },
                    { 5, 45000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2679), 0, false, 1.0, 1, 45000.0, 5, 50.0, 45000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2680) },
                    { 6, 80000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2682), 0, false, 1.0, 1, 80000.0, 6, 50.0, 80000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2684) },
                    { 26, 243000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2754), 0, false, 2.7000000000000002, 1, 90000.0, 3, 0.0, 243000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2755) },
                    { 7, 75000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2686), 0, false, 1.0, 1, 75000.0, 7, 50.0, 75000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2687) },
                    { 8, 65000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2690), 0, false, 1.0, 1, 65000.0, 8, 50.0, 65000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2691) },
                    { 9, 66000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2694), 0, false, 1.0, 1, 66000.0, 9, 50.0, 66000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2695) },
                    { 10, 58000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2697), 0, false, 1.0, 1, 58000.0, 10, 50.0, 58000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2698) },
                    { 11, 260000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2700), 0, false, 1.0, 1, 260000.0, 11, 50.0, 260000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2702) },
                    { 12, 70000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2704), 0, false, 1.0, 1, 70000.0, 12, 50.0, 70000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2705) },
                    { 13, 100000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2708), 0, false, 1.0, 1, 100000.0, 13, 50.0, 100000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2709) },
                    { 38, 700000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2814), 0, false, 1.0, 1, 700000.0, 15, 0.0, 700000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2815) },
                    { 15, 700000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2716), 0, false, 1.0, 1, 700000.0, 15, 50.0, 700000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2717) },
                    { 16, 400000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2719), 0, false, 1.0, 1, 400000.0, 16, 50.0, 400000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2720) },
                    { 17, 480000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2723), 0, false, 1.0, 1, 480000.0, 17, 50.0, 480000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2724) },
                    { 18, 330000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2726), 0, false, 1.0, 1, 330000.0, 18, 50.0, 330000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2727) },
                    { 19, 700000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2730), 0, false, 1.0, 1, 700000.0, 19, 50.0, 700000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2731) },
                    { 20, 400000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2733), 0, false, 0.5, 1, 400000.0, 20, 50.0, 400000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2734) },
                    { 21, 900000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2737), 0, false, 3.0, 1, 900000.0, 21, 50.0, 900000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2738) },
                    { 24, 100000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2747), 0, false, 1.0, 1, 100000.0, 1, 0.0, 100000.0, 2, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2748) },
                    { 23, 300000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2743), 0, false, 1.0, 1, 300000.0, 23, 50.0, 300000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2745) },
                    { 14, 620000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2711), 0, false, 1.0, 1, 620000.0, 14, 50.0, 620000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2712) },
                    { 22, 230000.0, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2740), 0, false, 1.0, 1, 230000.0, 22, 50.0, 230000.0, 1, new DateTime(2020, 6, 15, 0, 4, 41, 900, DateTimeKind.Utc).AddTicks(2741) }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(3087), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5179), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5243), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5247), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5251), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5255), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5259), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5265), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5269), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5273), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5277), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5280), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5284), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5288), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5292), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5296), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5299), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5303), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5307), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5311), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5315), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5318), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5323), new DateTime(2020, 6, 15, 0, 4, 41, 899, DateTimeKind.Utc).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 896, DateTimeKind.Utc).AddTicks(4892), new DateTime(2020, 6, 15, 0, 4, 41, 896, DateTimeKind.Utc).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 896, DateTimeKind.Utc).AddTicks(6363), new DateTime(2020, 6, 15, 0, 4, 41, 896, DateTimeKind.Utc).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 896, DateTimeKind.Utc).AddTicks(6420), new DateTime(2020, 6, 15, 0, 4, 41, 896, DateTimeKind.Utc).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 896, DateTimeKind.Utc).AddTicks(6424), new DateTime(2020, 6, 15, 0, 4, 41, 896, DateTimeKind.Utc).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 4, 41, 898, DateTimeKind.Utc).AddTicks(5053), new DateTime(2020, 6, 15, 0, 4, 41, 898, DateTimeKind.Utc).AddTicks(5580) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23);

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
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 161, DateTimeKind.Utc).AddTicks(7306), new DateTime(2020, 6, 15, 0, 3, 50, 161, DateTimeKind.Utc).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 161, DateTimeKind.Utc).AddTicks(8778), new DateTime(2020, 6, 15, 0, 3, 50, 161, DateTimeKind.Utc).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 161, DateTimeKind.Utc).AddTicks(8834), new DateTime(2020, 6, 15, 0, 3, 50, 161, DateTimeKind.Utc).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 161, DateTimeKind.Utc).AddTicks(8838), new DateTime(2020, 6, 15, 0, 3, 50, 161, DateTimeKind.Utc).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(2301), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4421), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4483), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4488), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4492), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4496), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4500), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4504), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4508), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4511), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4515), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4519), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4523), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4527), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4530), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4534), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4538), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4541), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4543) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4545), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4549), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4552), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4553) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4575), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4579), new DateTime(2020, 6, 15, 0, 3, 50, 162, DateTimeKind.Utc).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 159, DateTimeKind.Utc).AddTicks(4562), new DateTime(2020, 6, 15, 0, 3, 50, 159, DateTimeKind.Utc).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 159, DateTimeKind.Utc).AddTicks(6277), new DateTime(2020, 6, 15, 0, 3, 50, 159, DateTimeKind.Utc).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 159, DateTimeKind.Utc).AddTicks(6329), new DateTime(2020, 6, 15, 0, 3, 50, 159, DateTimeKind.Utc).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 159, DateTimeKind.Utc).AddTicks(6333), new DateTime(2020, 6, 15, 0, 3, 50, 159, DateTimeKind.Utc).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 50, 161, DateTimeKind.Utc).AddTicks(4357), new DateTime(2020, 6, 15, 0, 3, 50, 161, DateTimeKind.Utc).AddTicks(4874) });
        }
    }
}
