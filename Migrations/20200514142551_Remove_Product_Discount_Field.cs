using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Remove_Product_Discount_Field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 25, 51, 146, DateTimeKind.Utc).AddTicks(9288), new DateTime(2020, 5, 14, 14, 25, 51, 146, DateTimeKind.Utc).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 25, 51, 147, DateTimeKind.Utc).AddTicks(498), new DateTime(2020, 5, 14, 14, 25, 51, 147, DateTimeKind.Utc).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 25, 51, 147, DateTimeKind.Utc).AddTicks(550), new DateTime(2020, 5, 14, 14, 25, 51, 147, DateTimeKind.Utc).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 25, 51, 147, DateTimeKind.Utc).AddTicks(554), new DateTime(2020, 5, 14, 14, 25, 51, 147, DateTimeKind.Utc).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 25, 51, 147, DateTimeKind.Utc).AddTicks(557), new DateTime(2020, 5, 14, 14, 25, 51, 147, DateTimeKind.Utc).AddTicks(558) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "DiscountPrice",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(4666), new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(6157), new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(6195), new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(6199), new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(6202), new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(6204) });
        }
    }
}
