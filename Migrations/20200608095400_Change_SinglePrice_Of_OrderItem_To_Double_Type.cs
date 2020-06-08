using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Change_SinglePrice_Of_OrderItem_To_Double_Type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "SinglePrice",
                table: "OrderItems",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 505, DateTimeKind.Utc).AddTicks(8739), new DateTime(2020, 6, 8, 9, 53, 59, 505, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(59), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(125), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(129), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(3163), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(4423), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(606), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1712), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1744), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1748), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1752), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1755), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1759), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1763), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1766), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1770), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1773), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1777), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1781), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1798), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1801), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1805), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1808), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1812), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1816), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1819), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1825), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1828), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1832), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1835), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1839), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1842), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1846), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1849), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1853), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1856), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1859), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1863), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1867), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1870), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1873), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1877), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1880), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1884), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1887), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1891), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1894), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1897), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1901), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1904), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1908), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1911), new DateTime(2020, 6, 8, 9, 53, 59, 507, DateTimeKind.Utc).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(3036), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5059), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5124), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5129), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5133), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5136), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5140), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5144), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5147), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5151), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5155), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5159), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5163), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5166), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5170), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5174), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5178), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5181), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5185), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5188), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5192), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5195), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5196) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5199), new DateTime(2020, 6, 8, 9, 53, 59, 506, DateTimeKind.Utc).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 503, DateTimeKind.Utc).AddTicks(8355), new DateTime(2020, 6, 8, 9, 53, 59, 503, DateTimeKind.Utc).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 503, DateTimeKind.Utc).AddTicks(9603), new DateTime(2020, 6, 8, 9, 53, 59, 503, DateTimeKind.Utc).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 503, DateTimeKind.Utc).AddTicks(9658), new DateTime(2020, 6, 8, 9, 53, 59, 503, DateTimeKind.Utc).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 503, DateTimeKind.Utc).AddTicks(9661), new DateTime(2020, 6, 8, 9, 53, 59, 503, DateTimeKind.Utc).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 9, 53, 59, 505, DateTimeKind.Utc).AddTicks(6031), new DateTime(2020, 6, 8, 9, 53, 59, 505, DateTimeKind.Utc).AddTicks(6496) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SinglePrice",
                table: "OrderItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 72, DateTimeKind.Utc).AddTicks(7594), new DateTime(2020, 6, 8, 4, 41, 31, 72, DateTimeKind.Utc).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 72, DateTimeKind.Utc).AddTicks(9167), new DateTime(2020, 6, 8, 4, 41, 31, 72, DateTimeKind.Utc).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 72, DateTimeKind.Utc).AddTicks(9225), new DateTime(2020, 6, 8, 4, 41, 31, 72, DateTimeKind.Utc).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 72, DateTimeKind.Utc).AddTicks(9230), new DateTime(2020, 6, 8, 4, 41, 31, 72, DateTimeKind.Utc).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(3121), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(4496), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(442), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1588), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1625), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1629), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1633), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1636), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1640), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1644), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1647), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1650), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1655), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1659), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1662), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1666), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1672), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1675), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1679), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1682), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1686), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1704), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1707), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1711), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1714), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1718), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1722), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1725), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1729), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1732), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1736), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1739), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1743), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1747), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1751), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1754), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1758), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1762), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1765), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1769), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1772), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1776), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1779), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1780) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1783), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1786), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1791), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1794), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1798), new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(2540), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4530), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4622), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4692), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4696), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4700), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4704), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4707), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4711), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4717), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4721), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4725), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4728), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4732), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4735), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4739), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4742), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4746), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4749), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4753), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4756), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4760), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4763), new DateTime(2020, 6, 8, 4, 41, 31, 73, DateTimeKind.Utc).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 69, DateTimeKind.Utc).AddTicks(8139), new DateTime(2020, 6, 8, 4, 41, 31, 69, DateTimeKind.Utc).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 69, DateTimeKind.Utc).AddTicks(9611), new DateTime(2020, 6, 8, 4, 41, 31, 69, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 69, DateTimeKind.Utc).AddTicks(9672), new DateTime(2020, 6, 8, 4, 41, 31, 69, DateTimeKind.Utc).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 69, DateTimeKind.Utc).AddTicks(9677), new DateTime(2020, 6, 8, 4, 41, 31, 69, DateTimeKind.Utc).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 8, 4, 41, 31, 72, DateTimeKind.Utc).AddTicks(4534), new DateTime(2020, 6, 8, 4, 41, 31, 72, DateTimeKind.Utc).AddTicks(5128) });
        }
    }
}
