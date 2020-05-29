using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class ProductTiers_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 228, DateTimeKind.Utc).AddTicks(808), new DateTime(2020, 5, 31, 8, 29, 44, 228, DateTimeKind.Utc).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 228, DateTimeKind.Utc).AddTicks(3583), new DateTime(2020, 5, 31, 8, 29, 44, 228, DateTimeKind.Utc).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 228, DateTimeKind.Utc).AddTicks(3682), new DateTime(2020, 5, 31, 8, 29, 44, 228, DateTimeKind.Utc).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 228, DateTimeKind.Utc).AddTicks(3690), new DateTime(2020, 5, 31, 8, 29, 44, 228, DateTimeKind.Utc).AddTicks(3692) });

            migrationBuilder.InsertData(
                table: "ProductTiers",
                columns: new[] { "Id", "AfterDiscountPrice", "CreatedAt", "DiscountPercentage", "IsDeleted", "KgSale", "PriceCurrency", "PricePerKg", "ProductId", "Quantity", "SalePrice", "TierId", "UpdatedAt" },
                values: new object[,]
                {
                    { 23, 300000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6838), 0, false, 1.0, 1, 300000.0, 23, 50.0, 300000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6840) },
                    { 22, 230000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6831), 0, false, 1.0, 1, 230000.0, 22, 50.0, 230000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6833) },
                    { 21, 900000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6824), 0, false, 3.0, 1, 900000.0, 21, 50.0, 900000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6826) },
                    { 20, 400000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6818), 0, false, 0.5, 1, 400000.0, 20, 50.0, 400000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6820) },
                    { 19, 700000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6807), 0, false, 1.0, 1, 700000.0, 19, 50.0, 700000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6810) },
                    { 18, 330000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6801), 0, false, 1.0, 1, 330000.0, 18, 50.0, 330000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6803) },
                    { 17, 480000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6795), 0, false, 1.0, 1, 480000.0, 17, 50.0, 480000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6797) },
                    { 16, 400000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6787), 0, false, 1.0, 1, 400000.0, 16, 50.0, 400000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6790) },
                    { 15, 700000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6781), 0, false, 1.0, 1, 700000.0, 15, 50.0, 700000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6783) },
                    { 1, 100000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(4109), 0, false, 1.0, 1, 100000.0, 1, 57.0, 100000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(4952) },
                    { 13, 100000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6760), 0, false, 1.0, 1, 100000.0, 13, 50.0, 100000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6763) },
                    { 4, 130000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6700), 0, false, 1.0, 1, 130000.0, 4, 39.0, 130000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6703) },
                    { 14, 620000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6773), 0, false, 1.0, 1, 620000.0, 14, 50.0, 620000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6775) },
                    { 3, 243000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6691), 0, false, 2.7000000000000002, 1, 90000.0, 3, 62.0, 243000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6694) },
                    { 5, 45000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6707), 0, false, 1.0, 1, 45000.0, 5, 50.0, 45000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6709) },
                    { 6, 80000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6714), 0, false, 1.0, 1, 80000.0, 6, 50.0, 80000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6716) },
                    { 2, 100000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6623), 0, false, 1.0, 1, 110000.0, 2, 50.0, 110000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6648) },
                    { 8, 65000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6727), 0, false, 1.0, 1, 65000.0, 8, 50.0, 65000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6729) },
                    { 9, 66000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6733), 0, false, 1.0, 1, 66000.0, 9, 50.0, 66000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6735) },
                    { 10, 58000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6740), 0, false, 1.0, 1, 58000.0, 10, 50.0, 58000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6742) },
                    { 11, 260000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6746), 0, false, 1.0, 1, 260000.0, 11, 50.0, 260000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6749) },
                    { 12, 70000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6754), 0, false, 1.0, 1, 70000.0, 12, 50.0, 70000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6756) },
                    { 7, 75000.0, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6721), 0, false, 1.0, 1, 75000.0, 7, 50.0, 75000.0, 1, new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6723) }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 228, DateTimeKind.Utc).AddTicks(9482), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4026), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4124), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4131), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4137), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4143), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4150), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4156), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4162), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4168), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4174), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4181), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4187), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4193), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4199), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4206), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4212), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4218), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4224), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4230), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4236), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4241), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4403), new DateTime(2020, 5, 31, 8, 29, 44, 229, DateTimeKind.Utc).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 224, DateTimeKind.Utc).AddTicks(7781), new DateTime(2020, 5, 31, 8, 29, 44, 224, DateTimeKind.Utc).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 224, DateTimeKind.Utc).AddTicks(9294), new DateTime(2020, 5, 31, 8, 29, 44, 224, DateTimeKind.Utc).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 224, DateTimeKind.Utc).AddTicks(9350), new DateTime(2020, 5, 31, 8, 29, 44, 224, DateTimeKind.Utc).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 224, DateTimeKind.Utc).AddTicks(9354), new DateTime(2020, 5, 31, 8, 29, 44, 224, DateTimeKind.Utc).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 227, DateTimeKind.Utc).AddTicks(5744), new DateTime(2020, 5, 31, 8, 29, 44, 227, DateTimeKind.Utc).AddTicks(6573) });
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
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 234, DateTimeKind.Utc).AddTicks(5220), new DateTime(2020, 5, 31, 8, 28, 39, 234, DateTimeKind.Utc).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 234, DateTimeKind.Utc).AddTicks(8585), new DateTime(2020, 5, 31, 8, 28, 39, 234, DateTimeKind.Utc).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 234, DateTimeKind.Utc).AddTicks(8729), new DateTime(2020, 5, 31, 8, 28, 39, 234, DateTimeKind.Utc).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 234, DateTimeKind.Utc).AddTicks(8736), new DateTime(2020, 5, 31, 8, 28, 39, 234, DateTimeKind.Utc).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 236, DateTimeKind.Utc).AddTicks(2676), new DateTime(2020, 5, 31, 8, 28, 39, 236, DateTimeKind.Utc).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(236), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(413), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(422), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(428), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(434), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(441), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(447), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(455), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(461), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(467), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(473), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(479), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(484), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(490), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(499), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(508), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(515), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(521), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(529), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(535), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(540), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(546), new DateTime(2020, 5, 31, 8, 28, 39, 237, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 227, DateTimeKind.Utc).AddTicks(5849), new DateTime(2020, 5, 31, 8, 28, 39, 227, DateTimeKind.Utc).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 227, DateTimeKind.Utc).AddTicks(8132), new DateTime(2020, 5, 31, 8, 28, 39, 227, DateTimeKind.Utc).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 227, DateTimeKind.Utc).AddTicks(8209), new DateTime(2020, 5, 31, 8, 28, 39, 227, DateTimeKind.Utc).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 227, DateTimeKind.Utc).AddTicks(8216), new DateTime(2020, 5, 31, 8, 28, 39, 227, DateTimeKind.Utc).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 28, 39, 233, DateTimeKind.Utc).AddTicks(7187), new DateTime(2020, 5, 31, 8, 28, 39, 233, DateTimeKind.Utc).AddTicks(9326) });
        }
    }
}
