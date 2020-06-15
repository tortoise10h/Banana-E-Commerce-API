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
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(5457), new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(6905), new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(6957), new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(6961), new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(6962) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "Description", "EntryPrice", "IsDeleted", "Name", "Origin", "PriceCurrency", "ProductUnit", "Status", "StorageId", "UpdatedAt" },
                values: new object[,]
                {
                    { 23, 2, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2790), 2, "Bơ Úc (Bơ Hass)", 140000.0, false, "Bơ Úc (Bơ Hass)", "Úc", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2792) },
                    { 22, 2, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2786), 1, "Sầu Riêng Muthong Thái", 100000.0, false, "Sầu Riêng Muthong Thái", "Thái Lan", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2787) },
                    { 21, 2, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2783), 4, "Dưa Hấu Luna Piena Nhật", 170000.0, false, "Dưa Hấu Luna Piena Nhật", "Nhật Bản", 1, 3, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2784) },
                    { 20, 2, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2779), 3, "Dâu Anh Đào Nhật", 610000.0, false, "Dâu Anh Đào Nhật", "Nhật Bản", 1, 8, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2780) },
                    { 19, 2, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2775), 2, "Nho xanh Úc", 320000.0, false, "Nho xanh Úc", "Úc", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2776) },
                    { 18, 2, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2772), 1, "Kiwi Vàng New Zealand ", 130000.0, false, "Kiwi Vàng New Zealand ", "New Zealand", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2773) },
                    { 17, 2, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2768), 4, "Táo New Zealand", 200000.0, false, "Táo New Zealand", "New Zealand", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2769) },
                    { 15, 2, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2761), 2, "Việt Quất Mỹ", 380000.0, false, "Việt Quất Mỹ", "Mỹ", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2762) },
                    { 14, 2, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2757), 1, "Cherry Mỹ", 310000.0, false, "Cherry Mỹ", "Mỹ", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2758) },
                    { 16, 2, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2764), 3, "Dưa Lê Hàn", 180000.0, false, "Dưa Lê Hàn", "Hàn Quốc", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2765) },
                    { 12, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2749), 3, "Dưa lưới Bình Dương", 30000.0, false, "Dưa Lưới", "Bình Dương", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2751) },
                    { 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2629), 2, "Bơ Sáp từ Việt Nam, Đắk Lắk", 58000.0, false, "Bơ Sáp", "Việt Nam, Đắk Lắk", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2642) },
                    { 3, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2714), 3, "Bưởi Da Xanh từ Việt Nam, Đồng Nai, Tân Triều", 30000.0, false, "Bưởi Da Xanh", "Việt Nam, Đồng Nai, Tân Triều", 1, 3, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2716) },
                    { 13, 2, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2753), 4, "Dưa Pepino Mexico", 45000.0, false, "Dưới Pepino", "Mexico", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2754) },
                    { 5, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2723), 4, "Cam Sành Miền Tây", 15000.0, false, "Cam Sành", "Miền Tây", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2724) },
                    { 6, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2726), 1, "Chanh đào tươi Đà Lạt", 40000.0, false, "Chanh Đào Tươi", "Đà Lạt", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2727) },
                    { 4, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2719), 3, "Có sắc tố đặc biệt, rất hiệu dụng trong quá trình chống oxy hóa", 65000.0, false, "Cà Chua Đen", "Hà Nội", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2720) },
                    { 8, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2734), 3, "Nhãn Lồng", 25000.0, false, "Nhãn Lồng", "Hưng Yên", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2735) },
                    { 9, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2738), 4, "Thanh Long Ruột Đỏ", 22000.0, false, "Thanh Long Ruột Đỏ", "Bình Thuận", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2739) },
                    { 10, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2741), 1, "Thanh long ruột trắng", 25000.0, false, "Thanh Long Ruột Trắng", "Bình Thuận", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2742) },
                    { 11, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2745), 2, "Dâu tây đà lạt giống Mỹ", 120000.0, false, "Dâu Tây Đà Lạt", "Đà Lạt", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2746) },
                    { 7, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2730), 2, "Chôm chôm nhãn", 35000.0, false, "Chôm Chôm Nhãn", "Đồng Bằng Sông Cửu Long", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(2731) },
                    { 1, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(257), 1, "Bơ 034 từ Việt Nam, Đắk Lắk", 60000.0, false, "Bơ 034", "Việt Nam, Đắk Lắk", 1, 7, 2, 1, new DateTime(2020, 6, 15, 0, 3, 4, 483, DateTimeKind.Utc).AddTicks(724) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 480, DateTimeKind.Utc).AddTicks(4822), new DateTime(2020, 6, 15, 0, 3, 4, 480, DateTimeKind.Utc).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 480, DateTimeKind.Utc).AddTicks(6105), new DateTime(2020, 6, 15, 0, 3, 4, 480, DateTimeKind.Utc).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 480, DateTimeKind.Utc).AddTicks(6161), new DateTime(2020, 6, 15, 0, 3, 4, 480, DateTimeKind.Utc).AddTicks(6162) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 480, DateTimeKind.Utc).AddTicks(6164), new DateTime(2020, 6, 15, 0, 3, 4, 480, DateTimeKind.Utc).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(2862), new DateTime(2020, 6, 15, 0, 3, 4, 482, DateTimeKind.Utc).AddTicks(3304) });
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
                values: new object[] { new DateTime(2020, 6, 15, 0, 2, 20, 614, DateTimeKind.Utc).AddTicks(4831), new DateTime(2020, 6, 15, 0, 2, 20, 614, DateTimeKind.Utc).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 2, 20, 614, DateTimeKind.Utc).AddTicks(8368), new DateTime(2020, 6, 15, 0, 2, 20, 614, DateTimeKind.Utc).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 2, 20, 614, DateTimeKind.Utc).AddTicks(8491), new DateTime(2020, 6, 15, 0, 2, 20, 614, DateTimeKind.Utc).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 2, 20, 614, DateTimeKind.Utc).AddTicks(8500), new DateTime(2020, 6, 15, 0, 2, 20, 614, DateTimeKind.Utc).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 2, 20, 609, DateTimeKind.Utc).AddTicks(8085), new DateTime(2020, 6, 15, 0, 2, 20, 609, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 2, 20, 610, DateTimeKind.Utc).AddTicks(1151), new DateTime(2020, 6, 15, 0, 2, 20, 610, DateTimeKind.Utc).AddTicks(1182) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 2, 20, 610, DateTimeKind.Utc).AddTicks(1264), new DateTime(2020, 6, 15, 0, 2, 20, 610, DateTimeKind.Utc).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 2, 20, 610, DateTimeKind.Utc).AddTicks(1271), new DateTime(2020, 6, 15, 0, 2, 20, 610, DateTimeKind.Utc).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 2, 20, 613, DateTimeKind.Utc).AddTicks(8560), new DateTime(2020, 6, 15, 0, 2, 20, 613, DateTimeKind.Utc).AddTicks(9620) });
        }
    }
}
