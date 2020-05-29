using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Core_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(nullable: true),
                    Size = table.Column<double>(nullable: false),
                    SizeUnit = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tiers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TierOption = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Managers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Token = table.Column<string>(nullable: false),
                    JwtId = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    IsUsed = table.Column<bool>(nullable: false),
                    IsValidated = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Token);
                    table.ForeignKey(
                        name: "FK_RefreshToken_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StorageManagers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StorageId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageManagers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StorageManagers_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StorageManagers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Admins_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Admins",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    NotificationTo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Admins_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Admins",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notifications_Users_NotificationTo",
                        column: x => x.NotificationTo,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Method = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_Admins_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Admins",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateTable(
                name: "RequestImportProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestImportProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestImportProducts_Admins_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Admins",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Shipper",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    IdentityId = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    AdminId = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipper", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shipper_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipper_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Ward = table.Column<string>(nullable: true),
                    StreetLocation = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    EntryPrice = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Origin = table.Column<string>(nullable: true),
                    ProductUnit = table.Column<int>(nullable: false),
                    PriceCurrency = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    StorageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Admins_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Admins",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ImportBills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalAmount = table.Column<double>(nullable: false),
                    Currency = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    RequestImportProductId = table.Column<int>(nullable: false),
                    StorageManagerId = table.Column<int>(nullable: false),
                    StorageId = table.Column<int>(nullable: false),
                    SupplierBillImageLocation = table.Column<string>(nullable: true),
                    StorageManagerBillImageLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportBills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImportBills_RequestImportProducts_RequestImportProductId",
                        column: x => x.RequestImportProductId,
                        principalTable: "RequestImportProducts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ImportBills_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ImportBills_StorageManagers_StorageManagerId",
                        column: x => x.StorageManagerId,
                        principalTable: "StorageManagers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ImportProductReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    NextImportTime = table.Column<DateTime>(nullable: false),
                    ReportImageLocation = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    RequestImportProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportProductReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImportProductReports_StorageManagers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "StorageManagers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ImportProductReports_RequestImportProducts_RequestImportProductId",
                        column: x => x.RequestImportProductId,
                        principalTable: "RequestImportProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderStatus = table.Column<int>(nullable: false),
                    TotalAmount = table.Column<double>(nullable: false),
                    Currency = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    IdealShipTime = table.Column<DateTime>(nullable: false),
                    IsGift = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    IsCustomerReceive = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImgLocation = table.Column<string>(nullable: true),
                    ImgName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductTiers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    TierId = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    PricePerKg = table.Column<double>(nullable: false),
                    SalePrice = table.Column<double>(nullable: false),
                    KgSale = table.Column<double>(nullable: false),
                    DiscountPercentage = table.Column<int>(nullable: false),
                    AfterDiscountPrice = table.Column<double>(nullable: false),
                    PriceCurrency = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTiers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTiers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductTiers_Tiers_TierId",
                        column: x => x.TierId,
                        principalTable: "Tiers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestExportProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestExportProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestExportProducts_Admins_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Admins",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestExportProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CartDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(nullable: false),
                    ProductTierId = table.Column<int>(nullable: false),
                    CartId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartDetails_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CartDetails_ProductTiers_ProductTierId",
                        column: x => x.ProductTierId,
                        principalTable: "ProductTiers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClassifyProductReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromTierId = table.Column<int>(nullable: false),
                    ToTierId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassifyProductReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassifyProductReports_StorageManagers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "StorageManagers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClassifyProductReports_ProductTiers_ToTierId",
                        column: x => x.ToTierId,
                        principalTable: "ProductTiers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ImportBillDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ImportBillId = table.Column<int>(nullable: false),
                    ProductTierId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportBillDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImportBillDetails_ImportBills_ImportBillId",
                        column: x => x.ImportBillId,
                        principalTable: "ImportBills",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ImportBillDetails_ProductTiers_ProductTierId",
                        column: x => x.ProductTierId,
                        principalTable: "ProductTiers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(nullable: false),
                    SinglePrice = table.Column<int>(nullable: false),
                    ProductTierId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItems_ProductTiers_ProductTierId",
                        column: x => x.ProductTierId,
                        principalTable: "ProductTiers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductFavorites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductTierId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFavorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFavorites_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductFavorites_ProductTiers_ProductTierId",
                        column: x => x.ProductTierId,
                        principalTable: "ProductTiers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StarNum = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Like = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ProductTierId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rates_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rates_ProductTiers_ProductTierId",
                        column: x => x.ProductTierId,
                        principalTable: "ProductTiers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RemoveProductQuantityReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    ProductTierId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemoveProductQuantityReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RemoveProductQuantityReports_StorageManagers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "StorageManagers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RemoveProductQuantityReports_ProductTiers_ProductTierId",
                        column: x => x.ProductTierId,
                        principalTable: "ProductTiers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestImportDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestImportProductId = table.Column<int>(nullable: false),
                    ProductTierId = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestImportDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestImportDetails_ProductTiers_ProductTierId",
                        column: x => x.ProductTierId,
                        principalTable: "ProductTiers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestImportDetails_RequestImportProducts_RequestImportProductId",
                        column: x => x.RequestImportProductId,
                        principalTable: "RequestImportProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductExportBills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    RequestExportProductId = table.Column<int>(nullable: false),
                    StorageManagerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductExportBills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductExportBills_RequestExportProducts_RequestExportProductId",
                        column: x => x.RequestExportProductId,
                        principalTable: "RequestExportProducts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductExportBills_StorageManagers_StorageManagerId",
                        column: x => x.StorageManagerId,
                        principalTable: "StorageManagers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestExportDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestExportProductId = table.Column<int>(nullable: false),
                    ProductTierId = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestExportDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestExportDetails_ProductTiers_ProductTierId",
                        column: x => x.ProductTierId,
                        principalTable: "ProductTiers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestExportDetails_RequestExportProducts_RequestExportProductId",
                        column: x => x.RequestExportProductId,
                        principalTable: "RequestExportProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductExportDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ExportBillId = table.Column<int>(nullable: false),
                    ProductTierId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductExportDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductExportDetails_ProductExportBills_ExportBillId",
                        column: x => x.ExportBillId,
                        principalTable: "ProductExportBills",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductExportDetails_ProductTiers_ProductTierId",
                        column: x => x.ProductTierId,
                        principalTable: "ProductTiers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Shipment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Ward = table.Column<string>(nullable: true),
                    StreetLocation = table.Column<string>(nullable: true),
                    ShippingCharge = table.Column<double>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    AdminId = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    ShipperId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ProductExportBillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shipment_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipment_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shipment_ProductExportBills_ProductExportBillId",
                        column: x => x.ProductExportBillId,
                        principalTable: "ProductExportBills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shipment_Shipper_ShipperId",
                        column: x => x.ShipperId,
                        principalTable: "Shipper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PaymentMethodId = table.Column<int>(nullable: false),
                    ShipmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoice_Shipment_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "RoleName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 31, 8, 24, 10, 236, DateTimeKind.Utc).AddTicks(4891), false, 0, new DateTime(2020, 5, 31, 8, 24, 10, 236, DateTimeKind.Utc).AddTicks(5381) },
                    { 2, new DateTime(2020, 5, 31, 8, 24, 10, 236, DateTimeKind.Utc).AddTicks(6169), false, 1, new DateTime(2020, 5, 31, 8, 24, 10, 236, DateTimeKind.Utc).AddTicks(6186) },
                    { 3, new DateTime(2020, 5, 31, 8, 24, 10, 236, DateTimeKind.Utc).AddTicks(6224), false, 2, new DateTime(2020, 5, 31, 8, 24, 10, 236, DateTimeKind.Utc).AddTicks(6226) },
                    { 4, new DateTime(2020, 5, 31, 8, 24, 10, 236, DateTimeKind.Utc).AddTicks(6228), false, 3, new DateTime(2020, 5, 31, 8, 24, 10, 236, DateTimeKind.Utc).AddTicks(6229) }
                });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Location", "Name", "Size", "SizeUnit", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2020, 5, 31, 8, 24, 10, 238, DateTimeKind.Utc).AddTicks(3249), false, "Tiểu Vương Quốc Bình Chánh", "Hoàng Khố", 1000.2, "m2", new DateTime(2020, 5, 31, 8, 24, 10, 238, DateTimeKind.Utc).AddTicks(3676) });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomerId",
                table: "Addresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_CartId",
                table: "CartDetails",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_ProductTierId",
                table: "CartDetails",
                column: "ProductTierId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CustomerId",
                table: "Carts",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CreatedBy",
                table: "Categories",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ClassifyProductReports_CreatedBy",
                table: "ClassifyProductReports",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ClassifyProductReports_ToTierId",
                table: "ClassifyProductReports",
                column: "ToTierId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ImportBillDetails_ImportBillId",
                table: "ImportBillDetails",
                column: "ImportBillId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportBillDetails_ProductTierId",
                table: "ImportBillDetails",
                column: "ProductTierId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportBills_RequestImportProductId",
                table: "ImportBills",
                column: "RequestImportProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportBills_StorageId",
                table: "ImportBills",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportBills_StorageManagerId",
                table: "ImportBills",
                column: "StorageManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportProductReports_CreatedBy",
                table: "ImportProductReports",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ImportProductReports_RequestImportProductId",
                table: "ImportProductReports",
                column: "RequestImportProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_PaymentMethodId",
                table: "Invoice",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_ShipmentId",
                table: "Invoice",
                column: "ShipmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Managers_UserId",
                table: "Managers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_CreatedBy",
                table: "Notifications",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_NotificationTo",
                table: "Notifications",
                column: "NotificationTo");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductTierId",
                table: "OrderItems",
                column: "ProductTierId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_CreatedBy",
                table: "PaymentMethods",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_AdminId",
                table: "Payments",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductExportBills_RequestExportProductId",
                table: "ProductExportBills",
                column: "RequestExportProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductExportBills_StorageManagerId",
                table: "ProductExportBills",
                column: "StorageManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductExportDetails_ExportBillId",
                table: "ProductExportDetails",
                column: "ExportBillId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductExportDetails_ProductTierId",
                table: "ProductExportDetails",
                column: "ProductTierId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFavorites_CustomerId",
                table: "ProductFavorites",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFavorites_ProductTierId",
                table: "ProductFavorites",
                column: "ProductTierId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CreatedBy",
                table: "Products",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StorageId",
                table: "Products",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTiers_ProductId",
                table: "ProductTiers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTiers_TierId",
                table: "ProductTiers",
                column: "TierId");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_CustomerId",
                table: "Rates",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_ProductTierId",
                table: "Rates",
                column: "ProductTierId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RemoveProductQuantityReports_CreatedBy",
                table: "RemoveProductQuantityReports",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RemoveProductQuantityReports_ProductTierId",
                table: "RemoveProductQuantityReports",
                column: "ProductTierId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestExportDetails_ProductTierId",
                table: "RequestExportDetails",
                column: "ProductTierId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestExportDetails_RequestExportProductId",
                table: "RequestExportDetails",
                column: "RequestExportProductId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestExportProducts_CreatedBy",
                table: "RequestExportProducts",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RequestExportProducts_OrderId",
                table: "RequestExportProducts",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequestImportDetails_ProductTierId",
                table: "RequestImportDetails",
                column: "ProductTierId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestImportDetails_RequestImportProductId",
                table: "RequestImportDetails",
                column: "RequestImportProductId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestImportProducts_CreatedBy",
                table: "RequestImportProducts",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_AdminId",
                table: "Shipment",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_OrderId",
                table: "Shipment",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_ProductExportBillId",
                table: "Shipment",
                column: "ProductExportBillId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_ShipperId",
                table: "Shipment",
                column: "ShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipper_AdminId",
                table: "Shipper",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipper_UserId",
                table: "Shipper",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StorageManagers_StorageId",
                table: "StorageManagers",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageManagers_UserId",
                table: "StorageManagers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartDetails");

            migrationBuilder.DropTable(
                name: "ClassifyProductReports");

            migrationBuilder.DropTable(
                name: "ImportBillDetails");

            migrationBuilder.DropTable(
                name: "ImportProductReports");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "ProductExportDetails");

            migrationBuilder.DropTable(
                name: "ProductFavorites");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "RemoveProductQuantityReports");

            migrationBuilder.DropTable(
                name: "RequestExportDetails");

            migrationBuilder.DropTable(
                name: "RequestImportDetails");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ImportBills");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Shipment");

            migrationBuilder.DropTable(
                name: "ProductTiers");

            migrationBuilder.DropTable(
                name: "RequestImportProducts");

            migrationBuilder.DropTable(
                name: "ProductExportBills");

            migrationBuilder.DropTable(
                name: "Shipper");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Tiers");

            migrationBuilder.DropTable(
                name: "RequestExportProducts");

            migrationBuilder.DropTable(
                name: "StorageManagers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
