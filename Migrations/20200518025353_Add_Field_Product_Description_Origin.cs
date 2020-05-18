using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Add_Field_Product_Description_Origin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StorageManagers_UserId",
                table: "StorageManagers");

            migrationBuilder.DropIndex(
                name: "IX_Admins_UserId",
                table: "Admins");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Origin",
                table: "Products",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 18, 2, 53, 52, 663, DateTimeKind.Utc).AddTicks(7158), new DateTime(2020, 5, 18, 2, 53, 52, 663, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 18, 2, 53, 52, 663, DateTimeKind.Utc).AddTicks(9490), new DateTime(2020, 5, 18, 2, 53, 52, 663, DateTimeKind.Utc).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 18, 2, 53, 52, 663, DateTimeKind.Utc).AddTicks(9573), new DateTime(2020, 5, 18, 2, 53, 52, 663, DateTimeKind.Utc).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 18, 2, 53, 52, 663, DateTimeKind.Utc).AddTicks(9578), new DateTime(2020, 5, 18, 2, 53, 52, 663, DateTimeKind.Utc).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 18, 2, 53, 52, 663, DateTimeKind.Utc).AddTicks(9583), new DateTime(2020, 5, 18, 2, 53, 52, 663, DateTimeKind.Utc).AddTicks(9585) });

            migrationBuilder.CreateIndex(
                name: "IX_StorageManagers_UserId",
                table: "StorageManagers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StorageManagers_UserId",
                table: "StorageManagers");

            migrationBuilder.DropIndex(
                name: "IX_Admins_UserId",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Origin",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 33, 44, 397, DateTimeKind.Utc).AddTicks(701), new DateTime(2020, 5, 17, 15, 33, 44, 397, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 33, 44, 397, DateTimeKind.Utc).AddTicks(1841), new DateTime(2020, 5, 17, 15, 33, 44, 397, DateTimeKind.Utc).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 33, 44, 397, DateTimeKind.Utc).AddTicks(1883), new DateTime(2020, 5, 17, 15, 33, 44, 397, DateTimeKind.Utc).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 33, 44, 397, DateTimeKind.Utc).AddTicks(1886), new DateTime(2020, 5, 17, 15, 33, 44, 397, DateTimeKind.Utc).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 33, 44, 397, DateTimeKind.Utc).AddTicks(1889), new DateTime(2020, 5, 17, 15, 33, 44, 397, DateTimeKind.Utc).AddTicks(1890) });

            migrationBuilder.CreateIndex(
                name: "IX_StorageManagers_UserId",
                table: "StorageManagers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId");
        }
    }
}
