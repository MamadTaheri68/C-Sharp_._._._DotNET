using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_TestProject.Migrations
{
    public partial class AlterTableNameOfProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.EnsureSchema(
                name: "ASO_SHOP");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "MyProducts",
                newSchema: "ASO_SHOP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyProducts",
                schema: "ASO_SHOP",
                table: "MyProducts",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyProducts",
                schema: "ASO_SHOP",
                table: "MyProducts");

            migrationBuilder.RenameTable(
                name: "MyProducts",
                schema: "ASO_SHOP",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");
        }
    }
}
