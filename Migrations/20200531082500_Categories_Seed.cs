using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Categories_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(4812), 1, false, "Trái Cây Việt", new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(5235) },
                    { 2, new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(6272), 2, false, "Trái Cây Nhập", new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(6302) },
                    { 3, new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(6332), 3, false, "Trái Cây Sấy Khô", new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(6333) },
                    { 4, new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(6335), 4, false, "Mứt Trái Cây>", new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(6337) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 25, 0, 309, DateTimeKind.Utc).AddTicks(4123), new DateTime(2020, 5, 31, 8, 25, 0, 309, DateTimeKind.Utc).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 25, 0, 309, DateTimeKind.Utc).AddTicks(5535), new DateTime(2020, 5, 31, 8, 25, 0, 309, DateTimeKind.Utc).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 25, 0, 309, DateTimeKind.Utc).AddTicks(5582), new DateTime(2020, 5, 31, 8, 25, 0, 309, DateTimeKind.Utc).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 25, 0, 309, DateTimeKind.Utc).AddTicks(5586), new DateTime(2020, 5, 31, 8, 25, 0, 309, DateTimeKind.Utc).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(1962), new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(2468) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 24, 10, 236, DateTimeKind.Utc).AddTicks(4891), new DateTime(2020, 5, 31, 8, 24, 10, 236, DateTimeKind.Utc).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 24, 10, 236, DateTimeKind.Utc).AddTicks(6169), new DateTime(2020, 5, 31, 8, 24, 10, 236, DateTimeKind.Utc).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 24, 10, 236, DateTimeKind.Utc).AddTicks(6224), new DateTime(2020, 5, 31, 8, 24, 10, 236, DateTimeKind.Utc).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 24, 10, 236, DateTimeKind.Utc).AddTicks(6228), new DateTime(2020, 5, 31, 8, 24, 10, 236, DateTimeKind.Utc).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 24, 10, 238, DateTimeKind.Utc).AddTicks(3249), new DateTime(2020, 5, 31, 8, 24, 10, 238, DateTimeKind.Utc).AddTicks(3676) });
        }
    }
}
