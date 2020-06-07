using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Change_Name_ClassifyProductReport_To_ProductTierTransferReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassifyProductReports");

            migrationBuilder.CreateTable(
                name: "ProductTierTransferReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromTierId = table.Column<int>(nullable: false),
                    ToTierId = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTierTransferReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTierTransferReports_StorageManagers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "StorageManagers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductTierTransferReports_ProductTiers_ToTierId",
                        column: x => x.ToTierId,
                        principalTable: "ProductTiers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(7499), new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(8924), new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(8971), new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(8975), new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(9343), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(460), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(497), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(500), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(505), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(509), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(513), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(516), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(520), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(524), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(528), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(532), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(535), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(539), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(543), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(547), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(551), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(555), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(558), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(562), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(566), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(570), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(574), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(1765), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(3938), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(3999), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4004), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4008), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4011), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4015), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4019), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4023), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4027), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4031), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4034), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4038), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4043), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4047), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4051), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4055), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4058), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4062), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4066), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4070), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4073), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4077), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 496, DateTimeKind.Utc).AddTicks(7647), new DateTime(2020, 6, 7, 8, 57, 23, 496, DateTimeKind.Utc).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 496, DateTimeKind.Utc).AddTicks(8869), new DateTime(2020, 6, 7, 8, 57, 23, 496, DateTimeKind.Utc).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 496, DateTimeKind.Utc).AddTicks(8916), new DateTime(2020, 6, 7, 8, 57, 23, 496, DateTimeKind.Utc).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 496, DateTimeKind.Utc).AddTicks(8919), new DateTime(2020, 6, 7, 8, 57, 23, 496, DateTimeKind.Utc).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(4886), new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(5296) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTierTransferReports_CreatedBy",
                table: "ProductTierTransferReports",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTierTransferReports_ToTierId",
                table: "ProductTierTransferReports",
                column: "ToTierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTierTransferReports");

            migrationBuilder.CreateTable(
                name: "ClassifyProductReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    FromTierId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    ToTierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassifyProductReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassifyProductReports_StorageManagers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "StorageManagers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClassifyProductReports_ProductTiers_ToTierId",
                        column: x => x.ToTierId,
                        principalTable: "ProductTiers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 371, DateTimeKind.Utc).AddTicks(7127), new DateTime(2020, 6, 7, 8, 54, 58, 371, DateTimeKind.Utc).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 372, DateTimeKind.Utc).AddTicks(74), new DateTime(2020, 6, 7, 8, 54, 58, 372, DateTimeKind.Utc).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 372, DateTimeKind.Utc).AddTicks(152), new DateTime(2020, 6, 7, 8, 54, 58, 372, DateTimeKind.Utc).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 372, DateTimeKind.Utc).AddTicks(181), new DateTime(2020, 6, 7, 8, 54, 58, 372, DateTimeKind.Utc).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(9967), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1226), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1262), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1267), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1270), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1274), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1278), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1281), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1285), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1288), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1292), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1296), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1300), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1303), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1304) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1307), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1308) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1310), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1314), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1336), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1340), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1344), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1347), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1351), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1354), new DateTime(2020, 6, 7, 8, 54, 58, 374, DateTimeKind.Utc).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 372, DateTimeKind.Utc).AddTicks(5901), new DateTime(2020, 6, 7, 8, 54, 58, 372, DateTimeKind.Utc).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(79), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(192), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(195) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(200), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(207), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(214), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(220), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(227), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(233), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(239), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(246), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(253), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(260), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(267), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(273), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(280), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(287), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(293), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(299), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(305), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(312), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(318), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(324), new DateTime(2020, 6, 7, 8, 54, 58, 373, DateTimeKind.Utc).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 368, DateTimeKind.Utc).AddTicks(9068), new DateTime(2020, 6, 7, 8, 54, 58, 368, DateTimeKind.Utc).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 369, DateTimeKind.Utc).AddTicks(575), new DateTime(2020, 6, 7, 8, 54, 58, 369, DateTimeKind.Utc).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 369, DateTimeKind.Utc).AddTicks(628), new DateTime(2020, 6, 7, 8, 54, 58, 369, DateTimeKind.Utc).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 369, DateTimeKind.Utc).AddTicks(631), new DateTime(2020, 6, 7, 8, 54, 58, 369, DateTimeKind.Utc).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 54, 58, 371, DateTimeKind.Utc).AddTicks(4029), new DateTime(2020, 6, 7, 8, 54, 58, 371, DateTimeKind.Utc).AddTicks(4552) });

            migrationBuilder.CreateIndex(
                name: "IX_ClassifyProductReports_CreatedBy",
                table: "ClassifyProductReports",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ClassifyProductReports_ToTierId",
                table: "ClassifyProductReports",
                column: "ToTierId");
        }
    }
}
