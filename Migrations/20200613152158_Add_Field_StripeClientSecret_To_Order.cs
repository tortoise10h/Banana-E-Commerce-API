using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Add_Field_StripeClientSecret_To_Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StripeClientSecret",
                table: "Orders",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(7218), new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(8936), new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(8981), new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(8985), new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(4906), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(6632), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(1900), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3211), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3249), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3255), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3259), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3262), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3267), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3270), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3275), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3278), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3282), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3286), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3290), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3294), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3298), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3302), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3320), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3324), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3328), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3332), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3336), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3340), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3344), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3348), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3352), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3356), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3360), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3364), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3368), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3372), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3376), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3380), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3384), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3388), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3393), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3397), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3401), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3405), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3409), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3412), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3416), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3420), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3424), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3428), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3432), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3436), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(2813), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5027), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5091), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5096), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5103), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5107), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5112), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5113) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5116), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5120), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5125), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5129), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5133), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5137), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5141), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5146), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5150), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5154), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5159), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5163), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5167), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5171), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5175), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5179), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 774, DateTimeKind.Utc).AddTicks(2883), new DateTime(2020, 6, 13, 15, 21, 56, 774, DateTimeKind.Utc).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 774, DateTimeKind.Utc).AddTicks(4286), new DateTime(2020, 6, 13, 15, 21, 56, 774, DateTimeKind.Utc).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 774, DateTimeKind.Utc).AddTicks(4374), new DateTime(2020, 6, 13, 15, 21, 56, 774, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 774, DateTimeKind.Utc).AddTicks(4378), new DateTime(2020, 6, 13, 15, 21, 56, 774, DateTimeKind.Utc).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(4274), new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(4754) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StripeClientSecret",
                table: "Orders");

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

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(4318), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(5625), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(1341), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2826), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2859), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2863), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2867), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2870), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2873), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2877), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2880), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2884), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2887), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2891), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2894), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2898), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2901), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2905), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2908), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2912), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2915), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2919), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2923), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2926), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2929), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2944), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2948), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2951), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2955), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2958), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2962), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2965), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2969), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2972), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2975), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2979), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2982), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2986), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2989), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2992), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2996), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(2999), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3003), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3006), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3010), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3013), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3016), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3020), new DateTime(2020, 6, 13, 12, 39, 42, 381, DateTimeKind.Utc).AddTicks(3021) });

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
    }
}
