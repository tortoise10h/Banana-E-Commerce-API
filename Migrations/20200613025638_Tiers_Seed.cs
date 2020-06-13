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
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(13), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(1417), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(1477), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(1481), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(1482) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(4685), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6674), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6734), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6738), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6743), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6746), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6751), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6755), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6758), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6763), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6766), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6770), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6773), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6779), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6783), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6786), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6790), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6793), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6797), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6801), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6806), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6810), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6814), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 718, DateTimeKind.Utc).AddTicks(503), new DateTime(2020, 6, 13, 2, 55, 29, 718, DateTimeKind.Utc).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 718, DateTimeKind.Utc).AddTicks(1722), new DateTime(2020, 6, 13, 2, 55, 29, 718, DateTimeKind.Utc).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 718, DateTimeKind.Utc).AddTicks(1771), new DateTime(2020, 6, 13, 2, 55, 29, 718, DateTimeKind.Utc).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 718, DateTimeKind.Utc).AddTicks(1774), new DateTime(2020, 6, 13, 2, 55, 29, 718, DateTimeKind.Utc).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 719, DateTimeKind.Utc).AddTicks(7601), new DateTime(2020, 6, 13, 2, 55, 29, 719, DateTimeKind.Utc).AddTicks(8012) });
        }
    }
}
