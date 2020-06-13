using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Storage_And_Categories_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(7332), 1, false, "Trái Cây Việt", new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(7749) },
                    { 2, new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(9346), 2, false, "Trái Cây Nhập", new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(9377) },
                    { 3, new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(9412), 3, false, "Trái Cây Sấy Khô", new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(9413) },
                    { 4, new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(9416), 4, false, "Mứt Trái Cây>", new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(9417) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 38, 7, 128, DateTimeKind.Utc).AddTicks(5029), new DateTime(2020, 6, 13, 12, 38, 7, 128, DateTimeKind.Utc).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 38, 7, 128, DateTimeKind.Utc).AddTicks(6464), new DateTime(2020, 6, 13, 12, 38, 7, 128, DateTimeKind.Utc).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 38, 7, 128, DateTimeKind.Utc).AddTicks(6518), new DateTime(2020, 6, 13, 12, 38, 7, 128, DateTimeKind.Utc).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 38, 7, 128, DateTimeKind.Utc).AddTicks(6521), new DateTime(2020, 6, 13, 12, 38, 7, 128, DateTimeKind.Utc).AddTicks(6522) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Location", "Name", "Size", "SizeUnit", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(4584), false, "Tiểu Vương Quốc Bình Chánh", "Hoàng Khố", 1000.2, "m2", new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(5057) });
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

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 37, 30, 306, DateTimeKind.Utc).AddTicks(458), new DateTime(2020, 6, 13, 12, 37, 30, 306, DateTimeKind.Utc).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 37, 30, 306, DateTimeKind.Utc).AddTicks(3137), new DateTime(2020, 6, 13, 12, 37, 30, 306, DateTimeKind.Utc).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 37, 30, 306, DateTimeKind.Utc).AddTicks(3256), new DateTime(2020, 6, 13, 12, 37, 30, 306, DateTimeKind.Utc).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 37, 30, 306, DateTimeKind.Utc).AddTicks(3262), new DateTime(2020, 6, 13, 12, 37, 30, 306, DateTimeKind.Utc).AddTicks(3264) });
        }
    }
}
