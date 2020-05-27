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

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Location", "Name", "Size", "SizeUnit", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2020, 5, 28, 8, 0, 50, 486, DateTimeKind.Utc).AddTicks(9127), 3, false, "Tiểu Vương Quốc Bình Chánh", "Hoàng Khố", 1000.2, "m2", new DateTime(2020, 5, 28, 8, 0, 50, 486, DateTimeKind.Utc).AddTicks(9531), null });
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
                values: new object[] { new DateTime(2020, 5, 28, 7, 59, 20, 351, DateTimeKind.Utc).AddTicks(2745), new DateTime(2020, 5, 28, 7, 59, 20, 351, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 7, 59, 20, 351, DateTimeKind.Utc).AddTicks(4035), new DateTime(2020, 5, 28, 7, 59, 20, 351, DateTimeKind.Utc).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 7, 59, 20, 351, DateTimeKind.Utc).AddTicks(4124), new DateTime(2020, 5, 28, 7, 59, 20, 351, DateTimeKind.Utc).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 7, 59, 20, 351, DateTimeKind.Utc).AddTicks(4128), new DateTime(2020, 5, 28, 7, 59, 20, 351, DateTimeKind.Utc).AddTicks(4129) });
        }
    }
}
