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
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(13), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(1417), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(1477), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(1481), new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(1482) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "Description", "EntryPrice", "IsDeleted", "Name", "Origin", "PriceCurrency", "ProductUnit", "Status", "StorageId", "UpdatedAt" },
                values: new object[,]
                {
                    { 23, 2, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6814), 2, "Bơ Úc (Bơ Hass)", 140000.0, false, "Bơ Úc (Bơ Hass)", "Úc", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6815) },
                    { 22, 2, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6810), 1, "Sầu Riêng Muthong Thái", 100000.0, false, "Sầu Riêng Muthong Thái", "Thái Lan", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6811) },
                    { 21, 2, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6806), 4, "Dưa Hấu Luna Piena Nhật", 170000.0, false, "Dưa Hấu Luna Piena Nhật", "Nhật Bản", 1, 3, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6807) },
                    { 20, 2, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6801), 3, "Dâu Anh Đào Nhật", 610000.0, false, "Dâu Anh Đào Nhật", "Nhật Bản", 1, 8, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6802) },
                    { 19, 2, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6797), 2, "Nho xanh Úc", 320000.0, false, "Nho xanh Úc", "Úc", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6798) },
                    { 18, 2, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6793), 1, "Kiwi Vàng New Zealand ", 130000.0, false, "Kiwi Vàng New Zealand ", "New Zealand", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6794) },
                    { 17, 2, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6790), 4, "Táo New Zealand", 200000.0, false, "Táo New Zealand", "New Zealand", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6791) },
                    { 15, 2, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6783), 2, "Việt Quất Mỹ", 380000.0, false, "Việt Quất Mỹ", "Mỹ", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6784) },
                    { 14, 2, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6779), 1, "Cherry Mỹ", 310000.0, false, "Cherry Mỹ", "Mỹ", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6780) },
                    { 16, 2, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6786), 3, "Dưa Lê Hàn", 180000.0, false, "Dưa Lê Hàn", "Hàn Quốc", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6787) },
                    { 12, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6770), 3, "Dưa lưới Bình Dương", 30000.0, false, "Dưa Lưới", "Bình Dương", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6771) },
                    { 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6674), 2, "Bơ Sáp từ Việt Nam, Đắk Lắk", 58000.0, false, "Bơ Sáp", "Việt Nam, Đắk Lắk", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6688) },
                    { 3, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6734), 3, "Bưởi Da Xanh từ Việt Nam, Đồng Nai, Tân Triều", 30000.0, false, "Bưởi Da Xanh", "Việt Nam, Đồng Nai, Tân Triều", 1, 3, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6735) },
                    { 13, 2, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6773), 4, "Dưa Pepino Mexico", 45000.0, false, "Dưới Pepino", "Mexico", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6775) },
                    { 5, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6743), 4, "Cam Sành Miền Tây", 15000.0, false, "Cam Sành", "Miền Tây", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6744) },
                    { 6, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6746), 1, "Chanh đào tươi Đà Lạt", 40000.0, false, "Chanh Đào Tươi", "Đà Lạt", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6747) },
                    { 4, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6738), 3, "Có sắc tố đặc biệt, rất hiệu dụng trong quá trình chống oxy hóa", 65000.0, false, "Cà Chua Đen", "Hà Nội", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6739) },
                    { 8, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6755), 3, "Nhãn Lồng", 25000.0, false, "Nhãn Lồng", "Hưng Yên", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6756) },
                    { 9, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6758), 4, "Thanh Long Ruột Đỏ", 22000.0, false, "Thanh Long Ruột Đỏ", "Bình Thuận", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6759) },
                    { 10, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6763), 1, "Thanh long ruột trắng", 25000.0, false, "Thanh Long Ruột Trắng", "Bình Thuận", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6764) },
                    { 11, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6766), 2, "Dâu tây đà lạt giống Mỹ", 120000.0, false, "Dâu Tây Đà Lạt", "Đà Lạt", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6767) },
                    { 7, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6751), 2, "Chôm chôm nhãn", 35000.0, false, "Chôm Chôm Nhãn", "Đồng Bằng Sông Cửu Long", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(6752) },
                    { 1, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(4685), 1, "Bơ 034 từ Việt Nam, Đắk Lắk", 60000.0, false, "Bơ 034", "Việt Nam, Đắk Lắk", 1, 7, 2, 1, new DateTime(2020, 6, 13, 2, 55, 29, 720, DateTimeKind.Utc).AddTicks(5044) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 718, DateTimeKind.Utc).AddTicks(503), new DateTime(2020, 6, 13, 2, 55, 29, 718, DateTimeKind.Utc).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 718, DateTimeKind.Utc).AddTicks(1722), new DateTime(2020, 6, 13, 2, 55, 29, 718, DateTimeKind.Utc).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 718, DateTimeKind.Utc).AddTicks(1771), new DateTime(2020, 6, 13, 2, 55, 29, 718, DateTimeKind.Utc).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 718, DateTimeKind.Utc).AddTicks(1774), new DateTime(2020, 6, 13, 2, 55, 29, 718, DateTimeKind.Utc).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 55, 29, 719, DateTimeKind.Utc).AddTicks(7601), new DateTime(2020, 6, 13, 2, 55, 29, 719, DateTimeKind.Utc).AddTicks(8012) });
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
                values: new object[] { new DateTime(2020, 6, 13, 2, 54, 48, 582, DateTimeKind.Utc).AddTicks(9408), new DateTime(2020, 6, 13, 2, 54, 48, 582, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 54, 48, 583, DateTimeKind.Utc).AddTicks(744), new DateTime(2020, 6, 13, 2, 54, 48, 583, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 54, 48, 583, DateTimeKind.Utc).AddTicks(799), new DateTime(2020, 6, 13, 2, 54, 48, 583, DateTimeKind.Utc).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 54, 48, 583, DateTimeKind.Utc).AddTicks(803), new DateTime(2020, 6, 13, 2, 54, 48, 583, DateTimeKind.Utc).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 54, 48, 580, DateTimeKind.Utc).AddTicks(9165), new DateTime(2020, 6, 13, 2, 54, 48, 580, DateTimeKind.Utc).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 54, 48, 581, DateTimeKind.Utc).AddTicks(361), new DateTime(2020, 6, 13, 2, 54, 48, 581, DateTimeKind.Utc).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 54, 48, 581, DateTimeKind.Utc).AddTicks(411), new DateTime(2020, 6, 13, 2, 54, 48, 581, DateTimeKind.Utc).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 54, 48, 581, DateTimeKind.Utc).AddTicks(414), new DateTime(2020, 6, 13, 2, 54, 48, 581, DateTimeKind.Utc).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 2, 54, 48, 582, DateTimeKind.Utc).AddTicks(6993), new DateTime(2020, 6, 13, 2, 54, 48, 582, DateTimeKind.Utc).AddTicks(7407) });
        }
    }
}
