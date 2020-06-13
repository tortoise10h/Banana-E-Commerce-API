using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class PaymentMethods_And_ProductTiers_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 379, DateTimeKind.Utc).AddTicks(9141), new DateTime(2020, 6, 13, 12, 39, 42, 379, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(492), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(545), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(549), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(550) });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Method", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(4318), 1, false, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(4674) },
                    { 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(5625), 1, false, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(5638) }
                });

            migrationBuilder.InsertData(
                table: "ProductTiers",
                columns: new[] { "Id", "AfterDiscountPrice", "CreatedAt", "DiscountPercentage", "IsDeleted", "KgSale", "PriceCurrency", "PricePerKg", "ProductId", "Quantity", "SalePrice", "TierId", "UpdatedAt" },
                values: new object[,]
                {
                    { 4, 130000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2863), 0, false, 1.0, 1, 130000.0, 4, 39.0, 130000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2864) },
                    { 29, 80000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2962), 0, false, 1.0, 1, 80000.0, 6, 0.0, 80000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2963) },
                    { 30, 75000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2965), 0, false, 1.0, 1, 75000.0, 7, 0.0, 75000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2966) },
                    { 31, 65000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2969), 0, false, 1.0, 1, 65000.0, 8, 0.0, 65000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2970) },
                    { 32, 66000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2972), 0, false, 1.0, 1, 66000.0, 9, 0.0, 66000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2973) },
                    { 33, 58000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2975), 0, false, 1.0, 1, 58000.0, 10, 0.0, 58000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2976) },
                    { 34, 260000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2979), 0, false, 1.0, 1, 260000.0, 11, 0.0, 260000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2980) },
                    { 35, 70000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2982), 0, false, 1.0, 1, 70000.0, 12, 0.0, 70000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2983) },
                    { 36, 100000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2986), 0, false, 1.0, 1, 100000.0, 13, 0.0, 100000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2987) },
                    { 37, 620000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2989), 0, false, 1.0, 1, 620000.0, 14, 0.0, 620000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2990) },
                    { 2, 100000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2826), 0, false, 1.0, 1, 110000.0, 2, 50.0, 110000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2839) },
                    { 39, 400000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2996), 0, false, 1.0, 1, 400000.0, 16, 0.0, 400000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2997) },
                    { 40, 480000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2999), 0, false, 1.0, 1, 480000.0, 17, 0.0, 480000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3001) },
                    { 3, 243000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2859), 0, false, 2.7000000000000002, 1, 90000.0, 3, 62.0, 243000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2860) },
                    { 42, 700000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3006), 0, false, 1.0, 1, 700000.0, 19, 0.0, 700000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3007) },
                    { 43, 400000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3010), 0, false, 0.5, 1, 400000.0, 20, 0.0, 400000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3011) },
                    { 44, 900000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3013), 0, false, 3.0, 1, 900000.0, 21, 0.0, 900000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3014) },
                    { 45, 230000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3016), 0, false, 1.0, 1, 230000.0, 22, 0.0, 230000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3018) },
                    { 46, 300000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3020), 0, false, 1.0, 1, 300000.0, 23, 0.0, 300000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3021) },
                    { 1, 100000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(1341), 0, false, 1.0, 1, 100000.0, 1, 57.0, 100000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(1716) },
                    { 28, 45000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2958), 0, false, 1.0, 1, 45000.0, 5, 0.0, 45000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2959) },
                    { 27, 130000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2955), 0, false, 1.0, 1, 130000.0, 4, 0.0, 130000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2956) },
                    { 41, 330000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3003), 0, false, 1.0, 1, 330000.0, 18, 0.0, 330000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3004) },
                    { 25, 100000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2948), 0, false, 1.0, 1, 110000.0, 2, 0.0, 110000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2949) },
                    { 5, 45000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2867), 0, false, 1.0, 1, 45000.0, 5, 50.0, 45000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2868) },
                    { 6, 80000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2870), 0, false, 1.0, 1, 80000.0, 6, 50.0, 80000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2871) },
                    { 26, 243000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2951), 0, false, 2.7000000000000002, 1, 90000.0, 3, 0.0, 243000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2952) },
                    { 7, 75000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2873), 0, false, 1.0, 1, 75000.0, 7, 50.0, 75000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2875) },
                    { 8, 65000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2877), 0, false, 1.0, 1, 65000.0, 8, 50.0, 65000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2878) },
                    { 9, 66000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2880), 0, false, 1.0, 1, 66000.0, 9, 50.0, 66000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2882) },
                    { 10, 58000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2884), 0, false, 1.0, 1, 58000.0, 10, 50.0, 58000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2885) },
                    { 11, 260000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2887), 0, false, 1.0, 1, 260000.0, 11, 50.0, 260000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2889) },
                    { 12, 70000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2891), 0, false, 1.0, 1, 70000.0, 12, 50.0, 70000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2892) },
                    { 13, 100000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2894), 0, false, 1.0, 1, 100000.0, 13, 50.0, 100000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2895) },
                    { 38, 700000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2992), 0, false, 1.0, 1, 700000.0, 15, 0.0, 700000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2994) },
                    { 15, 700000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2901), 0, false, 1.0, 1, 700000.0, 15, 50.0, 700000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2903) },
                    { 16, 400000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2905), 0, false, 1.0, 1, 400000.0, 16, 50.0, 400000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2906) },
                    { 17, 480000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2908), 0, false, 1.0, 1, 480000.0, 17, 50.0, 480000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2909) },
                    { 18, 330000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2912), 0, false, 1.0, 1, 330000.0, 18, 50.0, 330000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2913) },
                    { 19, 700000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2915), 0, false, 1.0, 1, 700000.0, 19, 50.0, 700000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2917) },
                    { 20, 400000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2919), 0, false, 0.5, 1, 400000.0, 20, 50.0, 400000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2920) },
                    { 21, 900000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2923), 0, false, 3.0, 1, 900000.0, 21, 50.0, 900000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2924) },
                    { 24, 100000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2944), 0, false, 1.0, 1, 100000.0, 1, 0.0, 100000.0, 2, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2946) },
                    { 23, 300000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2929), 0, false, 1.0, 1, 300000.0, 23, 50.0, 300000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2931) },
                    { 14, 620000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2898), 0, false, 1.0, 1, 620000.0, 14, 50.0, 620000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2899) },
                    { 22, 230000.0, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2926), 0, false, 1.0, 1, 230000.0, 22, 50.0, 230000.0, 1, new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2927) }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(3923), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5844), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5907), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5912), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5915), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5919), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5925), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5949), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5952), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5956), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5959), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5963), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5967), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5971), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5974), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5979), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5983), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5986), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5990), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5993), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5997), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(6001), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(6004), new DateTime(2020, 6, 13, 12, 39, 42, 380, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 377, DateTimeKind.Utc).AddTicks(9025), new DateTime(2020, 6, 13, 12, 39, 42, 377, DateTimeKind.Utc).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 378, DateTimeKind.Utc).AddTicks(221), new DateTime(2020, 6, 13, 12, 39, 42, 378, DateTimeKind.Utc).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 378, DateTimeKind.Utc).AddTicks(277), new DateTime(2020, 6, 13, 12, 39, 42, 378, DateTimeKind.Utc).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 378, DateTimeKind.Utc).AddTicks(280), new DateTime(2020, 6, 13, 12, 39, 42, 378, DateTimeKind.Utc).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 379, DateTimeKind.Utc).AddTicks(6701), new DateTime(2020, 6, 13, 12, 39, 42, 379, DateTimeKind.Utc).AddTicks(7113) });
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
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(2766), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(4111), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(4167), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(4171), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(7257), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9457), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9522), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9526), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9531), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9535), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9539), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9542), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9546), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9550), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9554), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9558), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9561), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9565), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9568), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9572), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9576), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9579), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9583), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9586), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9590), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9593), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9597), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 366, DateTimeKind.Utc).AddTicks(2311), new DateTime(2020, 6, 13, 12, 39, 8, 366, DateTimeKind.Utc).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 366, DateTimeKind.Utc).AddTicks(3527), new DateTime(2020, 6, 13, 12, 39, 8, 366, DateTimeKind.Utc).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 366, DateTimeKind.Utc).AddTicks(3574), new DateTime(2020, 6, 13, 12, 39, 8, 366, DateTimeKind.Utc).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 366, DateTimeKind.Utc).AddTicks(3577), new DateTime(2020, 6, 13, 12, 39, 8, 366, DateTimeKind.Utc).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 367, DateTimeKind.Utc).AddTicks(9748), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(535) });
        }
    }
}
