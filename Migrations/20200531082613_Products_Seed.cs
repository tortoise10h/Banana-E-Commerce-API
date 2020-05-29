using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Products_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "Description", "EntryPrice", "IsDeleted", "Name", "Origin", "PriceCurrency", "ProductUnit", "StorageId", "UpdatedAt" },
                values: new object[,]
                {
                    { 23, 2, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(636), 2, "Bơ Úc (Bơ Hass)", 140000.0, false, "Bơ Úc (Bơ Hass)", "Úc", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(637) },
                    { 22, 2, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(632), 1, "Sầu Riêng Muthong Thái", 100000.0, false, "Sầu Riêng Muthong Thái", "Thái Lan", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(633) },
                    { 21, 2, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(629), 4, "Dưa Hấu Luna Piena Nhật", 170000.0, false, "Dưa Hấu Luna Piena Nhật", "Nhật Bản", 1, 3, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(630) },
                    { 20, 2, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(625), 3, "Dâu Anh Đào Nhật", 610000.0, false, "Dâu Anh Đào Nhật", "Nhật Bản", 1, 8, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(626) },
                    { 19, 2, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(621), 2, "Nho xanh Úc", 320000.0, false, "Nho xanh Úc", "Úc", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(623) },
                    { 18, 2, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(618), 1, "Kiwi Vàng New Zealand ", 130000.0, false, "Kiwi Vàng New Zealand ", "New Zealand", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(619) },
                    { 17, 2, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(614), 4, "Táo New Zealand", 200000.0, false, "Táo New Zealand", "New Zealand", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(615) },
                    { 15, 2, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(607), 2, "Việt Quất Mỹ", 380000.0, false, "Việt Quất Mỹ", "Mỹ", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(608) },
                    { 14, 2, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(603), 1, "Cherry Mỹ", 310000.0, false, "Cherry Mỹ", "Mỹ", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(604) },
                    { 16, 2, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(610), 3, "Dưa Lê Hàn", 180000.0, false, "Dưa Lê Hàn", "Hàn Quốc", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(612) },
                    { 12, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(596), 3, "Dưa lưới Bình Dương", 30000.0, false, "Dưa Lưới", "Bình Dương", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(597) },
                    { 2, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(470), 2, "Bơ Sáp từ Việt Nam, Đắk Lắk", 58000.0, false, "Bơ Sáp", "Việt Nam, Đắk Lắk", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(486) },
                    { 3, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(540), 3, "Bưởi Da Xanh từ Việt Nam, Đồng Nai, Tân Triều", 30000.0, false, "Bưởi Da Xanh", "Việt Nam, Đồng Nai, Tân Triều", 1, 3, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(541) },
                    { 13, 2, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(600), 4, "Dưa Pepino Mexico", 45000.0, false, "Dưới Pepino", "Mexico", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(601) },
                    { 5, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(549), 4, "Cam Sành Miền Tây", 15000.0, false, "Cam Sành", "Miền Tây", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(550) },
                    { 6, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(553), 1, "Chanh đào tươi Đà Lạt", 40000.0, false, "Chanh Đào Tươi", "Đà Lạt", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(554) },
                    { 4, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(545), 3, "Có sắc tố đặc biệt, rất hiệu dụng trong quá trình chống oxy hóa", 65000.0, false, "Cà Chua Đen", "Hà Nội", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(546) },
                    { 8, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(580), 3, "Nhãn Lồng", 25000.0, false, "Nhãn Lồng", "Hưng Yên", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(581) },
                    { 9, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(584), 4, "Thanh Long Ruột Đỏ", 22000.0, false, "Thanh Long Ruột Đỏ", "Bình Thuận", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(586) },
                    { 10, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(588), 1, "Thanh long ruột trắng", 25000.0, false, "Thanh Long Ruột Trắng", "Bình Thuận", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(590) },
                    { 11, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(592), 2, "Dâu tây đà lạt giống Mỹ", 120000.0, false, "Dâu Tây Đà Lạt", "Đà Lạt", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(593) },
                    { 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(556), 2, "Chôm chôm nhãn", 35000.0, false, "Chôm Chôm Nhãn", "Đồng Bằng Sông Cửu Long", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 601, DateTimeKind.Utc).AddTicks(558) },
                    { 1, 1, new DateTime(2020, 5, 31, 8, 26, 12, 600, DateTimeKind.Utc).AddTicks(8228), 1, "Bơ 034 từ Việt Nam, Đắk Lắk", 60000.0, false, "Bơ 034", "Việt Nam, Đắk Lắk", 1, 7, 1, new DateTime(2020, 5, 31, 8, 26, 12, 600, DateTimeKind.Utc).AddTicks(8592) }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(4812), new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(6272), new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(6332), new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(6335), new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 25, 0, 309, DateTimeKind.Utc).AddTicks(4123), new DateTime(2020, 5, 31, 8, 25, 0, 309, DateTimeKind.Utc).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 25, 0, 309, DateTimeKind.Utc).AddTicks(5535), new DateTime(2020, 5, 31, 8, 25, 0, 309, DateTimeKind.Utc).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 25, 0, 309, DateTimeKind.Utc).AddTicks(5582), new DateTime(2020, 5, 31, 8, 25, 0, 309, DateTimeKind.Utc).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 25, 0, 309, DateTimeKind.Utc).AddTicks(5586), new DateTime(2020, 5, 31, 8, 25, 0, 309, DateTimeKind.Utc).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(1962), new DateTime(2020, 5, 31, 8, 25, 0, 311, DateTimeKind.Utc).AddTicks(2468) });
        }
    }
}
