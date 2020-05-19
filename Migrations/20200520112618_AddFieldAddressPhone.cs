using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class AddFieldAddressPhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Addresses",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 11, 26, 17, 569, DateTimeKind.Utc).AddTicks(3507), new DateTime(2020, 5, 20, 11, 26, 17, 569, DateTimeKind.Utc).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 11, 26, 17, 569, DateTimeKind.Utc).AddTicks(4539), new DateTime(2020, 5, 20, 11, 26, 17, 569, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 11, 26, 17, 569, DateTimeKind.Utc).AddTicks(4659), new DateTime(2020, 5, 20, 11, 26, 17, 569, DateTimeKind.Utc).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 11, 26, 17, 569, DateTimeKind.Utc).AddTicks(4661), new DateTime(2020, 5, 20, 11, 26, 17, 569, DateTimeKind.Utc).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 569, DateTimeKind.Local).AddTicks(7154), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6122), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6174), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6175) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6231), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6235), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6238), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6241), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6244), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6246), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6249), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6253), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6256), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6259), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6262), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6265), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6268), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6271), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6274), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6277), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6280), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6281) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6284), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6287), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6290), new DateTime(2020, 5, 20, 18, 26, 17, 570, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 11, 26, 17, 567, DateTimeKind.Utc).AddTicks(9567), new DateTime(2020, 5, 20, 11, 26, 17, 567, DateTimeKind.Utc).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 11, 26, 17, 568, DateTimeKind.Utc).AddTicks(407), new DateTime(2020, 5, 20, 11, 26, 17, 568, DateTimeKind.Utc).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 11, 26, 17, 568, DateTimeKind.Utc).AddTicks(444), new DateTime(2020, 5, 20, 11, 26, 17, 568, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 11, 26, 17, 568, DateTimeKind.Utc).AddTicks(446), new DateTime(2020, 5, 20, 11, 26, 17, 568, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 11, 26, 17, 568, DateTimeKind.Utc).AddTicks(448), new DateTime(2020, 5, 20, 11, 26, 17, 568, DateTimeKind.Utc).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 11, 26, 17, 569, DateTimeKind.Utc).AddTicks(1633), new DateTime(2020, 5, 20, 11, 26, 17, 569, DateTimeKind.Utc).AddTicks(1922) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Addresses");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(6648), new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(8337), new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(8407), new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(8411), new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 908, DateTimeKind.Local).AddTicks(2142), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3497), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3562), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3568), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3572), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3577), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3581), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3585), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3590), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3595), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3599), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3603), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3608), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3612), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3616), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3620), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3626), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3630), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3634), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3638), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3643), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3647), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3651), new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(3301), new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(4462), new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(4512), new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(4515), new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(4517), new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(4519) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(2497), new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(3222) });
        }
    }
}
