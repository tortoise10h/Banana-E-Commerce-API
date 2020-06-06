using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Add_Field_Quantity_Left_In_Request_Import_Detail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "QuantityLeft",
                table: "RequestImportDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(2441), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(3906), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(3950), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(3953), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(5226), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6603), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6640), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6644), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6647), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6651), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6655), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6659), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6662), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6667), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6670), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6674), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6677), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6681), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6685), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6688), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6692), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6696), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6699), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6703), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6706), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6709), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6713), new DateTime(2020, 6, 6, 5, 35, 20, 384, DateTimeKind.Utc).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(7037), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9392), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9454), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9458), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9462), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9466), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9470), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9473), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9477), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9480), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9484), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9488), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9492), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9496), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9499), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9503), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9507), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9511), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9515), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9518), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9522), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9547), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9550), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 381, DateTimeKind.Utc).AddTicks(1789), new DateTime(2020, 6, 6, 5, 35, 20, 381, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 381, DateTimeKind.Utc).AddTicks(3108), new DateTime(2020, 6, 6, 5, 35, 20, 381, DateTimeKind.Utc).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 381, DateTimeKind.Utc).AddTicks(3161), new DateTime(2020, 6, 6, 5, 35, 20, 381, DateTimeKind.Utc).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 381, DateTimeKind.Utc).AddTicks(3165), new DateTime(2020, 6, 6, 5, 35, 20, 381, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 6, 5, 35, 20, 382, DateTimeKind.Utc).AddTicks(9715), new DateTime(2020, 6, 6, 5, 35, 20, 383, DateTimeKind.Utc).AddTicks(156) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantityLeft",
                table: "RequestImportDetails");

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

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(4109), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6623), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6691), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6700), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6707), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6714), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6721), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6727), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6733), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6740), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6746), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6754), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6760), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6773), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6781), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6787), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6795), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6801), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6807), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6818), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6824), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6831), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6838), new DateTime(2020, 5, 31, 8, 29, 44, 230, DateTimeKind.Utc).AddTicks(6840) });

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
    }
}
