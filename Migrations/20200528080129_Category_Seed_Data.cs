using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Category_Seed_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 28, 8, 1, 28, 269, DateTimeKind.Utc).AddTicks(8774), 1, false, "Trái Cây Việt", new DateTime(2020, 5, 28, 8, 1, 28, 269, DateTimeKind.Utc).AddTicks(9139) },
                    { 2, new DateTime(2020, 5, 28, 8, 1, 28, 270, DateTimeKind.Utc).AddTicks(81), 2, false, "Trái Cây Nhập", new DateTime(2020, 5, 28, 8, 1, 28, 270, DateTimeKind.Utc).AddTicks(105) },
                    { 3, new DateTime(2020, 5, 28, 8, 1, 28, 270, DateTimeKind.Utc).AddTicks(133), 3, false, "Trái Cây Sấy Khô", new DateTime(2020, 5, 28, 8, 1, 28, 270, DateTimeKind.Utc).AddTicks(134) },
                    { 4, new DateTime(2020, 5, 28, 8, 1, 28, 270, DateTimeKind.Utc).AddTicks(137), 4, false, "Mứt Trái Cây>", new DateTime(2020, 5, 28, 8, 1, 28, 270, DateTimeKind.Utc).AddTicks(138) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 1, 28, 267, DateTimeKind.Utc).AddTicks(7733), new DateTime(2020, 5, 28, 8, 1, 28, 267, DateTimeKind.Utc).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 1, 28, 267, DateTimeKind.Utc).AddTicks(9042), new DateTime(2020, 5, 28, 8, 1, 28, 267, DateTimeKind.Utc).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 1, 28, 267, DateTimeKind.Utc).AddTicks(9102), new DateTime(2020, 5, 28, 8, 1, 28, 267, DateTimeKind.Utc).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 1, 28, 267, DateTimeKind.Utc).AddTicks(9106), new DateTime(2020, 5, 28, 8, 1, 28, 267, DateTimeKind.Utc).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 1, 28, 269, DateTimeKind.Utc).AddTicks(6130), new DateTime(2020, 5, 28, 8, 1, 28, 269, DateTimeKind.Utc).AddTicks(6542) });
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
                values: new object[] { new DateTime(2020, 5, 28, 8, 0, 50, 485, DateTimeKind.Utc).AddTicks(2602), new DateTime(2020, 5, 28, 8, 0, 50, 485, DateTimeKind.Utc).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 0, 50, 485, DateTimeKind.Utc).AddTicks(3743), new DateTime(2020, 5, 28, 8, 0, 50, 485, DateTimeKind.Utc).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 0, 50, 485, DateTimeKind.Utc).AddTicks(3789), new DateTime(2020, 5, 28, 8, 0, 50, 485, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 0, 50, 485, DateTimeKind.Utc).AddTicks(3792), new DateTime(2020, 5, 28, 8, 0, 50, 485, DateTimeKind.Utc).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 0, 50, 486, DateTimeKind.Utc).AddTicks(9127), new DateTime(2020, 5, 28, 8, 0, 50, 486, DateTimeKind.Utc).AddTicks(9531) });
        }
    }
}
