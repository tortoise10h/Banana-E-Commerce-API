using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class ProductTier_Seed_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ProductTiers",
                columns: new[] { "Id", "AfterDiscountPrice", "CreatedAt", "DiscountPercentage", "IsDeleted", "KgSale", "PriceCurrency", "PricePerKg", "ProductId", "Quantity", "SalePrice", "TierId", "UpdatedAt" },
                values: new object[,]
                {
                    { 23, 300000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5763), 0, false, 1.0, 1, 300000.0, 1, 50.0, 300000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5764) },
                    { 22, 230000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5759), 0, false, 1.0, 1, 230000.0, 1, 50.0, 230000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5760) },
                    { 21, 900000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5755), 0, false, 3.0, 1, 900000.0, 1, 50.0, 900000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5756) },
                    { 20, 400000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5751), 0, false, 0.5, 1, 400000.0, 1, 50.0, 400000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5752) },
                    { 19, 700000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5747), 0, false, 1.0, 1, 700000.0, 1, 50.0, 700000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5748) },
                    { 18, 330000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5743), 0, false, 1.0, 1, 330000.0, 1, 50.0, 330000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5744) },
                    { 17, 480000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5739), 0, false, 1.0, 1, 480000.0, 1, 50.0, 480000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5740) },
                    { 16, 400000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5714), 0, false, 1.0, 1, 400000.0, 1, 50.0, 400000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5715) },
                    { 15, 700000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5710), 0, false, 1.0, 1, 700000.0, 1, 50.0, 700000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5711) },
                    { 1, 100000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(4303), 0, false, 1.0, 1, 100000.0, 1, 57.0, 100000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(4757) },
                    { 13, 100000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5702), 0, false, 1.0, 1, 100000.0, 1, 50.0, 100000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5703) },
                    { 4, 130000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5666), 0, false, 1.0, 1, 130000.0, 1, 39.0, 130000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5668) },
                    { 14, 620000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5706), 0, false, 1.0, 1, 620000.0, 1, 50.0, 620000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5707) },
                    { 3, 243000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5662), 0, false, 2.7000000000000002, 1, 90000.0, 1, 62.0, 243000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5663) },
                    { 5, 45000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5670), 0, false, 1.0, 1, 45000.0, 1, 50.0, 45000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5672) },
                    { 6, 80000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5675), 0, false, 1.0, 1, 80000.0, 1, 50.0, 80000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5676) },
                    { 2, 100000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5616), 0, false, 1.0, 1, 110000.0, 1, 50.0, 110000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5635) },
                    { 8, 65000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5682), 0, false, 1.0, 1, 65000.0, 1, 50.0, 65000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5684) },
                    { 9, 66000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5686), 0, false, 1.0, 1, 66000.0, 1, 50.0, 66000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5688) },
                    { 10, 58000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5690), 0, false, 1.0, 1, 58000.0, 1, 50.0, 58000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5692) },
                    { 11, 260000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5694), 0, false, 1.0, 1, 260000.0, 1, 50.0, 260000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5696) },
                    { 12, 70000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5698), 0, false, 1.0, 1, 70000.0, 1, 50.0, 70000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5700) },
                    { 7, 75000.0, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5678), 0, false, 1.0, 1, 75000.0, 1, 50.0, 75000.0, 1, new DateTime(2020, 5, 28, 8, 9, 58, 709, DateTimeKind.Utc).AddTicks(5680) }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(5121), new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(6576), new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(6633), new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(6637), new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(9675), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1809), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1875), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1881), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1885), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1889), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1893), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1897), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1902), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1906), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1910), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1915), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1919), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2018), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2022), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2026), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2029), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2033), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2036), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2040), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2043), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2047), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2051), new DateTime(2020, 5, 28, 8, 9, 8, 737, DateTimeKind.Utc).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 734, DateTimeKind.Utc).AddTicks(4049), new DateTime(2020, 5, 28, 8, 9, 8, 734, DateTimeKind.Utc).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 734, DateTimeKind.Utc).AddTicks(5231), new DateTime(2020, 5, 28, 8, 9, 8, 734, DateTimeKind.Utc).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 734, DateTimeKind.Utc).AddTicks(5283), new DateTime(2020, 5, 28, 8, 9, 8, 734, DateTimeKind.Utc).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 734, DateTimeKind.Utc).AddTicks(5287), new DateTime(2020, 5, 28, 8, 9, 8, 734, DateTimeKind.Utc).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(1128), new DateTime(2020, 5, 28, 8, 9, 8, 736, DateTimeKind.Utc).AddTicks(2434) });
        }
    }
}
