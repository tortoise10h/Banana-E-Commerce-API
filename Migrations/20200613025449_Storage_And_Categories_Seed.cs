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
                    { 1, new DateTime(2020, 6, 13, 2, 54, 48, 582, DateTimeKind.Utc).AddTicks(9408), 1, false, "Trái Cây Việt", new DateTime(2020, 6, 13, 2, 54, 48, 582, DateTimeKind.Utc).AddTicks(9769) },
                    { 2, new DateTime(2020, 6, 13, 2, 54, 48, 583, DateTimeKind.Utc).AddTicks(744), 2, false, "Trái Cây Nhập", new DateTime(2020, 6, 13, 2, 54, 48, 583, DateTimeKind.Utc).AddTicks(770) },
                    { 3, new DateTime(2020, 6, 13, 2, 54, 48, 583, DateTimeKind.Utc).AddTicks(799), 3, false, "Trái Cây Sấy Khô", new DateTime(2020, 6, 13, 2, 54, 48, 583, DateTimeKind.Utc).AddTicks(801) },
                    { 4, new DateTime(2020, 6, 13, 2, 54, 48, 583, DateTimeKind.Utc).AddTicks(803), 4, false, "Mứt Trái Cây>", new DateTime(2020, 6, 13, 2, 54, 48, 583, DateTimeKind.Utc).AddTicks(804) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 54, 48, 580, DateTimeKind.Utc).AddTicks(9165), new DateTime(2020, 6, 13, 2, 54, 48, 580, DateTimeKind.Utc).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 54, 48, 581, DateTimeKind.Utc).AddTicks(361), new DateTime(2020, 6, 13, 2, 54, 48, 581, DateTimeKind.Utc).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 54, 48, 581, DateTimeKind.Utc).AddTicks(411), new DateTime(2020, 6, 13, 2, 54, 48, 581, DateTimeKind.Utc).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 54, 48, 581, DateTimeKind.Utc).AddTicks(414), new DateTime(2020, 6, 13, 2, 54, 48, 581, DateTimeKind.Utc).AddTicks(415) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Location", "Name", "Size", "SizeUnit", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2020, 6, 13, 2, 54, 48, 582, DateTimeKind.Utc).AddTicks(6993), false, "Tiểu Vương Quốc Bình Chánh", "Hoàng Khố", 1000.2, "m2", new DateTime(2020, 6, 13, 2, 54, 48, 582, DateTimeKind.Utc).AddTicks(7407) });
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
                values: new object[] { new DateTime(2020, 6, 13, 2, 53, 41, 46, DateTimeKind.Utc).AddTicks(4431), new DateTime(2020, 6, 13, 2, 53, 41, 46, DateTimeKind.Utc).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 53, 41, 46, DateTimeKind.Utc).AddTicks(5682), new DateTime(2020, 6, 13, 2, 53, 41, 46, DateTimeKind.Utc).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 53, 41, 46, DateTimeKind.Utc).AddTicks(5727), new DateTime(2020, 6, 13, 2, 53, 41, 46, DateTimeKind.Utc).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 53, 41, 46, DateTimeKind.Utc).AddTicks(5730), new DateTime(2020, 6, 13, 2, 53, 41, 46, DateTimeKind.Utc).AddTicks(5731) });
        }
    }
}
