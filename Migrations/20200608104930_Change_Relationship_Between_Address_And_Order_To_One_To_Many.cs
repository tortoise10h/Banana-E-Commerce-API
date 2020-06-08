using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Change_Relationship_Between_Address_And_Order_To_One_To_Many : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Orders_AddressId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(3007), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(4422), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(4481), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(4484), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(8031), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(9384), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(5176), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6338), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6373), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6377), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6380), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6384), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6388), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6391), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6395), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6398), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6402), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6406), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6410), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6413), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6417), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6420), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6424), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6427), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6431), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6434), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6437), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6441), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6444), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6448), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6451), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6455), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6458), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6462), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6465), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6468), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6472), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6475), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6476) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6479), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6482), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6506), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6510), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6513), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6517), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6520), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6524), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6527), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6531), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6534), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6538), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6541), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6544), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(7369), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9358), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9423), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9428), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9432), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9435), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9439), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9443), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9446), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9449), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9453), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9457), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9460), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9464), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9468), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9471), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9475), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9478), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9482), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9485), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9489), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9492), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9496), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 590, DateTimeKind.Utc).AddTicks(2265), new DateTime(2020, 6, 8, 10, 49, 29, 590, DateTimeKind.Utc).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 590, DateTimeKind.Utc).AddTicks(3494), new DateTime(2020, 6, 8, 10, 49, 29, 590, DateTimeKind.Utc).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 590, DateTimeKind.Utc).AddTicks(3544), new DateTime(2020, 6, 8, 10, 49, 29, 590, DateTimeKind.Utc).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 590, DateTimeKind.Utc).AddTicks(3548), new DateTime(2020, 6, 8, 10, 49, 29, 590, DateTimeKind.Utc).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 591, DateTimeKind.Utc).AddTicks(9708), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(329) });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Orders_AddressId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 505, DateTimeKind.Utc).AddTicks(8739), new DateTime(2020, 6, 8, 9, 53, 59, 505, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(59), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(125), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(129), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(3163), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(4423), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(606), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1712), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1744), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1748), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1752), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1755), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1759), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1763), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1766), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1770), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1773), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1777), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1781), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1798), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1801), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1805), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1808), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1812), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1816), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1819), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1825), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1828), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1832), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1835), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1839), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1842), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1846), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1849), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1853), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1856), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1859), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1863), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1867), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1870), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1873), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1877), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1880), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1884), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1887), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1891), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1894), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1897), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1901), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1904), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1908), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1911), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(3036), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5059), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5124), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5129), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5133), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5136), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5140), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5144), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5147), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5151), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5155), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5159), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5163), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5166), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5170), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5174), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5178), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5181), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5185), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5188), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5192), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5195), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5196) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5199), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 503, DateTimeKind.Utc).AddTicks(8355), new DateTime(2020, 6, 8, 9, 53, 59, 503, DateTimeKind.Utc).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 503, DateTimeKind.Utc).AddTicks(9603), new DateTime(2020, 6, 8, 9, 53, 59, 503, DateTimeKind.Utc).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 503, DateTimeKind.Utc).AddTicks(9658), new DateTime(2020, 6, 8, 9, 53, 59, 503, DateTimeKind.Utc).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 503, DateTimeKind.Utc).AddTicks(9661), new DateTime(2020, 6, 8, 9, 53, 59, 503, DateTimeKind.Utc).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 505, DateTimeKind.Utc).AddTicks(6031), new DateTime(2020, 6, 8, 9, 53, 59, 505, DateTimeKind.Utc).AddTicks(6496) });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                column: "AddressId",
                unique: true);
        }
    }
}
