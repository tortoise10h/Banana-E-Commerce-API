using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Add_ClassifyProductReport_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassifyProductReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromTierId = table.Column<int>(nullable: false),
                    ToTierId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_ClassifyProductReports_CreatedBy",
                table: "ClassifyProductReports",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ClassifyProductReports_ToTierId",
                table: "ClassifyProductReports",
                column: "ToTierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassifyProductReports");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 707, DateTimeKind.Utc).AddTicks(7189), new DateTime(2020, 5, 28, 8, 9, 58, 707, DateTimeKind.Utc).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 707, DateTimeKind.Utc).AddTicks(8670), new DateTime(2020, 5, 28, 8, 9, 58, 707, DateTimeKind.Utc).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 707, DateTimeKind.Utc).AddTicks(8726), new DateTime(2020, 5, 28, 8, 9, 58, 707, DateTimeKind.Utc).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 707, DateTimeKind.Utc).AddTicks(8765), new DateTime(2020, 5, 28, 8, 9, 58, 707, DateTimeKind.Utc).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(4303), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5616), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5662), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5666), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5670), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5675), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5678), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5682), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5686), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5690), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5694), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5698), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5702), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5706), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5710), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5714), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5739), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5743), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5747), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5751), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5755), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5759), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5763), new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(2106), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4853), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4921), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4926), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4930), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4935), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4936) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4939), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4943), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4947), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4951), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4955), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4959), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4963), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4967), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4971), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4975), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4979), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4984), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4988), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4992), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4996), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(5000), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(5004), new DateTime(2020, 5, 28, 8, 9, 58, 708, DateTimeKind.Utc).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 700, DateTimeKind.Utc).AddTicks(5920), new DateTime(2020, 5, 28, 8, 9, 58, 700, DateTimeKind.Utc).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 700, DateTimeKind.Utc).AddTicks(7510), new DateTime(2020, 5, 28, 8, 9, 58, 700, DateTimeKind.Utc).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 700, DateTimeKind.Utc).AddTicks(7564), new DateTime(2020, 5, 28, 8, 9, 58, 700, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 700, DateTimeKind.Utc).AddTicks(7567), new DateTime(2020, 5, 28, 8, 9, 58, 700, DateTimeKind.Utc).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 58, 707, DateTimeKind.Utc).AddTicks(3979), new DateTime(2020, 5, 28, 8, 9, 58, 707, DateTimeKind.Utc).AddTicks(4473) });
        }
    }
}
