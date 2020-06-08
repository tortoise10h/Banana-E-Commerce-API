using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Add_Order_And_PaymentMethod_Relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentMethodId",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Method", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(3121), 1, false, 0, new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(3490) },
                    { 2, new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(4496), 1, false, 1, new DateTime(2020, 6, 8, 4, 41, 31, 74, DateTimeKind.Utc).AddTicks(4510) }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentMethodId",
                table: "Orders",
                column: "PaymentMethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PaymentMethods_PaymentMethodId",
                table: "Orders",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PaymentMethods_PaymentMethodId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PaymentMethodId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "PaymentMethodId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 780, DateTimeKind.Utc).AddTicks(8406), new DateTime(2020, 6, 7, 11, 11, 25, 780, DateTimeKind.Utc).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 781, DateTimeKind.Utc).AddTicks(4930), new DateTime(2020, 6, 7, 11, 11, 25, 781, DateTimeKind.Utc).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 781, DateTimeKind.Utc).AddTicks(5042), new DateTime(2020, 6, 7, 11, 11, 25, 781, DateTimeKind.Utc).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 781, DateTimeKind.Utc).AddTicks(5048), new DateTime(2020, 6, 7, 11, 11, 25, 781, DateTimeKind.Utc).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(3889), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6463), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6527), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6534), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6541), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6548), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6554), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6561), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6566), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6572), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6735), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6742), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6748), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6754), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6760), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6766), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6772), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6779), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6785), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6790), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6796), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6802), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6808), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6814), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6819), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6825), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6831), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6837), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6843), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6849), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6856), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6862), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6868), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6875), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6881), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6891), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6898), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6905), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6911), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6916), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6922), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6930), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6935), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6941), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6947), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6952), new DateTime(2020, 6, 7, 11, 11, 25, 786, DateTimeKind.Utc).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(3970), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8546), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8771), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8779), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8786), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8793), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8800), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8806), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8813), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8819), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8825), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8832), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8839), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8846), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8852), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8859), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8865), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8872), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8879), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8886), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8895), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8903), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8910), new DateTime(2020, 6, 7, 11, 11, 25, 782, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 775, DateTimeKind.Utc).AddTicks(3389), new DateTime(2020, 6, 7, 11, 11, 25, 775, DateTimeKind.Utc).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 775, DateTimeKind.Utc).AddTicks(6064), new DateTime(2020, 6, 7, 11, 11, 25, 775, DateTimeKind.Utc).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 775, DateTimeKind.Utc).AddTicks(6138), new DateTime(2020, 6, 7, 11, 11, 25, 775, DateTimeKind.Utc).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 775, DateTimeKind.Utc).AddTicks(6145), new DateTime(2020, 6, 7, 11, 11, 25, 775, DateTimeKind.Utc).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 11, 25, 780, DateTimeKind.Utc).AddTicks(3545), new DateTime(2020, 6, 7, 11, 11, 25, 780, DateTimeKind.Utc).AddTicks(4372) });
        }
    }
}
