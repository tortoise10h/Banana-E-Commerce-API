using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class UpdateProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_Product_ProductId",
                table: "CartDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Product_ProductId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Admin_CreatedBy",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Storage_StorageId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductExportDetail_Product_ProductId",
                table: "ProductExportDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFavorite_Product_ProductId",
                table: "ProductFavorite");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_Product_ProductId",
                table: "ProductImage");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Product_ProductId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyProduct_Product_ProductId",
                table: "SupplyProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Product_StorageId",
                table: "Products",
                newName: "IX_Products_StorageId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CreatedBy",
                table: "Products",
                newName: "IX_Products_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(4666), new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(6157), new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(6195), new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(6199), new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(6202), new DateTime(2020, 5, 14, 14, 22, 12, 851, DateTimeKind.Utc).AddTicks(6204) });

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_Products_ProductId",
                table: "CartDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Products_ProductId",
                table: "OrderItem",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductExportDetail_Products_ProductId",
                table: "ProductExportDetail",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFavorite_Products_ProductId",
                table: "ProductFavorite",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_Products_ProductId",
                table: "ProductImage",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Admin_CreatedBy",
                table: "Products",
                column: "CreatedBy",
                principalTable: "Admin",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Storage_StorageId",
                table: "Products",
                column: "StorageId",
                principalTable: "Storage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Products_ProductId",
                table: "Rating",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyProduct_Products_ProductId",
                table: "SupplyProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_Products_ProductId",
                table: "CartDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Products_ProductId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductExportDetail_Products_ProductId",
                table: "ProductExportDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFavorite_Products_ProductId",
                table: "ProductFavorite");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_Products_ProductId",
                table: "ProductImage");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Admin_CreatedBy",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Storage_StorageId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Products_ProductId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyProduct_Products_ProductId",
                table: "SupplyProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameIndex(
                name: "IX_Products_StorageId",
                table: "Product",
                newName: "IX_Product_StorageId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CreatedBy",
                table: "Product",
                newName: "IX_Product_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Product",
                newName: "IX_Product_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 13, 12, 44, 16, 839, DateTimeKind.Utc).AddTicks(5516), new DateTime(2020, 5, 13, 12, 44, 16, 839, DateTimeKind.Utc).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 13, 12, 44, 16, 839, DateTimeKind.Utc).AddTicks(6914), new DateTime(2020, 5, 13, 12, 44, 16, 839, DateTimeKind.Utc).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 13, 12, 44, 16, 839, DateTimeKind.Utc).AddTicks(6967), new DateTime(2020, 5, 13, 12, 44, 16, 839, DateTimeKind.Utc).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 13, 12, 44, 16, 839, DateTimeKind.Utc).AddTicks(6971), new DateTime(2020, 5, 13, 12, 44, 16, 839, DateTimeKind.Utc).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 13, 12, 44, 16, 839, DateTimeKind.Utc).AddTicks(6974), new DateTime(2020, 5, 13, 12, 44, 16, 839, DateTimeKind.Utc).AddTicks(6975) });

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_Product_ProductId",
                table: "CartDetails",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Product_ProductId",
                table: "OrderItem",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Admin_CreatedBy",
                table: "Product",
                column: "CreatedBy",
                principalTable: "Admin",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Storage_StorageId",
                table: "Product",
                column: "StorageId",
                principalTable: "Storage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductExportDetail_Product_ProductId",
                table: "ProductExportDetail",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFavorite_Product_ProductId",
                table: "ProductFavorite",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_Product_ProductId",
                table: "ProductImage",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Product_ProductId",
                table: "Rating",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyProduct_Product_ProductId",
                table: "SupplyProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");
        }
    }
}
