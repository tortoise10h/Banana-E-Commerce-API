using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Fix_Table_User_And_Admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannedBy",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Admins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BannedBy",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(5129), new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(6425), new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(6483), new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(6485) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(6487), new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(6490), new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(6491) });
        }
    }
}
