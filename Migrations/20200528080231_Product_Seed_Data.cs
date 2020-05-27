using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Product_Seed_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(6946), new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(8595), new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(8657), new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(8661), new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "Description", "EntryPrice", "IsDeleted", "Name", "Origin", "PriceCurrency", "ProductUnit", "StorageId", "UpdatedAt" },
                values: new object[,]
                {
                    { 23, 2, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4924), 2, "Bơ Úc (Bơ Hass)", 140000.0, false, "Bơ Úc (Bơ Hass)", "Úc", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4925) },
                    { 22, 2, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4920), 1, "Sầu Riêng Muthong Thái", 100000.0, false, "Sầu Riêng Muthong Thái", "Thái Lan", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4921) },
                    { 21, 2, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4916), 4, "Dưa Hấu Luna Piena Nhật", 170000.0, false, "Dưa Hấu Luna Piena Nhật", "Nhật Bản", 1, 3, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4917) },
                    { 20, 2, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4912), 3, "Dâu Anh Đào Nhật", 610000.0, false, "Dâu Anh Đào Nhật", "Nhật Bản", 1, 8, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4913) },
                    { 19, 2, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4908), 2, "Nho xanh Úc", 320000.0, false, "Nho xanh Úc", "Úc", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4909) },
                    { 18, 2, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4904), 1, "Kiwi Vàng New Zealand ", 130000.0, false, "Kiwi Vàng New Zealand ", "New Zealand", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4905) },
                    { 17, 2, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4900), 4, "Táo New Zealand", 200000.0, false, "Táo New Zealand", "New Zealand", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4901) },
                    { 15, 2, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4892), 2, "Việt Quất Mỹ", 380000.0, false, "Việt Quất Mỹ", "Mỹ", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4894) },
                    { 14, 2, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4888), 1, "Cherry Mỹ", 310000.0, false, "Cherry Mỹ", "Mỹ", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4890) },
                    { 16, 2, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4896), 3, "Dưa Lê Hàn", 180000.0, false, "Dưa Lê Hàn", "Hàn Quốc", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4898) },
                    { 12, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4880), 3, "Dưa lưới Bình Dương", 30000.0, false, "Dưa Lưới", "Bình Dương", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4882) },
                    { 2, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4775), 2, "Bơ Sáp từ Việt Nam, Đắk Lắk", 58000.0, false, "Bơ Sáp", "Việt Nam, Đắk Lắk", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4789) },
                    { 3, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4843), 3, "Bưởi Da Xanh từ Việt Nam, Đồng Nai, Tân Triều", 30000.0, false, "Bưởi Da Xanh", "Việt Nam, Đồng Nai, Tân Triều", 1, 3, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4845) },
                    { 13, 2, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4885), 4, "Dưa Pepino Mexico", 45000.0, false, "Dưới Pepino", "Mexico", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4886) },
                    { 5, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4853), 4, "Cam Sành Miền Tây", 15000.0, false, "Cam Sành", "Miền Tây", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4854) },
                    { 6, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4857), 1, "Chanh đào tươi Đà Lạt", 40000.0, false, "Chanh Đào Tươi", "Đà Lạt", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4858) },
                    { 4, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4849), 3, "Có sắc tố đặc biệt, rất hiệu dụng trong quá trình chống oxy hóa", 65000.0, false, "Cà Chua Đen", "Hà Nội", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4850) },
                    { 8, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4864), 3, "Nhãn Lồng", 25000.0, false, "Nhãn Lồng", "Hưng Yên", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4866) },
                    { 9, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4868), 4, "Thanh Long Ruột Đỏ", 22000.0, false, "Thanh Long Ruột Đỏ", "Bình Thuận", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4870) },
                    { 10, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4872), 1, "Thanh long ruột trắng", 25000.0, false, "Thanh Long Ruột Trắng", "Bình Thuận", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4874) },
                    { 11, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4877), 2, "Dâu tây đà lạt giống Mỹ", 120000.0, false, "Dâu Tây Đà Lạt", "Đà Lạt", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4878) },
                    { 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4861), 2, "Chôm chôm nhãn", 35000.0, false, "Chôm Chôm Nhãn", "Đồng Bằng Sông Cửu Long", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(4862) },
                    { 1, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(2397), 1, "Bơ 034 từ Việt Nam, Đắk Lắk", 60000.0, false, "Bơ 034", "Việt Nam, Đắk Lắk", 1, 7, 1, new DateTime(2020, 5, 28, 8, 2, 28, 937, DateTimeKind.Utc).AddTicks(2879) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 934, DateTimeKind.Utc).AddTicks(2715), new DateTime(2020, 5, 28, 8, 2, 28, 934, DateTimeKind.Utc).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 934, DateTimeKind.Utc).AddTicks(4044), new DateTime(2020, 5, 28, 8, 2, 28, 934, DateTimeKind.Utc).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 934, DateTimeKind.Utc).AddTicks(4100), new DateTime(2020, 5, 28, 8, 2, 28, 934, DateTimeKind.Utc).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 934, DateTimeKind.Utc).AddTicks(4104), new DateTime(2020, 5, 28, 8, 2, 28, 934, DateTimeKind.Utc).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(3766), new DateTime(2020, 5, 28, 8, 2, 28, 936, DateTimeKind.Utc).AddTicks(4227) });
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
                values: new object[] { new DateTime(2020, 5, 28, 8, 1, 28, 269, DateTimeKind.Utc).AddTicks(8774), new DateTime(2020, 5, 28, 8, 1, 28, 269, DateTimeKind.Utc).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 1, 28, 270, DateTimeKind.Utc).AddTicks(81), new DateTime(2020, 5, 28, 8, 1, 28, 270, DateTimeKind.Utc).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 1, 28, 270, DateTimeKind.Utc).AddTicks(133), new DateTime(2020, 5, 28, 8, 1, 28, 270, DateTimeKind.Utc).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 1, 28, 270, DateTimeKind.Utc).AddTicks(137), new DateTime(2020, 5, 28, 8, 1, 28, 270, DateTimeKind.Utc).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 1, 28, 267, DateTimeKind.Utc).AddTicks(7733), new DateTime(2020, 5, 28, 8, 1, 28, 267, DateTimeKind.Utc).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 1, 28, 267, DateTimeKind.Utc).AddTicks(9042), new DateTime(2020, 5, 28, 8, 1, 28, 267, DateTimeKind.Utc).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 1, 28, 267, DateTimeKind.Utc).AddTicks(9102), new DateTime(2020, 5, 28, 8, 1, 28, 267, DateTimeKind.Utc).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 1, 28, 267, DateTimeKind.Utc).AddTicks(9106), new DateTime(2020, 5, 28, 8, 1, 28, 267, DateTimeKind.Utc).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 28, 8, 1, 28, 269, DateTimeKind.Utc).AddTicks(6130), new DateTime(2020, 5, 28, 8, 1, 28, 269, DateTimeKind.Utc).AddTicks(6542) });
        }
    }
}
