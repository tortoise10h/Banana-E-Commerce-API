using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Change_Relationship_User_RefreshToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 384, DateTimeKind.Utc).AddTicks(9635), new DateTime(2020, 5, 20, 13, 44, 10, 384, DateTimeKind.Utc).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(1041), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(1123), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(1128), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(4596), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6693), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6757), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6761), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6765), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6769), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6773), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6776), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6782), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6786), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6791), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6794), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6798), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6802), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6806), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6809), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6813), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6821), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6824), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6828), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6832), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6835), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6839), new DateTime(2020, 5, 20, 13, 44, 10, 385, DateTimeKind.Utc).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 382, DateTimeKind.Utc).AddTicks(9840), new DateTime(2020, 5, 20, 13, 44, 10, 383, DateTimeKind.Utc).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 383, DateTimeKind.Utc).AddTicks(1016), new DateTime(2020, 5, 20, 13, 44, 10, 383, DateTimeKind.Utc).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 383, DateTimeKind.Utc).AddTicks(1065), new DateTime(2020, 5, 20, 13, 44, 10, 383, DateTimeKind.Utc).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 383, DateTimeKind.Utc).AddTicks(1068), new DateTime(2020, 5, 20, 13, 44, 10, 383, DateTimeKind.Utc).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 383, DateTimeKind.Utc).AddTicks(1071), new DateTime(2020, 5, 20, 13, 44, 10, 383, DateTimeKind.Utc).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 44, 10, 384, DateTimeKind.Utc).AddTicks(6993), new DateTime(2020, 5, 20, 13, 44, 10, 384, DateTimeKind.Utc).AddTicks(7403) });

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken");

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
    }
}
