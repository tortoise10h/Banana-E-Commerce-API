using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Add_Field_Product_Unit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Quantity",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Unit",
                table: "Products",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(994), new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(2113), new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(2157), new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(2161), new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(2164), new DateTime(2020, 5, 17, 5, 4, 37, 898, DateTimeKind.Utc).AddTicks(2165) });
        }
    }
}
