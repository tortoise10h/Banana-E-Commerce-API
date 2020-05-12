using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class AddRoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Is_deleted",
                table: "Role");

            migrationBuilder.AlterColumn<int>(
                name: "RoleName",
                table: "Role",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Role",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "RoleName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 12, 4, 21, 20, 265, DateTimeKind.Utc).AddTicks(8900), false, 0, new DateTime(2020, 5, 12, 4, 21, 20, 265, DateTimeKind.Utc).AddTicks(9396) },
                    { 2, new DateTime(2020, 5, 12, 4, 21, 20, 266, DateTimeKind.Utc).AddTicks(209), false, 2, new DateTime(2020, 5, 12, 4, 21, 20, 266, DateTimeKind.Utc).AddTicks(223) },
                    { 3, new DateTime(2020, 5, 12, 4, 21, 20, 266, DateTimeKind.Utc).AddTicks(289), false, 1, new DateTime(2020, 5, 12, 4, 21, 20, 266, DateTimeKind.Utc).AddTicks(290) },
                    { 4, new DateTime(2020, 5, 12, 4, 21, 20, 266, DateTimeKind.Utc).AddTicks(292), false, 3, new DateTime(2020, 5, 12, 4, 21, 20, 266, DateTimeKind.Utc).AddTicks(293) },
                    { 5, new DateTime(2020, 5, 12, 4, 21, 20, 266, DateTimeKind.Utc).AddTicks(295), false, 4, new DateTime(2020, 5, 12, 4, 21, 20, 266, DateTimeKind.Utc).AddTicks(296) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Role");

            migrationBuilder.AlterColumn<string>(
                name: "RoleName",
                table: "Role",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<bool>(
                name: "Is_deleted",
                table: "Role",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
