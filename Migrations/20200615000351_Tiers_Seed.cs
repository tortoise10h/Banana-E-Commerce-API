using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Tiers_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Tiers",
                columns: new[] { "Id", "IsDeleted", "TierOption" },
                values: new object[,]
                {
                    { 2, false, 2 },
                    { 1, false, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tiers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tiers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(5457), new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(6905), new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(6957), new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(6961), new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(257), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2629), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2714), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2719), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2723), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2726), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2730), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2734), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2738), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2741), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2745), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2749), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2753), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2757), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2761), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2764), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2768), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2772), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2775), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2779), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2783), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2786), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2790), new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 480, DateTimeKind.Utc).AddTicks(4822), new DateTime(2020, 6, 15, 0, 3, 4, 480, DateTimeKind.Utc).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 480, DateTimeKind.Utc).AddTicks(6105), new DateTime(2020, 6, 15, 0, 3, 4, 480, DateTimeKind.Utc).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 480, DateTimeKind.Utc).AddTicks(6161), new DateTime(2020, 6, 15, 0, 3, 4, 480, DateTimeKind.Utc).AddTicks(6162) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 480, DateTimeKind.Utc).AddTicks(6164), new DateTime(2020, 6, 15, 0, 3, 4, 480, DateTimeKind.Utc).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(2862), new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(3304) });
        }
    }
}
