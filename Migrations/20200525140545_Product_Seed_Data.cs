using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Product_Seed_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(770), 1, false, "Trái Cây Việt", new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(1313) },
                    { 2, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(2534), 2, false, "Trái Cây Nhập", new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(2556) },
                    { 3, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(2587), 3, false, "Trái Cây Sấy Khô", new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(2589) },
                    { 4, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(2591), 4, false, "Mứt Trái Cây>", new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(2592) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 5, 42, 246, DateTimeKind.Utc).AddTicks(6635), new DateTime(2020, 5, 25, 14, 5, 42, 246, DateTimeKind.Utc).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 5, 42, 246, DateTimeKind.Utc).AddTicks(8022), new DateTime(2020, 5, 25, 14, 5, 42, 246, DateTimeKind.Utc).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 5, 42, 246, DateTimeKind.Utc).AddTicks(8093), new DateTime(2020, 5, 25, 14, 5, 42, 246, DateTimeKind.Utc).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 5, 42, 246, DateTimeKind.Utc).AddTicks(8097), new DateTime(2020, 5, 25, 14, 5, 42, 246, DateTimeKind.Utc).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 5, 42, 246, DateTimeKind.Utc).AddTicks(8100), new DateTime(2020, 5, 25, 14, 5, 42, 246, DateTimeKind.Utc).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 5, 42, 248, DateTimeKind.Utc).AddTicks(7247), new DateTime(2020, 5, 25, 14, 5, 42, 248, DateTimeKind.Utc).AddTicks(7724) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "Description", "IsDeleted", "Name", "Origin", "Price", "PriceCurrency", "ProductUnit", "Quantity", "SalePrice", "StorageId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(6818), 1, "Bơ 034 từ Việt Nam, Đắk Lắk", false, "Bơ 034", "Việt Nam, Đắk Lắk", 100000.0, 1, 7, 100.0, 90000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(7265) },
                    { 21, 2, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9469), 4, "Dưa Hấu Luna Piena Nhật", false, "Dưa Hấu Luna Piena Nhật", "Nhật Bản", 550000.0, 1, 3, 20.0, 450000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9470) },
                    { 20, 2, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9465), 3, "Dâu Anh Đào Nhật", false, "Dâu Anh Đào Nhật", "Nhật Bản", 1000000.0, 1, 8, 150.0, 950000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9466) },
                    { 19, 2, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9461), 2, "Nho xanh Úc", false, "Nho xanh Úc", "Úc", 610000.0, 1, 7, 65.0, 600000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9462) },
                    { 18, 2, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9457), 1, "Kiwi Vàng New Zealand ", false, "Kiwi Vàng New Zealand ", "New Zealand", 300000.0, 1, 7, 21.0, 260000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9458) },
                    { 17, 2, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9452), 4, "Táo New Zealand", false, "Táo New Zealand", "New Zealand", 450000.0, 1, 7, 21.0, 400000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9454) },
                    { 16, 2, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9448), 3, "Dưa Lê Hàn", false, "Dưa Lê Hàn", "Hàn Quốc", 400000.0, 1, 7, 28.0, 300000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9449) },
                    { 15, 2, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9444), 2, "Việt Quất Mỹ", false, "Việt Quất Mỹ", "Mỹ", 900000.0, 1, 7, 19.0, 800000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9445) },
                    { 14, 2, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9440), 1, "Cherry Mỹ", false, "Cherry Mỹ", "Mỹ", 750000.0, 1, 7, 12.0, 700000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9441) },
                    { 13, 2, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9436), 4, "Dưa Pepino Mexico", false, "Dưới Pepino", "Mexico", 150000.0, 1, 7, 21.0, 120000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9437) },
                    { 22, 2, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9473), 1, "Sầu Riêng Muthong Thái", false, "Sầu Riêng Muthong Thái", "Thái Lan", 200000.0, 1, 7, 30.0, 185000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9474) },
                    { 12, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9432), 3, "Dưa lưới Bình Dương", false, "Dưa Lưới", "Bình Dương", 70000.0, 1, 7, 33.0, 60000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9433) },
                    { 10, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9423), 1, "Thanh long ruột trắng", false, "Thanh Long Ruột Trắng", "Bình Thuận", 40000.0, 1, 7, 50.0, 30000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9425) },
                    { 9, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9419), 4, "Thanh Long Ruột Đỏ", false, "Thanh Long Ruột Đỏ", "Bình Thuận", 55000.0, 1, 7, 65.0, 45000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9420) },
                    { 8, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9415), 3, "Nhãn Lồng", false, "Nhãn Lồng", "Hưng Yên", 50000.0, 1, 7, 89.0, 38000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9416) },
                    { 7, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9411), 2, "Chôm chôm nhãn", false, "Chôm Chôm Nhãn", "Đồng Bằng Sông Cửu Long", 75000.0, 1, 7, 122.0, 60000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9412) },
                    { 6, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9406), 1, "Chanh đào tươi Đà Lạt", false, "Chanh Đào Tươi", "Đà Lạt", 80000.0, 1, 7, 54.0, 70000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9407) },
                    { 5, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9401), 4, "Cam Sành Miền Tây", false, "Cam Sành", "Miền Tây", 40000.0, 1, 7, 23.0, 30000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9403) },
                    { 4, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9297), 3, "Có sắc tố đặc biệt, rất hiệu dụng trong quá trình chống oxy hóa", false, "Cà Chua Đen", "Hà Nội", 110000.0, 1, 7, 27.0, 90000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9298) },
                    { 3, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9291), 3, "Bưởi Da Xanh từ Việt Nam, Đồng Nai, Tân Triều", false, "Bưởi Da Xanh", "Việt Nam, Đồng Nai, Tân Triều", 160000.0, 1, 3, 60.0, 140000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9293) },
                    { 2, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9230), 2, "Bơ Sáp từ Việt Nam, Đắk Lắk", false, "Bơ Sáp", "Việt Nam, Đắk Lắk", 90000.0, 1, 7, 87.0, 70000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9245) },
                    { 11, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9428), 2, "Dâu tây đà lạt giống Mỹ", false, "Dâu Tây Đà Lạt", "Đà Lạt", 200000.0, 1, 7, 44.0, 180000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9429) },
                    { 23, 2, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9477), 2, "Bơ Úc (Bơ Hass)", false, "Bơ Úc (Bơ Hass)", "Úc", 450000.0, 1, 7, 51.0, 350000.0, 1, new DateTime(2020, 5, 25, 14, 5, 42, 249, DateTimeKind.Utc).AddTicks(9478) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 5, 9, 876, DateTimeKind.Utc).AddTicks(8981), new DateTime(2020, 5, 25, 14, 5, 9, 877, DateTimeKind.Utc).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 5, 9, 877, DateTimeKind.Utc).AddTicks(4098), new DateTime(2020, 5, 25, 14, 5, 9, 877, DateTimeKind.Utc).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 5, 9, 877, DateTimeKind.Utc).AddTicks(4157), new DateTime(2020, 5, 25, 14, 5, 9, 877, DateTimeKind.Utc).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 5, 9, 877, DateTimeKind.Utc).AddTicks(4160), new DateTime(2020, 5, 25, 14, 5, 9, 877, DateTimeKind.Utc).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 5, 9, 877, DateTimeKind.Utc).AddTicks(4163), new DateTime(2020, 5, 25, 14, 5, 9, 877, DateTimeKind.Utc).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 5, 9, 879, DateTimeKind.Utc).AddTicks(4808), new DateTime(2020, 5, 25, 14, 5, 9, 879, DateTimeKind.Utc).AddTicks(5280) });
        }
    }
}
