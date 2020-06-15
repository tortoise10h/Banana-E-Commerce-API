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
                    { 1, new DateTime(2020, 6, 15, 0, 2, 20, 614, DateTimeKind.Utc).AddTicks(4831), 1, false, "Trái Cây Việt", new DateTime(2020, 6, 15, 0, 2, 20, 614, DateTimeKind.Utc).AddTicks(5807) },
                    { 2, new DateTime(2020, 6, 15, 0, 2, 20, 614, DateTimeKind.Utc).AddTicks(8368), 2, false, "Trái Cây Nhập", new DateTime(2020, 6, 15, 0, 2, 20, 614, DateTimeKind.Utc).AddTicks(8431) },
                    { 3, new DateTime(2020, 6, 15, 0, 2, 20, 614, DateTimeKind.Utc).AddTicks(8491), 3, false, "Trái Cây Sấy Khô", new DateTime(2020, 6, 15, 0, 2, 20, 614, DateTimeKind.Utc).AddTicks(8495) },
                    { 4, new DateTime(2020, 6, 15, 0, 2, 20, 614, DateTimeKind.Utc).AddTicks(8500), 4, false, "Mứt Trái Cây>", new DateTime(2020, 6, 15, 0, 2, 20, 614, DateTimeKind.Utc).AddTicks(8503) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 2, 20, 609, DateTimeKind.Utc).AddTicks(8085), new DateTime(2020, 6, 15, 0, 2, 20, 609, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 2, 20, 610, DateTimeKind.Utc).AddTicks(1151), new DateTime(2020, 6, 15, 0, 2, 20, 610, DateTimeKind.Utc).AddTicks(1182) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 2, 20, 610, DateTimeKind.Utc).AddTicks(1264), new DateTime(2020, 6, 15, 0, 2, 20, 610, DateTimeKind.Utc).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 2, 20, 610, DateTimeKind.Utc).AddTicks(1271), new DateTime(2020, 6, 15, 0, 2, 20, 610, DateTimeKind.Utc).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 2, 20, 613, DateTimeKind.Utc).AddTicks(8560), new DateTime(2020, 6, 15, 0, 2, 20, 613, DateTimeKind.Utc).AddTicks(9620) });
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
                values: new object[] { new DateTime(2020, 6, 15, 0, 0, 54, 493, DateTimeKind.Utc).AddTicks(5411), new DateTime(2020, 6, 15, 0, 0, 54, 493, DateTimeKind.Utc).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 0, 54, 493, DateTimeKind.Utc).AddTicks(6666), new DateTime(2020, 6, 15, 0, 0, 54, 493, DateTimeKind.Utc).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 0, 54, 493, DateTimeKind.Utc).AddTicks(6717), new DateTime(2020, 6, 15, 0, 0, 54, 493, DateTimeKind.Utc).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 0, 54, 493, DateTimeKind.Utc).AddTicks(6721), new DateTime(2020, 6, 15, 0, 0, 54, 493, DateTimeKind.Utc).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 0, 54, 495, DateTimeKind.Utc).AddTicks(2163), new DateTime(2020, 6, 15, 0, 0, 54, 495, DateTimeKind.Utc).AddTicks(2846) });
        }
    }
}
