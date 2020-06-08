using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Add_ProductStatus_To_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 852, DateTimeKind.Utc).AddTicks(7117), new DateTime(2020, 6, 10, 7, 25, 1, 852, DateTimeKind.Utc).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 853, DateTimeKind.Utc).AddTicks(20), new DateTime(2020, 6, 10, 7, 25, 1, 853, DateTimeKind.Utc).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 853, DateTimeKind.Utc).AddTicks(99), new DateTime(2020, 6, 10, 7, 25, 1, 853, DateTimeKind.Utc).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 853, DateTimeKind.Utc).AddTicks(105), new DateTime(2020, 6, 10, 7, 25, 1, 853, DateTimeKind.Utc).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(5455), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(7908), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(436), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(2918), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3053), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3060), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3068), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3073), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3079), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3084), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3090), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3096), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3101), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3107), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3113), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3119), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3125), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3132), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3137), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3143), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3148), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3154), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3159), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3198), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3205), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3210), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3216), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3222), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3228), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3234), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3240), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3246), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3252), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3258), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3264), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3269), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3274), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3280), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3285), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3290), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3296), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3302), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3307), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3312), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3317), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3322), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3327), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3332), new DateTime(2020, 6, 10, 7, 25, 1, 855, DateTimeKind.Utc).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 853, DateTimeKind.Utc).AddTicks(7118), 2, new DateTime(2020, 6, 10, 7, 25, 1, 853, DateTimeKind.Utc).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(174), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(195) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(263), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(268), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(272), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(309), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(313), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(317), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(321), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(325), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(329), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(334), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(337), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(341), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(346), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(350), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(354), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(358), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(362), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(366), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(370), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(374), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(378), 2, new DateTime(2020, 6, 10, 7, 25, 1, 854, DateTimeKind.Utc).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 848, DateTimeKind.Utc).AddTicks(8891), new DateTime(2020, 6, 10, 7, 25, 1, 849, DateTimeKind.Utc).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 849, DateTimeKind.Utc).AddTicks(2852), new DateTime(2020, 6, 10, 7, 25, 1, 849, DateTimeKind.Utc).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 849, DateTimeKind.Utc).AddTicks(2939), new DateTime(2020, 6, 10, 7, 25, 1, 849, DateTimeKind.Utc).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 849, DateTimeKind.Utc).AddTicks(2945), new DateTime(2020, 6, 10, 7, 25, 1, 849, DateTimeKind.Utc).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 10, 7, 25, 1, 852, DateTimeKind.Utc).AddTicks(1492), new DateTime(2020, 6, 10, 7, 25, 1, 852, DateTimeKind.Utc).AddTicks(2348) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 706, DateTimeKind.Utc).AddTicks(3898), new DateTime(2020, 6, 9, 14, 28, 53, 706, DateTimeKind.Utc).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 706, DateTimeKind.Utc).AddTicks(7303), new DateTime(2020, 6, 9, 14, 28, 53, 706, DateTimeKind.Utc).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 706, DateTimeKind.Utc).AddTicks(7393), new DateTime(2020, 6, 9, 14, 28, 53, 706, DateTimeKind.Utc).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 706, DateTimeKind.Utc).AddTicks(7401), new DateTime(2020, 6, 9, 14, 28, 53, 706, DateTimeKind.Utc).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 710, DateTimeKind.Utc).AddTicks(1789), new DateTime(2020, 6, 9, 14, 28, 53, 710, DateTimeKind.Utc).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 710, DateTimeKind.Utc).AddTicks(4663), new DateTime(2020, 6, 9, 14, 28, 53, 710, DateTimeKind.Utc).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(5956), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8611), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8670), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8676), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8683), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8690), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8696), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8702), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8711), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8717), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8726), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8732), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8738), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8744), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8750), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8757), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8764), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8770), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8776), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8817), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8824), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8833), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8839), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8848), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8854), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8860), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8867), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8872), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8881), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8887), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8892), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8897), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8903), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8908), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8914), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8920), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8925), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8930), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8936), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8943), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8948), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8954), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8959), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8964), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8970), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8975), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 707, DateTimeKind.Utc).AddTicks(7145), 0, new DateTime(2020, 6, 9, 14, 28, 53, 707, DateTimeKind.Utc).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1573), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1694), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1795), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1802), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1808), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1814), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1821), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1829), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1836), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1843), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1849), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1856), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1863), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1869), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1875), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1882), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1889), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1896), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1903), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1909), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1916), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1923), 0, new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 702, DateTimeKind.Utc).AddTicks(2510), new DateTime(2020, 6, 9, 14, 28, 53, 702, DateTimeKind.Utc).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 702, DateTimeKind.Utc).AddTicks(3983), new DateTime(2020, 6, 9, 14, 28, 53, 702, DateTimeKind.Utc).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 702, DateTimeKind.Utc).AddTicks(4081), new DateTime(2020, 6, 9, 14, 28, 53, 702, DateTimeKind.Utc).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 702, DateTimeKind.Utc).AddTicks(4085), new DateTime(2020, 6, 9, 14, 28, 53, 702, DateTimeKind.Utc).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 705, DateTimeKind.Utc).AddTicks(4162), new DateTime(2020, 6, 9, 14, 28, 53, 705, DateTimeKind.Utc).AddTicks(7361) });
        }
    }
}
