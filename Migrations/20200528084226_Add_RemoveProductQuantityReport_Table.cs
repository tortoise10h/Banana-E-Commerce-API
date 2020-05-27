using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Add_RemoveProductQuantityReport_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RemoveProductQuantityReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    ProductTierId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemoveProductQuantityReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RemoveProductQuantityReports_StorageManagers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "StorageManagers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RemoveProductQuantityReports_ProductTiers_ProductTierId",
                        column: x => x.ProductTierId,
                        principalTable: "ProductTiers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 929, DateTimeKind.Utc).AddTicks(2585), new DateTime(2020, 5, 28, 8, 42, 24, 929, DateTimeKind.Utc).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 929, DateTimeKind.Utc).AddTicks(4453), new DateTime(2020, 5, 28, 8, 42, 24, 929, DateTimeKind.Utc).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 929, DateTimeKind.Utc).AddTicks(4524), new DateTime(2020, 5, 28, 8, 42, 24, 929, DateTimeKind.Utc).AddTicks(4526) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 929, DateTimeKind.Utc).AddTicks(4530), new DateTime(2020, 5, 28, 8, 42, 24, 929, DateTimeKind.Utc).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(4100), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5697), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5732), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5736), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5739), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5743), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5746), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5750), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5753), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5757), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5761), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5764), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5768), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5772), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5775), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5780), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5783), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5787), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5791), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5794), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5797), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5801), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5804), new DateTime(2020, 5, 28, 8, 42, 24, 931, DateTimeKind.Utc).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(950), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5823), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5898), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5904), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5908), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5913), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5917), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5921), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5925), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5928), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5932), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5937), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5941), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5945), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5949), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5953), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5957), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5961), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5965), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5969), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5973), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5978), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(6012), new DateTime(2020, 5, 28, 8, 42, 24, 930, DateTimeKind.Utc).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 926, DateTimeKind.Utc).AddTicks(6297), new DateTime(2020, 5, 28, 8, 42, 24, 926, DateTimeKind.Utc).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 926, DateTimeKind.Utc).AddTicks(7462), new DateTime(2020, 5, 28, 8, 42, 24, 926, DateTimeKind.Utc).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 926, DateTimeKind.Utc).AddTicks(7520), new DateTime(2020, 5, 28, 8, 42, 24, 926, DateTimeKind.Utc).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 926, DateTimeKind.Utc).AddTicks(7523), new DateTime(2020, 5, 28, 8, 42, 24, 926, DateTimeKind.Utc).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 42, 24, 928, DateTimeKind.Utc).AddTicks(5694), new DateTime(2020, 5, 28, 8, 42, 24, 928, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.CreateIndex(
                name: "IX_RemoveProductQuantityReports_CreatedBy",
                table: "RemoveProductQuantityReports",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RemoveProductQuantityReports_ProductTierId",
                table: "RemoveProductQuantityReports",
                column: "ProductTierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RemoveProductQuantityReports");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 954, DateTimeKind.Utc).AddTicks(6148), new DateTime(2020, 5, 28, 8, 36, 29, 954, DateTimeKind.Utc).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 954, DateTimeKind.Utc).AddTicks(7438), new DateTime(2020, 5, 28, 8, 36, 29, 954, DateTimeKind.Utc).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 954, DateTimeKind.Utc).AddTicks(7492), new DateTime(2020, 5, 28, 8, 36, 29, 954, DateTimeKind.Utc).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 954, DateTimeKind.Utc).AddTicks(7496), new DateTime(2020, 5, 28, 8, 36, 29, 954, DateTimeKind.Utc).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(8237), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9345), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9378), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9382), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9386), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9407), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9410), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9413), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9417), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9421), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9424), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9428), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9433), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9436), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9440), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9443), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9447), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9451), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9454), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9458), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9461), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9465), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9472), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(292), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2839), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2904), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2910), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2914), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2918), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2923), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2927), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2928) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2931), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2936), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2940), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2944), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2948), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2952), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2956), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2960), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2964), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2969), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2972), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2976), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2980), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2984), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2988), new DateTime(2020, 5, 28, 8, 36, 29, 955, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 952, DateTimeKind.Utc).AddTicks(4974), new DateTime(2020, 5, 28, 8, 36, 29, 952, DateTimeKind.Utc).AddTicks(5484) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 952, DateTimeKind.Utc).AddTicks(6344), new DateTime(2020, 5, 28, 8, 36, 29, 952, DateTimeKind.Utc).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 952, DateTimeKind.Utc).AddTicks(6409), new DateTime(2020, 5, 28, 8, 36, 29, 952, DateTimeKind.Utc).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 952, DateTimeKind.Utc).AddTicks(6413), new DateTime(2020, 5, 28, 8, 36, 29, 952, DateTimeKind.Utc).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 36, 29, 954, DateTimeKind.Utc).AddTicks(3511), new DateTime(2020, 5, 28, 8, 36, 29, 954, DateTimeKind.Utc).AddTicks(3914) });
        }
    }
}
