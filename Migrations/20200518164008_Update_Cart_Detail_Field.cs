using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Update_Cart_Detail_Field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "CartDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "CartDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 18, 16, 40, 7, 543, DateTimeKind.Utc).AddTicks(9351), new DateTime(2020, 5, 18, 16, 40, 7, 544, DateTimeKind.Utc).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 18, 16, 40, 7, 544, DateTimeKind.Utc).AddTicks(1668), new DateTime(2020, 5, 18, 16, 40, 7, 544, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 18, 16, 40, 7, 544, DateTimeKind.Utc).AddTicks(1730), new DateTime(2020, 5, 18, 16, 40, 7, 544, DateTimeKind.Utc).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 18, 16, 40, 7, 544, DateTimeKind.Utc).AddTicks(1735), new DateTime(2020, 5, 18, 16, 40, 7, 544, DateTimeKind.Utc).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 18, 16, 40, 7, 544, DateTimeKind.Utc).AddTicks(1740), new DateTime(2020, 5, 18, 16, 40, 7, 544, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Location", "Name", "Size", "SizeUnit", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2020, 5, 18, 16, 40, 7, 547, DateTimeKind.Utc).AddTicks(5914), 3, false, "Tiểu Vương Quốc Bình Chánh", "Hoàng Khố", 1000.2, "m2", new DateTime(2020, 5, 18, 16, 40, 7, 547, DateTimeKind.Utc).AddTicks(6761), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "CartDetails");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "CartDetails");

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
        }
    }
}
