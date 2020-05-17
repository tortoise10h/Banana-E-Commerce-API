using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Add_Field_Product_Quantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(994), new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(2113), new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(2157), new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(2161), new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(2164), new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(2165) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 15, 6, 51, 23, 580, DateTimeKind.Utc).AddTicks(2268), new DateTime(2020, 5, 15, 6, 51, 23, 580, DateTimeKind.Utc).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 15, 6, 51, 23, 580, DateTimeKind.Utc).AddTicks(3576), new DateTime(2020, 5, 15, 6, 51, 23, 580, DateTimeKind.Utc).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 15, 6, 51, 23, 580, DateTimeKind.Utc).AddTicks(3623), new DateTime(2020, 5, 15, 6, 51, 23, 580, DateTimeKind.Utc).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 15, 6, 51, 23, 580, DateTimeKind.Utc).AddTicks(3626), new DateTime(2020, 5, 15, 6, 51, 23, 580, DateTimeKind.Utc).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 15, 6, 51, 23, 580, DateTimeKind.Utc).AddTicks(3629), new DateTime(2020, 5, 15, 6, 51, 23, 580, DateTimeKind.Utc).AddTicks(3630) });
        }
    }
}
