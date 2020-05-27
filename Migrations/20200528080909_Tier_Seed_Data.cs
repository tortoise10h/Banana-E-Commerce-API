using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Tier_Seed_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(5121), new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(6576), new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(6633), new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(6637), new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(9675), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1809), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1875), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1881), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1885), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1889), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1893), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1897), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1902), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1906), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1910), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1915), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1919), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2018), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2022), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2026), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2029), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2033), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2036), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2040), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2043), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2047), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2051), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 734, DateTimeKind.Utc).AddTicks(4049), new DateTime(2020, 5, 28, 8, 9, 8, 734, DateTimeKind.Utc).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 734, DateTimeKind.Utc).AddTicks(5231), new DateTime(2020, 5, 28, 8, 9, 8, 734, DateTimeKind.Utc).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 734, DateTimeKind.Utc).AddTicks(5283), new DateTime(2020, 5, 28, 8, 9, 8, 734, DateTimeKind.Utc).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 734, DateTimeKind.Utc).AddTicks(5287), new DateTime(2020, 5, 28, 8, 9, 8, 734, DateTimeKind.Utc).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(1128), new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(2434) });

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
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(6946), new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(8595), new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(8657), new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(8661), new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(2397), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4775), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4843), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4849), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4853), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4857), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4861), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4864), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4868), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4870) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4872), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4877), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4880), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4885), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4888), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4892), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4896), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4900), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4904), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4908), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4912), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4916), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4920), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4924), new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 934, DateTimeKind.Utc).AddTicks(2715), new DateTime(2020, 5, 28, 8, 2, 28, 934, DateTimeKind.Utc).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 934, DateTimeKind.Utc).AddTicks(4044), new DateTime(2020, 5, 28, 8, 2, 28, 934, DateTimeKind.Utc).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 934, DateTimeKind.Utc).AddTicks(4100), new DateTime(2020, 5, 28, 8, 2, 28, 934, DateTimeKind.Utc).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 934, DateTimeKind.Utc).AddTicks(4104), new DateTime(2020, 5, 28, 8, 2, 28, 934, DateTimeKind.Utc).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(3766), new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(4227) });
        }
    }
}
