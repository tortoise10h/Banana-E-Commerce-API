using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Fix_Admin_Gender_Type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 10, 16, 721, DateTimeKind.Utc).AddTicks(3192), new DateTime(2020, 5, 14, 16, 10, 16, 721, DateTimeKind.Utc).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 10, 16, 721, DateTimeKind.Utc).AddTicks(4757), new DateTime(2020, 5, 14, 16, 10, 16, 721, DateTimeKind.Utc).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 10, 16, 721, DateTimeKind.Utc).AddTicks(4836), new DateTime(2020, 5, 14, 16, 10, 16, 721, DateTimeKind.Utc).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 10, 16, 721, DateTimeKind.Utc).AddTicks(4840), new DateTime(2020, 5, 14, 16, 10, 16, 721, DateTimeKind.Utc).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 10, 16, 721, DateTimeKind.Utc).AddTicks(4842), new DateTime(2020, 5, 14, 16, 10, 16, 721, DateTimeKind.Utc).AddTicks(4844) });
        }
    }
}
