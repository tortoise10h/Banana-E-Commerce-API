using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Products_And_Tiers_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(2766), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(4111), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(4167), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(4171), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(4172) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "Description", "EntryPrice", "IsDeleted", "Name", "Origin", "PriceCurrency", "ProductUnit", "Status", "StorageId", "UpdatedAt" },
                values: new object[,]
                {
                    { 23, 2, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9597), 2, "Bơ Úc (Bơ Hass)", 140000.0, false, "Bơ Úc (Bơ Hass)", "Úc", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9598) },
                    { 22, 2, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9593), 1, "Sầu Riêng Muthong Thái", 100000.0, false, "Sầu Riêng Muthong Thái", "Thái Lan", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9595) },
                    { 21, 2, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9590), 4, "Dưa Hấu Luna Piena Nhật", 170000.0, false, "Dưa Hấu Luna Piena Nhật", "Nhật Bản", 1, 3, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9591) },
                    { 20, 2, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9586), 3, "Dâu Anh Đào Nhật", 610000.0, false, "Dâu Anh Đào Nhật", "Nhật Bản", 1, 8, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9587) },
                    { 19, 2, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9583), 2, "Nho xanh Úc", 320000.0, false, "Nho xanh Úc", "Úc", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9584) },
                    { 18, 2, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9579), 1, "Kiwi Vàng New Zealand ", 130000.0, false, "Kiwi Vàng New Zealand ", "New Zealand", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9580) },
                    { 16, 2, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9572), 3, "Dưa Lê Hàn", 180000.0, false, "Dưa Lê Hàn", "Hàn Quốc", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9573) },
                    { 15, 2, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9568), 2, "Việt Quất Mỹ", 380000.0, false, "Việt Quất Mỹ", "Mỹ", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9569) },
                    { 14, 2, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9565), 1, "Cherry Mỹ", 310000.0, false, "Cherry Mỹ", "Mỹ", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9566) },
                    { 17, 2, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9576), 4, "Táo New Zealand", 200000.0, false, "Táo New Zealand", "New Zealand", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9577) },
                    { 12, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9558), 3, "Dưa lưới Bình Dương", 30000.0, false, "Dưa Lưới", "Bình Dương", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9559) },
                    { 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9457), 2, "Bơ Sáp từ Việt Nam, Đắk Lắk", 58000.0, false, "Bơ Sáp", "Việt Nam, Đắk Lắk", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9472) },
                    { 3, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9522), 3, "Bưởi Da Xanh từ Việt Nam, Đồng Nai, Tân Triều", 30000.0, false, "Bưởi Da Xanh", "Việt Nam, Đồng Nai, Tân Triều", 1, 3, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9523) },
                    { 13, 2, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9561), 4, "Dưa Pepino Mexico", 45000.0, false, "Dưới Pepino", "Mexico", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9562) },
                    { 4, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9526), 3, "Có sắc tố đặc biệt, rất hiệu dụng trong quá trình chống oxy hóa", 65000.0, false, "Cà Chua Đen", "Hà Nội", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9528) },
                    { 5, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9531), 4, "Cam Sành Miền Tây", 15000.0, false, "Cam Sành", "Miền Tây", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9532) },
                    { 1, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(7257), 1, "Bơ 034 từ Việt Nam, Đắk Lắk", 60000.0, false, "Bơ 034", "Việt Nam, Đắk Lắk", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(7617) },
                    { 7, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9539), 2, "Chôm chôm nhãn", 35000.0, false, "Chôm Chôm Nhãn", "Đồng Bằng Sông Cửu Long", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9540) },
                    { 8, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9542), 3, "Nhãn Lồng", 25000.0, false, "Nhãn Lồng", "Hưng Yên", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9543) },
                    { 9, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9546), 4, "Thanh Long Ruột Đỏ", 22000.0, false, "Thanh Long Ruột Đỏ", "Bình Thuận", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9547) },
                    { 10, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9550), 1, "Thanh long ruột trắng", 25000.0, false, "Thanh Long Ruột Trắng", "Bình Thuận", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9551) },
                    { 11, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9554), 2, "Dâu tây đà lạt giống Mỹ", 120000.0, false, "Dâu Tây Đà Lạt", "Đà Lạt", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9555) },
                    { 6, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9535), 1, "Chanh đào tươi Đà Lạt", 40000.0, false, "Chanh Đào Tươi", "Đà Lạt", 1, 7, 2, 1, new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(9536) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 366, DateTimeKind.Utc).AddTicks(2311), new DateTime(2020, 6, 13, 12, 39, 8, 366, DateTimeKind.Utc).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 366, DateTimeKind.Utc).AddTicks(3527), new DateTime(2020, 6, 13, 12, 39, 8, 366, DateTimeKind.Utc).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 366, DateTimeKind.Utc).AddTicks(3574), new DateTime(2020, 6, 13, 12, 39, 8, 366, DateTimeKind.Utc).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 366, DateTimeKind.Utc).AddTicks(3577), new DateTime(2020, 6, 13, 12, 39, 8, 366, DateTimeKind.Utc).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 39, 8, 367, DateTimeKind.Utc).AddTicks(9748), new DateTime(2020, 6, 13, 12, 39, 8, 368, DateTimeKind.Utc).AddTicks(535) });

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
                values: new object[] { new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(7332), new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(9346), new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(9412), new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(9416), new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 38, 7, 128, DateTimeKind.Utc).AddTicks(5029), new DateTime(2020, 6, 13, 12, 38, 7, 128, DateTimeKind.Utc).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 38, 7, 128, DateTimeKind.Utc).AddTicks(6464), new DateTime(2020, 6, 13, 12, 38, 7, 128, DateTimeKind.Utc).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 38, 7, 128, DateTimeKind.Utc).AddTicks(6518), new DateTime(2020, 6, 13, 12, 38, 7, 128, DateTimeKind.Utc).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 38, 7, 128, DateTimeKind.Utc).AddTicks(6521), new DateTime(2020, 6, 13, 12, 38, 7, 128, DateTimeKind.Utc).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(4584), new DateTime(2020, 6, 13, 12, 38, 7, 130, DateTimeKind.Utc).AddTicks(5057) });
        }
    }
}
