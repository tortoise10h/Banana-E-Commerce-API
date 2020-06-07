using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Add_IsDeleted_And_Description_To_ProductTierTransferReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ProductTierTransferReports",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ProductTierTransferReports",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(4682), new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(6140), new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(6195), new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(6199), new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(7611), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8829), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8866), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8870), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8874), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8877), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8881), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8884), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8899), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8903), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8906), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8910), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8913), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8917), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8920), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8924), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8927), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8931), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8935), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8938), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8941), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8945), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8948), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(9208), new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1602), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1670), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1674), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1678), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1681), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1685), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1689), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1692), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1696), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1699), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1703), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1707), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1710), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1714), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1718), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1721), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1724), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1728), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1731), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1735), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1739), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1742), new DateTime(2020, 6, 7, 11, 4, 22, 151, DateTimeKind.Utc).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 148, DateTimeKind.Utc).AddTicks(3899), new DateTime(2020, 6, 7, 11, 4, 22, 148, DateTimeKind.Utc).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 148, DateTimeKind.Utc).AddTicks(5196), new DateTime(2020, 6, 7, 11, 4, 22, 148, DateTimeKind.Utc).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 148, DateTimeKind.Utc).AddTicks(5249), new DateTime(2020, 6, 7, 11, 4, 22, 148, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 148, DateTimeKind.Utc).AddTicks(5252), new DateTime(2020, 6, 7, 11, 4, 22, 148, DateTimeKind.Utc).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(2103), new DateTime(2020, 6, 7, 11, 4, 22, 150, DateTimeKind.Utc).AddTicks(2544) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ProductTierTransferReports");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ProductTierTransferReports");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(7499), new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(8924), new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(8971), new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(8975), new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(9343), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(460), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(497), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(500), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(505), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(509), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(513), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(516), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(520), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(524), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(528), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(532), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(535), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(539), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(543), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(547), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(551), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(555), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(558), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(562), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(566), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(570), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(574), new DateTime(2020, 6, 7, 8, 57, 23, 500, DateTimeKind.Utc).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(1765), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(3938), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(3999), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4004), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4008), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4011), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4015), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4019), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4023), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4027), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4031), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4034), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4038), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4043), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4047), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4051), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4055), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4058), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4062), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4066), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4070), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4073), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4077), new DateTime(2020, 6, 7, 8, 57, 23, 499, DateTimeKind.Utc).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 496, DateTimeKind.Utc).AddTicks(7647), new DateTime(2020, 6, 7, 8, 57, 23, 496, DateTimeKind.Utc).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 496, DateTimeKind.Utc).AddTicks(8869), new DateTime(2020, 6, 7, 8, 57, 23, 496, DateTimeKind.Utc).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 496, DateTimeKind.Utc).AddTicks(8916), new DateTime(2020, 6, 7, 8, 57, 23, 496, DateTimeKind.Utc).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 496, DateTimeKind.Utc).AddTicks(8919), new DateTime(2020, 6, 7, 8, 57, 23, 496, DateTimeKind.Utc).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(4886), new DateTime(2020, 6, 7, 8, 57, 23, 498, DateTimeKind.Utc).AddTicks(5296) });
        }
    }
}
