using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Add_Field_Product_Status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 706, DateTimeKind.Utc).AddTicks(3898), new DateTime(2020, 6, 9, 14, 28, 53, 706, DateTimeKind.Utc).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 706, DateTimeKind.Utc).AddTicks(7303), new DateTime(2020, 6, 9, 14, 28, 53, 706, DateTimeKind.Utc).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 706, DateTimeKind.Utc).AddTicks(7393), new DateTime(2020, 6, 9, 14, 28, 53, 706, DateTimeKind.Utc).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 706, DateTimeKind.Utc).AddTicks(7401), new DateTime(2020, 6, 9, 14, 28, 53, 706, DateTimeKind.Utc).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Method", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 710, DateTimeKind.Utc).AddTicks(1789), 1, new DateTime(2020, 6, 9, 14, 28, 53, 710, DateTimeKind.Utc).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Method", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 710, DateTimeKind.Utc).AddTicks(4663), 2, new DateTime(2020, 6, 9, 14, 28, 53, 710, DateTimeKind.Utc).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(5956), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8611), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8670), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8676), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8683), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8690), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8696), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8702), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8711), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8717), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8726), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8732), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8738), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8744), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8750), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8757), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8764), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8770), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8776), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8817), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8824), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8833), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8839), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8848), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8854), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8860), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8867), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8872), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8881), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8887), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8892), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8897), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8903), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8908), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8914), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8920), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8925), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8930), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8936), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8943), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8948), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8954), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8959), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8964), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8970), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8975), new DateTime(2020, 6, 9, 14, 28, 53, 709, DateTimeKind.Utc).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 707, DateTimeKind.Utc).AddTicks(7145), new DateTime(2020, 6, 9, 14, 28, 53, 707, DateTimeKind.Utc).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1573), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1694), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1795), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1802), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1808), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1814), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1821), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1829), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1836), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1843), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1849), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1856), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1863), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1869), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1875), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1882), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1889), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1896), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1903), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1909), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1916), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1923), new DateTime(2020, 6, 9, 14, 28, 53, 708, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 702, DateTimeKind.Utc).AddTicks(2510), new DateTime(2020, 6, 9, 14, 28, 53, 702, DateTimeKind.Utc).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 702, DateTimeKind.Utc).AddTicks(3983), new DateTime(2020, 6, 9, 14, 28, 53, 702, DateTimeKind.Utc).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 702, DateTimeKind.Utc).AddTicks(4081), new DateTime(2020, 6, 9, 14, 28, 53, 702, DateTimeKind.Utc).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 702, DateTimeKind.Utc).AddTicks(4085), new DateTime(2020, 6, 9, 14, 28, 53, 702, DateTimeKind.Utc).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 14, 28, 53, 705, DateTimeKind.Utc).AddTicks(4162), new DateTime(2020, 6, 9, 14, 28, 53, 705, DateTimeKind.Utc).AddTicks(7361) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(3007), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(4422), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(4481), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(4484), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Method", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(8031), 0, new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Method", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(9384), 1, new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(5176), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6338), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6373), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6377), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6380), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6384), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6388), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6391), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6395), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6398), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6402), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6406), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6410), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6413), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6417), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6420), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6424), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6427), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6431), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6434), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6437), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6441), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6444), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6448), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6451), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6455), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6458), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6462), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6465), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6468), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6472), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6475), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6476) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6479), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6482), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6506), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6510), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6513), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6517), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6520), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6524), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6527), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6531), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6534), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6538), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6541), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6544), new DateTime(2020, 6, 8, 10, 49, 29, 593, DateTimeKind.Utc).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(7369), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9358), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9423), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9428), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9432), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9435), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9439), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9443), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9446), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9449), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9453), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9457), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9460), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9464), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9468), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9471), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9475), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9478), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9482), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9485), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9489), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9492), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9496), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 590, DateTimeKind.Utc).AddTicks(2265), new DateTime(2020, 6, 8, 10, 49, 29, 590, DateTimeKind.Utc).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 590, DateTimeKind.Utc).AddTicks(3494), new DateTime(2020, 6, 8, 10, 49, 29, 590, DateTimeKind.Utc).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 590, DateTimeKind.Utc).AddTicks(3544), new DateTime(2020, 6, 8, 10, 49, 29, 590, DateTimeKind.Utc).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 590, DateTimeKind.Utc).AddTicks(3548), new DateTime(2020, 6, 8, 10, 49, 29, 590, DateTimeKind.Utc).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 10, 49, 29, 591, DateTimeKind.Utc).AddTicks(9708), new DateTime(2020, 6, 8, 10, 49, 29, 592, DateTimeKind.Utc).AddTicks(329) });
        }
    }
}
