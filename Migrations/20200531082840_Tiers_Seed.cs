using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Tiers_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Tiers",
                columns: new[] { "Id", "IsDeleted", "TierOption" },
                values: new object[,]
                {
                    { 2, false, 2 },
                    { 1, false, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tiers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tiers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 600, DateTimeKind.Utc).AddTicks(3750), new DateTime(2020, 5, 31, 8, 26, 12, 600, DateTimeKind.Utc).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 600, DateTimeKind.Utc).AddTicks(5180), new DateTime(2020, 5, 31, 8, 26, 12, 600, DateTimeKind.Utc).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 600, DateTimeKind.Utc).AddTicks(5240), new DateTime(2020, 5, 31, 8, 26, 12, 600, DateTimeKind.Utc).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 600, DateTimeKind.Utc).AddTicks(5243), new DateTime(2020, 5, 31, 8, 26, 12, 600, DateTimeKind.Utc).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 600, DateTimeKind.Utc).AddTicks(8228), new DateTime(2020, 5, 31, 8, 26, 12, 600, DateTimeKind.Utc).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(470), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(540), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(545), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(549), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(553), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(556), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(580), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(584), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(588), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(592), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(596), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(600), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(603), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(607), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(610), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(614), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(618), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(621), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(625), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(629), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(632), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(636), new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 597, DateTimeKind.Utc).AddTicks(9100), new DateTime(2020, 5, 31, 8, 26, 12, 597, DateTimeKind.Utc).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 598, DateTimeKind.Utc).AddTicks(350), new DateTime(2020, 5, 31, 8, 26, 12, 598, DateTimeKind.Utc).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 598, DateTimeKind.Utc).AddTicks(404), new DateTime(2020, 5, 31, 8, 26, 12, 598, DateTimeKind.Utc).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 598, DateTimeKind.Utc).AddTicks(407), new DateTime(2020, 5, 31, 8, 26, 12, 598, DateTimeKind.Utc).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 26, 12, 600, DateTimeKind.Utc).AddTicks(8), new DateTime(2020, 5, 31, 8, 26, 12, 600, DateTimeKind.Utc).AddTicks(595) });
        }
    }
}
