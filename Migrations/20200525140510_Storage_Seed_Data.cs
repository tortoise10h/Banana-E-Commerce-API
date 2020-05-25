using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Storage_Seed_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 5, 9, 876, DateTimeKind.Utc).AddTicks(8981), new DateTime(2020, 5, 25, 14, 5, 9, 877, DateTimeKind.Utc).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 5, 9, 877, DateTimeKind.Utc).AddTicks(4098), new DateTime(2020, 5, 25, 14, 5, 9, 877, DateTimeKind.Utc).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 5, 9, 877, DateTimeKind.Utc).AddTicks(4157), new DateTime(2020, 5, 25, 14, 5, 9, 877, DateTimeKind.Utc).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 5, 9, 877, DateTimeKind.Utc).AddTicks(4160), new DateTime(2020, 5, 25, 14, 5, 9, 877, DateTimeKind.Utc).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 5, 9, 877, DateTimeKind.Utc).AddTicks(4163), new DateTime(2020, 5, 25, 14, 5, 9, 877, DateTimeKind.Utc).AddTicks(4165) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Location", "Name", "Size", "SizeUnit", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2020, 5, 25, 14, 5, 9, 879, DateTimeKind.Utc).AddTicks(4808), 3, false, "Tiểu Vương Quốc Bình Chánh", "Hoàng Khố", 1000.2, "m2", new DateTime(2020, 5, 25, 14, 5, 9, 879, DateTimeKind.Utc).AddTicks(5280), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 4, 24, 336, DateTimeKind.Utc).AddTicks(979), new DateTime(2020, 5, 25, 14, 4, 24, 336, DateTimeKind.Utc).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 4, 24, 336, DateTimeKind.Utc).AddTicks(3233), new DateTime(2020, 5, 25, 14, 4, 24, 336, DateTimeKind.Utc).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 4, 24, 336, DateTimeKind.Utc).AddTicks(3353), new DateTime(2020, 5, 25, 14, 4, 24, 336, DateTimeKind.Utc).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 4, 24, 336, DateTimeKind.Utc).AddTicks(3359), new DateTime(2020, 5, 25, 14, 4, 24, 336, DateTimeKind.Utc).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 4, 24, 336, DateTimeKind.Utc).AddTicks(3363), new DateTime(2020, 5, 25, 14, 4, 24, 336, DateTimeKind.Utc).AddTicks(3365) });
        }
    }
}
