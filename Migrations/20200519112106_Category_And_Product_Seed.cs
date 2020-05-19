using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Category_And_Product_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(6648), 1, false, "Trái Cây Việt", new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(7046) },
                    { 2, new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(8337), 2, false, "Trái Cây Nhập", new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(8372) },
                    { 3, new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(8407), 3, false, "Trái Cây Sấy Khô", new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(8408) },
                    { 4, new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(8411), 4, false, "Mứt Trái Cây>", new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(8412) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(3301), new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(4462), new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(4512), new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(4515), new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(4517), new DateTime(2020, 5, 19, 11, 21, 5, 905, DateTimeKind.Utc).AddTicks(4519) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(2497), new DateTime(2020, 5, 19, 11, 21, 5, 907, DateTimeKind.Utc).AddTicks(3222) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "Description", "IsDeleted", "Name", "Origin", "Price", "PriceCurrency", "ProductUnit", "Quantity", "SalePrice", "StorageId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 5, 19, 18, 21, 5, 908, DateTimeKind.Local).AddTicks(2142), 1, "Bơ 034 từ Việt Nam, Đắk Lắk", false, "Bơ 034", "Việt Nam, Đắk Lắk", 100000.0, 1, 7, 100.0, 90000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(1663) },
                    { 21, 2, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3643), 4, "Dưa Hấu Luna Piena Nhật", false, "Dưa Hấu Luna Piena Nhật", "Nhật Bản", 550000.0, 1, 3, 20.0, 450000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3644) },
                    { 20, 2, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3638), 3, "Dâu Anh Đào Nhật", false, "Dâu Anh Đào Nhật", "Nhật Bản", 1000000.0, 1, 8, 150.0, 950000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3640) },
                    { 19, 2, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3634), 2, "Nho xanh Úc", false, "Nho xanh Úc", "Úc", 610000.0, 1, 7, 65.0, 600000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3635) },
                    { 18, 2, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3630), 1, "Kiwi Vàng New Zealand ", false, "Kiwi Vàng New Zealand ", "New Zealand", 300000.0, 1, 7, 21.0, 260000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3631) },
                    { 17, 2, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3626), 4, "Táo New Zealand", false, "Táo New Zealand", "New Zealand", 450000.0, 1, 7, 21.0, 400000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3627) },
                    { 16, 2, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3620), 3, "Dưa Lê Hàn", false, "Dưa Lê Hàn", "Hàn Quốc", 400000.0, 1, 7, 28.0, 300000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3622) },
                    { 15, 2, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3616), 2, "Việt Quất Mỹ", false, "Việt Quất Mỹ", "Mỹ", 900000.0, 1, 7, 19.0, 800000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3618) },
                    { 14, 2, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3612), 1, "Cherry Mỹ", false, "Cherry Mỹ", "Mỹ", 750000.0, 1, 7, 12.0, 700000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3613) },
                    { 13, 2, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3608), 4, "Dưa Pepino Mexico", false, "Dưới Pepino", "Mexico", 150000.0, 1, 7, 21.0, 120000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3609) },
                    { 22, 2, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3647), 1, "Sầu Riêng Muthong Thái", false, "Sầu Riêng Muthong Thái", "Thái Lan", 200000.0, 1, 7, 30.0, 185000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3648) },
                    { 12, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3603), 3, "Dưa lưới Bình Dương", false, "Dưa Lưới", "Bình Dương", 70000.0, 1, 7, 33.0, 60000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3604) },
                    { 10, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3595), 1, "Thanh long ruột trắng", false, "Thanh Long Ruột Trắng", "Bình Thuận", 40000.0, 1, 7, 50.0, 30000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3596) },
                    { 9, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3590), 4, "Thanh Long Ruột Đỏ", false, "Thanh Long Ruột Đỏ", "Bình Thuận", 55000.0, 1, 7, 65.0, 45000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3591) },
                    { 8, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3585), 3, "Nhãn Lồng", false, "Nhãn Lồng", "Hưng Yên", 50000.0, 1, 7, 89.0, 38000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3587) },
                    { 7, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3581), 2, "Chôm chôm nhãn", false, "Chôm Chôm Nhãn", "Đồng Bằng Sông Cửu Long", 75000.0, 1, 7, 122.0, 60000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3582) },
                    { 6, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3577), 1, "Chanh đào tươi Đà Lạt", false, "Chanh Đào Tươi", "Đà Lạt", 80000.0, 1, 7, 54.0, 70000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3578) },
                    { 5, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3572), 4, "Cam Sành Miền Tây", false, "Cam Sành", "Miền Tây", 40000.0, 1, 7, 23.0, 30000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3574) },
                    { 4, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3568), 3, "Có sắc tố đặc biệt, rất hiệu dụng trong quá trình chống oxy hóa", false, "Cà Chua Đen", "Hà Nội", 110000.0, 1, 7, 27.0, 90000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3569) },
                    { 3, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3562), 3, "Bưởi Da Xanh từ Việt Nam, Đồng Nai, Tân Triều", false, "Bưởi Da Xanh", "Việt Nam, Đồng Nai, Tân Triều", 160000.0, 1, 3, 60.0, 140000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3564) },
                    { 2, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3497), 2, "Bơ Sáp từ Việt Nam, Đắk Lắk", false, "Bơ Sáp", "Việt Nam, Đắk Lắk", 90000.0, 1, 7, 87.0, 70000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3515) },
                    { 11, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3599), 2, "Dâu tây đà lạt giống Mỹ", false, "Dâu Tây Đà Lạt", "Đà Lạt", 200000.0, 1, 7, 44.0, 180000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3600) },
                    { 23, 2, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3651), 2, "Bơ Úc (Bơ Hass)", false, "Bơ Úc (Bơ Hass)", "Úc", 450000.0, 1, 7, 51.0, 350000.0, 1, new DateTime(2020, 5, 19, 18, 21, 5, 909, DateTimeKind.Local).AddTicks(3653) }
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
                values: new object[] { new DateTime(2020, 5, 18, 16, 40, 7, 543, DateTimeKind.Utc).AddTicks(9351), new DateTime(2020, 5, 18, 16, 40, 7, 544, DateTimeKind.Utc).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 18, 16, 40, 7, 544, DateTimeKind.Utc).AddTicks(1668), new DateTime(2020, 5, 18, 16, 40, 7, 544, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 18, 16, 40, 7, 544, DateTimeKind.Utc).AddTicks(1730), new DateTime(2020, 5, 18, 16, 40, 7, 544, DateTimeKind.Utc).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 18, 16, 40, 7, 544, DateTimeKind.Utc).AddTicks(1735), new DateTime(2020, 5, 18, 16, 40, 7, 544, DateTimeKind.Utc).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 18, 16, 40, 7, 544, DateTimeKind.Utc).AddTicks(1740), new DateTime(2020, 5, 18, 16, 40, 7, 544, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 18, 16, 40, 7, 547, DateTimeKind.Utc).AddTicks(5914), new DateTime(2020, 5, 18, 16, 40, 7, 547, DateTimeKind.Utc).AddTicks(6761) });
        }
    }
}
