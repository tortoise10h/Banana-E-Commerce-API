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
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 230, DateTimeKind.Utc).AddTicks(8823), new DateTime(2020, 6, 13, 2, 57, 10, 230, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(168), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(222), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(225), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(227) });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Method", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(4770), 1, false, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(5135) },
                    { 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(6105), 1, false, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(6120) }
                });

            migrationBuilder.InsertData(
                table: "ProductTiers",
                columns: new[] { "Id", "AfterDiscountPrice", "CreatedAt", "DiscountPercentage", "IsDeleted", "KgSale", "PriceCurrency", "PricePerKg", "ProductId", "Quantity", "SalePrice", "TierId", "UpdatedAt" },
                values: new object[,]
                {
                    { 4, 130000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3221), 0, false, 1.0, 1, 130000.0, 4, 39.0, 130000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3222) },
                    { 29, 80000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3308), 0, false, 1.0, 1, 80000.0, 6, 0.0, 80000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3309) },
                    { 30, 75000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3311), 0, false, 1.0, 1, 75000.0, 7, 0.0, 75000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3312) },
                    { 31, 65000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3315), 0, false, 1.0, 1, 65000.0, 8, 0.0, 65000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3316) },
                    { 32, 66000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3318), 0, false, 1.0, 1, 66000.0, 9, 0.0, 66000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3319) },
                    { 33, 58000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3321), 0, false, 1.0, 1, 58000.0, 10, 0.0, 58000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3323) },
                    { 34, 260000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3325), 0, false, 1.0, 1, 260000.0, 11, 0.0, 260000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3326) },
                    { 35, 70000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3328), 0, false, 1.0, 1, 70000.0, 12, 0.0, 70000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3329) },
                    { 36, 100000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3332), 0, false, 1.0, 1, 100000.0, 13, 0.0, 100000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3333) },
                    { 37, 620000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3335), 0, false, 1.0, 1, 620000.0, 14, 0.0, 620000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3336) },
                    { 2, 100000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3162), 0, false, 1.0, 1, 110000.0, 2, 50.0, 110000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3176) },
                    { 39, 400000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3342), 0, false, 1.0, 1, 400000.0, 16, 0.0, 400000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3343) },
                    { 40, 480000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3345), 0, false, 1.0, 1, 480000.0, 17, 0.0, 480000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3346) },
                    { 3, 243000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3197), 0, false, 2.7000000000000002, 1, 90000.0, 3, 62.0, 243000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3198) },
                    { 42, 700000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3352), 0, false, 1.0, 1, 700000.0, 19, 0.0, 700000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3353) },
                    { 43, 400000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3355), 0, false, 0.5, 1, 400000.0, 20, 0.0, 400000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3356) },
                    { 44, 900000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3359), 0, false, 3.0, 1, 900000.0, 21, 0.0, 900000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3360) },
                    { 45, 230000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3362), 0, false, 1.0, 1, 230000.0, 22, 0.0, 230000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3363) },
                    { 46, 300000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3373), 0, false, 1.0, 1, 300000.0, 23, 0.0, 300000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3374) },
                    { 1, 100000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(1197), 0, false, 1.0, 1, 100000.0, 1, 57.0, 100000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(1716) },
                    { 28, 45000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3304), 0, false, 1.0, 1, 45000.0, 5, 0.0, 45000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3305) },
                    { 27, 130000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3301), 0, false, 1.0, 1, 130000.0, 4, 0.0, 130000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3302) },
                    { 41, 330000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3349), 0, false, 1.0, 1, 330000.0, 18, 0.0, 330000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3350) },
                    { 25, 100000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3294), 0, false, 1.0, 1, 110000.0, 2, 0.0, 110000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3295) },
                    { 5, 45000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3224), 0, false, 1.0, 1, 45000.0, 5, 50.0, 45000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3225) },
                    { 6, 80000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3228), 0, false, 1.0, 1, 80000.0, 6, 50.0, 80000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3229) },
                    { 26, 243000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3297), 0, false, 2.7000000000000002, 1, 90000.0, 3, 0.0, 243000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3299) },
                    { 7, 75000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3231), 0, false, 1.0, 1, 75000.0, 7, 50.0, 75000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3232) },
                    { 8, 65000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3235), 0, false, 1.0, 1, 65000.0, 8, 50.0, 65000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3236) },
                    { 9, 66000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3238), 0, false, 1.0, 1, 66000.0, 9, 50.0, 66000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3240) },
                    { 10, 58000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3242), 0, false, 1.0, 1, 58000.0, 10, 50.0, 58000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3243) },
                    { 11, 260000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3246), 0, false, 1.0, 1, 260000.0, 11, 50.0, 260000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3247) },
                    { 12, 70000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3249), 0, false, 1.0, 1, 70000.0, 12, 50.0, 70000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3250) },
                    { 13, 100000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3252), 0, false, 1.0, 1, 100000.0, 13, 50.0, 100000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3253) },
                    { 38, 700000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3338), 0, false, 1.0, 1, 700000.0, 15, 0.0, 700000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3340) },
                    { 15, 700000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3259), 0, false, 1.0, 1, 700000.0, 15, 50.0, 700000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3260) },
                    { 16, 400000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3263), 0, false, 1.0, 1, 400000.0, 16, 50.0, 400000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3264) },
                    { 17, 480000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3266), 0, false, 1.0, 1, 480000.0, 17, 50.0, 480000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3268) },
                    { 18, 330000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3270), 0, false, 1.0, 1, 330000.0, 18, 50.0, 330000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3271) },
                    { 19, 700000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3273), 0, false, 1.0, 1, 700000.0, 19, 50.0, 700000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3275) },
                    { 20, 400000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3277), 0, false, 0.5, 1, 400000.0, 20, 50.0, 400000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3278) },
                    { 21, 900000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3280), 0, false, 3.0, 1, 900000.0, 21, 50.0, 900000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3281) },
                    { 24, 100000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3291), 0, false, 1.0, 1, 100000.0, 1, 0.0, 100000.0, 2, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3292) },
                    { 23, 300000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3287), 0, false, 1.0, 1, 300000.0, 23, 50.0, 300000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3288) },
                    { 14, 620000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3256), 0, false, 1.0, 1, 620000.0, 14, 50.0, 620000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3257) },
                    { 22, 230000.0, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3284), 0, false, 1.0, 1, 230000.0, 22, 50.0, 230000.0, 1, new DateTime(2020, 6, 13, 2, 57, 10, 232, DateTimeKind.Utc).AddTicks(3285) }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(3599), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5552), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5609), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5614), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5618), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5621), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5625), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5631), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5635), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5638), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5642), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5645), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5649), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5653), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5657), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5661), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5664), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5668), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5672), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5675), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5679), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5682), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5686), new DateTime(2020, 6, 13, 2, 57, 10, 231, DateTimeKind.Utc).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 228, DateTimeKind.Utc).AddTicks(8959), new DateTime(2020, 6, 13, 2, 57, 10, 228, DateTimeKind.Utc).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 229, DateTimeKind.Utc).AddTicks(158), new DateTime(2020, 6, 13, 2, 57, 10, 229, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 229, DateTimeKind.Utc).AddTicks(208), new DateTime(2020, 6, 13, 2, 57, 10, 229, DateTimeKind.Utc).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 229, DateTimeKind.Utc).AddTicks(211), new DateTime(2020, 6, 13, 2, 57, 10, 229, DateTimeKind.Utc).AddTicks(212) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 57, 10, 230, DateTimeKind.Utc).AddTicks(6400), new DateTime(2020, 6, 13, 2, 57, 10, 230, DateTimeKind.Utc).AddTicks(6806) });
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
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(324), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(1899), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(1967), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(1970), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(5595), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7531), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7590), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7617), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7621), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7624), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7628), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7631), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7635), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7639), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7642), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7646), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7650), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7653), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7657), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7660), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7664), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7668), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7671), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7675), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7678), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7682), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7686), new DateTime(2020, 6, 13, 2, 56, 37, 149, DateTimeKind.Utc).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 146, DateTimeKind.Utc).AddTicks(8424), new DateTime(2020, 6, 13, 2, 56, 37, 146, DateTimeKind.Utc).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 146, DateTimeKind.Utc).AddTicks(9643), new DateTime(2020, 6, 13, 2, 56, 37, 146, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 146, DateTimeKind.Utc).AddTicks(9700), new DateTime(2020, 6, 13, 2, 56, 37, 146, DateTimeKind.Utc).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 146, DateTimeKind.Utc).AddTicks(9703), new DateTime(2020, 6, 13, 2, 56, 37, 146, DateTimeKind.Utc).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 56, 37, 148, DateTimeKind.Utc).AddTicks(7860), new DateTime(2020, 6, 13, 2, 56, 37, 148, DateTimeKind.Utc).AddTicks(8275) });
        }
    }
}
