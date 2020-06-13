using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class Add_Field_IsPayed_To_Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPayed",
                table: "Orders",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(145), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(1542), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(1584), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(1587), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(5019), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(6386), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(2338), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3471), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3540), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3545), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3548), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3552), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3556), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3561), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3579), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3583), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3587), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3591), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3595), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3598), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3603), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3607), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3611), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3615), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3618), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3622), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3626), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3629), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3633), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3637), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3641), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3644), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3648), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3652), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3656), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3659), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3663), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3666), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3670), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3671) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3674), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3677), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3681), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3685), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3689), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3692), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3696), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3699), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3703), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3707), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3710), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3714), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3718), new DateTime(2020, 6, 14, 4, 19, 48, 357, DateTimeKind.Utc).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(4699), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6697), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6779), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6784), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6789), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6792), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6796), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6800), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6804), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6807), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6811), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6815), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6819), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6822), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6826), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6829), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6833), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6837), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6840), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6844), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6848), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6851), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6855), new DateTime(2020, 6, 14, 4, 19, 48, 356, DateTimeKind.Utc).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 353, DateTimeKind.Utc).AddTicks(6891), new DateTime(2020, 6, 14, 4, 19, 48, 353, DateTimeKind.Utc).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 353, DateTimeKind.Utc).AddTicks(8745), new DateTime(2020, 6, 14, 4, 19, 48, 353, DateTimeKind.Utc).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 353, DateTimeKind.Utc).AddTicks(8818), new DateTime(2020, 6, 14, 4, 19, 48, 353, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 353, DateTimeKind.Utc).AddTicks(8823), new DateTime(2020, 6, 14, 4, 19, 48, 353, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 4, 19, 48, 355, DateTimeKind.Utc).AddTicks(7546), new DateTime(2020, 6, 14, 4, 19, 48, 355, DateTimeKind.Utc).AddTicks(7961) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPayed",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(7218), new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(8936), new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(8981), new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(8985), new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(4906), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(6632), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(1900), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3211), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3249), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3255), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3259), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3262), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3267), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3270), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3275), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3278), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3282), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3286), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3290), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3294), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3298), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3302), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3320), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3324), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3328), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3332), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3336), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3340), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3344), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3348), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3352), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3356), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3360), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3364), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3368), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3372), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3376), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3380), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3384), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3388), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3393), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3397), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3401), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3405), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3409), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3412), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3416), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3420), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3424), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3428), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3432), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "ProductTiers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3436), new DateTime(2020, 6, 13, 15, 21, 56, 778, DateTimeKind.Utc).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(2813), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5027), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5091), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5096), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5103), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5107), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5112), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5113) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5116), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5120), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5125), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5129), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5133), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5137), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5141), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5146), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5150), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5154), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5159), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5163), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5167), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5171), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5175), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5179), new DateTime(2020, 6, 13, 15, 21, 56, 777, DateTimeKind.Utc).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 774, DateTimeKind.Utc).AddTicks(2883), new DateTime(2020, 6, 13, 15, 21, 56, 774, DateTimeKind.Utc).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 774, DateTimeKind.Utc).AddTicks(4286), new DateTime(2020, 6, 13, 15, 21, 56, 774, DateTimeKind.Utc).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 774, DateTimeKind.Utc).AddTicks(4374), new DateTime(2020, 6, 13, 15, 21, 56, 774, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 774, DateTimeKind.Utc).AddTicks(4378), new DateTime(2020, 6, 13, 15, 21, 56, 774, DateTimeKind.Utc).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(4274), new DateTime(2020, 6, 13, 15, 21, 56, 776, DateTimeKind.Utc).AddTicks(4754) });
        }
    }
}
