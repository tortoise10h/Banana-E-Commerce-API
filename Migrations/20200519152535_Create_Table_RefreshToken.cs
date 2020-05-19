using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Create_Table_RefreshToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Token = table.Column<string>(nullable: false),
                    JwtId = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    IsUsed = table.Column<bool>(nullable: false),
                    IsValidated = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Token);
                    table.ForeignKey(
                        name: "FK_RefreshToken_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 589, DateTimeKind.Utc).AddTicks(9040), new DateTime(2020, 5, 19, 15, 25, 34, 589, DateTimeKind.Utc).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(478), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(534), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(538), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(4118), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(5990), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6069), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6074), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6078), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6082), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6086), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6091), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6115), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6120), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6124), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6128), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6132), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6136), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6140), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6143), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6147), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6151), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6154), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6158), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6162), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6165), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6169), new DateTime(2020, 5, 19, 15, 25, 34, 590, DateTimeKind.Utc).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 587, DateTimeKind.Utc).AddTicks(8692), new DateTime(2020, 5, 19, 15, 25, 34, 587, DateTimeKind.Utc).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 587, DateTimeKind.Utc).AddTicks(9867), new DateTime(2020, 5, 19, 15, 25, 34, 587, DateTimeKind.Utc).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 587, DateTimeKind.Utc).AddTicks(9925), new DateTime(2020, 5, 19, 15, 25, 34, 587, DateTimeKind.Utc).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 587, DateTimeKind.Utc).AddTicks(9928), new DateTime(2020, 5, 19, 15, 25, 34, 587, DateTimeKind.Utc).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 587, DateTimeKind.Utc).AddTicks(9931), new DateTime(2020, 5, 19, 15, 25, 34, 587, DateTimeKind.Utc).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 15, 25, 34, 589, DateTimeKind.Utc).AddTicks(6437), new DateTime(2020, 5, 19, 15, 25, 34, 589, DateTimeKind.Utc).AddTicks(6842) });

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefreshToken");

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
