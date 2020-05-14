using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Fix_Price_Currency_Field_Syntax_In_Product_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Customers_CustomerId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Admin_Users_UserId",
                table: "Admin");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_Admin_CreatedBy",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportBill_Storage_StorageId",
                table: "ImportBill");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportBill_StorageManager_StorageManagerId",
                table: "ImportBill");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportBill_Supplier_SupplierId",
                table: "ImportBill");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportBillDetail_ImportBill_ImportBillId",
                table: "ImportBillDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportBillDetail_SupplyProduct_SupplyProductId",
                table: "ImportBillDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_PaymentMethod_PaymentMethodId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Shipment_ShipmentId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Manager_Users_UserId",
                table: "Manager");

            migrationBuilder.DropForeignKey(
                name: "FK_Notification_Admin_CreatedBy",
                table: "Notification");

            migrationBuilder.DropForeignKey(
                name: "FK_Notification_Users_NotificationTo",
                table: "Notification");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Address_AddressId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customers_CustomerId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Products_ProductId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_Admin_CreatedBy",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductExportBill_StorageManager_StorageManagerId",
                table: "ProductExportBill");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductExportDetail_ProductExportBill_ExportBillId",
                table: "ProductExportDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductExportDetail_Products_ProductId",
                table: "ProductExportDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFavorite_Customers_CustomerId",
                table: "ProductFavorite");

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
                name: "FK_Rating_Customers_CustomerId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Products_ProductId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipment_Admin_CreatedBy",
                table: "Shipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipment_Order_OrderId",
                table: "Shipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipment_ProductExportBill_ProductExportBillId",
                table: "Shipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipment_Shipper_ShipperId",
                table: "Shipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipper_Admin_AdminId",
                table: "Shipper");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipper_Users_UserId",
                table: "Shipper");

            migrationBuilder.DropForeignKey(
                name: "FK_Storage_Admin_UserId",
                table: "Storage");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageManager_Storage_StorageId",
                table: "StorageManager");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageManager_Users_UserId",
                table: "StorageManager");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierPayment_Admin_CreatedBy",
                table: "SupplierPayment");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierPayment_Supplier_SupplierId",
                table: "SupplierPayment");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyProduct_Products_ProductId",
                table: "SupplyProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyProduct_Supplier_SupplierId",
                table: "SupplyProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyProduct_Users_UserId",
                table: "SupplyProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplyProduct",
                table: "SupplyProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierPayment",
                table: "SupplierPayment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StorageManager",
                table: "StorageManager");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Storage",
                table: "Storage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shipper",
                table: "Shipper");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shipment",
                table: "Shipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rating",
                table: "Rating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImage",
                table: "ProductImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductFavorite",
                table: "ProductFavorite");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductExportDetail",
                table: "ProductExportDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductExportBill",
                table: "ProductExportBill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentMethod",
                table: "PaymentMethod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notification",
                table: "Notification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manager",
                table: "Manager");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImportBillDetail",
                table: "ImportBillDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImportBill",
                table: "ImportBill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "PriceCurrentcy",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "SupplyProduct",
                newName: "SupplyProducts");

            migrationBuilder.RenameTable(
                name: "SupplierPayment",
                newName: "SupplierPayments");

            migrationBuilder.RenameTable(
                name: "Supplier",
                newName: "Suppliers");

            migrationBuilder.RenameTable(
                name: "StorageManager",
                newName: "StorageManagers");

            migrationBuilder.RenameTable(
                name: "Storage",
                newName: "Storages");

            migrationBuilder.RenameTable(
                name: "Shipper",
                newName: "Shippers");

            migrationBuilder.RenameTable(
                name: "Shipment",
                newName: "Shipments");

            migrationBuilder.RenameTable(
                name: "Rating",
                newName: "Rates");

            migrationBuilder.RenameTable(
                name: "ProductImage",
                newName: "ProductImages");

            migrationBuilder.RenameTable(
                name: "ProductFavorite",
                newName: "ProductFavorites");

            migrationBuilder.RenameTable(
                name: "ProductExportDetail",
                newName: "ProductExportDetails");

            migrationBuilder.RenameTable(
                name: "ProductExportBill",
                newName: "ProductExportBills");

            migrationBuilder.RenameTable(
                name: "PaymentMethod",
                newName: "PaymentMethods");

            migrationBuilder.RenameTable(
                name: "OrderItem",
                newName: "OrderItems");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Notification",
                newName: "Notifications");

            migrationBuilder.RenameTable(
                name: "Manager",
                newName: "Managers");

            migrationBuilder.RenameTable(
                name: "Invoice",
                newName: "Invoices");

            migrationBuilder.RenameTable(
                name: "ImportBillDetail",
                newName: "ImportBillDetails");

            migrationBuilder.RenameTable(
                name: "ImportBill",
                newName: "ImportBills");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "Admin",
                newName: "Admins");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_SupplyProduct_UserId",
                table: "SupplyProducts",
                newName: "IX_SupplyProducts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SupplyProduct_SupplierId",
                table: "SupplyProducts",
                newName: "IX_SupplyProducts_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_SupplyProduct_ProductId",
                table: "SupplyProducts",
                newName: "IX_SupplyProducts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_SupplierPayment_SupplierId",
                table: "SupplierPayments",
                newName: "IX_SupplierPayments_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_SupplierPayment_CreatedBy",
                table: "SupplierPayments",
                newName: "IX_SupplierPayments_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_StorageManager_UserId",
                table: "StorageManagers",
                newName: "IX_StorageManagers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_StorageManager_StorageId",
                table: "StorageManagers",
                newName: "IX_StorageManagers_StorageId");

            migrationBuilder.RenameIndex(
                name: "IX_Storage_UserId",
                table: "Storages",
                newName: "IX_Storages_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Shipper_UserId",
                table: "Shippers",
                newName: "IX_Shippers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Shipper_AdminId",
                table: "Shippers",
                newName: "IX_Shippers_AdminId");

            migrationBuilder.RenameIndex(
                name: "IX_Shipment_ShipperId",
                table: "Shipments",
                newName: "IX_Shipments_ShipperId");

            migrationBuilder.RenameIndex(
                name: "IX_Shipment_ProductExportBillId",
                table: "Shipments",
                newName: "IX_Shipments_ProductExportBillId");

            migrationBuilder.RenameIndex(
                name: "IX_Shipment_OrderId",
                table: "Shipments",
                newName: "IX_Shipments_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Shipment_CreatedBy",
                table: "Shipments",
                newName: "IX_Shipments_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_ProductId",
                table: "Rates",
                newName: "IX_Rates_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_CustomerId",
                table: "Rates",
                newName: "IX_Rates_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductFavorite_ProductId",
                table: "ProductFavorites",
                newName: "IX_ProductFavorites_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductFavorite_CustomerId",
                table: "ProductFavorites",
                newName: "IX_ProductFavorites_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductExportDetail_ProductId",
                table: "ProductExportDetails",
                newName: "IX_ProductExportDetails_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductExportDetail_ExportBillId",
                table: "ProductExportDetails",
                newName: "IX_ProductExportDetails_ExportBillId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductExportBill_StorageManagerId",
                table: "ProductExportBills",
                newName: "IX_ProductExportBills_StorageManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_CreatedBy",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItems",
                newName: "IX_OrderItems_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CustomerId",
                table: "Orders",
                newName: "IX_Orders_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_AddressId",
                table: "Orders",
                newName: "IX_Orders_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Notification_NotificationTo",
                table: "Notifications",
                newName: "IX_Notifications_NotificationTo");

            migrationBuilder.RenameIndex(
                name: "IX_Notification_CreatedBy",
                table: "Notifications",
                newName: "IX_Notifications_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Manager_UserId",
                table: "Managers",
                newName: "IX_Managers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_ShipmentId",
                table: "Invoices",
                newName: "IX_Invoices_ShipmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_PaymentMethodId",
                table: "Invoices",
                newName: "IX_Invoices_PaymentMethodId");

            migrationBuilder.RenameIndex(
                name: "IX_ImportBillDetail_SupplyProductId",
                table: "ImportBillDetails",
                newName: "IX_ImportBillDetails_SupplyProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ImportBillDetail_ImportBillId",
                table: "ImportBillDetails",
                newName: "IX_ImportBillDetails_ImportBillId");

            migrationBuilder.RenameIndex(
                name: "IX_ImportBill_SupplierId",
                table: "ImportBills",
                newName: "IX_ImportBills_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_ImportBill_StorageManagerId",
                table: "ImportBills",
                newName: "IX_ImportBills_StorageManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_ImportBill_StorageId",
                table: "ImportBills",
                newName: "IX_ImportBills_StorageId");

            migrationBuilder.RenameIndex(
                name: "IX_Category_CreatedBy",
                table: "Categories",
                newName: "IX_Categories_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Admin_UserId",
                table: "Admins",
                newName: "IX_Admins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_CustomerId",
                table: "Addresses",
                newName: "IX_Addresses_CustomerId");

            migrationBuilder.AddColumn<int>(
                name: "PriceCurrency",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplyProducts",
                table: "SupplyProducts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierPayments",
                table: "SupplierPayments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StorageManagers",
                table: "StorageManagers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Storages",
                table: "Storages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shippers",
                table: "Shippers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shipments",
                table: "Shipments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rates",
                table: "Rates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductFavorites",
                table: "ProductFavorites",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductExportDetails",
                table: "ProductExportDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductExportBills",
                table: "ProductExportBills",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentMethods",
                table: "PaymentMethods",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Managers",
                table: "Managers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImportBillDetails",
                table: "ImportBillDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImportBills",
                table: "ImportBills",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalAmount = table.Column<double>(nullable: false),
                    Currency = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AdminId = table.Column<int>(nullable: true),
                    ExportBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(5129), new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(6425), new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(6483), new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(6485) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(6487), new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(6490), new DateTime(2020, 5, 14, 14, 43, 0, 85, DateTimeKind.Utc).AddTicks(6491) });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_AdminId",
                table: "Payments",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Customers_CustomerId",
                table: "Addresses",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Users_UserId",
                table: "Admins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Admins_CreatedBy",
                table: "Categories",
                column: "CreatedBy",
                principalTable: "Admins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImportBillDetails_ImportBills_ImportBillId",
                table: "ImportBillDetails",
                column: "ImportBillId",
                principalTable: "ImportBills",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImportBillDetails_SupplyProducts_SupplyProductId",
                table: "ImportBillDetails",
                column: "SupplyProductId",
                principalTable: "SupplyProducts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImportBills_Storages_StorageId",
                table: "ImportBills",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImportBills_StorageManagers_StorageManagerId",
                table: "ImportBills",
                column: "StorageManagerId",
                principalTable: "StorageManagers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImportBills_Suppliers_SupplierId",
                table: "ImportBills",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_PaymentMethods_PaymentMethodId",
                table: "Invoices",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Shipments_ShipmentId",
                table: "Invoices",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_Users_UserId",
                table: "Managers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Admins_CreatedBy",
                table: "Notifications",
                column: "CreatedBy",
                principalTable: "Admins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Users_NotificationTo",
                table: "Notifications",
                column: "NotificationTo",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_Admins_CreatedBy",
                table: "PaymentMethods",
                column: "CreatedBy",
                principalTable: "Admins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductExportBills_StorageManagers_StorageManagerId",
                table: "ProductExportBills",
                column: "StorageManagerId",
                principalTable: "StorageManagers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductExportDetails_ProductExportBills_ExportBillId",
                table: "ProductExportDetails",
                column: "ExportBillId",
                principalTable: "ProductExportBills",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductExportDetails_Products_ProductId",
                table: "ProductExportDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFavorites_Customers_CustomerId",
                table: "ProductFavorites",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFavorites_Products_ProductId",
                table: "ProductFavorites",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Admins_CreatedBy",
                table: "Products",
                column: "CreatedBy",
                principalTable: "Admins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Storages_StorageId",
                table: "Products",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_Customers_CustomerId",
                table: "Rates",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_Products_ProductId",
                table: "Rates",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Admins_CreatedBy",
                table: "Shipments",
                column: "CreatedBy",
                principalTable: "Admins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Orders_OrderId",
                table: "Shipments",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_ProductExportBills_ProductExportBillId",
                table: "Shipments",
                column: "ProductExportBillId",
                principalTable: "ProductExportBills",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Shippers_ShipperId",
                table: "Shipments",
                column: "ShipperId",
                principalTable: "Shippers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shippers_Admins_AdminId",
                table: "Shippers",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shippers_Users_UserId",
                table: "Shippers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StorageManagers_Storages_StorageId",
                table: "StorageManagers",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StorageManagers_Users_UserId",
                table: "StorageManagers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Admins_UserId",
                table: "Storages",
                column: "UserId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierPayments_Admins_CreatedBy",
                table: "SupplierPayments",
                column: "CreatedBy",
                principalTable: "Admins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierPayments_Suppliers_SupplierId",
                table: "SupplierPayments",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyProducts_Products_ProductId",
                table: "SupplyProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyProducts_Suppliers_SupplierId",
                table: "SupplyProducts",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyProducts_Users_UserId",
                table: "SupplyProducts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Customers_CustomerId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Users_UserId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Admins_CreatedBy",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportBillDetails_ImportBills_ImportBillId",
                table: "ImportBillDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportBillDetails_SupplyProducts_SupplyProductId",
                table: "ImportBillDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportBills_Storages_StorageId",
                table: "ImportBills");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportBills_StorageManagers_StorageManagerId",
                table: "ImportBills");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportBills_Suppliers_SupplierId",
                table: "ImportBills");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_PaymentMethods_PaymentMethodId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Shipments_ShipmentId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Managers_Users_UserId",
                table: "Managers");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Admins_CreatedBy",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Users_NotificationTo",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_Admins_CreatedBy",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductExportBills_StorageManagers_StorageManagerId",
                table: "ProductExportBills");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductExportDetails_ProductExportBills_ExportBillId",
                table: "ProductExportDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductExportDetails_Products_ProductId",
                table: "ProductExportDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFavorites_Customers_CustomerId",
                table: "ProductFavorites");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFavorites_Products_ProductId",
                table: "ProductFavorites");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Admins_CreatedBy",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Storages_StorageId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Rates_Customers_CustomerId",
                table: "Rates");

            migrationBuilder.DropForeignKey(
                name: "FK_Rates_Products_ProductId",
                table: "Rates");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Admins_CreatedBy",
                table: "Shipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Orders_OrderId",
                table: "Shipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_ProductExportBills_ProductExportBillId",
                table: "Shipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Shippers_ShipperId",
                table: "Shipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Shippers_Admins_AdminId",
                table: "Shippers");

            migrationBuilder.DropForeignKey(
                name: "FK_Shippers_Users_UserId",
                table: "Shippers");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageManagers_Storages_StorageId",
                table: "StorageManagers");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageManagers_Users_UserId",
                table: "StorageManagers");

            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Admins_UserId",
                table: "Storages");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierPayments_Admins_CreatedBy",
                table: "SupplierPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierPayments_Suppliers_SupplierId",
                table: "SupplierPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyProducts_Products_ProductId",
                table: "SupplyProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyProducts_Suppliers_SupplierId",
                table: "SupplyProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyProducts_Users_UserId",
                table: "SupplyProducts");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplyProducts",
                table: "SupplyProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierPayments",
                table: "SupplierPayments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Storages",
                table: "Storages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StorageManagers",
                table: "StorageManagers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shippers",
                table: "Shippers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shipments",
                table: "Shipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rates",
                table: "Rates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductFavorites",
                table: "ProductFavorites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductExportDetails",
                table: "ProductExportDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductExportBills",
                table: "ProductExportBills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentMethods",
                table: "PaymentMethods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Managers",
                table: "Managers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImportBills",
                table: "ImportBills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImportBillDetails",
                table: "ImportBillDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "PriceCurrency",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "SupplyProducts",
                newName: "SupplyProduct");

            migrationBuilder.RenameTable(
                name: "Suppliers",
                newName: "Supplier");

            migrationBuilder.RenameTable(
                name: "SupplierPayments",
                newName: "SupplierPayment");

            migrationBuilder.RenameTable(
                name: "Storages",
                newName: "Storage");

            migrationBuilder.RenameTable(
                name: "StorageManagers",
                newName: "StorageManager");

            migrationBuilder.RenameTable(
                name: "Shippers",
                newName: "Shipper");

            migrationBuilder.RenameTable(
                name: "Shipments",
                newName: "Shipment");

            migrationBuilder.RenameTable(
                name: "Rates",
                newName: "Rating");

            migrationBuilder.RenameTable(
                name: "ProductImages",
                newName: "ProductImage");

            migrationBuilder.RenameTable(
                name: "ProductFavorites",
                newName: "ProductFavorite");

            migrationBuilder.RenameTable(
                name: "ProductExportDetails",
                newName: "ProductExportDetail");

            migrationBuilder.RenameTable(
                name: "ProductExportBills",
                newName: "ProductExportBill");

            migrationBuilder.RenameTable(
                name: "PaymentMethods",
                newName: "PaymentMethod");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "OrderItem");

            migrationBuilder.RenameTable(
                name: "Notifications",
                newName: "Notification");

            migrationBuilder.RenameTable(
                name: "Managers",
                newName: "Manager");

            migrationBuilder.RenameTable(
                name: "Invoices",
                newName: "Invoice");

            migrationBuilder.RenameTable(
                name: "ImportBills",
                newName: "ImportBill");

            migrationBuilder.RenameTable(
                name: "ImportBillDetails",
                newName: "ImportBillDetail");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "Admins",
                newName: "Admin");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_SupplyProducts_UserId",
                table: "SupplyProduct",
                newName: "IX_SupplyProduct_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SupplyProducts_SupplierId",
                table: "SupplyProduct",
                newName: "IX_SupplyProduct_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_SupplyProducts_ProductId",
                table: "SupplyProduct",
                newName: "IX_SupplyProduct_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_SupplierPayments_SupplierId",
                table: "SupplierPayment",
                newName: "IX_SupplierPayment_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_SupplierPayments_CreatedBy",
                table: "SupplierPayment",
                newName: "IX_SupplierPayment_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Storages_UserId",
                table: "Storage",
                newName: "IX_Storage_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_StorageManagers_UserId",
                table: "StorageManager",
                newName: "IX_StorageManager_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_StorageManagers_StorageId",
                table: "StorageManager",
                newName: "IX_StorageManager_StorageId");

            migrationBuilder.RenameIndex(
                name: "IX_Shippers_UserId",
                table: "Shipper",
                newName: "IX_Shipper_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Shippers_AdminId",
                table: "Shipper",
                newName: "IX_Shipper_AdminId");

            migrationBuilder.RenameIndex(
                name: "IX_Shipments_ShipperId",
                table: "Shipment",
                newName: "IX_Shipment_ShipperId");

            migrationBuilder.RenameIndex(
                name: "IX_Shipments_ProductExportBillId",
                table: "Shipment",
                newName: "IX_Shipment_ProductExportBillId");

            migrationBuilder.RenameIndex(
                name: "IX_Shipments_OrderId",
                table: "Shipment",
                newName: "IX_Shipment_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Shipments_CreatedBy",
                table: "Shipment",
                newName: "IX_Shipment_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Rates_ProductId",
                table: "Rating",
                newName: "IX_Rating_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Rates_CustomerId",
                table: "Rating",
                newName: "IX_Rating_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImage",
                newName: "IX_ProductImage_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductFavorites_ProductId",
                table: "ProductFavorite",
                newName: "IX_ProductFavorite_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductFavorites_CustomerId",
                table: "ProductFavorite",
                newName: "IX_ProductFavorite_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductExportDetails_ProductId",
                table: "ProductExportDetail",
                newName: "IX_ProductExportDetail_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductExportDetails_ExportBillId",
                table: "ProductExportDetail",
                newName: "IX_ProductExportDetail_ExportBillId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductExportBills_StorageManagerId",
                table: "ProductExportBill",
                newName: "IX_ProductExportBill_StorageManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_CreatedBy",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerId",
                table: "Order",
                newName: "IX_Order_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_AddressId",
                table: "Order",
                newName: "IX_Order_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItem",
                newName: "IX_OrderItem_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItem",
                newName: "IX_OrderItem_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Notifications_NotificationTo",
                table: "Notification",
                newName: "IX_Notification_NotificationTo");

            migrationBuilder.RenameIndex(
                name: "IX_Notifications_CreatedBy",
                table: "Notification",
                newName: "IX_Notification_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Managers_UserId",
                table: "Manager",
                newName: "IX_Manager_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_ShipmentId",
                table: "Invoice",
                newName: "IX_Invoice_ShipmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_PaymentMethodId",
                table: "Invoice",
                newName: "IX_Invoice_PaymentMethodId");

            migrationBuilder.RenameIndex(
                name: "IX_ImportBills_SupplierId",
                table: "ImportBill",
                newName: "IX_ImportBill_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_ImportBills_StorageManagerId",
                table: "ImportBill",
                newName: "IX_ImportBill_StorageManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_ImportBills_StorageId",
                table: "ImportBill",
                newName: "IX_ImportBill_StorageId");

            migrationBuilder.RenameIndex(
                name: "IX_ImportBillDetails_SupplyProductId",
                table: "ImportBillDetail",
                newName: "IX_ImportBillDetail_SupplyProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ImportBillDetails_ImportBillId",
                table: "ImportBillDetail",
                newName: "IX_ImportBillDetail_ImportBillId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_CreatedBy",
                table: "Category",
                newName: "IX_Category_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Admins_UserId",
                table: "Admin",
                newName: "IX_Admin_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_CustomerId",
                table: "Address",
                newName: "IX_Address_CustomerId");

            migrationBuilder.AddColumn<int>(
                name: "PriceCurrentcy",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplyProduct",
                table: "SupplyProduct",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierPayment",
                table: "SupplierPayment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Storage",
                table: "Storage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StorageManager",
                table: "StorageManager",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shipper",
                table: "Shipper",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shipment",
                table: "Shipment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rating",
                table: "Rating",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImage",
                table: "ProductImage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductFavorite",
                table: "ProductFavorite",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductExportDetail",
                table: "ProductExportDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductExportBill",
                table: "ProductExportBill",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentMethod",
                table: "PaymentMethod",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notification",
                table: "Notification",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manager",
                table: "Manager",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImportBill",
                table: "ImportBill",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImportBillDetail",
                table: "ImportBillDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 25, 51, 146, DateTimeKind.Utc).AddTicks(9288), new DateTime(2020, 5, 14, 14, 25, 51, 146, DateTimeKind.Utc).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 25, 51, 147, DateTimeKind.Utc).AddTicks(498), new DateTime(2020, 5, 14, 14, 25, 51, 147, DateTimeKind.Utc).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 25, 51, 147, DateTimeKind.Utc).AddTicks(550), new DateTime(2020, 5, 14, 14, 25, 51, 147, DateTimeKind.Utc).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 25, 51, 147, DateTimeKind.Utc).AddTicks(554), new DateTime(2020, 5, 14, 14, 25, 51, 147, DateTimeKind.Utc).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 25, 51, 147, DateTimeKind.Utc).AddTicks(557), new DateTime(2020, 5, 14, 14, 25, 51, 147, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Customers_CustomerId",
                table: "Address",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_Users_UserId",
                table: "Admin",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Admin_CreatedBy",
                table: "Category",
                column: "CreatedBy",
                principalTable: "Admin",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImportBill_Storage_StorageId",
                table: "ImportBill",
                column: "StorageId",
                principalTable: "Storage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImportBill_StorageManager_StorageManagerId",
                table: "ImportBill",
                column: "StorageManagerId",
                principalTable: "StorageManager",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImportBill_Supplier_SupplierId",
                table: "ImportBill",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImportBillDetail_ImportBill_ImportBillId",
                table: "ImportBillDetail",
                column: "ImportBillId",
                principalTable: "ImportBill",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImportBillDetail_SupplyProduct_SupplyProductId",
                table: "ImportBillDetail",
                column: "SupplyProductId",
                principalTable: "SupplyProduct",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_PaymentMethod_PaymentMethodId",
                table: "Invoice",
                column: "PaymentMethodId",
                principalTable: "PaymentMethod",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Shipment_ShipmentId",
                table: "Invoice",
                column: "ShipmentId",
                principalTable: "Shipment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Manager_Users_UserId",
                table: "Manager",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_Admin_CreatedBy",
                table: "Notification",
                column: "CreatedBy",
                principalTable: "Admin",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_Users_NotificationTo",
                table: "Notification",
                column: "NotificationTo",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Address_AddressId",
                table: "Order",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customers_CustomerId",
                table: "Order",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Products_ProductId",
                table: "OrderItem",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_Admin_CreatedBy",
                table: "PaymentMethod",
                column: "CreatedBy",
                principalTable: "Admin",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductExportBill_StorageManager_StorageManagerId",
                table: "ProductExportBill",
                column: "StorageManagerId",
                principalTable: "StorageManager",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductExportDetail_ProductExportBill_ExportBillId",
                table: "ProductExportDetail",
                column: "ExportBillId",
                principalTable: "ProductExportBill",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductExportDetail_Products_ProductId",
                table: "ProductExportDetail",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFavorite_Customers_CustomerId",
                table: "ProductFavorite",
                column: "CustomerId",
                principalTable: "Customers",
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
                name: "FK_Rating_Customers_CustomerId",
                table: "Rating",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Products_ProductId",
                table: "Rating",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipment_Admin_CreatedBy",
                table: "Shipment",
                column: "CreatedBy",
                principalTable: "Admin",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipment_Order_OrderId",
                table: "Shipment",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipment_ProductExportBill_ProductExportBillId",
                table: "Shipment",
                column: "ProductExportBillId",
                principalTable: "ProductExportBill",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipment_Shipper_ShipperId",
                table: "Shipment",
                column: "ShipperId",
                principalTable: "Shipper",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipper_Admin_AdminId",
                table: "Shipper",
                column: "AdminId",
                principalTable: "Admin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipper_Users_UserId",
                table: "Shipper",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Storage_Admin_UserId",
                table: "Storage",
                column: "UserId",
                principalTable: "Admin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StorageManager_Storage_StorageId",
                table: "StorageManager",
                column: "StorageId",
                principalTable: "Storage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StorageManager_Users_UserId",
                table: "StorageManager",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierPayment_Admin_CreatedBy",
                table: "SupplierPayment",
                column: "CreatedBy",
                principalTable: "Admin",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierPayment_Supplier_SupplierId",
                table: "SupplierPayment",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyProduct_Products_ProductId",
                table: "SupplyProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyProduct_Supplier_SupplierId",
                table: "SupplyProduct",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyProduct_Users_UserId",
                table: "SupplyProduct",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
