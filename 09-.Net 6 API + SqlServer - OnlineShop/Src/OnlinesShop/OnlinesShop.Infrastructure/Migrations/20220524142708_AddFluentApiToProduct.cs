using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlinesShop.Infrastructure.Migrations
{
    public partial class AddFluentApiToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ASO_Products",
                schema: "ASO_BASE",
                table: "ASO_Products");

            migrationBuilder.RenameTable(
                name: "ASO_Products",
                schema: "ASO_BASE",
                newName: "ASO_*_Products");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "ASO_*_Products",
                newName: "Titleeeeee");

            migrationBuilder.AlterColumn<string>(
                name: "Titleeeeee",
                table: "ASO_*_Products",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ASO_*_Products",
                table: "ASO_*_Products",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ASO_*_Products",
                table: "ASO_*_Products");

            migrationBuilder.RenameTable(
                name: "ASO_*_Products",
                newName: "ASO_Products",
                newSchema: "ASO_BASE");

            migrationBuilder.RenameColumn(
                name: "Titleeeeee",
                schema: "ASO_BASE",
                table: "ASO_Products",
                newName: "ProductName");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                schema: "ASO_BASE",
                table: "ASO_Products",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ASO_Products",
                schema: "ASO_BASE",
                table: "ASO_Products",
                column: "Id");
        }
    }
}
