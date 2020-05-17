using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Change_Field_Product_Unit_Name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductUnit",
                table: "Products",
                nullable: false,
                defaultValue: 0);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductUnit",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Unit",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 41, 30, 795, DateTimeKind.Utc).AddTicks(3438), new DateTime(2020, 5, 17, 14, 41, 30, 795, DateTimeKind.Utc).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 41, 30, 795, DateTimeKind.Utc).AddTicks(4826), new DateTime(2020, 5, 17, 14, 41, 30, 795, DateTimeKind.Utc).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 41, 30, 795, DateTimeKind.Utc).AddTicks(4902), new DateTime(2020, 5, 17, 14, 41, 30, 795, DateTimeKind.Utc).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 41, 30, 795, DateTimeKind.Utc).AddTicks(4906), new DateTime(2020, 5, 17, 14, 41, 30, 795, DateTimeKind.Utc).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 41, 30, 795, DateTimeKind.Utc).AddTicks(4909), new DateTime(2020, 5, 17, 14, 41, 30, 795, DateTimeKind.Utc).AddTicks(4910) });
        }
    }
}
