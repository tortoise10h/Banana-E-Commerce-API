using Microsoft.EntityFrameworkCore.Migrations;

namespace Banana_E_Commerce_API.Migrations
{
    public partial class RemoveManagerRoleRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Role_Manager_CreatedBy",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Role_CreatedBy",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Role");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Role",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Role_CreatedBy",
                table: "Role",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Role_Manager_CreatedBy",
                table: "Role",
                column: "CreatedBy",
                principalTable: "Manager",
                principalColumn: "Id");
        }
    }
}
